using bts_gsb.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bts_gsb.Forms
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();

            MedicineDAO medicineDAO = new MedicineDAO();
            List<Medicine> medicines = medicineDAO.GetAll();

            this.dataGridViewDoctorListMedicine.DataSource = medicines;
        }

        private void logOutButton_click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
