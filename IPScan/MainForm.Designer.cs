namespace IPScan
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpResult = new System.Windows.Forms.TabPage();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.ipZone = new System.Windows.Forms.ComboBox();
            this.ipPreffix = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.ipEnd = new System.Windows.Forms.TextBox();
            this.ipStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bgwScanThread = new System.ComponentModel.BackgroundWorker();
            this.bsResult = new System.Windows.Forms.BindingSource(this.components);
            this.stLog = new System.Windows.Forms.StatusStrip();
            this.lElapsed = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.logConsole = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).BeginInit();
            this.stLog.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpResult);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 256);
            this.tabControl1.TabIndex = 2;
            // 
            // tpResult
            // 
            this.tpResult.Controls.Add(this.dgvResult);
            this.tpResult.Location = new System.Drawing.Point(4, 22);
            this.tpResult.Name = "tpResult";
            this.tpResult.Padding = new System.Windows.Forms.Padding(3);
            this.tpResult.Size = new System.Drawing.Size(276, 230);
            this.tpResult.TabIndex = 0;
            this.tpResult.Text = "Result";
            this.tpResult.UseVisualStyleBackColor = true;
            // 
            // dgvResult
            // 
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(3, 3);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 23;
            this.dgvResult.Size = new System.Drawing.Size(270, 224);
            this.dgvResult.TabIndex = 0;
            // 
            // ipZone
            // 
            this.ipZone.FormattingEnabled = true;
            this.ipZone.Items.AddRange(new object[] {
            "10.",
            "172.16.",
            "192.168.",
            "127."});
            this.ipZone.Location = new System.Drawing.Point(4, 19);
            this.ipZone.Name = "ipZone";
            this.ipZone.Size = new System.Drawing.Size(91, 21);
            this.ipZone.TabIndex = 3;
            this.ipZone.Text = "Частные диапазоны IP-адресов";
            // 
            // ipPreffix
            // 
            this.ipPreffix.Location = new System.Drawing.Point(101, 19);
            this.ipPreffix.Name = "ipPreffix";
            this.ipPreffix.Size = new System.Drawing.Size(46, 21);
            this.ipPreffix.TabIndex = 4;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(283, 3);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(67, 46);
            this.btnScan.TabIndex = 5;
            this.btnScan.Text = "scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // ipEnd
            // 
            this.ipEnd.Location = new System.Drawing.Point(62, 19);
            this.ipEnd.Name = "ipEnd";
            this.ipEnd.Size = new System.Drawing.Size(46, 21);
            this.ipEnd.TabIndex = 6;
            // 
            // ipStart
            // 
            this.ipStart.Location = new System.Drawing.Point(6, 19);
            this.ipStart.Name = "ipStart";
            this.ipStart.Size = new System.Drawing.Size(44, 21);
            this.ipStart.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ipZone);
            this.groupBox1.Controls.Add(this.ipPreffix);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 46);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Head and Preffix";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ipEnd);
            this.groupBox2.Controls.Add(this.ipStart);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(162, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 46);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interval";
            // 
            // bgwScanThread
            // 
            this.bgwScanThread.WorkerReportsProgress = true;
            this.bgwScanThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwScanThread_DoWorkAsync);
            this.bgwScanThread.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwScanThread_ProgressChanged);
            this.bgwScanThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwScanThread_RunWorkerCompleted);
            // 
            // bsResult
            // 
            this.bsResult.AllowNew = false;
            // 
            // stLog
            // 
            this.stLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lElapsed,
            this.pbStatus,
            this.lTotal});
            this.stLog.Location = new System.Drawing.Point(0, 291);
            this.stLog.Name = "stLog";
            this.stLog.Size = new System.Drawing.Size(328, 22);
            this.stLog.TabIndex = 12;
            this.stLog.Text = "statusStrip1";
            this.stLog.Visible = false;
            // 
            // lElapsed
            // 
            this.lElapsed.Name = "lElapsed";
            this.lElapsed.Size = new System.Drawing.Size(101, 17);
            this.lElapsed.Text = "Elapsed :{elapsed}";
            // 
            // pbStatus
            // 
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(100, 16);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.logConsole);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 230);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // logConsole
            // 
            this.logConsole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logConsole.CausesValidation = false;
            this.logConsole.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logConsole.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logConsole.ForeColor = System.Drawing.Color.ForestGreen;
            this.logConsole.Location = new System.Drawing.Point(3, 3);
            this.logConsole.Multiline = true;
            this.logConsole.Name = "logConsole";
            this.logConsole.ReadOnly = true;
            this.logConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logConsole.ShortcutsEnabled = false;
            this.logConsole.Size = new System.Drawing.Size(340, 224);
            this.logConsole.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(354, 313);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.btnScan);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 53);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // lTotal
            // 
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(75, 17);
            this.lTotal.Text = "Total: {Total}";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 313);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.stLog);
            this.Name = "MainForm";
            this.Text = "IPScan+";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).EndInit();
            this.stLog.ResumeLayout(false);
            this.stLog.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpResult;
        private System.Windows.Forms.ComboBox ipZone;
        private System.Windows.Forms.TextBox ipPreffix;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox ipEnd;
        private System.Windows.Forms.TextBox ipStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker bgwScanThread;
        private System.Windows.Forms.BindingSource bsResult;
        private System.Windows.Forms.StatusStrip stLog;
        private System.Windows.Forms.ToolStripStatusLabel lElapsed;
        private System.Windows.Forms.ToolStripProgressBar pbStatus;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox logConsole;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripStatusLabel lTotal;
    }
}

