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
    public partial class diagnosis_treatment : Form
    {
        public diagnosis_treatment()
        {
            InitializeComponent();
        }

        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_patient form = new add_patient();
            form.ShowDialog();
        }

        private void btn_excelParient_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient_excel form = new patient_excel();
            form.ShowDialog();
        }

        private void btn_questionnaire_Click(object sender, EventArgs e)
        {
            this.Hide();
            blood_tets form = new blood_tets();
            form.ShowDialog();
        }

        private void diagnosis_treatment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_diag_Click(object sender, EventArgs e)
        {
            // get blood test questionnaire and the acording the id
            float[] Btest = ReadWriteExcel.getBloodTest(txt_ID.Text);
            if(Btest[0] == 0)
            {
                MessageBox.Show("It is impossible to get a distinction without raising the results of blood tests");
                return;
            }

            string[] Questionnaire = ReadWriteExcel.getQuestionnaire(txt_ID.Text);
            // get age and gender acording the id
            string gender = ReadWriteExcel.getGender(txt_ID.Text);
            int age = ReadWriteExcel.getAge(txt_ID.Text);

            // "anemia", "diet", "bleeding", "Hyperlipidemia", "Blood clotting disorder", "Hematological disorder", "Iron poisoning", "Dehydration", "Infection", "Vitamin deficiency", "Viral disease" , "Diseases of the biliary tract", "heart diseases", "Blood disease", "Liver disease", "Kidney disease" , "Iron deficiency", "Muscle diseases" ,"Smoker", "Lung disease", "Overactive thyroid gland" , "Adult diabetes" , "cancer", "Increased consumption of meat", "Use of various medications" , "Malnutrition" };
            bool[] diseases_bool = new bool[26];


            //anemia
            if (Btest[3] < 4.5 || gender == "male" && Btest[4] < 37 || gender == "female" && Btest[4] < 33 || age >= 0 && age <= 17 && Btest[6] <11.5 || age >= 18 && Btest[6] < 12)
                diseases_bool[0] = true;
            

            //diet
            if((Questionnaire[4] == "Yes" && ( Btest[5] > 47.3 || (Btest[5] < 18.7 && Questionnaire[2] == "No"))) || (Questionnaire[4] == "No" && ( Btest[5] > 43 || (Btest[5] < 17 && Questionnaire[2] == "No" ))) || gender == "male" && Btest[8] < 60  || gender == "female" && Btest[8] < 48)
                diseases_bool[1] = true;
            

            //blooding
            if(gender == "female" && Btest[4] < 33 || gender == "male" && Btest[4] < 37 || age <= 17 && Btest[6] < 11.5  || age >= 18 && Btest[6] < 12 || Btest[3] < 4.5 || gender == "male" && Btest[8] < 60  || gender == "female" && Btest[8] < 48)
                diseases_bool[2] = true;
            

            //Hyperlipidemia
            if(gender == "male" && ( (Questionnaire[3] == "Yes" && Btest[9] < 34.8 )|| Btest[9] < 29) || gender == "female" && ((Questionnaire[3] == "Yes" && Btest[9] < 40.8)|| Btest[9] < 34))
                diseases_bool[3] = true;
            

            //Blood clotting disorder
            if(Btest[1] < 28 || Btest[2] < 36 || Btest[3] > 6)
                diseases_bool[4] = true;
            

            //Hematological disorder
            if(age <= 17 && Btest[6] < 11.5 || age >=  18 && Btest[6] < 12)
                diseases_bool[5] = true;
            

            //Iron poisoning
            if(gender == "male" && Btest[8] > 160 || gender == "female" && Btest[8] > 128)
                diseases_bool[6] = true;
            

            //Dehydration
            if(Questionnaire[4] == "Yes" && Btest[5] > 47.3 || Questionnaire[4] == "No" && Btest[5] > 43)
                diseases_bool[7] = true;
            

            //Infection
            if(age <= 3 && Btest[0] > 17500 || age <= 17 && age >= 4  && Btest[0] > 15500  || age >= 18 && Btest[0] > 11000 || Btest[1] > 54 || Btest[1] < 28  || Btest[2] < 52)
                diseases_bool[8] = true;
            

            //Vitamin deficiency
            if(Questionnaire[4] == "Yes" && Btest[10] < 60 && Questionnaire[4] == "No" && Btest[10] < 30)
                diseases_bool[9] = true;
            

            //Viral disease
            if((Questionnaire[0] == "No" &&( age <= 2 && Btest[7] > 0.5 ||  age <= 59 && age >= 3 && Btest[7] > 1 ||  age >= 60 && Btest[7] > 1.2)) ||  age <= 3 && Btest[0] < 6000 || age <= 17 && age >= 4 && Btest[0] < 5500 ||  age >= 18 && Btest[0] < 4500)
                diseases_bool[10] = true;
            

            //Diseases of the biliary tract
            if(Questionnaire[4] == "Yes" && Questionnaire[2] == "No" && Btest[10] > 120 || Questionnaire[4] == "No" && Questionnaire[2] == "No" && Btest[10] > 90)
                diseases_bool[11] = true;
            

            //heart diseases
            if (gender == "male" && ((Questionnaire[3] == "Yes" && Btest[9] < 34.8)|| Btest[9] < 29) || gender == "female" && ((Questionnaire[3] == "Yes" && Btest[9] < 40.8)|| Btest[9] < 34))
                diseases_bool[12] = true;
            

            //Blood disease
            if(age <= 3 && Btest[0] > 17500 || age <= 17 && age >= 4 && Btest[0] > 15500 ||  age >= 18 && Btest[0] > 11000)
                diseases_bool[13] = true;
            

            //Liver disease
            if ((Questionnaire[4] == "Yes" && ((Btest[10] > 120 || Btest[5] < 18.7 && Questionnaire[2] == "No"))) || (Questionnaire[4] == "No" &&( Btest[10] > 90 || Btest[5] < 17 && Questionnaire[2] == "No")))
                diseases_bool[14] = true;
            

            //Kidney disease
            if (Questionnaire[4] == "Yes" && Btest[5] > 47.3 || Questionnaire[4] == "No" && Btest[5] > 43 || (Questionnaire[0] == "No" && (age <= 2 && Btest[7] > 0.5 ||  age <= 59 && age >= 3 && Btest[7] > 1 ||  age >= 60 && Btest[7] > 1.2)))
                diseases_bool[15] = true;
            

            //Iron deficiency
            if(age <= 17 && Btest[6] < 11.5 || age >=  18 && Btest[6] < 12)
                diseases_bool[16] = true;
            

            //Muscle diseases
            if(age <= 2 && Btest[7] < 0.2 ||  age <= 17 && age >= 3 && Btest[7] < 0.5 ||  age >= 18 && Btest[7] < 0.6 )
                diseases_bool[17] = true;
            

            //Smokers
            if(gender == "female" && Btest[4] > 47 || gender == "male" && Btest[4] > 54 || Btest[3] > 6)
                diseases_bool[18] = true;
            

            //Lung disease
            if(Btest[3] > 6)
                diseases_bool[19] = true;
            

            //Overactive thyroid gland
            if ((Questionnaire[4] == "Yes" && Btest[10] > 120 && Questionnaire[2] == "No") || (Questionnaire[4] == "No" && Btest[10] > 90 && Questionnaire[2] == "No"))
               diseases_bool[20] = true;


            //Adult diabetes
            if (gender == "male" && ((Questionnaire[3] == "Yes" && Btest[9] < 34.8)|| Btest[9] < 29) || gender == "female" && ((Questionnaire[3] == "Yes" && Btest[9] < 40.8)|| Btest[9] < 34))  
                diseases_bool[21] = true;


            //cancer
            if (age <= 3 && (Btest[0] > 17500 || Btest[0] < 6000)  || age <= 17 && age >= 4 && (Btest[0] > 15500  || Btest[0] < 5500 ) ||  age >= 18 && (Btest[0] > 11000 || Btest[0] < 4500) || Btest[1] < 28 || Btest[2] > 52)
                diseases_bool[22] = true;


            //Increased consumption of meat
            if ((Questionnaire[0] == "No" &&(age <= 2 && Btest[7] > 0.5 ||  age <= 59 && age >= 3 && Btest[7] > 1 ||  age >= 60 && Btest[7] > 1.2)))
                diseases_bool[23] = true;


            //Use of various medications
            if ((Questionnaire[4] == "Yes" && Btest[10] > 120 && Questionnaire[2] == "No") || (Questionnaire[4] == "No" && Btest[10] > 90 && Questionnaire[2] == "No"))
                diseases_bool[24] = true;


            //Malnutrition
            if ((Questionnaire[4] == "Yes" && Btest[5] < 18.7 && Questionnaire[2] == "No") || (Questionnaire[4] == "No" && Btest[5] < 17 && Questionnaire[2] == "No") || age <= 2 && Btest[7] < 0.2 ||  age <= 17 && age >= 3 && Btest[7] < 0.5 ||  age >= 18 && Btest[7] < 0.6)
                diseases_bool[25] = true;
            
            Treatment(diseases_bool, txt_ID.Text);
            panel5.BackgroundImage = null;
            panel5.Size = new Size(582, 582);
            label5.Text = "Disease";
            label6.Text = "Treatment";

        }


        private void Treatment(bool[] disease,string id)
        {
            string label_treatment = "";
            string label_disease = "";
            int counter_treatments = 1;

            //array of all the nnames of the disease
            string[] list_disease = {"anemia", "diet", "bleeding", "Hyperlipidemia", "Blood clotting disorder", "Hematological disorder", "Iron poisoning", "Dehydration", "Infection", "Vitamin deficiency", "Viral disease" , "Diseases of the\n biliary tract", "heart diseases", "Blood disease", "Liver disease", "Kidney disease" , "Iron deficiency", "Muscle diseases" ,"Smoker", "Lung disease", "Overactive thyroid gland" , "Adult diabetes" , "cancer", "Increased consumption \nof meat", "Use of various\n medications" , "Malnutrition" };
        
            //array of all the treatment 
            string[] list_medicine = { "Two 10 mg B12 pills a day for a month" , "Schedule an appointment with a nutritionist" , "To be rushed to the hospital urgently" , "Schedule an appointment with a nutritionist, a 5 mg pill of Simobil daily for a week" ,
            "10 mg pill of B12 per day for one month 5 mg\npill of folic acid per day for one month" ,"An injection of a hormone to encourage red blood cell production" ,"To be evacuated to the hospital" ,"Complete rest while lying down, returning fluids to drinking",
            "Dedicated antibiotics" ,"Referral for a blood test to identify the missing vitamins" ,"Rest at home","Referral to surgical treatment" ,"Schedule an appointment with a nutritionist" ,"A combination of cyclophosphamide and corticosteroids" ,
            "Referral to a specific diagnosis for the purpose\n of determining treatment","Balance blood sugar levels" ,"Two 10 mg B12 pills a day for a month" ,"Two 5 mg pills of Altman c3 turmeric a day for a month" ,"to stop smoking" , "Stop smoking / Refer to an X-ray of the lungs" ,
            "Propylthiouracil to reduce thyroid activity" , "Insulin adjustment for the patient" ,"Antarctinib - Entrectinib" , "Schedule an appointment with a nutritionist" , "Referral to a family doctor for a match between medications" , "Schedule an appointment with a nutritionist"};

            for(int i = 0; i < disease.Length; i++)
            {
                if (disease[i] == true)
                {
                    label_disease += counter_treatments.ToString() + ". " + list_disease[i] + "\n";
                    label_treatment += counter_treatments.ToString() + ". "+ list_medicine[i] + "\n";
                    counter_treatments++;   
                }

            }
            // update the label in the sreen
            label3.Text = label_treatment;
            label4.Text = label_disease;
            //update the excel file
            ReadWriteExcel.addDiagnosis(id, label_disease, label_treatment);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
