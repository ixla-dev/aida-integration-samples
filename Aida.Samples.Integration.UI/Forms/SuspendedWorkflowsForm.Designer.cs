using System.ComponentModel;

namespace Aida.Samples.Integration.UI.Forms
{
    partial class SuspendedWorkflowsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnReject = new System.Windows.Forms.Button();
            this.BtnResume = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(800, 396);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnReject);
            this.panel2.Controls.Add(this.BtnResume);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 54);
            this.panel2.TabIndex = 0;
            // 
            // BtnReject
            // 
            this.BtnReject.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnReject.Location = new System.Drawing.Point(612, 0);
            this.BtnReject.Name = "BtnReject";
            this.BtnReject.Size = new System.Drawing.Size(94, 54);
            this.BtnReject.TabIndex = 0;
            this.BtnReject.Text = "Reject";
            this.BtnReject.UseVisualStyleBackColor = true;
            this.BtnReject.Click += new System.EventHandler(this.BtnReject_Click);
            // 
            // BtnResume
            // 
            this.BtnResume.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnResume.Location = new System.Drawing.Point(706, 0);
            this.BtnResume.Name = "BtnResume";
            this.BtnResume.Size = new System.Drawing.Size(94, 54);
            this.BtnResume.TabIndex = 0;
            this.BtnResume.Text = "Resume";
            this.BtnResume.UseVisualStyleBackColor = true;
            this.BtnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // SuspendedWorkflowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SuspendedWorkflowsForm";
            this.Text = "Received Webhooks (suspended workflows)";
            this.Load += new System.EventHandler(this.SuspendedWorkflowsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnReject;
        private System.Windows.Forms.Button BtnResume;
    }
}