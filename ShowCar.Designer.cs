
namespace ABC_Car_Traders
{
    partial class ShowCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCar));
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.comsearchType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.carGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.carGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(1245, 95);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(162, 32);
            this.txtsearch.TabIndex = 122;
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
            this.comsearchType.Location = new System.Drawing.Point(1077, 95);
            this.comsearchType.Name = "comsearchType";
            this.comsearchType.Size = new System.Drawing.Size(162, 31);
            this.comsearchType.TabIndex = 121;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(926, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 36);
            this.btnSearch.TabIndex = 120;
            this.btnSearch.Text = "SEARCH ";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // carGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.carGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.carGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.carGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.carGridView.Location = new System.Drawing.Point(286, 137);
            this.carGridView.Name = "carGridView";
            this.carGridView.RowHeadersWidth = 51;
            this.carGridView.RowTemplate.Height = 24;
            this.carGridView.Size = new System.Drawing.Size(1121, 566);
            this.carGridView.TabIndex = 119;
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
            this.label3.Location = new System.Drawing.Point(760, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 44);
            this.label3.TabIndex = 10;
            this.label3.Text = "SHOW CAR";
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
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
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
            // ShowCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 784);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.comsearchType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.carGridView);
            this.Name = "ShowCar";
            this.Text = "ShowCar";
            this.Load += new System.EventHandler(this.ShowCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox comsearchType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView carGridView;
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
    }
}