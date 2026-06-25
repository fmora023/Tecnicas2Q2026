using System;
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

        private void minMaxBtnClick(object sender, System.EventArgs e)
        {
            var inputList = new List<int>();
            var listAsText = textBox1.Text;

            if (string.IsNullOrEmpty(listAsText))
            {
                MessageBox.Show("First value is empty. Please enter a list of elements.");
                return;
            }

            foreach(var item in listAsText)
            {
                if (int.TryParse(item.ToString(), out int number))
                {
                    inputList.Add(number);
                }
            }
            
            if (inputList.Count == 0)
            {
                MessageBox.Show("No valid digits found in the first value. Please enter a list of elements.");
                return;
            }

            int max = inputList[0];
            int min = inputList[0];

            for (var i = 1; i < inputList.Count; i++)
            {
                if (max < inputList[i])
                {
                    max = inputList[i];
                }
                else if (min > inputList[i])
                {
                    min = inputList[i];
                }
            }

            resultTbx.Text = $"el maximo es {max} y el minimo {min}";
        }

        private void findIndexBtnClick(object sender, EventArgs e)
        {
            var wordInput = textBox1.Text;
            var charToSearch = textBox2.Text;

            if (string.IsNullOrEmpty(wordInput))
            {
                MessageBox.Show("First value is empty. Please enter a word.");
                return;
            }

            if (string.IsNullOrEmpty(charToSearch))
            {
                MessageBox.Show("Second value is empty. Please enter a character to search.");
                return;
            }

            var indexPosition = -1;

            for (var i = 0; i < wordInput.Length; i++)
            {
                if (charToSearch.Equals(wordInput[i].ToString()))
                {
                    indexPosition = i;
                    break;
                }
            }

            if (indexPosition == -1)
            {
                resultTbx.Text = $"La letra {charToSearch} no aparece en la palabra {wordInput}";
            }
            else
            {
                resultTbx.Text = $"La letra {charToSearch} en la palabra {wordInput} aparece en la posicion {indexPosition}";
            }
        }
    }
}
