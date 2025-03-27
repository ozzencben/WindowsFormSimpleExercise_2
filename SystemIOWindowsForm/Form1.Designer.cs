namespace SystemIOWindowsForm
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
            this.EmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.employeeListingBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.surnamelbl = new System.Windows.Forms.Label();
            this.surnametextbox = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.companylbl = new System.Windows.Forms.Label();
            this.companytextbox = new System.Windows.Forms.TextBox();
            this.countrylbl = new System.Windows.Forms.Label();
            this.countrytextbox = new System.Windows.Forms.TextBox();
            this.EmployeeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeGroupBox
            // 
            this.EmployeeGroupBox.Controls.Add(this.SaveBtn);
            this.EmployeeGroupBox.Controls.Add(this.employeeListingBtn);
            this.EmployeeGroupBox.Controls.Add(this.EmployeeListBox);
            this.EmployeeGroupBox.Location = new System.Drawing.Point(13, 13);
            this.EmployeeGroupBox.Name = "EmployeeGroupBox";
            this.EmployeeGroupBox.Size = new System.Drawing.Size(200, 425);
            this.EmployeeGroupBox.TabIndex = 0;
            this.EmployeeGroupBox.TabStop = false;
            this.EmployeeGroupBox.Text = "EmployeeList";
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.Location = new System.Drawing.Point(6, 17);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(188, 303);
            this.EmployeeListBox.TabIndex = 0;
            this.EmployeeListBox.DoubleClick += new System.EventHandler(this.EmployeeListBox_DoubleClick);
            // 
            // employeeListingBtn
            // 
            this.employeeListingBtn.Location = new System.Drawing.Point(6, 326);
            this.employeeListingBtn.Name = "employeeListingBtn";
            this.employeeListingBtn.Size = new System.Drawing.Size(187, 45);
            this.employeeListingBtn.TabIndex = 1;
            this.employeeListingBtn.Text = "Employee Listing";
            this.employeeListingBtn.UseVisualStyleBackColor = true;
            this.employeeListingBtn.Click += new System.EventHandler(this.employeeListingBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(6, 374);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(187, 45);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.countrytextbox);
            this.groupBox1.Controls.Add(this.companytextbox);
            this.groupBox1.Controls.Add(this.countrylbl);
            this.groupBox1.Controls.Add(this.emailtextbox);
            this.groupBox1.Controls.Add(this.companylbl);
            this.groupBox1.Controls.Add(this.surnametextbox);
            this.groupBox1.Controls.Add(this.emaillbl);
            this.groupBox1.Controls.Add(this.nametextbox);
            this.groupBox1.Controls.Add(this.surnamelbl);
            this.groupBox1.Controls.Add(this.namelbl);
            this.groupBox1.Location = new System.Drawing.Point(219, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EmployeeList";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.namelbl.Location = new System.Drawing.Point(6, 129);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(45, 17);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "Name";
            // 
            // nametextbox
            // 
            this.nametextbox.Enabled = false;
            this.nametextbox.Location = new System.Drawing.Point(90, 129);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(153, 20);
            this.nametextbox.TabIndex = 1;
            this.nametextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // surnamelbl
            // 
            this.surnamelbl.AutoSize = true;
            this.surnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnamelbl.Location = new System.Drawing.Point(6, 155);
            this.surnamelbl.Name = "surnamelbl";
            this.surnamelbl.Size = new System.Drawing.Size(65, 17);
            this.surnamelbl.TabIndex = 0;
            this.surnamelbl.Text = "Surname";
            // 
            // surnametextbox
            // 
            this.surnametextbox.Enabled = false;
            this.surnametextbox.Location = new System.Drawing.Point(90, 155);
            this.surnametextbox.Name = "surnametextbox";
            this.surnametextbox.Size = new System.Drawing.Size(153, 20);
            this.surnametextbox.TabIndex = 1;
            this.surnametextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emaillbl.Location = new System.Drawing.Point(6, 181);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(42, 17);
            this.emaillbl.TabIndex = 0;
            this.emaillbl.Text = "Email";
            // 
            // emailtextbox
            // 
            this.emailtextbox.Enabled = false;
            this.emailtextbox.Location = new System.Drawing.Point(90, 181);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(153, 20);
            this.emailtextbox.TabIndex = 1;
            this.emailtextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // companylbl
            // 
            this.companylbl.AutoSize = true;
            this.companylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.companylbl.Location = new System.Drawing.Point(6, 207);
            this.companylbl.Name = "companylbl";
            this.companylbl.Size = new System.Drawing.Size(67, 17);
            this.companylbl.TabIndex = 0;
            this.companylbl.Text = "Company";
            // 
            // companytextbox
            // 
            this.companytextbox.Enabled = false;
            this.companytextbox.Location = new System.Drawing.Point(90, 207);
            this.companytextbox.Name = "companytextbox";
            this.companytextbox.Size = new System.Drawing.Size(153, 20);
            this.companytextbox.TabIndex = 1;
            this.companytextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // countrylbl
            // 
            this.countrylbl.AutoSize = true;
            this.countrylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countrylbl.Location = new System.Drawing.Point(6, 233);
            this.countrylbl.Name = "countrylbl";
            this.countrylbl.Size = new System.Drawing.Size(57, 17);
            this.countrylbl.TabIndex = 0;
            this.countrylbl.Text = "Country";
            // 
            // countrytextbox
            // 
            this.countrytextbox.Enabled = false;
            this.countrytextbox.Location = new System.Drawing.Point(90, 233);
            this.countrytextbox.Name = "countrytextbox";
            this.countrytextbox.Size = new System.Drawing.Size(153, 20);
            this.countrytextbox.TabIndex = 1;
            this.countrytextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmployeeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Addition Form";
            this.EmployeeGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EmployeeGroupBox;
        private System.Windows.Forms.Button employeeListingBtn;
        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox countrytextbox;
        private System.Windows.Forms.TextBox companytextbox;
        private System.Windows.Forms.Label countrylbl;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.Label companylbl;
        private System.Windows.Forms.TextBox surnametextbox;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label surnamelbl;
    }
}

