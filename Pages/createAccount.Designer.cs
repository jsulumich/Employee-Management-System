namespace Human_Relations.Pages
{
    partial class createAccount
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
            this.components = new System.ComponentModel.Container();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hireDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cBoxRole = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeemgmtDataSet = new Human_Relations.employeemgmtDataSet();
            this.lblRole = new System.Windows.Forms.Label();
            this.cBoxDep = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDep = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.gBoxName = new System.Windows.Forms.GroupBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.txtZIP = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.cBoxStates = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gBoxAdminInfo = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.departmentTableAdapter = new Human_Relations.employeemgmtDataSetTableAdapters.departmentTableAdapter();
            this.roleTableAdapter = new Human_Relations.employeemgmtDataSetTableAdapters.roleTableAdapter();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeemgmtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.gBoxName.SuspendLayout();
            this.groupBoxAddress.SuspendLayout();
            this.gBoxAdminInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1027, 22);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(108, 40);
            this.btnLogOut.TabIndex = 67;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(882, 662);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(201, 35);
            this.btnCreateAccount.TabIndex = 4;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(20, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(88, 29);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(202, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(268, 35);
            this.txtEmail.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hireDateTimePicker);
            this.groupBox1.Controls.Add(this.cBoxRole);
            this.groupBox1.Controls.Add(this.lblRole);
            this.groupBox1.Controls.Add(this.cBoxDep);
            this.groupBox1.Controls.Add(this.lblDep);
            this.groupBox1.Controls.Add(this.lblHireDate);
            this.groupBox1.Controls.Add(this.lblSalary);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(591, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 259);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employment Information";
            // 
            // hireDateTimePicker
            // 
            this.hireDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hireDateTimePicker.Location = new System.Drawing.Point(196, 215);
            this.hireDateTimePicker.Name = "hireDateTimePicker";
            this.hireDateTimePicker.Size = new System.Drawing.Size(348, 30);
            this.hireDateTimePicker.TabIndex = 3;
            // 
            // cBoxRole
            // 
            this.cBoxRole.DataSource = this.roleBindingSource;
            this.cBoxRole.DisplayMember = "roleName";
            this.cBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxRole.FormattingEnabled = true;
            this.cBoxRole.Location = new System.Drawing.Point(196, 164);
            this.cBoxRole.Name = "cBoxRole";
            this.cBoxRole.Size = new System.Drawing.Size(348, 37);
            this.cBoxRole.TabIndex = 2;
            this.cBoxRole.ValueMember = "roleID";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "role";
            this.roleBindingSource.DataSource = this.employeemgmtDataSet;
            // 
            // employeemgmtDataSet
            // 
            this.employeemgmtDataSet.DataSetName = "employeemgmtDataSet";
            this.employeemgmtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(22, 167);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(70, 29);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Role:";
            // 
            // cBoxDep
            // 
            this.cBoxDep.DataSource = this.departmentBindingSource;
            this.cBoxDep.DisplayMember = "departmentName";
            this.cBoxDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDep.FormattingEnabled = true;
            this.cBoxDep.Location = new System.Drawing.Point(196, 109);
            this.cBoxDep.Name = "cBoxDep";
            this.cBoxDep.Size = new System.Drawing.Size(348, 37);
            this.cBoxDep.TabIndex = 1;
            this.cBoxDep.ValueMember = "departmentID";
            this.cBoxDep.SelectedIndexChanged += new System.EventHandler(this.cBoxDep_SelectedIndexChanged);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.employeemgmtDataSet;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.Location = new System.Drawing.Point(22, 112);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(144, 29);
            this.lblDep.TabIndex = 13;
            this.lblDep.Text = "Department:";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHireDate.Location = new System.Drawing.Point(22, 210);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(120, 29);
            this.lblHireDate.TabIndex = 11;
            this.lblHireDate.Text = "Hire Date:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(22, 55);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(86, 29);
            this.lblSalary.TabIndex = 11;
            this.lblSalary.Text = "Salary:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(196, 57);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(348, 35);
            this.txtSalary.TabIndex = 0;
            // 
            // gBoxName
            // 
            this.gBoxName.Controls.Add(this.txtEmail);
            this.gBoxName.Controls.Add(this.lblEmail);
            this.gBoxName.Controls.Add(this.lblFName);
            this.gBoxName.Controls.Add(this.lblLName);
            this.gBoxName.Controls.Add(this.txtLName);
            this.gBoxName.Controls.Add(this.txtFName);
            this.gBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxName.Location = new System.Drawing.Point(61, 129);
            this.gBoxName.Name = "gBoxName";
            this.gBoxName.Size = new System.Drawing.Size(491, 201);
            this.gBoxName.TabIndex = 0;
            this.gBoxName.TabStop = false;
            this.gBoxName.Text = "Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(20, 48);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(137, 29);
            this.lblFName.TabIndex = 10;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(20, 97);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(134, 29);
            this.lblLName.TabIndex = 41;
            this.lblLName.Text = "Last Name:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(204, 97);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(266, 35);
            this.txtLName.TabIndex = 1;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(204, 45);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(266, 35);
            this.txtFName.TabIndex = 0;
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.txtZIP);
            this.groupBoxAddress.Controls.Add(this.txtCity);
            this.groupBoxAddress.Controls.Add(this.txtAddress2);
            this.groupBoxAddress.Controls.Add(this.txtAddress1);
            this.groupBoxAddress.Controls.Add(this.cBoxStates);
            this.groupBoxAddress.Controls.Add(this.label2);
            this.groupBoxAddress.Controls.Add(this.label1);
            this.groupBoxAddress.Controls.Add(this.lblCity);
            this.groupBoxAddress.Controls.Add(this.lblAddress2);
            this.groupBoxAddress.Controls.Add(this.lblAddress1);
            this.groupBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddress.Location = new System.Drawing.Point(61, 344);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new System.Drawing.Size(491, 278);
            this.groupBoxAddress.TabIndex = 1;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Address";
            // 
            // txtZIP
            // 
            this.txtZIP.Location = new System.Drawing.Point(202, 225);
            this.txtZIP.MaxLength = 5;
            this.txtZIP.Name = "txtZIP";
            this.txtZIP.Size = new System.Drawing.Size(156, 35);
            this.txtZIP.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(202, 131);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(268, 35);
            this.txtCity.TabIndex = 2;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(202, 88);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(268, 35);
            this.txtAddress2.TabIndex = 1;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(204, 42);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(268, 35);
            this.txtAddress1.TabIndex = 0;
            // 
            // cBoxStates
            // 
            this.cBoxStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxStates.FormattingEnabled = true;
            this.cBoxStates.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NB",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cBoxStates.Location = new System.Drawing.Point(202, 180);
            this.cBoxStates.Name = "cBoxStates";
            this.cBoxStates.Size = new System.Drawing.Size(156, 37);
            this.cBoxStates.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "ZIP Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(6, 137);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(65, 29);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City: ";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(6, 92);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(179, 29);
            this.lblAddress2.TabIndex = 1;
            this.lblAddress2.Text = "Address Line 2:";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(6, 45);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(179, 29);
            this.lblAddress1.TabIndex = 0;
            this.lblAddress1.Text = "Address Line 1:";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(19, 22);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 38);
            this.btnReturn.TabIndex = 68;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(333, 77);
            this.lblDescribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(600, 31);
            this.lblDescribe.TabIndex = 62;
            this.lblDescribe.Text = "Create a new employee profile";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(328, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 62);
            this.lblTitle.TabIndex = 64;
            this.lblTitle.Text = "Employee Management";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gBoxAdminInfo
            // 
            this.gBoxAdminInfo.Controls.Add(this.txtPassword);
            this.gBoxAdminInfo.Controls.Add(this.txtUsername);
            this.gBoxAdminInfo.Controls.Add(this.lblPassword);
            this.gBoxAdminInfo.Controls.Add(this.lblUsername);
            this.gBoxAdminInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxAdminInfo.Location = new System.Drawing.Point(591, 463);
            this.gBoxAdminInfo.Name = "gBoxAdminInfo";
            this.gBoxAdminInfo.Size = new System.Drawing.Size(458, 159);
            this.gBoxAdminInfo.TabIndex = 3;
            this.gBoxAdminInfo.TabStop = false;
            this.gBoxAdminInfo.Text = "Login Information";
            this.gBoxAdminInfo.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(191, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(241, 35);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(191, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(241, 35);
            this.txtUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(14, 103);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(132, 29);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password: ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(14, 56);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(136, 29);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username: ";
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(243, 662);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(600, 35);
            this.lblError.TabIndex = 69;
            this.lblError.Text = "Error:";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblError.Visible = false;
            // 
            // createAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 721);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.gBoxAdminInfo);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxName);
            this.Controls.Add(this.groupBoxAddress);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Name = "createAccount";
            this.Text = "createAccount";
            this.Load += new System.EventHandler(this.createAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeemgmtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.gBoxName.ResumeLayout(false);
            this.gBoxName.PerformLayout();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            this.gBoxAdminInfo.ResumeLayout(false);
            this.gBoxAdminInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cBoxDep;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.GroupBox gBoxName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.TextBox txtZIP;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.ComboBox cBoxStates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gBoxAdminInfo;
        private System.Windows.Forms.Label lblHireDate;
        private employeemgmtDataSet employeemgmtDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private employeemgmtDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private employeemgmtDataSetTableAdapters.roleTableAdapter roleTableAdapter;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DateTimePicker hireDateTimePicker;
        private System.Windows.Forms.Label lblError;
    }
}