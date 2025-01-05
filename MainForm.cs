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

        // IDE�� MainForm_Load() �̺�Ʈ ó������ �����⸦ ����鼭 �ڵ� �����⸦ �ڵ����� ���ϴ�. 
        private void MainForm_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families; // �ü���� ��ġ�Ǿ� �ִ� ��Ʈ ��� �˻�
            foreach (FontFamily font in Fonts) // cboFont ��Ʈ�ѿ� �� ��Ʈ �̸� �߰� 
                cboFont.Items.Add(font.Name);
        }


        // cboFont, chkBold, chkItalic ��Ʈ���� �̺�Ʈ ó���⿡�� ȣ���ϱ� ���� ������,
        // txtSampleText�� ���ڿ� ��Ʈ�� �����ϴ� ����� �մϴ�.
        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0) // cboFont���� ������ �׸��� ������ �޼��� ����
                return;

            FontStyle style = FontStyle.Regular; // FontStyle ��ü�� �ʱ�ȭ

            if (chkBold.Checked) // ���� "����" üũ �ڽ��� ���õǾ� ������ Bold ���� ������
                style |= FontStyle.Bold;

            if (chkltalic.Checked) // ���� "���Ÿ�" üũ �ڽ��� ���õǾ� ������ Italic ���� ������
                style |= FontStyle.Italic;

            txtSampleText.Font =     // txtSampleText�� Font ������Ƽ�� �տ��� ���� style�� ������
                new Font((string)cboFont.SelectedItem, 10, style);
        }


        // �� ��Ʈ�ѿ� ���� �̺�Ʈ ó���� �����⸦ ����ϴ�.
        // (MainForm.cs [������] �ǿ��� �� ��Ʈ���� ���� Ŭ���ϸ� �����˴ϴ�.)
        // �׸��� �� �̺�Ʈ ó���⿡ ���� ���� ������ ChangeFont() �޼��带 ȣ���մϴ�.
        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }


        // �� ��Ʈ�ѿ� ���� �̺�Ʈ ó���� �����⸦ ����ϴ�.
        // tbDummy_Scroll() �̺�Ʈ ó����
        private void tbDummy_Scroll(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value; // �����̴��� ��ġ�� ���� ���α׷������� ���뵵 �����
        }


        private void pgDummy_Click(object sender, EventArgs e)
        {

        }
    }
}
