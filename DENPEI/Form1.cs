using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace DENPEI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string cmdRun(string command)
        {
            //Processオブジェクトを作成
            System.Diagnostics.Process p = new System.Diagnostics.Process();

            //ComSpec(cmd.exe)のパスを取得して、FileNameプロパティに指定
            p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
            //出力を読み取れるようにする
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = false;
            //ウィンドウを表示しないようにする
            p.StartInfo.CreateNoWindow = true;
            //コマンドラインを指定（"/c"は実行後閉じるために必要）
            p.StartInfo.Arguments = @"/c " + command;

            //起動
            p.Start();

            //出力を読み取る
            string results = p.StandardOutput.ReadToEnd();

            //プロセス終了まで待機する
            //WaitForExitはReadToEndの後である必要がある
            //(親プロセス、子プロセスでブロック防止のため)
            p.WaitForExit();
            p.Close();

            //出力された結果を表示
            return results;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(checkCToolStripMenuItem_Click);
            // 1秒インターバル
            // timer.Interval = 1000;
            // 1分インターバル
            timer.Interval = 60000;
            timer.Start();
        }

        private void alarm()
        {
            // 音量を80に調整する
            SetVolume(80);

            // 再生設定
            AudioFileReader reader = new AudioFileReader(@"yellow.mp3");
            WaveOut waveOut = new WaveOut();
            waveOut.Init(reader);
            waveOut.Play();
            // while (waveOut.PlaybackState == PlaybackState.Playing) ;
        }

        private void check()
        {
            //AC電源の状態
            PowerLineStatus pls = SystemInformation.PowerStatus.PowerLineStatus;
            switch (pls)
            {
                case PowerLineStatus.Offline:
                    label1.Text = "オフラインです";
                    label1.ForeColor = Color.Red;

                    break;
                case PowerLineStatus.Online:
                    label1.Text = "オンラインです";
                    label1.ForeColor = Color.Green;
                    break;
                case PowerLineStatus.Unknown:
                    label1.Text = "不明です";
                    label1.ForeColor = Color.Gray;
                    break;
            }

            //バッテリーの充電状態を取得する
            BatteryChargeStatus bcs = SystemInformation.PowerStatus.BatteryChargeStatus;
            if (bcs == BatteryChargeStatus.Unknown)
            {
                label2.Text = "不明です";
            }
            else
            {
                if ((bcs & BatteryChargeStatus.High) == BatteryChargeStatus.High)
                {
                    label2.Text = "高い（66%より上）です";
                    label2.ForeColor = Color.Green;
                }
                if ((bcs & BatteryChargeStatus.Low) == BatteryChargeStatus.Low)
                {
                    label2.Text = "低い（33%未満）です";
                    label2.ForeColor = Color.Yellow;
                    alarm();
                }
                if ((bcs & BatteryChargeStatus.Critical) == BatteryChargeStatus.Critical)
                {
                    label2.Text = "最低（5%未満）です";
                    label2.ForeColor = Color.Red;
                    alarm();
                }
                if ((bcs & BatteryChargeStatus.Charging) == BatteryChargeStatus.Charging)
                {
                    label2.Text = "充電中です";
                    label2.ForeColor = Color.Green;
                }
                if ((bcs & BatteryChargeStatus.NoSystemBattery) == BatteryChargeStatus.NoSystemBattery)
                {
                    label2.Text = "バッテリーが存在しません";
                    label2.ForeColor = Color.Gray;
                }
            }

            //バッテリー残量（割合）
            float blp = SystemInformation.PowerStatus.BatteryLifePercent;
            float blpP = (blp * 100);
            label3.Text = blpP + " %です";
            if (66 < blpP)
            {
                label2.ForeColor = Color.Green;
            }
            if (33 > blpP)
            {
                label2.ForeColor = Color.Yellow;
            }
            if (5 > blpP)
            {
                label2.ForeColor = Color.Red;
            }

            //バッテリー残量（時間）
            int blr = SystemInformation.PowerStatus.BatteryLifeRemaining;
            if (-1 < blr)
            {
                label4.Text = blr + " 秒です";
            }
            else
            {
                //AC電源がオンラインの時など
                label4.Text = "不明です";
                label4.ForeColor = Color.Gray;
            }

            //バッテリーがフル充電された時の持ち時間（バッテリー駆動時間）
            int bfl = SystemInformation.PowerStatus.BatteryFullLifetime;
            if (-1 < bfl)
            {
                label5.Text = bfl + " 秒です";
            }
            else
            {
                label5.Text = "不明です";
                label5.ForeColor = Color.Gray;
            }
        }

        private void checkCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            check();
        }

        private void closeWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetVolume(int value)
        {
            // 音量を変更
            MMDevice device;
            MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
            device = DevEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            device.AudioEndpointVolume.MasterVolumeLevelScalar = ((float)value / 100.0f);
        }

        private void versionVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void reportRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = cmdRun("powercfg /batteryreport /output report.html");
        }
    }
}
