using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Button m_btnLastButton;
        private void Form1_Load(object sender, EventArgs e)
        {
            //for(int i=0;i<10;i++)
            


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch ( e.KeyData )
           {                   
              // following case tests if backspace was pressed
              case Keys.Back: // Backspace key             
                  ChangeColor(button13);              
                 if ( txtOutput.Text.Length - 1 >= 0 )     
                 {                                         
                    txtOutput.Text = txtOutput.Text.Remove(
                       txtOutput.Text.Length - 1, 1 );     
                 }                                         
                 break;                                    
  
              // following cases test if whitespace key was pressed
              case Keys.Enter: // Enter key
                  ChangeColor(button40);  
                 txtOutput.Text += "\n";   
                 break;                    
 /*
              case Keys.Tab: // Tab key
                 ChangeColor( btnTab );
                 txtOutput.Text += "\t";
               break;
              case Keys.Space: // space bar
                 ChangeColor( btnSpace );
                 txtOutput.Text += " ";
                 break;
  */
              // following cases test if number key was pressed
              case Keys.D0: // 0 key
                  ChangeColor(button10);
                 txtOutput.Text += "0";
                 break;
 
              case Keys.D1:
                  ChangeColor(button1);
                 txtOutput.Text += "1";
                 break;
  
              case Keys.D2:
                  ChangeColor(button2);

                 txtOutput.Text += "2";
                 break;
  
              case Keys.D3:
                  ChangeColor(button3);
                 txtOutput.Text += "3";
                 break;
              case Keys.D4:
                  ChangeColor(button4);
                 txtOutput.Text += "4";
                 break;
  
              case Keys.D5:
                  ChangeColor(button5);
                 txtOutput.Text += "5";
                 break;
  
              case Keys.D6:
                  ChangeColor(button6);
                 txtOutput.Text += "6";
                 break;
 
              case Keys.D7:
                  ChangeColor(button7);
                 txtOutput.Text += "7";
                 break;
  
              case Keys.D8:
                  ChangeColor(button8);
                 txtOutput.Text += "8";
             break;
              case Keys.D9:
                  ChangeColor(button9);
                 txtOutput.Text += "9";
                 break;
  
              // following cases test if one of the F keys was pressed
              /*case Keys.F1: // F1 key
                 ChangeColor( btnF1 );
                 break;
  
              case Keys.F2: // F2 key
                 ChangeColor( btnF2 );
                 break;
  
              case Keys.F3: // F3 key
                 ChangeColor( btnF3 );
                 break;
  
              case Keys.F4: // F4 key
                 ChangeColor( btnF4 );
                break;
  
              case Keys.F5: // F5 key
                 ChangeColor( btnF5 );
                 break;

              case Keys.F6: // F6 key
                 ChangeColor( btnF6 );
                 break;
  
              case Keys.F7: // F7 key
                 ChangeColor( btnF7 );
                 break;
  
              case Keys.F8: // F8 key
                 ChangeColor( btnF8 );
                 break;
  
              case Keys.F9: // F9 key
                 ChangeColor( btnF9 );
                 break;
  
              case Keys.F10: // F10 key
                 ChangeColor( btnF10 );
                 break;
  
              case Keys.F11: // F11 key
                 ChangeColor( btnF11 );
                 break;
              case Keys.F12: // F12 key
                 ChangeColor( btnF12 );
                 break;
  */
              // following cases test if a special 
              // character key was pressed
    /*          case Keys.OemOpenBrackets: // left square bracket
                 ChangeColor( btnLeftBrace );
                 txtOutput.Text += "[";
                 break;
  
              case Keys.OemCloseBrackets: // right square bracket
                 ChangeColor( btnRightBrace );
                 txtOutput.Text += "]";
                 break;
  
              case Keys.Oemplus: // plus sign
                 ChangeColor( btnPlus );
                 txtOutput.Text += "+";
                 break;
  
              case Keys.OemMinus: // minus sign
                 ChangeColor( btnHyphen );
                 txtOutput.Text += "-";
              break;
             case Keys.Oemtilde: // tilde (~)
                 ChangeColor( btnTilde );
                 txtOutput.Text += "~";
                 break;
  */
              case Keys.OemPipe: // backslash
                  ChangeColor(button27);
                 txtOutput.Text += "\\";
                 break;
  /*
              case Keys.OemSemicolon: // colon
                 ChangeColor( btnColon );
                 txtOutput.Text += ":";
                 break;
  
              case Keys.OemQuotes: // quotation marks
                 ChangeColor( btnQuote );
                 txtOutput.Text += "\"";
                break;
  
              case Keys.OemPeriod: // period
                 ChangeColor( btnPeriod );
                 txtOutput.Text += ".";
               break;
              case Keys.Oemcomma: // comma
                 ChangeColor( btnComma );
                 txtOutput.Text += ",";
                 break;
  
              case Keys.OemQuestion: // question mark
                 ChangeColor( btnQuestion );
                 txtOutput.Text += "?";
                 break;
  
              case Keys.CapsLock: // Caps Lock key
                 ChangeColor( btnCaps );
                 break;
 
              // following cases test if one of the 
              // arrow keys was pressed
              case Keys.Down: // down arrow
                 ChangeColor( btnDown );
                 break;
  
              case Keys.Up: // up arrow
                 ChangeColor( btnUp );
                 break;
  
              case Keys.Left: // left arrow
                 ChangeColor( btnLeft );
                 break;

             case Keys.Right: // right arrow
                 ChangeColor( btnRight );
                 break;
  
              // following cases test if a modifier key was pressed
              case ( ( Keys ) 65552 ): // Shift key
                 ChangeColor( btnShiftLeft );
                 break;
  
              case ( ( Keys ) 131089 ): // Control key
                 ChangeColor( btnCtrlLeft );
                 break;
  
              case ( ( Keys ) 262162 ): // Alt key
                 ChangeColor( btnAltLeft );
                 break;
  */
           } // end switch e.KeyData


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          switch ( Char.ToUpper( e.KeyChar ) )
           {                                   
              // following cases test if key pressed was a letter
              case ( ( char ) Keys.A ): // a key
                  ChangeColor(button29);           
                 txtOutput.Text += e.KeyChar;   
                 break;                         
  
              /*case ( ( char ) Keys.B ): // b key
                 ChangeColor( btnB );           
                 txtOutput.Text += e.KeyChar;   
                 break;                         
  
              case ( ( char ) Keys.C ): // c key
                 ChangeColor( btnC );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.D ): // d key
                 ChangeColor( btnD );
                 txtOutput.Text += e.KeyChar;
                 break;
            case ( ( char ) Keys.E ): // e key
                 ChangeColor( btnE );
                 txtOutput.Text += e.KeyChar;
                 break;
 
              case ( ( char ) Keys.F ): // f key
                 ChangeColor( btnF );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.G ): // g key
                 ChangeColor( btnG );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.H ): // h key
                 ChangeColor( btnH );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.I ): // i key
                 ChangeColor( btnI );
                 txtOutput.Text += e.KeyChar;
                 break;
  
             case ( ( char ) Keys.J ): // j key
                ChangeColor( btnJ );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.K ): // k key
                 ChangeColor( btnK );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.L ): // l key
                 ChangeColor( btnL );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.M ): // m key
                 ChangeColor( btnM );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.N ): // n key
                 ChangeColor( btnN );
                 txtOutput.Text += e.KeyChar;
                 break;
            case ( ( char ) Keys.O ): // o key
                 ChangeColor( btnO );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.P ): // p key
                 ChangeColor( btnP );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.Q ): // q key
                ChangeColor( btnQ );
                 txtOutput.Text += e.KeyChar;
                break;
  
              case ( ( char ) Keys.R ): // r key
                 ChangeColor( btnR );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.S ): // s key
                 ChangeColor( btnS );
                 txtOutput.Text += e.KeyChar;
                 break;
              case ( ( char ) Keys.T ): // t key
                 ChangeColor( btnT );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.U ): // u key
                 ChangeColor( btnU );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.V ): // v key
                 ChangeColor( btnV );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.W ): // w key
                 ChangeColor( btnW );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.X ): // x key
                 ChangeColor( btnX );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.Y ): // y key
                 ChangeColor( btnY );
                 txtOutput.Text += e.KeyChar;
                 break;
  
              case ( ( char ) Keys.Z ): // z key
                 ChangeColor( btnZ );
                 txtOutput.Text += e.KeyChar;
                 break;*/
  
           } // end switch -- ends test for letters

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            ResetColor();
        }
    private void ChangeColor( Button btnButton )
       {
           ResetColor();
           btnButton.BackColor = Color.LightGoldenrodYellow;
           m_btnLastButton = btnButton;
    }  
        private void ResetColor()
        {
           if ( m_btnLastButton != null )
           {
              m_btnLastButton.BackColor = SystemColors.Control;
           }
            
        }

        private void clearTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
        }

        private void invertColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Color temporaryColor; // temporary Color value
  
           temporaryColor = txtOutput.BackColor;     
           txtOutput.BackColor = txtOutput.ForeColor;
           txtOutput.ForeColor = temporaryColor;     
  
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
          ColorDialog dlgColorDialog = new ColorDialog();
           DialogResult result; // stores Button clicked  
        
           dlgColorDialog.FullOpen = true; // show all colors
           result = dlgColorDialog.ShowDialog();             

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FontDialog dlgFontDialog = new FontDialog(); 
           DialogResult result; // stores Button clicked
          result = dlgFontDialog.ShowDialog();
  
           // do nothing if user clicked dialog's Cancel Button
           if ( result == DialogResult.Cancel )
           {                                   
              return;                          
           }                                   
  
           // assign new font value to TextBox 
           txtOutput.Font = dlgFontDialog.Font;

        } // end method mnuitmInvert_Click
  
     } // end class FrmTypingApplication

        } // end method ResetColor


 
