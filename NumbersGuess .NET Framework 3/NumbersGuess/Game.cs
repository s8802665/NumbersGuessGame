using System;
using System.Windows.Forms;

namespace NumbersGuess
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            Render();
        }

        //起始畫面
        public void Render()
        {
            //this.oneLabel.Hide();
            //this.twoLabel.Hide();
            //this.threeLabel.Hide();
            //this.fourLabel.Hide();
            this.tipsALabel.Hide();
            this.tipsBLabel.Hide();
            this.questionButton.Show();
            this.anOneTextBox.Hide();
            this.anTwoTextBox.Hide();
            this.anThreeTextBox.Hide();
            this.anFourTextBox.Hide();
            this.sendButton.Hide();
            this.winLabel.Hide();
            this.tipsLabel.Hide();
            this.questionButton.Text = "按這裡開始";
            this.answerLabel.Text = "請猜四個1~9的數字：";
            this.sendButton.Text = "提交答案";
            this.resultTextLabel.Text = "提示：";
            this.resultLabelA.Text = "";
            this.resultLabelB.Text = "";
            this.yourAnswerLabel.Text = "您的答案：";
            this.anOneLabel.Text = "?";
            this.anTwoLabel.Text = "?";
            this.anThreeLabel.Text = "?";
            this.anFourLabel.Text = "?";
        }

        //開始遊戲按鈕
        private void questionButton_Click(object sender, EventArgs e)
        {
            this.questionButton.Hide();
            this.anOneTextBox.Show();
            this.anTwoTextBox.Show();
            this.anThreeTextBox.Show();
            this.anFourTextBox.Show();
            this.sendButton.Show();

            #region 產生四個不重複的1~9的數字

            int[] randomArray = new int[4];
            Random random = new Random();
            for (int a = 0; a < 4; a++)
            {
                randomArray[a] = random.Next(1, 10);

                for (int b = 0; b < a; b++)
                {
                    while (randomArray[a] == randomArray[b])
                    {
                        b = 0;
                        randomArray[a] = random.Next(1, 10);
                    }
                }
            }
            this.oneLabel.Text = randomArray[0].ToString();
            this.twoLabel.Text = randomArray[1].ToString();
            this.threeLabel.Text = randomArray[2].ToString();
            this.fourLabel.Text = randomArray[3].ToString();

            #endregion 產生四個不重複的1~9的數字
        }

        public static int buttonTotal = 0;

        //提交答案按鈕
        private void sendButton_Click(object sender, EventArgs e)
        {
            #region 如果使用者未輸入TextBox

            if (string.IsNullOrEmpty(anOneTextBox.Text) || string.IsNullOrEmpty(anTwoTextBox.Text) ||
                string.IsNullOrEmpty(anThreeTextBox.Text) || string.IsNullOrEmpty(anFourTextBox.Text))
            {
                this.answerLabel.Text = "輸入錯誤，請重新輸入";

                return;
            }

            #endregion 如果使用者未輸入TextBox

            else
            {
                buttonTotal += 1;
                tipsALabel.Show();
                tipsBLabel.Show();

                #region 按下按鈕，輸入的字放進label中，並轉成數字

                this.anOneLabel.Text = this.anOneTextBox.Text;
                this.anTwoLabel.Text = this.anTwoTextBox.Text;
                this.anThreeLabel.Text = this.anThreeTextBox.Text;
                this.anFourLabel.Text = this.anFourTextBox.Text;

                int number1 = int.Parse(this.oneLabel.Text);
                int number2 = int.Parse(this.twoLabel.Text);
                int number3 = int.Parse(this.threeLabel.Text);
                int number4 = int.Parse(this.fourLabel.Text);

                int anNumber1 = int.Parse(this.anOneLabel.Text);
                int anNumber2 = int.Parse(this.anTwoLabel.Text);
                int anNumber3 = int.Parse(this.anThreeLabel.Text);
                int anNumber4 = int.Parse(this.anFourLabel.Text);

                #endregion 按下按鈕，輸入的字放進label中，並轉成數字

                #region 結果?A的算法

                int anserAscore = 0;

                if (number1 == anNumber1)

                    anserAscore += 1;
                else
                    anserAscore += 0;

                if (number2 == anNumber2)

                    anserAscore += 1;
                else
                    anserAscore += 0;

                if (number3 == anNumber3)

                    anserAscore += 1;
                else
                    anserAscore += 0;

                if (number4 == anNumber4)

                    anserAscore += 1;
                else
                    anserAscore += 0;

                this.resultLabelA.Text = string.Format("{0}A", anserAscore);

                //如果獲得4A 表示贏了
                if (number1 == anNumber1 && number2 == anNumber2 && number3 == anNumber3 && number4 == anNumber4)
                {
                    this.winLabel.Show();
                    Render2();
                }

                #endregion 結果?A的算法

                #region 結果?B的算法

                int anserBscore = 0;
                if (anNumber1 == number2)
                    anserBscore += 1;
                else
                    anserBscore += 0;
                if (anNumber1 == number3)
                    anserBscore += 1;
                else
                    anserBscore += 0;
                if (anNumber1 == number4)
                    anserBscore += 1;
                else
                    anserBscore += 0;

                if (anNumber2 == number1)
                    anserBscore += 1;
                else
                    anserBscore += 0;
                if (anNumber2 == number3)
                    anserBscore += 1;
                else
                    anserBscore += 0;
                if (anNumber2 == number4)
                    anserBscore += 1;
                else
                    anserBscore += 0;
                if (anNumber3 == number1)
                    anserBscore += 1;
                else
                    anserBscore += 0;
                if (anNumber3 == number2)
                    anserBscore += 1;
                else
                    anserBscore += 0;
                if (anNumber3 == number4)
                    anserBscore += 1;
                else
                    anserBscore += 0;
                if (anNumber4 == number1)
                    anserBscore += 1;
                else
                    anserBscore += 0;
                if (anNumber4 == number2)
                    anserBscore += 1;
                else
                    anserBscore += 0;
                if (anNumber4 == number3)
                    anserBscore += 1;
                else
                    anserBscore += 0;

                this.resultLabelB.Text = string.Format("{0}B", anserBscore);

                #endregion 結果?B的算法

                #region 提醒沒有重複的數字

                if (buttonTotal == 3)
                {
                    tipsLabel.Show();
                    tipsLabel.Text = "溫馨小叮嚀：沒有重複的數字喔！";
                }

                #endregion 提醒沒有重複的數字
            }
        }

        //顯示猜了幾次
        public void Render2()
        {
            this.winLabel.Text = "贏了 你總共猜了" + buttonTotal + "次";
        }

        //重新開始按鈕
        private void ReSetButton_Click(object sender, EventArgs e)
        {
            Render();
            buttonTotal = 0;
        }
    }
}