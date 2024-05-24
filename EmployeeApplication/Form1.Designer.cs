namespace EmployeeApplication
{
    partial class frmComputeSalary
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
            this.labelFname = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelDept = new System.Windows.Forms.Label();
            this.labeljob = new System.Windows.Forms.Label();
            this.labelrateperhr = new System.Windows.Forms.Label();
            this.labeltotalhrswrkd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelBasicSalary = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.buttonComputeSalary = new System.Windows.Forms.Button();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.textBoxRateperHour = new System.Windows.Forms.TextBox();
            this.textBoxTotalHoursWorked = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFname.Location = new System.Drawing.Point(39, 41);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(72, 17);
            this.labelFname.TabIndex = 0;
            this.labelFname.Text = "First name";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLname.Location = new System.Drawing.Point(244, 41);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(70, 17);
            this.labelLname.TabIndex = 1;
            this.labelLname.Text = "Last name";
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDept.Location = new System.Drawing.Point(39, 107);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(81, 17);
            this.labelDept.TabIndex = 2;
            this.labelDept.Text = "Department";
            // 
            // labeljob
            // 
            this.labeljob.AutoSize = true;
            this.labeljob.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljob.Location = new System.Drawing.Point(244, 107);
            this.labeljob.Name = "labeljob";
            this.labeljob.Size = new System.Drawing.Size(56, 17);
            this.labeljob.TabIndex = 3;
            this.labeljob.Text = "Job title";
            // 
            // labelrateperhr
            // 
            this.labelrateperhr.AutoSize = true;
            this.labelrateperhr.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrateperhr.Location = new System.Drawing.Point(39, 216);
            this.labelrateperhr.Name = "labelrateperhr";
            this.labelrateperhr.Size = new System.Drawing.Size(92, 17);
            this.labelrateperhr.TabIndex = 4;
            this.labelrateperhr.Text = "Rate per hour";
            // 
            // labeltotalhrswrkd
            // 
            this.labeltotalhrswrkd.AutoSize = true;
            this.labeltotalhrswrkd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalhrswrkd.Location = new System.Drawing.Point(244, 216);
            this.labeltotalhrswrkd.Name = "labeltotalhrswrkd";
            this.labeltotalhrswrkd.Size = new System.Drawing.Size(125, 17);
            this.labeltotalhrswrkd.TabIndex = 5;
            this.labeltotalhrswrkd.Text = "Total hours worked";
            this.labeltotalhrswrkd.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "First name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Last name:";
            // 
            // labelBasicSalary
            // 
            this.labelBasicSalary.AutoSize = true;
            this.labelBasicSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBasicSalary.Location = new System.Drawing.Point(44, 415);
            this.labelBasicSalary.Name = "labelBasicSalary";
            this.labelBasicSalary.Size = new System.Drawing.Size(81, 17);
            this.labelBasicSalary.TabIndex = 8;
            this.labelBasicSalary.Text = "Basic salary:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(32, 61);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(186, 22);
            this.textBoxFirstName.TabIndex = 9;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(238, 61);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(186, 22);
            this.textBoxLastName.TabIndex = 10;
            // 
            // buttonComputeSalary
            // 
            this.buttonComputeSalary.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonComputeSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComputeSalary.Location = new System.Drawing.Point(163, 296);
            this.buttonComputeSalary.Name = "buttonComputeSalary";
            this.buttonComputeSalary.Size = new System.Drawing.Size(117, 29);
            this.buttonComputeSalary.TabIndex = 15;
            this.buttonComputeSalary.Text = "Compute Salary";
            this.buttonComputeSalary.UseVisualStyleBackColor = false;
            this.buttonComputeSalary.Click += new System.EventHandler(this.buttonComputeSalary_Click);
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDepartment.Location = new System.Drawing.Point(32, 127);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(186, 22);
            this.textBoxDepartment.TabIndex = 16;
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJobTitle.Location = new System.Drawing.Point(238, 127);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(186, 22);
            this.textBoxJobTitle.TabIndex = 17;
            // 
            // textBoxRateperHour
            // 
            this.textBoxRateperHour.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRateperHour.Location = new System.Drawing.Point(32, 247);
            this.textBoxRateperHour.Name = "textBoxRateperHour";
            this.textBoxRateperHour.Size = new System.Drawing.Size(186, 22);
            this.textBoxRateperHour.TabIndex = 18;
            // 
            // textBoxTotalHoursWorked
            // 
            this.textBoxTotalHoursWorked.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalHoursWorked.Location = new System.Drawing.Point(238, 247);
            this.textBoxTotalHoursWorked.Name = "textBoxTotalHoursWorked";
            this.textBoxTotalHoursWorked.Size = new System.Drawing.Size(186, 22);
            this.textBoxTotalHoursWorked.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(146, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "<first name here>";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(146, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "<last name here>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(149, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "00.00";
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 507);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxTotalHoursWorked);
            this.Controls.Add(this.textBoxRateperHour);
            this.Controls.Add(this.textBoxJobTitle);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.buttonComputeSalary);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelBasicSalary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labeltotalhrswrkd);
            this.Controls.Add(this.labelrateperhr);
            this.Controls.Add(this.labeljob);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFname);
            this.Name = "frmComputeSalary";
            this.Text = "frmComputeSalary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Label labeljob;
        private System.Windows.Forms.Label labelrateperhr;
        private System.Windows.Forms.Label labeltotalhrswrkd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelBasicSalary;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button buttonComputeSalary;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.TextBox textBoxJobTitle;
        private System.Windows.Forms.TextBox textBoxRateperHour;
        private System.Windows.Forms.TextBox textBoxTotalHoursWorked;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

