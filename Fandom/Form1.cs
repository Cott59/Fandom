using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initDB();
        }
        private void initDB()
        {
            DBWork.FillQueryes();
            DBWork.MakeQuery();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            //DataSet ds = DataProcesing.AddData();
            //dgrTable.DataSource = DataProcesing.AddData().Tables[0];
            dgrTable.DataSource = DataProcesing.GetDBData().Tables[0];
            dgrTable.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (!dgrTable.DataSource.Equals(null))
            {
                dt = (DataTable)dgrTable.DataSource;
                DataProcesing.SaveData2DB(dt);
            }
            
        }

        private void btnTablesView_Click(object sender, EventArgs e)
        {
            string query = "SELECT name FROM sqlite_master WHERE type='table';";
            string tables = string.Empty;
            List<string> _lstTables = DBWork.GetDataBySelect(query);
            int counter = 0;
            int _number = 0;
            foreach (string table_name in _lstTables)
            {
                if (!table_name.Contains("sqlite_"))
                {
                    tables += table_name + "\r\n";
                }
                else
                {
                    _number = counter;
                }
                counter++;
            }
            _lstTables.RemoveAt(_number);
            lstBoxTables.DataSource = _lstTables;
            MessageBox.Show($"БД содержит таблицы:\r\n{tables}");
        }
    }
}
