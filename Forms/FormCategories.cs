using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPOS.Forms
{
    public partial class FormCategories : Form
    {
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataRow Row;
        private int index;
        public FormCategories()
        {
            InitializeComponent();
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * from Categories", adoClass.sqlCn);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            index = 0;
            loadData(0);
        }
        private void loadDataWithIndex(int _index)
        {
            index = _index;
            if (dataTable.Rows.Count > 0 && _index >= 0 && _index <= dataTable.Rows.Count - 1)
            {
                txtDes.Text = dataTable.Rows[_index]["Des"].ToString();
                Row = dataTable.Rows[_index];
            }
        }
        private void loadData(int ID)
        {
            DataRow[] dataRows = null;
            if (ID == 0)
            {
                dataRows = dataTable.Select();
            }
            else
            {
                dataRows = dataTable.Select("ID = '" + ID + "'");
            }
            if (dataRows.Length > 0)
            {
                Row = dataRows[0];
                txtDes.Text = Row["Des"].ToString();
            }
        }

        private void sBtnNew_Click(object sender, EventArgs e)
        {
            Row = null;
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                    ctr.Text = String.Empty;
            }
            txtDes.Focus();
        }

        private void sBtnSave_Click(object sender, EventArgs e)
        {
            if (txtDes.Text == String.Empty)
            {
                MessageBox.Show("Enter the user name");
                txtDes.Focus();
                return;
            }
            saveData();
        }
        private void saveData()
        {
            if (Row == null)
            {
                Row = dataTable.NewRow();
                dataFillRow();
                dataTable.Rows.Add(Row);
            }
            else
            {
                Row.BeginEdit();
                dataFillRow();
                Row.EndEdit();
            }
            try
            {
                adoClass.builder = new SqlCommandBuilder(adapter);
                adapter.Update(dataTable);
                MessageBox.Show("Data has been updated 👍");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataFillRow()
        {
            Row["Des"] = txtDes.Text;
        }

        private void sBtnFirst_Click(object sender, EventArgs e)
        {
            loadDataWithIndex(0);
        }

        private void sBtnBack_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                loadDataWithIndex(index);
            }
        }

        private void sBtnNext_Click(object sender, EventArgs e)
        {
            if (index < dataTable.Rows.Count - 1)
            {
                index++;
                loadDataWithIndex(index);
            }
        }

        private void sBtnLast_Click(object sender, EventArgs e)
        {
            loadDataWithIndex(dataTable.Rows.Count - 1);
        }

        private void sBtnSelect_Click(object sender, EventArgs e)
        {
            FormSelect select = new FormSelect("Select ID,Des From Categories", "FormCategories");
            select.des = "Des";
            if (select.ShowDialog() == DialogResult.OK)
                loadData(int.Parse(select.result));
        }
    }
}
