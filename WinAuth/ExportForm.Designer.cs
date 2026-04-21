namespace WinAuth
{
	partial class ExportForm
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
			this.introLabel = new MetroFramework.Controls.MetroLabel();
			this.passwordCheckbox = new MetroFramework.Controls.MetroCheckBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.cancelButton = new MetroFramework.Controls.MetroButton();
			this.okButton = new MetroFramework.Controls.MetroButton();
			this.passwordField = new MetroFramework.Controls.MetroTextBox();
			this.verifyField = new MetroFramework.Controls.MetroTextBox();
			this.verifyFieldLabel = new MetroFramework.Controls.MetroLabel();
			this.passwordFieldLabel = new MetroFramework.Controls.MetroLabel();
			this.pgpCheckbox = new MetroFramework.Controls.MetroCheckBox();
			this.pgpBrowse = new MetroFramework.Controls.MetroButton();
			this.pgpField = new MetroFramework.Controls.MetroTextBox();
			this.orLabel = new MetroFramework.Controls.MetroLabel();
			this.fileField = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.browseButton = new MetroFramework.Controls.MetroButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// introLabel
			// 
			this.introLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.introLabel.Location = new System.Drawing.Point(23, 60);
			this.introLabel.Name = "introLabel";
			this.introLabel.Size = new System.Drawing.Size(484, 50);
			this.introLabel.TabIndex = 1;
			this.introLabel.Text = "这将导出一个文本文件，每行一个验证器，使用 Google 的 KeyUriFor" +
    "mat 格式，可导入 WinAuth 或其他验证器应用。";
			// 
			// passwordCheckbox
			// 
			this.passwordCheckbox.AutoSize = true;
			this.passwordCheckbox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.passwordCheckbox.Location = new System.Drawing.Point(25, 112);
			this.passwordCheckbox.Name = "passwordCheckbox";
			this.passwordCheckbox.Size = new System.Drawing.Size(252, 19);
			this.passwordCheckbox.TabIndex = 0;
			this.passwordCheckbox.Text = "使用密码保护（仅限zip文件）";
			this.passwordCheckbox.UseSelectable = true;
			this.passwordCheckbox.CheckedChanged += new System.EventHandler(this.passwordCheckbox_CheckedChanged);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Image = global::WinAuth.Properties.Resources.BluePixel;
			this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox2.Location = new System.Drawing.Point(24, 563);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(484, 1);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(432, 580);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 6;
			this.cancelButton.Text = "取消";
			this.cancelButton.UseSelectable = true;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(351, 580);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 5;
			this.okButton.Text = "确定";
			this.okButton.UseSelectable = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// passwordField
			// 
			this.passwordField.Enabled = false;
			this.passwordField.Location = new System.Drawing.Point(128, 143);
			this.passwordField.MaxLength = 32767;
			this.passwordField.Name = "passwordField";
			this.passwordField.PasswordChar = '●';
			this.passwordField.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.passwordField.SelectedText = "";
			this.passwordField.Size = new System.Drawing.Size(262, 23);
			this.passwordField.TabIndex = 1;
			this.passwordField.UseSelectable = true;
			this.passwordField.UseSystemPasswordChar = true;
			// 
			// verifyField
			// 
			this.verifyField.Enabled = false;
			this.verifyField.Location = new System.Drawing.Point(128, 172);
			this.verifyField.MaxLength = 32767;
			this.verifyField.Name = "verifyField";
			this.verifyField.PasswordChar = '●';
			this.verifyField.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.verifyField.SelectedText = "";
			this.verifyField.Size = new System.Drawing.Size(262, 23);
			this.verifyField.TabIndex = 2;
			this.verifyField.UseSelectable = true;
			this.verifyField.UseSystemPasswordChar = true;
			// 
			// verifyFieldLabel
			// 
			this.verifyFieldLabel.AutoSize = true;
			this.verifyFieldLabel.Location = new System.Drawing.Point(45, 173);
			this.verifyFieldLabel.Name = "verifyFieldLabel";
			this.verifyFieldLabel.Size = new System.Drawing.Size(41, 19);
			this.verifyFieldLabel.TabIndex = 5;
			this.verifyFieldLabel.Text = "确认";
			// 
			// passwordFieldLabel
			// 
			this.passwordFieldLabel.AutoSize = true;
			this.passwordFieldLabel.Location = new System.Drawing.Point(45, 144);
			this.passwordFieldLabel.Name = "passwordFieldLabel";
			this.passwordFieldLabel.Size = new System.Drawing.Size(63, 19);
			this.passwordFieldLabel.TabIndex = 5;
			this.passwordFieldLabel.Text = "密码";
			// 
			// pgpCheckbox
			// 
			this.pgpCheckbox.AutoSize = true;
			this.pgpCheckbox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.pgpCheckbox.Location = new System.Drawing.Point(23, 212);
			this.pgpCheckbox.Name = "pgpCheckbox";
			this.pgpCheckbox.Size = new System.Drawing.Size(205, 19);
			this.pgpCheckbox.TabIndex = 0;
			this.pgpCheckbox.Text = "使用 PGP 公钥保护";
			this.pgpCheckbox.UseSelectable = true;
			this.pgpCheckbox.CheckedChanged += new System.EventHandler(this.pgpCheckbox_CheckedChanged);
			// 
			// pgpBrowse
			// 
			this.pgpBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pgpBrowse.Location = new System.Drawing.Point(73, 363);
			this.pgpBrowse.Name = "pgpBrowse";
			this.pgpBrowse.Size = new System.Drawing.Size(186, 23);
			this.pgpBrowse.TabIndex = 8;
			this.pgpBrowse.Text = "浏览选择 PGP 密钥文件...";
			this.pgpBrowse.UseSelectable = true;
			this.pgpBrowse.Click += new System.EventHandler(this.pgpBrowseButton_Click);
			// 
			// pgpField
			// 
			this.pgpField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pgpField.Enabled = false;
			this.pgpField.Location = new System.Drawing.Point(45, 237);
			this.pgpField.MaxLength = 32767;
			this.pgpField.Multiline = true;
			this.pgpField.Name = "pgpField";
			this.pgpField.PasswordChar = '\0';
			this.pgpField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.pgpField.SelectedText = "";
			this.pgpField.Size = new System.Drawing.Size(462, 113);
			this.pgpField.TabIndex = 7;
			this.pgpField.UseSelectable = true;
			// 
			// orLabel
			// 
			this.orLabel.AutoSize = true;
			this.orLabel.Location = new System.Drawing.Point(45, 363);
			this.orLabel.Name = "orLabel";
			this.orLabel.Size = new System.Drawing.Size(22, 19);
			this.orLabel.TabIndex = 5;
			this.orLabel.Text = "或";
			// 
			// fileField
			// 
			this.fileField.Location = new System.Drawing.Point(25, 467);
			this.fileField.MaxLength = 32767;
			this.fileField.Name = "fileField";
			this.fileField.PasswordChar = '\0';
			this.fileField.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.fileField.SelectedText = "";
			this.fileField.Size = new System.Drawing.Size(401, 23);
			this.fileField.TabIndex = 9;
			this.fileField.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroLabel1.Location = new System.Drawing.Point(23, 414);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(484, 50);
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "选择要保存的文件。如果使用了密码，这将是\".zip\"文件" +
    "，如果使用了 PGP 密钥则是 .pgp 文件，否则为普通 .txt 文件";
			// 
			// browseButton
			// 
			this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.browseButton.Location = new System.Drawing.Point(432, 467);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(75, 23);
			this.browseButton.TabIndex = 8;
			this.browseButton.Text = "浏览...";
			this.browseButton.UseSelectable = true;
			this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroLabel2.Location = new System.Drawing.Point(23, 505);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(484, 50);
			this.metroLabel2.TabIndex = 1;
			this.metroLabel2.Text = "警告：如果您的验证器有自己的密码，系统会逐一询问。" +
    "取消任何密码输入将排除该验证器的导出。\r\n";
			// 
			// ExportForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(538, 626);
			this.Controls.Add(this.fileField);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.pgpBrowse);
			this.Controls.Add(this.pgpField);
			this.Controls.Add(this.verifyField);
			this.Controls.Add(this.passwordField);
			this.Controls.Add(this.orLabel);
			this.Controls.Add(this.verifyFieldLabel);
			this.Controls.Add(this.passwordFieldLabel);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pgpCheckbox);
			this.Controls.Add(this.passwordCheckbox);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.introLabel);
			this.Name = "ExportForm";
			this.Resizable = false;
			this.Text = "导出";
			this.Load += new System.EventHandler(this.ExportForm_Load);
			this.Shown += new System.EventHandler(this.ExportForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel introLabel;
		private MetroFramework.Controls.MetroCheckBox passwordCheckbox;
		private System.Windows.Forms.PictureBox pictureBox2;
		private MetroFramework.Controls.MetroButton cancelButton;
		private MetroFramework.Controls.MetroButton okButton;
		private MetroFramework.Controls.MetroTextBox passwordField;
		private MetroFramework.Controls.MetroTextBox verifyField;
		private MetroFramework.Controls.MetroLabel verifyFieldLabel;
		private MetroFramework.Controls.MetroLabel passwordFieldLabel;
		private MetroFramework.Controls.MetroCheckBox pgpCheckbox;
		private MetroFramework.Controls.MetroButton pgpBrowse;
		private MetroFramework.Controls.MetroTextBox pgpField;
		private MetroFramework.Controls.MetroLabel orLabel;
		private MetroFramework.Controls.MetroTextBox fileField;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroButton browseButton;
		private MetroFramework.Controls.MetroLabel metroLabel2;

	}
}