namespace UsingControls
{
    public partial class MainForm : Form
    {
        // 필드 생성(TreeView의 노드 이름으로 사용할 난수 생성기)
        Random random = new Random(37);

        public MainForm()
        {
            InitializeComponent();

            // lvDummy에 컬럼을 생성하는 코드 작성
            lvDummy.Columns.Add("Name");
            lvDummy.Columns.Add("Depth");
        }

        // TreeToList() 메서드 추가
        // (TreeView의 각 노드를 ListView로 옮겨 표시하는 기능)
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
            // TreeNode 형식의 FullPath 프로퍼티는,
            // 루트 노드부터 현재 노드까지의 경로를 나타내며,
            // 각 경로는 \로 구분합니다.

            foreach (TreeNode node in Node.Nodes)
            {
                TreeToList(node);
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // IDE가 MainForm_Load() 이벤트 처리기의 껍데기를 만들면서 코드 편집기를 자동으로 엽니다. 
        private void MainForm_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families; // 운영체제에 설치되어 있는 폰트 목록 검색
            foreach (FontFamily font in Fonts) // cboFont 컨트롤에 각 폰트 이름 추가 
                cboFont.Items.Add(font.Name);
        }


        // cboFont, chkBold, chkItalic 컨트롤의 이벤트 처리기에서 호출하기 위한 것으로,
        // txtSampleText의 문자열 폰트를 변경하는 기능을 합니다.
        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0) // cboFont에서 선택한 항목이 없으면 메서드 종료
                return;

            FontStyle style = FontStyle.Regular; // FontStyle 객체를 초기화

            if (chkBold.Checked) // 만약 "굵게" 체크 박스가 선택되어 있으면 Bold 논리합 수행함
                style |= FontStyle.Bold;

            if (chkltalic.Checked) // 만약 "이탤릭" 체크 박스가 선택되어 있으면 Italic 논리합 수행함
                style |= FontStyle.Italic;

            txtSampleText.Font =     // txtSampleText의 Font 프로퍼티를 앞에서 만든 style로 수정함
                new Font((string)cboFont.SelectedItem, 10, style);
        }


        // 각 컨트롤에 대해 이벤트 처리기 껍데기를 만듭니다.
        // (MainForm.cs [디자인] 탭에서 각 컨트롤을 더블 클릭하면 생성됩니다.)
        // 그리고 각 이벤트 처리기에 조금 전에 선언한 ChangeFont() 메서드를 호출합니다.
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


        // 각 컨트롤에 대해 이벤트 처리기 껍데기를 만듭니다.
        // tbDummy_Scroll() 이벤트 처리기
        private void tbDummy_Scroll(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value; // 슬라이더의 위치에 따라 프로그레스바의 내용도 변경됨
        }


        private void pgDummy_Click(object sender, EventArgs e)
        {

        }


        // 컨트롤에 대해 이벤트 처리기 껍데기를 만듭니다.
        // Modal 창, Modaless 창:
        // 윈도우 프로그램은 두 가지 모드의 자식 창을 띄울 수 있는데, 
        // 각각 Modal 창, Modaless 창입니다.
        // Modal 창:
        // 일단 띄우고 나면 창을 닫을 때까지 프로그램의 다른 UI를
        // 절대 사용할 수 없는 것이 특징입니다.
        // 프로그램이 심각한 정보를 표시해야 하거나, 사용자로부터 중요한 사항을
        // 입력받아 다음 단계를 진행해야할 떄 주로 사용합니다.
        // Modaless 창:
        // 이 창은 띄우고 난 뒤에도 프로그램의 다른 UI에 사용자가 접근할 수 있습니다.
        // 웹 부라우저의 파일 다운로드 창이 대표적인 예입니다.
        // 파일을 다운로드하면 자식 창이 떠서 파일 다운로드를 수행하지만,
        // 사용자는 여전히 웹 브라우저로 다른 페이지를 탐색할 수 있기 때문입니다.
        private void btnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.ShowDialog(); // Modal 창을 띄웁니다
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modaless Form";
            frm.Width = 300;
            frm.Height = 300;
            frm.BackColor = Color.Green;
            frm.Show(); // Modaless 창을 띄웁니다
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text,
               "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        // [루트 추가] 버튼과 [자식 추가] 버튼에 대해 이벤트 처리기 껍데기를 만들고,
        // 코드를 입력해서 완성합니다. 
        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if (tvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.",
                    "TreeView Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();
            TreeToList();
        }
    }
}
