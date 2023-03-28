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
            components = new System.ComponentModel.Container();
            dataGridJobs = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            dataGridContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            rejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridJobs).BeginInit();
            panel1.SuspendLayout();
            dataGridContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridJobs
            // 
            dataGridJobs.AllowUserToAddRows = false;
            dataGridJobs.AllowUserToDeleteRows = false;
            dataGridJobs.AllowUserToOrderColumns = true;
            dataGridJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridJobs.Location = new System.Drawing.Point(0, 0);
            dataGridJobs.Name = "dataGridJobs";
            dataGridJobs.ReadOnly = true;
            dataGridJobs.RowTemplate.Height = 25;
            dataGridJobs.Size = new System.Drawing.Size(800, 450);
            dataGridJobs.TabIndex = 0;
            dataGridJobs.CellContentClick += dataGridJobs_CellContentClick;
            dataGridJobs.CellMouseClick += dataGridJobs_CellMouseClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridJobs);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 450);
            panel1.TabIndex = 1;
            // 
            // dataGridContextMenu
            // 
            dataGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { rejectToolStripMenuItem, resumeToolStripMenuItem });
            dataGridContextMenu.Name = "contextMenuStrip1";
            dataGridContextMenu.Size = new System.Drawing.Size(117, 48);
            // 
            // rejectToolStripMenuItem
            // 
            rejectToolStripMenuItem.Name = "rejectToolStripMenuItem";
            rejectToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            rejectToolStripMenuItem.Text = "Reject";
            rejectToolStripMenuItem.Click += rejectToolStripMenuItem_Click;
            // 
            // resumeToolStripMenuItem
            // 
            resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            resumeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            resumeToolStripMenuItem.Text = "Resume";
            resumeToolStripMenuItem.Click += resumeToolStripMenuItem_Click;
            // 
            // JobStatusForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel1);
            Name = "JobStatusForm";
            Text = "JobStatusForm";
            Load += JobStatusForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridJobs).EndInit();
            panel1.ResumeLayout(false);
            dataGridContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridJobs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip dataGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem rejectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
    }
}