// Fig 10.27: OperatorOverloading.cs
// An example that uses operator overloading

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace OperatorOverloading
{
   public class ComplexTest : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label realLabel;
      private System.Windows.Forms.Label imaginaryLabel;
      private System.Windows.Forms.Label statusLabel;

      private System.Windows.Forms.TextBox realTextBox;
      private System.Windows.Forms.TextBox imaginaryTextBox;

      private System.Windows.Forms.Button firstButton;
      private System.Windows.Forms.Button secondButton;
      private System.Windows.Forms.Button addButton;
      private System.Windows.Forms.Button subtractButton;
      private System.Windows.Forms.Button multiplyButton;

      private ComplexNumber x = new ComplexNumber();
      private ComplexNumber y = new ComplexNumber();

      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public ComplexTest()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if ( disposing )
         {
            if ( components != null ) 
            {
               components.Dispose();
            }
         }

         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.imaginaryTextBox = new System.Windows.Forms.TextBox();
         this.imaginaryLabel = new System.Windows.Forms.Label();
         this.addButton = new System.Windows.Forms.Button();
         this.secondButton = new System.Windows.Forms.Button();
         this.realLabel = new System.Windows.Forms.Label();
         this.firstButton = new System.Windows.Forms.Button();
         this.realTextBox = new System.Windows.Forms.TextBox();
         this.multiplyButton = new System.Windows.Forms.Button();
         this.subtractButton = new System.Windows.Forms.Button();
         this.statusLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // imaginaryTextBox
         // 
         this.imaginaryTextBox.Location = new System.Drawing.Point(73, 56);
         this.imaginaryTextBox.Name = "imaginaryTextBox";
         this.imaginaryTextBox.Size = new System.Drawing.Size(86, 20);
         this.imaginaryTextBox.TabIndex = 4;
         this.imaginaryTextBox.Text = "";
         // 
         // imaginaryLabel
         // 
         this.imaginaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
         this.imaginaryLabel.Location = new System.Drawing.Point(10, 56);
         this.imaginaryLabel.Name = "imaginaryLabel";
         this.imaginaryLabel.Size = new System.Drawing.Size(60, 18);
         this.imaginaryLabel.TabIndex = 1;
         this.imaginaryLabel.Text = "Imaginary";
         // 
         // addButton
         // 
         this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.addButton.Location = new System.Drawing.Point(38, 112);
         this.addButton.Name = "addButton";
         this.addButton.TabIndex = 7;
         this.addButton.Text = "+";
         this.addButton.Click += new System.EventHandler(this.addButton_Click);
         // 
         // secondButton
         // 
         this.secondButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
         this.secondButton.Location = new System.Drawing.Point(172, 56);
         this.secondButton.Name = "secondButton";
         this.secondButton.Size = new System.Drawing.Size(178, 25);
         this.secondButton.TabIndex = 6;
         this.secondButton.Text = "Set Second Complex Number";
         this.secondButton.Click += new System.EventHandler(this.secondButton_Click);
         // 
         // realLabel
         // 
         this.realLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
         this.realLabel.Location = new System.Drawing.Point(24, 16);
         this.realLabel.Name = "realLabel";
         this.realLabel.Size = new System.Drawing.Size(32, 17);
         this.realLabel.TabIndex = 0;
         this.realLabel.Text = "Real";
         // 
         // firstButton
         // 
         this.firstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
         this.firstButton.Location = new System.Drawing.Point(172, 16);
         this.firstButton.Name = "firstButton";
         this.firstButton.Size = new System.Drawing.Size(178, 25);
         this.firstButton.TabIndex = 5;
         this.firstButton.Text = "Set First Complex Number";
         this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
         // 
         // realTextBox
         // 
         this.realTextBox.Location = new System.Drawing.Point(73, 16);
         this.realTextBox.Name = "realTextBox";
         this.realTextBox.Size = new System.Drawing.Size(86, 20);
         this.realTextBox.TabIndex = 3;
         this.realTextBox.Text = "";
         // 
         // multiplyButton
         // 
         this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.multiplyButton.Location = new System.Drawing.Point(250, 112);
         this.multiplyButton.Name = "multiplyButton";
         this.multiplyButton.TabIndex = 9;
         this.multiplyButton.Text = "x";
         this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
         // 
         // subtractButton
         // 
         this.subtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.subtractButton.Location = new System.Drawing.Point(144, 112);
         this.subtractButton.Name = "subtractButton";
         this.subtractButton.TabIndex = 8;
         this.subtractButton.Text = "-";
         this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
         // 
         // statusLabel
         // 
         this.statusLabel.Location = new System.Drawing.Point(34, 160);
         this.statusLabel.Name = "statusLabel";
         this.statusLabel.Size = new System.Drawing.Size(294, 23);
         this.statusLabel.TabIndex = 2;
         // 
         // ComplexTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(360, 197);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.multiplyButton,
                                                                      this.subtractButton,
                                                                      this.addButton,
                                                                      this.secondButton,
                                                                      this.firstButton,
                                                                      this.imaginaryTextBox,
                                                                      this.realTextBox,
                                                                      this.statusLabel,
                                                                      this.imaginaryLabel,
                                                                      this.realLabel});
         this.Name = "ComplexTest";
         this.Text = "ComplexNumberTest";
         this.ResumeLayout(false);

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new ComplexTest() );
      }

      private void firstButton_Click(
         object sender, System.EventArgs e)
      {
         x.Real = Int32.Parse(realTextBox.Text);
         x.Imaginary = Int32.Parse(imaginaryTextBox.Text);
         realTextBox.Clear();
         imaginaryTextBox.Clear();
         statusLabel.Text = "First Complex Number is: " + x;
      }

      private void secondButton_Click(
         object sender, System.EventArgs e)
      {
         y.Real = Int32.Parse(realTextBox.Text);
         y.Imaginary = Int32.Parse(imaginaryTextBox.Text);
         realTextBox.Clear();
         imaginaryTextBox.Clear();
         statusLabel.Text = "Second Complex Number is: " + y;
      }

      // add complex numbers
      private void addButton_Click(object sender, System.EventArgs e)
      {
         statusLabel.Text = x + " + " + y + " = " + ( x + y );
      }

      // subtract complex numbers
      private void subtractButton_Click(
         object sender, System.EventArgs e)
      {
         statusLabel.Text = x + " - " + y + " = " + ( x - y );
      }

      // multiply complex numbers
      private void multiplyButton_Click(
         object sender, System.EventArgs e)
      {
         statusLabel.Text = x + " * " + y + " = " + ( x * y );
      }

   } // end class ComplexTest
}

/*
 ************************************************************************** 
 * (C) Copyright 2002 by Deitel & Associates, Inc. and Prentice Hall.     *
 * All Rights Reserved.                                                   *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************
*/