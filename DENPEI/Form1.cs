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
            // 1�b�C���^�[�o��
            // timer.Interval = 1000;
            timer.Interval = 60000;
            timer.Start();
        }

        private void check()
        {
            //AC�d���̏��
            PowerLineStatus pls = SystemInformation.PowerStatus.PowerLineStatus;
            switch (pls)
            {
                case PowerLineStatus.Offline:
                    label1.Text = "�I�t���C���ł�";
                    label1.ForeColor = Color.Red;
                    break;
                case PowerLineStatus.Online:
                    label1.Text = "�I�����C���ł�";
                    label1.ForeColor = Color.Green;
                    break;
                case PowerLineStatus.Unknown:
                    label1.Text = "�s���ł�";
                    label1.ForeColor = Color.Gray;
                    break;
            }

            //�o�b�e���[�̏[�d��Ԃ��擾����
            BatteryChargeStatus bcs = SystemInformation.PowerStatus.BatteryChargeStatus;
            if (bcs == BatteryChargeStatus.Unknown)
            {
                label2.Text = "�s���ł�";
            }
            else
            {
                if ((bcs & BatteryChargeStatus.High) == BatteryChargeStatus.High)
                {
                    label2.Text = "�����i66%����j�ł�";
                    label2.ForeColor = Color.Green;
                }
                if ((bcs & BatteryChargeStatus.Low) == BatteryChargeStatus.Low)
                {
                    label2.Text = "�Ⴂ�i33%�����j�ł�";
                    label2.ForeColor = Color.Yellow;
                }
                if ((bcs & BatteryChargeStatus.Critical) == BatteryChargeStatus.Critical)
                {
                    label2.Text = "�Œ�i5%�����j�ł�";
                    label2.ForeColor = Color.Red;
                }
                if ((bcs & BatteryChargeStatus.Charging) == BatteryChargeStatus.Charging)
                {
                    label2.Text = "�[�d���ł�";
                    label2.ForeColor = Color.Green;
                }
                if ((bcs & BatteryChargeStatus.NoSystemBattery) == BatteryChargeStatus.NoSystemBattery)
                {
                    label2.Text = "�o�b�e���[�����݂��܂���";
                    label2.ForeColor = Color.Gray;
                }
            }

            //�o�b�e���[�c�ʁi�����j
            float blp = SystemInformation.PowerStatus.BatteryLifePercent;
            float blpP = (blp * 100);
            label3.Text = blpP + " %�ł�";
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

            //�o�b�e���[�c�ʁi���ԁj
            int blr = SystemInformation.PowerStatus.BatteryLifeRemaining;
            if (-1 < blr)
            {
                label4.Text = blr + " �b�ł�";
            }
            else
            {
                //AC�d�����I�����C���̎��Ȃ�
                label4.Text = "�s���ł�";
                label4.ForeColor = Color.Gray;
            }

            //�o�b�e���[���t���[�d���ꂽ���̎������ԁi�o�b�e���[�쓮���ԁj
            int bfl = SystemInformation.PowerStatus.BatteryFullLifetime;
            if (-1 < bfl)
            {
                label5.Text = bfl + " �b�ł�";
            }
            else
            {
                label5.Text = "�s���ł�";
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

        private void versionVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
