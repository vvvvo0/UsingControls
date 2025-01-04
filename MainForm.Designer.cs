namespace UsingControls
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
            grpFont = new GroupBox();
            IblFont = new Label();
            cboFont = new ComboBox();
            chkBold = new CheckBox();
            chkIltalic = new CheckBox();
            txtSampleText = new TextBox();
            grpFont.SuspendLayout();
            SuspendLayout();
            // 
            // grpFont
            // 
            grpFont.Controls.Add(txtSampleText);
            grpFont.Controls.Add(chkIltalic);
            grpFont.Controls.Add(chkBold);
            grpFont.Controls.Add(cboFont);
            grpFont.Controls.Add(IblFont);
            grpFont.Location = new Point(21, 35);
            grpFont.Name = "grpFont";
            grpFont.Size = new Size(584, 360);
            grpFont.TabIndex = 0;
            grpFont.TabStop = false;
            grpFont.Text = "ComboBox, CheckBox, TextBox";
            grpFont.Enter += groupBox1_Enter;
            // 
            // IblFont
            // 
            IblFont.AutoSize = true;
            IblFont.Location = new Point(43, 46);
            IblFont.Name = "IblFont";
            IblFont.Size = new Size(38, 15);
            IblFont.TabIndex = 0;
            IblFont.Text = "Font :";
            // 
            // cboFont
            // 
            cboFont.FormattingEnabled = true;
            cboFont.Location = new Point(89, 43);
            cboFont.Name = "cboFont";
            cboFont.Size = new Size(198, 23);
            cboFont.TabIndex = 1;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Location = new Point(302, 45);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(50, 19);
            chkBold.TabIndex = 2;
            chkBold.Text = "굵게";
            chkBold.UseVisualStyleBackColor = true;
            // 
            // chkIltalic
            // 
            chkIltalic.AutoSize = true;
            chkIltalic.Location = new Point(358, 45);
            chkIltalic.Name = "chkIltalic";
            chkIltalic.Size = new Size(62, 19);
            chkIltalic.TabIndex = 3;
            chkIltalic.Text = "이탤릭";
            chkIltalic.UseVisualStyleBackColor = true;
            // 
            // txtSampleText
            // 
            txtSampleText.Location = new Point(44, 87);
            txtSampleText.Name = "txtSampleText";
            txtSampleText.Size = new Size(375, 23);
            txtSampleText.TabIndex = 4;
            txtSampleText.Text = "Hello, C#";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 450);
            Controls.Add(grpFont);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Control Test";
            Load += MainForm_Load;
            grpFont.ResumeLayout(false);
            grpFont.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpFont;
        private Label IblFont;
        private CheckBox chkIltalic;
        private CheckBox chkBold;
        private ComboBox cboFont;
        private TextBox txtSampleText;
    }
}
