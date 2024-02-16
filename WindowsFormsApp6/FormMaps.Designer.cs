namespace WindowsFormsApp6
{
    partial class FormMaps
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelName = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picMaps = new System.Windows.Forms.PictureBox();
            this.zoomTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaps)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.picMaps);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 741);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panelName);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(299, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 81);
            this.panel2.TabIndex = 1;
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.lbName);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(655, 81);
            this.panelName.TabIndex = 7;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Blue;
            this.lbName.Location = new System.Drawing.Point(59, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 61);
            this.lbName.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSelect);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.cbCamera);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(655, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(344, 81);
            this.panel4.TabIndex = 5;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.Color.Turquoise;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(118, 44);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(127, 33);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Mở Camera";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(78, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // cbCamera
            // 
            this.cbCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Items.AddRange(new object[] {
            "1-Hành lang Locker nữ",
            "2-Phòng phân tích",
            "3-Cửa SMT PD2",
            "4-Hành lang kho MC",
            "5-Kho WH",
            "6-Hành lang EQ",
            "7-Cổng A2",
            "8-Cổng A1",
            "9-Cổng A1-2",
            "10-Cổng A1-3",
            "11-KV Kyocera",
            "12-Cửa xuất kho PC",
            "13-Hành lang FAT-PD2",
            "14-Kho PC",
            "15-Xray Canon",
            "16-HLDS-FAT2",
            "17-Cửa Canteen",
            "18-Cửa ngoài Canteen",
            "19-Đường ngoài",
            "20-Đường ngoài nhà xe",
            "21-HLDS-SMT1",
            "22-FAT-YASKAWA",
            "23-Kho PC HLDS",
            "24-Cửa ngoài kho PC",
            "25-Kho MC ngoài",
            "26-Hành lang A4-1",
            "27-Cửa kho xuất AUTO",
            "28-Cửa nhà xe",
            "29-Cuối nhà xe",
            "30-Kho hóa chất",
            "31-Hành lang KX1",
            "32-Hành lang KX2",
            "33-Nhà nghỉ Canon",
            "35-Hành lang ngoài D1",
            "36-Hành lang ngoài D3",
            "37-Cổng bảo vệ A3",
            "38-Line Fuji-Nichicon",
            "39-Kho WH-HLDS",
            "40-Cửa sau LCA",
            "42-SMT-CANON",
            "43-FAT-CANON",
            "44-Đầu line SMT-CANON",
            "45-Xưởng SMT-BROTHER",
            "46-FAT-BIVN",
            "48-Kho PC",
            "49-Kho PC-Canon (kho của TE)",
            "52-Hành lang Locker nam",
            "54-Cửa kho ngoài MC",
            "55-Cửa kho MC",
            "56-Nhập LK kho WH",
            "57-Kho AC",
            "58-Nhà rác trong",
            "59-Nhà rác ngoài",
            "60-Nhà nghỉ M2",
            "61-Phòng hút thuốc Canteen",
            "62-Cửa vào Oto",
            "63-Cửa kho MC-Oto",
            "64-Cửa SMT-Oto",
            "65-Cửa FAT-Oto",
            "66-Khu vực SMT-Oto",
            "67-Khu vực FAT-Oto",
            "68-Khu vực SMT-Yaskawa",
            "69-Khu vực FAT-Yaskawa",
            "70-Cửa vào SMT-Yaskawa",
            "71-Cửa kho SMT-Yaskawa",
            "72-Cửa vào FAT-Yaskawa",
            "73-Nhà nghỉ KV Yaskawa",
            "74-Cửa exit kho PC-Oto",
            "75-Cửa xuất hàng kho PC-Oto",
            "76-Cửa vào kho PC-Oto",
            "77-Nhà rác KV Oto",
            "78-Phòng nghỉ Oto",
            "79-Hành lang lễ tân",
            "80-Hành lang nhà xe 1",
            "81-Hành lang nhà xe 2",
            "82-Cửa ngoài nhập hàng kho MC",
            "83-Cổng A1-lối đi bộ",
            "84-Cửa ngoài EQ",
            "85-Cửa ngoài Locker nam",
            "86-Cửa ngoài Locker nữ",
            "87-Cửa ngoài đầu Canteen",
            "88-Cửa ngoài cuối Canteen",
            "89-Cửa vào nhà xe công nhân",
            "90-Cửa ra nhà xe công nhân",
            "91-Cửa kho hóa chất",
            "92-Hành lang LCA",
            "93-Cổng A4",
            "94-Hành lang A2-1",
            "95-Hành lang A2-2",
            "96-Kho IC-New",
            "97-Cửa kho IC new",
            "98-Hành lang kho IC new",
            "99-Văn phòng PD1",
            "100-Kho IC-New 2",
            "101-Phòng Xray Yaskawa",
            "102-Hành lang PD1",
            "103-Đầu Canteen",
            "104-Cuối Canteen",
            "105-Canteen",
            "106-Khu vực gia công",
            "107-Nạp rom kho IC"});
            this.cbCamera.Location = new System.Drawing.Point(78, 4);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(211, 26);
            this.cbCamera.TabIndex = 2;
            this.cbCamera.SelectedIndexChanged += new System.EventHandler(this.cbCamera_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // picMaps
            // 
            this.picMaps.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.Camera_Maps1;
            this.picMaps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMaps.Location = new System.Drawing.Point(0, 0);
            this.picMaps.Name = "picMaps";
            this.picMaps.Size = new System.Drawing.Size(1298, 741);
            this.picMaps.TabIndex = 0;
            this.picMaps.TabStop = false;
            this.picMaps.Paint += new System.Windows.Forms.PaintEventHandler(this.picMaps_Paint);
            this.picMaps.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picMaps_MouseClick);
            this.picMaps.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMaps_MouseMove);
            this.picMaps.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picMaps_MouseUp);
            // 
            // zoomTimer
            // 
            this.zoomTimer.Tick += new System.EventHandler(this.zoomTimer_Tick);
            // 
            // FormMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 741);
            this.Controls.Add(this.panel1);
            this.Name = "FormMaps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMaps";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMaps_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMaps;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Timer zoomTimer;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panelName;
    }
}