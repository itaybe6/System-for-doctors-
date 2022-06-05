using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_excelParient_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient_excel form = new patient_excel();
            form.ShowDialog();
        }

        //for the option to close from the form2
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_BloodTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            blood_tets form = new blood_tets();
            form.ShowDialog();
        }

        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_patient form = new add_patient();
            form.ShowDialog();
        }

        private void btn_diagnosis_Click(object sender, EventArgs e)
        {
            this.Hide();
            diagnosis_treatment form = new diagnosis_treatment();
            form.ShowDialog();
        }

       
    }
}
