namespace DENPEI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(checkCToolStripMenuItem_Click);
            // 1秒インターバル
            // timer.Interval = 1000;
            timer.Interval = 60000;
            timer.Start();
        }

        private void check()
        {
            //AC電源の状態
            PowerLineStatus pls = SystemInformation.PowerStatus.PowerLineStatus;
            switch (pls)
            {
                case PowerLineStatus.Offline:
                    label1.Text = "AC電源がオフラインです";
                    break;
                case PowerLineStatus.Online:
                    label1.Text = "AC電源がオンラインです";
                    break;
                case PowerLineStatus.Unknown:
                    label1.Text = "AC電源の状態は不明です";
                    break;
            }

            //バッテリーの充電状態を取得する
            BatteryChargeStatus bcs =
                SystemInformation.PowerStatus.BatteryChargeStatus;
            if (bcs == BatteryChargeStatus.Unknown)
            {
                label2.Text = "不明です";
            }
            else
            {
                if ((bcs & BatteryChargeStatus.High) ==
                    BatteryChargeStatus.High)
                {
                    label2.Text = "充電レベルは、高い(66%より上)です";
                }
                if ((bcs & BatteryChargeStatus.Low) ==
                    BatteryChargeStatus.Low)
                {
                    label2.Text = "充電レベルは、低い(33%未満)です";
                }
                if ((bcs & BatteryChargeStatus.Critical) ==
                    BatteryChargeStatus.Critical)
                {
                    label2.Text = "充電レベルは、最低(5%未満)です";
                }
                if ((bcs & BatteryChargeStatus.Charging) ==
                    BatteryChargeStatus.Charging)
                {
                    label2.Text = "充電中です";
                }
                if ((bcs & BatteryChargeStatus.NoSystemBattery) ==
                    BatteryChargeStatus.NoSystemBattery)
                {
                    label2.Text = "バッテリーが存在しません";
                }
            }

            //バッテリー残量（割合）
            float blp = SystemInformation.PowerStatus.BatteryLifePercent;
            label3.Text = "バッテリー残量は、" + (blp * 100) + "%です";

            //バッテリー残量（時間）
            int blr = SystemInformation.PowerStatus.BatteryLifeRemaining;
            if (-1 < blr)
            {
                label4.Text = "バッテリー残り時間は、" + blr + "秒です";
            }
            else
            {
                //AC電源がオンラインの時など
                label4.Text = "バッテリー残り時間は、不明です";
            }

            //バッテリーがフル充電された時の持ち時間（バッテリー駆動時間）
            int bfl = SystemInformation.PowerStatus.BatteryFullLifetime;
            if (-1 < bfl)
            {
                label5.Text = "バッテリー駆動時間は、{" + bfl + "}秒です";
            }
            else
            {
                label5.Text = "バッテリー駆動時間は、不明です";
            }
        }

        private void checkCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            check();
        }
    }
}
