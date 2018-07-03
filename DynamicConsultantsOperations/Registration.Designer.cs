namespace DynamicConsultantsOperations
{
    partial class Registration
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
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.registrationDataGridView = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.genderPanel = new System.Windows.Forms.Panel();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.bodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataGridView)).BeginInit();
            this.topPanel.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.genderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bodyPanel
            // 
            this.bodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyPanel.BackColor = System.Drawing.Color.LimeGreen;
            this.bodyPanel.Controls.Add(this.registrationDataGridView);
            this.bodyPanel.Controls.Add(this.topPanel);
            this.bodyPanel.Location = new System.Drawing.Point(0, 0);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(931, 564);
            this.bodyPanel.TabIndex = 0;
            // 
            // registrationDataGridView
            // 
            this.registrationDataGridView.AllowUserToAddRows = false;
            this.registrationDataGridView.AllowUserToDeleteRows = false;
            this.registrationDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrationDataGridView.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.registrationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registrationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.registrationDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.registrationDataGridView.Location = new System.Drawing.Point(0, 450);
            this.registrationDataGridView.Name = "registrationDataGridView";
            this.registrationDataGridView.ReadOnly = true;
            this.registrationDataGridView.Size = new System.Drawing.Size(800, 114);
            this.registrationDataGridView.TabIndex = 1;
            this.registrationDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registrationDataGridView_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit Column";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete Column";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.btnShowPassword);
            this.topPanel.Controls.Add(this.btnRegister);
            this.topPanel.Controls.Add(this.tableLayoutPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(931, 444);
            this.topPanel.TabIndex = 0;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowPassword.Location = new System.Drawing.Point(823, 212);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(59, 23);
            this.btnShowPassword.TabIndex = 7;
            this.btnShowPassword.Text = "Show Password";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 410F));
            this.tableLayoutPanel.Controls.Add(this.txtAge, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.txtConfirmPass, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txtPass, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.txtMail, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblMail, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblPass, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lblConfirmPass, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lblAge, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.lblGender, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.genderPanel, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(157, 98);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(660, 300);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Paint);
            // 
            // txtAge
            // 
            this.txtAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAge.Location = new System.Drawing.Point(287, 213);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(335, 24);
            this.txtAge.TabIndex = 10;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPass.Location = new System.Drawing.Point(287, 163);
            this.txtConfirmPass.Multiline = true;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(335, 24);
            this.txtConfirmPass.TabIndex = 9;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.Location = new System.Drawing.Point(287, 113);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(335, 24);
            this.txtPass.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMail.Location = new System.Drawing.Point(287, 63);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(335, 24);
            this.txtMail.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(69, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Name";
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(68, 63);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(113, 24);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "Enter E-Mail";
            // 
            // lblPass
            // 
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(54, 113);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(142, 24);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Enter Password";
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.Location = new System.Drawing.Point(40, 163);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(170, 24);
            this.lblConfirmPass.TabIndex = 3;
            this.lblConfirmPass.Text = "Re-enter Password";
            // 
            // lblAge
            // 
            this.lblAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(77, 213);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(95, 24);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Enter Age";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(59, 263);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(131, 24);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Select Gender";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(287, 13);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(335, 24);
            this.txtName.TabIndex = 6;
            // 
            // genderPanel
            // 
            this.genderPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genderPanel.Controls.Add(this.femaleRadio);
            this.genderPanel.Controls.Add(this.maleRadio);
            this.genderPanel.Location = new System.Drawing.Point(287, 263);
            this.genderPanel.Name = "genderPanel";
            this.genderPanel.Size = new System.Drawing.Size(335, 24);
            this.genderPanel.TabIndex = 11;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(192, 3);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(59, 17);
            this.femaleRadio.TabIndex = 1;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(56, 3);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(48, 17);
            this.maleRadio.TabIndex = 0;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRegister.Location = new System.Drawing.Point(380, 404);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(195, 37);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register/Update";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(931, 564);
            this.Controls.Add(this.bodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.bodyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registrationDataGridView)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.genderPanel.ResumeLayout(false);
            this.genderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel genderPanel;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DataGridView registrationDataGridView;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}