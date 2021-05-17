
namespace Workshop_Management_OOD_W12
{
    partial class WorkshopUC
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
            this.lvWorkshops = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddWorkshop = new System.Windows.Forms.Button();
            this.btnUpdateWorkshop = new System.Windows.Forms.Button();
            this.btnRemoveWorkshop = new System.Windows.Forms.Button();
            this.tbxSearchWorkshop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeneratingFile = new System.Windows.Forms.Button();
            this.btnMarkStarted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvWorkshops
            // 
            this.lvWorkshops.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.Description});
            this.lvWorkshops.HideSelection = false;
            this.lvWorkshops.Location = new System.Drawing.Point(4, 4);
            this.lvWorkshops.Name = "lvWorkshops";
            this.lvWorkshops.Size = new System.Drawing.Size(592, 603);
            this.lvWorkshops.TabIndex = 0;
            this.lvWorkshops.UseCompatibleStateImageBehavior = false;
            this.lvWorkshops.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Created Date";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Capacity";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Teacher";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nr Students";
            this.columnHeader6.Width = 68;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Has Started ?";
            this.columnHeader7.Width = 78;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 110;
            // 
            // btnAddWorkshop
            // 
            this.btnAddWorkshop.Location = new System.Drawing.Point(602, 304);
            this.btnAddWorkshop.Name = "btnAddWorkshop";
            this.btnAddWorkshop.Size = new System.Drawing.Size(105, 23);
            this.btnAddWorkshop.TabIndex = 1;
            this.btnAddWorkshop.Text = "Add Workshop";
            this.btnAddWorkshop.UseVisualStyleBackColor = true;
            this.btnAddWorkshop.Click += new System.EventHandler(this.btnAddWorkshop_Click);
            // 
            // btnUpdateWorkshop
            // 
            this.btnUpdateWorkshop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateWorkshop.Location = new System.Drawing.Point(602, 333);
            this.btnUpdateWorkshop.Name = "btnUpdateWorkshop";
            this.btnUpdateWorkshop.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateWorkshop.TabIndex = 2;
            this.btnUpdateWorkshop.Text = "Update Workshop";
            this.btnUpdateWorkshop.UseVisualStyleBackColor = true;
            this.btnUpdateWorkshop.Click += new System.EventHandler(this.btnUpdateWorkshop_Click);
            // 
            // btnRemoveWorkshop
            // 
            this.btnRemoveWorkshop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveWorkshop.Location = new System.Drawing.Point(602, 362);
            this.btnRemoveWorkshop.Name = "btnRemoveWorkshop";
            this.btnRemoveWorkshop.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveWorkshop.TabIndex = 3;
            this.btnRemoveWorkshop.Text = "Remove Workshop";
            this.btnRemoveWorkshop.UseVisualStyleBackColor = true;
            this.btnRemoveWorkshop.Click += new System.EventHandler(this.btnRemoveWorkshop_Click);
            // 
            // tbxSearchWorkshop
            // 
            this.tbxSearchWorkshop.Location = new System.Drawing.Point(602, 40);
            this.tbxSearchWorkshop.Name = "tbxSearchWorkshop";
            this.tbxSearchWorkshop.Size = new System.Drawing.Size(105, 20);
            this.tbxSearchWorkshop.TabIndex = 4;
            this.tbxSearchWorkshop.TextChanged += new System.EventHandler(this.tbxSearchWorkshop_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // btnGeneratingFile
            // 
            this.btnGeneratingFile.Location = new System.Drawing.Point(602, 392);
            this.btnGeneratingFile.Name = "btnGeneratingFile";
            this.btnGeneratingFile.Size = new System.Drawing.Size(105, 23);
            this.btnGeneratingFile.TabIndex = 6;
            this.btnGeneratingFile.Text = "Generating file";
            this.btnGeneratingFile.UseVisualStyleBackColor = true;
            this.btnGeneratingFile.Click += new System.EventHandler(this.btnGeneratingFile_Click);
            // 
            // btnMarkStarted
            // 
            this.btnMarkStarted.Location = new System.Drawing.Point(602, 422);
            this.btnMarkStarted.Name = "btnMarkStarted";
            this.btnMarkStarted.Size = new System.Drawing.Size(105, 23);
            this.btnMarkStarted.TabIndex = 7;
            this.btnMarkStarted.Text = "Start Workshop";
            this.btnMarkStarted.UseVisualStyleBackColor = true;
            this.btnMarkStarted.Click += new System.EventHandler(this.btnMarkStarted_Click);
            // 
            // WorkshopUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMarkStarted);
            this.Controls.Add(this.btnGeneratingFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearchWorkshop);
            this.Controls.Add(this.btnRemoveWorkshop);
            this.Controls.Add(this.btnUpdateWorkshop);
            this.Controls.Add(this.btnAddWorkshop);
            this.Controls.Add(this.lvWorkshops);
            this.Name = "WorkshopUC";
            this.Size = new System.Drawing.Size(710, 610);
            this.Enter += new System.EventHandler(this.WorkshopUC_Enter);
            this.Leave += new System.EventHandler(this.WorkshopUC_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvWorkshops;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Button btnAddWorkshop;
        private System.Windows.Forms.Button btnUpdateWorkshop;
        private System.Windows.Forms.Button btnRemoveWorkshop;
        private System.Windows.Forms.TextBox tbxSearchWorkshop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeneratingFile;
        private System.Windows.Forms.Button btnMarkStarted;
    }
}
