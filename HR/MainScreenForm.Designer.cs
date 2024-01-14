
namespace HR
{
    partial class MainScreenForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.items = new System.Windows.Forms.MenuStrip();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAddEmployee = new System.Windows.Forms.Panel();
            this.saveEmpBtn = new System.Windows.Forms.Button();
            this.nationalID = new System.Windows.Forms.TextBox();
            this.nationalIDLbl = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.TextBox();
            this.positionLbl = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.empCode = new System.Windows.Forms.TextBox();
            this.empCodeLbl = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.TextBox();
            this.empNameLbl = new System.Windows.Forms.Label();
            this.panelAllEmployees = new System.Windows.Forms.Panel();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_codeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.items.SuspendLayout();
            this.panelAddEmployee.SuspendLayout();
            this.panelAllEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // items
            // 
            this.items.Font = new System.Drawing.Font("Tajawal", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.items.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.items.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.allEmployeesToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.items.Location = new System.Drawing.Point(0, 0);
            this.items.Name = "items";
            this.items.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.items.Size = new System.Drawing.Size(613, 24);
            this.items.TabIndex = 0;
            
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.addEmployeeToolStripMenuItem.Text = "إضافة موظف";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // allEmployeesToolStripMenuItem
            // 
            this.allEmployeesToolStripMenuItem.Name = "allEmployeesToolStripMenuItem";
            this.allEmployeesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.allEmployeesToolStripMenuItem.Text = "الموظفين";
            this.allEmployeesToolStripMenuItem.Click += new System.EventHandler(this.allEmployeesToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.signOutToolStripMenuItem.Text = "تسجيل خروج";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // panelAddEmployee
            // 
            this.panelAddEmployee.Controls.Add(this.saveEmpBtn);
            this.panelAddEmployee.Controls.Add(this.nationalID);
            this.panelAddEmployee.Controls.Add(this.nationalIDLbl);
            this.panelAddEmployee.Controls.Add(this.position);
            this.panelAddEmployee.Controls.Add(this.positionLbl);
            this.panelAddEmployee.Controls.Add(this.address);
            this.panelAddEmployee.Controls.Add(this.addressLbl);
            this.panelAddEmployee.Controls.Add(this.empCode);
            this.panelAddEmployee.Controls.Add(this.empCodeLbl);
            this.panelAddEmployee.Controls.Add(this.empName);
            this.panelAddEmployee.Controls.Add(this.empNameLbl);
            this.panelAddEmployee.Location = new System.Drawing.Point(371, 27);
            this.panelAddEmployee.Name = "panelAddEmployee";
            this.panelAddEmployee.Size = new System.Drawing.Size(230, 351);
            this.panelAddEmployee.TabIndex = 1;
            this.panelAddEmployee.Visible = false;
            // 
            // saveEmpBtn
            // 
            this.saveEmpBtn.Font = new System.Drawing.Font("Tajawal Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEmpBtn.Location = new System.Drawing.Point(69, 298);
            this.saveEmpBtn.Name = "saveEmpBtn";
            this.saveEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.saveEmpBtn.TabIndex = 10;
            this.saveEmpBtn.Text = "حفظ";
            this.saveEmpBtn.UseVisualStyleBackColor = true;
            this.saveEmpBtn.Click += new System.EventHandler(this.saveEmpBtn_Click);
            // 
            // nationalID
            // 
            this.nationalID.Font = new System.Drawing.Font("Tajawal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalID.Location = new System.Drawing.Point(15, 46);
            this.nationalID.MaxLength = 10;
            this.nationalID.Name = "nationalID";
            this.nationalID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nationalID.Size = new System.Drawing.Size(195, 23);
            this.nationalID.TabIndex = 9;
            this.nationalID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nationalIDLbl
            // 
            this.nationalIDLbl.AutoSize = true;
            this.nationalIDLbl.Font = new System.Drawing.Font("Tajawal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalIDLbl.Location = new System.Drawing.Point(156, 24);
            this.nationalIDLbl.Name = "nationalIDLbl";
            this.nationalIDLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nationalIDLbl.Size = new System.Drawing.Size(54, 15);
            this.nationalIDLbl.TabIndex = 8;
            this.nationalIDLbl.Text = "رقم الهوية";
            // 
            // position
            // 
            this.position.Font = new System.Drawing.Font("Tajawal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(15, 254);
            this.position.MaxLength = 250;
            this.position.Name = "position";
            this.position.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.position.Size = new System.Drawing.Size(195, 23);
            this.position.TabIndex = 7;
            this.position.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // positionLbl
            // 
            this.positionLbl.AutoSize = true;
            this.positionLbl.Font = new System.Drawing.Font("Tajawal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLbl.Location = new System.Drawing.Point(124, 232);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.positionLbl.Size = new System.Drawing.Size(86, 15);
            this.positionLbl.TabIndex = 6;
            this.positionLbl.Text = "المسمى الوظيفي";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Tajawal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(15, 202);
            this.address.MaxLength = 250;
            this.address.Name = "address";
            this.address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.address.Size = new System.Drawing.Size(195, 23);
            this.address.TabIndex = 5;
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Tajawal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.Location = new System.Drawing.Point(169, 180);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addressLbl.Size = new System.Drawing.Size(41, 15);
            this.addressLbl.TabIndex = 4;
            this.addressLbl.Text = "العنوان";
            // 
            // empCode
            // 
            this.empCode.Font = new System.Drawing.Font("Tajawal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empCode.Location = new System.Drawing.Point(15, 150);
            this.empCode.MaxLength = 5;
            this.empCode.Name = "empCode";
            this.empCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empCode.Size = new System.Drawing.Size(195, 23);
            this.empCode.TabIndex = 3;
            this.empCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // empCodeLbl
            // 
            this.empCodeLbl.AutoSize = true;
            this.empCodeLbl.Font = new System.Drawing.Font("Tajawal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empCodeLbl.Location = new System.Drawing.Point(139, 128);
            this.empCodeLbl.Name = "empCodeLbl";
            this.empCodeLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empCodeLbl.Size = new System.Drawing.Size(71, 15);
            this.empCodeLbl.TabIndex = 2;
            this.empCodeLbl.Text = "الرقم الوظيفي";
            // 
            // empName
            // 
            this.empName.Font = new System.Drawing.Font("Tajawal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.Location = new System.Drawing.Point(15, 98);
            this.empName.MaxLength = 250;
            this.empName.Name = "empName";
            this.empName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empName.Size = new System.Drawing.Size(195, 23);
            this.empName.TabIndex = 1;
            this.empName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // empNameLbl
            // 
            this.empNameLbl.AutoSize = true;
            this.empNameLbl.Font = new System.Drawing.Font("Tajawal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameLbl.Location = new System.Drawing.Point(140, 76);
            this.empNameLbl.Name = "empNameLbl";
            this.empNameLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empNameLbl.Size = new System.Drawing.Size(70, 15);
            this.empNameLbl.TabIndex = 0;
            this.empNameLbl.Text = "اسم الموظف";
            // 
            // panelAllEmployees
            // 
            this.panelAllEmployees.Controls.Add(this.btnSaveChanges);
            this.panelAllEmployees.Controls.Add(this.deleteBtn);
            this.panelAllEmployees.Controls.Add(this.editBtn);
            this.panelAllEmployees.Controls.Add(this.dataGridViewEmployees);
            this.panelAllEmployees.Location = new System.Drawing.Point(27, 27);
            this.panelAllEmployees.Name = "panelAllEmployees";
            this.panelAllEmployees.Size = new System.Drawing.Size(571, 351);
            this.panelAllEmployees.TabIndex = 2;
            this.panelAllEmployees.Visible = false;
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.emp_codeCol,
            this.nameCol,
            this.nationalIDCol,
            this.positionCol,
            this.addressCol});
            this.dataGridViewEmployees.Location = new System.Drawing.Point(13, 12);
            this.dataGridViewEmployees.MultiSelect = false;
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tajawal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tajawal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewEmployees.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(558, 288);
            this.dataGridViewEmployees.TabIndex = 1;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "#";
            this.idCol.Name = "idCol";
            // 
            // emp_codeCol
            // 
            this.emp_codeCol.HeaderText = "الرقم الوظيفي";
            this.emp_codeCol.Name = "emp_codeCol";
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "إسم الموظف";
            this.nameCol.Name = "nameCol";
            // 
            // nationalIDCol
            // 
            this.nationalIDCol.HeaderText = "رقم الهوية";
            this.nationalIDCol.Name = "nationalIDCol";
            // 
            // positionCol
            // 
            this.positionCol.HeaderText = "المسمى الوظيفي";
            this.positionCol.Name = "positionCol";
            // 
            // addressCol
            // 
            this.addressCol.HeaderText = "العنوان";
            this.addressCol.Name = "addressCol";
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Tajawal Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(246, 315);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "تعديل";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Tajawal Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(338, 315);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "حذف";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Tajawal Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(129, 315);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(102, 23);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "حفظ التعديلات";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 406);
            this.Controls.Add(this.panelAllEmployees);
            this.Controls.Add(this.panelAddEmployee);
            this.Controls.Add(this.items);
            this.MainMenuStrip = this.items;
            this.Name = "MainScreenForm";
            this.Text = "MainScreenForm";
            this.items.ResumeLayout(false);
            this.items.PerformLayout();
            this.panelAddEmployee.ResumeLayout(false);
            this.panelAddEmployee.PerformLayout();
            this.panelAllEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip items;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Panel panelAddEmployee;
        private System.Windows.Forms.Panel panelAllEmployees;
        private System.Windows.Forms.Label empNameLbl;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.Button saveEmpBtn;
        private System.Windows.Forms.TextBox nationalID;
        private System.Windows.Forms.Label nationalIDLbl;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox empCode;
        private System.Windows.Forms.Label empCodeLbl;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_codeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCol;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}