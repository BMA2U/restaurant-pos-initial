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
        public FormSelect(string _selectTxt)
        {
            InitializeComponent();
            selectTxt = _selectTxt;

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
            DataRow[] rows = dt.Select(des + " LIKE '%'+'" + txtDes.Text + "'+'%' ");
            dgvItems.Rows.Clear();
            for (int i = 0; i <= rows.Length - 1; i++)
            {
                dgvItems.Rows.Add(new object[]{
                    rows[i][0],
                    rows[i][des]
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadSelect();

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
