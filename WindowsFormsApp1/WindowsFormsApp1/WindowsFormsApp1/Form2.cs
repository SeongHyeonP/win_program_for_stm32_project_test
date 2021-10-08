using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private bool button1WasClicked = false;

        public bool buttonWasClicked
        {
            get { return this.button1WasClicked; }
        }

        public string baudRate
        {
            get { return this.comboBox1.SelectedItem.ToString(); }
        }

        public string dataBits
        {
            get { return this.comboBox2.SelectedItem.ToString(); }
        }

        public string stopBits
        {
            get { return this.comboBox4.SelectedIndex.ToString(); }
        }

        public string parity
        {
            get { return this.comboBox3.SelectedIndex.ToString(); }
        }

        public string flowControl
        {
            get { return this.comboBox5.SelectedIndex.ToString(); }
        }

        public Form2()
        {
            InitializeComponent();
            ComboBox_init();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //textBox1.Text = Passvalue;
        }

        public void ComboBox_init()
        {
            comboBox1.SelectedIndex = 9;
            comboBox2.SelectedIndex = 3;
            comboBox3.SelectedIndex = 2;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
