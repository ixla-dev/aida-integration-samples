namespace Aida.Samples.Integration.UI.Forms
{
    partial class JobStatusForm
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
            this.dataGridJobs = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJobs)).BeginInit();
            this.panel1.SuspendLayout();
            this.dataGridContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridJobs
            // 
            this.dataGridJobs.AllowUserToAddRows = false;
            this.dataGridJobs.AllowUserToDeleteRows = false;
            this.dataGridJobs.AllowUserToOrderColumns = true;
            this.dataGridJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridJobs.Location = new System.Drawing.Point(0, 0);
            this.dataGridJobs.Name = "dataGridJobs";
            this.dataGridJobs.ReadOnly = true;
            this.dataGridJobs.RowTemplate.Height = 25;
            this.dataGridJobs.Size = new System.Drawing.Size(800, 450);
            this.dataGridJobs.TabIndex = 0;
            this.dataGridJobs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridJobs_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridJobs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // dataGridContextMenu
            // 
            this.dataGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rejectToolStripMenuItem,
            this.resumeToolStripMenuItem});
            this.dataGridContextMenu.Name = "contextMenuStrip1";
            this.dataGridContextMenu.Size = new System.Drawing.Size(117, 48);
            // 
            // rejectToolStripMenuItem
            // 
            this.rejectToolStripMenuItem.Name = "rejectToolStripMenuItem";
            this.rejectToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.rejectToolStripMenuItem.Text = "Reject";
            this.rejectToolStripMenuItem.Click += new System.EventHandler(this.rejectToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.resumeToolStripMenuItem.Text = "Resume";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // JobStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "JobStatusForm";
            this.Text = "JobStatusForm";
            this.Load += new System.EventHandler(this.JobStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJobs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.dataGridContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridJobs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip dataGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem rejectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
    }
}