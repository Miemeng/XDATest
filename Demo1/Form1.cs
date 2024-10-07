using System.IO.Ports;

namespace Demo1
{
    public partial class Form1 : Form
    {
        readonly String[] ports = SerialPort.GetPortNames();
        SerialPort serialPort1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1 = new SerialPort();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);
            ComboBoxCom.Items.AddRange(ports);
            ComboBoxNum.Items.Add("9600");
            ComboBoxCom.Text = ports[0];
            ComboBoxNum.Text = "9600";
            SendButton.Enabled = false;
        }

        private void ComboBoxCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComBotton_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    labelStatus.BackColor = Color.Red;
                    ComboBoxCom.Enabled = true;
                    ComboBoxNum.Enabled = true;
                    SendButton.Enabled = false;
                    ComBotton.Text = "打开串口";
                }
                else
                {
                    serialPort1.PortName = ComboBoxCom.Text;
                    serialPort1.BaudRate = Convert.ToInt32(ComboBoxNum.Text);
                    serialPort1.Open();
                    labelStatus.BackColor = Color.Green;
                    ComboBoxCom.Enabled = false;
                    ComboBoxNum.Enabled = false;
                    SendButton.Enabled = true;
                    SendBox.Clear();
                    ReceBox.Clear();
                    ComBotton.Text = "关闭串口";
                }
            }
            catch (Exception ex)
            {
                serialPort1 = new SerialPort();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);
                //刷新COM口选项
                ComboBoxCom.Items.Clear();
                ComboBoxCom.Items.AddRange(SerialPort.GetPortNames());
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                ComBotton.Text = "打开串口";
                labelStatus.BackColor = Color.Red;
                MessageBox.Show(ex.Message);
                ComboBoxNum.Enabled = true;
                ComboBoxCom.Enabled = true;
                SendButton.Enabled= false;
            }
        }

        private void SendButton_Click(object sender, EventArgs e)//发送信息
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(SendBox.Text);
                }
            }
            catch (Exception ex)
            {
                serialPort1 = new SerialPort();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);
                //刷新COM口选项
                ComboBoxCom.Items.Clear();
                ComboBoxCom.Items.AddRange(SerialPort.GetPortNames());
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                ComBotton.Text = "打开串口";
                labelStatus.BackColor = Color.Red;
                MessageBox.Show(ex.Message);
                ComboBoxNum.Enabled = true;
                ComboBoxCom.Enabled = true;
                SendButton.Enabled = false;
            }
        }
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                this.Invoke((EventHandler)(delegate
                {
                    ReceBox.AppendText(serialPort1.ReadExisting());
                }));
            }
            catch (Exception ex)
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
