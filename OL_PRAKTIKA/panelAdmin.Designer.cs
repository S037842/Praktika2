namespace OL_PRAKTIKA
{
    partial class panelAdmin
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
            this.lGroup = new System.Windows.Forms.ListBox();
            this.lSubject = new System.Windows.Forms.ListBox();
            this.lLecturer = new System.Windows.Forms.ListBox();
            this.bCreateGroup = new System.Windows.Forms.Button();
            this.bDeleteGroup = new System.Windows.Forms.Button();
            this.bCreateSubject = new System.Windows.Forms.Button();
            this.bDeleteSubject = new System.Windows.Forms.Button();
            this.bCreateLecturer = new System.Windows.Forms.Button();
            this.bDeleteLecturer = new System.Windows.Forms.Button();
            this.bDeleteStudent = new System.Windows.Forms.Button();
            this.bCreateStudent = new System.Windows.Forms.Button();
            this.lStudent = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tNewGroup = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.bSubjectToLecturer = new System.Windows.Forms.Button();
            this.cLecturer1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cSubject1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bLecturerToGroup = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cGroup = new System.Windows.Forms.ComboBox();
            this.cSubject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cLecturer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tNewSubject = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tNewLecturer = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tNewStudent = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cStudent = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cStudentGroup = new System.Windows.Forms.ComboBox();
            this.bStudentToGroup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lGroup
            // 
            this.lGroup.FormattingEnabled = true;
            this.lGroup.Location = new System.Drawing.Point(14, 19);
            this.lGroup.Name = "lGroup";
            this.lGroup.Size = new System.Drawing.Size(120, 95);
            this.lGroup.TabIndex = 0;
            // 
            // lSubject
            // 
            this.lSubject.FormattingEnabled = true;
            this.lSubject.Location = new System.Drawing.Point(14, 43);
            this.lSubject.Name = "lSubject";
            this.lSubject.Size = new System.Drawing.Size(120, 134);
            this.lSubject.TabIndex = 2;
            // 
            // lLecturer
            // 
            this.lLecturer.FormattingEnabled = true;
            this.lLecturer.Location = new System.Drawing.Point(14, 19);
            this.lLecturer.Name = "lLecturer";
            this.lLecturer.Size = new System.Drawing.Size(120, 95);
            this.lLecturer.TabIndex = 4;
            // 
            // bCreateGroup
            // 
            this.bCreateGroup.Location = new System.Drawing.Point(140, 62);
            this.bCreateGroup.Name = "bCreateGroup";
            this.bCreateGroup.Size = new System.Drawing.Size(140, 23);
            this.bCreateGroup.TabIndex = 6;
            this.bCreateGroup.Text = "Kurti";
            this.bCreateGroup.UseVisualStyleBackColor = true;
            this.bCreateGroup.Click += new System.EventHandler(this.bCreateGroup_Click);
            // 
            // bDeleteGroup
            // 
            this.bDeleteGroup.Location = new System.Drawing.Point(140, 91);
            this.bDeleteGroup.Name = "bDeleteGroup";
            this.bDeleteGroup.Size = new System.Drawing.Size(140, 23);
            this.bDeleteGroup.TabIndex = 7;
            this.bDeleteGroup.Text = "Trinti pažymėtą";
            this.bDeleteGroup.UseVisualStyleBackColor = true;
            this.bDeleteGroup.Click += new System.EventHandler(this.bDeleteGroup_Click);
            // 
            // bCreateSubject
            // 
            this.bCreateSubject.Location = new System.Drawing.Point(140, 129);
            this.bCreateSubject.Name = "bCreateSubject";
            this.bCreateSubject.Size = new System.Drawing.Size(140, 23);
            this.bCreateSubject.TabIndex = 8;
            this.bCreateSubject.Text = "Kurti";
            this.bCreateSubject.UseVisualStyleBackColor = true;
            this.bCreateSubject.Click += new System.EventHandler(this.bCreateSubject_Click);
            // 
            // bDeleteSubject
            // 
            this.bDeleteSubject.Location = new System.Drawing.Point(140, 158);
            this.bDeleteSubject.Name = "bDeleteSubject";
            this.bDeleteSubject.Size = new System.Drawing.Size(140, 23);
            this.bDeleteSubject.TabIndex = 9;
            this.bDeleteSubject.Text = "Trinti pažymėtą";
            this.bDeleteSubject.UseVisualStyleBackColor = true;
            this.bDeleteSubject.Click += new System.EventHandler(this.bDeleteSubject_Click);
            // 
            // bCreateLecturer
            // 
            this.bCreateLecturer.Location = new System.Drawing.Point(140, 62);
            this.bCreateLecturer.Name = "bCreateLecturer";
            this.bCreateLecturer.Size = new System.Drawing.Size(140, 23);
            this.bCreateLecturer.TabIndex = 10;
            this.bCreateLecturer.Text = "Kurti";
            this.bCreateLecturer.UseVisualStyleBackColor = true;
            this.bCreateLecturer.Click += new System.EventHandler(this.bCreateLecturer_Click);
            // 
            // bDeleteLecturer
            // 
            this.bDeleteLecturer.Location = new System.Drawing.Point(140, 91);
            this.bDeleteLecturer.Name = "bDeleteLecturer";
            this.bDeleteLecturer.Size = new System.Drawing.Size(140, 23);
            this.bDeleteLecturer.TabIndex = 11;
            this.bDeleteLecturer.Text = "Trinti pažymėtą";
            this.bDeleteLecturer.UseVisualStyleBackColor = true;
            this.bDeleteLecturer.Click += new System.EventHandler(this.bDeleteLecturer_Click);
            // 
            // bDeleteStudent
            // 
            this.bDeleteStudent.Location = new System.Drawing.Point(140, 91);
            this.bDeleteStudent.Name = "bDeleteStudent";
            this.bDeleteStudent.Size = new System.Drawing.Size(140, 23);
            this.bDeleteStudent.TabIndex = 15;
            this.bDeleteStudent.Text = "Trinti pažymėtą";
            this.bDeleteStudent.UseVisualStyleBackColor = true;
            this.bDeleteStudent.Click += new System.EventHandler(this.bDeleteStudent_Click);
            // 
            // bCreateStudent
            // 
            this.bCreateStudent.Location = new System.Drawing.Point(140, 62);
            this.bCreateStudent.Name = "bCreateStudent";
            this.bCreateStudent.Size = new System.Drawing.Size(140, 23);
            this.bCreateStudent.TabIndex = 14;
            this.bCreateStudent.Text = "Kurti";
            this.bCreateStudent.UseVisualStyleBackColor = true;
            this.bCreateStudent.Click += new System.EventHandler(this.bCreateStudent_Click);
            // 
            // lStudent
            // 
            this.lStudent.FormattingEnabled = true;
            this.lStudent.Location = new System.Drawing.Point(14, 19);
            this.lStudent.Name = "lStudent";
            this.lStudent.Size = new System.Drawing.Size(120, 95);
            this.lStudent.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tNewGroup);
            this.groupBox1.Controls.Add(this.lGroup);
            this.groupBox1.Controls.Add(this.bDeleteGroup);
            this.groupBox1.Controls.Add(this.bCreateGroup);
            this.groupBox1.Location = new System.Drawing.Point(311, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 128);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Studentų grupės";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Naujos grupės pavadinimas:";
            // 
            // tNewGroup
            // 
            this.tNewGroup.Location = new System.Drawing.Point(140, 36);
            this.tNewGroup.Name = "tNewGroup";
            this.tNewGroup.Size = new System.Drawing.Size(140, 20);
            this.tNewGroup.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cLecturer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tNewSubject);
            this.groupBox2.Controls.Add(this.lSubject);
            this.groupBox2.Controls.Add(this.bCreateSubject);
            this.groupBox2.Controls.Add(this.bDeleteSubject);
            this.groupBox2.Location = new System.Drawing.Point(311, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 232);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dėstomi dalykai";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Controls.Add(this.bSubjectToLecturer);
            this.groupBox6.Controls.Add(this.cLecturer1);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.cSubject1);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(291, 123);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(209, 103);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Priskirti dėstomą dalyką dėstytojui";
            // 
            // bSubjectToLecturer
            // 
            this.bSubjectToLecturer.Location = new System.Drawing.Point(71, 69);
            this.bSubjectToLecturer.Name = "bSubjectToLecturer";
            this.bSubjectToLecturer.Size = new System.Drawing.Size(129, 23);
            this.bSubjectToLecturer.TabIndex = 23;
            this.bSubjectToLecturer.Text = "Atnaujinti";
            this.bSubjectToLecturer.UseVisualStyleBackColor = true;
            this.bSubjectToLecturer.Click += new System.EventHandler(this.bSubjectToLecturer_Click);
            // 
            // cLecturer1
            // 
            this.cLecturer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cLecturer1.FormattingEnabled = true;
            this.cLecturer1.Location = new System.Drawing.Point(71, 44);
            this.cLecturer1.Name = "cLecturer1";
            this.cLecturer1.Size = new System.Drawing.Size(129, 21);
            this.cLecturer1.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Dėstytojas:";
            // 
            // cSubject1
            // 
            this.cSubject1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSubject1.FormattingEnabled = true;
            this.cSubject1.Location = new System.Drawing.Point(60, 17);
            this.cSubject1.Name = "cSubject1";
            this.cSubject1.Size = new System.Drawing.Size(140, 21);
            this.cSubject1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Dalykas:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Controls.Add(this.bLecturerToGroup);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.cGroup);
            this.groupBox5.Controls.Add(this.cSubject);
            this.groupBox5.Location = new System.Drawing.Point(291, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(209, 103);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Priskirti dėstomą dalyką grupei";
            // 
            // bLecturerToGroup
            // 
            this.bLecturerToGroup.Location = new System.Drawing.Point(60, 74);
            this.bLecturerToGroup.Name = "bLecturerToGroup";
            this.bLecturerToGroup.Size = new System.Drawing.Size(140, 23);
            this.bLecturerToGroup.TabIndex = 28;
            this.bLecturerToGroup.Text = "Atnaujinti";
            this.bLecturerToGroup.UseVisualStyleBackColor = true;
            this.bLecturerToGroup.Click += new System.EventHandler(this.bLecturerToGroup_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Grupė:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Dalykas:";
            // 
            // cGroup
            // 
            this.cGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cGroup.FormattingEnabled = true;
            this.cGroup.Location = new System.Drawing.Point(60, 50);
            this.cGroup.Name = "cGroup";
            this.cGroup.Size = new System.Drawing.Size(140, 21);
            this.cGroup.TabIndex = 23;
            // 
            // cSubject
            // 
            this.cSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSubject.FormattingEnabled = true;
            this.cSubject.Location = new System.Drawing.Point(60, 22);
            this.cSubject.Name = "cSubject";
            this.cSubject.Size = new System.Drawing.Size(140, 21);
            this.cSubject.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Dėstytojas:";
            // 
            // cLecturer
            // 
            this.cLecturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cLecturer.FormattingEnabled = true;
            this.cLecturer.Location = new System.Drawing.Point(140, 102);
            this.cLecturer.Name = "cLecturer";
            this.cLecturer.Size = new System.Drawing.Size(140, 21);
            this.cLecturer.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Naujo dalyko pavadinimas:";
            // 
            // tNewSubject
            // 
            this.tNewSubject.Location = new System.Drawing.Point(140, 60);
            this.tNewSubject.Name = "tNewSubject";
            this.tNewSubject.Size = new System.Drawing.Size(140, 20);
            this.tNewSubject.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tNewLecturer);
            this.groupBox3.Controls.Add(this.lLecturer);
            this.groupBox3.Controls.Add(this.bDeleteLecturer);
            this.groupBox3.Controls.Add(this.bCreateLecturer);
            this.groupBox3.Location = new System.Drawing.Point(12, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 128);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dėstytojai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Naujas dėstytojas:";
            // 
            // tNewLecturer
            // 
            this.tNewLecturer.Location = new System.Drawing.Point(140, 36);
            this.tNewLecturer.Name = "tNewLecturer";
            this.tNewLecturer.Size = new System.Drawing.Size(140, 20);
            this.tNewLecturer.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tNewStudent);
            this.groupBox4.Controls.Add(this.lStudent);
            this.groupBox4.Controls.Add(this.bCreateStudent);
            this.groupBox4.Controls.Add(this.bDeleteStudent);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 128);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Studentai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Naujas studentas:";
            // 
            // tNewStudent
            // 
            this.tNewStudent.Location = new System.Drawing.Point(140, 36);
            this.tNewStudent.Name = "tNewStudent";
            this.tNewStudent.Size = new System.Drawing.Size(140, 20);
            this.tNewStudent.TabIndex = 20;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox7.Controls.Add(this.bStudentToGroup);
            this.groupBox7.Controls.Add(this.cStudentGroup);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.cStudent);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Location = new System.Drawing.Point(291, 14);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(209, 108);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Priskirti studentą į grupę";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Studentas:";
            // 
            // cStudent
            // 
            this.cStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cStudent.FormattingEnabled = true;
            this.cStudent.Location = new System.Drawing.Point(70, 22);
            this.cStudent.Name = "cStudent";
            this.cStudent.Size = new System.Drawing.Size(133, 21);
            this.cStudent.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Grupė:";
            // 
            // cStudentGroup
            // 
            this.cStudentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cStudentGroup.FormattingEnabled = true;
            this.cStudentGroup.Location = new System.Drawing.Point(70, 48);
            this.cStudentGroup.Name = "cStudentGroup";
            this.cStudentGroup.Size = new System.Drawing.Size(133, 21);
            this.cStudentGroup.TabIndex = 30;
            // 
            // bStudentToGroup
            // 
            this.bStudentToGroup.Location = new System.Drawing.Point(70, 75);
            this.bStudentToGroup.Name = "bStudentToGroup";
            this.bStudentToGroup.Size = new System.Drawing.Size(133, 23);
            this.bStudentToGroup.TabIndex = 29;
            this.bStudentToGroup.Text = "Atnaujinti";
            this.bStudentToGroup.UseVisualStyleBackColor = true;
            this.bStudentToGroup.Click += new System.EventHandler(this.bStudentToGroup_Click);
            // 
            // panelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 390);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "panelAdmin";
            this.Text = "panelAdmin";
            this.Load += new System.EventHandler(this.panelAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lGroup;
        private System.Windows.Forms.ListBox lSubject;
        private System.Windows.Forms.ListBox lLecturer;
        private System.Windows.Forms.Button bCreateGroup;
        private System.Windows.Forms.Button bDeleteGroup;
        private System.Windows.Forms.Button bCreateSubject;
        private System.Windows.Forms.Button bDeleteSubject;
        private System.Windows.Forms.Button bCreateLecturer;
        private System.Windows.Forms.Button bDeleteLecturer;
        private System.Windows.Forms.Button bDeleteStudent;
        private System.Windows.Forms.Button bCreateStudent;
        private System.Windows.Forms.ListBox lStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNewGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tNewSubject;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tNewLecturer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tNewStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cLecturer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cGroup;
        private System.Windows.Forms.ComboBox cSubject;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cSubject1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cLecturer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bSubjectToLecturer;
        private System.Windows.Forms.Button bLecturerToGroup;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cStudent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cStudentGroup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bStudentToGroup;
    }
}