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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RE333BER
{
    public partial class FormMenu : Form
    {
        private string signinUsername;
        private int numOfDeck;
        private static List<DataTable> deckList = new List<DataTable>();
        public FormMenu(string signinUsername)
        {
            this.signinUsername = signinUsername;
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            
            // CSV file Path
            string CSVpath = "../../data/" + signinUsername;
            
            // If a folder does not exist then create it, else ignore
            System.IO.Directory.CreateDirectory(CSVpath);
            
            // Read all CSV in this folder
            var AllFiles = new DirectoryInfo(CSVpath).GetFiles("*.CSV");
            numOfDeck = AllFiles.Count();
            
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
                    checkedListBoxDeckView.Items.Add(file.Name);
                    dataGridView1.DataSource = dtTmp;
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
            using (OleDbConnection cn = new OleDbConnection(
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" +
                    Path.GetDirectoryName(filename) + "\";Extended Properties=\'text;HDR=Yes;FMT=Delimited(,)';"))
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
            for(int i = 0; i < checkedListBoxDeckView.Items.Count; i++)
            {
                if (checkedListBoxDeckView.GetItemChecked(i))
                {
                    dataGridView1.DataSource = deckList.ElementAt(i);
                }
            }
        }
    }
}
