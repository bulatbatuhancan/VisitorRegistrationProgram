namespace ZiyaretciDefteri
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtPersKod = new System.Windows.Forms.TextBox();
            this.txtAdıSoyadı = new System.Windows.Forms.TextBox();
            this.txtZiyPers = new System.Windows.Forms.TextBox();
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.txtSoyadı = new System.Windows.Forms.TextBox();
            this.txtÇalFirm = new System.Windows.Forms.TextBox();
            this.txtÜnv = new System.Windows.Forms.TextBox();
            this.txtHES = new System.Windows.Forms.TextBox();
            this.txtİrsal = new System.Windows.Forms.TextBox();
            this.txtİrTes = new System.Windows.Forms.TextBox();
            this.txtİrTesEden = new System.Windows.Forms.TextBox();
            this.txtAraçPlaka = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cmbGiriş = new System.Windows.Forms.ComboBox();
            this.cmbPlanlımı = new System.Windows.Forms.ComboBox();
            this.timeEdit3 = new DevExpress.XtraEditors.TimeEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBul = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn39 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn40 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn41 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn42 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretciAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretciSoyadı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretciFirm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretciÜnv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretciHES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretciİrsaliye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretciİrsTeslim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretciİrsTeslimEden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretciArac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretciKonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretciPlanlımı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretciTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretciBaşlangıç = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretciBitiş = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretEdilenPersKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretEdilenAdıSoyadı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGirisYapanPers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretEdilenGirisKapı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretEdilenTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZiyaretEdilenSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn6 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn7 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn8 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn9 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn10 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn11 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn12 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn13 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn14 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn15 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn16 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn17 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn18 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn19 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn20 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn21 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtBaşlama = new System.Windows.Forms.TextBox();
            this.txtBitiş = new System.Windows.Forms.TextBox();
            this.SaatEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ziyaretçi ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyadı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Çalıştığı Firma : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ünvanı : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "HES Kodu :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "İrsaliye Bilgisi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "İrsaliye Teslim Edilecek Kişi :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(386, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "İrsaliye Teslim Eden : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(386, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Araç Plaka :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(386, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ziyaret Konusu :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(386, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Planlı bir ziyaret mi : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(386, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Tarih :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(386, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Başlama Saati :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(386, 224);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Bitiş Saati : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(734, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Ziyaret Edilen ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(767, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Pers. kod : ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(767, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Adı Soyadı : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(767, 125);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(142, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Ziyaretçi Girişi Yapan Pers. : ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(767, 152);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Giriş Kapısı : ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(767, 179);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Griş Tarihi : ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(767, 206);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Giriş Saati : ";
            // 
            // txtPersKod
            // 
            this.txtPersKod.Location = new System.Drawing.Point(834, 69);
            this.txtPersKod.Name = "txtPersKod";
            this.txtPersKod.Size = new System.Drawing.Size(276, 20);
            this.txtPersKod.TabIndex = 23;
            // 
            // txtAdıSoyadı
            // 
            this.txtAdıSoyadı.Location = new System.Drawing.Point(839, 95);
            this.txtAdıSoyadı.Name = "txtAdıSoyadı";
            this.txtAdıSoyadı.Size = new System.Drawing.Size(271, 20);
            this.txtAdıSoyadı.TabIndex = 24;
            // 
            // txtZiyPers
            // 
            this.txtZiyPers.Location = new System.Drawing.Point(915, 122);
            this.txtZiyPers.Name = "txtZiyPers";
            this.txtZiyPers.Size = new System.Drawing.Size(195, 20);
            this.txtZiyPers.TabIndex = 25;
            // 
            // txtAdı
            // 
            this.txtAdı.Location = new System.Drawing.Point(77, 61);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(303, 20);
            this.txtAdı.TabIndex = 30;
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.Location = new System.Drawing.Point(94, 87);
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Size = new System.Drawing.Size(286, 20);
            this.txtSoyadı.TabIndex = 31;
            // 
            // txtÇalFirm
            // 
            this.txtÇalFirm.Location = new System.Drawing.Point(125, 114);
            this.txtÇalFirm.Name = "txtÇalFirm";
            this.txtÇalFirm.Size = new System.Drawing.Size(255, 20);
            this.txtÇalFirm.TabIndex = 32;
            // 
            // txtÜnv
            // 
            this.txtÜnv.Location = new System.Drawing.Point(96, 141);
            this.txtÜnv.Name = "txtÜnv";
            this.txtÜnv.Size = new System.Drawing.Size(284, 20);
            this.txtÜnv.TabIndex = 33;
            // 
            // txtHES
            // 
            this.txtHES.Location = new System.Drawing.Point(109, 168);
            this.txtHES.Name = "txtHES";
            this.txtHES.Size = new System.Drawing.Size(271, 20);
            this.txtHES.TabIndex = 34;
            // 
            // txtİrsal
            // 
            this.txtİrsal.Location = new System.Drawing.Point(120, 195);
            this.txtİrsal.Name = "txtİrsal";
            this.txtİrsal.Size = new System.Drawing.Size(260, 20);
            this.txtİrsal.TabIndex = 35;
            // 
            // txtİrTes
            // 
            this.txtİrTes.Location = new System.Drawing.Point(187, 222);
            this.txtİrTes.Name = "txtİrTes";
            this.txtİrTes.Size = new System.Drawing.Size(193, 20);
            this.txtİrTes.TabIndex = 36;
            // 
            // txtİrTesEden
            // 
            this.txtİrTesEden.Location = new System.Drawing.Point(501, 57);
            this.txtİrTesEden.Name = "txtİrTesEden";
            this.txtİrTesEden.Size = new System.Drawing.Size(225, 20);
            this.txtİrTesEden.TabIndex = 37;
            // 
            // txtAraçPlaka
            // 
            this.txtAraçPlaka.Location = new System.Drawing.Point(457, 87);
            this.txtAraçPlaka.Name = "txtAraçPlaka";
            this.txtAraçPlaka.Size = new System.Drawing.Size(269, 20);
            this.txtAraçPlaka.TabIndex = 38;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(476, 113);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(250, 20);
            this.txtKonu.TabIndex = 39;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(429, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 20);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(465, 255);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(92, 27);
            this.btnKayıt.TabIndex = 45;
            this.btnKayıt.Text = "REGISTER";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(836, 177);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(274, 20);
            this.dateTimePicker2.TabIndex = 46;
            // 
            // cmbGiriş
            // 
            this.cmbGiriş.FormattingEnabled = true;
            this.cmbGiriş.Items.AddRange(new object[] {
            "A kapısı ",
            "B kapısı",
            "C kapısı"});
            this.cmbGiriş.Location = new System.Drawing.Point(841, 150);
            this.cmbGiriş.Name = "cmbGiriş";
            this.cmbGiriş.Size = new System.Drawing.Size(269, 21);
            this.cmbGiriş.TabIndex = 47;
            // 
            // cmbPlanlımı
            // 
            this.cmbPlanlımı.FormattingEnabled = true;
            this.cmbPlanlımı.Items.AddRange(new object[] {
            "Evet ",
            "Hayır"});
            this.cmbPlanlımı.Location = new System.Drawing.Point(493, 140);
            this.cmbPlanlımı.Name = "cmbPlanlımı";
            this.cmbPlanlımı.Size = new System.Drawing.Size(232, 21);
            this.cmbPlanlımı.TabIndex = 48;
            // 
            // timeEdit3
            // 
            this.timeEdit3.EditValue = new System.DateTime(2021, 3, 2, 0, 0, 0, 0);
            this.timeEdit3.Location = new System.Drawing.Point(836, 203);
            this.timeEdit3.Name = "timeEdit3";
            this.timeEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit3.Size = new System.Drawing.Size(100, 20);
            this.timeEdit3.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 53;
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(316, 12);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(298, 20);
            this.txtBul.TabIndex = 54;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(623, 10);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 55;
            this.btnBul.Text = "FIND";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(368, 255);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 27);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource3;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(12, 316);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1116, 349);
            this.gridControl1.TabIndex = 57;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.cardView1,
            this.gridView1,
            this.bandedGridView1});
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "localhost_ZiyaretciDefter_Connection";
            this.sqlDataSource3.Name = "sqlDataSource3";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select * from ZiyaretciDefteri";
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn24,
            this.gridColumn25,
            this.gridColumn26,
            this.gridColumn27,
            this.gridColumn28,
            this.gridColumn29,
            this.gridColumn30,
            this.gridColumn31,
            this.gridColumn32,
            this.gridColumn33,
            this.gridColumn34,
            this.gridColumn35,
            this.gridColumn36,
            this.gridColumn37,
            this.gridColumn38,
            this.gridColumn39,
            this.gridColumn40,
            this.gridColumn41,
            this.gridColumn42});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // gridColumn22
            // 
            this.gridColumn22.FieldName = "ID";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 0;
            // 
            // gridColumn23
            // 
            this.gridColumn23.FieldName = "ZiyaretciAdı";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 1;
            // 
            // gridColumn24
            // 
            this.gridColumn24.FieldName = "ZiyaretciSoyadı";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 2;
            // 
            // gridColumn25
            // 
            this.gridColumn25.FieldName = "ZiyaretciFirm";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 3;
            // 
            // gridColumn26
            // 
            this.gridColumn26.FieldName = "ZiyaretciÜnv";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 4;
            // 
            // gridColumn27
            // 
            this.gridColumn27.FieldName = "ZiyaretciHES";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 5;
            // 
            // gridColumn28
            // 
            this.gridColumn28.FieldName = "Ziyaretciİrsaliye";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 6;
            // 
            // gridColumn29
            // 
            this.gridColumn29.FieldName = "ZiyaretciİrsTeslim";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.Visible = true;
            this.gridColumn29.VisibleIndex = 7;
            // 
            // gridColumn30
            // 
            this.gridColumn30.FieldName = "ZiyaretciİrsTeslimEden";
            this.gridColumn30.Name = "gridColumn30";
            this.gridColumn30.Visible = true;
            this.gridColumn30.VisibleIndex = 8;
            // 
            // gridColumn31
            // 
            this.gridColumn31.FieldName = "ZiyaretciArac";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.Visible = true;
            this.gridColumn31.VisibleIndex = 9;
            // 
            // gridColumn32
            // 
            this.gridColumn32.FieldName = "ZiyaretciKonu";
            this.gridColumn32.Name = "gridColumn32";
            this.gridColumn32.Visible = true;
            this.gridColumn32.VisibleIndex = 10;
            // 
            // gridColumn33
            // 
            this.gridColumn33.FieldName = "ZiyaretciPlanlımı";
            this.gridColumn33.Name = "gridColumn33";
            this.gridColumn33.Visible = true;
            this.gridColumn33.VisibleIndex = 11;
            // 
            // gridColumn34
            // 
            this.gridColumn34.FieldName = "ZiyaretciTarih";
            this.gridColumn34.Name = "gridColumn34";
            this.gridColumn34.Visible = true;
            this.gridColumn34.VisibleIndex = 12;
            // 
            // gridColumn35
            // 
            this.gridColumn35.FieldName = "ZiyaretciBaşlangıç";
            this.gridColumn35.Name = "gridColumn35";
            this.gridColumn35.Visible = true;
            this.gridColumn35.VisibleIndex = 13;
            // 
            // gridColumn36
            // 
            this.gridColumn36.FieldName = "ZiyaretciBitiş";
            this.gridColumn36.Name = "gridColumn36";
            this.gridColumn36.Visible = true;
            this.gridColumn36.VisibleIndex = 14;
            // 
            // gridColumn37
            // 
            this.gridColumn37.FieldName = "ZiyaretEdilenPersKod";
            this.gridColumn37.Name = "gridColumn37";
            this.gridColumn37.Visible = true;
            this.gridColumn37.VisibleIndex = 15;
            // 
            // gridColumn38
            // 
            this.gridColumn38.FieldName = "ZiyaretEdilenAdıSoyadı";
            this.gridColumn38.Name = "gridColumn38";
            this.gridColumn38.Visible = true;
            this.gridColumn38.VisibleIndex = 16;
            // 
            // gridColumn39
            // 
            this.gridColumn39.FieldName = "GirisYapanPers";
            this.gridColumn39.Name = "gridColumn39";
            this.gridColumn39.Visible = true;
            this.gridColumn39.VisibleIndex = 17;
            // 
            // gridColumn40
            // 
            this.gridColumn40.FieldName = "ZiyaretEdilenGirisKapı";
            this.gridColumn40.Name = "gridColumn40";
            this.gridColumn40.Visible = true;
            this.gridColumn40.VisibleIndex = 18;
            // 
            // gridColumn41
            // 
            this.gridColumn41.FieldName = "ZiyaretEdilenTarih";
            this.gridColumn41.Name = "gridColumn41";
            this.gridColumn41.Visible = true;
            this.gridColumn41.VisibleIndex = 19;
            // 
            // gridColumn42
            // 
            this.gridColumn42.FieldName = "ZiyaretEdilenSaat";
            this.gridColumn42.Name = "gridColumn42";
            this.gridColumn42.Visible = true;
            this.gridColumn42.VisibleIndex = 20;
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colZiyaretciAdı,
            this.colZiyaretciSoyadı,
            this.colZiyaretciFirm,
            this.colZiyaretciÜnv,
            this.colZiyaretciHES,
            this.colZiyaretciİrsaliye,
            this.colZiyaretciİrsTeslim,
            this.colZiyaretciİrsTeslimEden,
            this.colZiyaretciArac,
            this.colZiyaretciKonu,
            this.colZiyaretciPlanlımı,
            this.colZiyaretciTarih,
            this.colZiyaretciBaşlangıç,
            this.colZiyaretciBitiş,
            this.colZiyaretEdilenPersKod,
            this.colZiyaretEdilenAdıSoyadı,
            this.colGirisYapanPers,
            this.colZiyaretEdilenGirisKapı,
            this.colZiyaretEdilenTarih,
            this.colZiyaretEdilenSaat});
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colZiyaretciAdı
            // 
            this.colZiyaretciAdı.FieldName = "ZiyaretciAdı";
            this.colZiyaretciAdı.Name = "colZiyaretciAdı";
            this.colZiyaretciAdı.Visible = true;
            this.colZiyaretciAdı.VisibleIndex = 1;
            // 
            // colZiyaretciSoyadı
            // 
            this.colZiyaretciSoyadı.FieldName = "ZiyaretciSoyadı";
            this.colZiyaretciSoyadı.Name = "colZiyaretciSoyadı";
            this.colZiyaretciSoyadı.Visible = true;
            this.colZiyaretciSoyadı.VisibleIndex = 2;
            // 
            // colZiyaretciFirm
            // 
            this.colZiyaretciFirm.FieldName = "ZiyaretciFirm";
            this.colZiyaretciFirm.Name = "colZiyaretciFirm";
            this.colZiyaretciFirm.Visible = true;
            this.colZiyaretciFirm.VisibleIndex = 3;
            // 
            // colZiyaretciÜnv
            // 
            this.colZiyaretciÜnv.FieldName = "ZiyaretciÜnv";
            this.colZiyaretciÜnv.Name = "colZiyaretciÜnv";
            this.colZiyaretciÜnv.Visible = true;
            this.colZiyaretciÜnv.VisibleIndex = 4;
            // 
            // colZiyaretciHES
            // 
            this.colZiyaretciHES.FieldName = "ZiyaretciHES";
            this.colZiyaretciHES.Name = "colZiyaretciHES";
            this.colZiyaretciHES.Visible = true;
            this.colZiyaretciHES.VisibleIndex = 5;
            // 
            // colZiyaretciİrsaliye
            // 
            this.colZiyaretciİrsaliye.FieldName = "Ziyaretciİrsaliye";
            this.colZiyaretciİrsaliye.Name = "colZiyaretciİrsaliye";
            this.colZiyaretciİrsaliye.Visible = true;
            this.colZiyaretciİrsaliye.VisibleIndex = 6;
            // 
            // colZiyaretciİrsTeslim
            // 
            this.colZiyaretciİrsTeslim.FieldName = "ZiyaretciİrsTeslim";
            this.colZiyaretciİrsTeslim.Name = "colZiyaretciİrsTeslim";
            this.colZiyaretciİrsTeslim.Visible = true;
            this.colZiyaretciİrsTeslim.VisibleIndex = 7;
            // 
            // colZiyaretciİrsTeslimEden
            // 
            this.colZiyaretciİrsTeslimEden.FieldName = "ZiyaretciİrsTeslimEden";
            this.colZiyaretciİrsTeslimEden.Name = "colZiyaretciİrsTeslimEden";
            this.colZiyaretciİrsTeslimEden.Visible = true;
            this.colZiyaretciİrsTeslimEden.VisibleIndex = 8;
            // 
            // colZiyaretciArac
            // 
            this.colZiyaretciArac.FieldName = "ZiyaretciArac";
            this.colZiyaretciArac.Name = "colZiyaretciArac";
            this.colZiyaretciArac.Visible = true;
            this.colZiyaretciArac.VisibleIndex = 9;
            // 
            // colZiyaretciKonu
            // 
            this.colZiyaretciKonu.FieldName = "ZiyaretciKonu";
            this.colZiyaretciKonu.Name = "colZiyaretciKonu";
            this.colZiyaretciKonu.Visible = true;
            this.colZiyaretciKonu.VisibleIndex = 10;
            // 
            // colZiyaretciPlanlımı
            // 
            this.colZiyaretciPlanlımı.FieldName = "ZiyaretciPlanlımı";
            this.colZiyaretciPlanlımı.Name = "colZiyaretciPlanlımı";
            this.colZiyaretciPlanlımı.Visible = true;
            this.colZiyaretciPlanlımı.VisibleIndex = 11;
            // 
            // colZiyaretciTarih
            // 
            this.colZiyaretciTarih.FieldName = "ZiyaretciTarih";
            this.colZiyaretciTarih.Name = "colZiyaretciTarih";
            this.colZiyaretciTarih.Visible = true;
            this.colZiyaretciTarih.VisibleIndex = 12;
            // 
            // colZiyaretciBaşlangıç
            // 
            this.colZiyaretciBaşlangıç.FieldName = "ZiyaretciBaşlangıç";
            this.colZiyaretciBaşlangıç.Name = "colZiyaretciBaşlangıç";
            this.colZiyaretciBaşlangıç.Visible = true;
            this.colZiyaretciBaşlangıç.VisibleIndex = 13;
            // 
            // colZiyaretciBitiş
            // 
            this.colZiyaretciBitiş.FieldName = "ZiyaretciBitiş";
            this.colZiyaretciBitiş.Name = "colZiyaretciBitiş";
            this.colZiyaretciBitiş.Visible = true;
            this.colZiyaretciBitiş.VisibleIndex = 14;
            // 
            // colZiyaretEdilenPersKod
            // 
            this.colZiyaretEdilenPersKod.FieldName = "ZiyaretEdilenPersKod";
            this.colZiyaretEdilenPersKod.Name = "colZiyaretEdilenPersKod";
            this.colZiyaretEdilenPersKod.Visible = true;
            this.colZiyaretEdilenPersKod.VisibleIndex = 15;
            // 
            // colZiyaretEdilenAdıSoyadı
            // 
            this.colZiyaretEdilenAdıSoyadı.FieldName = "ZiyaretEdilenAdıSoyadı";
            this.colZiyaretEdilenAdıSoyadı.Name = "colZiyaretEdilenAdıSoyadı";
            this.colZiyaretEdilenAdıSoyadı.Visible = true;
            this.colZiyaretEdilenAdıSoyadı.VisibleIndex = 16;
            // 
            // colGirisYapanPers
            // 
            this.colGirisYapanPers.FieldName = "GirisYapanPers";
            this.colGirisYapanPers.Name = "colGirisYapanPers";
            this.colGirisYapanPers.Visible = true;
            this.colGirisYapanPers.VisibleIndex = 17;
            // 
            // colZiyaretEdilenGirisKapı
            // 
            this.colZiyaretEdilenGirisKapı.FieldName = "ZiyaretEdilenGirisKapı";
            this.colZiyaretEdilenGirisKapı.Name = "colZiyaretEdilenGirisKapı";
            this.colZiyaretEdilenGirisKapı.Visible = true;
            this.colZiyaretEdilenGirisKapı.VisibleIndex = 18;
            // 
            // colZiyaretEdilenTarih
            // 
            this.colZiyaretEdilenTarih.FieldName = "ZiyaretEdilenTarih";
            this.colZiyaretEdilenTarih.Name = "colZiyaretEdilenTarih";
            this.colZiyaretEdilenTarih.Visible = true;
            this.colZiyaretEdilenTarih.VisibleIndex = 19;
            // 
            // colZiyaretEdilenSaat
            // 
            this.colZiyaretEdilenSaat.FieldName = "ZiyaretEdilenSaat";
            this.colZiyaretEdilenSaat.Name = "colZiyaretEdilenSaat";
            this.colZiyaretEdilenSaat.Visible = true;
            this.colZiyaretEdilenSaat.VisibleIndex = 20;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "ZiyaretciAdı";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "ZiyaretciSoyadı";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "ZiyaretciFirm";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "ZiyaretciÜnv";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "ZiyaretciHES";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "Ziyaretciİrsaliye";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "ZiyaretciİrsTeslim";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "ZiyaretciİrsTeslimEden";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "ZiyaretciArac";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "ZiyaretciKonu";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "ZiyaretciPlanlımı";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 11;
            // 
            // gridColumn13
            // 
            this.gridColumn13.FieldName = "ZiyaretciTarih";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 12;
            // 
            // gridColumn14
            // 
            this.gridColumn14.FieldName = "ZiyaretciBaşlangıç";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 13;
            // 
            // gridColumn15
            // 
            this.gridColumn15.FieldName = "ZiyaretciBitiş";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 14;
            // 
            // gridColumn16
            // 
            this.gridColumn16.FieldName = "ZiyaretEdilenPersKod";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 15;
            // 
            // gridColumn17
            // 
            this.gridColumn17.FieldName = "ZiyaretEdilenAdıSoyadı";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 16;
            // 
            // gridColumn18
            // 
            this.gridColumn18.FieldName = "GirisYapanPers";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 17;
            // 
            // gridColumn19
            // 
            this.gridColumn19.FieldName = "ZiyaretEdilenGirisKapı";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 18;
            // 
            // gridColumn20
            // 
            this.gridColumn20.FieldName = "ZiyaretEdilenTarih";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 19;
            // 
            // gridColumn21
            // 
            this.gridColumn21.FieldName = "ZiyaretEdilenSaat";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 20;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumn1,
            this.bandedGridColumn2,
            this.bandedGridColumn3,
            this.bandedGridColumn4,
            this.bandedGridColumn5,
            this.bandedGridColumn6,
            this.bandedGridColumn7,
            this.bandedGridColumn8,
            this.bandedGridColumn9,
            this.bandedGridColumn10,
            this.bandedGridColumn11,
            this.bandedGridColumn12,
            this.bandedGridColumn13,
            this.bandedGridColumn14,
            this.bandedGridColumn15,
            this.bandedGridColumn16,
            this.bandedGridColumn17,
            this.bandedGridColumn18,
            this.bandedGridColumn19,
            this.bandedGridColumn20,
            this.bandedGridColumn21});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.bandedGridColumn1);
            this.gridBand1.Columns.Add(this.bandedGridColumn2);
            this.gridBand1.Columns.Add(this.bandedGridColumn3);
            this.gridBand1.Columns.Add(this.bandedGridColumn4);
            this.gridBand1.Columns.Add(this.bandedGridColumn5);
            this.gridBand1.Columns.Add(this.bandedGridColumn6);
            this.gridBand1.Columns.Add(this.bandedGridColumn7);
            this.gridBand1.Columns.Add(this.bandedGridColumn8);
            this.gridBand1.Columns.Add(this.bandedGridColumn9);
            this.gridBand1.Columns.Add(this.bandedGridColumn10);
            this.gridBand1.Columns.Add(this.bandedGridColumn11);
            this.gridBand1.Columns.Add(this.bandedGridColumn12);
            this.gridBand1.Columns.Add(this.bandedGridColumn13);
            this.gridBand1.Columns.Add(this.bandedGridColumn14);
            this.gridBand1.Columns.Add(this.bandedGridColumn15);
            this.gridBand1.Columns.Add(this.bandedGridColumn16);
            this.gridBand1.Columns.Add(this.bandedGridColumn17);
            this.gridBand1.Columns.Add(this.bandedGridColumn18);
            this.gridBand1.Columns.Add(this.bandedGridColumn19);
            this.gridBand1.Columns.Add(this.bandedGridColumn20);
            this.gridBand1.Columns.Add(this.bandedGridColumn21);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1575;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.FieldName = "ID";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.Visible = true;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.FieldName = "ZiyaretciAdı";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.Visible = true;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.FieldName = "ZiyaretciSoyadı";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.Visible = true;
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.FieldName = "ZiyaretciFirm";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.Visible = true;
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.FieldName = "ZiyaretciÜnv";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.Visible = true;
            // 
            // bandedGridColumn6
            // 
            this.bandedGridColumn6.FieldName = "ZiyaretciHES";
            this.bandedGridColumn6.Name = "bandedGridColumn6";
            this.bandedGridColumn6.Visible = true;
            // 
            // bandedGridColumn7
            // 
            this.bandedGridColumn7.FieldName = "Ziyaretciİrsaliye";
            this.bandedGridColumn7.Name = "bandedGridColumn7";
            this.bandedGridColumn7.Visible = true;
            // 
            // bandedGridColumn8
            // 
            this.bandedGridColumn8.FieldName = "ZiyaretciİrsTeslim";
            this.bandedGridColumn8.Name = "bandedGridColumn8";
            this.bandedGridColumn8.Visible = true;
            // 
            // bandedGridColumn9
            // 
            this.bandedGridColumn9.FieldName = "ZiyaretciİrsTeslimEden";
            this.bandedGridColumn9.Name = "bandedGridColumn9";
            this.bandedGridColumn9.Visible = true;
            // 
            // bandedGridColumn10
            // 
            this.bandedGridColumn10.FieldName = "ZiyaretciArac";
            this.bandedGridColumn10.Name = "bandedGridColumn10";
            this.bandedGridColumn10.Visible = true;
            // 
            // bandedGridColumn11
            // 
            this.bandedGridColumn11.FieldName = "ZiyaretciKonu";
            this.bandedGridColumn11.Name = "bandedGridColumn11";
            this.bandedGridColumn11.Visible = true;
            // 
            // bandedGridColumn12
            // 
            this.bandedGridColumn12.FieldName = "ZiyaretciPlanlımı";
            this.bandedGridColumn12.Name = "bandedGridColumn12";
            this.bandedGridColumn12.Visible = true;
            // 
            // bandedGridColumn13
            // 
            this.bandedGridColumn13.FieldName = "ZiyaretciTarih";
            this.bandedGridColumn13.Name = "bandedGridColumn13";
            this.bandedGridColumn13.Visible = true;
            // 
            // bandedGridColumn14
            // 
            this.bandedGridColumn14.FieldName = "ZiyaretciBaşlangıç";
            this.bandedGridColumn14.Name = "bandedGridColumn14";
            this.bandedGridColumn14.Visible = true;
            // 
            // bandedGridColumn15
            // 
            this.bandedGridColumn15.FieldName = "ZiyaretciBitiş";
            this.bandedGridColumn15.Name = "bandedGridColumn15";
            this.bandedGridColumn15.Visible = true;
            // 
            // bandedGridColumn16
            // 
            this.bandedGridColumn16.FieldName = "ZiyaretEdilenPersKod";
            this.bandedGridColumn16.Name = "bandedGridColumn16";
            this.bandedGridColumn16.Visible = true;
            // 
            // bandedGridColumn17
            // 
            this.bandedGridColumn17.FieldName = "ZiyaretEdilenAdıSoyadı";
            this.bandedGridColumn17.Name = "bandedGridColumn17";
            this.bandedGridColumn17.Visible = true;
            // 
            // bandedGridColumn18
            // 
            this.bandedGridColumn18.FieldName = "GirisYapanPers";
            this.bandedGridColumn18.Name = "bandedGridColumn18";
            this.bandedGridColumn18.Visible = true;
            // 
            // bandedGridColumn19
            // 
            this.bandedGridColumn19.FieldName = "ZiyaretEdilenGirisKapı";
            this.bandedGridColumn19.Name = "bandedGridColumn19";
            this.bandedGridColumn19.Visible = true;
            // 
            // bandedGridColumn20
            // 
            this.bandedGridColumn20.FieldName = "ZiyaretEdilenTarih";
            this.bandedGridColumn20.Name = "bandedGridColumn20";
            this.bandedGridColumn20.Visible = true;
            // 
            // bandedGridColumn21
            // 
            this.bandedGridColumn21.FieldName = "ZiyaretEdilenSaat";
            this.bandedGridColumn21.Name = "bandedGridColumn21";
            this.bandedGridColumn21.Visible = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.txtBaşlama);
            this.panel1.Controls.Add(this.txtBitiş);
            this.panel1.Controls.Add(this.SaatEkle);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtBul);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBul);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.timeEdit3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbPlanlımı);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cmbGiriş);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnKayıt);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtKonu);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtAraçPlaka);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtİrTesEden);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtİrTes);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtİrsal);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtHES);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtÜnv);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.txtÇalFirm);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.txtSoyadı);
            this.panel1.Controls.Add(this.txtPersKod);
            this.panel1.Controls.Add(this.txtAdı);
            this.panel1.Controls.Add(this.txtAdıSoyadı);
            this.panel1.Controls.Add(this.txtZiyPers);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 298);
            this.panel1.TabIndex = 58;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(662, 255);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 27);
            this.btnRefresh.TabIndex = 60;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtBaşlama
            // 
            this.txtBaşlama.Location = new System.Drawing.Point(472, 195);
            this.txtBaşlama.Name = "txtBaşlama";
            this.txtBaşlama.Size = new System.Drawing.Size(100, 20);
            this.txtBaşlama.TabIndex = 59;
            // 
            // txtBitiş
            // 
            this.txtBitiş.Location = new System.Drawing.Point(454, 221);
            this.txtBitiş.Name = "txtBitiş";
            this.txtBitiş.Size = new System.Drawing.Size(100, 20);
            this.txtBitiş.TabIndex = 58;
            // 
            // SaatEkle
            // 
            this.SaatEkle.Location = new System.Drawing.Point(560, 221);
            this.SaatEkle.Name = "SaatEkle";
            this.SaatEkle.Size = new System.Drawing.Size(28, 20);
            this.SaatEkle.TabIndex = 57;
            this.SaatEkle.Text = "+";
            this.SaatEkle.UseVisualStyleBackColor = true;
            this.SaatEkle.Click += new System.EventHandler(this.SaatEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 57;
            this.button1.Text = "ŞUAN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 672);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtPersKod;
        private System.Windows.Forms.TextBox txtAdıSoyadı;
        private System.Windows.Forms.TextBox txtZiyPers;
        private System.Windows.Forms.TextBox txtAdı;
        private System.Windows.Forms.TextBox txtSoyadı;
        private System.Windows.Forms.TextBox txtÇalFirm;
        private System.Windows.Forms.TextBox txtÜnv;
        private System.Windows.Forms.TextBox txtHES;
        private System.Windows.Forms.TextBox txtİrsal;
        private System.Windows.Forms.TextBox txtİrTes;
        private System.Windows.Forms.TextBox txtİrTesEden;
        private System.Windows.Forms.TextBox txtAraçPlaka;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cmbGiriş;
        private System.Windows.Forms.ComboBox cmbPlanlımı;
        private DevExpress.XtraEditors.TimeEdit timeEdit3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnUpdate;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretciAdı;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretciSoyadı;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretciFirm;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretciÜnv;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretciHES;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretciİrsaliye;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretciİrsTeslim;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretciİrsTeslimEden;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretciArac;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretciKonu;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretciPlanlımı;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretciTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretciBaşlangıç;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretciBitiş;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretEdilenPersKod;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretEdilenAdıSoyadı;
        private DevExpress.XtraGrid.Columns.GridColumn colGirisYapanPers;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretEdilenGirisKapı;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretEdilenTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colZiyaretEdilenSaat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn38;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn39;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn40;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn41;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn42;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn8;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn9;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn10;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn11;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn12;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn13;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn14;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn15;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn16;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn17;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn18;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn19;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn20;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn21;
        private System.Windows.Forms.Button SaatEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBaşlama;
        private System.Windows.Forms.TextBox txtBitiş;
        private System.Windows.Forms.Button btnRefresh;
    }
}

