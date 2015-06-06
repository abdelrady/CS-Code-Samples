using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Diagnostics;

/// <summary>
/// Draws random shapes on a form.
/// </summary>
public class DrawShapes
{
    #region Fields
    
    private Bitmap backupBitmap; // The bitmap to use for repaints
    private Form mainForm;      // The form that will be drawn on
    private ShapeType shapeType = ShapeType.Random; // The type of shape to draw

    #endregion

    #region Properties

    public Bitmap BackupBitmap
    {
        get { return backupBitmap; }
    }

    #endregion

    #region ShapeType Enum
    public enum ShapeType
    {
        Circles, Squares, Text, Random
    }
    #endregion


    #region Constructors
    /// <summary>
    /// Initialises the DrawShapes class.
    /// </summary>
    /// <param name="form">A valid form on which to draw the shapes.</param>
    /// <param name="shape">The type of shape to draw, as a DrawShapes.ShapeType enum value.</param>
    public DrawShapes(Form form, ShapeType shape) 
    {
        mainForm = form;
        shapeType = shape;
        Initialise();
    }
    /// <summary>
    /// Initialises the DrawShapes class.
    /// </summary>
    /// <param name="form">A valid form on which to draw the shapes.</param>
    /// <param name="shape">The type of shape to draw, as a string corresponding to one of the DrawShapes.ShapeType names.</param>
    public DrawShapes(Form form, string shape)
    {
        mainForm = form;
        if(!String.IsNullOrEmpty(shape) && Enum.IsDefined(typeof(ShapeType), shape))
        {
            shapeType = (ShapeType)Enum.Parse(typeof(ShapeType), shape);
        }
        Initialise();
    }
    #endregion

    #region Initialisation
    /// <summary>
    /// Sets the background colour of the form and creates a 
    /// blank bitmap the same size and colour as the form, which can
    /// be used when the form is repainted. When called after
    /// initialisation, this method will clear the form.
    /// </summary>
    public void Initialise()
    {
        Color backColour = GetRandomColor();

        backupBitmap = new Bitmap(
            mainForm.ClientRectangle.Width,
            mainForm.ClientRectangle.Height,
            System.Drawing.Imaging.PixelFormat.Format24bppRgb);

        using (Graphics objGraphics = Graphics.FromImage(backupBitmap))
        {
            objGraphics.Clear(backColour);
            mainForm.BackColor = backColour;
        }
    }
    #endregion

    #region Drawing methods

    /// <summary>
    /// Draws a shape or string based on the Shape setting.
    /// </summary>
    public void Draw()
    {
        Draw("");
    }

    /// <summary>
    /// Draws a string using a random font, colour and location.
    /// </summary>
    /// <param name="str">The string to draw.</param>
    public void Draw(string str)
    {
        switch (shapeType)
        {
            case ShapeType.Text:
                if (!String.IsNullOrEmpty(str))
                    DrawText(str);
                else
                    DrawText("abc");
                break;

            case ShapeType.Random:
                DrawRandom();
                break;
            
            default:
                DrawShape(shapeType);
                break;
        }
    }

    /// <summary>
    /// Internal implementation to draw a text string 
    /// using a random font, colour and location.
    /// </summary>
    /// <param name="str">The string to be drawn.</param>
    private void DrawText(string str)
    {
        Font font;
        Brush colourBrush;
        int intFontSize, X, Y;
        SizeF sizeText;

        Random randomGenerator = new Random();

        // Create a graphics object using the memory bitmap and one for the form.
        using(Graphics objGraphics = Graphics.FromImage(backupBitmap),
        FormGraphics = mainForm.CreateGraphics())
        {
            // Create random data for font
            intFontSize = randomGenerator.Next(14, 72);
            GetRandomFont();
            font = new System.Drawing.Font(RandomFont.Name, intFontSize, RandomFont.DefaultStyle);
            sizeText = objGraphics.MeasureString(str, new Font(RandomFont.Name, intFontSize, RandomFont.DefaultStyle));

            // and coordinates
            if (sizeText.Width > mainForm.ClientRectangle.Width)
                X = 0;
            else
                X = randomGenerator.Next(0, mainForm.ClientRectangle.Width - (int)sizeText.Width);

            if (sizeText.Height > mainForm.ClientRectangle.Height)
                Y = 0;
            else
                Y = randomGenerator.Next(0, mainForm.ClientRectangle.Height - (int)sizeText.Height);
            
            colourBrush = new SolidBrush(GetRandomColor());

            // Draw the text to the form and the bitmap.
            objGraphics.DrawString(str, font, colourBrush, X, Y);
            FormGraphics.DrawString(str, font, colourBrush, X, Y);
      }
    }

