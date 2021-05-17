
namespace Workshop_Management_OOD_W12
{
    partial class UserUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvUsers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Overview = new System.Windows.Forms.GroupBox();
            this.lblTotalTeachers = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearchUser = new System.Windows.Forms.TextBox();
            this.btnUpdateUserForm = new System.Windows.Forms.Button();
            this.btnAddUserForm = new System.Windows.Forms.Button();
            this.Overview.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvUsers.HideSelection = false;
            this.lvUsers.Location = new System.Drawing.Point(3, 35);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(535, 572);
            this.lvUsers.TabIndex = 1;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PCN";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Birthdate";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Teacher ?";
            this.columnHeader6.Width = 69;
            // 
            // Overview
            // 
            this.Overview.Controls.Add(this.lblTotalTeachers);
            this.Overview.Controls.Add(this.lblTotalStudents);
            this.Overview.Controls.Add(this.lblTotalUsers);
            this.Overview.Controls.Add(this.label4);
            this.Overview.Controls.Add(this.label3);
            this.Overview.Controls.Add(this.label2);
            this.Overview.Location = new System.Drawing.Point(544, 464);
            this.Overview.Name = "Overview";
            this.Overview.Size = new System.Drawing.Size(163, 143);
            this.Overview.TabIndex = 6;
            this.Overview.TabStop = false;
            this.Overview.Text = "Overview";
            // 
            // lblTotalTeachers
            // 
            this.lblTotalTeachers.AutoSize = true;
            this.lblTotalTeachers.Location = new System.Drawing.Point(80, 88);
            this.lblTotalTeachers.Name = "lblTotalTeachers";
            this.lblTotalTeachers.Size = new System.Drawing.Size(35, 13);
            this.lblTotalTeachers.TabIndex = 5;
            this.lblTotalTeachers.Text = "label7";
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Location = new System.Drawing.Point(80, 53);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(35, 13);
            this.lblTotalStudents.TabIndex = 4;
            this.lblTotalStudents.Text = "label6";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Location = new System.Drawing.Point(80, 20);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(35, 13);
            this.lblTotalUsers.TabIndex = 3;
            this.lblTotalUsers.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Teachers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // tbxSearchUser
            // 
            this.tbxSearchUser.Location = new System.Drawing.Point(544, 3);
            this.tbxSearchUser.Name = "tbxSearchUser";
            this.tbxSearchUser.Size = new System.Drawing.Size(154, 20);
            this.tbxSearchUser.TabIndex = 7;
            this.tbxSearchUser.TextChanged += new System.EventHandler(this.tbxSearchUser_TextChanged);
            // 
            // btnUpdateUserForm
            // 
            this.btnUpdateUserForm.Location = new System.Drawing.Point(544, 253);
            this.btnUpdateUserForm.Name = "btnUpdateUserForm";
            this.btnUpdateUserForm.Size = new System.Drawing.Size(154, 23);
            this.btnUpdateUserForm.TabIndex = 10;
            this.btnUpdateUserForm.Text = "Update User";
            this.btnUpdateUserForm.UseVisualStyleBackColor = true;
            this.btnUpdateUserForm.Click += new System.EventHandler(this.btnUpdateUserForm_Click);
            // 
            // btnAddUserForm
            // 
            this.btnAddUserForm.Location = new System.Drawing.Point(544, 224);
            this.btnAddUserForm.Name = "btnAddUserForm";
            this.btnAddUserForm.Size = new System.Drawing.Size(154, 23);
            this.btnAddUserForm.TabIndex = 9;
            this.btnAddUserForm.Text = "Add User";
            this.btnAddUserForm.UseVisualStyleBackColor = true;
            this.btnAddUserForm.Click += new System.EventHandler(this.btnAddUserForm_Click);
            // 
            // UserUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdateUserForm);
            this.Controls.Add(this.btnAddUserForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearchUser);
            this.Controls.Add(this.Overview);
            this.Controls.Add(this.lvUsers);
            this.Name = "UserUC";
            this.Size = new System.Drawing.Size(710, 610);
            this.Enter += new System.EventHandler(this.UserUC_Enter);
            this.Leave += new System.EventHandler(this.UserUC_Leave);
            this.Overview.ResumeLayout(false);
            this.Overview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox Overview;
        private System.Windows.Forms.Label lblTotalTeachers;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearchUser;
        private System.Windows.Forms.Button btnUpdateUserForm;
        private System.Windows.Forms.Button btnAddUserForm;
    }
}
