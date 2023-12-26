namespace binary_conversion_guessing_game_cs_version
{
    public partial class Form1 : Form
    {
        int[] digits;
        int decimalNumber = 0;
        string tempAnswer;
        int userAnswer;
        int trueAnswerDecimal;
        int[] trueAnswerBinary;

        public Form1()
        {
            InitializeComponent();
        }

        void randomBinary(int[] digits)
        {
            Random random = new Random(Environment.TickCount);

            for (int i = 0; i < 8; i++)
            {
                digits[i] = random.Next(0, 2);
            }
        }

        void randomDecimal()
        {
            Random random = new Random(Environment.TickCount);

            decimalNumber = random.Next(0, 256);
        }

        int toDecimal(int[] digits)
        {
            int[] reverse = new int[8];
            decimalNumber = 0;

            for (int i = 0, j = 7; i < 8 && j > -1; i++, j--)
            {
                reverse[i] = digits[j];
            }
            for (int i = 0; i < 8; i++)
            {
                decimalNumber += reverse[i] * (int)(Math.Pow(2, i));
            }
            return decimalNumber;
        }

        int[] toBinary()
        {
            int[] reverse = new int[8];
            int tempNum = decimalNumber;

            for (int i = 7; i > -1; i--)
            {
                tempNum -= (int)(Math.Pow(2, i));
                if (tempNum >= 0)
                {
                    reverse[i] = 1;
                }

                else
                {
                    reverse[i] = 0;
                    tempNum += (int)(Math.Pow(2, i));
                }
            }
            for (int i = 0, j = 7; i < 8 && j > -1; i++, j--)
            {
                digits[i] = reverse[j];
            }
            return digits;

        }

        public bool checkDigit(string checkThisDigit)
        {
            if (int.TryParse(checkThisDigit, out userAnswer))
                return true;
            else
                return false;
        }

        private void answerBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newQuestionButton_Click(object sender, EventArgs e)
        {
            giveUpButton.Enabled = false;
            confirmButton.Enabled = true;

            if (binaryGeneratorRadio.Checked)
            {
                digits = new int[8];

                resultLabel.Text = "";
                answerBox.Text = "";

                randomBinary(digits);
                trueAnswerDecimal = toDecimal(digits);

                generatedQuestionBox.Text = string.Join("", digits);
            }

            if (decimalGeneratorRadio.Checked)
            {
                digits = new int[8];

                resultLabel.Text = "";
                answerBox.Text = "";

                randomDecimal();
                trueAnswerBinary = toBinary();

                generatedQuestionBox.Text = decimalNumber.ToString();
            }

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (binaryGeneratorRadio.Checked)
            {
                tempAnswer = answerBox.Text.Replace(" ", "");
                if (checkDigit(tempAnswer))
                {
                    if (userAnswer == trueAnswerDecimal)
                    {
                        resultLabel.ForeColor = Color.Green;
                        resultLabel.Text = "Correct!";
                        giveUpButton.Enabled = false;
                    }
                    else
                    {
                        resultLabel.ForeColor = Color.Red;
                        resultLabel.Text = "Wrong";
                        giveUpButton.Enabled = true;
                    }
                }
                else
                    MessageBox.Show("Please make sure your answer is an integer", "Error!");
            }
            if (decimalGeneratorRadio.Checked)
            {
                tempAnswer = answerBox.Text.Replace(" ", "");
                if (checkDigit(tempAnswer))
                {
                    if (userAnswer == int.Parse(string.Join("", trueAnswerBinary)))
                    {
                        resultLabel.ForeColor = Color.Green;
                        resultLabel.Text = "Correct!";
                        giveUpButton.Enabled = false;
                    }
                    else
                    {
                        resultLabel.ForeColor = Color.Red;
                        resultLabel.Text = "Wrong";
                        giveUpButton.Enabled = true;
                    }
                }
                else
                    MessageBox.Show("Please make sure your answer is a binary number", "Error!");
            }
        }

        private void binaryGeneratorRadio_CheckedChanged(object sender, EventArgs e)
        {
            giveUpButton.Enabled = false;
            confirmButton.Enabled = true;

            generatedQuestionLabel.Text = "Binary :";
            answerLabel.Text = "Decimal :";

            digits = new int[8];

            resultLabel.Text = "";
            answerBox.Text = "";

            randomBinary(digits);
            trueAnswerDecimal = toDecimal(digits);

            generatedQuestionBox.Text = string.Join("", digits);
        }

        private void decimalGeneratorRadio_CheckedChanged(object sender, EventArgs e)
        {
            giveUpButton.Enabled = false;
            confirmButton.Enabled = true;

            generatedQuestionLabel.Text = "Decimal :";
            answerLabel.Text = "Binary :";

            digits = new int[8];

            resultLabel.Text = "";
            answerBox.Text = "";

            randomDecimal();
            trueAnswerBinary = toBinary();

            generatedQuestionBox.Text = decimalNumber.ToString();
        }

        private void giveUpButton_Click(object sender, EventArgs e)
        {
            confirmButton.Enabled = false;

            if (binaryGeneratorRadio.Checked)
            {
                resultLabel.ForeColor = Color.Black;
                resultLabel.Text = trueAnswerDecimal.ToString();
            }
            if (decimalGeneratorRadio.Checked)
            {
                resultLabel.ForeColor = Color.Black;
                resultLabel.Text = string.Join("", trueAnswerBinary);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}