using System;
using System.Windows.Forms;

namespace DataEasy
{
	/// <summary>
	/// This Class Allows the user to develop his/her own controls
	/// </summary>
	public class CreateControls
	{
		static int height;
		static int width;
		static int left;
		static int top;//So the controls will be placed in a line, one under the other
		static string text;
		static string name;//Note: Multiple controls may have the same name in .Net
		
		public static Control MakeControl(string ControlType, int Height,
			int Width, int Left, int Top,
			string Text, string Name)
		{
			//As there are four steps to follow
			//in order to create controls at runtime:
			//GET THE ASSEMBLY QUALIFIED NAME,
			//CREATE THE CONTROL,
			//SET THE CONTROL'S PROPERTIES and
			//ADD THE CONTROL TO THE FORM
			//I split method into four
			//methods doing exactly the specified
			//operations

			//Get the assembly qualified name
			string assemblyName;
			assemblyName=GetAssemblyQualifiedName(ControlType);

			//Create the control
			Control myNewControl;
			myNewControl=CreateControl(assemblyName);

			//Set it's properties like Name, 
			//Top, Left etc.
			height = Height;
			width = Width;
			left = Left;
			top = Top;
			text = Text;
			name = Name;
			SetControlProperties(myNewControl);

			return myNewControl;
			//Add the control to the form
			//AddControlToTheForm(myNewControl);
		}


		private static  string GetAssemblyQualifiedName(string ControlType)
		{
			//In order to create a control 
			//at runtime you need to know:
			//THE CONTROL TYPE, 
			//THE NAME OF THE FILE that 
			//contains the type, 
			//THE VERION OF THE FILE, 
			//THE CULTURE and 
			//THE PUBLIC TOKEN KEY


			//It would be a better practice to 
			//declare this constants at the 
			//class level.
			//The reason why I placed this here
			//is olny that I wanted to make
			//this tutorial more easy to be 
			//followed and understood

			string TYPE_NAME="System.Windows.Forms." + ControlType;
			const string FILE_NAME="System.Windows.Forms";//REMARK! The name of the file without the type (.dll)
			const string VERSION_NUMBER="1.0.3300.0";
			const string CULTURE="neutral";
			const string TOKEN_KEY="b77a5c561934e089";

			//Create the assembly qualified name
			string assemblyQualifiedName=TYPE_NAME+", "+FILE_NAME +
				", Version="+VERSION_NUMBER+", Culture="+CULTURE +
				", PublicKeyToken="+TOKEN_KEY;

			//return the assembly qualified name
			return assemblyQualifiedName;

			//NOTE!
			//If you want to create a control 
			//deffined in an other library you
			//need to find the library version,
			//the culture and the token, presumming 
			//that you allready know the type of
			//control, and the library.
			//Do find this informations just
			//browse with WINDOWS EXPLORER
			//to the <WINDOWS DIR>\Assembly.

			//If you don't have this version of
			//System.Windows.Forms.dll
			//you shold also do the same way
			//to find your vesrion, culture and 
			//token
		}

		
		private static Control CreateControl(string assemblyName)
		{
			//Get the button type
			Type buttonType = Type.GetType (assemblyName);

			//Get the button contructor
			//We search for the constructor
			//with no parameters
			System.Reflection.ConstructorInfo buttonCtor;
			Type[] typesCtorParams=new Type[0];
			buttonCtor=buttonType.GetConstructor(typesCtorParams);

			//Create the control by invoking
			//the constructor
			Object[] paramsCtor=new Object[0];
			Control myControl=(Control)buttonCtor.Invoke(paramsCtor);

			//Return the control
			return myControl;
		}


		private static void SetControlProperties(Control control)
		{
			//First increment the counter so the
			//next control will be visible
			//(otherwise it will be under
			//the previous control)
			//newControlsCounter++;
		
			//Set some properties
			control.Height=height;
			control.Width=width;
			control.Left =left;
			control.Top = top;//So the controls will be placed in a line, one under the other
			control.Text = text;
			control.Name = name;//Note: Multiple controls may have the same name in .Net

			//Add an event
			//control.Click += new System.EventHandler(this.EventTest);

			//NOTE!
			//1)
			//If you don't set any property
			//the control will be plased with
			//it's default properties.
			//
			//To create a control with it's
			//default properties comment all
			//the code within this method

			//2)
			//If you want to set some properties 
			//or handle some events that 
			//aren't inherited from
			//System.Windows.Forms.Control 
			//(such as you own-deffined control)
			//you have to cast the control
			//to a type that knows this properties
			//and events (such as your control type)
		}
	}
}
