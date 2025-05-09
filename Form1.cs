namespace 倒數計時器
{

    public partial class Form1 : Form
    {
        //秒數
        private int seconds = 0;

        public Form1()
        {
            //從0開始
            InitializeComponent();
            labelTimer.Text = "0";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //計算1-100秒
            if (seconds <= 100)
            {
                labelTimer.Text = seconds.ToString();
                seconds++;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("時間到！");
            }
        }

       

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //控制開始

            seconds = 0;
            labelTimer.Text = "0";
            timer1.Start();
        }
    }
}

