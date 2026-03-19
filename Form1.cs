namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                return; // 아무것도 하지 않고 함수 종료
            }

            // (기본 기능) 리스트박스에 메시지 추가
            lstHistory.Items.Add(txtInput.Text);

            // 1. 입력창의 기존 메시지 지우기
            txtInput.Clear();

            // 2. 입력창에 입력 포커스 갖다 놓기
            txtInput.Focus();
        }
    }
}
