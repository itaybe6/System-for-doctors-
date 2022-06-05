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
    public partial class add_patient : Form
    {
        public add_patient()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //send to write in excel function
        private void btn_enterDetails_Click(object sender, EventArgs e)
        {
            ReadWriteExcel.addPatient(txt_firstName.Text,txt_lastName.Text, txt_ID.Text, txt_age.Text, Gender.Text, txt_wigth.Text, txt_higth.Text,cmb_diarrhea.Text,cmb_smoking.Text,cmb_pregnent.Text,cmb_ethiopian.Text,cmb_oriental.Text);
            clearAddPatient();
        }

        //clear the text box 
        private void clearAddPatient()
        {
            txt_firstName.Clear();
            txt_lastName.Clear();
            txt_age.Clear();
            txt_higth.Clear();
            txt_wigth.Clear();
            txt_ID.Clear();
            cmb_diarrhea.ResetText();
            cmb_smoking.ResetText();
            cmb_pregnent.ResetText();
            cmb_ethiopian.ResetText();
            cmb_oriental.ResetText();   
            Gender.ResetText(); 


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void add_patient_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_bloodTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            blood_tets form = new blood_tets();
            form.ShowDialog();
        }

        private void smoking_Enter(object sender, EventArgs e)
        {

        }

        private void btn_excelParient_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient_excel form = new patient_excel();
            form.ShowDialog();
        }

        private void btn_diagnosis_Click(object sender, EventArgs e)
        {
            this.Hide();
            diagnosis_treatment form = new diagnosis_treatment();
            form.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
