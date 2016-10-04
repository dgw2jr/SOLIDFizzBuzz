using System;
using System.Windows.Forms;
using WindowsFormsUI.DividendRules;
using SOLIDFizzBuzz;

namespace WindowsFormsUI
{
    public partial class MainForm : Form
    {
        private readonly IDividendProcessor dividendProcessor;

        public MainForm(IDividendProcessor dividendProcessor)
        {
            this.dividendProcessor = dividendProcessor;
            InitializeComponent();
        }
        
        private void DividendNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var o = sender as NumericUpDown;
            var dividendValue = Convert.ToInt32(o.Value);

            this.MessageLabel.Text = this.dividendProcessor.Process(dividendValue);
        }

        private void AddRuleButton_Click(object sender, EventArgs e)
        {
            var val = Convert.ToInt32(AddRuleNumericUpDown.Value);
            this.dividendProcessor.Register(new DividendRule(val, AddRuleTextBox.Text));
        }
    }
}
