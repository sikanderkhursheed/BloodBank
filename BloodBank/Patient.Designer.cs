namespace BloodBank
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.Links = new System.Windows.Forms.Panel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabPatient = new System.Windows.Forms.TabControl();
            this.pageAdd = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.txtDisease = new System.Windows.Forms.TextBox();
            this.lblDisease = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtGroup = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddreess = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.pageView = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PageUpdate = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.txtPDisease = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnFemale = new System.Windows.Forms.RadioButton();
            this.btnMale = new System.Windows.Forms.RadioButton();
            this.txtBG = new System.Windows.Forms.ComboBox();
            this.txtPAddress = new System.Windows.Forms.TextBox();
            this.txtPContact = new System.Windows.Forms.TextBox();
            this.txtPAge = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pageDelete = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Links.SuspendLayout();
            this.tabPatient.SuspendLayout();
            this.pageAdd.SuspendLayout();
            this.pageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PageUpdate.SuspendLayout();
            this.pageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Links
            // 
            this.Links.Controls.Add(this.linkLabel4);
            this.Links.Controls.Add(this.linkLabel2);
            this.Links.Controls.Add(this.linkLabel3);
            this.Links.Controls.Add(this.linkLabel1);
            this.Links.Location = new System.Drawing.Point(53, 191);
            this.Links.Name = "Links";
            this.Links.Size = new System.Drawing.Size(200, 518);
            this.Links.TabIndex = 1;
            this.Links.Paint += new System.Windows.Forms.PaintEventHandler(this.Links_Paint);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.Location = new System.Drawing.Point(51, 78);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(49, 18);
            this.linkLabel4.TabIndex = 5;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Home";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(50, 144);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(59, 20);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Patient";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(13, 178);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(173, 20);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Who can donate blood ";
            this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(50, 104);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Donor";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tabPatient
            // 
            this.tabPatient.Controls.Add(this.pageAdd);
            this.tabPatient.Controls.Add(this.pageView);
            this.tabPatient.Controls.Add(this.PageUpdate);
            this.tabPatient.Controls.Add(this.pageDelete);
            this.tabPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPatient.Location = new System.Drawing.Point(264, 191);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.SelectedIndex = 0;
            this.tabPatient.Size = new System.Drawing.Size(1025, 518);
            this.tabPatient.TabIndex = 2;
            // 
            // pageAdd
            // 
            this.pageAdd.Controls.Add(this.btnClear);
            this.pageAdd.Controls.Add(this.btnInsert);
            this.pageAdd.Controls.Add(this.datetime);
            this.pageAdd.Controls.Add(this.txtDisease);
            this.pageAdd.Controls.Add(this.lblDisease);
            this.pageAdd.Controls.Add(this.lblDate);
            this.pageAdd.Controls.Add(this.txtPatientId);
            this.pageAdd.Controls.Add(this.rdbFemale);
            this.pageAdd.Controls.Add(this.rdbMale);
            this.pageAdd.Controls.Add(this.txtGroup);
            this.pageAdd.Controls.Add(this.txtAddress);
            this.pageAdd.Controls.Add(this.txtContact);
            this.pageAdd.Controls.Add(this.txtAge);
            this.pageAdd.Controls.Add(this.txtName);
            this.pageAdd.Controls.Add(this.lblAddreess);
            this.pageAdd.Controls.Add(this.lblPhone);
            this.pageAdd.Controls.Add(this.lblGender);
            this.pageAdd.Controls.Add(this.lblBloodGroup);
            this.pageAdd.Controls.Add(this.lblAge);
            this.pageAdd.Controls.Add(this.lblName);
            this.pageAdd.Controls.Add(this.lblPatientID);
            this.pageAdd.Location = new System.Drawing.Point(4, 29);
            this.pageAdd.Name = "pageAdd";
            this.pageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.pageAdd.Size = new System.Drawing.Size(1017, 485);
            this.pageAdd.TabIndex = 0;
            this.pageAdd.Text = "Add";
            this.pageAdd.UseVisualStyleBackColor = true;
            this.pageAdd.Click += new System.EventHandler(this.pageAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(794, 444);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 26);
            this.btnClear.TabIndex = 62;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(732, 444);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(58, 26);
            this.btnInsert.TabIndex = 61;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(179, 340);
            this.datetime.Margin = new System.Windows.Forms.Padding(2);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(257, 26);
            this.datetime.TabIndex = 60;
            // 
            // txtDisease
            // 
            this.txtDisease.Location = new System.Drawing.Point(148, 372);
            this.txtDisease.Margin = new System.Windows.Forms.Padding(2);
            this.txtDisease.Multiline = true;
            this.txtDisease.Name = "txtDisease";
            this.txtDisease.Size = new System.Drawing.Size(468, 97);
            this.txtDisease.TabIndex = 59;
            // 
            // lblDisease
            // 
            this.lblDisease.AutoSize = true;
            this.lblDisease.Location = new System.Drawing.Point(54, 372);
            this.lblDisease.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisease.Name = "lblDisease";
            this.lblDisease.Size = new System.Drawing.Size(67, 20);
            this.lblDisease.TabIndex = 58;
            this.lblDisease.Text = "Disease";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(48, 340);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(127, 20);
            this.lblDate.TabIndex = 57;
            this.lblDate.Text = "Requested Date";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(148, 45);
            this.txtPatientId.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(139, 26);
            this.txtPatientId.TabIndex = 56;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(215, 180);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(80, 24);
            this.rdbFemale.TabIndex = 55;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(148, 180);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(61, 24);
            this.rdbMale.TabIndex = 54;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtGroup
            // 
            this.txtGroup.FormattingEnabled = true;
            this.txtGroup.Items.AddRange(new object[] {
            "A+ve",
            "A-ve",
            "B+ve",
            "B-ve",
            "O+ve",
            "O-ve",
            "AB+ve",
            "AB-vee"});
            this.txtGroup.Location = new System.Drawing.Point(148, 143);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(139, 28);
            this.txtGroup.TabIndex = 53;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(148, 245);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(468, 81);
            this.txtAddress.TabIndex = 52;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(148, 207);
            this.txtContact.Margin = new System.Windows.Forms.Padding(5);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(257, 26);
            this.txtContact.TabIndex = 51;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(148, 110);
            this.txtAge.Margin = new System.Windows.Forms.Padding(5);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(139, 26);
            this.txtAge.TabIndex = 50;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 77);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 26);
            this.txtName.TabIndex = 49;
            // 
            // lblAddreess
            // 
            this.lblAddreess.AutoSize = true;
            this.lblAddreess.Location = new System.Drawing.Point(55, 245);
            this.lblAddreess.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddreess.Name = "lblAddreess";
            this.lblAddreess.Size = new System.Drawing.Size(68, 20);
            this.lblAddreess.TabIndex = 48;
            this.lblAddreess.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(51, 207);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(89, 20);
            this.lblPhone.TabIndex = 47;
            this.lblPhone.Text = "Contact No";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(52, 184);
            this.lblGender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 46;
            this.lblGender.Text = "Gender";
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Location = new System.Drawing.Point(52, 143);
            this.lblBloodGroup.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(99, 20);
            this.lblBloodGroup.TabIndex = 45;
            this.lblBloodGroup.Text = "Blood Group";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(54, 110);
            this.lblAge.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 44;
            this.lblAge.Text = "Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(54, 82);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 20);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "Full Name";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(54, 47);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(80, 20);
            this.lblPatientID.TabIndex = 42;
            this.lblPatientID.Text = "Patient ID";
            // 
            // pageView
            // 
            this.pageView.Controls.Add(this.label1);
            this.pageView.Controls.Add(this.dataGridView1);
            this.pageView.Location = new System.Drawing.Point(4, 29);
            this.pageView.Name = "pageView";
            this.pageView.Padding = new System.Windows.Forms.Padding(3);
            this.pageView.Size = new System.Drawing.Size(1017, 485);
            this.pageView.TabIndex = 1;
            this.pageView.Text = "View";
            this.pageView.UseVisualStyleBackColor = true;
            this.pageView.Click += new System.EventHandler(this.pageView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Patient Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(34, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(947, 403);
            this.dataGridView1.TabIndex = 5;
            // 
            // PageUpdate
            // 
            this.PageUpdate.Controls.Add(this.button1);
            this.PageUpdate.Controls.Add(this.bttnUpdate);
            this.PageUpdate.Controls.Add(this.date);
            this.PageUpdate.Controls.Add(this.txtPDisease);
            this.PageUpdate.Controls.Add(this.label2);
            this.PageUpdate.Controls.Add(this.label3);
            this.PageUpdate.Controls.Add(this.txtId);
            this.PageUpdate.Controls.Add(this.btnFemale);
            this.PageUpdate.Controls.Add(this.btnMale);
            this.PageUpdate.Controls.Add(this.txtBG);
            this.PageUpdate.Controls.Add(this.txtPAddress);
            this.PageUpdate.Controls.Add(this.txtPContact);
            this.PageUpdate.Controls.Add(this.txtPAge);
            this.PageUpdate.Controls.Add(this.txtPName);
            this.PageUpdate.Controls.Add(this.label4);
            this.PageUpdate.Controls.Add(this.label5);
            this.PageUpdate.Controls.Add(this.label6);
            this.PageUpdate.Controls.Add(this.label7);
            this.PageUpdate.Controls.Add(this.label8);
            this.PageUpdate.Controls.Add(this.label9);
            this.PageUpdate.Controls.Add(this.label10);
            this.PageUpdate.Location = new System.Drawing.Point(4, 29);
            this.PageUpdate.Name = "PageUpdate";
            this.PageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.PageUpdate.Size = new System.Drawing.Size(1017, 485);
            this.PageUpdate.TabIndex = 2;
            this.PageUpdate.Text = "Update";
            this.PageUpdate.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 81;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Location = new System.Drawing.Point(755, 424);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(75, 34);
            this.bttnUpdate.TabIndex = 80;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(178, 336);
            this.date.Margin = new System.Windows.Forms.Padding(2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(276, 26);
            this.date.TabIndex = 79;
            // 
            // txtPDisease
            // 
            this.txtPDisease.Location = new System.Drawing.Point(147, 368);
            this.txtPDisease.Margin = new System.Windows.Forms.Padding(2);
            this.txtPDisease.Multiline = true;
            this.txtPDisease.Name = "txtPDisease";
            this.txtPDisease.Size = new System.Drawing.Size(468, 81);
            this.txtPDisease.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 368);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Disease";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Requested Date";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(147, 35);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(156, 26);
            this.txtId.TabIndex = 75;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnFemale
            // 
            this.btnFemale.AutoSize = true;
            this.btnFemale.Location = new System.Drawing.Point(223, 176);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(80, 24);
            this.btnFemale.TabIndex = 74;
            this.btnFemale.TabStop = true;
            this.btnFemale.Text = "Female";
            this.btnFemale.UseVisualStyleBackColor = true;
            // 
            // btnMale
            // 
            this.btnMale.AutoSize = true;
            this.btnMale.Location = new System.Drawing.Point(147, 177);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(61, 24);
            this.btnMale.TabIndex = 73;
            this.btnMale.TabStop = true;
            this.btnMale.Text = "Male";
            this.btnMale.UseVisualStyleBackColor = true;
            // 
            // txtBG
            // 
            this.txtBG.FormattingEnabled = true;
            this.txtBG.Items.AddRange(new object[] {
            "A+ve",
            "A-ve",
            "B+ve",
            "B-ve",
            "O+ve",
            "O-ve",
            "AB+ve",
            "AB-vee"});
            this.txtBG.Location = new System.Drawing.Point(147, 139);
            this.txtBG.Name = "txtBG";
            this.txtBG.Size = new System.Drawing.Size(156, 28);
            this.txtBG.TabIndex = 72;
            // 
            // txtPAddress
            // 
            this.txtPAddress.Location = new System.Drawing.Point(147, 241);
            this.txtPAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtPAddress.Multiline = true;
            this.txtPAddress.Name = "txtPAddress";
            this.txtPAddress.Size = new System.Drawing.Size(468, 81);
            this.txtPAddress.TabIndex = 71;
            // 
            // txtPContact
            // 
            this.txtPContact.Location = new System.Drawing.Point(149, 203);
            this.txtPContact.Margin = new System.Windows.Forms.Padding(5);
            this.txtPContact.Name = "txtPContact";
            this.txtPContact.Size = new System.Drawing.Size(305, 26);
            this.txtPContact.TabIndex = 70;
            // 
            // txtPAge
            // 
            this.txtPAge.Location = new System.Drawing.Point(147, 106);
            this.txtPAge.Margin = new System.Windows.Forms.Padding(5);
            this.txtPAge.Name = "txtPAge";
            this.txtPAge.Size = new System.Drawing.Size(156, 26);
            this.txtPAge.TabIndex = 69;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(147, 73);
            this.txtPName.Margin = new System.Windows.Forms.Padding(5);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(307, 26);
            this.txtPName.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Contact No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "Blood Group";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "Full Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 61;
            this.label10.Text = "Patient ID";
            // 
            // pageDelete
            // 
            this.pageDelete.Controls.Add(this.btnDelete);
            this.pageDelete.Controls.Add(this.dataGridView2);
            this.pageDelete.Controls.Add(this.txtDelete);
            this.pageDelete.Controls.Add(this.lblDelete);
            this.pageDelete.Location = new System.Drawing.Point(4, 29);
            this.pageDelete.Name = "pageDelete";
            this.pageDelete.Padding = new System.Windows.Forms.Padding(3);
            this.pageDelete.Size = new System.Drawing.Size(1017, 485);
            this.pageDelete.TabIndex = 3;
            this.pageDelete.Text = "Delete";
            this.pageDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(210, 19);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 27);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(34, 62);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(947, 403);
            this.dataGridView2.TabIndex = 12;
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(59, 19);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(116, 26);
            this.txtDelete.TabIndex = 11;
            this.txtDelete.TextChanged += new System.EventHandler(this.txtDelete_TextChanged_1);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(26, 19);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(26, 20);
            this.lblDelete.TabIndex = 10;
            this.lblDelete.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(569, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 26);
            this.label11.TabIndex = 3;
            this.label11.Text = "Patient Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 166);
            this.panel2.TabIndex = 6;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 721);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabPatient);
            this.Controls.Add(this.Links);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.Links.ResumeLayout(false);
            this.Links.PerformLayout();
            this.tabPatient.ResumeLayout(false);
            this.pageAdd.ResumeLayout(false);
            this.pageAdd.PerformLayout();
            this.pageView.ResumeLayout(false);
            this.pageView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PageUpdate.ResumeLayout(false);
            this.PageUpdate.PerformLayout();
            this.pageDelete.ResumeLayout(false);
            this.pageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Links;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabControl tabPatient;
        private System.Windows.Forms.TabPage pageAdd;
        private System.Windows.Forms.TabPage pageView;
        private System.Windows.Forms.TabPage PageUpdate;
        private System.Windows.Forms.TabPage pageDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.TextBox txtDisease;
        private System.Windows.Forms.Label lblDisease;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.ComboBox txtGroup;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddreess;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox txtPDisease;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.RadioButton btnFemale;
        private System.Windows.Forms.RadioButton btnMale;
        private System.Windows.Forms.ComboBox txtBG;
        private System.Windows.Forms.TextBox txtPAddress;
        private System.Windows.Forms.TextBox txtPContact;
        private System.Windows.Forms.TextBox txtPAge;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
    }
}