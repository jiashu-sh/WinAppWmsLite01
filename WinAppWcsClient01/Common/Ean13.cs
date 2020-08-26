using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Common
{
    class Ean13
    {
        private string getENA13Code(string Numbers12bit)
        {
            int c1 = 0;
            int c2 = 0;
            for (int i = 0; i < 11; i = i + 2)
            {
                c1 += int.Parse(Numbers12bit[i].ToString());
                c2 += int.Parse(Numbers12bit[i + 1].ToString());
            }
            int c3 = c1 + c2 * 3;
            c3 = c3 - c3 / 10 * 10;
            if (c3 == 0)
            {
                return Numbers12bit + 0;
            }
            else
            {
                int N = 10 - c3;
                return Numbers12bit + N;
            }
        }

        /// <summary>
        /// 将EAN13条形码按指定图形绘制到指定的绘制矩形中。 
        /// </summary>
        /// <param name="barCode">BarCode value.</param>
        /// <param name="g">Graphics where to draw.</param>
        /// <param name="drawBounds">Draw bounds.</param>
        public void Paint_EAN13(string Numbers12bit, Graphics g, Rectangle drawBounds)
        {
            string barCode = getENA13Code(Numbers12bit);
            char[] symbols = barCode.ToCharArray();
            //--- Validate barCode -------------------------------------------------------------------//
            if (barCode.Length != 13)
            {
                return;
            }
            foreach (char c in symbols)
            {
                if (!Char.IsDigit(c))
                {
                    return;
                }
            }
            //--- Check barcode checksum ------------------------//
            int checkSum = Convert.ToInt32(symbols[12].ToString());
            int calcSum = 0;
            bool one_three = true;
            for (int i = 0; i < 12; i++)
            {
                if (one_three)
                {
                    calcSum += (Convert.ToInt32(symbols[i].ToString()) * 1);
                    one_three = false;
                }
                else
                {
                    calcSum += (Convert.ToInt32(symbols[i].ToString()) * 3);
                    one_three = true;
                }
            }

            char[] calcSumChar = calcSum.ToString().ToCharArray();
            if (checkSum != 0 && checkSum != (10 - Convert.ToInt32(calcSumChar[calcSumChar.Length - 1].ToString())))
            {
                return;
            }
            //--------------------------------------------------//
            //---------------------------------------------------------------------------------------//
            Font font = new Font("Microsoft Sans Serif", 8);

            // Fill backround with white color
            //    g.Clear(Color.White);
            int lineWidth = 1;
            int x = drawBounds.X;
            // Paint human readable 1 system symbol code
            g.DrawString(symbols[0].ToString(), font, new SolidBrush(Color.Black), x, drawBounds.Y + drawBounds.Height - 16);
            x += 10;
            // Paint left 'guard bars', always same '101'
            g.DrawLine(new Pen(Color.Black, lineWidth), x, drawBounds.Y, x, drawBounds.Y + drawBounds.Height);
            x += lineWidth;
            g.DrawLine(new Pen(Color.White, lineWidth), x, drawBounds.Y, x, drawBounds.Y + drawBounds.Height);
            x += lineWidth;
            g.DrawLine(new Pen(Color.Black, lineWidth), x, drawBounds.Y, x, drawBounds.Y + drawBounds.Height);
            x += lineWidth;
            // First number of barcode specifies how to encode each character in the left-hand 
            // side of the barcode should be encoded.
            bool[] leftSideParity = new bool[6];
            switch (symbols[0])
            {
                case '0':
                    leftSideParity[0] = true; // Odd
                    leftSideParity[1] = true; // Odd
                    leftSideParity[2] = true; // Odd
                    leftSideParity[3] = true; // Odd
                    leftSideParity[4] = true; // Odd
                    leftSideParity[5] = true; // Odd
                    break;
                case '1':
                    leftSideParity[0] = true; // Odd
                    leftSideParity[1] = true; // Odd
                    leftSideParity[2] = false; // Even
                    leftSideParity[3] = true; // Odd
                    leftSideParity[4] = false; // Even
                    leftSideParity[5] = false; // Even
                    break;
                case '2':
                    leftSideParity[0] = true; // Odd
                    leftSideParity[1] = true; // Odd
                    leftSideParity[2] = false; // Even
                    leftSideParity[3] = false; // Even
                    leftSideParity[4] = true; // Odd
                    leftSideParity[5] = false; // Even
                    break;
                case '3':
                    leftSideParity[0] = true; // Odd
                    leftSideParity[1] = true; // Odd
                    leftSideParity[2] = false; // Even
                    leftSideParity[3] = false; // Even
                    leftSideParity[4] = false; // Even
                    leftSideParity[5] = true; // Odd
                    break;
                case '4':
                    leftSideParity[0] = true; // Odd
                    leftSideParity[1] = false; // Even
                    leftSideParity[2] = true; // Odd
                    leftSideParity[3] = true; // Odd
                    leftSideParity[4] = false; // Even
                    leftSideParity[5] = false; // Even
                    break;
                case '5':
                    leftSideParity[0] = true; // Odd
                    leftSideParity[1] = false; // Even
                    leftSideParity[2] = false; // Even
                    leftSideParity[3] = true; // Odd
                    leftSideParity[4] = true; // Odd
                    leftSideParity[5] = false; // Even
                    break;
                case '6':
                    leftSideParity[0] = true; // Odd
                    leftSideParity[1] = false; // Even
                    leftSideParity[2] = false; // Even
                    leftSideParity[3] = false; // Even
                    leftSideParity[4] = true; // Odd
                    leftSideParity[5] = true; // Odd
                    break;
                case '7':
                    leftSideParity[0] = true; // Odd
                    leftSideParity[1] = false; // Even
                    leftSideParity[2] = true; // Odd
                    leftSideParity[3] = false; // Even
                    leftSideParity[4] = true; // Odd
                    leftSideParity[5] = false; // Even
                    break;
                case '8':
                    leftSideParity[0] = true; // Odd
                    leftSideParity[1] = false; // Even
                    leftSideParity[2] = true; // Odd
                    leftSideParity[3] = false; // Even
                    leftSideParity[4] = false; // Even
                    leftSideParity[5] = true; // Odd
                    break;
                case '9':
                    leftSideParity[0] = true; // Odd
                    leftSideParity[1] = false; // Even
                    leftSideParity[2] = false; // Even
                    leftSideParity[3] = true; // Odd
                    leftSideParity[4] = false; // Even
                    leftSideParity[5] = true; // Odd
                    break;
            }
            // second number system digit + 5 symbol manufacter code
            string lines = "";
            for (int i = 0; i < 6; i++)
            {
                bool oddParity = leftSideParity[i];
                if (oddParity)
                {
                    switch (symbols[i + 1])
                    {
                        case '0':
                            lines += "0001101";
                            break;
                        case '1':
                            lines += "0011001";
                            break;
                        case '2':
                            lines += "0010011";
                            break;
                        case '3':
                            lines += "0111101";
                            break;
                        case '4':
                            lines += "0100011";
                            break;
                        case '5':
                            lines += "0110001";
                            break;
                        case '6':
                            lines += "0101111";
                            break;
                        case '7':
                            lines += "0111011";
                            break;
                        case '8':
                            lines += "0110111";
                            break;
                        case '9':
                            lines += "0001011";
                            break;
                    }
                }
                // Even parity
                else
                {
                    switch (symbols[i + 1])
                    {
                        case '0':
                            lines += "0100111";
                            break;
                        case '1':
                            lines += "0110011";
                            break;
                        case '2':
                            lines += "0011011";
                            break;
                        case '3':
                            lines += "0100001";
                            break;
                        case '4':
                            lines += "0011101";
                            break;
                        case '5':
                            lines += "0111001";
                            break;
                        case '6':
                            lines += "0000101";
                            break;
                        case '7':
                            lines += "0010001";
                            break;
                        case '8':
                            lines += "0001001";
                            break;
                        case '9':
                            lines += "0010111";
                            break;
                    }
                }
            }
            // Paint human readable left-side 6 symbol code
            g.DrawString(barCode.Substring(1, 6), font, new SolidBrush(Color.Black), x, drawBounds.Y + drawBounds.Height - 12);
            char[] xxx = lines.ToCharArray();
            for (int i = 0; i < xxx.Length; i++)
            {
                if (xxx[i] == '1')
                {
                    g.DrawLine(new Pen(Color.Black, lineWidth), x, drawBounds.Y, x, drawBounds.Y + drawBounds.Height - 12);
                }
                else
                {
                    g.DrawLine(new Pen(Color.White, lineWidth), x, drawBounds.Y, x, drawBounds.Y + drawBounds.Height - 12);
                }
                x += lineWidth;
            }

            // Paint center 'guard bars', always same '01010'
            g.DrawLine(new Pen(Color.White, lineWidth), x, drawBounds.Y, x, drawBounds.Y + drawBounds.Height);
            x += lineWidth;
            g.DrawLine(new Pen(Color.Black, lineWidth), x, drawBounds.Y, x, drawBounds.Y + drawBounds.Height);
            x += lineWidth;
            g.DrawLine(new Pen(Color.White, lineWidth), x, drawBounds.Y, x, drawBounds.Y + drawBounds.Height);
            x += lineWidth;
            g.DrawLine(new Pen(Color.Black, lineWidth), x, drawBounds.Y, x, drawBounds.Y + drawBounds.Height);
            x += lineWidth;
            g.DrawLine(new Pen(Color.White, lineWidth), x, drawBounds.Y, x, drawBounds.Y + drawBounds.Height);
            x += lineWidth;
            // 5 symbol product code + 1 symbol parity
            lines = "";
            for (int i = 7; i < 13; i++)
            {
                switch (symbols[i])
                {
                    case '0':
                        lines += "1110010";
                        break;
                    case '1':
                        lines += "1100110";
                        break;
                    case '2':
                        lines += "1101100";
                        break;
                    case '3':
                        lines += "1000010";
                        break;
                    case '4':
                        lines += "1011100";
                        break;
                    case '5':
                        lines += "1001110";
                        break;
                    case '6':
                        lines += "1010000";
                        break;
                    case '7':
                        lines += "1000100";
                        break;
                    case '8':
                        lines += "1001000";
                        break;
                    case '9':
                        lines += "1110100";
                        break;
                }
            }
            // Paint human readable left-side 6 symbol code
            g.DrawString(barCode.Substring(7, 6), font, new SolidBrush(Color.Black), x, drawBounds.Y + drawBounds.Height - 12);
            xxx = lines.ToCharArray();
            for (int i = 0; i < xxx.Length; i++)
            {
                if (xxx[i] == '1')
                {
                    g.DrawLine(new Pen(Color.Black, lineWidth), x, drawBounds.Y, x, drawBounds.Y + drawBounds.Height - 12);
                }
                else
                {
                    g.DrawLine(new Pen(Color.White, lineWidth), x, drawBounds.Y, x, drawBounds.Y + drawBounds.Height - 12);
                }
                x += lineWidth;
            }

            // Paint right 'guard bars', always same '101'
            g.DrawLine(new Pen(Color.Black, lineWidth), x, drawBounds.Y, x, drawBounds.Y + drawBounds.Height);
            x += lineWidth;
            g.DrawLine(new Pen(Color.White, lineWidth), x, drawBounds.Y, x, drawBounds.Y + drawBounds.Height);
            x += lineWidth;
            g.DrawLine(new Pen(Color.Black, lineWidth), x, drawBounds.Y, x, drawBounds.Y + drawBounds.Height);
        }

    }

}
