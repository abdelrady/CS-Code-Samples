using System;
using System.Windows.Forms;
using System.Threading;
namespace FormEffect
{
    class Fade
    {
        public Fade()
        {

        }//end of constructor

        /// <summary>
        /// Allows a form to have a fade in effect
        /// </summary>
        /// <param name="form">An instance of a Windows Form</param>
        /// <param name="maxOpacity">Opacity that the form will end up with.</param>
        /// <param name="countAdd">Number used to increase opacity of the form</param>
        public static void In(Form form, double maxOpacity, double countAdd)
        {
            double counter = form.Opacity;
            if ((form.Opacity == 0) || (form.Visible == false))
            {
                form.Show();
            }

            while (counter <= maxOpacity)
            {
                form.Update();
                Thread.Sleep(50);
                counter += countAdd;
                form.Opacity = counter;
            }//end of while
        }//end of In()

        /// <summary>
        /// Allows a form to have a fade out effect
        /// </summary>
        /// <param name="form">An instance of a Windows Form</param>
        /// <param name="minOpacity">Opacity that the form will end up with.</param>
        /// <param name="countDelete">Number used to decrease opacity of the form</param>  
        public static void Out(Form form, double minOpacity, double countDelete)
        {
            double counter = form.Opacity;
            if (form.Opacity == 0)
            {
                form.Show();
            }
            else if (form.Visible == false)
            {
                form.Show();
            }
            while (counter >= minOpacity)
            {
                form.Update();
                counter -= countDelete;
                form.Opacity = counter;
            }//end of while
        }//end of Out()
    }//end of class
}//end of namespace