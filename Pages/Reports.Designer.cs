namespace Human_Relations.Pages
{
    partial class Reports
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
            this.lblError = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.reportDataGrid = new System.Windows.Forms.DataGridView();
            this.cBoxDepartment = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeemgmtDataSet = new Human_Relations.employeemgmtDataSet();
            this.departmentTableAdapter = new Human_Relations.employeemgmtDataSetTableAdapters.departmentTableAdapter();
            this.cBoxRole = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleTableAdapter = new Human_Relations.employeemgmtDataSetTableAdapters.roleTableAdapter();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeemgmtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblError.Location = new System.Drawing.Point(245, 101);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(600, 38);
            this.lblError.TabIndex = 35;
            this.lblError.Text = "Error:";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(245, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 77);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Human Resources";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDepartment
            // 
            this.btnDepartment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDepartment.Location = new System.Drawing.Point(789, 188);
            this.btnDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(182, 32);
            this.btnDepartment.TabIndex = 33;
            this.btnDepartment.Text = "Department Report";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnRole
            // 
            this.btnRole.Location = new System.Drawing.Point(264, 188);
            this.btnRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(182, 32);
            this.btnRole.TabIndex = 32;
            this.btnRole.Text = "Role Report";
            this.btnRole.UseVisualStyleBackColor = true;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(890, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 35);
            this.btnLogout.TabIndex = 31;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // reportDataGrid
            // 
            this.reportDataGrid.AllowUserToAddRows = false;
            this.reportDataGrid.AllowUserToDeleteRows = false;
            this.reportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGrid.Location = new System.Drawing.Point(45, 258);
            this.reportDataGrid.Name = "reportDataGrid";
            this.reportDataGrid.ReadOnly = true;
            this.reportDataGrid.RowHeadersWidth = 62;
            this.reportDataGrid.RowTemplate.Height = 28;
            this.reportDataGrid.Size = new System.Drawing.Size(926, 328);
            this.reportDataGrid.TabIndex = 36;
            // 
            // cBoxDepartment
            // 
            this.cBoxDepartment.DataSource = this.departmentBindingSource;
            this.cBoxDepartment.DisplayMember = "departmentName";
            this.cBoxDepartment.FormattingEnabled = true;
            this.cBoxDepartment.Location = new System.Drawing.Point(580, 191);
            this.cBoxDepartment.Name = "cBoxDepartment";
            this.cBoxDepartment.Size = new System.Drawing.Size(189, 28);
            this.cBoxDepartment.TabIndex = 37;
            this.cBoxDepartment.ValueMember = "departmentID";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.employeemgmtDataSet;
            // 
            // employeemgmtDataSet
            // 
            this.employeemgmtDataSet.DataSetName = "employeemgmtDataSet";
            this.employeemgmtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // cBoxRole
            // 
            this.cBoxRole.DataSource = this.roleBindingSource;
            this.cBoxRole.DisplayMember = "roleName";
            this.cBoxRole.FormattingEnabled = true;
            this.cBoxRole.Location = new System.Drawing.Point(45, 188);
            this.cBoxRole.Name = "cBoxRole";
            this.cBoxRole.Size = new System.Drawing.Size(178, 28);
            this.cBoxRole.TabIndex = 38;
            this.cBoxRole.ValueMember = "roleID";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "role";
            this.roleBindingSource.DataSource = this.employeemgmtDataSet;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(13, 14);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 35);
            this.btnReturn.TabIndex = 39;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 652);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cBoxRole);
            this.Controls.Add(this.cBoxDepartment);
            this.Controls.Add(this.reportDataGrid);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnRole);
            this.Controls.Add(this.btnLogout);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeemgmtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView reportDataGrid;
        private System.Windows.Forms.ComboBox cBoxDepartment;
        private employeemgmtDataSet employeemgmtDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private employeemgmtDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.ComboBox cBoxRole;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private employeemgmtDataSetTableAdapters.roleTableAdapter roleTableAdapter;
        private System.Windows.Forms.Button btnReturn;
    }
}