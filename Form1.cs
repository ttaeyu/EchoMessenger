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
            if (!string.IsNullOrWhiteSpace(txtInput.Text))
            {
                // 2. 전송 기능: TextBox의 텍스트를 ListBox의 항목(Items)으로 추가합니다.
                lstHistory.Items.Add(txtInput.Text);

                // 3. 입력창 정리: 추가 직후 TextBox의 내용을 비워(Clear) 다음 입력을 준비합니다.
                txtInput.Clear();

                // (보너스) 다음 입력을 위해 입력창에 텍스트 커서를 다시 가져다 놓습니다.
                txtInput.Focus();
            }
        }
    }
}
