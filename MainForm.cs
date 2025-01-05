namespace UsingControls
{
    public partial class MainForm : Form
    {
        // �ʵ� ����(TreeView�� ��� �̸����� ����� ���� ������)
        Random random = new Random(37);

        public MainForm()
        {
            InitializeComponent();

            // lvDummy�� �÷��� �����ϴ� �ڵ� �ۼ�
            lvDummy.Columns.Add("Name");
            lvDummy.Columns.Add("Depth");
        }

        // TreeToList() �޼��� �߰�
        // (TreeView�� �� ��带 ListView�� �Ű� ǥ���ϴ� ���)
        void TreeToList()
        {
            lvDummy.Items.Clear();
            foreach (TreeNode node in tvDummy.Nodes)
                TreeToList(node);
        }

        void TreeToList(TreeNode Node)
        {
            lvDummy.Items.Add(
                    new ListViewItem(
                        new string[] { Node.Text,
                            Node.FullPath.Count(f => f == '\\').ToString() }));
            // TreeNode ������ FullPath ������Ƽ��,
            // ��Ʈ ������ ���� �������� ��θ� ��Ÿ����,
            // �� ��δ� \�� �����մϴ�.

            foreach (TreeNode node in Node.Nodes)
            {
                TreeToList(node);
            }
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


        // ��Ʈ�ѿ� ���� �̺�Ʈ ó���� �����⸦ ����ϴ�.
        // Modal â, Modaless â:
        // ������ ���α׷��� �� ���� ����� �ڽ� â�� ��� �� �ִµ�, 
        // ���� Modal â, Modaless â�Դϴ�.
        // Modal â:
        // �ϴ� ���� ���� â�� ���� ������ ���α׷��� �ٸ� UI��
        // ���� ����� �� ���� ���� Ư¡�Դϴ�.
        // ���α׷��� �ɰ��� ������ ǥ���ؾ� �ϰų�, ����ڷκ��� �߿��� ������
        // �Է¹޾� ���� �ܰ踦 �����ؾ��� �� �ַ� ����մϴ�.
        // Modaless â:
        // �� â�� ���� �� �ڿ��� ���α׷��� �ٸ� UI�� ����ڰ� ������ �� �ֽ��ϴ�.
        // �� �ζ������ ���� �ٿ�ε� â�� ��ǥ���� ���Դϴ�.
        // ������ �ٿ�ε��ϸ� �ڽ� â�� ���� ���� �ٿ�ε带 ����������,
        // ����ڴ� ������ �� �������� �ٸ� �������� Ž���� �� �ֱ� �����Դϴ�.
        private void btnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.ShowDialog(); // Modal â�� ���ϴ�
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modaless Form";
            frm.Width = 300;
            frm.Height = 300;
            frm.BackColor = Color.Green;
            frm.Show(); // Modaless â�� ���ϴ�
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text,
               "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        // [��Ʈ �߰�] ��ư�� [�ڽ� �߰�] ��ư�� ���� �̺�Ʈ ó���� �����⸦ �����,
        // �ڵ带 �Է��ؼ� �ϼ��մϴ�. 
        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if (tvDummy.SelectedNode == null)
            {
                MessageBox.Show("���õ� ��尡 �����ϴ�.",
                    "TreeView Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();
            TreeToList();
        }
    }
}
