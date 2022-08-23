using System.Drawing;

namespace FindAndReplace.App
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDir = new System.Windows.Forms.TextBox();
            this.vistaFolderBrowserDialog1 = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog();
            this.toolTip_btnSwap = new System.Windows.Forms.ToolTip(this.components);
            this.btnSwap = new System.Windows.Forms.Button();
            this.toolTip_chkIncludeFilesWithoutMatches = new System.Windows.Forms.ToolTip(this.components);
            this.chkIncludeFilesWithoutMatches = new System.Windows.Forms.CheckBox();
            this.toolTip_chkSkipBinaryFileDetection = new System.Windows.Forms.ToolTip(this.components);
            this.chkSkipBinaryFileDetection = new System.Windows.Forms.CheckBox();
            this.toolTip_chkShowEncoding = new System.Windows.Forms.ToolTip(this.components);
            this.chkShowEncoding = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExcludeDir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIncludeSubDirectories = new System.Windows.Forms.CheckBox();
            this.lblStats = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlReplace = new System.Windows.Forms.Panel();
            this.txtReplace = new System.Windows.Forms.RichTextBox();
            this.pnlFind = new System.Windows.Forms.Panel();
            this.txtFind = new System.Windows.Forms.RichTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnGenReplaceCommandLine = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnFindOnly = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkIsCaseSensitive = new System.Windows.Forms.CheckBox();
            this.chkIsRegEx = new System.Windows.Forms.CheckBox();
            this.chkKeepModifiedDate = new System.Windows.Forms.CheckBox();
            this.chkUseEscapeChars = new System.Windows.Forms.CheckBox();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.cmbEncoding = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtExcludeFileMask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileMask = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlGridResults = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtMatchesPreview = new System.Windows.Forms.RichTextBox();
            this.gvResults = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlCommandLine = new System.Windows.Forms.Panel();
            this.lblCommandLine = new System.Windows.Forms.Label();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.txtNoMatches = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlReplace.SuspendLayout();
            this.pnlFind.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlGridResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).BeginInit();
            this.panel7.SuspendLayout();
            this.pnlCommandLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // txtDir
            // 
            this.txtDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorProvider1.SetIconPadding(this.txtDir, 30);
            this.txtDir.Location = new System.Drawing.Point(82, 14);
            this.txtDir.Margin = new System.Windows.Forms.Padding(0);
            this.txtDir.MinimumSize = new System.Drawing.Size(539, 20);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(755, 20);
            this.txtDir.TabIndex = 0;
            this.txtDir.Validating += new System.ComponentModel.CancelEventHandler(this.txtDir_Validating);
            // 
            // vistaFolderBrowserDialog1
            // 
            this.vistaFolderBrowserDialog1.Description = "Select folder with files to find and replace.";
            // 
            // btnSwap
            // 
            this.btnSwap.AccessibleDescription = "";
            this.btnSwap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwap.CausesValidation = false;
            this.btnSwap.Location = new System.Drawing.Point(561, 96);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.btnSwap.Size = new System.Drawing.Size(34, 34);
            this.btnSwap.TabIndex = 1;
            this.btnSwap.Text = "↑ ↓";
            this.toolTip_btnSwap.SetToolTip(this.btnSwap, "Swap find text and replace text");
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // chkIncludeFilesWithoutMatches
            // 
            this.chkIncludeFilesWithoutMatches.AutoSize = true;
            this.chkIncludeFilesWithoutMatches.Location = new System.Drawing.Point(123, 53);
            this.chkIncludeFilesWithoutMatches.Name = "chkIncludeFilesWithoutMatches";
            this.chkIncludeFilesWithoutMatches.Size = new System.Drawing.Size(186, 19);
            this.chkIncludeFilesWithoutMatches.TabIndex = 5;
            this.chkIncludeFilesWithoutMatches.Text = "Include files without matches";
            this.toolTip_chkIncludeFilesWithoutMatches.SetToolTip(this.chkIncludeFilesWithoutMatches, "Show files without matches in results.");
            this.chkIncludeFilesWithoutMatches.UseVisualStyleBackColor = true;
            // 
            // chkSkipBinaryFileDetection
            // 
            this.chkSkipBinaryFileDetection.AutoSize = true;
            this.chkSkipBinaryFileDetection.Location = new System.Drawing.Point(3, 28);
            this.chkSkipBinaryFileDetection.Name = "chkSkipBinaryFileDetection";
            this.chkSkipBinaryFileDetection.Size = new System.Drawing.Size(161, 19);
            this.chkSkipBinaryFileDetection.TabIndex = 2;
            this.chkSkipBinaryFileDetection.Text = "Skip binary file detection";
            this.toolTip_chkSkipBinaryFileDetection.SetToolTip(this.chkSkipBinaryFileDetection, "Include binary files when searching for the string in \'Find\'.");
            this.chkSkipBinaryFileDetection.UseVisualStyleBackColor = true;
            // 
            // chkShowEncoding
            // 
            this.chkShowEncoding.AutoSize = true;
            this.chkShowEncoding.Location = new System.Drawing.Point(3, 53);
            this.chkShowEncoding.Name = "chkShowEncoding";
            this.chkShowEncoding.Size = new System.Drawing.Size(114, 19);
            this.chkShowEncoding.TabIndex = 4;
            this.chkShowEncoding.Text = "Show encoding";
            this.toolTip_chkShowEncoding.SetToolTip(this.chkShowEncoding, "Indicate encoding detected for each file");
            this.chkShowEncoding.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtExcludeDir);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.chkIncludeSubDirectories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 68);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnSelectDir);
            this.panel2.Controls.Add(this.txtDir);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 38);
            this.panel2.TabIndex = 0;
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDir.CausesValidation = false;
            this.btnSelectDir.Location = new System.Drawing.Point(847, 13);
            this.btnSelectDir.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnSelectDir.MaximumSize = new System.Drawing.Size(25, 20);
            this.btnSelectDir.MinimumSize = new System.Drawing.Size(25, 20);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(25, 20);
            this.btnSelectDir.TabIndex = 1;
            this.btnSelectDir.Text = "...";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Directory:";
            // 
            // txtExcludeDir
            // 
            this.txtExcludeDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcludeDir.Location = new System.Drawing.Point(397, 48);
            this.txtExcludeDir.MinimumSize = new System.Drawing.Size(50, 20);
            this.txtExcludeDir.Name = "txtExcludeDir";
            this.txtExcludeDir.Size = new System.Drawing.Size(440, 20);
            this.txtExcludeDir.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Exclude Dir:";
            // 
            // chkIncludeSubDirectories
            // 
            this.chkIncludeSubDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIncludeSubDirectories.AutoSize = true;
            this.chkIncludeSubDirectories.Checked = true;
            this.chkIncludeSubDirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeSubDirectories.Location = new System.Drawing.Point(82, 50);
            this.chkIncludeSubDirectories.Name = "chkIncludeSubDirectories";
            this.chkIncludeSubDirectories.Size = new System.Drawing.Size(153, 19);
            this.chkIncludeSubDirectories.TabIndex = 1;
            this.chkIncludeSubDirectories.Text = "Include sub-directories";
            this.chkIncludeSubDirectories.UseVisualStyleBackColor = true;
            this.chkIncludeSubDirectories.CheckedChanged += new System.EventHandler(this.chkIncludeSubDirectories_CheckedChanged);
            // 
            // lblStats
            // 
            this.lblStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.Location = new System.Drawing.Point(639, 122);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(237, 273);
            this.lblStats.TabIndex = 51;
            this.lblStats.Text = "Stats";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.pnlReplace);
            this.panel5.Controls.Add(this.pnlFind);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnSwap);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.flowLayoutPanel1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(881, 284);
            this.panel5.TabIndex = 2;
            // 
            // pnlReplace
            // 
            this.pnlReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReplace.Controls.Add(this.txtReplace);
            this.pnlReplace.Location = new System.Drawing.Point(80, 165);
            this.pnlReplace.Name = "pnlReplace";
            this.pnlReplace.Size = new System.Drawing.Size(470, 55);
            this.pnlReplace.TabIndex = 8;
            this.pnlReplace.Validating += new System.ComponentModel.CancelEventHandler(this.pnlReplace_Validating);
            // 
            // txtReplace
            // 
            this.txtReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReplace.CausesValidation = false;
            this.txtReplace.DetectUrls = false;
            this.txtReplace.Location = new System.Drawing.Point(0, 2);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(470, 55);
            this.txtReplace.TabIndex = 0;
            this.txtReplace.Text = "";
            this.txtReplace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReplace_KeyDown);
            this.txtReplace.Validating += new System.ComponentModel.CancelEventHandler(this.pnlReplace_Validating);
            // 
            // pnlFind
            // 
            this.pnlFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFind.Controls.Add(this.txtFind);
            this.pnlFind.Location = new System.Drawing.Point(79, 8);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(471, 50);
            this.pnlFind.TabIndex = 72;
            this.pnlFind.Validating += new System.ComponentModel.CancelEventHandler(this.pnlFind_Validating);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFind.DetectUrls = false;
            this.txtFind.Location = new System.Drawing.Point(0, 0);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(469, 50);
            this.txtFind.TabIndex = 0;
            this.txtFind.Text = "";
            this.txtFind.WordWrap = false;
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.btnReplace);
            this.panel9.Controls.Add(this.btnGenReplaceCommandLine);
            this.panel9.Location = new System.Drawing.Point(81, 226);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(469, 58);
            this.panel9.TabIndex = 1;
            // 
            // btnReplace
            // 
            this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplace.Location = new System.Drawing.Point(377, 3);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(85, 25);
            this.btnReplace.TabIndex = 0;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnGenReplaceCommandLine
            // 
            this.btnGenReplaceCommandLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenReplaceCommandLine.Location = new System.Drawing.Point(237, 30);
            this.btnGenReplaceCommandLine.Name = "btnGenReplaceCommandLine";
            this.btnGenReplaceCommandLine.Size = new System.Drawing.Size(225, 25);
            this.btnGenReplaceCommandLine.TabIndex = 1;
            this.btnGenReplaceCommandLine.Text = "Generate Replace Command Line";
            this.btnGenReplaceCommandLine.UseVisualStyleBackColor = true;
            this.btnGenReplaceCommandLine.Click += new System.EventHandler(this.btnGenReplaceCommandLine_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Replace:";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.btnFindOnly);
            this.panel8.Location = new System.Drawing.Point(455, 63);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(94, 99);
            this.panel8.TabIndex = 8;
            // 
            // btnFindOnly
            // 
            this.btnFindOnly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindOnly.Location = new System.Drawing.Point(3, 3);
            this.btnFindOnly.Name = "btnFindOnly";
            this.btnFindOnly.Size = new System.Drawing.Size(85, 25);
            this.btnFindOnly.TabIndex = 0;
            this.btnFindOnly.Text = "Find Only";
            this.btnFindOnly.UseVisualStyleBackColor = true;
            this.btnFindOnly.Click += new System.EventHandler(this.btnFindOnly_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.chkIsCaseSensitive);
            this.flowLayoutPanel1.Controls.Add(this.chkIsRegEx);
            this.flowLayoutPanel1.Controls.Add(this.chkSkipBinaryFileDetection);
            this.flowLayoutPanel1.Controls.Add(this.chkKeepModifiedDate);
            this.flowLayoutPanel1.Controls.Add(this.chkShowEncoding);
            this.flowLayoutPanel1.Controls.Add(this.chkIncludeFilesWithoutMatches);
            this.flowLayoutPanel1.Controls.Add(this.chkUseEscapeChars);
            this.flowLayoutPanel1.Controls.Add(this.lblEncoding);
            this.flowLayoutPanel1.Controls.Add(this.cmbEncoding);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(79, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(370, 99);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // chkIsCaseSensitive
            // 
            this.chkIsCaseSensitive.AutoSize = true;
            this.chkIsCaseSensitive.Location = new System.Drawing.Point(3, 3);
            this.chkIsCaseSensitive.Name = "chkIsCaseSensitive";
            this.chkIsCaseSensitive.Size = new System.Drawing.Size(107, 19);
            this.chkIsCaseSensitive.TabIndex = 0;
            this.chkIsCaseSensitive.Text = "Case sensitive";
            this.chkIsCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // chkIsRegEx
            // 
            this.chkIsRegEx.AutoSize = true;
            this.chkIsRegEx.Location = new System.Drawing.Point(116, 3);
            this.chkIsRegEx.Name = "chkIsRegEx";
            this.chkIsRegEx.Size = new System.Drawing.Size(162, 19);
            this.chkIsRegEx.TabIndex = 1;
            this.chkIsRegEx.Text = "Use regular expressions";
            this.chkIsRegEx.UseVisualStyleBackColor = true;
            // 
            // chkKeepModifiedDate
            // 
            this.chkKeepModifiedDate.AutoSize = true;
            this.chkKeepModifiedDate.Location = new System.Drawing.Point(170, 28);
            this.chkKeepModifiedDate.Name = "chkKeepModifiedDate";
            this.chkKeepModifiedDate.Size = new System.Drawing.Size(138, 19);
            this.chkKeepModifiedDate.TabIndex = 3;
            this.chkKeepModifiedDate.Text = "Keep Modified Date";
            this.chkKeepModifiedDate.UseVisualStyleBackColor = true;
            // 
            // chkUseEscapeChars
            // 
            this.chkUseEscapeChars.AutoSize = true;
            this.chkUseEscapeChars.Location = new System.Drawing.Point(3, 78);
            this.chkUseEscapeChars.Name = "chkUseEscapeChars";
            this.chkUseEscapeChars.Size = new System.Drawing.Size(127, 19);
            this.chkUseEscapeChars.TabIndex = 6;
            this.chkUseEscapeChars.Text = "Use escape chars";
            this.chkUseEscapeChars.UseVisualStyleBackColor = true;
            // 
            // lblEncoding
            // 
            this.lblEncoding.AutoSize = true;
            this.lblEncoding.Location = new System.Drawing.Point(136, 75);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(62, 15);
            this.lblEncoding.TabIndex = 7;
            this.lblEncoding.Text = "Encoding:";
            // 
            // cmbEncoding
            // 
            this.cmbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncoding.FormattingEnabled = true;
            this.cmbEncoding.Location = new System.Drawing.Point(204, 78);
            this.cmbEncoding.Name = "cmbEncoding";
            this.cmbEncoding.Size = new System.Drawing.Size(121, 21);
            this.cmbEncoding.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.txtExcludeFileMask);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(266, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 34);
            this.panel4.TabIndex = 0;
            // 
            // txtExcludeFileMask
            // 
            this.txtExcludeFileMask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcludeFileMask.Location = new System.Drawing.Point(97, 7);
            this.txtExcludeFileMask.Name = "txtExcludeFileMask";
            this.txtExcludeFileMask.Size = new System.Drawing.Size(190, 20);
            this.txtExcludeFileMask.TabIndex = 1;
            this.txtExcludeFileMask.Text = "*.dll, *.exe";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Exclude Mask:";
            // 
            // txtFileMask
            // 
            this.txtFileMask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileMask.Location = new System.Drawing.Point(82, 7);
            this.txtFileMask.Name = "txtFileMask";
            this.txtFileMask.Size = new System.Drawing.Size(178, 20);
            this.txtFileMask.TabIndex = 0;
            this.txtFileMask.Text = "*.*";
            this.txtFileMask.Validating += new System.ComponentModel.CancelEventHandler(this.txtFileMask_Validating);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "File Mask:";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.txtFileMask);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(0, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 34);
            this.panel6.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.pnlGridResults);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 575);
            this.panel3.TabIndex = 42;
            // 
            // pnlGridResults
            // 
            this.pnlGridResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGridResults.Controls.Add(this.label9);
            this.pnlGridResults.Controls.Add(this.lblResults);
            this.pnlGridResults.Controls.Add(this.txtMatchesPreview);
            this.pnlGridResults.Controls.Add(this.gvResults);
            this.pnlGridResults.Controls.Add(this.btnCancel);
            this.pnlGridResults.Controls.Add(this.lblStatus);
            this.pnlGridResults.Controls.Add(this.progressBar);
            this.pnlGridResults.Location = new System.Drawing.Point(2, 323);
            this.pnlGridResults.Name = "pnlGridResults";
            this.pnlGridResults.Size = new System.Drawing.Size(878, 245);
            this.pnlGridResults.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 58;
            this.label9.Text = "Preview:";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(9, 4);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(51, 15);
            this.lblResults.TabIndex = 52;
            this.lblResults.Text = "Results:";
            // 
            // txtMatchesPreview
            // 
            this.txtMatchesPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatchesPreview.BackColor = System.Drawing.SystemColors.Info;
            this.txtMatchesPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatchesPreview.DetectUrls = false;
            this.txtMatchesPreview.Enabled = false;
            this.txtMatchesPreview.Location = new System.Drawing.Point(81, 130);
            this.txtMatchesPreview.Name = "txtMatchesPreview";
            this.txtMatchesPreview.ReadOnly = true;
            this.txtMatchesPreview.Size = new System.Drawing.Size(789, 112);
            this.txtMatchesPreview.TabIndex = 57;
            this.txtMatchesPreview.Text = "";
            // 
            // gvResults
            // 
            this.gvResults.AllowUserToAddRows = false;
            this.gvResults.AllowUserToDeleteRows = false;
            this.gvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResults.Location = new System.Drawing.Point(81, 4);
            this.gvResults.MultiSelect = false;
            this.gvResults.Name = "gvResults";
            this.gvResults.ReadOnly = true;
            this.gvResults.RowHeadersVisible = false;
            this.gvResults.RowHeadersWidth = 51;
            this.gvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvResults.Size = new System.Drawing.Size(789, 81);
            this.gvResults.TabIndex = 51;
            this.gvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResults_CellClick);
            this.gvResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResults_CellDoubleClick);
            this.gvResults.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResults_CellClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(795, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(83, 86);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 15);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "...";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(81, 103);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(708, 23);
            this.progressBar.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.pnlCommandLine);
            this.panel7.Location = new System.Drawing.Point(-2, 327);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(884, 213);
            this.panel7.TabIndex = 40;
            // 
            // pnlCommandLine
            // 
            this.pnlCommandLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCommandLine.Controls.Add(this.lblCommandLine);
            this.pnlCommandLine.Controls.Add(this.txtCommandLine);
            this.pnlCommandLine.Controls.Add(this.txtNoMatches);
            this.pnlCommandLine.Location = new System.Drawing.Point(0, 0);
            this.pnlCommandLine.Name = "pnlCommandLine";
            this.pnlCommandLine.Size = new System.Drawing.Size(873, 108);
            this.pnlCommandLine.TabIndex = 54;
            this.pnlCommandLine.Visible = false;
            // 
            // lblCommandLine
            // 
            this.lblCommandLine.AutoSize = true;
            this.lblCommandLine.Location = new System.Drawing.Point(14, 6);
            this.lblCommandLine.Name = "lblCommandLine";
            this.lblCommandLine.Size = new System.Drawing.Size(68, 15);
            this.lblCommandLine.TabIndex = 20;
            this.lblCommandLine.Text = "Command:";
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandLine.Location = new System.Drawing.Point(82, 6);
            this.txtCommandLine.Multiline = true;
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(800, 123);
            this.txtCommandLine.TabIndex = 0;
            this.txtCommandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommandLine_KeyDown);
            // 
            // txtNoMatches
            // 
            this.txtNoMatches.AutoSize = true;
            this.txtNoMatches.Location = new System.Drawing.Point(3, 5);
            this.txtNoMatches.Name = "txtNoMatches";
            this.txtNoMatches.Size = new System.Drawing.Size(142, 15);
            this.txtNoMatches.TabIndex = 49;
            this.txtNoMatches.Text = " No matching files found.";
            this.txtNoMatches.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(884, 651);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 690);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find and Replace In Files";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlReplace.ResumeLayout(false);
            this.pnlFind.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlGridResults.ResumeLayout(false);
            this.pnlGridResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).EndInit();
            this.panel7.ResumeLayout(false);
            this.pnlCommandLine.ResumeLayout(false);
            this.pnlCommandLine.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private Ookii.Dialogs.WinForms.VistaFolderBrowserDialog vistaFolderBrowserDialog1;
		private System.Windows.Forms.ToolTip toolTip_btnSwap;
		private System.Windows.Forms.ToolTip toolTip_chkIncludeFilesWithoutMatches;
		private System.Windows.Forms.ToolTip toolTip_chkSkipBinaryFileDetection;
		private System.Windows.Forms.ToolTip toolTip_chkShowEncoding;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtExcludeDir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkIncludeSubDirectories;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtFileMask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnFindOnly;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkIsCaseSensitive;
        private System.Windows.Forms.CheckBox chkIsRegEx;
        private System.Windows.Forms.CheckBox chkSkipBinaryFileDetection;
        private System.Windows.Forms.CheckBox chkKeepModifiedDate;
        private System.Windows.Forms.CheckBox chkShowEncoding;
        private System.Windows.Forms.CheckBox chkIncludeFilesWithoutMatches;
        private System.Windows.Forms.CheckBox chkUseEscapeChars;
        private System.Windows.Forms.Label lblEncoding;
        private System.Windows.Forms.ComboBox cmbEncoding;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenReplaceCommandLine;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.RichTextBox txtFind;
        private System.Windows.Forms.Panel pnlReplace;
        private System.Windows.Forms.RichTextBox txtReplace;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnlGridResults;
        private System.Windows.Forms.Label txtNoMatches;
        private System.Windows.Forms.Label lblResults;
        public System.Windows.Forms.DataGridView gvResults;
        private System.Windows.Forms.Panel pnlCommandLine;
        private System.Windows.Forms.Label lblCommandLine;
        private System.Windows.Forms.TextBox txtCommandLine;
        private System.Windows.Forms.TextBox txtExcludeFileMask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtMatchesPreview;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.ProgressBar progressBar;
    }
}

