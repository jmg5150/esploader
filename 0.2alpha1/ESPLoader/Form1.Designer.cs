namespace ESPLoader
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
            this.components = new System.ComponentModel.Container();
            this.log = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFlash = new System.Windows.Forms.Button();
            this.btnProgrammingInterface = new System.Windows.Forms.Button();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutESPLoaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConsole = new System.Windows.Forms.TabPage();
            this.tabTCPServer = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgrammingProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsCOMStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearAllFiles = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.cboMemoryLocation = new System.Windows.Forms.ComboBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabConsole.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.BackColor = System.Drawing.Color.Black;
            this.log.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.log.Location = new System.Drawing.Point(0, 0);
            this.log.Margin = new System.Windows.Forms.Padding(6);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(856, 616);
            this.log.TabIndex = 12;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnFlash);
            this.groupBox1.Controls.Add(this.btnProgrammingInterface);
            this.groupBox1.Controls.Add(this.cboPorts);
            this.groupBox1.Location = new System.Drawing.Point(18, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(354, 197);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programming Interface";
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(12, 139);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 42);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset Device";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnFlash
            // 
            this.btnFlash.Enabled = false;
            this.btnFlash.Location = new System.Drawing.Point(186, 139);
            this.btnFlash.Margin = new System.Windows.Forms.Padding(6);
            this.btnFlash.Name = "btnFlash";
            this.btnFlash.Size = new System.Drawing.Size(152, 42);
            this.btnFlash.TabIndex = 12;
            this.btnFlash.Text = "Flash";
            this.btnFlash.UseVisualStyleBackColor = true;
            this.btnFlash.Click += new System.EventHandler(this.btnFlash_Click);
            // 
            // btnProgrammingInterface
            // 
            this.btnProgrammingInterface.Location = new System.Drawing.Point(12, 85);
            this.btnProgrammingInterface.Margin = new System.Windows.Forms.Padding(6);
            this.btnProgrammingInterface.Name = "btnProgrammingInterface";
            this.btnProgrammingInterface.Size = new System.Drawing.Size(326, 42);
            this.btnProgrammingInterface.TabIndex = 8;
            this.btnProgrammingInterface.Text = "Open";
            this.btnProgrammingInterface.UseVisualStyleBackColor = true;
            this.btnProgrammingInterface.Click += new System.EventHandler(this.btnProgrammingInterface_Click);
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(12, 40);
            this.cboPorts.Margin = new System.Windows.Forms.Padding(6);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(326, 33);
            this.cboPorts.TabIndex = 0;
            this.cboPorts.DropDown += new System.EventHandler(this.cboPorts_DropDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1284, 44);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 36);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutESPLoaderToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(77, 36);
            this.toolStripMenuItem2.Text = "Help";
            // 
            // aboutESPLoaderToolStripMenuItem
            // 
            this.aboutESPLoaderToolStripMenuItem.Name = "aboutESPLoaderToolStripMenuItem";
            this.aboutESPLoaderToolStripMenuItem.Size = new System.Drawing.Size(272, 36);
            this.aboutESPLoaderToolStripMenuItem.Text = "About ESPLoader";
            this.aboutESPLoaderToolStripMenuItem.Click += new System.EventHandler(this.aboutESPLoaderToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabConsole);
            this.tabControl1.Controls.Add(this.tabTCPServer);
            this.tabControl1.Location = new System.Drawing.Point(384, 75);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(876, 669);
            this.tabControl1.TabIndex = 21;
            // 
            // tabConsole
            // 
            this.tabConsole.Controls.Add(this.log);
            this.tabConsole.Location = new System.Drawing.Point(4, 34);
            this.tabConsole.Margin = new System.Windows.Forms.Padding(6);
            this.tabConsole.Name = "tabConsole";
            this.tabConsole.Padding = new System.Windows.Forms.Padding(6);
            this.tabConsole.Size = new System.Drawing.Size(868, 631);
            this.tabConsole.TabIndex = 0;
            this.tabConsole.Text = "Console";
            this.tabConsole.UseVisualStyleBackColor = true;
            // 
            // tabTCPServer
            // 
            this.tabTCPServer.Location = new System.Drawing.Point(4, 34);
            this.tabTCPServer.Margin = new System.Windows.Forms.Padding(6);
            this.tabTCPServer.Name = "tabTCPServer";
            this.tabTCPServer.Padding = new System.Windows.Forms.Padding(6);
            this.tabTCPServer.Size = new System.Drawing.Size(868, 672);
            this.tabTCPServer.TabIndex = 1;
            this.tabTCPServer.Text = "TCP Server";
            this.tabTCPServer.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabel,
            this.tsProgrammingProgress,
            this.tsCOMStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 750);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1284, 22);
            this.statusStrip.TabIndex = 22;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsStatusLabel
            // 
            this.tsStatusLabel.Name = "tsStatusLabel";
            this.tsStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tsProgrammingProgress
            // 
            this.tsProgrammingProgress.Name = "tsProgrammingProgress";
            this.tsProgrammingProgress.Size = new System.Drawing.Size(100, 32);
            this.tsProgrammingProgress.Visible = false;
            // 
            // tsCOMStatusLabel
            // 
            this.tsCOMStatusLabel.Name = "tsCOMStatusLabel";
            this.tsCOMStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnClearAllFiles);
            this.groupBox2.Controls.Add(this.lstFiles);
            this.groupBox2.Location = new System.Drawing.Point(18, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 323);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File List";
            // 
            // btnClearAllFiles
            // 
            this.btnClearAllFiles.Location = new System.Drawing.Point(197, 268);
            this.btnClearAllFiles.Margin = new System.Windows.Forms.Padding(6);
            this.btnClearAllFiles.Name = "btnClearAllFiles";
            this.btnClearAllFiles.Size = new System.Drawing.Size(141, 42);
            this.btnClearAllFiles.TabIndex = 34;
            this.btnClearAllFiles.Text = "Clear All";
            this.btnClearAllFiles.UseVisualStyleBackColor = true;
            this.btnClearAllFiles.Click += new System.EventHandler(this.btnClearAllFiles_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 25;
            this.lstFiles.Location = new System.Drawing.Point(12, 30);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(326, 229);
            this.lstFiles.TabIndex = 25;
            this.lstFiles.Click += new System.EventHandler(this.lstFiles_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddFile);
            this.groupBox3.Controls.Add(this.cboMemoryLocation);
            this.groupBox3.Controls.Add(this.txtFilePath);
            this.groupBox3.Location = new System.Drawing.Point(18, 600);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 134);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add File";
            // 
            // btnAddFile
            // 
            this.btnAddFile.Enabled = false;
            this.btnAddFile.Location = new System.Drawing.Point(197, 73);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(141, 42);
            this.btnAddFile.TabIndex = 35;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // cboMemoryLocation
            // 
            this.cboMemoryLocation.FormattingEnabled = true;
            this.cboMemoryLocation.Items.AddRange(new object[] {
            "0x00000",
            "0x01000",
            "0x40000",
            "0x41000",
            "0x7C000",
            "0x7E000"});
            this.cboMemoryLocation.Location = new System.Drawing.Point(12, 73);
            this.cboMemoryLocation.Name = "cboMemoryLocation";
            this.cboMemoryLocation.Size = new System.Drawing.Size(152, 33);
            this.cboMemoryLocation.TabIndex = 27;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 33);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(6);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(326, 31);
            this.txtFilePath.TabIndex = 33;
            this.txtFilePath.Text = "[Double-Click to Select File]";
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            this.txtFilePath.DoubleClick += new System.EventHandler(this.txtFilePath_DoubleClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(12, 268);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 42);
            this.btnRemove.TabIndex = 35;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 772);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "ESPLoader 0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabConsole.ResumeLayout(false);
            this.tabConsole.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutESPLoaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConsole;
        private System.Windows.Forms.TabPage tabTCPServer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar tsProgrammingProgress;
        private System.Windows.Forms.ToolStripStatusLabel tsCOMStatusLabel;
        private System.Windows.Forms.Button btnProgrammingInterface;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFlash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearAllFiles;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.ComboBox cboMemoryLocation;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnRemove;
    }
}

