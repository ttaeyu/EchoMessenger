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
            string userInput = txtInput.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                return; 
            }
            string timeStamp = DateTime.Now.ToString("HH:mm:ss");
            string formattedMessage = $"[{timeStamp}] {userInput}";
            lstHistory.Items.Add(formattedMessage);
            lblCount.Text = $"현재 대화 : {lstHistory.Items.Count}개";
            
     
           
            lstHistory.Items.Add(txtInput.Text);

            
            txtInput.Clear();

            
            txtInput.Focus();
        }
    }
}
