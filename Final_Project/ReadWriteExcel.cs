using IronXL;

namespace Final_Project
{

    class ReadWriteExcel
    {
        //excel for the doctors
        public static string doctorsPath = AppDomain.CurrentDomain.BaseDirectory + "Doctors.xlsx";
        public static WorkBook workBook_doctors = WorkBook.Load(doctorsPath);
        public static WorkSheet sheet_doctors = workBook_doctors.DefaultWorkSheet;

        //excel for the patients
        public static string paitentPath = AppDomain.CurrentDomain.BaseDirectory + "Patients.xlsx";
        public static WorkBook workBook_patients = WorkBook.Load(paitentPath);
        public static WorkSheet sheet_patients = workBook_patients.DefaultWorkSheet;
        
        //excel for the files of the blood tests
        public static WorkBook wb_Btest;
        public static WorkSheet ws_Btest;



        //return the index of "A" column for the username 
        public static int searchUserName(string UserName)
        {
            for (int i = 1; i <= sheet_doctors.Rows.Count(); i++)
            {
                if (UserName == sheet_doctors["A" + i].Value.ToString())
                    return i;
            }

            //if the username dont exist
            return -1;
             
        }

        public static int searchID(string ID)
        {
            for (int i = 1; i <= sheet_patients.Rows.Count(); i++)
            {
                if (ID == sheet_patients["C" + i].Value.ToString())
                    return i;
            }

            //if the username dont exist
            return -1;

        }

        //return the index of "B" column for the password
        public static int searchPassword(string Password)
        {
            for(int i = 1; i <= sheet_doctors.Rows.Count(); i++)
            {
                if (Password == sheet_doctors["B" + i].Value.ToString())
                    return i; 

            }
            //if the password dont exist
            return -1;

        }
        //add doctor to system
        public static void addDoctor(string userName,string ID ,string password)
        {
            int row = sheet_doctors.Rows.Count() + 1;
            sheet_doctors["A" + row].Value = userName;
            sheet_doctors["B" + row].Value = password;
            sheet_doctors["C" + row].Value = ID;

            workBook_doctors.Save();
            workBook_doctors.SaveAs(doctorsPath);

        }

        //add patient to the excel patiens
        public static void addPatient(string Fname,string Lname,string ID,string Age,string Gen,string Whight,string Higth,string diarrhea,string smoking,string pregnent,string etiopiha ,string oriental)
        {
            int row = sheet_patients.Rows.Count() + 1;
            string[] col = { "A", "B", "C", "D", "E", "F", "G", "S", "T", "U", "V", "W" };
            string[] values = {Fname, Lname, ID, Age,Whight, Higth,Gen, diarrhea, smoking, pregnent, etiopiha, oriental};

            for(int i = 0; i < col.Length; i++)
                sheet_patients[col[i]+row].Value = values[i];

          
            workBook_patients.Save();
            workBook_patients.SaveAs(paitentPath);

        }


        public static void addBloodTest(string[] arr)
        {

            //find the patient row
            int row = searchID(arr[0]);

            //enter blood test only to patients that exist in the system.
            if(row == -1)
            {
                MessageBox.Show("The patient with this id dont exist in the system. \nPlease enter the id previous.");
                return;
            }

            string[] col = { "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R"};
            for(int i = 0; i < col.Length; i++)
                sheet_patients[col[i]+row].Value = arr[i+1];

            workBook_patients.Save();
            workBook_patients.SaveAs(paitentPath);
            MessageBox.Show("Data saved successfully");

        }

        public static string getGender(string id)
        {
            //get gender recording the id
            int row = searchID(id);
            return sheet_patients["G" + row].Value.ToString();
        }

        public static int getAge(string id)
        {
            //get age recording the id
            int row = searchID(id);
            return int.Parse(sheet_patients["D" + row].Value.ToString());
        }

        //get blood test according to id
        public static float[] getBloodTest(string id)
        {
            int row = searchID(id);
            float[] blood_test = new float [16];

            //check if the doctor try to get diagnosis without enter blood test
            if(sheet_patients["H" + row].IsEmpty)
                return blood_test;
         
            blood_test[0] = float.Parse(sheet_patients["H" + row].Value.ToString());
            blood_test[1] = float.Parse(sheet_patients["I" + row].Value.ToString());
            blood_test[2] = float.Parse(sheet_patients["J" + row].Value.ToString());
            blood_test[3] = float.Parse(sheet_patients["K" + row].Value.ToString());
            blood_test[4] = float.Parse(sheet_patients["L" + row].Value.ToString());
            blood_test[5] = float.Parse(sheet_patients["M" + row].Value.ToString());
            blood_test[6] = float.Parse(sheet_patients["N" + row].Value.ToString());
            blood_test[7] = float.Parse(sheet_patients["O" + row].Value.ToString());
            blood_test[8] = float.Parse(sheet_patients["P" + row].Value.ToString());
            blood_test[9] = float.Parse(sheet_patients["Q" + row].Value.ToString());
            blood_test[10] = float.Parse(sheet_patients["R" + row].Value.ToString());


            return blood_test;
        }

        //get the data the questionnaire (smoking , pregnent ..)
        public static string[] getQuestionnaire(string id)
        {
            int row = searchID(id);
            string[] questionnaire = new string[5];
            string[] col = { "S", "T", "U", "V", "W" };

            for(int i = 0; i < col.Length; i++)
                questionnaire[i] = sheet_patients[col[i]+row].Value.ToString();
            
            return questionnaire;
        }

        public static void updateExcelPathForBtest (string path)
        {
            wb_Btest = WorkBook.Load(path);
            ws_Btest = wb_Btest.DefaultWorkSheet;
            
        }

    //import excel file for the blood tese
    public static void importExcelBtest(string id)
        {
            string[] blood_test = new string[12];
            string[] col = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K"};
            blood_test[0] = id;
            for(int i = 0; i < 11; i++)
                blood_test[i + 1] = (ws_Btest[col[i] + 2].Value.ToString());

            addBloodTest(blood_test);  
        }


    //add the diagnosis to excel
    public static void addDiagnosis(string id,string diagnosis,string treatment){

            int row = searchID(id);
            sheet_patients["X" + row].Value = diagnosis;
            sheet_patients["Y" + row].Value = treatment; 
            workBook_patients.Save();
            workBook_patients.SaveAs(paitentPath);


        }

    }

    



}

