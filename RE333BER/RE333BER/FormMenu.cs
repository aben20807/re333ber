using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RE333BER
{
    public partial class FormMenu : Form
    {
        private string signinUsername;
        private static List<DataTable> deckList = new List<DataTable>();
        private static List<string> question = new List<string>();
        private static List<string> answer = new List<string>();
        private DataTable clearDataTable = new DataTable();
        private DataTable viewDataTable = new DataTable();
        private string CSVpath;
        public FormMenu(string signinUsername)
        {
            this.signinUsername = signinUsername;
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            deckBindingSource.DataSource = new List<Deck>();
            //string[][] Array = new string[10][];
            //for (int i = 0; i < 10; i++) // Set some values to test
            //    Array[i] = new string[2] { "Value 1", "Value 2" };

            //dataGridView1.DataSource = (from arr in Array select new { Col1 = arr[0], Col2 = arr[1] });


            // CSV file Path
            CSVpath = "../../data/" + signinUsername;
            
            // If a folder does not exist then create it, else ignore
            System.IO.Directory.CreateDirectory(CSVpath);
            
            // Read all CSV in this folder
            var AllFiles = new DirectoryInfo(CSVpath).GetFiles("*.CSV");
            
            // init List
            deckList.Clear();
            checkedListBoxDeckView.Items.Clear();
            foreach (var file in AllFiles) // open and read all CSV file
            {
                string fullFileName = CSVpath + "/" + file.Name;
                try
                {
                    DataTable dtTmp = ReadCsv(fullFileName);
                    deckList.Add(dtTmp);
                    checkedListBoxDeckView.Items.Add(Path.GetFileNameWithoutExtension(fullFileName));
                    //dataGridView1.DataSource = dtTmp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+ "\nFull File Name:" + fullFileName, "Warning!"+ file.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public DataTable ReadCsv(string filename)
        {
            DataTable dt = new DataTable("Data");

            dt.Columns.Add("CardLabel1", typeof(string));
            dt.Columns.Add("CardLabel2", typeof(string));

            using (OleDbConnection cn = new OleDbConnection(
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" +
                    Path.GetDirectoryName(filename) + "\";Extended Properties='text;HDR=yes;IMEX=1;FMT=Delimited(,)';"))
            {
                using (OleDbCommand cmd = new OleDbCommand(string.Format("select * from [{0}]", new FileInfo(filename).Name), cn))
                {
                    cn.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        private void checkedListBoxDeckView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectCount = 0;
            DataTable dtTmp = new DataTable("Data"); ;
            for (int i = 0; i < checkedListBoxDeckView.Items.Count; i++)
            {
                if (checkedListBoxDeckView.GetItemChecked(i))
                {
                    dtTmp.Merge(deckList.ElementAt(i));
                    selectCount++;
                }
            }
            if(selectCount == 0)
            {
                dataGridView1.DataSource = clearDataTable;
            }
            else
            {
                dataGridView1.DataSource = dtTmp;
                viewDataTable = dtTmp;
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        DataTable dtTmp = ReadCsv(ofd.FileName);
                        deckList.Add(dtTmp);
                        checkedListBoxDeckView.Items.Add(Path.GetFileNameWithoutExtension(ofd.FileName));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\ncannot import", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxDeckView.Items.Count; i++)
            {
                if (checkedListBoxDeckView.GetItemChecked(i))
                {
                    deckList.RemoveAt(i);
                    checkedListBoxDeckView.Items.RemoveAt(i);
                    i--;
                }
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            ////DataRow[] foundRows;
            //DataTable dtSearch = viewDataTable;
            //dtSearch.DefaultView.RowFilter = ("TimeStamp < 5");
            //dataGridView1.DataSource = dtSearch;

            ////for (int i = 0; i < foundRows.Length; i++)
            ////{
            ////    Console.WriteLine(foundRows[i][0]);
            ////}
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int viewNumOfCard = 0;
            if (comboBoxNumOfCard.Text == "全部")
            {
                viewNumOfCard = viewDataTable.Rows.Count;
            }
            else // number = all select deck
            {
                if (!(Int32.TryParse(comboBoxNumOfCard.Text, out viewNumOfCard)))
                {// if can not let string transfer to int then show messagebox
                    MessageBox.Show("String could not be parsed.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Select cards to review
                    DataTable dtTmp = new DataTable();
                    if (viewDataTable.Rows.Count < viewNumOfCard)
                    {// if viewNumOfCard is too many that viewDataTable not contain
                        viewNumOfCard = viewDataTable.Rows.Count;
                    }
                    // Sort selected decks
                    DataView dv = new DataView();
                    dv.Table = viewDataTable;
                    dv.Sort = "TimeStamp ASC";
                    DataTable dtSort = dv.ToTable();

                    // Copy the smaller timestamp to view
                    dtTmp = dtSort.Clone();
                    for (int i = 0; i < viewNumOfCard; i++)
                    {
                        DataRow row = dtSort.Rows[i];
                        int rowTimestamp = 0;
                        //Console.WriteLine(Int32.TryParse(row["TimeStamp"].ToString(), out rowTimestamp));
                        Int32.TryParse(row["TimeStamp"].ToString(), out rowTimestamp);
                        //Console.WriteLine(rowTimestamp);
                        row["TimeStamp"] = rowTimestamp + 1;
                        dtTmp.ImportRow(row);
                    }
                    //show
                    //deckBindingSource.DataSource = dtTmp;
                    dataGridView1.DataSource = dtTmp;

                    string filename = "";
                    for(int i = 0; i < checkedListBoxDeckView.Items.Count; i++)
                    {
                        if (checkedListBoxDeckView.GetItemChecked(i))
                        {
                            filename = checkedListBoxDeckView.GetItemText(checkedListBoxDeckView.Items[i]);
                            checkedListBoxDeckView.Items.RemoveAt(i);
                            deckList.RemoveAt(i);
                            break;
                        }
                    }
                    StringBuilder sb = new StringBuilder();
                    IEnumerable<string> columnNames = dtTmp.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                    sb.AppendLine(string.Join(",", columnNames));

                    foreach(DataRow row1 in viewDataTable.Rows)
                    {
                        foreach(DataRow row2 in dtTmp.Rows)
                        {
                            IEnumerable<string> fields1 = row1.ItemArray.Select(field => field.ToString());
                            IEnumerable<string> fields2 = row2.ItemArray.Select(field => field.ToString());
                            if(fields1.ElementAt(0) == fields2.ElementAt(0) &&
                                fields1.ElementAt(1) == fields2.ElementAt(1))
                            {
                                row1["TimeStamp"] = row2["TimeStamp"];
                            }
                        }
                    }
                    
                    foreach (DataRow row in viewDataTable.Rows)
                    {
                        //IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                        //sb.AppendLine(string.Join(",", fields));
                        IEnumerable<string> fields = row.ItemArray.Select(field =>
                            string.Concat("\"", field.ToString().Replace("\"", "\"\""), "\""));
                        sb.AppendLine(string.Join(",", fields));
                    }
                    File.WriteAllText(CSVpath + "/" + filename + ".csv", sb.ToString(), Encoding.GetEncoding(950));

                    DataTable dtTmpNew = ReadCsv(CSVpath + "/" + filename + ".csv");
                    deckList.Add(dtTmpNew);
                    checkedListBoxDeckView.Items.Add(filename);

                    StringBuilder sb1 = new StringBuilder();
                    //    IEnumerable<string> columnNames = dtTmp.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                    //     sb.AppendLine(string.Join(",",columnNames));
                    foreach (DataRow row in dtTmp.Rows)
                    {
                        IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                        question.Add(fields.ElementAt(0));
                        answer.Add(fields.ElementAt(1));
                        sb1.AppendLine(string.Join(",", fields.ElementAt(1)));
                    }
                    File.WriteAllText("test.csv", sb1.ToString());
                    FormCard card = new FormCard(question, answer);
                    question.Clear();
                    answer.Clear();
                    card.Show();
                }
            }
        }

        private void checkedListBoxDeckView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBoxDeckView.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBoxDeckView.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        this.checkedListBoxDeckView.SetItemCheckState(i,
                        System.Windows.Forms.CheckState.Unchecked);
                    }
                }
            }
        }
    }
}
