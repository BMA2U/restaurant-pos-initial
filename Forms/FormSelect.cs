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
    public partial class FormSelect : Form
    {
        public FormSelect(string _selectTxt, string s)
        {
            InitializeComponent();
            selectTxt = _selectTxt;
            if (s == "FormCategories")
            {
                lblDes.Text = "Des";
                dgvItems.Columns["ColDes"].HeaderText = "Des";

            }

        }
        private DataTable dt;
        private SqlDataAdapter adapter;
        public string selectTxt { get; set; }
        public string des { get; set; }
        public string result { get; set; }
        private void txtDes_KeyUp(object sender, KeyEventArgs e)
        {
            loadSelect();
        }
        private void loadSelect()
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = des + " LIKE '%" + txtDes.Text + "%'";
            dv.Sort = "ID ASC"; // أو DESC للترتيب التنازلي

            dgvItems.Rows.Clear();

            foreach (DataRowView drv in dv)
            {
                dgvItems.Rows.Add(new object[]
                {
                    drv["ID"],
                    drv[des]
                });
            }

        }
        private void FormSelect_Load(object sender, EventArgs e)
        {

            adapter = new SqlDataAdapter(selectTxt, adoClass.sqlCn);
            dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                loadSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItems.Rows.Count != 0)
            {
                result = dgvItems[ColID.Index, dgvItems.CurrentRow.Index].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormSelect_Shown(object sender, EventArgs e)
        {
            txtDes.Focus();
        }


    }
}
