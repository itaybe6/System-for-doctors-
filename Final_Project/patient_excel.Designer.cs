namespace Final_Project
{
    partial class patient_excel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patient_excel));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_questionnaire = new System.Windows.Forms.Button();
            this.btn_diagnosis = new System.Windows.Forms.Button();
            this.btn_excelParient = new System.Windows.Forms.Button();
            this.btn_AddPatient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
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
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 463);
            this.panel2.TabIndex = 6;
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
            this.btn_AddPatient.Click += new System.EventHandler(this.btn_AddPatient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_path);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_export);
            this.panel1.Location = new System.Drawing.Point(225, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 457);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(-2, 235);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(577, 219);
            this.panel5.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.SpringGreen;
            this.button1.Location = new System.Drawing.Point(212, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(97, 117);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(450, 23);
            this.txt_path.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Please export the file ";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(43, 45);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 23);
            this.txt_id.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SpringGreen;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter the id of patient that excel file belongs to him";
            // 
            // btn_export
            // 
            this.btn_export.FlatAppearance.BorderSize = 3;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_export.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_export.Location = new System.Drawing.Point(6, 112);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 32);
            this.btn_export.TabIndex = 0;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // patient_excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "patient_excel";
            this.Text = "patient_excel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.patient_excel_FormClosed);
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
        private Panel panel1;
        private Button btn_export;
        private Label label1;
        private Label label4;
        private TextBox txt_id;
        private Label label3;
        private TextBox txt_path;
        private Panel panel5;
        private Button button1;
    }
}