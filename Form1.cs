using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlcolizerFileBasedUnitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Tuple<string, float>> unitConversionsTuple =
            new List<Tuple<string, float>>
            {
                new Tuple<string, float>("ug/100mL", 100000f),
                new Tuple<string, float>("mg/L", 1000f),
                new Tuple<string, float>("g/210L", 210f),
                new Tuple<string, float>("g/230L", 230f),
                new Tuple<string, float>("g/dL", 0.1f),
                new Tuple<string, float>("ug/L", 1000000f),
                new Tuple<string, float>("g/L", 1f)
            };

        private bool VerifyNotEmptyTextBoxes()
        {
            //Eg. Z:\
            if(Txt_InputPath.Text.Length >= 3 
                && Txt_OutputPath.Text.Length >= 3
                && Txt_OutputFileName.Text.Length >= 1)
            {
                Btn_ConvertInputToOutput.Enabled = true;
                return true;
            }
            else
            {
                Btn_ConvertInputToOutput.Enabled = false;
                return false;
            }
        }

        private void Btn_BrowseInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if(dialogResult == DialogResult.OK 
                && openFileDialog.CheckFileExists 
                && openFileDialog.CheckPathExists)
            {
                Txt_InputPath.Text = openFileDialog.FileName;
            }

            VerifyNotEmptyTextBoxes();
        }

        private void Btn_BrowseOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            DialogResult dialogResult = folderBrowserDialog.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                Txt_OutputPath.Text = folderBrowserDialog.SelectedPath;
            }

            VerifyNotEmptyTextBoxes();
        }

        private void Btn_ConvertInputToOutput_Click(object sender, EventArgs e)
        {
            string outputFilePath = Txt_OutputPath.Text + @"\" + Txt_OutputFileName.Text + ".txt";
            Console.WriteLine(outputFilePath);

            if (VerifyNotEmptyTextBoxes())
            {
                if (File.Exists(outputFilePath))
                {
                    DialogResult dialogResult = MessageBox.Show(outputFilePath + " already exists. Would you like to overwrite this file?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        Console.WriteLine("Overwriting...");

                        ConvertFileProcess();
                    }
                }
                else
                {
                    ConvertFileProcess();
                }
            }
        }

        private void ConvertFileProcess()
        {
            try
            {
                string[] inputLines = File.ReadAllLines(Txt_InputPath.Text);
                List<string> outputLines = new List<string>();

                //Convert values process
                foreach(string line in inputLines)
                {
                    string[] splitLine = line.Split(' ');

                    for(int i = 0; i >= splitLine.Length-1; i++)
                    {
                        splitLine[i] = splitLine[i].Trim();
                    }


                    float amount = 0f;

                    if(splitLine.Length != 3)
                    {
                        Console.WriteLine("Length error");
                        outputLines.Add("Error");
                        continue;
                    }

                    //Amount validation
                    if(!float.TryParse(splitLine[0], out amount))
                    {
                        Console.WriteLine("Amount validation error");
                        outputLines.Add("Error");
                        continue;
                    }

                    //Unit validation
                    if(!IsValidUnit(splitLine[1]) || !IsValidUnit(splitLine[2]))
                    {
                        Console.WriteLine("Unit validation error");
                        outputLines.Add("Error");
                        continue;
                    }

                    //if neither units are normalized, convert initial unit to normalized unit g/L
                    if(splitLine[1] != "g/L" && splitLine[2] != "g/L")
                    {
                        amount = ReturnScaledAmount(splitLine[1], amount);
                        amount = ConvertAmounts(splitLine[2], amount);
                    }
                    else
                    {
                        Console.WriteLine(amount);
                        amount = ReturnScaledAmount(splitLine[1], amount);
                        Console.WriteLine(amount);
                        amount = ConvertAmounts(splitLine[2], amount);
                        Console.WriteLine(amount);
                        Console.WriteLine();
                    }

                    outputLines.Add(amount.ToString("0.000000")+" "+ splitLine[2]);
                }

                //Write list to file.
                File.WriteAllLines(Txt_OutputPath.Text + @"\"+Txt_OutputFileName.Text+".txt", outputLines);
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred during conversion." +
                                "\n\n" + e.Message);
            }
        }

        private float ConvertAmounts(string outputUnit, float inputAmount)
        {
            float amount = 0f;

            foreach (Tuple<string, float> unitValue in unitConversionsTuple)
            {
                if (unitValue.Item1 == outputUnit)
                {
                    amount = unitValue.Item2 / inputAmount;
                }
            };

            return amount;
        }

        private float ReturnScaledAmount(string inputUnit, float inputAmount)
        {
            float amount = 0f;

            foreach (Tuple<string, float> unitValue in unitConversionsTuple)
            {
                if(string.Equals(unitValue.Item1, inputUnit))
                {
                    amount = unitValue.Item2 / inputAmount;
                    break;
                }
            };

            return amount;
        }

        private bool IsValidUnit(string inputUnit)
        {
            bool flag = false;

            foreach (Tuple<string, float> unitValue in unitConversionsTuple)
            {

                if(string.Equals(unitValue.Item1, inputUnit))
                {
                    flag = true;
                    continue;
                };
            };

            return flag;
        }

        private void Txt_OutputFileName_TextChanged(object sender, EventArgs e)
        {
            VerifyNotEmptyTextBoxes();
        }
    }
}
