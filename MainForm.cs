namespace UsingControls
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // IDE가 MainForm_Load() 이벤트 처리기의 껍데기를 만들면서 코드 편집기를 자동으로 엽니다. 
        private void MainForm_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families; // 운영체제에 설치되어 있는 폰트 목록 검색
            foreach(FontFamily font in Fonts) // cboFont 컨트롤에 각 폰트 이름 추가 
                cboFont.Items.Add(font.Name);
        }

        // cboFont, chkBold, chkItalic 컨트롤의 이벤트 처리기에서 호출하기 위한 것으로,
        // txtSampleText의 문자열 폰트를 변경하는 기능을 합니다.
        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0)
                return;

            FontStyle style = FontStyle.Regular;
            if (chkBold.Checked)
                style |= FontStyle.Bold;
            if (chkItalic.Checked)
                style |= FontStyle.Italic;

            txtSampleText.Font =
                new Font((string)cboFont.SelectedItem, 10,
                    style);
        }
    }
}
