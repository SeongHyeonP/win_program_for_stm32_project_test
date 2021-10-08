namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_setCom = new System.Windows.Forms.ComboBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timeData = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button_disconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "통신 디바이스";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_setCom
            // 
            this.comboBox_setCom.FormattingEnabled = true;
            this.comboBox_setCom.Location = new System.Drawing.Point(12, 24);
            this.comboBox_setCom.Name = "comboBox_setCom";
            this.comboBox_setCom.Size = new System.Drawing.Size(95, 20);
            this.comboBox_setCom.TabIndex = 1;
            this.comboBox_setCom.SelectedIndexChanged += new System.EventHandler(this.comboBox_setCom_SelectedIndexChanged);
            this.comboBox_setCom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_setCom_MouseClick);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(12, 50);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 2;
            this.button_connect.Text = "선택";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "추출";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Integration Time(asscii, 7byte)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timeData
            // 
            this.timeData.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.timeData.Location = new System.Drawing.Point(137, 24);
            this.timeData.Name = "timeData";
            this.timeData.Size = new System.Drawing.Size(193, 21);
            this.timeData.TabIndex = 8;
            this.timeData.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(93, 51);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(75, 23);
            this.button_disconnect.TabIndex = 11;
            this.button_disconnect.Text = "해제";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 95);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.timeData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.comboBox_setCom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_setCom;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_disconnect;
    }
}

