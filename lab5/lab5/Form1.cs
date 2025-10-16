using Lab5.Controller;
using System;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        private MainController _controller;

        public Form1()
        {
            InitializeComponent();
            _controller = new MainController(this);
        }

        // Властивості для доступу з контролера
        public string DisplayText
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }

        public string AgeText
        {
            get { return textBox2.Text; }
        }

        public string AgeCategoryResult
        {
            set { label6.Text = value; }
        }

        public string TableNumberText
        {
            get { return textBox4.Text; }
        }

        public string MultiplicationTableResult
        {
            set { label5.Text = value; }
        }

        // ОБРОБНИКИ ПОДІЙ ДЛЯ КАЛЬКУЛЯТОРА
        private void button1_Click(object sender, EventArgs e)
        {
            _controller.AppendNumber("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _controller.AppendNumber("8");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _controller.AppendNumber("9");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _controller.SetOperation("/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _controller.SetOperation("-");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _controller.SetOperation("*");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _controller.AppendNumber("2");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _controller.AppendNumber("4");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _controller.AppendNumber("1");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _controller.AppendNumber("3");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _controller.AppendNumber("5");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _controller.AppendNumber("0");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _controller.ClearCalculator();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _controller.AppendNumber("6");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _controller.CalculateResult();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _controller.SetOperation("+");
        }

        // ОБРОБНИКИ ПОДІЙ ДЛЯ ІНШИХ ВКЛАДОК
        private void button17_Click(object sender, EventArgs e)
        {
            _controller.CheckAge();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            _controller.GenerateMultiplicationTable();
        }
    }
}