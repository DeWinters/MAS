namespace TransitLog
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
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.tbx_invoice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_client = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_origin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_destination = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_delivery = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.tbx_discount = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.dtp_collection = new System.Windows.Forms.DateTimePicker();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btn_preview = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_driver = new System.Windows.Forms.ComboBox();
            this.xbx_weekend = new System.Windows.Forms.CheckBox();
            this.cbx_wait = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_region = new System.Windows.Forms.ComboBox();
            this.lbl_outClient = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_invoiceOut = new System.Windows.Forms.Label();
            this.lbl_outWeekend = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lbl_outDiscount = new System.Windows.Forms.Label();
            this.lbl_outWait = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_outDelivery = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl_outCollection = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_outDestination = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_outOrigin = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_outRegion = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_outDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_outDriver = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbl_voyagerOut = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(3, 94);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(198, 26);
            this.dtp_date.TabIndex = 0;
            // 
            // tbx_invoice
            // 
            this.tbx_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_invoice.Location = new System.Drawing.Point(3, 31);
            this.tbx_invoice.Name = "tbx_invoice";
            this.tbx_invoice.Size = new System.Drawing.Size(82, 26);
            this.tbx_invoice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Invoice #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // cbx_client
            // 
            this.cbx_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_client.FormattingEnabled = true;
            this.cbx_client.Items.AddRange(new object[] {
            "CSO Stg",
            "HUS",
            "Adassa",
            "PUI - GCSM",
            "Diac",
            "EFS",
            "Interne",
            "Néant"});
            this.cbx_client.Location = new System.Drawing.Point(95, 31);
            this.cbx_client.Name = "cbx_client";
            this.cbx_client.Size = new System.Drawing.Size(138, 28);
            this.cbx_client.TabIndex = 4;
            this.cbx_client.Text = "CSO Stg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Client";
            // 
            // cbx_origin
            // 
            this.cbx_origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_origin.FormattingEnabled = true;
            this.cbx_origin.Items.AddRange(new object[] {
            "Aéroport de Strasbourg",
            "CCOM",
            "Centre Paul Schtrauss",
            "CH de Haguenau",
            "CH de Sarrebourg",
            "CH de Wissembourg",
            "CH d\'Erstein",
            "CH Pasteur de Colmar",
            "CH Sainte Catherine de Saverne",
            "CHD Bischwiller",
            "CHRU Hautepierre",
            "Clinique Adassa",
            "Clinique de la Toussaint",
            "Clinique de l\'Orangerie",
            "Clinique des Diaconnesses",
            "Clinique Saint Luc",
            "Clinique Sainte Anne",
            "Clinique Sainte Barbe",
            "Clinique Sainte Odile de Haguenau",
            "Clinique Sainte Odile de Strasbourg",
            "CMCO",
            "EFS de Colmar",
            "EFS de Mulhouse",
            "EFS Hautepierre Strasbourg",
            "EFS Spielmann Strasbourg",
            "EPSAN",
            "Hopital Civil de Colmar",
            "Hopital de la Robertsau",
            "Hopital de l\'Elsau",
            "Hopital du Neuhof",
            "Hopitaux Universitaires de Strasbourg",
            "Maison d\'Arrêt de Strasbourg",
            "NHC",
            "Pôle Logistique HUS",
            "PTB",
            "PTM",
            "Domicile"});
            this.cbx_origin.Location = new System.Drawing.Point(3, 168);
            this.cbx_origin.Name = "cbx_origin";
            this.cbx_origin.Size = new System.Drawing.Size(221, 28);
            this.cbx_origin.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Origin";
            // 
            // cbx_destination
            // 
            this.cbx_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_destination.FormattingEnabled = true;
            this.cbx_destination.Items.AddRange(new object[] {
            "Aéroport de Strasbourg",
            "CCOM",
            "Centre Paul Schtrauss",
            "CH de Haguenau",
            "CH de Sarrebourg",
            "CH de Wissembourg",
            "CH d\'Erstein",
            "CH Pasteur de Colmar",
            "CH Sainte Catherine de Saverne",
            "CHD Bischwiller",
            "CHRU Hautepierre",
            "Clinique Adassa",
            "Clinique de la Toussaint",
            "Clinique de l\'Orangerie",
            "Clinique des Diaconnesses",
            "Clinique Saint Luc",
            "Clinique Sainte Anne",
            "Clinique Sainte Barbe",
            "Clinique Sainte Odile de Haguenau",
            "Clinique Sainte Odile de Strasbourg",
            "CMCO",
            "EFS de Colmar",
            "EFS de Mulhouse",
            "EFS Hautepierre Strasbourg",
            "EFS Spielmann Strasbourg",
            "EPSAN",
            "Hopital Civil de Colmar",
            "Hopital de la Robertsau",
            "Hopital de l\'Elsau",
            "Hopital du Neuhof",
            "Hopitaux Universitaires de Strasbourg",
            "Maison d\'Arrêt de Strasbourg",
            "NHC",
            "Pôle Logistique HUS",
            "PTB",
            "PTM",
            "Domicile"});
            this.cbx_destination.Location = new System.Drawing.Point(230, 168);
            this.cbx_destination.Name = "cbx_destination";
            this.cbx_destination.Size = new System.Drawing.Size(238, 28);
            this.cbx_destination.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destination";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Collection Time";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_delivery);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.tbx_discount);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.dtp_collection);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.btn_preview);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbx_driver);
            this.panel1.Controls.Add(this.xbx_weekend);
            this.panel1.Controls.Add(this.cbx_wait);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbx_region);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbx_invoice);
            this.panel1.Controls.Add(this.cbx_client);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbx_destination);
            this.panel1.Controls.Add(this.dtp_date);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbx_origin);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 447);
            this.panel1.TabIndex = 12;
            // 
            // dtp_delivery
            // 
            this.dtp_delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_delivery.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_delivery.Location = new System.Drawing.Point(133, 245);
            this.dtp_delivery.Name = "dtp_delivery";
            this.dtp_delivery.ShowUpDown = true;
            this.dtp_delivery.Size = new System.Drawing.Size(83, 26);
            this.dtp_delivery.TabIndex = 39;
            this.dtp_delivery.Value = new System.DateTime(2016, 11, 16, 23, 59, 0, 0);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(369, 225);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "Remise (en euro)";
            // 
            // tbx_discount
            // 
            this.tbx_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_discount.Location = new System.Drawing.Point(372, 245);
            this.tbx_discount.Name = "tbx_discount";
            this.tbx_discount.Size = new System.Drawing.Size(82, 26);
            this.tbx_discount.TabIndex = 36;
            this.tbx_discount.Text = "0.00";
            this.tbx_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(9, 382);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(79, 24);
            this.checkBox4.TabIndex = 35;
            this.checkBox4.Text = "Interne";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // dtp_collection
            // 
            this.dtp_collection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_collection.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_collection.Location = new System.Drawing.Point(14, 245);
            this.dtp_collection.Name = "dtp_collection";
            this.dtp_collection.ShowUpDown = true;
            this.dtp_collection.Size = new System.Drawing.Size(83, 26);
            this.dtp_collection.TabIndex = 38;
            this.dtp_collection.Value = new System.DateTime(2016, 11, 16, 23, 59, 0, 0);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(9, 352);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(138, 24);
            this.checkBox3.TabIndex = 34;
            this.checkBox3.Text = "Prise en charge";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(9, 322);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 24);
            this.checkBox2.TabIndex = 33;
            this.checkBox2.Text = "Personne";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btn_preview
            // 
            this.btn_preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.Location = new System.Drawing.Point(381, 408);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 29);
            this.btn_preview.TabIndex = 32;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(257, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Chauffeur";
            // 
            // cbx_driver
            // 
            this.cbx_driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_driver.FormattingEnabled = true;
            this.cbx_driver.Items.AddRange(new object[] {
            "ALBISSER Pierre-Jean",
            "FEHR Romain",
            "FROEHLICHER Brandon",
            "MEGE Charley",
            "MERCIER Marine"});
            this.cbx_driver.Location = new System.Drawing.Point(256, 31);
            this.cbx_driver.Name = "cbx_driver";
            this.cbx_driver.Size = new System.Drawing.Size(138, 28);
            this.cbx_driver.TabIndex = 30;
            this.cbx_driver.Text = "MEGE Charley";
            // 
            // xbx_weekend
            // 
            this.xbx_weekend.AutoSize = true;
            this.xbx_weekend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xbx_weekend.Location = new System.Drawing.Point(9, 292);
            this.xbx_weekend.Name = "xbx_weekend";
            this.xbx_weekend.Size = new System.Drawing.Size(108, 24);
            this.xbx_weekend.TabIndex = 29;
            this.xbx_weekend.Text = "Nuit/WE/JF";
            this.xbx_weekend.UseVisualStyleBackColor = true;
            // 
            // cbx_wait
            // 
            this.cbx_wait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_wait.FormattingEnabled = true;
            this.cbx_wait.Items.AddRange(new object[] {
            "none",
            "15min",
            "30min",
            "45min",
            "1hr",
            "1hr 15min",
            "1hr 30min",
            "1hr 45min",
            "2hr",
            "2hr 15min",
            "2hr 30min",
            "2hr 45min",
            "3hr"});
            this.cbx_wait.Location = new System.Drawing.Point(243, 245);
            this.cbx_wait.Name = "cbx_wait";
            this.cbx_wait.Size = new System.Drawing.Size(107, 28);
            this.cbx_wait.TabIndex = 27;
            this.cbx_wait.Text = "none";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(246, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Waiting Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(130, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Delivery Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(223, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Region";
            // 
            // cbx_region
            // 
            this.cbx_region.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_region.FormattingEnabled = true;
            this.cbx_region.Items.AddRange(new object[] {
            "(01) Ain",
            "(02) Aisne",
            "(03) Allier",
            "(04) Alpes de Haute Provence",
            "(05) Hautes Alpes",
            "(06) Alpes Maritimes",
            "(07) Ardèche",
            "(08) Ardennes",
            "(09) Ariège",
            "(10) Aube",
            "(11) Aude",
            "(12) Aveyron",
            "(13) Bouches du Rhône",
            "(14) Calvados\t",
            "(15) Cantal",
            "(16) Charente",
            "(17) Charente Maritime",
            "(18) Cher",
            "(19) Corrèze",
            "(2a) Corse du Sud",
            "(21) Cote d\'Or",
            "(22) Cotes d\'Armor",
            "(23) Creuse",
            "(24) Dordogne",
            "(25) Doubs",
            "(26) Drôme",
            "(27) Eure",
            "(28) Eure et Loir",
            "(29) Finistère",
            "(30) Gard",
            "(31) Haute Garonne",
            "(32) Gers",
            "(33) Gironde",
            "(34) Hérault",
            "(35) Ille et Vilaine",
            "(36) Indre",
            "(37) Indre et Loire",
            "(38) Isère",
            "(39) Jura",
            "(40) Landes",
            "(41) Loir et Cher",
            "(42) Loire",
            "(43) Haute Loire",
            "(44) Loire Atlantique",
            "(45) Loiret",
            "(46) Lot",
            "(47) Lot et Garonne",
            "(48) Lozère",
            "(49) Maine et Loire",
            "(50) Manche",
            "(51) Marne",
            "(52) Haute Marne",
            "(53) Mayenne",
            "(54) Meurthe et Moselle",
            "(55) Meuse",
            "(56) Morbihan",
            "(57) Moselle",
            "(58) Nièvre",
            "(59) Nord",
            "(60) Oise",
            "(61) Orne",
            "(65) Hautes Pyrénées",
            "(66) Pyrénées Orientales",
            "(67) Bas Rhin",
            "(68) Haut Rhin",
            "(69) Rhône",
            "(69M) Métropole de Lyon",
            "(70) Haute Saône",
            "(71) Saône et Loire",
            "(72) Sarthe",
            "(73) Savoie",
            "(74) Haute Savoie",
            "(75) Paris",
            "(76) Seine Maritime",
            "(77) Seine et Marne",
            "(78) Yvelines",
            "(79) Deux Sèvres",
            "(80) Somme",
            "(81) Tarn",
            "(82) Tarn et Garonne",
            "(83) Var",
            "(84) Vaucluse",
            "(85) Vendée",
            "(86) Vienne",
            "(87) Haute Vienne",
            "(88) Vosges",
            "(89) Yonne",
            "(90) Territoire de Belfort",
            "(91) Essonne",
            "(92) Hauts de Seine",
            "(93) Seine Saint Denis",
            "(94) Val de Marne",
            "(95) Val d\'Oise",
            "(2b) Haute Corse"});
            this.cbx_region.Location = new System.Drawing.Point(226, 94);
            this.cbx_region.Name = "cbx_region";
            this.cbx_region.Size = new System.Drawing.Size(230, 28);
            this.cbx_region.TabIndex = 12;
            this.cbx_region.Text = "(67) Bas Rhin";
            // 
            // lbl_outClient
            // 
            this.lbl_outClient.AutoSize = true;
            this.lbl_outClient.Location = new System.Drawing.Point(86, 36);
            this.lbl_outClient.Name = "lbl_outClient";
            this.lbl_outClient.Size = new System.Drawing.Size(54, 13);
            this.lbl_outClient.TabIndex = 13;
            this.lbl_outClient.Text = "pending...";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_voyagerOut);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.lbl_invoiceOut);
            this.panel2.Controls.Add(this.lbl_outWeekend);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.lbl_outDiscount);
            this.panel2.Controls.Add(this.lbl_outWait);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbl_outDelivery);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.lbl_outCollection);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.lbl_outDestination);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.lbl_outOrigin);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.lbl_outRegion);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.lbl_outDate);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lbl_outDriver);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lbl_outClient);
            this.panel2.Location = new System.Drawing.Point(496, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 447);
            this.panel2.TabIndex = 13;
            // 
            // lbl_invoiceOut
            // 
            this.lbl_invoiceOut.AutoSize = true;
            this.lbl_invoiceOut.Location = new System.Drawing.Point(86, 17);
            this.lbl_invoiceOut.Name = "lbl_invoiceOut";
            this.lbl_invoiceOut.Size = new System.Drawing.Size(54, 13);
            this.lbl_invoiceOut.TabIndex = 51;
            this.lbl_invoiceOut.Text = "pending...";
            // 
            // lbl_outWeekend
            // 
            this.lbl_outWeekend.AutoSize = true;
            this.lbl_outWeekend.Location = new System.Drawing.Point(90, 287);
            this.lbl_outWeekend.Name = "lbl_outWeekend";
            this.lbl_outWeekend.Size = new System.Drawing.Size(54, 13);
            this.lbl_outWeekend.TabIndex = 50;
            this.lbl_outWeekend.Text = "pending...";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(11, 287);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 16);
            this.label23.TabIndex = 49;
            this.label23.Text = "Weekend:";
            // 
            // lbl_outDiscount
            // 
            this.lbl_outDiscount.AutoSize = true;
            this.lbl_outDiscount.Location = new System.Drawing.Point(94, 265);
            this.lbl_outDiscount.Name = "lbl_outDiscount";
            this.lbl_outDiscount.Size = new System.Drawing.Size(54, 13);
            this.lbl_outDiscount.TabIndex = 48;
            this.lbl_outDiscount.Text = "pending...";
            // 
            // lbl_outWait
            // 
            this.lbl_outWait.AutoSize = true;
            this.lbl_outWait.Location = new System.Drawing.Point(94, 238);
            this.lbl_outWait.Name = "lbl_outWait";
            this.lbl_outWait.Size = new System.Drawing.Size(54, 13);
            this.lbl_outWait.TabIndex = 47;
            this.lbl_outWait.Text = "pending...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "discount :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Waiting :";
            // 
            // lbl_outDelivery
            // 
            this.lbl_outDelivery.AutoSize = true;
            this.lbl_outDelivery.Location = new System.Drawing.Point(91, 213);
            this.lbl_outDelivery.Name = "lbl_outDelivery";
            this.lbl_outDelivery.Size = new System.Drawing.Size(54, 13);
            this.lbl_outDelivery.TabIndex = 44;
            this.lbl_outDelivery.Text = "pending...";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(15, 211);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 16);
            this.label22.TabIndex = 43;
            this.label22.Text = "Delivery :";
            // 
            // lbl_outCollection
            // 
            this.lbl_outCollection.AutoSize = true;
            this.lbl_outCollection.Location = new System.Drawing.Point(90, 189);
            this.lbl_outCollection.Name = "lbl_outCollection";
            this.lbl_outCollection.Size = new System.Drawing.Size(54, 13);
            this.lbl_outCollection.TabIndex = 42;
            this.lbl_outCollection.Text = "pending...";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(7, 189);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 16);
            this.label21.TabIndex = 41;
            this.label21.Text = "Collection :";
            // 
            // lbl_outDestination
            // 
            this.lbl_outDestination.AutoSize = true;
            this.lbl_outDestination.Location = new System.Drawing.Point(89, 165);
            this.lbl_outDestination.Name = "lbl_outDestination";
            this.lbl_outDestination.Size = new System.Drawing.Size(54, 13);
            this.lbl_outDestination.TabIndex = 40;
            this.lbl_outDestination.Text = "pending...";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 16);
            this.label19.TabIndex = 33;
            this.label19.Text = "Destination";
            // 
            // lbl_outOrigin
            // 
            this.lbl_outOrigin.AutoSize = true;
            this.lbl_outOrigin.Location = new System.Drawing.Point(89, 138);
            this.lbl_outOrigin.Name = "lbl_outOrigin";
            this.lbl_outOrigin.Size = new System.Drawing.Size(54, 13);
            this.lbl_outOrigin.TabIndex = 39;
            this.lbl_outOrigin.Text = "pending...";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(32, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 16);
            this.label18.TabIndex = 33;
            this.label18.Text = "Origin";
            // 
            // lbl_outRegion
            // 
            this.lbl_outRegion.AutoSize = true;
            this.lbl_outRegion.Location = new System.Drawing.Point(89, 110);
            this.lbl_outRegion.Name = "lbl_outRegion";
            this.lbl_outRegion.Size = new System.Drawing.Size(54, 13);
            this.lbl_outRegion.TabIndex = 38;
            this.lbl_outRegion.Text = "pending...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(23, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 16);
            this.label17.TabIndex = 37;
            this.label17.Text = "Region";
            // 
            // lbl_outDate
            // 
            this.lbl_outDate.AutoSize = true;
            this.lbl_outDate.Location = new System.Drawing.Point(88, 83);
            this.lbl_outDate.Name = "lbl_outDate";
            this.lbl_outDate.Size = new System.Drawing.Size(54, 13);
            this.lbl_outDate.TabIndex = 36;
            this.lbl_outDate.Text = "pending...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "Date";
            // 
            // lbl_outDriver
            // 
            this.lbl_outDriver.AutoSize = true;
            this.lbl_outDriver.Location = new System.Drawing.Point(88, 60);
            this.lbl_outDriver.Name = "lbl_outDriver";
            this.lbl_outDriver.Size = new System.Drawing.Size(54, 13);
            this.lbl_outDriver.TabIndex = 34;
            this.lbl_outDriver.Text = "pending...";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 33;
            this.label16.Text = "Chauffeur";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 16);
            this.label15.TabIndex = 33;
            this.label15.Text = "Invoice #";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Client";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(9, 312);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 16);
            this.label24.TabIndex = 52;
            this.label24.Text = "Voyage:";
            // 
            // lbl_voyagerOut
            // 
            this.lbl_voyagerOut.AutoSize = true;
            this.lbl_voyagerOut.Location = new System.Drawing.Point(86, 314);
            this.lbl_voyagerOut.Name = "lbl_voyagerOut";
            this.lbl_voyagerOut.Size = new System.Drawing.Size(54, 13);
            this.lbl_voyagerOut.TabIndex = 53;
            this.lbl_voyagerOut.Text = "pending...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.TextBox tbx_invoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_origin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_destination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbx_region;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_wait;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox xbx_weekend;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbx_driver;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Label lbl_outClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_outDriver;
        private System.Windows.Forms.Label lbl_outDestination;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_outOrigin;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_outRegion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_outDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbx_discount;
        private System.Windows.Forms.DateTimePicker dtp_collection;
        private System.Windows.Forms.Label lbl_outCollection;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl_outDelivery;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dtp_delivery;
        private System.Windows.Forms.Label lbl_outDiscount;
        private System.Windows.Forms.Label lbl_outWait;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_outWeekend;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbl_invoiceOut;
        private System.Windows.Forms.Label lbl_voyagerOut;
        private System.Windows.Forms.Label label24;
    }
}

