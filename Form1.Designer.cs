namespace EchoMessenger
{
    partial class Form1
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
            lblCount.Location = new Point(571, 389);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(82, 15);
            lblCount.TabIndex = 4;
            lblCount.Text = "현재 대화 0개";
            // 
            // Form1
            // 
            AcceptButton = btnSend;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCount);
            Controls.Add(txtInput);
            Controls.Add(lstHistory);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label label1;
        private ListBox lstHistory;
        private TextBox txtInput;
        private Label lblCount;
    }
}
