namespace Final_Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_questionnaire = new System.Windows.Forms.Button();
            this.btn_diagnosis = new System.Windows.Forms.Button();
            this.btn_excelParient = new System.Windows.Forms.Button();
            this.btn_AddPatient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 463);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.btn_questionnaire.Click += new System.EventHandler(this.btn_BloodTest_Click);
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
            this.btn_AddPatient.Click += new System.EventHandler(this.btn_AddPatient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(226, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 460);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(130, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome doctor";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(0, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(580, 269);
            this.panel5.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Button btn_AddPatient;
        private Button btn_excelParient;
        private Button btn_diagnosis;
        private Button btn_questionnaire;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Panel panel1;
        private Panel panel5;
        private Label label1;
    }
}