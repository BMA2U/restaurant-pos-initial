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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataRow Row;
        private int index;
        private void sBtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * from Users", adoClass.sqlCn);
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
                txtUserName.Text = dataTable.Rows[_index]["UserName"].ToString();
                txtPhone.Text = dataTable.Rows[_index]["Phone"].ToString();
                txtPassword.Text = dataTable.Rows[_index]["Password"].ToString();
                txtJobDes.Text = dataTable.Rows[_index]["JobDes"].ToString();
                txtFullName.Text = dataTable.Rows[_index]["FullName"].ToString();
                txtEmail.Text = dataTable.Rows[_index]["Email"].ToString();
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
                txtUserName.Text = dataRows[0]["UserName"].ToString();
                txtPhone.Text = dataRows[0]["Phone"].ToString();
                txtPassword.Text = dataRows[0]["Password"].ToString();
                txtJobDes.Text = dataRows[0]["JobDes"].ToString();
                txtFullName.Text = dataRows[0]["FullName"].ToString();
                txtEmail.Text = dataRows[0]["Email"].ToString();
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
            txtUserName.Focus();
        }

        private void sBtnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == String.Empty)
            {
                MessageBox.Show("Enter the user name");
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text == String.Empty)
            {
                MessageBox.Show("Enter the password");
                txtPassword.Focus();
                return;
            }
            if (txtFullName.Text == String.Empty)
            {
                MessageBox.Show("Enter the full name");
                txtFullName.Focus();
                return;
            }
            if (txtPhone.Text == String.Empty)
            {
                MessageBox.Show("Enter the phone Number");
                txtPhone.Focus();
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
            Row["UserName"] = txtUserName.Text;
            Row["FullName"] = txtFullName.Text;
            Row["Email"] = txtEmail.Text;
            Row["Phone"] = txtPhone.Text;
            Row["JobDes"] = txtJobDes.Text;
            Row["Password"] = txtPassword.Text;
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
            FormSelect select = new FormSelect("Select ID, FullName From Users");
            select.des = "FullName";
            if (select.ShowDialog() == DialogResult.OK)
                loadData(int.Parse(select.result));

        }
    }
}
