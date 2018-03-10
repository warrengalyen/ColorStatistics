using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ColorStatistics
{
    //'*****************************************************************************************
    //'**    开发日期 ：  2013-6-21
    //'**    作    者 ：  laviewpbt
    //'**    联系方式：   33184777
    //'**    修改日期 ：  2013-6-21
    //'**    版    本 ：  Version 1.1.1
    //'**    转载请不要删除以上信息
    //'****************************************************************************************

    static unsafe class Statistics
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct MajorColor : IComparable<MajorColor>
        {
            internal int Color;
            internal int Amount;

            public MajorColor(int Color, int Amount)
            {
                this.Color = Color;
                this.Amount = Amount;
            }

            public int CompareTo(MajorColor obj)
            {
                return this.Amount.CompareTo(obj.Amount);
            }
        }

        // http://www.coolphptools.com/color_extract
        // http://www.wookmark.com/image/268753/30-inspiring-examples-of-levitation-photography-inspirationfeed-com
        public static List<MajorColor> PrincipalColorAnalysis(Bitmap Bmp, int PCAAmount, int Delta = 24)
        {
            List<MajorColor> MC = new List<MajorColor>();

            int X, Y, Width, Height, Stride, Index, TotalColorAmount = 0;
            int HalfDelta;
            byte* Pointer, Scan0;
            BitmapData BmpData = Bmp.LockBits(new Rectangle(0, 0, Bmp.Width, Bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            Height = Bmp.Height; Width = Bmp.Width; Stride = BmpData.Stride; Scan0 = (byte*)BmpData.Scan0;

            int[] Table = new int[256 * 256 * 256];
            int[] NonZero = new int[Width * Height];
            int[] Map = new int[256];

            if (Delta > 2)
            {
                HalfDelta = Delta / 2 - 1;
            }
            else
            {
                HalfDelta = 0;
            }

            for (Y = 0; Y < 256; Y++)
            {
                Map[Y] = ((Y + HalfDelta) / Delta) * Delta;
                if (Map[Y] > 255) Map[Y] = 255;
            }
            for (Y = 0; Y < Height; Y++)
            {
                Pointer = Scan0 + Stride * Y;
                for (X = 0; X < Width; X++)
                {
                    Index = (Map[*Pointer] << 16) + (Map[*(Pointer + 1)] << 8) + Map[*(Pointer + 2)];
                    if (Table[Index] == 0)                  //      No color has ever appeared
                    {
                        NonZero[TotalColorAmount] = Index;  //      The location of the color is recorded and the color is recorded.
                        TotalColorAmount++;                 //      Total number of colors +1
                    }
                    Table[Index]++;                         //      The number of corresponding colors plus 1
                    Pointer += 3;                           //      Move to the next pixel
                }
            }
            MajorColor[] Result = new MajorColor[TotalColorAmount];
            for (Y = 0; Y < TotalColorAmount; Y++)
            {
                Result[Y].Amount = Table[NonZero[Y]];
                Result[Y].Color = NonZero[Y];
            }
            Array.Sort(Result);                             // The sort algorithm that the system takes is faster than the usual one.
            Array.Reverse(Result);

            for (Y = 0; Y < PCAAmount; Y++)
                MC.Add(new MajorColor(Result[Y].Color, Result[Y].Amount));
            Bmp.UnlockBits(BmpData);
            GC.Collect();                                   // Immediately release the allocated 64MB memory
            return MC;
        }
    }
}