    /// <summary>
    /// Draws any of the available shapes at random.
    /// </summary>
    private void DrawRandom()
    {
        // Create a circle or square based on a random number.
        Random random = new Random();
        int randomInt = random.Next(1, 6);
        switch (randomInt)
        {
            case 2: case 4: case 6:
                DrawShape(ShapeType.Circles);
                break;
            case 1: case 3: case 5:
                DrawShape(ShapeType.Squares);
                break;
        }
    }

    /// <summary>
    /// Draw a shape in a random location. The two random generators
    /// are necessary to avoid the colour and shape clusters that
    /// occur when the same seed is used for all the random numbers.
    /// </summary>
    /// <param name="type">A ShapeType enum</param>
    private void DrawShape(ShapeType type)
    {
        Brush colBrush;
        int X, Y, S;

        Random random = new Random();
        Random randomRandom = new Random(random.Next() * random.Next());

        using (Graphics objGraphics = Graphics.FromImage(backupBitmap),
        FormGraphics = mainForm.CreateGraphics())
        {
            X = random.Next(0, mainForm.ClientRectangle.Width);
            Y = randomRandom.Next(0, mainForm.ClientRectangle.Height);
            S = random.Next(1, 6);

            colBrush = new SolidBrush(GetRandomColor());
            
            switch (type)
            {
                case ShapeType.Circles:
                    objGraphics.FillEllipse(colBrush, X, Y, S * 15, S * 15);
                    FormGraphics.FillEllipse(colBrush, X, Y, S * 15, S * 15);
                    break;
                case ShapeType.Squares:
                    objGraphics.FillRectangle(colBrush, X, Y, S * 15, S * 15);
                    FormGraphics.FillRectangle(colBrush, X, Y, S * 15, S * 15);
                    break;
            }
       }
    }
    #endregion

    #region Font and Colour Handling
    private struct FontInfo
    {
        public string Name;
        public FontStyle DefaultStyle;
    }

    private static FontInfo RandomFont = new FontInfo();

    private static void GetRandomFont()
    {
        InstalledFontCollection fc = new InstalledFontCollection();
        Random random = new Random();
        FontFamily ff = fc.Families[random.Next(0, fc.Families.Length)];

        RandomFont.Name = ff.Name;
        if (ff.IsStyleAvailable(FontStyle.Regular))
            RandomFont.DefaultStyle = FontStyle.Regular;
        else if (ff.IsStyleAvailable(FontStyle.Italic))
            RandomFont.DefaultStyle = FontStyle.Italic;
        else if (ff.IsStyleAvailable(FontStyle.Bold))
            RandomFont.DefaultStyle = FontStyle.Bold;
        else if (ff.IsStyleAvailable(FontStyle.Strikeout))
            RandomFont.DefaultStyle = FontStyle.Strikeout;
        else if (ff.IsStyleAvailable(FontStyle.Underline))
            RandomFont.DefaultStyle = FontStyle.Underline;
        else //give up
        {
            RandomFont.Name = "Arial";
            RandomFont.DefaultStyle = FontStyle.Regular;
        }

    }

    /// <summary>
    /// Get a random number and cast it to a Color. The double calls
    /// to Random are to avoid the clusters of colours which would
    /// occur when the position and colour were both obtained from
    /// the same seed.
    /// </summary>
    /// <returns>A random colour.</returns>
    private static Color GetRandomColor()
    {
        KnownColor[] colors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
        Random random = new Random();
        Random randomRandom = new Random(random.Next());
        int intColor = randomRandom.Next(0, colors.Length);

        return Color.FromKnownColor(colors[intColor]);
    }   
    #endregion



}
