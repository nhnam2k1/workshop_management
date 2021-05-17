
namespace Workshop_Management_OOD_W12
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnUcUsers = new System.Windows.Forms.Button();
            this.btnUcWorkshops = new System.Windows.Forms.Button();
            this.btnUcEnrollments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(118, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(710, 610);
            this.pnlMain.TabIndex = 0;
            // 
            // btnUcUsers
            // 
            this.btnUcUsers.Location = new System.Drawing.Point(12, 13);
            this.btnUcUsers.Name = "btnUcUsers";
            this.btnUcUsers.Size = new System.Drawing.Size(99, 68);
            this.btnUcUsers.TabIndex = 1;
            this.btnUcUsers.Text = "Users";
            this.btnUcUsers.UseVisualStyleBackColor = true;
            this.btnUcUsers.Click += new System.EventHandler(this.btnUcUsers_Click);
            // 
            // btnUcWorkshops
            // 
            this.btnUcWorkshops.Location = new System.Drawing.Point(12, 87);
            this.btnUcWorkshops.Name = "btnUcWorkshops";
            this.btnUcWorkshops.Size = new System.Drawing.Size(99, 68);
            this.btnUcWorkshops.TabIndex = 2;
            this.btnUcWorkshops.Text = "Workshops";
            this.btnUcWorkshops.UseVisualStyleBackColor = true;
            this.btnUcWorkshops.Click += new System.EventHandler(this.btnUcWorkshops_Click);
            // 
            // btnUcEnrollments
            // 
            this.btnUcEnrollments.Location = new System.Drawing.Point(12, 161);
            this.btnUcEnrollments.Name = "btnUcEnrollments";
            this.btnUcEnrollments.Size = new System.Drawing.Size(99, 68);
            this.btnUcEnrollments.TabIndex = 3;
            this.btnUcEnrollments.Text = "Enrollments";
            this.btnUcEnrollments.UseVisualStyleBackColor = true;
            this.btnUcEnrollments.Click += new System.EventHandler(this.btnUcEnrollments_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 625);
            this.Controls.Add(this.btnUcEnrollments);
            this.Controls.Add(this.btnUcWorkshops);
            this.Controls.Add(this.btnUcUsers);
            this.Controls.Add(this.pnlMain);
            this.Name = "Form1";
            this.Text = "Workshop Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnUcUsers;
        private System.Windows.Forms.Button btnUcWorkshops;
        private System.Windows.Forms.Button btnUcEnrollments;
    }
}

