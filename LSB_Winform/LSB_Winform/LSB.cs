using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSB_Winform
{
    class LSB
    {
        static bool end;
        public static Bitmap HideBitmap(String text, Bitmap bmp)
        {
            end = false;
            int charValue = 0;//chứa mã kí tự dạng int
            int zeros = 0;// thêm bit 0 để báo kết thúc chèn
            int charIndex = 0;// vị trị của kí tự đang ẩn trong mess
            long pixelIndex = 0;// lưu vị trị pixel đang xét trong ảnh
            int R = 0, G = 0, B = 0;
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);// tạo biến tạm lưu giá trị pixel tại vị trí (j,i)
                    R = pixel.R - pixel.R % 2;//làm sạch các bit LSB khi kết thúc không chèn thêm các bit này sẽ mang giá trị 0
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;
                    for (int n = 0; n < 3; n++) //duyệt qua mỗi thành phần pixel R,G,B
                    {
                        if (pixelIndex % 8 == 0) //nếu chuyển sang kí tự  mới xử lí , mỗi kí tự cần chèn 8bit vào 8 byte màu nên khi chuyển sang chèn kí tự mới sẽ bat đầu chèn từ vị trí pixel%8=0
                        {
                            if (end = true && zeros == 8)//khi hết thông điệp cần ẩn và tăng zeros se =8 -> ket thuc 
                            {
                                if (((pixelIndex - 1) % 3) < 2)
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));// update giá trị 
                                return bmp;
                            }
                            if (charIndex >= text.Length) 
                                end = true;                 //khi hết thông điệp cần chèn set end=true ngược lại chuyển qua kí tự kế tiếp bắt đầu chèn vào;
                            else charValue = text[charIndex++];
                        }
                        switch (pixelIndex % 3)         //thay doi byte màu nếu 
                        {
                            case 0:                     //byte màu R- có vị trí chia dư cho 3 =0
                                if (end == false)
                                {
                                    R += charValue % 2;
                                    charValue /= 2;
                                }
                                break;
                            case 1:                     //byte màu G- có vị trí chia dư cho 3 =1
                                if (end == false)
                                {
                                    G += charValue % 2;
                                    charValue /= 2;
                                }
                                break;
                            case 2:                     //byte màu B- có vị trí chia dư cho 3 =2
                                if (end == false)
                                {
                                    B += charValue % 2;
                                    charValue /= 2;
                                }
                                bmp.SetPixel(j, i, Color.FromArgb(R, G, B));// sét lại giá trị màu R/G/B sau khi sữa đổi lại
                                break;
                        }
                        pixelIndex++;
                        if (end == true)//khi thông điệp đã chèn xong, tăng zeros đến 8
                            zeros++;
                    }
                }
            }
            return bmp;
        }

        public static String ExtractBitmap(Bitmap bmp)
        {
            String text = String.Empty;
            int charValue = 0;                               //mã ascii của từng kí tự trong thông điệp cần trích xuất
            long colorUnitIndex = 0;                    //  để lấy 8 bit từ pixel, r tính đưa ra kí tự
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);           // lấy điểm ảnh tại ví trí (j,i)
                    for (int n = 0; n < 3; n++)             //lặp để lấy lần lượt R G B
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                charValue = charValue * 2 + pixel.R % 2;              // lấy LSB của R
                                break;
                            case 1:
                                charValue = charValue * 2 + pixel.G % 2;
                                break;
                            case 2:
                                charValue = charValue * 2 + pixel.B % 2;
                                break;
                        }
                        colorUnitIndex++;
                        if (colorUnitIndex % 8 == 0)        //đủ 8 bit , thì chuyển sang kí tự
                        {
                            charValue = reverseBits(charValue);       //quá trình chèn ngược với lấy , nên đổi Bit chiều ngược lại
                            if (charValue == 0)                  // khi char có giá trị  8bit 0-> thông điệp chèn đã hết, ta trả về thông diệp tìm đc
                                return text;
                            char c = (char)charValue;
                            text += c;
                        }
                    }
                }
            }
            return text;
        }

        public static int reverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }

            return result;
        }

    }

}