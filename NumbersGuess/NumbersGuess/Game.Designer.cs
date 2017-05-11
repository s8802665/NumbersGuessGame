namespace NumbersGuess
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oneLabel = new System.Windows.Forms.Label();
            this.twoLabel = new System.Windows.Forms.Label();
            this.threeLabel = new System.Windows.Forms.Label();
            this.fourLabel = new System.Windows.Forms.Label();
            this.questionButton = new System.Windows.Forms.Button();
            this.anOneTextBox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.resultTextLabel = new System.Windows.Forms.Label();
            this.resultLabelA = new System.Windows.Forms.Label();
            this.anOneLabel = new System.Windows.Forms.Label();
            this.anTwoLabel = new System.Windows.Forms.Label();
            this.anThreeLabel = new System.Windows.Forms.Label();
            this.anFourLabel = new System.Windows.Forms.Label();
            this.anTwoTextBox = new System.Windows.Forms.TextBox();
            this.anThreeTextBox = new System.Windows.Forms.TextBox();
            this.anFourTextBox = new System.Windows.Forms.TextBox();
            this.yourAnswerLabel = new System.Windows.Forms.Label();
            this.resultLabelB = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.ReSetButton = new System.Windows.Forms.Button();
            this.tipsLabel = new System.Windows.Forms.Label();
            this.tipsALabel = new System.Windows.Forms.Label();
            this.tipsBLabel = new System.Windows.Forms.Label();
            this.autoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oneLabel
            // 
            this.oneLabel.AutoSize = true;
            this.oneLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.oneLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.oneLabel.ForeColor = System.Drawing.Color.Black;
            this.oneLabel.Location = new System.Drawing.Point(47, 49);
            this.oneLabel.Name = "oneLabel";
            this.oneLabel.Size = new System.Drawing.Size(50, 61);
            this.oneLabel.TabIndex = 2;
            this.oneLabel.Text = "?";
            // 
            // twoLabel
            // 
            this.twoLabel.AutoSize = true;
            this.twoLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.twoLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.twoLabel.ForeColor = System.Drawing.Color.Black;
            this.twoLabel.Location = new System.Drawing.Point(130, 49);
            this.twoLabel.Name = "twoLabel";
            this.twoLabel.Size = new System.Drawing.Size(50, 61);
            this.twoLabel.TabIndex = 3;
            this.twoLabel.Text = "?";
            // 
            // threeLabel
            // 
            this.threeLabel.AutoSize = true;
            this.threeLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.threeLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.threeLabel.ForeColor = System.Drawing.Color.Black;
            this.threeLabel.Location = new System.Drawing.Point(210, 49);
            this.threeLabel.Name = "threeLabel";
            this.threeLabel.Size = new System.Drawing.Size(50, 61);
            this.threeLabel.TabIndex = 4;
            this.threeLabel.Text = "?";
            // 
            // fourLabel
            // 
            this.fourLabel.AutoSize = true;
            this.fourLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.fourLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fourLabel.ForeColor = System.Drawing.Color.Black;
            this.fourLabel.Location = new System.Drawing.Point(287, 49);
            this.fourLabel.Name = "fourLabel";
            this.fourLabel.Size = new System.Drawing.Size(50, 61);
            this.fourLabel.TabIndex = 5;
            this.fourLabel.Text = "?";
            // 
            // questionButton
            // 
            this.questionButton.BackColor = System.Drawing.SystemColors.Control;
            this.questionButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.questionButton.ForeColor = System.Drawing.Color.Black;
            this.questionButton.Location = new System.Drawing.Point(56, 42);
            this.questionButton.Name = "questionButton";
            this.questionButton.Size = new System.Drawing.Size(221, 68);
            this.questionButton.TabIndex = 6;
            this.questionButton.Text = "按這裡開始";
            this.questionButton.UseVisualStyleBackColor = false;
            this.questionButton.Click += new System.EventHandler(this.questionButton_Click);
            // 
            // anOneTextBox
            // 
            this.anOneTextBox.Location = new System.Drawing.Point(56, 162);
            this.anOneTextBox.MaxLength = 1;
            this.anOneTextBox.Name = "anOneTextBox";
            this.anOneTextBox.Size = new System.Drawing.Size(41, 22);
            this.anOneTextBox.TabIndex = 7;
            this.anOneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anOneTextBox_KeyPress);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.answerLabel.Location = new System.Drawing.Point(54, 128);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(143, 24);
            this.answerLabel.TabIndex = 8;
            this.answerLabel.Text = "請輸入您的答案";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.SystemColors.Control;
            this.sendButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sendButton.ForeColor = System.Drawing.Color.Black;
            this.sendButton.Location = new System.Drawing.Point(283, 147);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(111, 45);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "提交答案";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // resultTextLabel
            // 
            this.resultTextLabel.AutoSize = true;
            this.resultTextLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultTextLabel.Location = new System.Drawing.Point(97, 342);
            this.resultTextLabel.Name = "resultTextLabel";
            this.resultTextLabel.Size = new System.Drawing.Size(67, 24);
            this.resultTextLabel.TabIndex = 10;
            this.resultTextLabel.Text = "提示：";
            // 
            // resultLabelA
            // 
            this.resultLabelA.AutoSize = true;
            this.resultLabelA.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLabelA.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.resultLabelA.Location = new System.Drawing.Point(173, 332);
            this.resultLabelA.Name = "resultLabelA";
            this.resultLabelA.Size = new System.Drawing.Size(104, 45);
            this.resultLabelA.TabIndex = 11;
            this.resultLabelA.Text = "1234";
            // 
            // anOneLabel
            // 
            this.anOneLabel.AutoSize = true;
            this.anOneLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anOneLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.anOneLabel.Location = new System.Drawing.Point(163, 241);
            this.anOneLabel.Name = "anOneLabel";
            this.anOneLabel.Size = new System.Drawing.Size(50, 61);
            this.anOneLabel.TabIndex = 12;
            this.anOneLabel.Text = "?";
            // 
            // anTwoLabel
            // 
            this.anTwoLabel.AutoSize = true;
            this.anTwoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anTwoLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.anTwoLabel.Location = new System.Drawing.Point(219, 241);
            this.anTwoLabel.Name = "anTwoLabel";
            this.anTwoLabel.Size = new System.Drawing.Size(50, 61);
            this.anTwoLabel.TabIndex = 13;
            this.anTwoLabel.Text = "?";
            // 
            // anThreeLabel
            // 
            this.anThreeLabel.AutoSize = true;
            this.anThreeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anThreeLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.anThreeLabel.Location = new System.Drawing.Point(275, 241);
            this.anThreeLabel.Name = "anThreeLabel";
            this.anThreeLabel.Size = new System.Drawing.Size(50, 61);
            this.anThreeLabel.TabIndex = 14;
            this.anThreeLabel.Text = "?";
            // 
            // anFourLabel
            // 
            this.anFourLabel.AutoSize = true;
            this.anFourLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anFourLabel.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.anFourLabel.Location = new System.Drawing.Point(331, 241);
            this.anFourLabel.Name = "anFourLabel";
            this.anFourLabel.Size = new System.Drawing.Size(50, 61);
            this.anFourLabel.TabIndex = 15;
            this.anFourLabel.Text = "?";
            // 
            // anTwoTextBox
            // 
            this.anTwoTextBox.Location = new System.Drawing.Point(113, 162);
            this.anTwoTextBox.MaxLength = 1;
            this.anTwoTextBox.Name = "anTwoTextBox";
            this.anTwoTextBox.Size = new System.Drawing.Size(41, 22);
            this.anTwoTextBox.TabIndex = 16;
            this.anTwoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anTwoTextBox_KeyPress);
            // 
            // anThreeTextBox
            // 
            this.anThreeTextBox.Location = new System.Drawing.Point(170, 162);
            this.anThreeTextBox.MaxLength = 1;
            this.anThreeTextBox.Name = "anThreeTextBox";
            this.anThreeTextBox.Size = new System.Drawing.Size(40, 22);
            this.anThreeTextBox.TabIndex = 17;
            this.anThreeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anThreeTextBox_KeyPress);
            // 
            // anFourTextBox
            // 
            this.anFourTextBox.Location = new System.Drawing.Point(226, 162);
            this.anFourTextBox.MaxLength = 1;
            this.anFourTextBox.Name = "anFourTextBox";
            this.anFourTextBox.Size = new System.Drawing.Size(41, 22);
            this.anFourTextBox.TabIndex = 18;
            this.anFourTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anFourTextBox_KeyPress);
            // 
            // yourAnswerLabel
            // 
            this.yourAnswerLabel.AutoSize = true;
            this.yourAnswerLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yourAnswerLabel.Location = new System.Drawing.Point(54, 241);
            this.yourAnswerLabel.Name = "yourAnswerLabel";
            this.yourAnswerLabel.Size = new System.Drawing.Size(86, 24);
            this.yourAnswerLabel.TabIndex = 19;
            this.yourAnswerLabel.Text = "您的答案";
            // 
            // resultLabelB
            // 
            this.resultLabelB.AutoSize = true;
            this.resultLabelB.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLabelB.ForeColor = System.Drawing.Color.DarkRed;
            this.resultLabelB.Location = new System.Drawing.Point(274, 331);
            this.resultLabelB.Name = "resultLabelB";
            this.resultLabelB.Size = new System.Drawing.Size(104, 45);
            this.resultLabelB.TabIndex = 20;
            this.resultLabelB.Text = "1234";
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.winLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.winLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.winLabel.Location = new System.Drawing.Point(52, 464);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(177, 35);
            this.winLabel.TabIndex = 21;
            this.winLabel.Text = "恭喜你贏了！";
            // 
            // ReSetButton
            // 
            this.ReSetButton.BackColor = System.Drawing.SystemColors.Control;
            this.ReSetButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ReSetButton.Location = new System.Drawing.Point(271, 530);
            this.ReSetButton.Name = "ReSetButton";
            this.ReSetButton.Size = new System.Drawing.Size(150, 52);
            this.ReSetButton.TabIndex = 22;
            this.ReSetButton.Text = "重新遊戲";
            this.ReSetButton.UseVisualStyleBackColor = false;
            this.ReSetButton.Click += new System.EventHandler(this.ReSetButton_Click);
            // 
            // tipsLabel
            // 
            this.tipsLabel.AutoSize = true;
            this.tipsLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tipsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tipsLabel.Location = new System.Drawing.Point(53, 194);
            this.tipsLabel.Name = "tipsLabel";
            this.tipsLabel.Size = new System.Drawing.Size(164, 16);
            this.tipsLabel.TabIndex = 23;
            this.tipsLabel.Text = "小叮嚀：沒有重複的數字喔！";
            // 
            // tipsALabel
            // 
            this.tipsALabel.AutoSize = true;
            this.tipsALabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tipsALabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tipsALabel.Location = new System.Drawing.Point(99, 387);
            this.tipsALabel.Name = "tipsALabel";
            this.tipsALabel.Size = new System.Drawing.Size(151, 16);
            this.tipsALabel.TabIndex = 24;
            this.tipsALabel.Text = "A表示數字對 位置也對了。";
            // 
            // tipsBLabel
            // 
            this.tipsBLabel.AutoSize = true;
            this.tipsBLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.tipsBLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tipsBLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.tipsBLabel.Location = new System.Drawing.Point(99, 407);
            this.tipsBLabel.Name = "tipsBLabel";
            this.tipsBLabel.Size = new System.Drawing.Size(162, 16);
            this.tipsBLabel.TabIndex = 25;
            this.tipsBLabel.Text = "B表示數字對 但是位置錯了。";
            // 
            // autoButton
            // 
            this.autoButton.Location = new System.Drawing.Point(101, 530);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(149, 52);
            this.autoButton.TabIndex = 26;
            this.autoButton.Text = "自動破解";
            this.autoButton.UseVisualStyleBackColor = true;
            this.autoButton.Click += new System.EventHandler(this.autoButton_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 610);
            this.Controls.Add(this.autoButton);
            this.Controls.Add(this.tipsBLabel);
            this.Controls.Add(this.tipsALabel);
            this.Controls.Add(this.tipsLabel);
            this.Controls.Add(this.ReSetButton);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.resultLabelB);
            this.Controls.Add(this.yourAnswerLabel);
            this.Controls.Add(this.anFourTextBox);
            this.Controls.Add(this.anThreeTextBox);
            this.Controls.Add(this.anTwoTextBox);
            this.Controls.Add(this.anFourLabel);
            this.Controls.Add(this.anThreeLabel);
            this.Controls.Add(this.anTwoLabel);
            this.Controls.Add(this.anOneLabel);
            this.Controls.Add(this.resultLabelA);
            this.Controls.Add(this.resultTextLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.anOneTextBox);
            this.Controls.Add(this.questionButton);
            this.Controls.Add(this.fourLabel);
            this.Controls.Add(this.threeLabel);
            this.Controls.Add(this.twoLabel);
            this.Controls.Add(this.oneLabel);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button questionButton;
        private System.Windows.Forms.Label fourLabel;
        private System.Windows.Forms.Label oneLabel;
        private System.Windows.Forms.Label twoLabel;
        private System.Windows.Forms.Label threeLabel;
        private System.Windows.Forms.TextBox anOneTextBox;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label resultTextLabel;
        private System.Windows.Forms.Label resultLabelA;
        private System.Windows.Forms.Label anOneLabel;
        private System.Windows.Forms.Label anTwoLabel;
        private System.Windows.Forms.Label anThreeLabel;
        private System.Windows.Forms.Label anFourLabel;
        private System.Windows.Forms.TextBox anTwoTextBox;
        private System.Windows.Forms.TextBox anThreeTextBox;
        private System.Windows.Forms.TextBox anFourTextBox;
        private System.Windows.Forms.Label yourAnswerLabel;
        private System.Windows.Forms.Label resultLabelB;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Button ReSetButton;
        private System.Windows.Forms.Label tipsLabel;
        private System.Windows.Forms.Label tipsALabel;
        private System.Windows.Forms.Label tipsBLabel;
        private System.Windows.Forms.Button autoButton;
    }
}