using System;
using System.Windows.Forms;
using SOLIDFizzBuzz;

namespace WindowsFormsUI
{
    public partial class MainForm : Form
    {
        private readonly IDividendProcessor dividendProcessor;
        private readonly Func<int, string, IDividendRule> ruleFactory;

        public MainForm(IDividendProcessor dividendProcessor, Func<int, string, IDividendRule> ruleFactory)
        {
            this.dividendProcessor = dividendProcessor;
            this.ruleFactory = ruleFactory;

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
            this.dividendProcessor.Register(this.ruleFactory(val, this.AddRuleTextBox.Text));
        }
    }
}
