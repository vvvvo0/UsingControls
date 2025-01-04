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
            grpFont.SuspendLayout();
            SuspendLayout();
            // 
            // grpFont
            // 
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
            IblFont.Location = new Point(28, 43);
            IblFont.Name = "IblFont";
            IblFont.Size = new Size(31, 15);
            IblFont.TabIndex = 0;
            IblFont.Text = "Font";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpFont);
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
    }
}
