namespace SerialPortReader
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRecieveTresh = new System.Windows.Forms.TextBox();
            this.lblGiden = new System.Windows.Forms.Label();
            this.btnTekrar = new System.Windows.Forms.Button();
            this.cbKomut = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDatabits = new System.Windows.Forms.ComboBox();
            this.lblDatabitBaslik = new System.Windows.Forms.Label();
            this.lblWriteTimeoutBaslik = new System.Windows.Forms.Label();
            this.cbWriteTimeout = new System.Windows.Forms.ComboBox();
            this.lblParityBaslik = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.lblStopbitBaslik = new System.Windows.Forms.Label();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.lblBaudRateBaslik = new System.Windows.Forms.Label();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.lblReadTimeoutBaslik = new System.Windows.Forms.Label();
            this.lblPortlarBaslik = new System.Windows.Forms.Label();
            this.cbReadTimeout = new System.Windows.Forms.ComboBox();
            this.btnPortTazele = new System.Windows.Forms.Button();
            this.rbBaglantiDurumu = new System.Windows.Forms.RadioButton();
            this.btnBaglanti = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.spc = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGelenByteBaslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGidenByteBaslik = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBolumle = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbString = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lineNumbers_For_RichTextBox1 = new LineNumbers.LineNumbers_For_RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc)).BeginInit();
            this.spc.Panel1.SuspendLayout();
            this.spc.Panel2.SuspendLayout();
            this.spc.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbRecieveTresh);
            this.panel1.Controls.Add(this.lblGiden);
            this.panel1.Controls.Add(this.btnTekrar);
            this.panel1.Controls.Add(this.cbKomut);
            this.panel1.Location = new System.Drawing.Point(9, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 55);
            this.panel1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "ReceiveThreshold";
            // 
            // tbRecieveTresh
            // 
            this.tbRecieveTresh.Location = new System.Drawing.Point(158, 23);
            this.tbRecieveTresh.Name = "tbRecieveTresh";
            this.tbRecieveTresh.Size = new System.Drawing.Size(90, 20);
            this.tbRecieveTresh.TabIndex = 39;
            this.tbRecieveTresh.Text = "1";
            this.tbRecieveTresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGiden
            // 
            this.lblGiden.AutoSize = true;
            this.lblGiden.Location = new System.Drawing.Point(5, 7);
            this.lblGiden.Name = "lblGiden";
            this.lblGiden.Size = new System.Drawing.Size(37, 13);
            this.lblGiden.TabIndex = 37;
            this.lblGiden.Text = "Komut";
            // 
            // btnTekrar
            // 
            this.btnTekrar.Location = new System.Drawing.Point(253, 21);
            this.btnTekrar.Name = "btnTekrar";
            this.btnTekrar.Size = new System.Drawing.Size(75, 23);
            this.btnTekrar.TabIndex = 36;
            this.btnTekrar.Text = "Tekrarla";
            this.btnTekrar.UseVisualStyleBackColor = true;
            this.btnTekrar.Click += new System.EventHandler(this.btnTekrar_Click);
            // 
            // cbKomut
            // 
            this.cbKomut.FormattingEnabled = true;
            this.cbKomut.Items.AddRange(new object[] {
            "z - 1 Bağlantı",
            "0 - 4 Seri No",
            "1 - 2 Anlık Giriş İletkenliği",
            "2 - 2 Anlık Üretim İletkenliği",
            "3 - 1 Sıcaklık",
            "4 - 2 Çalışma Saati ",
            "5 - 2 Alarm Sayıs2",
            "6 - 2 Dezenfeksiyon Sayısı",
            "7 - 1 Üretim Limit İletkenlik",
            "8 - 2 Giriş Limit İletkenlik",
            "9 - 1 Dezenfeksiyon Süresi",
            ": - 1 Durulama Süresi",
            "; - 1 Temizlem Süresi",
            "< -  Alarm Log",
            "= -  Tüm Loglar",
            "    (>> - 1 Hand Shake",
            "? - 3 Kayıt Sayısı",
            "  - 16 Versiyon No"});
            this.cbKomut.Location = new System.Drawing.Point(5, 23);
            this.cbKomut.Name = "cbKomut";
            this.cbKomut.Size = new System.Drawing.Size(146, 21);
            this.cbKomut.TabIndex = 35;
            this.cbKomut.SelectedIndexChanged += new System.EventHandler(this.cbKomut_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cbDatabits);
            this.panel2.Controls.Add(this.lblDatabitBaslik);
            this.panel2.Controls.Add(this.lblWriteTimeoutBaslik);
            this.panel2.Controls.Add(this.cbWriteTimeout);
            this.panel2.Controls.Add(this.lblParityBaslik);
            this.panel2.Controls.Add(this.cbParity);
            this.panel2.Controls.Add(this.lblStopbitBaslik);
            this.panel2.Controls.Add(this.cbStopBits);
            this.panel2.Controls.Add(this.lblBaudRateBaslik);
            this.panel2.Controls.Add(this.cbBaudrate);
            this.panel2.Controls.Add(this.lblReadTimeoutBaslik);
            this.panel2.Controls.Add(this.lblPortlarBaslik);
            this.panel2.Controls.Add(this.cbReadTimeout);
            this.panel2.Controls.Add(this.btnPortTazele);
            this.panel2.Controls.Add(this.rbBaglantiDurumu);
            this.panel2.Controls.Add(this.btnBaglanti);
            this.panel2.Controls.Add(this.cbPorts);
            this.panel2.Location = new System.Drawing.Point(9, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 61);
            this.panel2.TabIndex = 27;
            // 
            // cbDatabits
            // 
            this.cbDatabits.FormattingEnabled = true;
            this.cbDatabits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDatabits.Location = new System.Drawing.Point(753, 24);
            this.cbDatabits.Name = "cbDatabits";
            this.cbDatabits.Size = new System.Drawing.Size(110, 21);
            this.cbDatabits.TabIndex = 43;
            // 
            // lblDatabitBaslik
            // 
            this.lblDatabitBaslik.AutoSize = true;
            this.lblDatabitBaslik.Location = new System.Drawing.Point(753, 9);
            this.lblDatabitBaslik.Name = "lblDatabitBaslik";
            this.lblDatabitBaslik.Size = new System.Drawing.Size(47, 13);
            this.lblDatabitBaslik.TabIndex = 42;
            this.lblDatabitBaslik.Text = "DataBits";
            // 
            // lblWriteTimeoutBaslik
            // 
            this.lblWriteTimeoutBaslik.AutoSize = true;
            this.lblWriteTimeoutBaslik.Location = new System.Drawing.Point(285, 8);
            this.lblWriteTimeoutBaslik.Name = "lblWriteTimeoutBaslik";
            this.lblWriteTimeoutBaslik.Size = new System.Drawing.Size(102, 13);
            this.lblWriteTimeoutBaslik.TabIndex = 40;
            this.lblWriteTimeoutBaslik.Text = "Yazma Zaman Aşımı";
            // 
            // cbWriteTimeout
            // 
            this.cbWriteTimeout.FormattingEnabled = true;
            this.cbWriteTimeout.Items.AddRange(new object[] {
            "100",
            "250",
            "500",
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000"});
            this.cbWriteTimeout.Location = new System.Drawing.Point(285, 24);
            this.cbWriteTimeout.Name = "cbWriteTimeout";
            this.cbWriteTimeout.Size = new System.Drawing.Size(110, 21);
            this.cbWriteTimeout.TabIndex = 39;
            // 
            // lblParityBaslik
            // 
            this.lblParityBaslik.AutoSize = true;
            this.lblParityBaslik.Location = new System.Drawing.Point(636, 8);
            this.lblParityBaslik.Name = "lblParityBaslik";
            this.lblParityBaslik.Size = new System.Drawing.Size(33, 13);
            this.lblParityBaslik.TabIndex = 38;
            this.lblParityBaslik.Text = "Parity";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "Even",
            "None",
            "Mark",
            "Odd",
            "Space"});
            this.cbParity.Location = new System.Drawing.Point(636, 24);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(110, 21);
            this.cbParity.TabIndex = 37;
            // 
            // lblStopbitBaslik
            // 
            this.lblStopbitBaslik.AutoSize = true;
            this.lblStopbitBaslik.Location = new System.Drawing.Point(402, 8);
            this.lblStopbitBaslik.Name = "lblStopbitBaslik";
            this.lblStopbitBaslik.Size = new System.Drawing.Size(46, 13);
            this.lblStopbitBaslik.TabIndex = 36;
            this.lblStopbitBaslik.Text = "StopBits";
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.cbStopBits.Location = new System.Drawing.Point(402, 24);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(110, 21);
            this.cbStopBits.TabIndex = 35;
            // 
            // lblBaudRateBaslik
            // 
            this.lblBaudRateBaslik.AutoSize = true;
            this.lblBaudRateBaslik.Location = new System.Drawing.Point(519, 8);
            this.lblBaudRateBaslik.Name = "lblBaudRateBaslik";
            this.lblBaudRateBaslik.Size = new System.Drawing.Size(55, 13);
            this.lblBaudRateBaslik.TabIndex = 34;
            this.lblBaudRateBaslik.Text = "BaudRate";
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "56600",
            "115200"});
            this.cbBaudrate.Location = new System.Drawing.Point(519, 24);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(110, 21);
            this.cbBaudrate.TabIndex = 33;
            // 
            // lblReadTimeoutBaslik
            // 
            this.lblReadTimeoutBaslik.AutoSize = true;
            this.lblReadTimeoutBaslik.Location = new System.Drawing.Point(168, 8);
            this.lblReadTimeoutBaslik.Name = "lblReadTimeoutBaslik";
            this.lblReadTimeoutBaslik.Size = new System.Drawing.Size(104, 13);
            this.lblReadTimeoutBaslik.TabIndex = 32;
            this.lblReadTimeoutBaslik.Text = "Okuma Zaman Aşımı";
            // 
            // lblPortlarBaslik
            // 
            this.lblPortlarBaslik.AutoSize = true;
            this.lblPortlarBaslik.Location = new System.Drawing.Point(6, 8);
            this.lblPortlarBaslik.Name = "lblPortlarBaslik";
            this.lblPortlarBaslik.Size = new System.Drawing.Size(37, 13);
            this.lblPortlarBaslik.TabIndex = 31;
            this.lblPortlarBaslik.Text = "Portlar";
            // 
            // cbReadTimeout
            // 
            this.cbReadTimeout.FormattingEnabled = true;
            this.cbReadTimeout.Items.AddRange(new object[] {
            "100",
            "250",
            "500",
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000"});
            this.cbReadTimeout.Location = new System.Drawing.Point(168, 24);
            this.cbReadTimeout.Name = "cbReadTimeout";
            this.cbReadTimeout.Size = new System.Drawing.Size(110, 21);
            this.cbReadTimeout.TabIndex = 30;
            // 
            // btnPortTazele
            // 
            this.btnPortTazele.Location = new System.Drawing.Point(98, 23);
            this.btnPortTazele.Name = "btnPortTazele";
            this.btnPortTazele.Size = new System.Drawing.Size(54, 23);
            this.btnPortTazele.TabIndex = 29;
            this.btnPortTazele.Text = "Yenile";
            this.btnPortTazele.UseVisualStyleBackColor = true;
            this.btnPortTazele.Click += new System.EventHandler(this.btnPortTazele_Click);
            // 
            // rbBaglantiDurumu
            // 
            this.rbBaglantiDurumu.AutoCheck = false;
            this.rbBaglantiDurumu.AutoSize = true;
            this.rbBaglantiDurumu.CausesValidation = false;
            this.rbBaglantiDurumu.Location = new System.Drawing.Point(964, 26);
            this.rbBaglantiDurumu.Name = "rbBaglantiDurumu";
            this.rbBaglantiDurumu.Size = new System.Drawing.Size(34, 17);
            this.rbBaglantiDurumu.TabIndex = 28;
            this.rbBaglantiDurumu.TabStop = true;
            this.rbBaglantiDurumu.Text = "...";
            this.rbBaglantiDurumu.UseVisualStyleBackColor = false;
            // 
            // btnBaglanti
            // 
            this.btnBaglanti.Location = new System.Drawing.Point(869, 23);
            this.btnBaglanti.Name = "btnBaglanti";
            this.btnBaglanti.Size = new System.Drawing.Size(89, 23);
            this.btnBaglanti.TabIndex = 27;
            this.btnBaglanti.Text = "Bağlan";
            this.btnBaglanti.UseVisualStyleBackColor = true;
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(6, 24);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(86, 21);
            this.cbPorts.TabIndex = 26;
            // 
            // spc
            // 
            this.spc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.spc.Location = new System.Drawing.Point(9, 132);
            this.spc.Name = "spc";
            this.spc.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc.Panel1
            // 
            this.spc.Panel1.Controls.Add(this.label2);
            this.spc.Panel1.Controls.Add(this.lblGelenByteBaslik);
            this.spc.Panel1.Controls.Add(this.label1);
            this.spc.Panel1.Controls.Add(this.lblGidenByteBaslik);
            this.spc.Panel1.Controls.Add(this.label3);
            this.spc.Panel1.Controls.Add(this.tbBolumle);
            this.spc.Panel1.Controls.Add(this.panel3);
            // 
            // spc.Panel2
            // 
            this.spc.Panel2.Controls.Add(this.panel5);
            this.spc.Size = new System.Drawing.Size(1050, 458);
            this.spc.SplitterDistance = 199;
            this.spc.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(965, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "0";
            // 
            // lblGelenByteBaslik
            // 
            this.lblGelenByteBaslik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGelenByteBaslik.AutoSize = true;
            this.lblGelenByteBaslik.Location = new System.Drawing.Point(886, 177);
            this.lblGelenByteBaslik.Name = "lblGelenByteBaslik";
            this.lblGelenByteBaslik.Size = new System.Drawing.Size(65, 13);
            this.lblGelenByteBaslik.TabIndex = 43;
            this.lblGelenByteBaslik.Text = "Gelen Byte :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "0";
            // 
            // lblGidenByteBaslik
            // 
            this.lblGidenByteBaslik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGidenByteBaslik.AutoSize = true;
            this.lblGidenByteBaslik.Location = new System.Drawing.Point(694, 177);
            this.lblGidenByteBaslik.Name = "lblGidenByteBaslik";
            this.lblGidenByteBaslik.Size = new System.Drawing.Size(65, 13);
            this.lblGidenByteBaslik.TabIndex = 41;
            this.lblGidenByteBaslik.Text = "Giden Byte :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Karakterden Böl";
            // 
            // tbBolumle
            // 
            this.tbBolumle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbBolumle.Location = new System.Drawing.Point(8, 173);
            this.tbBolumle.Name = "tbBolumle";
            this.tbBolumle.Size = new System.Drawing.Size(47, 20);
            this.tbBolumle.TabIndex = 36;
            this.tbBolumle.Text = "1";
            this.tbBolumle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbBolumle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBolumle_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.tbString);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1050, 169);
            this.panel3.TabIndex = 0;
            // 
            // tbString
            // 
            this.tbString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbString.Location = new System.Drawing.Point(0, 0);
            this.tbString.Multiline = true;
            this.tbString.Name = "tbString";
            this.tbString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbString.Size = new System.Drawing.Size(1050, 169);
            this.tbString.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.richTextBox1);
            this.panel5.Controls.Add(this.lineNumbers_For_RichTextBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1050, 255);
            this.panel5.TabIndex = 10;
            // 
            // lineNumbers_For_RichTextBox1
            // 
            this.lineNumbers_For_RichTextBox1._SeeThroughMode_ = true;
            this.lineNumbers_For_RichTextBox1.AutoSizing = true;
            this.lineNumbers_For_RichTextBox1.BackgroundGradient_AlphaColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineNumbers_For_RichTextBox1.BackgroundGradient_BetaColor = System.Drawing.Color.LightSteelBlue;
            this.lineNumbers_For_RichTextBox1.BackgroundGradient_Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lineNumbers_For_RichTextBox1.BorderLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox1.BorderLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineNumbers_For_RichTextBox1.BorderLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lineNumbers_For_RichTextBox1.DockSide = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Left;
            this.lineNumbers_For_RichTextBox1.GridLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox1.GridLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineNumbers_For_RichTextBox1.GridLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox1.LineNrs_Alignment = System.Drawing.ContentAlignment.TopRight;
            this.lineNumbers_For_RichTextBox1.LineNrs_AntiAlias = true;
            this.lineNumbers_For_RichTextBox1.LineNrs_AsHexadecimal = false;
            this.lineNumbers_For_RichTextBox1.LineNrs_ClippedByItemRectangle = true;
            this.lineNumbers_For_RichTextBox1.LineNrs_LeadingZeroes = true;
            this.lineNumbers_For_RichTextBox1.LineNrs_Offset = new System.Drawing.Size(0, 0);
            this.lineNumbers_For_RichTextBox1.Location = new System.Drawing.Point(0, 0);
            this.lineNumbers_For_RichTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.lineNumbers_For_RichTextBox1.MarginLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox1.MarginLines_Side = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Right;
            this.lineNumbers_For_RichTextBox1.MarginLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.lineNumbers_For_RichTextBox1.MarginLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox1.Name = "lineNumbers_For_RichTextBox1";
            this.lineNumbers_For_RichTextBox1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.lineNumbers_For_RichTextBox1.ParentRichTextBox = this.richTextBox1;
            this.lineNumbers_For_RichTextBox1.Show_BackgroundGradient = true;
            this.lineNumbers_For_RichTextBox1.Show_BorderLines = true;
            this.lineNumbers_For_RichTextBox1.Show_GridLines = true;
            this.lineNumbers_For_RichTextBox1.Show_LineNrs = true;
            this.lineNumbers_For_RichTextBox1.Show_MarginLines = true;
            this.lineNumbers_For_RichTextBox1.Size = new System.Drawing.Size(18, 255);
            this.lineNumbers_For_RichTextBox1.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(18, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1032, 255);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 590);
            this.Controls.Add(this.spc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Serial Port Okuyucu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.spc.Panel1.ResumeLayout(false);
            this.spc.Panel1.PerformLayout();
            this.spc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc)).EndInit();
            this.spc.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort sp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRecieveTresh;
        private System.Windows.Forms.Label lblGiden;
        private System.Windows.Forms.Button btnTekrar;
        private System.Windows.Forms.ComboBox cbKomut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStopbitBaslik;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.Label lblBaudRateBaslik;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.Label lblReadTimeoutBaslik;
        private System.Windows.Forms.Label lblPortlarBaslik;
        private System.Windows.Forms.ComboBox cbReadTimeout;
        private System.Windows.Forms.Button btnPortTazele;
        private System.Windows.Forms.RadioButton rbBaglantiDurumu;
        private System.Windows.Forms.Button btnBaglanti;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Label lblParityBaslik;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Label lblWriteTimeoutBaslik;
        private System.Windows.Forms.ComboBox cbWriteTimeout;
        private System.Windows.Forms.ComboBox cbDatabits;
        private System.Windows.Forms.Label lblDatabitBaslik;
        private System.Windows.Forms.SplitContainer spc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBolumle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGelenByteBaslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGidenByteBaslik;
        private System.Windows.Forms.Panel panel5;
        private LineNumbers.LineNumbers_For_RichTextBox lineNumbers_For_RichTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;

    }
}

