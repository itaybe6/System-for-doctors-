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
    public partial class patient_excel : Form
    {
        public patient_excel()
        {
            InitializeComponent();
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

        private void btn_bloodTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            blood_tets form = new blood_tets();
            form.ShowDialog();
        }

        private void patient_excel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_path.Text = dlg.FileName;
            }
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        //enter botton to import excel
        private void button1_Click(object sender, EventArgs e)
        {
            ReadWriteExcel.updateExcelPathForBtest(txt_path.Text);
            ReadWriteExcel.importExcelBtest(txt_id.Text);
        }
    }
}
