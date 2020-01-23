using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IdGenerator
{
    class Print
    {
        public static void setCard(XGraphics gfx, int cardNumber, String color, String imageBoxRound , ModelStudent obj , String themePath)
        {


            // Settings for width and height , font and size 
            double labelValueY = 110;
            double labelValueX = 95;
            double labelValueX2 = 385;
            string lableFontStatic = "Comic Sans MS";
            string lableFontDynamic = "Calibri (Body)";
            double fontStaticSize = 6;
            double fontDynamicSize = 9;
            double constantGapPictureAndWords = 30;
            double constantYAxisIncrementPerCard = 300;

            
            XImage ximageTheme = XImage.FromFile(themePath);
            // assign new numbers based on card number

            
            if (ximageTheme.Size.Width < 340)
            {
                System.Windows.Forms.MessageBox.Show("Theme image width  is too small");
                return;
            }
            else if (ximageTheme.Size.Width >= 360)
            {
                System.Windows.Forms.MessageBox.Show("Theme image width is too much");
                return;
            }
            else if (ximageTheme.Size.Height < 220)
            {
                System.Windows.Forms.MessageBox.Show("Theme image Height  is too small");
                return;
            }
            else if (ximageTheme.Size.Height >= 240)
            {
                System.Windows.Forms.MessageBox.Show("Theme image Height is too much");
                return;
            }
            ximageTheme.Interpolate = false;
            if(cardNumber == 1){ 
                gfx.DrawImage(ximageTheme, new XPoint(labelValueX - 60, labelValueY - 80 )); 
            }
            else if (cardNumber == 2)
            {
                labelValueX = labelValueX2; 
                gfx.DrawImage(ximageTheme, new XPoint(labelValueX2 - 60 , labelValueY - 80));
            }
            else if (cardNumber == 3)
            {
                labelValueY = (1 * constantYAxisIncrementPerCard);
                gfx.DrawImage(ximageTheme, new XPoint(labelValueX - 60, labelValueY - 80));
            }
            else if (cardNumber == 4)
            {
                labelValueY = (1 * constantYAxisIncrementPerCard);
                labelValueX = labelValueX2;
                gfx.DrawImage(ximageTheme, new XPoint(labelValueX2 - 60, labelValueY - 80));
            }
            else if (cardNumber == 5)
            {
                labelValueY = (2 * constantYAxisIncrementPerCard) - 110;
                gfx.DrawImage(ximageTheme, new XPoint(labelValueX - 60, labelValueY - 80));
            }
            else if (cardNumber == 6)
            {
                labelValueY = (2 * constantYAxisIncrementPerCard) - 110;
                labelValueX = labelValueX2;
                gfx.DrawImage(ximageTheme, new XPoint(labelValueX2 - 60, labelValueY - 80));

            }
            else if (cardNumber == 7)
            {
                labelValueY = (3 * constantYAxisIncrementPerCard) - 220;
                gfx.DrawImage(ximageTheme, new XPoint(labelValueX - 60, labelValueY - 80));
            }
            else if (cardNumber == 8)
            {
                labelValueY = (3 * constantYAxisIncrementPerCard) - 220;
                labelValueX = labelValueX2;
                gfx.DrawImage(ximageTheme, new XPoint(labelValueX2 - 60, labelValueY - 80));
            }
            
            // set image frame 
            if (imageBoxRound.Equals("boxedblue.png"))
            {
                XImage ximageBackground;
                ximageBackground = XImage.FromGdiPlusImage(Properties.Resources.boxedblue);
                gfx.DrawImage(ximageBackground, labelValueX - 50, labelValueY - 9, 75, 75);
            }
            else if (imageBoxRound.Equals("boxedgreen.png"))
            {
                XImage ximageBackground;
                ximageBackground = XImage.FromGdiPlusImage(Properties.Resources.boxedgreen);
                gfx.DrawImage(ximageBackground, labelValueX - 50, labelValueY - 9, 75, 75);
            }
            else if (imageBoxRound.Equals("boxedorange.png"))
            {
                XImage ximageBackground;
                ximageBackground = XImage.FromGdiPlusImage(Properties.Resources.boxedorange);
                gfx.DrawImage(ximageBackground, labelValueX - 50, labelValueY - 9, 75, 75);
            }
            else if (imageBoxRound.Equals("boxedred.png"))
            {
                XImage ximageBackground;
                ximageBackground = XImage.FromGdiPlusImage(Properties.Resources.boxedred);
                gfx.DrawImage(ximageBackground, labelValueX - 50, labelValueY - 9, 75, 75);
            }
            else if (imageBoxRound.Equals("roundblue.png"))
            {
                XImage ximageBackground;
                ximageBackground = XImage.FromGdiPlusImage(Properties.Resources.roundblue);
                gfx.DrawImage(ximageBackground, labelValueX - 50, labelValueY - 9, 75, 75);
            } 
            else if (imageBoxRound.Equals("roundgreen.png"))
            {
                XImage ximageBackground;
                ximageBackground = XImage.FromGdiPlusImage(Properties.Resources.roundgreen);
                gfx.DrawImage(ximageBackground, labelValueX - 50, labelValueY - 9, 75, 75);
            }
            else if (imageBoxRound.Equals("roundorange.png"))
            {
                XImage ximageBackground;
                ximageBackground = XImage.FromGdiPlusImage(Properties.Resources.roundorange);
                gfx.DrawImage(ximageBackground, labelValueX - 50, labelValueY - 9, 75, 75);
            } 
           /* else if (imageBoxRound.Equals("roundred.png"))
            {
                XImage ximageBackground;
                ximageBackground = XImage.FromGdiPlusImage(Properties.Resources.roundred);
                gfx.DrawImage(ximageBackground, labelValueX - 50, labelValueY - 9, 75, 75);
            } */

            XImage ximage;
            if (File.Exists(obj.studentImagePath))
            {
                ximage = XImage.FromFile(obj.studentImagePath);
                
            }
            else { 
                ximage = XImage.FromGdiPlusImage(Properties.Resources.android_contact);
            }
            gfx.DrawImage(ximage, labelValueX - 45, labelValueY - 3, 62, 60);

            // name
            XFont fontNameLabel = new XFont(lableFontStatic, fontStaticSize, XFontStyle.BoldItalic);
            if (color.Equals("orange"))
            {
                gfx.DrawString("Name :", fontNameLabel, XBrushes.DarkOrange, labelValueX + constantGapPictureAndWords, labelValueY);
            }
            else if (color.Equals("blue"))
            {
                gfx.DrawString("Name :" , fontNameLabel, XBrushes.Blue, labelValueX + constantGapPictureAndWords, labelValueY);
            }
            else if (color.Equals("red"))
            {
                gfx.DrawString("Name :" , fontNameLabel, XBrushes.DarkRed, labelValueX + constantGapPictureAndWords, labelValueY);
            }
            else if (color.Equals("green"))
            {
                gfx.DrawString("Name :", fontNameLabel, XBrushes.Green, labelValueX + constantGapPictureAndWords, labelValueY);
            }

            XFont fontNameString = new XFont(lableFontDynamic, fontDynamicSize, XFontStyle.Bold);
            gfx.DrawString(obj.fullName, fontNameString, XBrushes.Black, labelValueX + constantGapPictureAndWords, labelValueY + 8);

            // DOB
            XFont fontDOBLabel = new XFont(lableFontStatic, fontStaticSize, XFontStyle.BoldItalic);
            if (color.Equals("orange"))
            {
                gfx.DrawString("Date Of Birth :", fontNameLabel, XBrushes.DarkOrange, labelValueX + constantGapPictureAndWords, labelValueY + 18);
            }
            else if (color.Equals("red"))
            {
                gfx.DrawString("Date Of Birth :", fontNameLabel, XBrushes.DarkRed, labelValueX + constantGapPictureAndWords, labelValueY + 18);
            }
            else if (color.Equals("green"))
            {
                gfx.DrawString("Date Of Birth :", fontNameLabel, XBrushes.Green, labelValueX + constantGapPictureAndWords, labelValueY + 18);
            }
            else
            {
                gfx.DrawString("Date Of Birth :", fontNameLabel, XBrushes.Blue, labelValueX + constantGapPictureAndWords, labelValueY + 18);
            }



            XFont fontDOBString = new XFont(lableFontDynamic, fontDynamicSize, XFontStyle.Bold);
            gfx.DrawString(obj.DOB, fontDOBString, XBrushes.Black, labelValueX + constantGapPictureAndWords, labelValueY + 28);


            // National Id
            XFont fontNationalIdLabel = new XFont(lableFontStatic, fontStaticSize, XFontStyle.BoldItalic);
            if (color.Equals("orange"))
            {
                gfx.DrawString("SRN :", fontNameLabel, XBrushes.DarkOrange, labelValueX + constantGapPictureAndWords, labelValueY + 38);
            }
            else if (color.Equals("red"))
            {
                gfx.DrawString("SRN :", fontNameLabel, XBrushes.DarkRed, labelValueX + constantGapPictureAndWords, labelValueY + 38);
            }
            else if (color.Equals("green"))
            {
                gfx.DrawString("SRN :", fontNameLabel, XBrushes.Green, labelValueX + constantGapPictureAndWords, labelValueY + 38);
            }
            else
            {
                gfx.DrawString("SRN :", fontNameLabel, XBrushes.Blue, labelValueX + constantGapPictureAndWords, labelValueY + 38);
            }


            XFont fontNationalIdString = new XFont(lableFontDynamic, fontDynamicSize, XFontStyle.Bold);
            gfx.DrawString( obj.nationalId , fontNationalIdString, XBrushes.Black, labelValueX + constantGapPictureAndWords, labelValueY + 48);


        }
    }
}
