
namespace Aida.Samples.Integration.UI.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxConnections = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtConnectionString = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIpAddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grpBoxPersoData = new System.Windows.Forms.GroupBox();
            this.lblBatchId = new System.Windows.Forms.Label();
            this.txtBatchId = new System.Windows.Forms.TextBox();
            this.pnlDataControls = new System.Windows.Forms.Panel();
            this.btnInsertRecord = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.pnlSchedulerControls = new System.Windows.Forms.Panel();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pnlJobTemplate = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbJobTemplates = new System.Windows.Forms.ComboBox();
            this.btnSelectTempalte = new System.Windows.Forms.Button();
            this.listPersoRecordsToSend = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpBoxConnections.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpBoxPersoData.SuspendLayout();
            this.pnlDataControls.SuspendLayout();
            this.pnlSchedulerControls.SuspendLayout();
            this.pnlJobTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpBoxConnections, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpBoxPersoData, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(618, 533);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpBoxConnections
            // 
            this.grpBoxConnections.Controls.Add(this.tableLayoutPanel2);
            this.grpBoxConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxConnections.Location = new System.Drawing.Point(3, 3);
            this.grpBoxConnections.Name = "grpBoxConnections";
            this.grpBoxConnections.Size = new System.Drawing.Size(612, 164);
            this.grpBoxConnections.TabIndex = 4;
            this.grpBoxConnections.TabStop = false;
            this.grpBoxConnections.Text = "Connections";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(606, 142);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.TxtConnectionString);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(600, 44);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.flowLayoutPanel2.SetFlowBreak(this.label2, true);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Database Exchange";
            // 
            // TxtConnectionString
            // 
            this.flowLayoutPanel2.SetFlowBreak(this.TxtConnectionString, true);
            this.TxtConnectionString.Location = new System.Drawing.Point(3, 18);
            this.TxtConnectionString.Name = "TxtConnectionString";
            this.TxtConnectionString.Size = new System.Drawing.Size(594, 23);
            this.TxtConnectionString.TabIndex = 1;
            this.TxtConnectionString.Text = "User ID=postgres;Password=root;Host=192.168.3.104;Port=5432;Database=ixla_iws";
            this.TxtConnectionString.TextChanged += new System.EventHandler(this.TxtConnectionString_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.TxtIpAddress);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(600, 44);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.label1, true);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Machine Address";
            // 
            // TxtIpAddress
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.TxtIpAddress, true);
            this.TxtIpAddress.Location = new System.Drawing.Point(3, 18);
            this.TxtIpAddress.Name = "TxtIpAddress";
            this.TxtIpAddress.Size = new System.Drawing.Size(594, 23);
            this.TxtIpAddress.TabIndex = 1;
            this.TxtIpAddress.Text = "http://192.168.3.104:5000";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 36);
            this.panel1.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(510, 0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(87, 36);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // grpBoxPersoData
            // 
            this.grpBoxPersoData.Controls.Add(this.lblBatchId);
            this.grpBoxPersoData.Controls.Add(this.txtBatchId);
            this.grpBoxPersoData.Controls.Add(this.pnlDataControls);
            this.grpBoxPersoData.Controls.Add(this.pnlSchedulerControls);
            this.grpBoxPersoData.Controls.Add(this.pnlJobTemplate);
            this.grpBoxPersoData.Controls.Add(this.listPersoRecordsToSend);
            this.grpBoxPersoData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxPersoData.Location = new System.Drawing.Point(3, 173);
            this.grpBoxPersoData.Name = "grpBoxPersoData";
            this.grpBoxPersoData.Size = new System.Drawing.Size(612, 357);
            this.grpBoxPersoData.TabIndex = 5;
            this.grpBoxPersoData.TabStop = false;
            this.grpBoxPersoData.Text = "Personalization Data";
            // 
            // lblBatchId
            // 
            this.lblBatchId.AutoSize = true;
            this.lblBatchId.Location = new System.Drawing.Point(9, 60);
            this.lblBatchId.Name = "lblBatchId";
            this.lblBatchId.Size = new System.Drawing.Size(47, 15);
            this.lblBatchId.TabIndex = 15;
            this.lblBatchId.Text = "BatchId";
            // 
            // txtBatchId
            // 
            this.txtBatchId.Location = new System.Drawing.Point(95, 57);
            this.txtBatchId.Name = "txtBatchId";
            this.txtBatchId.Size = new System.Drawing.Size(508, 23);
            this.txtBatchId.TabIndex = 14;
            this.txtBatchId.TextChanged += new System.EventHandler(this.txtBatchId_TextChanged);
            // 
            // pnlDataControls
            // 
            this.pnlDataControls.Controls.Add(this.btnInsertRecord);
            this.pnlDataControls.Controls.Add(this.btnAdd);
            this.pnlDataControls.Controls.Add(this.btnRemove);
            this.pnlDataControls.Controls.Add(this.btnSend);
            this.pnlDataControls.Enabled = false;
            this.pnlDataControls.Location = new System.Drawing.Point(5, 302);
            this.pnlDataControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDataControls.Name = "pnlDataControls";
            this.pnlDataControls.Size = new System.Drawing.Size(300, 51);
            this.pnlDataControls.TabIndex = 13;
            // 
            // btnInsertRecord
            // 
            this.btnInsertRecord.Location = new System.Drawing.Point(225, 0);
            this.btnInsertRecord.Name = "btnInsertRecord";
            this.btnInsertRecord.Size = new System.Drawing.Size(75, 51);
            this.btnInsertRecord.TabIndex = 6;
            this.btnInsertRecord.Text = "Insert Record";
            this.btnInsertRecord.UseVisualStyleBackColor = true;
            this.btnInsertRecord.Click += new System.EventHandler(this.btnInsertRecord_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(150, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 51);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemove.Location = new System.Drawing.Point(75, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 51);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSend.Location = new System.Drawing.Point(0, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 51);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pnlSchedulerControls
            // 
            this.pnlSchedulerControls.Controls.Add(this.btnResume);
            this.pnlSchedulerControls.Controls.Add(this.btnStart);
            this.pnlSchedulerControls.Controls.Add(this.btnStop);
            this.pnlSchedulerControls.Enabled = false;
            this.pnlSchedulerControls.Location = new System.Drawing.Point(384, 302);
            this.pnlSchedulerControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSchedulerControls.Name = "pnlSchedulerControls";
            this.pnlSchedulerControls.Size = new System.Drawing.Size(227, 51);
            this.pnlSchedulerControls.TabIndex = 12;
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(152, 0);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 51);
            this.btnResume.TabIndex = 10;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStart.Location = new System.Drawing.Point(75, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 51);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStop.Location = new System.Drawing.Point(0, 0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 51);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pnlJobTemplate
            // 
            this.pnlJobTemplate.Controls.Add(this.label3);
            this.pnlJobTemplate.Controls.Add(this.cmbJobTemplates);
            this.pnlJobTemplate.Controls.Add(this.btnSelectTempalte);
            this.pnlJobTemplate.Enabled = false;
            this.pnlJobTemplate.Location = new System.Drawing.Point(-3, 20);
            this.pnlJobTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlJobTemplate.Name = "pnlJobTemplate";
            this.pnlJobTemplate.Size = new System.Drawing.Size(618, 31);
            this.pnlJobTemplate.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "JobTemplate";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbJobTemplates
            // 
            this.cmbJobTemplates.FormattingEnabled = true;
            this.cmbJobTemplates.Location = new System.Drawing.Point(98, 4);
            this.cmbJobTemplates.Name = "cmbJobTemplates";
            this.cmbJobTemplates.Size = new System.Drawing.Size(430, 23);
            this.cmbJobTemplates.TabIndex = 7;
            this.cmbJobTemplates.SelectedIndexChanged += new System.EventHandler(this.cmbJobTemplates_SelectedIndexChanged);
            // 
            // btnSelectTempalte
            // 
            this.btnSelectTempalte.AutoSize = true;
            this.btnSelectTempalte.Location = new System.Drawing.Point(533, 3);
            this.btnSelectTempalte.Name = "btnSelectTempalte";
            this.btnSelectTempalte.Size = new System.Drawing.Size(77, 25);
            this.btnSelectTempalte.TabIndex = 6;
            this.btnSelectTempalte.Text = "Select";
            this.btnSelectTempalte.UseVisualStyleBackColor = true;
            this.btnSelectTempalte.Click += new System.EventHandler(this.btnSelectTemplate_Click);
            // 
            // listPersoRecordsToSend
            // 
            this.listPersoRecordsToSend.FormattingEnabled = true;
            this.listPersoRecordsToSend.ItemHeight = 15;
            this.listPersoRecordsToSend.Location = new System.Drawing.Point(5, 86);
            this.listPersoRecordsToSend.Name = "listPersoRecordsToSend";
            this.listPersoRecordsToSend.Size = new System.Drawing.Size(605, 214);
            this.listPersoRecordsToSend.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(618, 533);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpBoxConnections.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grpBoxPersoData.ResumeLayout(false);
            this.grpBoxPersoData.PerformLayout();
            this.pnlDataControls.ResumeLayout(false);
            this.pnlSchedulerControls.ResumeLayout(false);
            this.pnlJobTemplate.ResumeLayout(false);
            this.pnlJobTemplate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TxtIpAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listPersoRecordsToSend;
        private System.Windows.Forms.TextBox TxtConnectionString;
        private System.Windows.Forms.GroupBox grpBoxConnections;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxPersoData;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbJobTemplates;
        private System.Windows.Forms.Button btnSelectTempalte;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel pnlJobTemplate;
        private System.Windows.Forms.Panel pnlDataControls;
        private System.Windows.Forms.Panel pnlSchedulerControls;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnInsertRecord;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Label lblBatchId;
        private System.Windows.Forms.TextBox txtBatchId;
    }
}

