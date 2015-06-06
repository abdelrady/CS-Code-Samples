using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace BarcodeGenerator
{
    /// <summary>
    /// this enum include the different types of classes in 
    /// code 128
    /// </summary>
    public enum BarCodeClass
    {
        ClassA = 'a',
        ClassB = 'b',
        ClassC = 'c',
    };
    /// <summary>
    /// This class is used to Get the barcode equivelent to 
    /// an input string, using barcode 128 and with the 
    /// specified code class
    /// </summary>
    public class CSBarcode
    {
        //the string to be coded
        string EncodedString;
        //the class of the code 12
        BarCodeClass BClass = BarCodeClass.ClassC;
        //the white-black bars equivelent to each character
        //in the code
        #region Bars
        string[] Bars ={"bbsbbssbbss","bbssbbsbbss",
                "bbssbbssbbs","bssbssbbsss","bssbsssbbss", 
                "bsssbssbbss","bssbbssbsss","bssbbsssbss",
                "bsssbbssbss","bbssbssbsss","bbssbsssbss",
                "bbsssbssbss","bsbbssbbbss","bssbbsbbbss",
                "bssbbssbbbs","bsbbbssbbss","bssbbbsbbss",
                "bssbbbssbbs","bbssbbbssbs","bbssbsbbbss",
                "bbssbssbbbs","bbsbbbssbss","bbssbbbsbss",
                "bbbsbbsbbbs","bbbsbssbbss","bbbssbsbbss",
                "bbbssbssbbs","bbbsbbssbss","bbbssbbsbss",
                "bbbssbbssbs","bbsbbsbbsss","bbsbbsssbbs",
                "bbsssbbsbbs","bsbsssbbsss","bsssbsbbsss",
                "bsssbsssbbs","bsbbsssbsss","bsssbbsbsss",
                "bsssbbsssbs","bbsbsssbsss","bbsssbsbsss",
                "bbsssbsssbs","bsbbsbbbsss","bsbbsssbbbs",
                "bsssbbsbbbs","bsbbbsbbsss","bsbbbsssbbs",
                "bsssbbbsbbs","bbbsbbbsbbs","bbsbsssbbbs",
                "bbsssbsbbbs","bbsbbbsbsss","bbsbbbsssbs",
                "bbsbbbsbbbs","bbbsbsbbsss","bbbsbsssbbs",
                "bbbsssbsbbs","bbbsbbsbsss","bbbsbbsssbs",
                "bbbsssbbsbs","bbbsbbbbsbs","bbssbssssbs",
                "bbbbsssbsbs","bsbssbbssss","bsbssssbbss",
                "bssbsbbssss","bssbssssbbs","bssssbsbbss",
                "bssssbssbbs","bsbbssbssss","bsbbssssbss",
                "bssbbsbssss","bssbbssssbs","bssssbbsbss",
                "bssssbbssbs","bbssssbssbs","bbssbsbssss",
                "bbbbsbbbsbs","bbssssbsbss","bsssbbbbsbs",
                "bsbssbbbbss","bssbsbbbbss","bssbssbbbbs",
                "bsbbbbssbss","bssbbbbsbss","bssbbbbssbs",
                "bbbbsbssbss","bbbbssbsbss","bbbbssbssbs",
                "bbsbbsbbbbs","bbsbbbbsbbs","bbbbsbbsbbs",
                "bsbsbbbbsss","bsbsssbbbbs","bsssbsbbbbs",
                "bsbbbbsbsss","bsbbbbsssbs","bbbbsbsbsss",
                "bbbbsbsssbs","bsbbbsbbbbs","bsbbbbsbbbs",
                "bbbsbsbbbbs","bbbbsbsbbbs","bbsbssssbss",
                "bbsbssbssss","bbsbssbbbss","bbsssbbbsbsbb"};
        #endregion
        #region BarcodeBChars
        char[] BarcodeBChars ={  (char)32 , '!' ,
        '"' ,'#' ,'$' ,'%' ,'&','\'','(' ,')' ,'*' ,
        '+' ,',' ,'-' ,'.' ,'/' ,'0' ,'1' ,'2' ,
        '3' ,'4' ,'5' ,'6' ,'7' ,'8' ,'9' ,':' ,
        ';' ,'<' ,'=' ,'>' ,'?' ,'@' ,'A' ,
        'B' ,'C' ,'D' ,'E' ,'F' ,'G' ,'H' ,'I' ,
        'J' ,'K' ,'L' ,'M' ,'N' ,'O' ,'P' ,'Q' ,
        'R' ,'S' ,'T' ,'U' ,'V' ,'W' ,'X' ,'Y' ,
        'Z' ,'[' ,'\\' ,']','^' ,'_' ,'`' ,'a' ,
        'b' ,'c' ,'d' ,'e' ,'f' ,'g' ,'h' ,'i',
        'j' ,'k' ,'l' ,'m' ,'n' ,'o' ,'p' ,'q' ,
        'r' ,'s' ,'t' ,'u' ,'v' ,'w' ,'x' ,'y' ,
        'z' ,'{' ,'|' ,'}' ,'~' ,(char)Keys.Delete};
        #endregion
        #region BarcodeAChars
        char[] BarcodeAChars ={ (char)32 , '!' ,
        '"' ,'#' ,'$' ,'%' ,'&','\'','(' ,')' ,'*' ,
        '+' ,',' ,'-' ,'.' ,'/' ,'0' ,'1' ,'2' ,
        '3' ,'4' ,'5' ,'6' ,'7' ,'8' ,'9' ,':' ,
        ';' ,'<' ,'=' ,'>' ,'?' ,'@' ,'A' ,
        'B' ,'C' ,'D' ,'E' ,'F' ,'G' ,'H' ,'I' ,
        'J' ,'K' ,'L' ,'M' ,'N' ,'O' ,'P' ,'Q' ,
        'R' ,'S' ,'T' ,'U' ,'V' ,'W' ,'X' ,'Y' ,
        'Z' ,'[' ,'\\' ,']','^' ,'_',(char)0,(char)1,
        (char)2,(char)3,(char)4,(char)5,
        (char)6,(char)7,(char)8,(char)9,
        (char)10,(char)11,(char)12,(char)13,
        (char)14,(char)15,(char)16,(char)17,
        (char)18,(char)19,(char)20,(char)21,
        (char)22,(char)23,(char)24,(char)25,
        (char)26,(char)27,(char)28,(char)29,
        (char)30,(char)31};
        #endregion
        static char CharToSearchFor;
        enum CommonSpecialSymbols
        {
            FNC1 = 102,
            StartA = 103,
            StartB = 104,
            StartC = 105,
            Stop = 106
        };
        enum ClassASpecialSymbols
        {
            FNC3 = 96,
            FNC2 = 97,
            Shift = 98,
            SwichCodeC = 99,
            SwichCodeB = 100,
            FNC4 = 101
        };
        enum ClassBSpecialSymbols
        {
            FNC3 = 96,
            FNC2 = 97,
            Shift = 98,
            SwichCodeC = 99,
            FNC4 = 100,
            SwichCodeA = 101
        };
        int x,  //handles the x position in the image
            y1, //handles the y position from which to start drawing
            y2; //handles the y position in which drawing will end
        Bitmap Barcode; //the bitmap to handle the resulted barcode image
        int ImageSize = 0; //the image width
        public CSBarcode()
        {
            y1 = 0;
            y2 = 30;
            x = 0;
        }
        //-------------------------------------------------
        /// <summary>
        /// this function is implemented to specify the match criteria 
        /// that used in the Array.Find() function 
        /// </summary>
        /// <param name="ch">the array character to 
        /// apply the match criteria on it</param>
        /// <returns>true if the current character is equal
        /// to the previously set variable (CharToSearchFor)
        /// false if not</returns>
        private static bool SearchArray(char ch)
        {
            if (ch == CharToSearchFor)
                return true;
            else
                return false;
        }
        //-------------------------------------------------
        /// <summary>
        /// checks if the string provided in the class constructor
        /// belongs to the specified character set or not
        /// </summary>
        /// <returns>true if the string is compatable to the character set</returns>
        public bool IsValidInputString(string Input,
            BarCodeClass CodeClass)
        {
            if (CodeClass == BarCodeClass.ClassC)
            {
                foreach (char ch in Input)
                {
                    if (!char.IsDigit(ch))
                        return false;
                }
            }
            else if (CodeClass == BarCodeClass.ClassB)
            {
                foreach (char ch in Input)
                {
                    CharToSearchFor = ch;
                    if (!Array.Exists(BarcodeBChars,
                        SearchArray))
                        return false;
                }
            }
            else
            {
                foreach (char ch in Input)
                {
                    CharToSearchFor = ch;
                    if (!Array.Exists(BarcodeAChars,
                        SearchArray))
                        return false;
                }
            }
            return true;
        }
        //-------------------------------------------------
        public Image GetBarCode(string Input,BarCodeClass CodeClass,int ImageHight)
        {
            if (!IsValidInputString(Input,CodeClass))
                return null;
            EncodedString = Input;
            BClass = CodeClass;
            y2 = ImageHight;
            //set the size of the image depending on the character set
            switch (BClass) //check the character set
            {
                case BarCodeClass.ClassA:
                    {
                        ImageSize = (EncodedString.Length + 2) * 11 + 13;
                        CodeA(EncodedString);
                    }
                    break;
                case BarCodeClass.ClassB:
                    {
                        ImageSize = (EncodedString.Length + 2) * 11 + 13;
                        CodeB(EncodedString);
                    }
                    break;
                case BarCodeClass.ClassC:
                    {
                        EncodedString = (EncodedString.Length % 2 == 0) ? EncodedString : "0" + EncodedString;
                        ImageSize = (EncodedString.Length / 2 + 2) * 11 + 13;
                        CodeC(EncodedString);
                    }
                    break;
            }
            return Barcode;
        }
        //-----------------------------------------------------
        void CodeC(string p)
        {
            //initialize the image
            Barcode = new Bitmap(ImageSize, 30);
            int num,        //the current 2-digits
                sum = (int)CommonSpecialSymbols.StartC;  //the ckeck sum
            drawchar(sum);
            for (int i = 0; i < p.Length; i += 2)
            {
                num = int.Parse(p.Substring(i, 2));
                sum += num * ((i + 2) / 2);
                drawchar(num);
            }
            int rem = sum % 103;
            drawchar(rem);
            drawchar((int)CommonSpecialSymbols.Stop);
            for (int v = x; v < ImageSize; v++)
            {
                DrawLine(v, y1, y2, Color.White);
            }
        }
        //-----------------------------------------------------
        void CodeA(string p)
        {
            //initialize the image
            Barcode = new Bitmap(ImageSize, 30);
            int num,        //the current 2-digits
                sum = (int)CommonSpecialSymbols.StartA;  //the ckeck sum
            drawchar(sum);
            for (int i = 0; i < p.Length; i++)
            {
                CharToSearchFor = p[i];
                num = Array.IndexOf(BarcodeAChars,
                    CharToSearchFor);
                drawchar(num);
                sum += num * (i + 1);
            }
            int rem = sum % 103;
            drawchar(rem);
            drawchar((int)CommonSpecialSymbols.Stop);
            for (int v = x; v < ImageSize; v++)
            {
                DrawLine(v, y1, y2, Color.White);
            }
        }
        //-----------------------------------------------------
        void CodeB(string p)
        {
            //initialize the image
            Barcode = new Bitmap(ImageSize, 30);
            int num,        //the current 2-digits
                sum = (int)CommonSpecialSymbols.StartB;  //the ckeck sum
            drawchar(sum);
            for (int i = 0; i < p.Length; i++)
            {
                CharToSearchFor = p[i];
                num = Array.IndexOf(BarcodeBChars, CharToSearchFor);
                drawchar(num);
                sum += num * (i + 1);
            }
            int rem = sum % 103;
            drawchar(rem);
            drawchar((int)CommonSpecialSymbols.Stop);
            for (int v = x; v < ImageSize; v++)
            {
                DrawLine(v, y1, y2, Color.White);
            }
        }
        //-----------------------------------------------------
        void drawchar(int rem)
        {
            string str = Bars[rem];
            foreach (char ch in str)
            {
                if (ch == 'b')
                {
                    DrawLine(x, y1, y2, Color.Black);
                }
                else
                {
                    DrawLine(x, y1, y2, Color.White);
                }
                x++;
            }
        }
        //-----------------------------------------------------
        void DrawLine(int x, int y1, int y2,
             Color col)
        {
            for (int i = y1; i < y2; i++)
            {
                Barcode.SetPixel(x, i, col);
            }
        }
        //-------------------------------------------------
    }
}
