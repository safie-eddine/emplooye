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
    public partial class frmEmployee : Form
    {
        
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtid.Text);
            String name = txtName.Text;
            float salary = float.Parse(txtSalary.Text);

            Employee emp = new Employee(id, name, salary);
            lstEmployee.DisplayMember = "name";
            lstEmployee.ValueMember = "id";

            lstEmployee.Items.Add(emp);
            txtid.Clear();
            txtName.Clear();
            txtSalary.Clear();

        }

        private void LstEmployee_DoubleClick(object sender, EventArgs e)
        {
            Employee emp = (Employee) lstEmployee.SelectedItem;

            txtid.Text = emp.id.ToString();
            txtName.Text = emp.name;
            txtSalary.Text = emp.salary.ToString();

        }

        //private void LstEmployee_SelectedIndexChanged(object sender, EventArgs e) { }
 

 
    }
}
