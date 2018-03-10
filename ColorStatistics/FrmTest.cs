using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace ColorStatistics
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        List<Statistics.MajorColor> MC;
        int PixelAmount = 0;

        private void CmdOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FilterIndex = 4;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Thumb.Image =  (Bitmap)Bitmap.FromFile(openFileDialog.FileName);
              
            }
        }
        public static Color IntToColor(int color)
        {
            int R = color & 255;
            int G = (color & 65280) / 256;
            int B = (color & 16711680) / 65536;
            return Color.FromArgb(255, R, G, B);
        }

        private void PicR_Click(object sender, EventArgs e)
        {

        }

        private void PicR_Paint(object sender, PaintEventArgs e)
        {
            if (MC != null)
            {
                e.Graphics.Clear(PicColors.BackColor);
                Font font = new Font("Arial", 9f);
                SolidBrush B = new SolidBrush(Color.Black);
                e.Graphics.DrawString("      Color        ", font, B, new PointF(0, 0));
                e.Graphics.DrawString("     Percentage      ", font, B, new PointF(120, 0));
                e.Graphics.DrawString("Amount", font, B, new PointF(250, 0));
                B.Dispose();
                for (int i = 0; i < MC.Count; i++)
                {
                    B = new SolidBrush(IntToColor(MC[i].Color));
                    e.Graphics.FillRectangle(B, new Rectangle(0, (i + 1) * 20, 100, 15));
                    e.Graphics.DrawString(((double)MC[i].Amount / PixelAmount).ToString(), font, B, new PointF(120, (i + 1) * 20 + 3));
                    e.Graphics.DrawString(MC[i].Amount.ToString(), font, B, new PointF(250, (i + 1) * 20 + 3));
                    B.Dispose();
                }
                font.Dispose();
            }
        }

        private void CmdDeal_Click(object sender, EventArgs e)
        {
           
            if (Thumb.Image !=null ) 
            {
                Stopwatch Sw = new Stopwatch();
                Sw.Start();
                MC = Statistics.PrincipalColorAnalysis((Bitmap)Thumb.Image,SliderColorAmount.Value, SliderDelta.Value);
                Sw.Stop();
                LblStatus.Text   = "Processing time: " + Sw.ElapsedMilliseconds.ToString() + " ms";
                PixelAmount = Thumb.Image.Width * Thumb.Image.Height;
                PicColors.Refresh();
            }
        }

        private void SliderColorAmount_Scroll(object sender, EventArgs e)
        {
            LblAmount.Text = SliderColorAmount.Value.ToString();
        }

        private void SliderDelta_Scroll(object sender, EventArgs e)
        {
            LblDelta.Text = SliderDelta.Value.ToString();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            CmdDeal_Click(sender,e);
        }

    }
}
