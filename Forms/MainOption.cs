using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SmartPOS.Forms
{
    public partial class MainOption : Form
    {
        public MainOption()
        {
            InitializeComponent();
        }
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataRow Row;
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainOption_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select Top 1 * From Options", adoClass.sqlCn);
            dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    Row = dataTable.Rows[0];
                    txtRestName.Text = Row["RestName"].ToString();
                    txtRestAddress1.Text = Row["RestAddress1"].ToString();
                    txtRestAddress2.Text = Row["RestAddress2"].ToString();
                    txtPhone.Text = Row["Telephone"].ToString();
                    txtPrinter.Text = Row["PrinterName"].ToString();
                    txtReceiptLine1.Text = Row["ReceiptLine1"].ToString();
                    txtReceiptLine2.Text = Row["ReceiptLine2"].ToString();
                    if (Row["logo"] != DBNull.Value)
                        pictureBox1.BackgroundImage = Classes.Helper.ByteToImage(Row["logo"]);

                }
                else
                {
                    Row = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save New Data", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                SaveData();
        }
        private void SaveData()
        {
            if (txtRestName.Text == String.Empty)
            {
                MessageBox.Show("Place Enter the Restaurant name");
                txtRestName.Focus();
                return;
            }
            if (txtPhone.Text == String.Empty)
            {
                MessageBox.Show("Please enter the phone number");
                txtPhone.Focus();
                return;
            }
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
            Row["RestName"] = txtRestName.Text;
            Row["RestAddress1"] = txtRestAddress1.Text;
            Row["RestAddress2"] = txtReceiptLine2.Text;
            Row["Telephone"] = txtPhone.Text;
            Row["PrinterName"] = txtPrinter.Text;
            Row["ReceiptLine1"] = txtReceiptLine1.Text;
            Row["ReceiptLine2"] = txtReceiptLine2.Text;
            if (pictureBox1.BackgroundImage != null)
            {
                Row["logo"] = Classes.Helper.ImageToByte(pictureBox1.BackgroundImage);
            }
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Images|*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPic.Text = fileDialog.FileName;
                pictureBox1.BackgroundImage = new Bitmap(txtPic.Text);

            }

        }
    }
}
