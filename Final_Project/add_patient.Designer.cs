namespace Final_Project
{
    partial class add_patient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_patient));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_questionnaire = new System.Windows.Forms.Button();
            this.btn_diagnosis = new System.Windows.Forms.Button();
            this.btn_excelParient = new System.Windows.Forms.Button();
            this.btn_AddPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.btn_enterDetails = new System.Windows.Forms.Button();
            this.txt_wigth = new System.Windows.Forms.TextBox();
            this.txt_higth = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmb_diarrhea = new System.Windows.Forms.ComboBox();
            this.cmb_smoking = new System.Windows.Forms.ComboBox();
            this.cmb_pregnent = new System.Windows.Forms.ComboBox();
            this.cmb_ethiopian = new System.Windows.Forms.ComboBox();
            this.cmb_oriental = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_questionnaire);
            this.panel2.Controls.Add(this.btn_diagnosis);
            this.panel2.Controls.Add(this.btn_excelParient);
            this.panel2.Controls.Add(this.btn_AddPatient);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 463);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(226, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(547, 86);
            this.panel4.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 86);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aharoni", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu";
            // 
            // btn_questionnaire
            // 
            this.btn_questionnaire.FlatAppearance.BorderSize = 0;
            this.btn_questionnaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_questionnaire.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_questionnaire.ForeColor = System.Drawing.Color.White;
            this.btn_questionnaire.Image = ((System.Drawing.Image)(resources.GetObject("btn_questionnaire.Image")));
            this.btn_questionnaire.Location = new System.Drawing.Point(-7, 341);
            this.btn_questionnaire.Name = "btn_questionnaire";
            this.btn_questionnaire.Size = new System.Drawing.Size(233, 78);
            this.btn_questionnaire.TabIndex = 2;
            this.btn_questionnaire.Text = "Blood Test";
            this.btn_questionnaire.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_questionnaire.UseVisualStyleBackColor = true;
            this.btn_questionnaire.Click += new System.EventHandler(this.btn_bloodTest_Click);
            // 
            // btn_diagnosis
            // 
            this.btn_diagnosis.FlatAppearance.BorderSize = 0;
            this.btn_diagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diagnosis.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_diagnosis.ForeColor = System.Drawing.Color.White;
            this.btn_diagnosis.Image = global::Final_Project.Properties.Resources.icons8_pills_49;
            this.btn_diagnosis.Location = new System.Drawing.Point(0, 255);
            this.btn_diagnosis.Name = "btn_diagnosis";
            this.btn_diagnosis.Size = new System.Drawing.Size(226, 78);
            this.btn_diagnosis.TabIndex = 2;
            this.btn_diagnosis.Text = "Diagnosis  Treatment";
            this.btn_diagnosis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_diagnosis.UseVisualStyleBackColor = true;
            this.btn_diagnosis.Click += new System.EventHandler(this.btn_diagnosis_Click);
            // 
            // btn_excelParient
            // 
            this.btn_excelParient.FlatAppearance.BorderSize = 0;
            this.btn_excelParient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excelParient.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_excelParient.ForeColor = System.Drawing.Color.White;
            this.btn_excelParient.Image = global::Final_Project.Properties.Resources.icons8_microsoft_excel_50;
            this.btn_excelParient.Location = new System.Drawing.Point(-3, 171);
            this.btn_excelParient.Name = "btn_excelParient";
            this.btn_excelParient.Size = new System.Drawing.Size(226, 78);
            this.btn_excelParient.TabIndex = 3;
            this.btn_excelParient.Text = "Excel Patient";
            this.btn_excelParient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_excelParient.UseVisualStyleBackColor = true;
            this.btn_excelParient.Click += new System.EventHandler(this.btn_excelParient_Click);
            // 
            // btn_AddPatient
            // 
            this.btn_AddPatient.FlatAppearance.BorderSize = 0;
            this.btn_AddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddPatient.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AddPatient.ForeColor = System.Drawing.Color.White;
            this.btn_AddPatient.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddPatient.Image")));
            this.btn_AddPatient.Location = new System.Drawing.Point(-3, 90);
            this.btn_AddPatient.Name = "btn_AddPatient";
            this.btn_AddPatient.Size = new System.Drawing.Size(226, 78);
            this.btn_AddPatient.TabIndex = 2;
            this.btn_AddPatient.Text = "Add Patient";
            this.btn_AddPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_AddPatient.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(128, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Details Patient";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aharoni", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(34, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aharoni", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(194, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Age";
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.Gender.Location = new System.Drawing.Point(119, 116);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(69, 23);
            this.Gender.TabIndex = 14;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(240, 116);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(54, 23);
            this.txt_age.TabIndex = 15;
            // 
            // btn_enterDetails
            // 
            this.btn_enterDetails.FlatAppearance.BorderSize = 3;
            this.btn_enterDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enterDetails.Font = new System.Drawing.Font("Aharoni", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_enterDetails.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_enterDetails.Location = new System.Drawing.Point(199, 395);
            this.btn_enterDetails.Name = "btn_enterDetails";
            this.btn_enterDetails.Size = new System.Drawing.Size(193, 43);
            this.btn_enterDetails.TabIndex = 27;
            this.btn_enterDetails.Text = "ENTER";
            this.btn_enterDetails.UseVisualStyleBackColor = true;
            this.btn_enterDetails.Click += new System.EventHandler(this.btn_enterDetails_Click);
            // 
            // txt_wigth
            // 
            this.txt_wigth.Location = new System.Drawing.Point(378, 118);
            this.txt_wigth.Name = "txt_wigth";
            this.txt_wigth.Size = new System.Drawing.Size(54, 23);
            this.txt_wigth.TabIndex = 28;
            // 
            // txt_higth
            // 
            this.txt_higth.Location = new System.Drawing.Point(507, 119);
            this.txt_higth.Name = "txt_higth";
            this.txt_higth.Size = new System.Drawing.Size(57, 23);
            this.txt_higth.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Aharoni", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(300, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "weight";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Aharoni", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(438, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "height";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.cmb_oriental);
            this.panel1.Controls.Add(this.cmb_ethiopian);
            this.panel1.Controls.Add(this.cmb_pregnent);
            this.panel1.Controls.Add(this.cmb_smoking);
            this.panel1.Controls.Add(this.cmb_diarrhea);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_ID);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_lastName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_firstName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txt_higth);
            this.panel1.Controls.Add(this.txt_wigth);
            this.panel1.Controls.Add(this.btn_enterDetails);
            this.panel1.Controls.Add(this.txt_age);
            this.panel1.Controls.Add(this.Gender);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(224, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 454);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Aharoni", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(36, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(414, 20);
            this.label13.TabIndex = 57;
            this.label13.Text = "Do you suffer from vomiting and diarrhea?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(135, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(308, 46);
            this.label12.TabIndex = 56;
            this.label12.Text = "Questionnaire";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(415, 71);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(113, 23);
            this.txt_ID.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Aharoni", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(380, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "ID";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(318, 71);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(57, 23);
            this.txt_lastName.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Aharoni", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(208, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Last Name";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(146, 72);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(57, 23);
            this.txt_firstName.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Aharoni", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(34, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 50;
            this.label9.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Aharoni", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(36, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Are you Oriental ?";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Aharoni", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(35, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Are you of Ethiopian descent ?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Aharoni", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(36, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Did you pregnent ? ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aharoni", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(36, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Did you smoking ? ";
            // 
            // cmb_diarrhea
            // 
            this.cmb_diarrhea.FormattingEnabled = true;
            this.cmb_diarrhea.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmb_diarrhea.Location = new System.Drawing.Point(462, 212);
            this.cmb_diarrhea.Name = "cmb_diarrhea";
            this.cmb_diarrhea.Size = new System.Drawing.Size(69, 23);
            this.cmb_diarrhea.TabIndex = 58;
            this.cmb_diarrhea.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmb_smoking
            // 
            this.cmb_smoking.FormattingEnabled = true;
            this.cmb_smoking.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmb_smoking.Location = new System.Drawing.Point(462, 249);
            this.cmb_smoking.Name = "cmb_smoking";
            this.cmb_smoking.Size = new System.Drawing.Size(69, 23);
            this.cmb_smoking.TabIndex = 59;
            // 
            // cmb_pregnent
            // 
            this.cmb_pregnent.FormattingEnabled = true;
            this.cmb_pregnent.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmb_pregnent.Location = new System.Drawing.Point(462, 291);
            this.cmb_pregnent.Name = "cmb_pregnent";
            this.cmb_pregnent.Size = new System.Drawing.Size(69, 23);
            this.cmb_pregnent.TabIndex = 60;
            // 
            // cmb_ethiopian
            // 
            this.cmb_ethiopian.FormattingEnabled = true;
            this.cmb_ethiopian.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmb_ethiopian.Location = new System.Drawing.Point(462, 330);
            this.cmb_ethiopian.Name = "cmb_ethiopian";
            this.cmb_ethiopian.Size = new System.Drawing.Size(69, 23);
            this.cmb_ethiopian.TabIndex = 61;
            // 
            // cmb_oriental
            // 
            this.cmb_oriental.FormattingEnabled = true;
            this.cmb_oriental.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmb_oriental.Location = new System.Drawing.Point(463, 369);
            this.cmb_oriental.Name = "cmb_oriental";
            this.cmb_oriental.Size = new System.Drawing.Size(69, 23);
            this.cmb_oriental.TabIndex = 62;
            // 
            // add_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "add_patient";
            this.Text = "add_patient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_patient_FormClosed_1);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Label label2;
        private Button btn_questionnaire;
        private Button btn_diagnosis;
        private Button btn_excelParient;
        private Button btn_AddPatient;
        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox Gender;
        private TextBox txt_age;
        private Button btn_enterDetails;
        private TextBox txt_wigth;
        private TextBox txt_higth;
        private Label label16;
        private Label label17;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label7;
        private Label label8;
        private TextBox txt_firstName;
        private Label label9;
        private TextBox txt_ID;
        private Label label11;
        private TextBox txt_lastName;
        private Label label10;
        private Label label12;
        private Label label13;
        private ComboBox cmb_diarrhea;
        private ComboBox cmb_oriental;
        private ComboBox cmb_ethiopian;
        private ComboBox cmb_pregnent;
        private ComboBox cmb_smoking;
    }
}