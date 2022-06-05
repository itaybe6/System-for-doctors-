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
    public partial class blood_tets : Form
    {
        public blood_tets()
        {
            InitializeComponent();
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

        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_patient form = new add_patient();
            form.ShowDialog();
        }

        private void blood_tets_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_enterDetails_Click(object sender, EventArgs e)
        {
            string[] bloodTestData = {txt_ID.Text,txt_WBC.Text,txt_neut.Text,txt_lymph.Text,txt_rbc.Text,txt_htc.Text,txt_urea.Text,txt_hb.Text,txt_crtn.Text,txt_iron.Text,txt_hdl.Text,txt_ap.Text};
            ReadWriteExcel.addBloodTest(bloodTestData);
            clearBloodTest();
        }

        private void clearBloodTest()
        {
            txt_ap.Clear();
            txt_crtn.Clear();
            txt_hb.Clear();
            txt_hdl.Clear();
            txt_htc.Clear();
            txt_ID.Clear(); 
            txt_iron.Clear();   
            txt_lymph.Clear();
            txt_neut.Clear();
            txt_rbc.Clear();
            txt_urea.Clear();
            txt_WBC.Clear();





        }
    }
}
