using System.Collections.Generic;
using System.Windows.Forms;

namespace ClassExampleWF
{
    /// <summary>
    /// Entry form for the ClassExampleWF application.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void ElementsSumClick(object sender, System.EventArgs e)
        {
            var input = textBox1.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("First value is empty. Please enter a list of elements.");
                return;
            }

            var listToProcess = new List<int>();
            for (var i = 0; i < input.Length; i++)
            {
                if (int.TryParse(input[i].ToString(), out int number))
                {
                    listToProcess.Add(number);
                }
            }

            if (listToProcess.Count == 0)
            {
                MessageBox.Show("No valid digits found in the first value. Please enter a list of elements.");
                return;
            }

            var result = 0;
            foreach (var item in listToProcess)
            {
                result += item;
            }

            resultTbx.Text = result.ToString(); // => $"{result}"
        }

        private void countCharOccurencies_Click(object sender, System.EventArgs e)
        {
            var input = textBox1.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("First value is empty. Please enter a list of elements.");
                return;
            }

            var resultDict = new Dictionary<char, int>();
            for (var i = 0; i < input.Length; i++)
            {
                if (resultDict.ContainsKey(input[i]))
                {
                    resultDict[input[i]]++;
                }
                else
                {
                    resultDict.Add(input[i], 1);
                }
            }

            var result = string.Empty;
            foreach (var key in resultDict.Keys)
            {
                result += $"'{key}' => {resultDict[key]} ; ";
            }

            resultTbx.Text = result;
        }
    }
}
