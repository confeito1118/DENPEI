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
                    label1.Text = "AC�d�����I�t���C���ł�";
                    break;
                case PowerLineStatus.Online:
                    label1.Text = "AC�d�����I�����C���ł�";
                    break;
                case PowerLineStatus.Unknown:
                    label1.Text = "AC�d���̏�Ԃ͕s���ł�";
                    break;
            }

            //�o�b�e���[�̏[�d��Ԃ��擾����
            BatteryChargeStatus bcs =
                SystemInformation.PowerStatus.BatteryChargeStatus;
            if (bcs == BatteryChargeStatus.Unknown)
            {
                label2.Text = "�s���ł�";
            }
            else
            {
                if ((bcs & BatteryChargeStatus.High) ==
                    BatteryChargeStatus.High)
                {
                    label2.Text = "�[�d���x���́A����(66%����)�ł�";
                }
                if ((bcs & BatteryChargeStatus.Low) ==
                    BatteryChargeStatus.Low)
                {
                    label2.Text = "�[�d���x���́A�Ⴂ(33%����)�ł�";
                }
                if ((bcs & BatteryChargeStatus.Critical) ==
                    BatteryChargeStatus.Critical)
                {
                    label2.Text = "�[�d���x���́A�Œ�(5%����)�ł�";
                }
                if ((bcs & BatteryChargeStatus.Charging) ==
                    BatteryChargeStatus.Charging)
                {
                    label2.Text = "�[�d���ł�";
                }
                if ((bcs & BatteryChargeStatus.NoSystemBattery) ==
                    BatteryChargeStatus.NoSystemBattery)
                {
                    label2.Text = "�o�b�e���[�����݂��܂���";
                }
            }

            //�o�b�e���[�c�ʁi�����j
            float blp = SystemInformation.PowerStatus.BatteryLifePercent;
            label3.Text = "�o�b�e���[�c�ʂ́A" + (blp * 100) + "%�ł�";

            //�o�b�e���[�c�ʁi���ԁj
            int blr = SystemInformation.PowerStatus.BatteryLifeRemaining;
            if (-1 < blr)
            {
                label4.Text = "�o�b�e���[�c�莞�Ԃ́A" + blr + "�b�ł�";
            }
            else
            {
                //AC�d�����I�����C���̎��Ȃ�
                label4.Text = "�o�b�e���[�c�莞�Ԃ́A�s���ł�";
            }

            //�o�b�e���[���t���[�d���ꂽ���̎������ԁi�o�b�e���[�쓮���ԁj
            int bfl = SystemInformation.PowerStatus.BatteryFullLifetime;
            if (-1 < bfl)
            {
                label5.Text = "�o�b�e���[�쓮���Ԃ́A{" + bfl + "}�b�ł�";
            }
            else
            {
                label5.Text = "�o�b�e���[�쓮���Ԃ́A�s���ł�";
            }
        }

        private void checkCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            check();
        }
    }
}
