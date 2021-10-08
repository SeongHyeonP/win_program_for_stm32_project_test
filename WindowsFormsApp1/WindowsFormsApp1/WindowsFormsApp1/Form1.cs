using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.CodeDom;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        /*-------------------------------------------------------
         * serial connect variable
         * ----------------------------------------------------*/
        delegate void SetTextCallBack(string opt);
        string str;
        bool create_text = false;
        int pNum;

        public Form1()
        {
            pNum = 0;
            InitializeComponent();
            FileInfo fileDel = new FileInfo(@"output.txt");
            if (fileDel.Exists)
            {
                fileDel.Delete();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == false)
                {
                    if (comboBox_setCom.SelectedIndex > -1)
                    {
                        Form2 form = new Form2();
                        form.ShowDialog();
                        if (form.buttonWasClicked == true)
                        {
                            serialPort1.PortName = comboBox_setCom.SelectedItem.ToString();
                            serialPort1.BaudRate = int.Parse(form.baudRate);
                            serialPort1.DataBits = int.Parse(form.dataBits);
                            if (int.Parse(form.stopBits) == 0) serialPort1.StopBits = StopBits.One;
                            else if (int.Parse(form.stopBits) == 1) serialPort1.StopBits = StopBits.OnePointFive;
                            else if (int.Parse(form.stopBits) == 2) serialPort1.StopBits = StopBits.Two;
                            else serialPort1.StopBits = StopBits.None;
                            if (int.Parse(form.parity) == 0) serialPort1.Parity = Parity.Even;
                            else if (int.Parse(form.parity) == 1) serialPort1.Parity = Parity.Odd;
                            else if (int.Parse(form.parity) == 2) serialPort1.Parity = Parity.None;
                            else if (int.Parse(form.parity) == 3) serialPort1.Parity = Parity.Mark;
                            else serialPort1.Parity = Parity.Space;
                            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                            serialPort1.Open();
                            comboBox_setCom.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("디바이스를 선택하지 않았습니다.");
                    }
                }
                else
                {
                    MessageBox.Show("이미 포트가 열려있습니다.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("포트 연결 오류");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived));
        }

        private void MySerialReceived(object s, EventArgs e)
        {
            str = serialPort1.ReadLine();
            if (create_text == true)
            {
                using (StreamWriter outputFile = new StreamWriter(@"output.txt", true))
                {
                    outputFile.Write(str);
                    pNum += 1;
                }
            }
            if (pNum > 3647)
            {
                create_text = false;
                MessageBox.Show("파일 생성 완료");
                pNum = 0;
            }
        }

        private void comboBox_setCom_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox_setCom.Items.Clear();
            foreach (string comport in SerialPort.GetPortNames())
            {
                comboBox_setCom.Items.Add(comport);
            }
        }

        private void comboBox_setCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == true)
                {
                    create_text = true;
                    serialPort1.WriteLine(timeData.Text);
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                comboBox_setCom.Enabled = true;
            }
        }
    }
}
