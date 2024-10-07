namespace Demo1
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
            SendButton = new Button();
            SendBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ReceBox = new TextBox();
            ComboBoxCom = new ComboBox();
            label3 = new Label();
            ComboBoxNum = new ComboBox();
            ComBotton = new Button();
            label4 = new Label();
            labelStatus = new Label();
            SuspendLayout();
            // 
            // SendButton
            // 
            SendButton.Location = new Point(468, 217);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(118, 46);
            SendButton.TabIndex = 0;
            SendButton.Text = "发送";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // SendBox
            // 
            SendBox.Location = new Point(171, 222);
            SendBox.Name = "SendBox";
            SendBox.Size = new Size(274, 38);
            SendBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 8F);
            label1.Location = new Point(68, 228);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 2;
            label1.Text = "发送：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 8F);
            label2.Location = new Point(689, 71);
            label2.Name = "label2";
            label2.Size = new Size(79, 30);
            label2.TabIndex = 2;
            label2.Text = "收到：";
            // 
            // ReceBox
            // 
            ReceBox.Location = new Point(774, 37);
            ReceBox.Multiline = true;
            ReceBox.Name = "ReceBox";
            ReceBox.ReadOnly = true;
            ReceBox.Size = new Size(328, 364);
            ReceBox.TabIndex = 1;
            // 
            // ComboBoxCom
            // 
            ComboBoxCom.FormattingEnabled = true;
            ComboBoxCom.Location = new Point(171, 71);
            ComboBoxCom.Name = "ComboBoxCom";
            ComboBoxCom.Size = new Size(415, 39);
            ComboBoxCom.TabIndex = 3;
            ComboBoxCom.SelectedIndexChanged += ComboBoxCom_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 76);
            label3.Name = "label3";
            label3.Size = new Size(62, 31);
            label3.TabIndex = 4;
            label3.Text = "串口";
            // 
            // ComboBoxNum
            // 
            ComboBoxNum.FormattingEnabled = true;
            ComboBoxNum.Items.AddRange(new object[] { "9600" });
            ComboBoxNum.Location = new Point(171, 150);
            ComboBoxNum.Name = "ComboBoxNum";
            ComboBoxNum.Size = new Size(415, 39);
            ComboBoxNum.TabIndex = 3;
            // 
            // ComBotton
            // 
            ComBotton.Location = new Point(297, 301);
            ComBotton.Name = "ComBotton";
            ComBotton.Size = new Size(184, 46);
            ComBotton.TabIndex = 0;
            ComBotton.Text = "启动";
            ComBotton.UseVisualStyleBackColor = true;
            ComBotton.Click += ComBotton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 155);
            label4.Name = "label4";
            label4.Size = new Size(86, 31);
            label4.TabIndex = 4;
            label4.Text = "波特率";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(136, 79);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(21, 31);
            labelStatus.TabIndex = 5;
            labelStatus.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 443);
            Controls.Add(labelStatus);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ComboBoxNum);
            Controls.Add(ComboBoxCom);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReceBox);
            Controls.Add(SendBox);
            Controls.Add(ComBotton);
            Controls.Add(SendButton);
            Name = "Form1";
            Text = "湿度监测系统";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SendButton;
        private TextBox SendBox;
        private Label label1;
        private Label label2;
        private TextBox ReceBox;
        private ComboBox ComboBoxCom;
        private Label label3;
        private ComboBox ComboBoxNum;
        private Button ComBotton;
        private Label label4;
        private Label labelStatus;
    }
}
