using System;

namespace FormBrowse
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnStartCamera = new System.Windows.Forms.Button();
            this.btnCaptureCamera = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rtbProject = new System.Windows.Forms.RichTextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.chkDiploma = new System.Windows.Forms.CheckBox();
            this.chkUG = new System.Windows.Forms.CheckBox();
            this.chkPG = new System.Windows.Forms.CheckBox();
            this.cmbExperience = new System.Windows.Forms.ComboBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.grpMarital = new System.Windows.Forms.GroupBox();
            this.rbUnMarried = new System.Windows.Forms.RadioButton();
            this.rbMarried = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrint2 = new System.Windows.Forms.Button();
            this.btnStopCamera = new System.Windows.Forms.Button();
            this.picPhoto1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            this.grpGender.SuspendLayout();
            this.grpMarital.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upload Photo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marital Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Qualification";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Experience";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 637);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "About Project";
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Location = new System.Drawing.Point(283, 12);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(120, 111);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 8;
            this.picPhoto.TabStop = false;
            // 
            // picCamera
            // 
            this.picCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCamera.Location = new System.Drawing.Point(689, 12);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(120, 111);
            this.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamera.TabIndex = 9;
            this.picCamera.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(302, 144);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnStartCamera
            // 
            this.btnStartCamera.Location = new System.Drawing.Point(473, 144);
            this.btnStartCamera.Name = "btnStartCamera";
            this.btnStartCamera.Size = new System.Drawing.Size(75, 23);
            this.btnStartCamera.TabIndex = 11;
            this.btnStartCamera.Text = "Start";
            this.btnStartCamera.UseVisualStyleBackColor = true;
            this.btnStartCamera.Click += new System.EventHandler(this.btnStartCamera_Click_1);
            // 
            // btnCaptureCamera
            // 
            this.btnCaptureCamera.Location = new System.Drawing.Point(590, 144);
            this.btnCaptureCamera.Name = "btnCaptureCamera";
            this.btnCaptureCamera.Size = new System.Drawing.Size(75, 23);
            this.btnCaptureCamera.TabIndex = 12;
            this.btnCaptureCamera.Text = "Capture";
            this.btnCaptureCamera.UseVisualStyleBackColor = true;
            this.btnCaptureCamera.Click += new System.EventHandler(this.btnCaptureCamera_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(473, 705);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(283, 186);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 14;
            // 
            // rtbProject
            // 
            this.rtbProject.Location = new System.Drawing.Point(283, 605);
            this.rtbProject.Name = "rtbProject";
            this.rtbProject.Size = new System.Drawing.Size(250, 80);
            this.rtbProject.TabIndex = 15;
            this.rtbProject.Text = "";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(283, 232);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 16;
            // 
            // chkDiploma
            // 
            this.chkDiploma.AutoSize = true;
            this.chkDiploma.Location = new System.Drawing.Point(282, 449);
            this.chkDiploma.Name = "chkDiploma";
            this.chkDiploma.Size = new System.Drawing.Size(80, 20);
            this.chkDiploma.TabIndex = 21;
            this.chkDiploma.Text = "Diploma";
            this.chkDiploma.UseVisualStyleBackColor = true;
            // 
            // chkUG
            // 
            this.chkUG.AutoSize = true;
            this.chkUG.Location = new System.Drawing.Point(282, 485);
            this.chkUG.Name = "chkUG";
            this.chkUG.Size = new System.Drawing.Size(49, 20);
            this.chkUG.TabIndex = 22;
            this.chkUG.Text = "UG";
            this.chkUG.UseVisualStyleBackColor = true;
            // 
            // chkPG
            // 
            this.chkPG.AutoSize = true;
            this.chkPG.Location = new System.Drawing.Point(283, 511);
            this.chkPG.Name = "chkPG";
            this.chkPG.Size = new System.Drawing.Size(48, 20);
            this.chkPG.TabIndex = 23;
            this.chkPG.Text = "PG";
            this.chkPG.UseVisualStyleBackColor = true;
            this.chkPG.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cmbExperience
            // 
            this.cmbExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExperience.FormattingEnabled = true;
            this.cmbExperience.Items.AddRange(new object[] {
            "Fresher",
            "1 - 2 Years",
            "2 - 5 Years",
            "5+ Years"});
            this.cmbExperience.Location = new System.Drawing.Point(283, 559);
            this.cmbExperience.Name = "cmbExperience";
            this.cmbExperience.Size = new System.Drawing.Size(121, 24);
            this.cmbExperience.TabIndex = 24;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rbFemale);
            this.grpGender.Controls.Add(this.rbMale);
            this.grpGender.Location = new System.Drawing.Point(282, 290);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(383, 59);
            this.grpGender.TabIndex = 25;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(176, 21);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(74, 20);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(6, 21);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 20);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // grpMarital
            // 
            this.grpMarital.Controls.Add(this.rbUnMarried);
            this.grpMarital.Controls.Add(this.rbMarried);
            this.grpMarital.Location = new System.Drawing.Point(282, 370);
            this.grpMarital.Name = "grpMarital";
            this.grpMarital.Size = new System.Drawing.Size(383, 58);
            this.grpMarital.TabIndex = 26;
            this.grpMarital.TabStop = false;
            this.grpMarital.Text = "Marital Status";
            // 
            // rbUnMarried
            // 
            this.rbUnMarried.AutoSize = true;
            this.rbUnMarried.Location = new System.Drawing.Point(176, 21);
            this.rbUnMarried.Name = "rbUnMarried";
            this.rbUnMarried.Size = new System.Drawing.Size(91, 20);
            this.rbUnMarried.TabIndex = 2;
            this.rbUnMarried.TabStop = true;
            this.rbUnMarried.Text = "Unmarried";
            this.rbUnMarried.UseVisualStyleBackColor = true;
            // 
            // rbMarried
            // 
            this.rbMarried.AutoSize = true;
            this.rbMarried.Location = new System.Drawing.Point(6, 21);
            this.rbMarried.Name = "rbMarried";
            this.rbMarried.Size = new System.Drawing.Size(74, 20);
            this.rbMarried.TabIndex = 1;
            this.rbMarried.TabStop = true;
            this.rbMarried.Text = "Married";
            this.rbMarried.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(631, 705);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnPrint2
            // 
            this.btnPrint2.Location = new System.Drawing.Point(803, 705);
            this.btnPrint2.Name = "btnPrint2";
            this.btnPrint2.Size = new System.Drawing.Size(75, 23);
            this.btnPrint2.TabIndex = 28;
            this.btnPrint2.Text = "Print";
            this.btnPrint2.UseVisualStyleBackColor = true;
            this.btnPrint2.Click += new System.EventHandler(this.btnPrint2_Click);
            // 
            // btnStopCamera
            // 
            this.btnStopCamera.Location = new System.Drawing.Point(711, 144);
            this.btnStopCamera.Name = "btnStopCamera";
            this.btnStopCamera.Size = new System.Drawing.Size(75, 23);
            this.btnStopCamera.TabIndex = 29;
            this.btnStopCamera.Text = "Stop";
            this.btnStopCamera.UseVisualStyleBackColor = true;
            this.btnStopCamera.Click += new System.EventHandler(this.btnStopCamera_Click);
            // 
            // picPhoto1
            // 
            this.picPhoto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto1.Location = new System.Drawing.Point(496, 12);
            this.picPhoto1.Name = "picPhoto1";
            this.picPhoto1.Size = new System.Drawing.Size(120, 111);
            this.picPhoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto1.TabIndex = 30;
            this.picPhoto1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 754);
            this.Controls.Add(this.picPhoto1);
            this.Controls.Add(this.btnStopCamera);
            this.Controls.Add(this.btnPrint2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpMarital);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.cmbExperience);
            this.Controls.Add(this.chkPG);
            this.Controls.Add(this.chkUG);
            this.Controls.Add(this.chkDiploma);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.rtbProject);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCaptureCamera);
            this.Controls.Add(this.btnStartCamera);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picCamera);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpMarital.ResumeLayout(false);
            this.grpMarital.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnStartCamera;
        private System.Windows.Forms.Button btnCaptureCamera;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.CheckBox chkDiploma;
        private System.Windows.Forms.CheckBox chkUG;
        private System.Windows.Forms.CheckBox chkPG;
        private System.Windows.Forms.ComboBox cmbExperience;
        private System.Windows.Forms.RichTextBox rtbProject;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.GroupBox grpMarital;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbMarried;
        private System.Windows.Forms.RadioButton rbUnMarried;
        private System.Windows.Forms.Button btnReset;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnPrint2;
        private System.Windows.Forms.Button btnStopCamera;
        private System.Windows.Forms.PictureBox picPhoto1;
    }
}

