namespace PresentationLayer
{
    partial class AssignmentForm
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
            this.cmbDrivers = new System.Windows.Forms.ComboBox();
            this.cmbBuses = new System.Windows.Forms.ComboBox();
            this.cmbRoutes = new System.Windows.Forms.ComboBox();
            this.dtpAssignmentDate = new System.Windows.Forms.DateTimePicker();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDrivers
            // 
            this.cmbDrivers.FormattingEnabled = true;
            this.cmbDrivers.Location = new System.Drawing.Point(101, 164);
            this.cmbDrivers.Name = "cmbDrivers";
            this.cmbDrivers.Size = new System.Drawing.Size(121, 24);
            this.cmbDrivers.TabIndex = 0;
            // 
            // cmbBuses
            // 
            this.cmbBuses.FormattingEnabled = true;
            this.cmbBuses.Location = new System.Drawing.Point(306, 164);
            this.cmbBuses.Name = "cmbBuses";
            this.cmbBuses.Size = new System.Drawing.Size(122, 24);
            this.cmbBuses.TabIndex = 1;
            // 
            // cmbRoutes
            // 
            this.cmbRoutes.FormattingEnabled = true;
            this.cmbRoutes.Location = new System.Drawing.Point(484, 164);
            this.cmbRoutes.Name = "cmbRoutes";
            this.cmbRoutes.Size = new System.Drawing.Size(121, 24);
            this.cmbRoutes.TabIndex = 2;
            // 
            // dtpAssignmentDate
            // 
            this.dtpAssignmentDate.Location = new System.Drawing.Point(101, 287);
            this.dtpAssignmentDate.Name = "dtpAssignmentDate";
            this.dtpAssignmentDate.Size = new System.Drawing.Size(193, 22);
            this.dtpAssignmentDate.TabIndex = 4;
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.Location = new System.Drawing.Point(142, 393);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.RowHeadersWidth = 51;
            this.dgvAssignments.RowTemplate.Height = 24;
            this.dgvAssignments.Size = new System.Drawing.Size(518, 191);
            this.dgvAssignments.TabIndex = 5;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(510, 255);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(133, 54);
            this.btnAssign.TabIndex = 6;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(645, 607);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 54);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 800);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.dgvAssignments);
            this.Controls.Add(this.dtpAssignmentDate);
            this.Controls.Add(this.cmbRoutes);
            this.Controls.Add(this.cmbBuses);
            this.Controls.Add(this.cmbDrivers);
            this.Name = "AssignmentForm";
            this.Text = "AssignmentForm";
            this.Load += new System.EventHandler(this.AssignmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDrivers;
        private System.Windows.Forms.ComboBox cmbBuses;
        private System.Windows.Forms.ComboBox cmbRoutes;
        private System.Windows.Forms.DateTimePicker dtpAssignmentDate;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnDelete;
    }
}