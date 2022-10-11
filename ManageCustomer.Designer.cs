
namespace ABC_Car_Traders
{
    partial class ManageCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomer));
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comsearchType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnbackup = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnsales = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnparts = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(988, 128);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(162, 32);
            this.txtsearch.TabIndex = 118;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(682, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 36);
            this.btnSearch.TabIndex = 116;
            this.btnSearch.Text = "SEARCH ";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // customerGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customerGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customerGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.customerGridView.Location = new System.Drawing.Point(0, 0);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.RowHeadersWidth = 51;
            this.customerGridView.RowTemplate.Height = 24;
            this.customerGridView.Size = new System.Drawing.Size(928, 566);
            this.customerGridView.TabIndex = 115;
            this.customerGridView.SelectionChanged += new System.EventHandler(this.customerGridView_SelectionChanged);
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerid.Location = new System.Drawing.Point(159, 153);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(146, 23);
            this.txtcustomerid.TabIndex = 119;
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(159, 265);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(146, 23);
            this.txtlname.TabIndex = 120;
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(159, 321);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(146, 23);
            this.txtphone.TabIndex = 121;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(159, 433);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(146, 23);
            this.txtaddress.TabIndex = 122;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(159, 377);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(146, 23);
            this.txtemail.TabIndex = 123;
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(159, 209);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(146, 23);
            this.txtfname.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 125;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 126;
            this.label2.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 127;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 128;
            this.label5.Text = "Phone No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 129;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 130;
            this.label7.Text = "Address";
            // 
            // comsearchType
            // 
            this.comsearchType.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comsearchType.FormattingEnabled = true;
            this.comsearchType.Items.AddRange(new object[] {
            "FirstName",
            "LastName",
            "Email"});
            this.comsearchType.Location = new System.Drawing.Point(820, 129);
            this.comsearchType.Name = "comsearchType";
            this.comsearchType.Size = new System.Drawing.Size(162, 31);
            this.comsearchType.TabIndex = 117;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1537, 65);
            this.panel1.TabIndex = 133;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(626, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 44);
            this.label3.TabIndex = 9;
            this.label3.Text = "MANAGE CUSTOMER";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1307, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "   LOG OUT";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.btnbackup);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.btnreport);
            this.panel2.Controls.Add(this.btnsales);
            this.panel2.Controls.Add(this.btnorder);
            this.panel2.Controls.Add(this.btncustomer);
            this.panel2.Controls.Add(this.btnparts);
            this.panel2.Controls.Add(this.btnCar);
            this.panel2.Controls.Add(this.btnDashBoard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 719);
            this.panel2.TabIndex = 134;
            // 
            // btnbackup
            // 
            this.btnbackup.BackColor = System.Drawing.Color.Transparent;
            this.btnbackup.FlatAppearance.BorderSize = 0;
            this.btnbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbackup.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackup.ForeColor = System.Drawing.Color.White;
            this.btnbackup.Image = ((System.Drawing.Image)(resources.GetObject("btnbackup.Image")));
            this.btnbackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbackup.Location = new System.Drawing.Point(0, 506);
            this.btnbackup.Margin = new System.Windows.Forms.Padding(4);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(219, 43);
            this.btnbackup.TabIndex = 69;
            this.btnbackup.Text = "   Backup";
            this.btnbackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbackup.UseVisualStyleBackColor = false;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(-4, 455);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(219, 43);
            this.button9.TabIndex = 65;
            this.button9.Text = "   Service";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.Transparent;
            this.btnreport.FlatAppearance.BorderSize = 0;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.White;
            this.btnreport.Image = ((System.Drawing.Image)(resources.GetObject("btnreport.Image")));
            this.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.Location = new System.Drawing.Point(-4, 398);
            this.btnreport.Margin = new System.Windows.Forms.Padding(4);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(219, 48);
            this.btnreport.TabIndex = 68;
            this.btnreport.Text = "   Report";
            this.btnreport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnsales
            // 
            this.btnsales.BackColor = System.Drawing.Color.Transparent;
            this.btnsales.FlatAppearance.BorderSize = 0;
            this.btnsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsales.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsales.ForeColor = System.Drawing.Color.White;
            this.btnsales.Image = ((System.Drawing.Image)(resources.GetObject("btnsales.Image")));
            this.btnsales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsales.Location = new System.Drawing.Point(-4, 341);
            this.btnsales.Margin = new System.Windows.Forms.Padding(4);
            this.btnsales.Name = "btnsales";
            this.btnsales.Size = new System.Drawing.Size(219, 48);
            this.btnsales.TabIndex = 67;
            this.btnsales.Text = "   Sales";
            this.btnsales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsales.UseVisualStyleBackColor = false;
            this.btnsales.Click += new System.EventHandler(this.btnsales_Click);
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.Color.Transparent;
            this.btnorder.FlatAppearance.BorderSize = 0;
            this.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorder.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.ForeColor = System.Drawing.Color.White;
            this.btnorder.Image = ((System.Drawing.Image)(resources.GetObject("btnorder.Image")));
            this.btnorder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorder.Location = new System.Drawing.Point(-4, 284);
            this.btnorder.Margin = new System.Windows.Forms.Padding(4);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(219, 48);
            this.btnorder.TabIndex = 66;
            this.btnorder.Text = "   Order";
            this.btnorder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnorder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.BackColor = System.Drawing.Color.Transparent;
            this.btncustomer.FlatAppearance.BorderSize = 0;
            this.btncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomer.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomer.ForeColor = System.Drawing.Color.White;
            this.btncustomer.Image = ((System.Drawing.Image)(resources.GetObject("btncustomer.Image")));
            this.btncustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomer.Location = new System.Drawing.Point(-4, 227);
            this.btncustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(219, 48);
            this.btncustomer.TabIndex = 65;
            this.btncustomer.Text = "   Customer";
            this.btncustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncustomer.UseVisualStyleBackColor = false;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnparts
            // 
            this.btnparts.BackColor = System.Drawing.Color.Transparent;
            this.btnparts.FlatAppearance.BorderSize = 0;
            this.btnparts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnparts.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnparts.ForeColor = System.Drawing.Color.White;
            this.btnparts.Image = ((System.Drawing.Image)(resources.GetObject("btnparts.Image")));
            this.btnparts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnparts.Location = new System.Drawing.Point(-4, 171);
            this.btnparts.Margin = new System.Windows.Forms.Padding(4);
            this.btnparts.Name = "btnparts";
            this.btnparts.Size = new System.Drawing.Size(219, 47);
            this.btnparts.TabIndex = 11;
            this.btnparts.Text = "   Parts";
            this.btnparts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnparts.UseVisualStyleBackColor = false;
            this.btnparts.Click += new System.EventHandler(this.btnparts_Click);
            // 
            // btnCar
            // 
            this.btnCar.BackColor = System.Drawing.Color.Transparent;
            this.btnCar.FlatAppearance.BorderSize = 0;
            this.btnCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar.ForeColor = System.Drawing.Color.White;
            this.btnCar.Image = ((System.Drawing.Image)(resources.GetObject("btnCar.Image")));
            this.btnCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCar.Location = new System.Drawing.Point(-4, 119);
            this.btnCar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(219, 43);
            this.btnCar.TabIndex = 10;
            this.btnCar.Text = "   Car";
            this.btnCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCar.UseVisualStyleBackColor = false;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashBoard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(-4, 73);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(219, 37);
            this.btnDashBoard.TabIndex = 9;
            this.btnDashBoard.Text = "   DashBoard";
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnclear);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtcustomerid);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtlname);
            this.panel4.Controls.Add(this.txtphone);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtaddress);
            this.panel4.Controls.Add(this.txtfname);
            this.panel4.Controls.Add(this.txtemail);
            this.panel4.Location = new System.Drawing.Point(1179, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 719);
            this.panel4.TabIndex = 135;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnclear.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclear.Location = new System.Drawing.Point(202, 478);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(103, 39);
            this.btnclear.TabIndex = 91;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(202, 557);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 39);
            this.button3.TabIndex = 88;
            this.button3.Text = "DETELE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(57, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 87;
            this.button2.Text = "EDIT";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customerGridView);
            this.panel3.Location = new System.Drawing.Point(222, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(928, 566);
            this.panel3.TabIndex = 136;
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 784);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comsearchType);
            this.Controls.Add(this.btnSearch);
            this.Name = "ManageCustomer";
            this.Text = "ManageCustomer";
            this.Load += new System.EventHandler(this.ManageCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comsearchType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnbackup;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnsales;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnparts;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
    }
}