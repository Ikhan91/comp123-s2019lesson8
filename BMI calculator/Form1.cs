using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_calculator
{
    public partial class BMIFORM : Form
    {
        public BMIFORM()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ClearMethod();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var Thebutton = sender as Button;
            var ButtonTag = Thebutton.Tag;
            if (ButtonTag.ToString() == "Calculate" && MetricRadioButton.Checked)
            {
                MetricCalculation();

            }
            else if (ButtonTag.ToString() == "Calculate" && ImperialRadioButton.Checked)
            {
                ImperialCalculation();
            }
            else if (ButtonTag.ToString()=="Reset")
            {
                ClearMethod();
            }
        }

        private void ImperialCalculation()
        {
            float _inputHeight = float.Parse(HeightTextBox.Text);
            float _inputWight = float.Parse(WeightTextBox.Text);
            float _bmiResult = 0;

            _bmiResult = _inputWight * 730 / (_inputHeight * _inputHeight);

            _bmiResult.ToString();
            ResultLabel.Text = _bmiResult.ToString("#.##");
            RangeResult(_bmiResult);

        }

        private void RangeResult(float _bmiResult)
        {
            if (_bmiResult < 18.5)
            {
                RangeTextBox.Text = "Underweight .. Less Than 18.5";
            }
            else if (_bmiResult > 18.5 && _bmiResult < 24.9)
            {
                RangeTextBox.Text = "Normal .. 18.5 - 24.99";
            }
            else if (_bmiResult > 25 && _bmiResult < 29.99)
            {
                RangeTextBox.Text = "Over Weight .. 25 - 29.99";
            }
            else if (_bmiResult > 30)
            {
                RangeTextBox.Text = "Obese .. Over 30";
            }
        }

        private void MetricCalculation()
        {
            float _inputHeight = float.Parse(HeightTextBox.Text);
            float _inputWight = float.Parse(WeightTextBox.Text);
            float _bmiResult = 0;

            _bmiResult = _inputWight / (_inputHeight * _inputHeight);

            _bmiResult.ToString();
            ResultLabel.Text = _bmiResult.ToString("#.##");
            RangeResult(_bmiResult);
        }

        private void ClearMethod()
        {
            RangeTextBox.Text = string.Empty;
            ResultLabel.Text = string.Empty;
            HeightTextBox.Text = string.Empty;
            WeightTextBox.Text = string.Empty;
            MetricRadioButton.Checked = true;
            ImperialRadioButton.Checked = false;
        }

       private void BMICalculatorForm_FormClosing(object sender,FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
