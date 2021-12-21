using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageProcessing
{
    class Processing
    {
        public Processing()
        {

        }
        public static bool ConvertToGray(Bitmap b)
        {
            for (int i=0;i<b.Width;i++)
                for(int j=0;j<b.Height;j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int gray = (byte)(.299 * r1 + .587 * g1 + .114 * b1);
                    r1 = gray;
                    g1 = gray;
                    b1 = gray;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));

                }
            return true;
        }

        public static bool MirrorImageH(Bitmap b, Bitmap a)
        {
            
            for (int i = 0; i < a.Width; i++)
                for (int j = 0; j < a.Height; j++)
                {
                    Color c1 = a.GetPixel(i, j);
                    //int width = a.Width;
                    //int height = a.Height;
                    b.SetPixel(a.Width - i - 1, j, c1);

                }
            return true;

        }

        public static bool MirrorImageV(Bitmap b, Bitmap a)
        {
            for (int i = 0; i < a.Width; i++)
                for (int j = 0; j < a.Height; j++)
                {
                    Color c1 = a.GetPixel(i, j);
                    int width = a.Width;
                    int height = a.Height;
                    b.SetPixel(i,height - j - 1, c1);

                }
            return true;

        }

        public static bool histogram(Bitmap b, Bitmap a)
        {
            int red, green, blue, gray;
            int[] img = new int[256];
            ConvertToGray(b);
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c = b.GetPixel(i, j);
                    red = c.R;
                    green = c.G;
                    blue = c.B;
                    gray = (byte)(.299 * red + .587 * green + .114 * blue);
                    img[gray] += 1;
                    if (img[gray] % 256 == 0)
                    {
                        a.SetPixel(gray, 255 - (img[gray] / 256), Color.FromArgb(0, 0, 0));
                    }
                }
            }
            return true;
        }

        public static bool brightness(Bitmap b, int n)
        {
            int red, blue, green;


            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c = b.GetPixel(i, j);
                    red = c.R;
                    green = c.G;
                    blue = c.B;

                    if (c.R + n > 255)
                    {
                        red = 255;
                    }

                    else if (c.R + n < 0)
                    {
                        red = 0;
                    }
                    else
                    {
                        red = c.R + n;
                    }


                    if (c.G + n > 255)
                    {
                        green = 255;
                    }

                    else if (c.G + n < 0)
                    {
                        green = 0;
                    }
                    else
                    {
                        green = c.G + n;
                    }


                    if (c.B + n > 255)
                    {
                        blue = 255;
                    }

                    else if (c.B + n < 0)
                    {
                        blue = 0;
                    }
                    else
                    {
                        blue = c.B + n;
                    }


                    b.SetPixel(i, j, Color.FromArgb(red, green, blue));

                }
            }
            return true;
        }


        public static bool negative(Bitmap b)
        {
            int red, green, blue;
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c = b.GetPixel(i, j);
                    red = c.R;
                    green = c.G;
                    blue = c.B;
                    b.SetPixel(i, j, Color.FromArgb(255 - red, 255 - green, 255 - blue));
                }
            }

            return true;
        }

      

        public static bool Contrast(Bitmap b, int n)
        {
            int red, blue, green;


            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c = b.GetPixel(i, j);
                    red = c.R;
                    green = c.G;
                    blue = c.B;

                    if (c.R * n > 255)
                    {
                        red = 255;
                    }

                    else if (c.R * n < 0)
                    {
                        red = 0;
                    }
                    else
                    {
                        red = c.R * n;
                    }


                    if (c.G * n > 255)
                    {
                        green = 255;
                    }

                    else if (c.G * n < 0)
                    {
                        green = 0;
                    }
                    else
                    {
                        green = c.G * n;
                    }


                    if (c.B * n > 255)
                    {
                        blue = 255;
                    }

                    else if (c.B * n < 0)
                    {
                        blue = 0;
                    }
                    else
                    {
                        blue = c.B * n;
                    }


                    b.SetPixel(i, j, Color.FromArgb(red, green, blue));

                }
            }
            return true;
        }

        public static bool rotate(Bitmap b, Bitmap a)
        {
            int red, green, blue;
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c = b.GetPixel(i, j);
                    red = c.R;
                    green = c.G;
                    blue = c.B;
                    a.SetPixel(b.Height - j - 1, i, Color.FromArgb(red, green, blue));
                }
            }

            return true;
        }

        public static bool Equalized(Bitmap b, Bitmap h, Bitmap a)
        {
            int red, green, blue, gray, gray1, numpixel;
            int[] cont = new int[256];
            int[] hequa = new int[256];
            float alpha;
            ConvertToGray(b);
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c = b.GetPixel(i, j);
                    red = c.R;
                    green = c.G;
                    blue = c.B;
                    gray = (byte)(.299 * red + .587 * green + .114 * blue);
                    cont[gray] = cont[gray] + 1;
                }
            }
            numpixel = b.Width * b.Height;
            alpha = (float)255 / numpixel;
            hequa[0] = (int)(alpha * cont[0]);
            for (int x = 1; x < 255; x++)
            {
                hequa[x] = (int)(hequa[x - 1] + alpha * cont[x]);
            }

            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c = b.GetPixel(i, j);
                    red = c.R;
                    green = c.G;
                    blue = c.B;
                    gray = (byte)(.299 * red + .587 * green + .114 * blue);
                    gray1 = hequa[gray];
                    a.SetPixel(i, j, Color.FromArgb(gray1, gray1, gray1));
                    cont[gray1] += 1;
                    if (cont[gray1] % 256 == 0)
                    {
                        h.SetPixel(gray, 255 - (cont[gray1] / 256), Color.FromArgb(gray, gray, gray));
                    }
                }
            }

            return true;
        }

        public static bool ZoomIn(Bitmap b, Bitmap h)
        {
            int red, green, blue;
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c = b.GetPixel(i, j);
                    red = c.R;
                    green = c.G;
                    blue = c.B;
                    h.SetPixel(2 * i, 2 * j, Color.FromArgb(red, blue, green));

                }
            }
            for (int i = 2; i < h.Width; i = i + 2)
            {
                for (int j = 2; j < h.Height; j = j + 2)
                {
                    Color a = h.GetPixel(i, j - 2);
                    Color c = h.GetPixel(i, j);
                    red = (c.R + a.R) / 2;
                    green = (c.G + a.R) / 2;
                    blue = (c.B + a.R) / 2;
                    h.SetPixel(i, j - 1, Color.FromArgb(red, blue, green));

                }
            }

            for (int i = 2; i < h.Width; i = i + 2)
            {
                for (int j = 0; j < h.Height; j++)
                {
                    Color a = h.GetPixel(i - 2, j);
                    Color c = h.GetPixel(i, j);
                    red = (int)((c.R + a.R) / 2);
                    green = (int)((c.G + a.R) / 2);
                    blue = (int)(c.B + a.R) / 2;
                    h.SetPixel(i - 1, j, Color.FromArgb(red, blue, green));

                }
            }


            return true;
        }

        public static bool ZoomOut(Bitmap b, Bitmap g, int a, int w)
        {
            int red = 0, green = 0, blue = 0, i = 0, j = 0, k, l = 0;
            while (l <= b.Height)
            {
                k = 0;

                while (k <= b.Width)
                {
                    red = 0;
                    green = 0;
                    blue = 0;

                    for (i = k; i < w; i++)
                    {
                        for (j = 0; j < a; j++)
                        {

                            Color c = b.GetPixel(i, j);
                            red = +c.R;
                            green = +c.G;
                            blue = +c.B;

                        }

                        k++;
                    }

                    g.SetPixel(k - w, l - a, Color.FromArgb((int)red / (a * w), (int)blue / (a * w), (int)green / (a * w)));
                    k++;
                }
                l = l + a;
            }
            return true;



        }
    }
}
