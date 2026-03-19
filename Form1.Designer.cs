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
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(571, 363);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 0;
            btnSend.Text = "button1";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 30F);
            label1.Location = new Point(73, 54);
            label1.Name = "label1";
            label1.Size = new Size(131, 54);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.Location = new Point(73, 116);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(573, 184);
            lstHistory.TabIndex = 2;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(73, 364);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(469, 23);
            txtInput.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
