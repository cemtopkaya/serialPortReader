using System;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialPortReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f_PortlariBagla();

            // DefaultTimeOut 1000 olsun
            cbReadTimeout.SelectedIndex = 3;
            cbWriteTimeout.SelectedIndex = 3;
            cbParity.SelectedIndex = 1;
            cbBaudrate.SelectedIndex = 0;
            cbStopBits.SelectedIndex = 1;
            cbDatabits.SelectedIndex = 3;

            btnBaglanti.Click += btnBaglanti_Baglan_Click;
        }

        private void f_PortlariBagla()
        {
            cbPorts.Items.Clear();
            cbPorts.Items.AddRange(SerialPort.GetPortNames());
            cbPorts.SelectedIndex = 1;
        }

        #region Bağlan/Bağlantıyı Kes Eventleri
        private void btnBaglanti_Baglan_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPorts.SelectedItem != null)
                {
                    rbBaglantiDurumu.Text = "Bekleyiniz...";

                    sp = f_SerialPort();
                    if (!sp.IsOpen)
                    {
                        sp.Open();
                        rbBaglantiDurumu.Checked = true;
                        rbBaglantiDurumu.Text = "Bağlandi";
                        btnBaglanti.Text = "Bağlantıyı Kes";

                        btnBaglanti.Click -= btnBaglanti_Baglan_Click;
                        btnBaglanti.Click += btnBaglanti_BaglantiyiKes_Click;
                    }
                    else
                    {
                        rbBaglantiDurumu.Checked = false;
                        rbBaglantiDurumu.Text = "Baglantı Yok!";
                    }
                }
            }
            catch (TimeoutException tex)
            {
                rbBaglantiDurumu.Text = "...";
                MessageBox.Show("Bağlantı zaman aşımına uğradı. HATA:\n" + tex.Message);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                rbBaglantiDurumu.Text = "...";
                MessageBox.Show(sp.PortName + " Portuna erişim yetkiniz yok! HATA:\n" + uaEx);
            }
            catch (Exception ex)
            {
                rbBaglantiDurumu.Text = "...";
                MessageBox.Show(ex.ToString());
            }
        }

        private SerialPort f_SerialPort()
        {
            SerialPort spConnection = new SerialPort();
            if (string.IsNullOrEmpty(cbPorts.Text))
            {
                throw new Exception("Bağlantı kurulacak port adı tayin edilmemiş.");
            }

            spConnection = new SerialPort
                               {
                                   PortName = cbPorts.SelectedItem.ToString(),
                                   ReadTimeout = Convert.ToInt32(cbReadTimeout.Text),
                                   WriteTimeout = Convert.ToInt32(cbReadTimeout.Text),
                                   BaudRate = Convert.ToInt32(cbBaudrate.Text),
                                   StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text),
                                   Parity = (Parity)Enum.Parse(typeof(Parity), cbParity.Text),
                                   DataBits = Convert.ToInt32(cbDatabits.Text),
                               };

            spConnection.DataReceived += sp_DataReceived;
            spConnection.ErrorReceived += sp_ErrorReceived;
            return spConnection;
        }


        private void btnBaglanti_BaglantiyiKes_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp != null)
                {
                    if (sp.IsOpen)
                    {
                        sp.Close();
                        rbBaglantiDurumu.Checked = false;
                        rbBaglantiDurumu.Text = "...";
                        btnBaglanti.Text = "Bağlan";

                        btnBaglanti.Click -= btnBaglanti_BaglantiyiKes_Click;
                        btnBaglanti.Click += btnBaglanti_Baglan_Click;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı kesilirken istisna fırlatıldı. \n\nİSTİSNA:\n" + ex);
            }
        }
        #endregion


        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int bufLen = 1024;
                byte[] buffer = new byte[bufLen];

                int i = sp.Read(buffer, 0, bufLen);

                if (e.EventType == SerialData.Chars)
                {
                    tbString.Text += Encoding.ASCII.GetString(buffer.Take(i).ToArray());
                    for (int j = 0; j < i; j++)
                    {
                        richTextBox1.AppendText(Convert.ToDecimal(buffer.Take(i).ToArray()[j]) + "\t");
                    }
                    label1.Text = i.ToString();
                    label2.Text = (Convert.ToInt32(label2.Text) + i).ToString();
                }
            }
            catch (TimeoutException tex)
            {
                MessageBox.Show("Timeout oldu:\n" + tex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception oldu:\n" + ex);
            }
        }

        void sp_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            try
            {
                
            }
            catch (TimeoutException tex)
            {
                MessageBox.Show("Timeout oldu:\n" + tex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception oldu:\n" + ex);
            }
        }

        private void btnPortTazele_Click(object sender, EventArgs e)
        {
            f_PortlariBagla();
        }

        private void cbKomut_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbString.Text = "";
            richTextBox1.Text = "";
            label1.Text = "0";
            label2.Text = "0";

            if (sp == null)
            {
                MessageBox.Show("Bağlı değil!!!");
                return;
            }

            if (cbKomut.Text == "")
            {
                MessageBox.Show("Bir komut seçilmedi!");
                return;
            }

            try
            {
                sp.ReceivedBytesThreshold = Convert.ToInt32(tbRecieveTresh.Text);

                if (!sp.IsOpen)
                {
                    sp.Open();
                }
                sp.Write(cbKomut.Text.Substring(0, 1));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata fırlatıldı:\n" + ex);
            }
        }

        private void btnTekrar_Click(object sender, EventArgs e)
        {
            cbKomut_SelectedIndexChanged(cbKomut, null);
        }

        private void tbBolumle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && !string.IsNullOrWhiteSpace(tbBolumle.Text))
            {
                int iLen = tbString.Text.Length;
                int iBolum = Convert.ToInt32(tbBolumle.Text);
                string sText = tbString.Text;
                string sSonuc = "";

                for (int i = 0; i < Convert.ToInt32(Math.Ceiling(iLen / iBolum * 1.0)); i++)
                {
                    if (i == 0)
                    {
                        continue;
                    }
                    sSonuc += sText.Substring(i * iBolum, iBolum) + Environment.NewLine;
                }
                tbString.Text = sSonuc;


                string[] barr = richTextBox1.Text.Split('\t');
                string sBytes = "";
                for (int i = 0; i < barr.Length; i++)
                {
                    if (i != 0 && i % (iBolum) == 0)
                    {
                        sBytes += Environment.NewLine;
                    }
                    sBytes += barr[i] + "\t";
                }
                richTextBox1.Text = sBytes;
            }

        }
    }
}
