using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class FormMaps : Form
    {
        public static int cameraNumber;
        public static int TypeCamera;
        private ToolTip tooltip;
        public static string url;
        public static int getSelectCamera;

        // timer
        private int radius = 10;
        private bool zoomingIn = true;
        //position
        private float xPercent = 0; // Initial x-coordinate of the circle center
        private float yPercent = 0; // Initial y-coordinate of the circle center

        public FormMaps()
        {
            InitializeComponent();
            picMaps.MouseMove += picMaps_MouseMove; 
            this.MouseUp += picMaps_MouseUp;
            tooltip = new ToolTip();
            tooltip.AutoPopDelay = 0; // Set the delay to 0 so that the tooltip remains visible
            tooltip.ShowAlways = true;
            //setup timer
            zoomTimer.Interval = 50; // 0.05 seconds
            zoomTimer.Tick += zoomTimer_Tick;
            zoomTimer.Start();
        }
        private void picMaps_MouseClick(object sender, MouseEventArgs e)
        {
            //// Calculate the position based on the percentage of the PictureBox dimensions
            //float percentageX = (float)e.X / picMaps.Width * 100;
            //float percentageY = (float)e.Y / picMaps.Height * 100;

            //// Display the position
            //position = $"Position: X = {percentageX}%, Y = {percentageY}%";
            //MessageBox.Show(position, "Mouse Click Position", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private List<string> allItems;
        private List<string> filteredItems;
        private void FormMaps_Load(object sender, EventArgs e)
        {
            allItems = cbCamera.Items.OfType<string>().ToList();
            cbCamera.DropDownHeight = cbCamera.ItemHeight * 8;

        }
        private void picMaps_MouseMove(object sender, MouseEventArgs e)
        {
            float percentageX = (float)e.X / picMaps.Width * 100;
            float percentageY = (float)e.Y / picMaps.Height * 100;
            // Call method to display information table
            DisplayCoordinatesInfo(percentageX, percentageY);
            int stX = panelName.Location.X;
            int endX = stX + panelName.Width;
            int stY = panelName.Location.Y;

            int subX = (stX + endX) / 2;

            int lbX = lbName.Width / 2;
            int resultX = subX - lbX;
            lbName.Location = new Point(resultX, stY);
            if (url != null)
            {
                Cursor.Current = Cursors.Hand;
                lbName.Text = position;
            }
        }
        string position;
        private void DisplayCoordinatesInfo(float x, float y)
        {
            if (x >= 50 && x <= 53 && y >= 39 && y <= 41)
            {
                cameraNumber = 107;
                TypeCamera = 2;
                position = $"Nạp rom kho IC";
                url = "172.28.13.116";
            }
            else if (x >= 80 && x <= 83 && y >= 64.5 && y <= 67)
            {
                cameraNumber = 106;
                TypeCamera = 2;
                position = $"Khu vực gia công";
                url = "172.28.13.115";
            }
            else if (x >= 29.5 && x <= 30.5 && y >= 22 && y <= 23.5)
            {
                cameraNumber = 105;
                TypeCamera = 4;
                position = $"Canteen";
                url = "172.28.13.114";
            }
            else if (x >= 19 && x <= 21 && y >= 16 && y <= 18)
            {
                cameraNumber = 104;
                TypeCamera = 2;
                position = $"Cuối Canteen";
                url = "172.28.13.113";
            }
            else if (x >= 27 && x <= 28.5 && y >= 17 && y <= 19)
            {
                cameraNumber = 103;
                TypeCamera = 2;
                position = $"Đầu Canteen";
                url = "172.28.13.112";
            }
            else if (x >= 53 && x <= 55 && y >= 60 && y <= 62)
            {
                cameraNumber = 102;
                TypeCamera = 4;
                position = $"Hành lang PD1";

                url = "172.28.13.111";
            }
            else if (x >= 28 && x <= 31 && y >= 76 && y <= 78)
            {
                cameraNumber = 101;
                TypeCamera = 2;
                position = $"Phòng Xray Yaskawa";

                url = "172.28.13.110";
            }
            else if (x >= 51.8 && x <= 52.5 && y >= 33 && y <= 34.2)
            {
                cameraNumber = 100;
                TypeCamera = 5;
                position = $"Kho IC-New 2";
                url = "172.28.13.109";
            }
            else if (x >= 58.5 && x <= 60 && y >= 59.5 && y <= 61)
            {
                cameraNumber = 99;
                TypeCamera = 3;
                position = $"Văn phòng PD1";
                url = "172.28.13.108";
            }
            else if (x >= 53.5 && x <= 55 && y >= 35.2 && y <= 36.5)
            {
                cameraNumber = 98;
                TypeCamera = 2;
                position = $"Hành lang kho IC new";
                url = "172.28.13.107";
            }
            else if (x >= 53 && x <= 54.5 && y >= 33 && y <= 34.5)
            {
                cameraNumber = 97;
                TypeCamera = 2;
                position = $"Cửa kho IC new";
                url = "172.28.13.106";
            }
            else if (x >= 52 && x <= 54 && y >= 27 && y <= 29)
            {
                cameraNumber = 96;
                TypeCamera = 2;
                position = $"Kho IC-New";
                url = "172.28.13.105";
            }
            else if (x >= 63 && x <= 65 && y >= 86 && y <= 89)
            {
                cameraNumber = 95;
                TypeCamera = 2;
                position = $"Hành lang A2-2";
                url = "172.28.13.104";
            }
            else if (x >= 60 && x <= 62 && y >= 86 && y <= 89)
            {
                cameraNumber = 94;
                TypeCamera = 2;
                position = $"Hành lang A2-1";
                url = "172.28.13.103";
            }
            else if (x >= 4 && x <= 6 && y >= 88 && y <= 91)
            {
                cameraNumber = 93;
                TypeCamera = 5;
                position = $"Cổng A4";
                url = "172.28.13.102";
            }
            else if (x >= 11.5 && x <= 13 && y >= 31 && y <= 33)
            {
                cameraNumber = 92;
                TypeCamera = 2;
                position = $"Hành lang LCA";
                url = "172.28.13.101";
            }
            else if (x >= 5 && x <= 6.4 && y >= 32.4 && y <= 34)
            {
                cameraNumber = 91;
                TypeCamera = 2;
                position = $"Cửa kho hóa chất";
                url = "172.28.13.100";
            }

            else if (x >= 7 && x <= 9 && y >= 10 && y <= 12)
            {
                cameraNumber = 90;
                TypeCamera = 2;
                position = $"Cửa ra nhà xe công nhân";
                url = "172.28.13.99";
            }
            else if (x >= 20 && x <= 22 && y >= 1 && y <= 4)
            {
                cameraNumber = 89;
                TypeCamera = 2;
                position = $"Cửa vào nhà xe công nhân";
                url = "172.28.13.98";
            }
            else if (x >= 17.5 && x <= 19 && y >= 13.5 && y <= 15)
            {
                cameraNumber = 88;
                TypeCamera = 2;
                position = $"Cửa ngoài cuối Canteen";
                url = "172.28.13.97";
            }
            else if (x >= 26.6 && x <= 28.5 && y >= 13 && y <= 15)
            {
                cameraNumber = 87;
                TypeCamera = 2;
                position = $"Cửa ngoài đầu Canteen";
                url = "172.28.13.96";
            }
            else if (x >= 43 && x <= 44.5 && y >= 13 && y <= 15)
            {
                cameraNumber = 86;
                TypeCamera = 2;
                position = $"Cửa ngoài Locker nữ";
                url = "172.28.13.95";
            }
            else if (x >= 47 && x <= 49 && y >= 13 && y <= 15)
            {
                cameraNumber = 85;
                TypeCamera = 2;
                position = $"Cửa ngoài Locker nam";
                url = "172.28.13.94";
            }
            else if (x >= 76 && x <= 77.5 && y >= 13 && y <= 15)
            {
                cameraNumber = 84;
                TypeCamera = 2;
                position = $"Cửa ngoài EQ";
                url = "172.28.13.93";
            }
            else if (x >= 98.4 && x <= 99.5 && y >= 15 && y <= 18)
            {
                cameraNumber = 83;
                TypeCamera = 2;
                position = $"Cổng A1-lối đi bộ";
                url = "172.28.13.92";
            }
            else if (x >= 95 && x <= 96.5 && y >= 22.3 && y <= 23.7)
            {
                cameraNumber = 82;
                TypeCamera = 5;
                position = $"Cửa ngoài nhập hàng kho MC";
                url = "172.28.13.91";
            }
            else if (x >= 96 && x <= 98.5 && y >= 38 && y <= 41)
            {
                cameraNumber = 81;
                TypeCamera = 2;
                position = $"Hành lang nhà xe 2";
                url = "172.28.13.90";
            }
            else if (x >= 96 && x <= 98.4 && y >= 43 && y <= 45)
            {
                cameraNumber = 80;
                TypeCamera = 2;
                position = $"Hành lang nhà xe 1";
                url = "172.28.13.89";
            }
            else if (x >= 90 && x <= 92 && y >= 76 && y <= 79)
            {
                cameraNumber = 79;
                TypeCamera = 2;
                position = $"Hành lang lễ tân";
                url = "172.28.13.88";
            }
            else if (x >= 15 && x <= 17 && y >= 30 && y <= 33)
            {
                cameraNumber = 78;
                TypeCamera = 2;
                position = $"Phòng nghỉ Oto";
                url = "172.28.13.87";
            }
            else if (x >= 8 && x <= 10 && y >= 33 && y <= 35)
            {
                cameraNumber = 77;
                TypeCamera = 2;
                position = $"Nhà rác KV Oto";
                url = "172.28.13.86";
            }
            else if (x >= 12 && x <= 14 && y >= 40 && y <= 42.4)
            {
                cameraNumber = 76;
                TypeCamera = 2;
                position = $"Cửa vào kho PC-Oto";
                url = "172.28.13.85";
            }
            else if (x >= 9 && x <= 11 && y >= 50 && y <= 52.5)
            {
                cameraNumber = 75;
                TypeCamera = 5;
                position = $"Cửa xuất hàng kho PC-Oto";
                url = "172.28.13.84";
            }
            else if (x >= 12 && x <= 14 && y >= 71 && y <= 73.6)
            {
                cameraNumber = 74;
                TypeCamera = 5;
                position = $"Cửa exit kho PC-Oto";
                url = "172.28.13.83";
            }
            else if (x >= 20 && x <= 21.5 && y >= 74 && y <= 76.5)
            {
                cameraNumber = 73;
                TypeCamera = 2;
                position = $"Nhà nghỉ KV Yaskawa";
                url = "172.28.13.82";
            }
            else if (x >= 18 && x <= 20 && y >= 69 && y <= 71)
            {
                cameraNumber = 72;
                TypeCamera = 2;
                position = $"Cửa vào FAT-Yaskawa";
                url = "172.28.13.81";
            }
            else if (x >= 25 && x <= 27 && y >= 69 && y <= 70.5)
            {
                cameraNumber = 71;
                TypeCamera = 2;
                position = $"Cửa kho SMT-Yaskawa";
                url = "172.28.13.80";
            }
            else if (x >= 25.5 && x <= 27 && y >= 73 && y <= 75)
            {
                cameraNumber = 70;
                TypeCamera = 2;
                position = $"Cửa vào SMT-Yaskawa";
                url = "172.28.13.79";
            }
            else if (x >= 17 && x <= 19 && y >= 62 && y <= 64.5)
            {
                cameraNumber = 69;
                TypeCamera = 5;
                position = $"Khu vực FAT-Yaskawa";
                url = "172.28.13.78";
            }
            else if (x >= 25 && x <= 27 && y >= 62 && y <= 65)
            {
                cameraNumber = 68;
                TypeCamera = 2;
                position = $"Khu vực SMT-Yaskawa";
                url = "172.28.13.77";
            }
            else if (x >= 17 && x <= 19 && y >= 44 && y <= 46)
            {
                cameraNumber = 67;
                TypeCamera = 2;
                position = $"Khu vực FAT-Oto";
                url = "172.28.13.76";
            }
            else if (x >= 24 && x <= 26 && y >= 44 && y <= 46)
            {
                cameraNumber = 66;
                TypeCamera = 2;
                position = $"Khu vực SMT-Oto";
                url = "172.28.13.75";
            }
            else if (x >= 22 && x <= 24 && y >= 47 && y <= 50)
            {
                cameraNumber = 65;
                TypeCamera = 2;
                position = $"Cửa FAT-Oto";
                url = "172.28.13.74";
            }
            else if (x >= 21 && x <= 24 && y >= 38 && y <= 41)
            {
                cameraNumber = 64;
                TypeCamera = 2;
                position = $"Cửa SMT-Oto";
                url = "172.28.13.73";
            }
            else if (x >= 29 && x <= 31 && y >= 39 && y <= 42)
            {
                cameraNumber = 63;
                TypeCamera = 5;
                position = $"Cửa kho MC-Oto";
                url = "172.28.13.72";
            }
            else if (x >= 31 && x <= 33 && y >= 34 && y <= 37)
            {
                cameraNumber = 62;
                TypeCamera = 2;
                position = $"Cửa vào Oto";
                url = "172.28.13.71";
            }
            else if (x >= 35 && x <= 36.5 && y >= 27 && y <= 29)
            {
                cameraNumber = 61;
                TypeCamera = 2;
                position = $"Phòng hút thuốc Canteen";
                url = "172.28.13.70";
            }
            else if (x >= 55 && x <= 59.5 && y >= 24 && y <= 27)
            {
                cameraNumber = 60;
                TypeCamera = 2;
                position = $"Nhà nghỉ M2";
                url = "172.28.13.69";
            }
            else if (x >= 63 && x <= 65 && y >= 18 && y <= 21)
            {
                cameraNumber = 59;
                TypeCamera = 5;
                position = $"Nhà rác ngoài";
                url = "172.28.13.68";
            }
            else if (x >= 63 && x <= 65 && y >= 23 && y <= 25)
            {
                cameraNumber = 58;
                TypeCamera = 2;
                position = $"Nhà rác trong";
                url = "172.28.13.67";
            }
            else if (x >= 77 && x <= 79 && y >= 23 && y <= 25.4)
            {
                cameraNumber = 57;
                TypeCamera = 5;
                position = $"Kho AC";
                url = "172.28.13.66";
            }
            else if (x >= 81.5 && x <= 83 && y >= 24 && y <= 27)
            {
                cameraNumber = 56;
                TypeCamera = 2;
                position = $"Nhập LK kho WH";
                url = "172.28.13.65";
            }
            else if (x >= 83 && x <= 85 && y >= 38 && y <= 40)
            {
                cameraNumber = 55;
                TypeCamera = 2;
                position = $"Cửa kho MC";
                url = "172.28.13.64";
            }
            else if (x >= 85 && x <= 87 && y >= 29 && y <= 32)
            {
                cameraNumber = 54;
                TypeCamera = 2;
                position = $"Cửa kho ngoài MC";
                url = "172.28.13.63";
            }
            ////else if (x >=  && x <=  && y >=  && y <= )
            ////{
            ////    cameraNumber = 53;
            ////    TypeCamera = 1;
            ////    position = $"Nhập LK kho WH";
            ////    
            ////    url = "172.28.13.65";
            ////}
            else if (x >= 46 && x <= 48 && y >= 25 && y <= 30)
            {
                cameraNumber = 52;
                TypeCamera = 1;
                position = $"Hành lang Locker nam";
                url = "172.28.13.61";
            }
            //else if (x >=  && x <=  && y >=  && y <= )
            //{
            //    cameraNumber = 51;
            //    TypeCamera = 1;
            //    position = $"Nhập LK kho WH";
            //    
            //    url = "172.28.13.65";
            //}
            //else if (x >=  && x <=  && y >=  && y <= )
            //{
            //    cameraNumber = 50;
            //    TypeCamera = 1;
            //    position = $"Nhập LK kho WH";
            //    
            //    url = "172.28.13.65";
            //}
            else if (x >= 58 && x <= 60 && y >= 81 && y <= 82.5)
            {
                cameraNumber = 49;
                TypeCamera = 2;
                position = $"Kho PC-Canon (kho của TE)";
                url = "172.28.13.58";
            }
            else if (x >= 55 && x <= 57 && y >= 67 && y <= 69)
            {
                cameraNumber = 48;
                TypeCamera = 5;
                position = $"Kho PC";
                url = "172.28.13.57";
            }
            //else if (x >=  && x <=  && y >=  && y <= )
            //{
            //    cameraNumber = 47;
            //    TypeCamera = 1;
            //    position = $"Nhập LK kho WH";
            //    
            //    url = "172.28.13.56";
            //}
            else if (x >= 58 && x <= 60 && y >= 43 && y <= 46)
            {
                cameraNumber = 46;
                TypeCamera = 6;
                position = $"FAT-BIVN";
                url = "172.28.13.55";
            }
            else if (x >= 70 && x <= 72 && y >= 38 && y <= 41)
            {
                cameraNumber = 45;
                TypeCamera = 2;
                position = $"Xưởng SMT-BROTHER";
                url = "172.28.13.54";
            }
            else if (x >= 76 && x <= 78 && y >= 55 && y <= 57)
            {
                cameraNumber = 44;
                TypeCamera = 2;
                position = $"Đầu line SMT-CANON";
                url = "172.28.13.53";
            }
            else if (x >= 64 && x <= 66 && y >= 66 && y <= 68.5)
            {
                cameraNumber = 43;
                TypeCamera = 2;
                position = $"FAT-CANON";
                url = "172.28.13.52";
            }
            else if (x >= 74 && x <= 76 && y >= 66 && y <= 69)
            {
                cameraNumber = 42;
                TypeCamera = 6;
                position = $"SMT-CANON";
                url = "172.28.13.51";
            }
            //else if (x >=  && x <=  && y >=  && y <= )
            //{
            //    cameraNumber = 41;
            //    TypeCamera = 1;
            //    position = $"Nhập LK kho WH";
            //    
            //    url = "172.28.13.50";
            //}
            else if (x >= 2 && x <= 4 && y >= 34.5 && y <= 37)
            {
                cameraNumber = 40;
                TypeCamera = 1;
                position = $"Cửa sau LCA";
                url = "172.28.13.49";
            }
            else if (x >= 45 && x <= 47 && y >= 37 && y <= 40)
            {
                cameraNumber = 39;
                TypeCamera = 5;
                position = $"Kho WH-HLDS";
                url = "172.28.13.48";
            }
            else if (x >= 59 && x <= 62 && y >= 37 && y <= 40)
            {
                cameraNumber = 38;
                TypeCamera = 5;
                position = $"Line Fuji-Nichicon";
                url = "172.28.13.47";
            }
            //=============
            else if (x >= 44 && x <= 46 && y >= 89 && y <= 92)
            {
                cameraNumber = 37;
                TypeCamera = 5;
                position = $"Cổng bảo vệ A3";
                url = "172.28.13.46";
            }
            else if (x >= 41 && x <= 43 && y >= 89 && y <= 91)
            {
                cameraNumber = 36;
                TypeCamera = 1;
                position = $"Hành lang ngoài D3";
                url = "172.28.13.45";
            }
            else if (x >= 30 && x <= 32 && y >= 89 && y <= 91)
            {
                cameraNumber = 35;
                TypeCamera = 1;
                position = $"Hành lang ngoài D1";
                url = "172.28.13.44";
            }
            //else if (x >=  && x <=  && y >=  && y <= )
            //{
            //    cameraNumber = 34;
            //    TypeCamera = 0;
            //    position = $"Hành lang ngoài BV";
            //    
            //    url = "172.28.13.43";
            //}
            else if (x >= 74 && x <= 77 && y >= 79 && y <= 82)
            {
                cameraNumber = 33;
                TypeCamera = 1;
                position = $"Nhà nghỉ Canon";
                url = "172.28.13.42";
            }
            else if (x >= 17 && x <= 19 && y >= 80 && y <= 82)
            {
                cameraNumber = 32;
                TypeCamera = 1;
                position = $"Hành lang KX2";
                url = "172.28.13.41";
            }
            else if (x >= 7 && x <= 9 && y >= 79 && y <= 82)
            {
                cameraNumber = 31;
                TypeCamera = 1;
                position = $"Hành lang KX1";
                url = "172.28.13.40";
            }

            else if (x >= 5 && x <= 7 && y >= 28 && y <= 31)
            {
                cameraNumber = 30;
                TypeCamera = 5;
                position = $"Kho hóa chất";
                url = "172.28.13.39";
            }
            else if (x >= 7 && x <= 12 && y >= 0.2 && y <= 3)
            {
                cameraNumber = 29;
                TypeCamera = 1;
                position = $"Cuối nhà xe";
                url = "172.28.13.38";
            }
            else if (x >= 18 && x <= 20 && y >= 8 && y <= 10.5)
            {
                cameraNumber = 28;
                TypeCamera = 1;
                position = $"Cửa nhà xe";
                url = "172.28.13.37";
            }
            else if (x >= 9 && x <= 11 && y >= 72 && y <= 74)
            {
                cameraNumber = 27;
                TypeCamera = 5;
                position = $"Cửa kho xuất AUTO";
                url = "172.28.13.36";
            }
            else if (x >= 9 && x <= 12.5 && y >= 45 && y <= 48)
            {
                cameraNumber = 26;
                TypeCamera = 3;
                position = $"Hành lang A4-1";
                url = "172.28.13.35";
            }
            else if (x >= 87 && x <= 89 && y >= 24 && y <= 26.5)
            {
                cameraNumber = 25;
                TypeCamera = 5;
                position = $"Kho MC ngoài";
                url = "172.28.13.34";
            }
            else if (x >= 37 && x <= 39 && y >= 78 && y <= 80)
            {
                cameraNumber = 24;
                TypeCamera = 5;
                position = $"Cửa ngoài kho PC";
                url = "172.28.13.33";
            }
            else if (x >= 39 && x <= 41 && y >= 69 && y <= 71)
            {
                cameraNumber = 23;
                TypeCamera = 5;
                position = $"Kho PC HLDS";
                url = "172.28.13.32";
            }
            else if (x >= 35 && x <= 37 && y >= 46 && y <= 48)
            {
                cameraNumber = 22;
                TypeCamera = 2;
                position = $"FAT-YASKAWA";
                url = "172.28.13.31";
            }
            else if (x >= 41 && x <= 43 && y >= 46 && y <= 48)
            {
                cameraNumber = 21;
                TypeCamera = 2;
                position = $"HLDS-SMT1";
                url = "172.28.13.30";
            }
            else if (x >= 23 && x <= 25 && y >= 13 && y <= 15)
            {
                cameraNumber = 20;
                TypeCamera = 5;
                position = $"Đường ngoài nhà xe";
                url = "172.28.13.29";
            }
            else if (x >= 41 && x <= 42.5 && y >= 13 && y <= 15.5)
            {
                cameraNumber = 19;
                TypeCamera = 1;
                position = $"Đường ngoài";
                url = "172.28.13.28";
            }
            else if (x >= 29 && x <= 31 && y >= 28 && y <= 30)
            {
                cameraNumber = 18;
                TypeCamera = 2;
                position = $"Cửa ngoài Canteen";
                url = "172.28.13.27";
            }
            else if (x >= 32 && x <= 33 && y >= 29.5 && y <= 32)
            {
                cameraNumber = 17;
                TypeCamera = 3;
                position = $"Cửa Canteen";
                url = "172.28.13.26";
            }
            else if (x >= 35.3 && x <= 37 && y >= 58 && y <= 60.6)
            {
                cameraNumber = 16;
                TypeCamera = 2;
                position = $"HLDS-FAT2";
                url = "172.28.13.25";
            }
            else if (x >= 81 && x <= 82.5 && y >= 71.5 && y <= 73)
            {
                cameraNumber = 15;
                TypeCamera = 2;
                position = $"Xray Canon";
                url = "172.28.13.24";
            }
            else if (x >= 56.7 && x <= 57.7 && y >= 75.4 && y <= 77.4)
            {
                cameraNumber = 14;
                TypeCamera = 1;
                position = $"Kho PC";
                url = "172.28.13.23";
            }
            else if (x >= 52.7 && x <= 53.5 && y >= 24.5 && y <= 26.1)
            {
                cameraNumber = 13;
                TypeCamera = 2;
                position = $"Hành lang FAT-PD2";
                url = "172.28.13.22";
            }
            else if (x >= 47 && x <= 49 && y >= 72 && y <= 74)
            {
                cameraNumber = 12;
                TypeCamera = 1;
                position = $"Cửa xuất kho PC";
                url = "172.28.13.21";
            }
            else if (x >= 50 && x <= 51.5 && y >= 57 && y <= 58.5)
            {
                cameraNumber = 11;
                TypeCamera = 3;
                position = $"KV Kyocera";
                url = "172.28.13.20";
            }
            else if (x >= 96.5 && x <= 97.5 && y >= 17 && y <= 19)
            {
                cameraNumber = 10;
                TypeCamera = 5;
                position = $"Cổng A1-3";
                url = "172.28.13.19";
            }
            else if (x >= 97.3 && x <= 97.8 && y >= 21.8 && y <= 24)
            {
                cameraNumber = 9;
                TypeCamera = 1;
                position = $"Cổng A1-2";
                url = "172.28.13.18";
            }
            else if (x >= 98.4 && x <= 99.2 && y >= 23 && y <= 25)
            {
                cameraNumber = 8;
                TypeCamera = 5;
                position = $"Cổng A1";
                url = "172.28.13.17";
            }
            else if (x >= 77 && x <= 78.5 && y >= 91 && y <= 92.5)
            {
                cameraNumber = 7;
                TypeCamera = 1;
                position = $"Cổng A2";
                url = "172.28.13.16";
            }
            else if (x >= 71 && x <= 73 && y >= 25 && y <= 27.5)
            {
                cameraNumber = 6;
                TypeCamera = 2;
                position = $"Hành lang EQ";
                url = "172.28.13.15";
            }
            else if (x >= 88.7 && x <= 89.7 && y >= 36 && y <= 38)
            {
                cameraNumber = 5;
                TypeCamera = 1;
                position = $"Kho WH";
                url = "172.28.13.14";
            }
            else if (x >= 78.5 && x <= 80.5 && y >= 26.5 && y <= 28)
            {
                cameraNumber = 4;
                TypeCamera = 1;
                position = $"Hành lang kho MC";
                url = "172.28.13.13";
            }
            else if (x >= 76 && x <= 78 && y >= 38 && y <= 40)
            {
                cameraNumber = 3;
                TypeCamera = 1;
                position = $"Cửa SMT PD2";
                url = "172.28.13.12";
            }
            else if (x >= 79.6 && x <= 80.7 && y >= 70.5 && y <= 72.2)
            {
                cameraNumber = 2;
                TypeCamera = 1;
                position = $"Phòng phân tích";
                url = "172.28.13.11";
            }
            else if (x >= 41.5 && x <= 43.5 && y >= 26 && y <= 28)
            {
                cameraNumber = 1;
                TypeCamera = 1;
                position = $"Hành lang Locker nữ";
                url = "172.28.13.10";
            }
            else
            {
                Cursor.Current = Cursors.Default;
                url = null;
                lbName.Text = null;
                lbName.Text = null;
                tooltip.Hide(this);
            }
        }

        private void picMaps_MouseUp(object sender, MouseEventArgs e)
        {
            if (url == null)
            {
                return;
            }
            lbName.Text = null;
            lbName.Text = null;
            Form1 f1 = new Form1();
            f1.Show();
        }
        int indexSelected;
        private bool checkOpen = true;

        private void cbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkOpen = false;
            string itemSelect = cbCamera.SelectedItem.ToString();
            txtSearch.Text = itemSelect;
            indexSelected = allItems.IndexOf(itemSelect);
            if (indexSelected == 0)
            {
                xPercent = 43;
                yPercent = 27;
            }
            else if (indexSelected == 1)
            {
                xPercent = 79.5f;
                yPercent = 71;
            }
            else if (indexSelected == 2)
            {
                xPercent = 77;
                yPercent = 39;
            }
            else if (indexSelected == 3)
            {
                xPercent = 80;
                yPercent = 27;
            }
            else if (indexSelected == 4)
            {
                xPercent = 89;
                yPercent = 37;
            }
            else if (indexSelected == 5)
            {
                xPercent = 72.2f;
                yPercent = 26;
            }
            else if (indexSelected == 6)
            {
                xPercent = 78;
                yPercent = 92.5f;
            }
            else if (indexSelected == 7)
            {
                xPercent = 99;
                yPercent = 24;
            }
            else if (indexSelected == 8)
            {
                xPercent = 97.5f;
                yPercent = 23;
            }
            else if (indexSelected == 9)
            {
                xPercent = 97f;
                yPercent = 18;
            }
            else if (indexSelected == 10)
            {
                xPercent = 50.5f;
                yPercent = 58;
            }
            else if (indexSelected == 11)
            {
                xPercent = 48;
                yPercent = 73;
            }
            else if (indexSelected == 12)
            {
                xPercent = 53;
                yPercent = 25;
            }
            else if (indexSelected == 13)
            {
                xPercent = 57;
                yPercent = 76;
            }
            else if (indexSelected == 14)
            {
                xPercent = 82;
                yPercent = 72;
            }
            else if (indexSelected == 15)
            {
                xPercent = 36;
                yPercent = 59;
            }
            else if (indexSelected == 16)
            {
                xPercent = 32;
                yPercent = 31;
            }
            else if (indexSelected == 17)
            {
                xPercent = 31;
                yPercent = 29;
            }
            else if (indexSelected == 18)
            {
                xPercent = 42;
                yPercent = 14.5f;
            }
            else if (indexSelected == 19)
            {
                xPercent = 24.5f;
                yPercent = 14.5f;
            }
            else if (indexSelected == 20)
            {
                xPercent = 42;
                yPercent = 47;
            }
            else if (indexSelected == 21)
            {
                xPercent = 36;
                yPercent = 47;
            }
            else if (indexSelected == 22)
            {
                xPercent = 40;
                yPercent = 70;
            }
            else if (indexSelected == 23)
            {
                xPercent = 38;
                yPercent = 79;
            }
            else if (indexSelected == 24)
            {
                xPercent = 88;
                yPercent = 26;
            }
            else if (indexSelected == 25)
            {
                xPercent = 10;
                yPercent = 47;
            }
            else if (indexSelected == 26)
            {
                xPercent = 10;
                yPercent = 73;
            }
            else if (indexSelected == 27)
            {
                xPercent = 19;
                yPercent = 10;
            }
            else if (indexSelected == 28)
            {
                xPercent = 12;
                yPercent = 2;
            }
            else if (indexSelected == 29)
            {
                xPercent = 6;
                yPercent = 30;
            }
            else if (indexSelected == 30)
            {
                xPercent = 8;
                yPercent = 81;
            }
            else if (indexSelected == 31)
            {
                xPercent = 18;
                yPercent = 81;
            }
            else if (indexSelected == 32)//33
            {
                xPercent = 75;
                yPercent = 81;
            }
            else if (indexSelected == 33)//35
            {
                xPercent = 31;
                yPercent = 90;
            }
            else if (indexSelected == 34)
            {
                xPercent = 42.5f;
                yPercent = 90;
            }
            else if (indexSelected == 35)//37
            {
                xPercent = 44;
                yPercent = 91;
            }
            else if (indexSelected == 36)
            {
                xPercent = 62;
                yPercent = 39;
            }
            else if (indexSelected == 37)
            {
                xPercent = 46.5f;
                yPercent = 39;
            }
            else if (indexSelected == 38)//40
            {
                xPercent = 3;
                yPercent = 36;
            }
            else if (indexSelected == 39)//42
            {
                xPercent = 75;
                yPercent = 67.5f;
            }
            else if (indexSelected == 40)
            {
                xPercent = 65.5f;
                yPercent = 67;
            }
            else if (indexSelected == 41)
            {
                xPercent = 77;
                yPercent = 56;
            }
            else if (indexSelected == 42)
            {
                xPercent = 71.4f;
                yPercent = 39.7f;
            }
            else if (indexSelected == 43)//46
            {
                xPercent = 59.5f;
                yPercent = 45;
            }
            else if (indexSelected == 44)//48
            {
                xPercent = 56.5f;
                yPercent = 68;
            }
            else if (indexSelected == 45)//49
            {
                xPercent = 59.4f;
                yPercent = 82;
            }
            else if (indexSelected == 46)//52
            {
                xPercent = 47;
                yPercent = 27;
            }
            else if (indexSelected == 47)//54
            {
                xPercent = 86;
                yPercent = 31;
            }
            else if (indexSelected == 48)
            {
                xPercent = 84;
                yPercent = 39;
            }
            else if (indexSelected == 49)
            {
                xPercent = 82;
                yPercent = 26;
            }
            else if (indexSelected == 50)//57
            {
                xPercent = 78.4f;
                yPercent = 23.7f;
            }
            else if (indexSelected == 51)//58
            {
                xPercent = 64.5f;
                yPercent = 24;
            }
            else if (indexSelected == 52)
            {
                xPercent = 64.4f;
                yPercent = 20;
            }
            else if (indexSelected == 53)//60
            {
                xPercent = 58.5f;
                yPercent = 26;
            }
            else if (indexSelected == 54)
            {
                xPercent = 36;
                yPercent = 28.3f;
            }
            else if (indexSelected == 55)
            {
                xPercent = 32;
                yPercent = 36;
            }
            else if (indexSelected == 56)
            {
                xPercent = 30;
                yPercent = 41;
            }
            else if (indexSelected == 57)
            {
                xPercent = 23;
                yPercent = 40;
            }
            else if (indexSelected == 58)//65
            {
                xPercent = 23.4f;
                yPercent = 49;
            }
            else if (indexSelected == 59)
            {
                xPercent = 25.7f;
                yPercent = 45;
            }
            else if (indexSelected == 60)
            {
                xPercent = 18.7f;
                yPercent = 45;
            }
            else if (indexSelected == 61)
            {
                xPercent = 26;
                yPercent = 64;
            }
            else if (indexSelected == 62)//69
            {
                xPercent = 18.4f;
                yPercent = 63.4f;
            }
            else if (indexSelected == 63)
            {
                xPercent = 26;
                yPercent = 74;
            }
            else if (indexSelected == 64)//71
            {
                xPercent = 26.4f;
                yPercent = 70;
            }
            else if (indexSelected == 65)
            {
                xPercent = 19;
                yPercent = 70;
            }
            else if (indexSelected == 66)
            {
                xPercent = 21;
                yPercent = 75;
            }
            else if (indexSelected == 67)
            {
                xPercent = 13;
                yPercent = 72;
            }
            else if (indexSelected == 68)//75
            {
                xPercent = 10.5f;
                yPercent = 51;
            }
            else if (indexSelected == 69)
            {
                xPercent = 13;
                yPercent = 41;
            }
            else if (indexSelected == 70)//77
            {
                xPercent = 9.4f;
                yPercent = 34;
            }
            else if (indexSelected == 71)
            {
                xPercent = 16;
                yPercent = 32;
            }
            else if (indexSelected == 72)
            {
                xPercent = 91;
                yPercent = 78;
            }
            else if (indexSelected == 73)//80
            {
                xPercent = 97.7f;
                yPercent = 44;
            }
            else if (indexSelected == 74)//81
            {
                xPercent = 97.4f;
                yPercent = 39.3f;
            }
            else if (indexSelected == 75)
            {
                xPercent = 96;
                yPercent = 23;
            }
            else if (indexSelected == 76)
            {
                xPercent = 99;
                yPercent = 17;
            }
            else if (indexSelected == 77)
            {
                xPercent = 77;
                yPercent = 14;
            }
            else if (indexSelected == 78)//85
            {
                xPercent = 48;
                yPercent = 14.7f;
            }
            else if (indexSelected == 79)
            {
                xPercent = 44;
                yPercent = 14.5f;
            }
            else if (indexSelected == 80)
            {
                xPercent = 28;
                yPercent = 14;
            }
            else if (indexSelected == 81)//88
            {
                xPercent = 18;
                yPercent = 13.6f;
            }
            else if (indexSelected == 82)
            {
                xPercent = 21;
                yPercent = 3;
            }
            else if (indexSelected == 83)//90
            {
                xPercent = 8;
                yPercent = 11.5f;
            }
            else if (indexSelected == 84)
            {
                xPercent = 6;
                yPercent = 33;
            }
            else if (indexSelected == 85)
            {
                xPercent = 12;
                yPercent = 32;
            }
            else if (indexSelected == 86)
            {
                xPercent = 5;
                yPercent = 90;
            }
            else if (indexSelected == 87)
            {
                xPercent = 61;
                yPercent = 88;
            }
            else if (indexSelected == 88)//95
            {
                xPercent = 63.7f;
                yPercent = 88;
            }
            else if (indexSelected == 89)
            {
                xPercent = 53;
                yPercent = 28;
            }
            else if (indexSelected == 90)
            {
                xPercent = 54;
                yPercent = 34;
            }
            else if (indexSelected == 91)
            {
                xPercent = 54;
                yPercent = 36;
            }
            else if (indexSelected == 92)//99
            {
                xPercent = 59;
                yPercent = 60.5f;
            }
            else if (indexSelected == 93)
            {
                xPercent = 52;
                yPercent = 34;
            }
            else if (indexSelected == 94)//101
            {
                xPercent = 29;
                yPercent = 77.5f;
            }
            else if (indexSelected == 95)
            {
                xPercent = 54;
                yPercent = 61;
            }
            else if (indexSelected == 96)
            {
                xPercent = 28;
                yPercent = 18;
            }
            else if (indexSelected == 97)
            {
                xPercent = 20;
                yPercent = 17;
            }
            else if (indexSelected == 98)//105
            {
                xPercent = 30.4f;
                yPercent = 23.4f;
            }
            else if (indexSelected == 99)
            {
                xPercent = 81.6f;
                yPercent = 66;
            }
            else if (indexSelected == 100)
            {
                xPercent = 51.5f;
                yPercent = 40;
            }
            else
            {
                return;
            }
            //OpenCamera(itemSelect);

        }
        private void Option_Click(object sender, EventArgs e)
        {
            //// Get the clicked option
            //ToolStripMenuItem clickedOption = (ToolStripMenuItem)sender;

            //// Perform the desired action based on the clicked option
            //string optionText = clickedOption.Text;

            //for(int  item = 0; item < allItems.Count; item++)
            //{
            //    if(allItems[item] == optionText)
            //    {
            //        //OpenCamera(item);
            //        if(item == 0)
            //        {
            //            xPercent = 51;
            //            yPercent = 40;
            //            break;
            //        }
            //        else if( item == 1)
            //        {
            //            xPercent = 20;
            //            yPercent = 30;
            //            break;
            //        }
            //    }
            //}
            //Refresh();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = txtSearch.Text.Trim();
                var filter = allItems.Where(w => w.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                cbCamera.DroppedDown = false;
                // Clear the ComboBox items
                cbCamera.Items.Clear();
                // Add the retrieved elements to the ComboBox
                cbCamera.Items.AddRange(filter.ToArray());
                cbCamera.DroppedDown = true;
                Cursor.Current = Cursors.Default;


                //string searchText = txtSearch.Text.Trim();
                //if (string.IsNullOrEmpty(searchText)) return;
                //// Filter the items based on the search text (case-insensitive)
                //filteredItems = allItems.Where(item => item.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                //ContextMenuStrip menu = new ContextMenuStrip();
                //if (filteredItems.Count > 25)
                //{
                //    int count = 25;
                //    for (int i = 0; i < count; i++)
                //    {
                //        ToolStripMenuItem option = new ToolStripMenuItem(filteredItems[i]);
                //        menu.Items.Add(option);
                //    }
                //}
                //else
                //{
                //    for (int i = 0; i < filteredItems.Count; i++)
                //    {
                //        ToolStripMenuItem option = new ToolStripMenuItem(filteredItems[i]);
                //        menu.Items.Add(option);
                //    }
                //}
                //menu.Show(txtSearch, new Point(0, txtSearch.Height));

                //for (int i = 0; i < menu.Items.Count; i++)
                //{
                //    var item = menu.Items[i];
                //    item.Click += Option_Click;
                //}
            }

        }
        private void OpenCamera(int index)
        {

            if (index == 0)
            {
                url = "172.28.13.10";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 1)
            {
                url = "172.28.13.11";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 2)
            {
                url = "172.28.13.12";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 3)
            {
                url = "172.28.13.13";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 4)
            {
                url = "172.28.13.14";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 5)
            {
                url = "172.28.13.15";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 6)
            {
                url = "172.28.13.16";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 7)
            {
                url = "172.28.13.17";
                Form1 f1 = new Form1(url, 5);
                f1.Show();
            }
            else if (index == 8)
            {
                url = "172.28.13.18";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 9)
            {
                url = "172.28.13.19";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 10)
            {
                url = "172.28.13.20";
                Form1 f1 = new Form1(url, 3);
                f1.Show();
            }
            else if (index == 11)
            {
                url = "172.28.13.21";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 12)
            {
                url = "172.28.13.22";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 13)
            {
                url = "172.28.13.23";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 14)
            {
                url = "172.28.13.24";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 15)
            {
                url = "172.28.13.25";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 16)
            {
                url = "172.28.13.26";
                Form1 f1 = new Form1(url, 3);
                f1.Show();
            }
            else if (index == 17)
            {
                url = "172.28.13.27";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 18)
            {
                url = "172.28.13.28";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 19)
            {
                url = "172.28.13.29";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 20)
            {
                url = "172.28.13.30";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 21)
            {
                url = "172.28.13.31";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            //----------//
            else if (index == 22)
            {
                url = "172.28.13.32";
                Form1 f1 = new Form1(url, 4);
                f1.Show();
            }
            else if (index == 23)
            {
                url = "172.28.13.33";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 24)
            {
                url = "172.28.13.34";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 25)
            {
                url = "172.28.13.35";
                Form1 f1 = new Form1(url, 3);
                f1.Show();
            }
            else if (index == 26)
            {
                url = "172.28.13.36";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 27)
            {
                url = "172.28.13.37";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 28)
            {
                url = "172.28.13.38";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 29)
            {
                url = "172.28.13.39";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 30)
            {
                url = "172.28.13.40";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 31)
            {
                url = "172.28.13.41";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 32)
            {
                url = "172.28.13.42";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 33)
            {
                url = "172.28.13.44";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 34)
            {
                url = "172.28.13.45";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 35)
            {
                url = "172.28.13.46";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 36)
            {
                url = "172.28.13.47";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 37)
            {
                url = "172.28.13.48";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 38)
            {
                url = "172.28.13.49";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 39)
            {
                url = "172.28.13.51";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 40)
            {
                url = "172.28.13.52";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 41)
            {
                url = "172.28.13.53";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 42)
            {
                url = "172.28.13.54";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 43)
            {
                url = "172.28.13.55";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            //---
            else if (index == 44)
            {
                url = "172.28.13.57";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 45)
            {
                url = "172.28.13.58";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 46)
            {
                url = "172.28.13.61";
                Form1 f1 = new Form1(url, 1);
                f1.Show();
            }
            else if (index == 47)
            {
                url = "172.28.13.63";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 48)
            {
                url = "172.28.13.64";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 49)
            {
                url = "172.28.13.65";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 50)
            {
                url = "172.28.13.66";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 51)
            {
                url = "172.28.13.67";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 52)
            {
                url = "172.28.13.68";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 53)
            {
                url = "172.28.13.69";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 54)
            {
                url = "172.28.13.70";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 55)
            {
                url = "172.28.13.71";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 56)
            {
                url = "172.28.13.72";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 57)
            {
                url = "172.28.13.73";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 58)
            {
                url = "172.28.13.74";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 59)
            {
                url = "172.28.13.75";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 60)
            {
                url = "172.28.13.76";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 61)
            {
                url = "172.28.13.77";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 62)
            {
                url = "172.28.13.78";
                Form1 f1 = new Form1(url, 3);
                f1.Show();
            }
            else if (index == 63)
            {
                url = "172.28.13.79";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 64)
            {
                url = "172.28.13.80";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 65)
            {
                url = "172.28.13.81";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 66)
            {
                url = "172.28.13.82";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 67)
            {
                url = "172.28.13.83";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 68)
            {
                url = "172.28.13.84";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 69)
            {
                url = "172.28.13.85";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 70)
            {
                url = "172.28.13.86";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 71)
            {
                url = "172.28.13.87";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 72)
            {
                url = "172.28.13.88";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 73)
            {
                url = "172.28.13.89";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 74)
            {
                url = "172.28.13.90";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 75)
            {
                url = "172.28.13.91";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 76)
            {
                url = "172.28.13.92";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 77)
            {
                url = "172.28.13.93";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 78)
            {
                url = "172.28.13.94";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 79)
            {
                url = "172.28.13.95";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 80)
            {
                url = "172.28.13.96";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 81)
            {
                url = "172.28.13.97";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 82)
            {
                url = "172.28.13.98";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 83)
            {
                url = "172.28.13.99";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 84)
            {
                url = "172.28.13.100";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 85)
            {
                url = "172.28.13.101";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 86)
            {
                url = "172.28.13.102";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 87)
            {
                url = "172.28.13.103";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 88)
            {
                url = "172.28.13.104";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 89)
            {
                url = "172.28.13.105";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 90)
            {
                url = "172.28.13.106";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 91)
            {
                url = "172.28.13.107";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 92)
            {
                url = "172.28.13.108";
                Form1 f1 = new Form1(url, 3);
                f1.Show();
            }
            else if (index == 93)
            {
                url = "172.28.13.109";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 94)
            {
                url = "172.28.13.110";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 95)
            {
                url = "172.28.13.111";
                Form1 f1 = new Form1(url, 4);
                f1.Show();
            }
            else if (index == 96)
            {
                url = "172.28.13.112";
                Form1 f1 = new Form1(url, 2);
                f1.Show();
            }
            else if (index == 97)
            {
                url = "172.28.13.113";
                Form1 f1 = new Form1(url, 2);
                f1.Show();

            }
            else if (index == 98)
            {
                url = "172.28.13.114";
                Form1 f1 = new Form1(url, 4);
                f1.Show();

            }
            else if (index == 99)
            {
                url = "172.28.13.115";
                Form1 f1 = new Form1(url, 2);
                f1.Show();

            }
            else if (index == 100)
            {
                url = "172.28.13.116";
                Form1 f1 = new Form1(url, 2);
                f1.Show();

            }
        }

        private void picMaps_Paint(object sender, PaintEventArgs e)
        {
            // int x = ClientSize.Width / 2; // x-coordinate of the center
            //int y = ClientSize.Height / 2; // y-coordinate of the center
            int x = (int)(xPercent / 100 * ClientSize.Width);
            int y = (int)(yPercent / 100 * ClientSize.Height);
            if (x > 0 && y > 0)
            {
                // Calculate the top-left corner of the bounding rectangl
                int topLeftX = x - radius;
                int topLeftY = y - radius;

                // Calculate the diameter
                int diameter = radius * 2;
                Pen pen = new Pen(Color.Red, 3);
                // Draw the circle using the Graphics object
                e.Graphics.DrawEllipse(pen, topLeftX, topLeftY, diameter, diameter);
            }

        }

        private void zoomTimer_Tick(object sender, EventArgs e)
        {
            if (zoomingIn)
            {
                if (radius < 30)
                {
                    radius++;
                }
                else
                {
                    zoomingIn = false;
                    radius--;
                }
            }
            else
            {
                if (radius > 10)
                {
                    radius--;
                }
                else
                {
                    zoomingIn = true;
                    radius++;
                }
            }

            Refresh();  // Redraw the form
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (checkOpen == false)
            {
                OpenCamera(indexSelected);
            }
            else if (checkOpen == true) return;
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.SelectAll();
        }
    }
}
