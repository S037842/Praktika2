namespace OL_PRAKTIKA
{
    partial class panelLecturer
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
            this.label1 = new System.Windows.Forms.Label();
            this.cStudent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cSubject = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cGroup = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Studentas:";
            // 
            // cStudent
            // 
            this.cStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cStudent.FormattingEnabled = true;
            this.cStudent.Location = new System.Drawing.Point(97, 50);
            this.cStudent.Name = "cStudent";
            this.cStudent.Size = new System.Drawing.Size(121, 21);
            this.cStudent.TabIndex = 1;
            this.cStudent.SelectedIndexChanged += new System.EventHandler(this.cStudent_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dalykas:";
            // 
            // cSubject
            // 
            this.cSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cSubject.FormattingEnabled = true;
            this.cSubject.Location = new System.Drawing.Point(97, 83);
            this.cSubject.Name = "cSubject";
            this.cSubject.Size = new System.Drawing.Size(121, 21);
            this.cSubject.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(97, 110);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pažymys:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grupė:";
            // 
            // cGroup
            // 
            this.cGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cGroup.FormattingEnabled = true;
            this.cGroup.Location = new System.Drawing.Point(80, 20);
            this.cGroup.Name = "cGroup";
            this.cGroup.Size = new System.Drawing.Size(138, 21);
            this.cGroup.TabIndex = 7;
            this.cGroup.SelectedIndexChanged += new System.EventHandler(this.cGroup_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Atnaujinti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 182);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cStudent);
            this.Controls.Add(this.label1);
            this.Name = "panelLecturer";
            this.Text = "panelLecturer";
            this.Load += new System.EventHandler(this.panelLecturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cSubject;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cGroup;
        private System.Windows.Forms.Button button1;
    }
}