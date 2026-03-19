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
            if (txtInput.Text.Length > 50)
            {
                MessageBox.Show("메시지는 50자까지만 입력할 수 있습니다.", "경고");
                return; // 전송하지 않고 함수 종료
            }
            string userInput = txtInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                return;
            }
            
            if (string.IsNullOrWhiteSpace(userInput)) return; 
            string timeStamp = DateTime.Now.ToString("HH:mm:ss");
            string formattedMessage = $"[{timeStamp}] {userInput}";
            lstHistory.Items.Add(formattedMessage);
            lblCount.Text = $"현재 대화 : {lstHistory.Items.Count}개";



            lstHistory.Items.Add(txtInput.Text);


            txtInput.Clear();


            txtInput.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstHistory.SelectedIndex != -1)
            {
                // 선택된 위치(Index)의 항목을 삭제
                lstHistory.Items.RemoveAt(lstHistory.SelectedIndex);

                // 삭제 후 메시지 카운트 라벨도 업데이트!
                lblCount.Text = $"현재 대화 : {lstHistory.Items.Count}개";
            }
            else
            {
                // 선택하지 않았을 때 사용자에게 알림 (예외 처리)
                MessageBox.Show("삭제할 메시지를 먼저 선택해주세요!", "알림");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();

            // 카운트 초기화
            lblCount.Text = "현재 대화 : 0개";
        }
    }
}
