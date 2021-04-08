using combo_pro.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combo_pro
{
    public partial class frmComboPro : Form
    {
        List<String> Departments = new List<String>
                        { "Computer",
                          "Control",
                          "Communication"
                        };
                                      
        public frmComboPro()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            String name = ((String) txtName.Text).Trim();

            if (name.Length != 0)
            {
                cmbNames.Items.Add(name);
                txtName.Clear();
            }
        }

        private void FrmComboPro_Load(object sender, EventArgs e)
        {
            cmbNames.DropDownStyle = ComboBoxStyle.DropDownList;

            var bindingSource = new BindingSource();
            bindingSource.DataSource = Departments;
            cmbDepartment.DataSource = bindingSource;

            

        }

        private void AddCountry_Click(object sender, EventArgs e)
        {
            cmbCountry.DisplayMember = "Name";
            cmbCountry.ValueMember = "Key";

            cmbCountry.Items.Add(new Country(txtCountry.Text, 
                                            txtKey.Text));
            txtCountry.Clear();
            txtKey.Clear();
        }

        private void CmbCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCountry.Items.Count > 0) { 
                Country country = (Country) cmbCountry.SelectedItem;
                txtCountry.Text = country.Name;
                txtKey.Text = country.Key;
            }

        }

        private void CmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelected.Text = cmbDepartment.Text;
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            frmEmployee emp = new frmEmployee();
            emp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            cmbNames.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCountry.Text = string.Empty;
            txtKey.Text = string.Empty;
            cmbCountry.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtSelected.Text , txtName.Text , txtCountry.Text );
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtSelected.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtCountry.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                
            }
        }
    }
}
