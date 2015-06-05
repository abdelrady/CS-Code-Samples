using System;

// Derive a custom EventArgs class that holds the key.
class KeyEventArgs : EventArgs
{
    public char ch;
}

// Declare a delegate for an event.
delegate void KeyHandler(object source, KeyEventArgs arg);

// Declare a keypress event class.
class KeyEvent
{
    public event KeyHandler KeyPress;

    // This is called when a key is pressed.
    public void OnKeyPress(char key)
    {
        KeyEventArgs k = new KeyEventArgs();

        if (KeyPress != null)
        {
            k.ch = key;
            KeyPress(this, k);
        }
    }
}

// Demonstrate KeyEvent.
class KeyEventDemo
{
    public static void Main()
    {
        KeyEvent kevt = new KeyEvent();
        ConsoleKeyInfo key;
        int count = 0;

        // Use anonymous method to display the keypress.
        kevt.KeyPress += delegate(object source, KeyEventArgs arg)
        {
            Console.WriteLine(" Received keystroke: " + arg.ch);
        };

        // Use an anonymous method to count keypresses.
        kevt.KeyPress += delegate(object source, KeyEventArgs arg)
        {
            count++; // count is an outer variable
        };

        Console.WriteLine("Enter some characters. " +
                          "Enter a period to stop.");
        do
        {
            key = Console.ReadKey(true);//Don't show Inercepted character........
            kevt.OnKeyPress(key.KeyChar);
        } while (key.KeyChar != '.');
        Console.WriteLine(count + " keys pressed.");
    }
}