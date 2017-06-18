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
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            
            string CSVpath = "../../data"; // CSV file Path
            var AllFiles = new DirectoryInfo(CSVpath).GetFiles("*.CSV");
            foreach (var file in AllFiles) //read all CSV file
            {
                string fullFileName = "../../data/" + file.Name;
                try
                {
                    dataGridView1.DataSource = ReadCsv(fullFileName);
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
    }
}
