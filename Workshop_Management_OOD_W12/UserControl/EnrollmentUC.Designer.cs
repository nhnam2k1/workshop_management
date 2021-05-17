
namespace Workshop_Management_OOD_W12
{
    partial class EnrollmentUC
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
            this.lvEnrollments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvWarningSystem = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvEnrollments
            // 
            this.lvEnrollments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvEnrollments.HideSelection = false;
            this.lvEnrollments.Location = new System.Drawing.Point(3, 4);
            this.lvEnrollments.Name = "lvEnrollments";
            this.lvEnrollments.Size = new System.Drawing.Size(382, 603);
            this.lvEnrollments.TabIndex = 0;
            this.lvEnrollments.UseCompatibleStateImageBehavior = false;
            this.lvEnrollments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Student Name";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Workshop Title";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Seat / Login Code";
            this.columnHeader4.Width = 107;
            // 
            // lvWarningSystem
            // 
            this.lvWarningSystem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.lvWarningSystem.HideSelection = false;
            this.lvWarningSystem.Location = new System.Drawing.Point(391, 4);
            this.lvWarningSystem.Name = "lvWarningSystem";
            this.lvWarningSystem.Size = new System.Drawing.Size(316, 398);
            this.lvWarningSystem.TabIndex = 1;
            this.lvWarningSystem.UseCompatibleStateImageBehavior = false;
            this.lvWarningSystem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Message";
            this.columnHeader6.Width = 209;
            // 
            // EnrollmentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvWarningSystem);
            this.Controls.Add(this.lvEnrollments);
            this.Name = "EnrollmentUC";
            this.Size = new System.Drawing.Size(710, 610);
            this.Enter += new System.EventHandler(this.EnrollmentUC_Enter);
            this.Leave += new System.EventHandler(this.EnrollmentUC_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvEnrollments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvWarningSystem;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
