using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Diagnostics;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private SoundPlayer asd = new SoundPlayer();
        public Form1()
        {
           
            InitializeComponent();
        }    


        private void button1_Click(object sender, EventArgs e)
        {
            
                  int i;
                  for (i = 0; i < textBox1.Text.Length; i++)
                  {              
                   
                      switch (textBox1.Text[i].ToString())
                      {
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\"+"�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case "�":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "�.wav");
                              break;
                          case " ":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "space.wav");
                              break;
                          case "0":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "0.wav");
                              break;
                          case "1":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "1.wav");
                              break;
                          case "2":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "2.wav");
                              break;
                          case "3":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "3.wav");
                              break;
                          case "4":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "4.wav");
                              break;
                          case "5":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "5.wav");
                              break;
                          case "6":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "6.wav");
                              break;
                          case "7":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "7.wav");
                              break;
                          case "8":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "8.wav");
                              break;
                          case "9":
                              playSound(Directory.GetCurrentDirectory() + "\\" + "9.wav");
                              break;
                               

                              }

                      
                  }
    }

        private void playSound(string p)
        {
            asd.SoundLocation = p;
            asd.LoadAsync();
            asd.PlaySync();
        }
        private void button2_Click(object sender, EventArgs e)
        {
           //playSound( Directory.GetCurrentDirectory() + "\\about.wav");
            MessageBox.Show("Simple Text Editor Program :SADAWY KAMEL SADAWY", "About", MessageBoxButtons.OK,               MessageBoxIcon.Information);
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("TextWithVoice.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Text Editor Program :SADAWY KAMEL SADAWY", "About", MessageBoxButtons.OK,             MessageBoxIcon.Information);

        }
    }
}