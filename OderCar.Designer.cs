
namespace ABC_Car_Traders
{
    partial class OderCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OderCar));
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.comsearchType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.carOrderGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.txtEngNo = new System.Windows.Forms.TextBox();
            this.CC = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.txtcolour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comModel = new System.Windows.Forms.ComboBox();
            this.Model = new System.Windows.Forms.Label();
            this.comBrand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnmakeorder = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOrderParts = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnOrderCar = new System.Windows.Forms.Button();
            this.btnShowParts = new System.Windows.Forms.Button();
            this.btnShowCar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.carOrderGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(985, 139);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(162, 32);
            this.txtsearch.TabIndex = 130;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // comsearchType
            // 
            this.comsearchType.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comsearchType.FormattingEnabled = true;
            this.comsearchType.Items.AddRange(new object[] {
            "Model",
            "Brand",
            "Color"});
            this.comsearchType.Location = new System.Drawing.Point(817, 140);
            this.comsearchType.Name = "comsearchType";
            this.comsearchType.Size = new System.Drawing.Size(162, 31);
            this.comsearchType.TabIndex = 129;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(679, 140);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 32);
            this.btnSearch.TabIndex = 128;
            this.btnSearch.Text = "SEARCH ";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // carOrderGridView
            // 
            this.carOrderGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.carOrderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.carOrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carOrderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carOrderGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.carOrderGridView.Location = new System.Drawing.Point(0, 0);
            this.carOrderGridView.Name = "carOrderGridView";
            this.carOrderGridView.RowHeadersWidth = 51;
            this.carOrderGridView.RowTemplate.Height = 24;
            this.carOrderGridView.Size = new System.Drawing.Size(921, 569);
            this.carOrderGridView.TabIndex = 127;
            this.carOrderGridView.SelectionChanged += new System.EventHandler(this.carOrderGridView_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 538);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 146;
            this.label6.Text = "Made By";
            // 
            // txtContry
            // 
            this.txtContry.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContry.Location = new System.Drawing.Point(157, 535);
            this.txtContry.Name = "txtContry";
            this.txtContry.Size = new System.Drawing.Size(140, 28);
            this.txtContry.TabIndex = 145;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 144;
            this.label5.Text = "Eng No";
            // 
            // txtCc
            // 
            this.txtCc.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCc.Location = new System.Drawing.Point(157, 441);
            this.txtCc.Name = "txtCc";
            this.txtCc.Size = new System.Drawing.Size(140, 28);
            this.txtCc.TabIndex = 143;
            // 
            // txtEngNo
            // 
            this.txtEngNo.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEngNo.Location = new System.Drawing.Point(157, 488);
            this.txtEngNo.Name = "txtEngNo";
            this.txtEngNo.Size = new System.Drawing.Size(140, 28);
            this.txtEngNo.TabIndex = 142;
            // 
            // CC
            // 
            this.CC.AutoSize = true;
            this.CC.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC.Location = new System.Drawing.Point(51, 444);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(34, 21);
            this.CC.TabIndex = 141;
            this.CC.Text = "CC";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(157, 394);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 28);
            this.txtPrice.TabIndex = 140;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(51, 397);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(51, 21);
            this.Price.TabIndex = 139;
            this.Price.Text = "Price";
            // 
            // txtcolour
            // 
            this.txtcolour.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolour.Location = new System.Drawing.Point(157, 347);
            this.txtcolour.Name = "txtcolour";
            this.txtcolour.Size = new System.Drawing.Size(140, 28);
            this.txtcolour.TabIndex = 138;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 137;
            this.label4.Text = "Colour";
            // 
            // comModel
            // 
            this.comModel.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comModel.FormattingEnabled = true;
            this.comModel.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.comModel.Location = new System.Drawing.Point(157, 299);
            this.comModel.Name = "comModel";
            this.comModel.Size = new System.Drawing.Size(140, 29);
            this.comModel.TabIndex = 136;
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Model.Location = new System.Drawing.Point(51, 303);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(59, 21);
            this.Model.TabIndex = 135;
            this.Model.Text = "Model";
            // 
            // comBrand
            // 
            this.comBrand.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBrand.FormattingEnabled = true;
            this.comBrand.Items.AddRange(new object[] {
            "Select Brand",
            "Honda",
            "Limousine",
            "Micro Car"});
            this.comBrand.Location = new System.Drawing.Point(157, 251);
            this.comBrand.Name = "comBrand";
            this.comBrand.Size = new System.Drawing.Size(140, 29);
            this.comBrand.TabIndex = 134;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 133;
            this.label2.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 132;
            this.label1.Text = "Item ID";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(157, 204);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(140, 28);
            this.txtid.TabIndex = 131;
            // 
            // btnmakeorder
            // 
            this.btnmakeorder.BackColor = System.Drawing.Color.Green;
            this.btnmakeorder.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmakeorder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmakeorder.Location = new System.Drawing.Point(118, 633);
            this.btnmakeorder.Name = "btnmakeorder";
            this.btnmakeorder.Size = new System.Drawing.Size(179, 47);
            this.btnmakeorder.TabIndex = 147;
            this.btnmakeorder.Text = "MAKE ORDER";
            this.btnmakeorder.UseVisualStyleBackColor = false;
            this.btnmakeorder.Click += new System.EventHandler(this.btnmakeorder_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 582);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 28);
            this.dateTimePicker1.TabIndex = 149;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 585);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 150;
            this.label7.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1537, 60);
            this.panel1.TabIndex = 155;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(603, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 44);
            this.label3.TabIndex = 10;
            this.label3.Text = "ORDER CAR";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1336, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "   LOG OUT";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.btnOrderParts);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Controls.Add(this.btnOrderHistory);
            this.panel2.Controls.Add(this.btnOrderCar);
            this.panel2.Controls.Add(this.btnShowParts);
            this.panel2.Controls.Add(this.btnShowCar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 724);
            this.panel2.TabIndex = 156;
            // 
            // btnOrderParts
            // 
            this.btnOrderParts.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderParts.FlatAppearance.BorderSize = 0;
            this.btnOrderParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderParts.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderParts.ForeColor = System.Drawing.Color.White;
            this.btnOrderParts.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderParts.Image")));
            this.btnOrderParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderParts.Location = new System.Drawing.Point(-2, 371);
            this.btnOrderParts.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderParts.Name = "btnOrderParts";
            this.btnOrderParts.Size = new System.Drawing.Size(219, 43);
            this.btnOrderParts.TabIndex = 71;
            this.btnOrderParts.Text = "  Order Parts";
            this.btnOrderParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderParts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderParts.UseVisualStyleBackColor = false;
            this.btnOrderParts.Click += new System.EventHandler(this.btnOrderParts_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(2, 143);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(219, 43);
            this.btnDashboard.TabIndex = 70;
            this.btnDashboard.Text = "   DashBoard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(-2, 485);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(219, 43);
            this.btnProfile.TabIndex = 65;
            this.btnProfile.Text = "   Profile";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderHistory.FlatAppearance.BorderSize = 0;
            this.btnOrderHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderHistory.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderHistory.ForeColor = System.Drawing.Color.White;
            this.btnOrderHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderHistory.Image")));
            this.btnOrderHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderHistory.Location = new System.Drawing.Point(-2, 428);
            this.btnOrderHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(219, 43);
            this.btnOrderHistory.TabIndex = 69;
            this.btnOrderHistory.Text = "  Order History";
            this.btnOrderHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderHistory.UseVisualStyleBackColor = false;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnOrderCar
            // 
            this.btnOrderCar.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderCar.FlatAppearance.BorderSize = 0;
            this.btnOrderCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderCar.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCar.ForeColor = System.Drawing.Color.White;
            this.btnOrderCar.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderCar.Image")));
            this.btnOrderCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderCar.Location = new System.Drawing.Point(0, 257);
            this.btnOrderCar.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderCar.Name = "btnOrderCar";
            this.btnOrderCar.Size = new System.Drawing.Size(219, 43);
            this.btnOrderCar.TabIndex = 66;
            this.btnOrderCar.Text = "  Order Car";
            this.btnOrderCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderCar.UseVisualStyleBackColor = false;
            this.btnOrderCar.Click += new System.EventHandler(this.btnOrderCar_Click);
            // 
            // btnShowParts
            // 
            this.btnShowParts.BackColor = System.Drawing.Color.Transparent;
            this.btnShowParts.FlatAppearance.BorderSize = 0;
            this.btnShowParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowParts.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowParts.ForeColor = System.Drawing.Color.White;
            this.btnShowParts.Image = ((System.Drawing.Image)(resources.GetObject("btnShowParts.Image")));
            this.btnShowParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowParts.Location = new System.Drawing.Point(-2, 314);
            this.btnShowParts.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowParts.Name = "btnShowParts";
            this.btnShowParts.Size = new System.Drawing.Size(219, 43);
            this.btnShowParts.TabIndex = 11;
            this.btnShowParts.Text = "   Show Parts";
            this.btnShowParts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowParts.UseVisualStyleBackColor = false;
            this.btnShowParts.Click += new System.EventHandler(this.btnShowParts_Click);
            // 
            // btnShowCar
            // 
            this.btnShowCar.BackColor = System.Drawing.Color.Transparent;
            this.btnShowCar.FlatAppearance.BorderSize = 0;
            this.btnShowCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCar.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCar.ForeColor = System.Drawing.Color.White;
            this.btnShowCar.Image = ((System.Drawing.Image)(resources.GetObject("btnShowCar.Image")));
            this.btnShowCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowCar.Location = new System.Drawing.Point(0, 200);
            this.btnShowCar.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowCar.Name = "btnShowCar";
            this.btnShowCar.Size = new System.Drawing.Size(219, 43);
            this.btnShowCar.TabIndex = 10;
            this.btnShowCar.Text = "   Show Car";
            this.btnShowCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowCar.UseVisualStyleBackColor = false;
            this.btnShowCar.Click += new System.EventHandler(this.btnShowCar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.comModel);
            this.panel4.Controls.Add(this.txtid);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnmakeorder);
            this.panel4.Controls.Add(this.comBrand);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.Model);
            this.panel4.Controls.Add(this.txtContry);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtcolour);
            this.panel4.Controls.Add(this.txtCc);
            this.panel4.Controls.Add(this.Price);
            this.panel4.Controls.Add(this.txtEngNo);
            this.panel4.Controls.Add(this.txtPrice);
            this.panel4.Controls.Add(this.CC);
            this.panel4.Location = new System.Drawing.Point(1179, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 719);
            this.panel4.TabIndex = 157;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.carOrderGridView);
            this.panel3.Location = new System.Drawing.Point(226, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(921, 569);
            this.panel3.TabIndex = 158;
            // 
            // OderCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 784);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.comsearchType);
            this.Controls.Add(this.btnSearch);
            this.Name = "OderCar";
            this.Text = "OderCar";
            this.Load += new System.EventHandler(this.OderCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carOrderGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox comsearchType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView carOrderGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCc;
        private System.Windows.Forms.TextBox txtEngNo;
        private System.Windows.Forms.Label CC;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox txtcolour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comModel;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.ComboBox comBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnmakeorder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOrderParts;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnOrderCar;
        private System.Windows.Forms.Button btnShowParts;
        private System.Windows.Forms.Button btnShowCar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}