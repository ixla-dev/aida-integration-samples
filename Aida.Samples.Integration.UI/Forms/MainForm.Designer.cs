
using System.Windows.Forms;

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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            grpBoxConnections = new System.Windows.Forms.GroupBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            pnlDbConnection = new System.Windows.Forms.FlowLayoutPanel();
            lblConnectionString = new System.Windows.Forms.Label();
            TxtConnectionString = new System.Windows.Forms.TextBox();
            pnlMachineAddress = new System.Windows.Forms.FlowLayoutPanel();
            lblMachineAddress = new System.Windows.Forms.Label();
            TxtIpAddress = new System.Windows.Forms.TextBox();
            pnlConnectButton = new System.Windows.Forms.Panel();
            btnConnect = new System.Windows.Forms.Button();
            grpBoxPersoData = new System.Windows.Forms.GroupBox();
            pnlDataControls = new System.Windows.Forms.Panel();
            btnClearJobs = new System.Windows.Forms.Button();
            btnInsertRecord = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            btnRemove = new System.Windows.Forms.Button();
            btnSend = new System.Windows.Forms.Button();
            pnlSchedulerControls = new System.Windows.Forms.Panel();
            btnResume = new System.Windows.Forms.Button();
            btnStart = new System.Windows.Forms.Button();
            btnStop = new System.Windows.Forms.Button();
            pnlJobTemplate = new System.Windows.Forms.Panel();
            lblWorkflow = new System.Windows.Forms.Label();
            txtBatchId = new System.Windows.Forms.TextBox();
            lblBatchId = new System.Windows.Forms.Label();
            cmbBoxWorkflows = new System.Windows.Forms.ComboBox();
            checkBoxDryRun = new System.Windows.Forms.CheckBox();
            label3 = new System.Windows.Forms.Label();
            cmbJobTemplates = new System.Windows.Forms.ComboBox();
            listPersoRecordsToSend = new System.Windows.Forms.ListBox();
            tableLayoutPanel1.SuspendLayout();
            grpBoxConnections.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnlDbConnection.SuspendLayout();
            pnlMachineAddress.SuspendLayout();
            pnlConnectButton.SuspendLayout();
            grpBoxPersoData.SuspendLayout();
            pnlDataControls.SuspendLayout();
            pnlSchedulerControls.SuspendLayout();
            pnlJobTemplate.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(grpBoxConnections, 0, 0);
            tableLayoutPanel1.Controls.Add(grpBoxPersoData, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(706, 767);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // grpBoxConnections
            // 
            grpBoxConnections.Controls.Add(tableLayoutPanel2);
            grpBoxConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            grpBoxConnections.Location = new System.Drawing.Point(3, 4);
            grpBoxConnections.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpBoxConnections.Name = "grpBoxConnections";
            grpBoxConnections.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpBoxConnections.Size = new System.Drawing.Size(700, 219);
            grpBoxConnections.TabIndex = 4;
            grpBoxConnections.TabStop = false;
            grpBoxConnections.Text = "Connections";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(pnlDbConnection, 0, 1);
            tableLayoutPanel2.Controls.Add(pnlMachineAddress, 0, 0);
            tableLayoutPanel2.Controls.Add(pnlConnectButton, 0, 2);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 24);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new System.Drawing.Size(694, 191);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pnlDbConnection
            // 
            pnlDbConnection.Controls.Add(lblConnectionString);
            pnlDbConnection.Controls.Add(TxtConnectionString);
            pnlDbConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDbConnection.Location = new System.Drawing.Point(3, 71);
            pnlDbConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDbConnection.Name = "pnlDbConnection";
            pnlDbConnection.Size = new System.Drawing.Size(688, 59);
            pnlDbConnection.TabIndex = 1;
            // 
            // lblConnectionString
            // 
            lblConnectionString.AutoSize = true;
            pnlDbConnection.SetFlowBreak(lblConnectionString, true);
            lblConnectionString.Location = new System.Drawing.Point(3, 0);
            lblConnectionString.Name = "lblConnectionString";
            lblConnectionString.Size = new System.Drawing.Size(139, 20);
            lblConnectionString.TabIndex = 5;
            lblConnectionString.Text = "Database Exchange";
            // 
            // TxtConnectionString
            // 
            pnlDbConnection.SetFlowBreak(TxtConnectionString, true);
            TxtConnectionString.Location = new System.Drawing.Point(3, 24);
            TxtConnectionString.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TxtConnectionString.Name = "TxtConnectionString";
            TxtConnectionString.Size = new System.Drawing.Size(678, 27);
            TxtConnectionString.TabIndex = 1;
            TxtConnectionString.Text = "User ID=postgres;Password=root;Host=192.168.3.104;Port=5432;Database=ixla_iws";
            TxtConnectionString.TextChanged += TxtConnectionString_TextChanged;
            // 
            // pnlMachineAddress
            // 
            pnlMachineAddress.Controls.Add(lblMachineAddress);
            pnlMachineAddress.Controls.Add(TxtIpAddress);
            pnlMachineAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMachineAddress.Location = new System.Drawing.Point(3, 4);
            pnlMachineAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlMachineAddress.Name = "pnlMachineAddress";
            pnlMachineAddress.Size = new System.Drawing.Size(688, 59);
            pnlMachineAddress.TabIndex = 0;
            // 
            // lblMachineAddress
            // 
            lblMachineAddress.AutoSize = true;
            pnlMachineAddress.SetFlowBreak(lblMachineAddress, true);
            lblMachineAddress.Location = new System.Drawing.Point(3, 0);
            lblMachineAddress.Name = "lblMachineAddress";
            lblMachineAddress.Size = new System.Drawing.Size(122, 20);
            lblMachineAddress.TabIndex = 5;
            lblMachineAddress.Text = "Machine Address";
            // 
            // TxtIpAddress
            // 
            pnlMachineAddress.SetFlowBreak(TxtIpAddress, true);
            TxtIpAddress.Location = new System.Drawing.Point(3, 24);
            TxtIpAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TxtIpAddress.Name = "TxtIpAddress";
            TxtIpAddress.Size = new System.Drawing.Size(678, 27);
            TxtIpAddress.TabIndex = 1;
            TxtIpAddress.Text = "http://192.168.3.104:5000";
            // 
            // pnlConnectButton
            // 
            pnlConnectButton.Controls.Add(btnConnect);
            pnlConnectButton.Location = new System.Drawing.Point(3, 138);
            pnlConnectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlConnectButton.Name = "pnlConnectButton";
            pnlConnectButton.Size = new System.Drawing.Size(686, 43);
            pnlConnectButton.TabIndex = 2;
            // 
            // btnConnect
            // 
            btnConnect.Location = new System.Drawing.Point(569, 0);
            btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new System.Drawing.Size(113, 43);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // grpBoxPersoData
            // 
            grpBoxPersoData.Controls.Add(pnlDataControls);
            grpBoxPersoData.Controls.Add(pnlSchedulerControls);
            grpBoxPersoData.Controls.Add(pnlJobTemplate);
            grpBoxPersoData.Controls.Add(listPersoRecordsToSend);
            grpBoxPersoData.Dock = System.Windows.Forms.DockStyle.Fill;
            grpBoxPersoData.Location = new System.Drawing.Point(3, 231);
            grpBoxPersoData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpBoxPersoData.Name = "grpBoxPersoData";
            grpBoxPersoData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpBoxPersoData.Size = new System.Drawing.Size(700, 532);
            grpBoxPersoData.TabIndex = 5;
            grpBoxPersoData.TabStop = false;
            grpBoxPersoData.Text = "Startup Parameters";
            // 
            // pnlDataControls
            // 
            pnlDataControls.Controls.Add(btnClearJobs);
            pnlDataControls.Controls.Add(btnInsertRecord);
            pnlDataControls.Controls.Add(btnAdd);
            pnlDataControls.Controls.Add(btnRemove);
            pnlDataControls.Controls.Add(btnSend);
            pnlDataControls.Enabled = false;
            pnlDataControls.Location = new System.Drawing.Point(6, 456);
            pnlDataControls.Name = "pnlDataControls";
            pnlDataControls.Size = new System.Drawing.Size(426, 68);
            pnlDataControls.TabIndex = 13;
            // 
            // btnClearJobs
            // 
            btnClearJobs.Location = new System.Drawing.Point(340, 0);
            btnClearJobs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClearJobs.Name = "btnClearJobs";
            btnClearJobs.Size = new System.Drawing.Size(85, 68);
            btnClearJobs.TabIndex = 6;
            btnClearJobs.Text = "Clear Jobs";
            btnClearJobs.UseVisualStyleBackColor = true;
            btnClearJobs.Click += btnClearJobs_Click;
            // 
            // btnInsertRecord
            // 
            btnInsertRecord.Location = new System.Drawing.Point(255, 0);
            btnInsertRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnInsertRecord.Name = "btnInsertRecord";
            btnInsertRecord.Size = new System.Drawing.Size(85, 68);
            btnInsertRecord.TabIndex = 6;
            btnInsertRecord.Text = "Insert Record";
            btnInsertRecord.UseVisualStyleBackColor = true;
            btnInsertRecord.Click += btnInsertRecord_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            btnAdd.Location = new System.Drawing.Point(170, 0);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(85, 68);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            btnRemove.Location = new System.Drawing.Point(85, 0);
            btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(85, 68);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSend
            // 
            btnSend.Dock = System.Windows.Forms.DockStyle.Left;
            btnSend.Location = new System.Drawing.Point(0, 0);
            btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(85, 68);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // pnlSchedulerControls
            // 
            pnlSchedulerControls.Controls.Add(btnResume);
            pnlSchedulerControls.Controls.Add(btnStart);
            pnlSchedulerControls.Controls.Add(btnStop);
            pnlSchedulerControls.Enabled = false;
            pnlSchedulerControls.Location = new System.Drawing.Point(438, 456);
            pnlSchedulerControls.Name = "pnlSchedulerControls";
            pnlSchedulerControls.Size = new System.Drawing.Size(259, 68);
            pnlSchedulerControls.TabIndex = 12;
            // 
            // btnResume
            // 
            btnResume.Location = new System.Drawing.Point(174, 0);
            btnResume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnResume.Name = "btnResume";
            btnResume.Size = new System.Drawing.Size(86, 68);
            btnResume.TabIndex = 10;
            btnResume.Text = "Resume";
            btnResume.UseVisualStyleBackColor = true;
            btnResume.Click += btnResume_Click;
            // 
            // btnStart
            // 
            btnStart.Dock = System.Windows.Forms.DockStyle.Left;
            btnStart.Location = new System.Drawing.Point(86, 0);
            btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(86, 68);
            btnStart.TabIndex = 9;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // btnStart.Click += (sender, args) => MessageBox.Show("handler 1");
            // btnStart.Click += (sender, args) => MessageBox.Show("handler 2");
            // 
            // btnStop
            // 
            btnStop.Dock = System.Windows.Forms.DockStyle.Left;
            btnStop.Location = new System.Drawing.Point(0, 0);
            btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(86, 68);
            btnStop.TabIndex = 9;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // pnlJobTemplate
            // 
            pnlJobTemplate.Controls.Add(lblWorkflow);
            pnlJobTemplate.Controls.Add(txtBatchId);
            pnlJobTemplate.Controls.Add(lblBatchId);
            pnlJobTemplate.Controls.Add(cmbBoxWorkflows);
            pnlJobTemplate.Controls.Add(checkBoxDryRun);
            pnlJobTemplate.Controls.Add(label3);
            pnlJobTemplate.Controls.Add(cmbJobTemplates);
            pnlJobTemplate.Enabled = false;
            pnlJobTemplate.Location = new System.Drawing.Point(-3, 27);
            pnlJobTemplate.Name = "pnlJobTemplate";
            pnlJobTemplate.Size = new System.Drawing.Size(706, 132);
            pnlJobTemplate.TabIndex = 11;
            // 
            // lblWorkflow
            // 
            lblWorkflow.AutoSize = true;
            lblWorkflow.Location = new System.Drawing.Point(24, 48);
            lblWorkflow.Name = "lblWorkflow";
            lblWorkflow.Size = new System.Drawing.Size(72, 20);
            lblWorkflow.TabIndex = 17;
            lblWorkflow.Text = "Workflow";
            // 
            // txtBatchId
            // 
            txtBatchId.Location = new System.Drawing.Point(113, 83);
            txtBatchId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtBatchId.Name = "txtBatchId";
            txtBatchId.Size = new System.Drawing.Size(405, 27);
            txtBatchId.TabIndex = 14;
            // 
            // lblBatchId
            // 
            lblBatchId.AutoSize = true;
            lblBatchId.Location = new System.Drawing.Point(37, 87);
            lblBatchId.Name = "lblBatchId";
            lblBatchId.Size = new System.Drawing.Size(59, 20);
            lblBatchId.TabIndex = 15;
            lblBatchId.Text = "BatchId";
            // 
            // cmbBoxWorkflows
            // 
            cmbBoxWorkflows.FormattingEnabled = true;
            cmbBoxWorkflows.Location = new System.Drawing.Point(113, 44);
            cmbBoxWorkflows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbBoxWorkflows.Name = "cmbBoxWorkflows";
            cmbBoxWorkflows.Size = new System.Drawing.Size(579, 28);
            cmbBoxWorkflows.TabIndex = 16;
            // 
            // checkBoxDryRun
            // 
            checkBoxDryRun.AutoSize = true;
            checkBoxDryRun.Location = new System.Drawing.Point(527, 85);
            checkBoxDryRun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkBoxDryRun.Name = "checkBoxDryRun";
            checkBoxDryRun.Size = new System.Drawing.Size(168, 24);
            checkBoxDryRun.TabIndex = 18;
            checkBoxDryRun.Text = "Disable Laser Source";
            checkBoxDryRun.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 20);
            label3.TabIndex = 8;
            label3.Text = "JobTemplate";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbJobTemplates
            // 
            cmbJobTemplates.FormattingEnabled = true;
            cmbJobTemplates.Location = new System.Drawing.Point(113, 5);
            cmbJobTemplates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbJobTemplates.Name = "cmbJobTemplates";
            cmbJobTemplates.Size = new System.Drawing.Size(579, 28);
            cmbJobTemplates.TabIndex = 7;
            cmbJobTemplates.SelectedIndexChanged += cmbJobTemplates_SelectedIndexChanged;
            // 
            // listPersoRecordsToSend
            // 
            listPersoRecordsToSend.FormattingEnabled = true;
            listPersoRecordsToSend.ItemHeight = 20;
            listPersoRecordsToSend.Location = new System.Drawing.Point(6, 205);
            listPersoRecordsToSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listPersoRecordsToSend.Name = "listPersoRecordsToSend";
            listPersoRecordsToSend.Size = new System.Drawing.Size(691, 244);
            listPersoRecordsToSend.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(706, 767);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Form1";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            grpBoxConnections.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            pnlDbConnection.ResumeLayout(false);
            pnlDbConnection.PerformLayout();
            pnlMachineAddress.ResumeLayout(false);
            pnlMachineAddress.PerformLayout();
            pnlConnectButton.ResumeLayout(false);
            grpBoxPersoData.ResumeLayout(false);
            pnlDataControls.ResumeLayout(false);
            pnlSchedulerControls.ResumeLayout(false);
            pnlJobTemplate.ResumeLayout(false);
            pnlJobTemplate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listPersoRecordsToSend;
        private System.Windows.Forms.GroupBox grpBoxConnections;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grpBoxPersoData;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbJobTemplates;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel pnlJobTemplate;
        private System.Windows.Forms.Panel pnlDataControls;
        private System.Windows.Forms.Panel pnlSchedulerControls;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnInsertRecord;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.CheckBox checkBoxDryRun;
        private System.Windows.Forms.Label lblWorkflow;
        private System.Windows.Forms.ComboBox cmbBoxWorkflows;
        private System.Windows.Forms.Label lblBatchId;
        private System.Windows.Forms.TextBox txtBatchId;
        private System.Windows.Forms.FlowLayoutPanel pnlDbConnection;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.TextBox TxtConnectionString;
        private System.Windows.Forms.FlowLayoutPanel pnlMachineAddress;
        private System.Windows.Forms.Label lblMachineAddress;
        private System.Windows.Forms.TextBox TxtIpAddress;
        private System.Windows.Forms.Panel pnlConnectButton;
        private System.Windows.Forms.Button btnClearJobs;
    }
}

