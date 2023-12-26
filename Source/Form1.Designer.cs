namespace binary_conversion_guessing_game_cs_version
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            binaryGeneratorRadio = new RadioButton();
            decimalGeneratorRadio = new RadioButton();
            generatedQuestionBox = new TextBox();
            generatedQuestionLabel = new Label();
            answerLabel = new Label();
            answerBox = new TextBox();
            newQuestionButton = new Button();
            confirmButton = new Button();
            resultLabel = new Label();
            giveUpButton = new Button();
            SuspendLayout();
            // 
            // binaryGeneratorRadio
            // 
            binaryGeneratorRadio.AutoSize = true;
            binaryGeneratorRadio.Location = new Point(138, 22);
            binaryGeneratorRadio.Name = "binaryGeneratorRadio";
            binaryGeneratorRadio.Size = new Size(117, 19);
            binaryGeneratorRadio.TabIndex = 2;
            binaryGeneratorRadio.TabStop = true;
            binaryGeneratorRadio.Text = "Binary to decimal";
            binaryGeneratorRadio.UseVisualStyleBackColor = true;
            binaryGeneratorRadio.CheckedChanged += binaryGeneratorRadio_CheckedChanged;
            // 
            // decimalGeneratorRadio
            // 
            decimalGeneratorRadio.AutoSize = true;
            decimalGeneratorRadio.Location = new Point(138, 47);
            decimalGeneratorRadio.Name = "decimalGeneratorRadio";
            decimalGeneratorRadio.Size = new Size(118, 19);
            decimalGeneratorRadio.TabIndex = 3;
            decimalGeneratorRadio.TabStop = true;
            decimalGeneratorRadio.Text = "Decimal to binary";
            decimalGeneratorRadio.UseVisualStyleBackColor = true;
            decimalGeneratorRadio.CheckedChanged += decimalGeneratorRadio_CheckedChanged;
            // 
            // generatedQuestionBox
            // 
            generatedQuestionBox.Enabled = false;
            generatedQuestionBox.Location = new Point(184, 97);
            generatedQuestionBox.Name = "generatedQuestionBox";
            generatedQuestionBox.Size = new Size(100, 23);
            generatedQuestionBox.TabIndex = 4;
            // 
            // generatedQuestionLabel
            // 
            generatedQuestionLabel.AccessibleDescription = "";
            generatedQuestionLabel.AutoSize = true;
            generatedQuestionLabel.Location = new Point(112, 100);
            generatedQuestionLabel.Name = "generatedQuestionLabel";
            generatedQuestionLabel.Size = new Size(46, 15);
            generatedQuestionLabel.TabIndex = 5;
            generatedQuestionLabel.Text = "Binary :";
            // 
            // answerLabel
            // 
            answerLabel.AutoSize = true;
            answerLabel.Location = new Point(112, 140);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(56, 15);
            answerLabel.TabIndex = 6;
            answerLabel.Text = "Decimal :";
            // 
            // answerBox
            // 
            answerBox.Location = new Point(184, 137);
            answerBox.Name = "answerBox";
            answerBox.Size = new Size(100, 23);
            answerBox.TabIndex = 7;
            answerBox.TextChanged += answerBox_TextChanged;
            // 
            // newQuestionButton
            // 
            newQuestionButton.Location = new Point(70, 209);
            newQuestionButton.Name = "newQuestionButton";
            newQuestionButton.Size = new Size(75, 23);
            newQuestionButton.TabIndex = 8;
            newQuestionButton.Text = "New";
            newQuestionButton.UseVisualStyleBackColor = true;
            newQuestionButton.Click += newQuestionButton_Click;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(163, 209);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(75, 23);
            confirmButton.TabIndex = 9;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(174, 179);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 10;
            // 
            // giveUpButton
            // 
            giveUpButton.Enabled = false;
            giveUpButton.Location = new Point(255, 209);
            giveUpButton.Name = "giveUpButton";
            giveUpButton.Size = new Size(75, 23);
            giveUpButton.TabIndex = 11;
            giveUpButton.Text = "Give Up";
            giveUpButton.UseVisualStyleBackColor = true;
            giveUpButton.Click += giveUpButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 254);
            Controls.Add(giveUpButton);
            Controls.Add(resultLabel);
            Controls.Add(confirmButton);
            Controls.Add(newQuestionButton);
            Controls.Add(answerBox);
            Controls.Add(answerLabel);
            Controls.Add(generatedQuestionLabel);
            Controls.Add(generatedQuestionBox);
            Controls.Add(decimalGeneratorRadio);
            Controls.Add(binaryGeneratorRadio);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Binary-Decimal Quiz";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton binaryGeneratorRadio;
        private RadioButton decimalGeneratorRadio;
        private TextBox generatedQuestionBox;
        private Label generatedQuestionLabel;
        private Label answerLabel;
        private TextBox answerBox;
        private Button newQuestionButton;
        private Button confirmButton;
        private Label resultLabel;
        private Button giveUpButton;
    }
}