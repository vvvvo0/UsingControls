﻿namespace UsingControls
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
            groupBox1 = new GroupBox();
            txtSampleText = new TextBox();
            chkltalic = new CheckBox();
            chkBold = new CheckBox();
            cboFont = new ComboBox();
            IblFont = new Label();
            grpBar = new GroupBox();
            pgDummy = new ProgressBar();
            tbDummy = new TrackBar();
            grpForm = new GroupBox();
            btnMsgBox = new Button();
            btnModaless = new Button();
            btnModal = new Button();
            grpTreeList = new GroupBox();
            btnAddChild = new Button();
            btnAddRoot = new Button();
            lvDummy = new ListView();
            tvDummy = new TreeView();
            grpFont.SuspendLayout();
            grpBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbDummy).BeginInit();
            grpForm.SuspendLayout();
            grpTreeList.SuspendLayout();
            SuspendLayout();
            // 
            // grpFont
            // 
            grpFont.Controls.Add(groupBox1);
            grpFont.Controls.Add(txtSampleText);
            grpFont.Controls.Add(chkltalic);
            grpFont.Controls.Add(chkBold);
            grpFont.Controls.Add(cboFont);
            grpFont.Controls.Add(IblFont);
            grpFont.Location = new Point(21, 35);
            grpFont.Name = "grpFont";
            grpFont.Size = new Size(566, 157);
            grpFont.TabIndex = 0;
            grpFont.TabStop = false;
            grpFont.Text = "ComboBox, CheckBox, TextBox";
            grpFont.Enter += groupBox1_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(31, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(528, 192);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtSampleText
            // 
            txtSampleText.Location = new Point(44, 87);
            txtSampleText.Name = "txtSampleText";
            txtSampleText.Size = new Size(375, 23);
            txtSampleText.TabIndex = 4;
            txtSampleText.Text = "Hello, C#";
            // 
            // chkltalic
            // 
            chkltalic.AutoSize = true;
            chkltalic.Location = new Point(358, 45);
            chkltalic.Name = "chkltalic";
            chkltalic.Size = new Size(62, 19);
            chkltalic.TabIndex = 3;
            chkltalic.Text = "이탤릭";
            chkltalic.UseVisualStyleBackColor = true;
            chkltalic.CheckedChanged += chkItalic_CheckedChanged;
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
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // cboFont
            // 
            cboFont.FormattingEnabled = true;
            cboFont.Location = new Point(89, 43);
            cboFont.Name = "cboFont";
            cboFont.Size = new Size(198, 23);
            cboFont.TabIndex = 1;
            cboFont.SelectedIndexChanged += cboFont_SelectedIndexChanged;
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
            // grpBar
            // 
            grpBar.Controls.Add(pgDummy);
            grpBar.Controls.Add(tbDummy);
            grpBar.Location = new Point(22, 214);
            grpBar.Name = "grpBar";
            grpBar.Size = new Size(567, 189);
            grpBar.TabIndex = 1;
            grpBar.TabStop = false;
            grpBar.Text = "TrackBar && ProgressBar";
            grpBar.Enter += chkItalic_CheckedChanged;
            // 
            // pgDummy
            // 
            pgDummy.Location = new Point(21, 109);
            pgDummy.Maximum = 20;
            pgDummy.Name = "pgDummy";
            pgDummy.Size = new Size(529, 51);
            pgDummy.TabIndex = 1;
            pgDummy.Click += pgDummy_Click;
            // 
            // tbDummy
            // 
            tbDummy.Location = new Point(20, 37);
            tbDummy.Maximum = 20;
            tbDummy.Name = "tbDummy";
            tbDummy.Size = new Size(528, 45);
            tbDummy.TabIndex = 0;
            tbDummy.Scroll += tbDummy_Scroll;
            // 
            // grpForm
            // 
            grpForm.Controls.Add(btnMsgBox);
            grpForm.Controls.Add(btnModaless);
            grpForm.Controls.Add(btnModal);
            grpForm.Location = new Point(22, 427);
            grpForm.Name = "grpForm";
            grpForm.Size = new Size(565, 85);
            grpForm.TabIndex = 2;
            grpForm.TabStop = false;
            grpForm.Text = "Modal && Modaless";
            // 
            // btnMsgBox
            // 
            btnMsgBox.Location = new Point(302, 19);
            btnMsgBox.Name = "btnMsgBox";
            btnMsgBox.Size = new Size(227, 50);
            btnMsgBox.TabIndex = 2;
            btnMsgBox.Text = "MessageBox";
            btnMsgBox.UseVisualStyleBackColor = true;
            btnMsgBox.Click += btnMsgBox_Click;
            // 
            // btnModaless
            // 
            btnModaless.Location = new Point(176, 19);
            btnModaless.Name = "btnModaless";
            btnModaless.Size = new Size(120, 50);
            btnModaless.TabIndex = 1;
            btnModaless.Text = "Modaless";
            btnModaless.UseVisualStyleBackColor = true;
            btnModaless.Click += btnModaless_Click;
            // 
            // btnModal
            // 
            btnModal.Location = new Point(46, 19);
            btnModal.Name = "btnModal";
            btnModal.Size = new Size(124, 50);
            btnModal.TabIndex = 0;
            btnModal.Text = "Modal";
            btnModal.UseVisualStyleBackColor = true;
            btnModal.Click += btnModal_Click;
            // 
            // grpTreeList
            // 
            grpTreeList.Controls.Add(btnAddChild);
            grpTreeList.Controls.Add(btnAddRoot);
            grpTreeList.Controls.Add(lvDummy);
            grpTreeList.Controls.Add(tvDummy);
            grpTreeList.Location = new Point(22, 539);
            grpTreeList.Name = "grpTreeList";
            grpTreeList.Size = new Size(567, 242);
            grpTreeList.TabIndex = 3;
            grpTreeList.TabStop = false;
            grpTreeList.Text = "TreeView && ListView";
            grpTreeList.Enter += groupBox2_Enter;
            // 
            // btnAddChild
            // 
            btnAddChild.Location = new Point(176, 181);
            btnAddChild.Name = "btnAddChild";
            btnAddChild.Size = new Size(110, 40);
            btnAddChild.TabIndex = 3;
            btnAddChild.Text = "자식 추가";
            btnAddChild.UseVisualStyleBackColor = true;
            btnAddChild.Click += btnAddChild_Click;
            // 
            // btnAddRoot
            // 
            btnAddRoot.Location = new Point(47, 181);
            btnAddRoot.Name = "btnAddRoot";
            btnAddRoot.Size = new Size(123, 40);
            btnAddRoot.TabIndex = 2;
            btnAddRoot.Text = "루트 추가";
            btnAddRoot.UseVisualStyleBackColor = true;
            btnAddRoot.Click += btnAddRoot_Click;
            // 
            // lvDummy
            // 
            lvDummy.Location = new Point(297, 22);
            lvDummy.Name = "lvDummy";
            lvDummy.Size = new Size(232, 145);
            lvDummy.TabIndex = 1;
            lvDummy.UseCompatibleStateImageBehavior = false;
            lvDummy.View = View.Details;
            // 
            // tvDummy
            // 
            tvDummy.Location = new Point(46, 22);
            tvDummy.Name = "tvDummy";
            tvDummy.Size = new Size(240, 148);
            tvDummy.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 816);
            Controls.Add(grpTreeList);
            Controls.Add(grpForm);
            Controls.Add(grpBar);
            Controls.Add(grpFont);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Control Test";
            Load += MainForm_Load;
            grpFont.ResumeLayout(false);
            grpFont.PerformLayout();
            grpBar.ResumeLayout(false);
            grpBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbDummy).EndInit();
            grpForm.ResumeLayout(false);
            grpTreeList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpFont;
        private Label IblFont;
        private CheckBox chkltalic;
        private CheckBox chkBold;
        private ComboBox cboFont;
        private TextBox txtSampleText;
        private GroupBox groupBox1;
        private GroupBox grpBar;
        private ProgressBar pgDummy;
        private TrackBar tbDummy;
        private GroupBox grpForm;
        private Button btnMsgBox;
        private Button btnModaless;
        private Button btnModal;
        private GroupBox grpTreeList;
        private ListView lvDummy;
        private TreeView tvDummy;
        private Button btnAddChild;
        private Button btnAddRoot;
    }
}
