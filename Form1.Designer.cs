namespace EchoMessenger
{
    partial class ＥｏｃｈｏＭｅｓｓｅｎｇｅｒ
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
            btnSend = new Button();
            label1 = new Label();
            lstHistory = new ListBox();
            txtInput = new TextBox();
            lblCount = new Label();
            btnDelete = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Font = new Font("한컴 울주 반구대 암각화체", 29.9999962F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSend.ForeColor = Color.Blue;
            btnSend.Location = new Point(571, 329);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(122, 57);
            btnSend.TabIndex = 0;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(73, 54);
            label1.Name = "label1";
            label1.Size = new Size(330, 46);
            label1.TabIndex = 1;
            label1.Text = "Eocho Messenger";
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.Location = new Point(63, 116);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(620, 184);
            lstHistory.TabIndex = 2;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(73, 364);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(469, 23);
            txtInput.TabIndex = 3;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.ForeColor = Color.Black;
            lblCount.Location = new Point(571, 389);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(82, 15);
            lblCount.TabIndex = 4;
            lblCount.Text = "현재 대화 0개";
            lblCount.Click += lblCount_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("새굴림", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDelete.ForeColor = Color.Lime;
            btnDelete.Location = new Point(605, 50);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 34);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "선택삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("새굴림", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnClear.ForeColor = Color.Lime;
            btnClear.Location = new Point(458, 50);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 34);
            btnClear.TabIndex = 6;
            btnClear.Text = "전송기록삭제";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // ＥｏｃｈｏＭｅｓｓｅｎｇｅｒ
            // 
            AcceptButton = btnSend;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(lblCount);
            Controls.Add(txtInput);
            Controls.Add(lstHistory);
            Controls.Add(label1);
            Controls.Add(btnSend);
            ForeColor = Color.Transparent;
            Name = "ＥｏｃｈｏＭｅｓｓｅｎｇｅｒ";
            Text = "ＥｏｃｈｏＭｅｓｓｅｎｇｅｒ";
            Load += ＥｏｃｈｏＭｅｓｓｅｎｇｅｒ_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label label1;
        private ListBox lstHistory;
        private TextBox txtInput;
        private Label lblCount;
        private Button btnDelete;
        private Button btnClear;
    }
}
