//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 25/12/2006 02:25:34 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace WindowsApplication1

{
		
		#region Namespace Import Declarations
		
			using Microsoft.CSharp;
			using System;
			using System.CodeDom.Compiler;
			using System.Collections;
			using System.ComponentModel;
			using System.Diagnostics;
			using System.Drawing;
			using System.IO;
			using System.Windows.Forms;
			
			
		#endregion
		
	public class frm : Form
	
	{
		
		#region Fields
			private Button button1;
			private Button button2;
			private Button button3;
			private IContainer components;
			private Label label1;
			private TextBox textBox1;
			private TextBox textBox2;
			private TextBox textBox4;
			private TextBox textBox5;
		#endregion
		
		#region Constructors

        public frm() { }
			/*
				// Code Size: 13 Bytes
				.maxstack 8
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Form::Void .ctor()
				L_0006: ldarg.0 
				L_0007: call WindowsApplication1.Form1::Void InitializeComponent()
				L_000c: ret 
			*/
		#endregion
		
		#region Methods
		
			private int asd (string b)
			
			/*
				// Code Size: 204 Bytes
				.maxstack 4
				.locals (System.String[] V_0, 
         System.Char[] V_1, 
         System.Diagnostics.Process V_2, 
         System.String V_3, 
         System.Double V_4, 
         System.String V_5, 
         System.Int32 V_6, 
         System.Char[] V_7)
				.try L_0072 to L_00b0 catch System.IndexOutOfRangeException L_00b0 to L_00be
				.try L_0072 to L_00c0 finally L_00c0 to L_00c7
				L_0000: ldc.i4.1 
				L_0001: newarr System.Char
				L_0006: stloc.s V_7
				L_0008: ldloc.s V_7
				L_000a: ldc.i4.0 
				L_000b: ldc.i4.s 69
				L_000d: stelem.i2 
				L_000e: ldloc.s V_7
				L_0010: stloc.1 
				L_0011: newobj System.Diagnostics.Process::Void .ctor()
				L_0016: stloc.2 
				L_0017: ldloc.2 
				L_0018: callvirt System.Diagnostics.Process::System.Diagnostics.ProcessStartInfo get_StartInfo()
				L_001d: ldc.i4.0 
				L_001e: callvirt System.Diagnostics.ProcessStartInfo::Void set_UseShellExecute(Boolean)
				L_0023: ldloc.2 
				L_0024: callvirt System.Diagnostics.Process::System.Diagnostics.ProcessStartInfo get_StartInfo()
				L_0029: ldc.i4.1 
				L_002a: callvirt System.Diagnostics.ProcessStartInfo::Void set_RedirectStandardOutput(Boolean)
				L_002f: ldloc.2 
				L_0030: callvirt System.Diagnostics.Process::System.Diagnostics.ProcessStartInfo get_StartInfo()
				L_0035: ldstr "out.com"
				L_003a: callvirt System.Diagnostics.ProcessStartInfo::Void set_FileName(System.String)
				L_003f: ldloc.2 
				L_0040: callvirt System.Diagnostics.Process::System.Diagnostics.ProcessStartInfo get_StartInfo()
				L_0045: ldarg.0 
				L_0046: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox4
				L_004b: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_0050: callvirt System.Diagnostics.ProcessStartInfo::Void set_Arguments(System.String)
				L_0055: ldloc.2 
				L_0056: callvirt System.Diagnostics.Process::Boolean Start()
				L_005b: pop 
				L_005c: ldloc.2 
				L_005d: callvirt System.Diagnostics.Process::System.IO.StreamReader get_StandardOutput()
				L_0062: callvirt System.IO.TextReader::System.String ReadToEnd()
				L_0067: stloc.3 
				L_0068: ldloc.3 
				L_0069: ldloc.1 
				L_006a: ldc.i4.2 
				L_006b: ldc.i4.1 
				L_006c: callvirt System.String::System.String[] Split(Char[], Int32, System.StringSplitOptions)
				L_0071: stloc.0 
				L_0072: ldloc.0 
				L_0073: ldc.i4.0 
				L_0074: ldelem.ref 
				L_0075: call System.Convert::Double ToDouble(System.String)
				L_007a: call System.Math::Double Log10(Double)
				L_007f: ldloc.0 
				L_0080: ldc.i4.1 
				L_0081: ldelem.ref 
				L_0082: call System.Convert::Int32 ToInt32(System.String)
				L_0087: conv.r8 
				L_0088: add 
				L_0089: stloc.s V_4
				L_008b: ldloc.s V_4
				L_008d: ldc.i4.4 
				L_008e: call System.Math::Double Round(Double, Int32)
				L_0093: stloc.s V_4
				L_0095: ldloc.s V_4
				L_0097: call System.Convert::System.String ToString(Double)
				L_009c: stloc.s V_5
				L_009e: ldloc.s V_5
				L_00a0: ldarg.1 
				L_00a1: call System.String::Boolean Equals(System.String, System.String)
				L_00a6: brtrue.s L_00ab
				L_00a8: ldc.i4.0 
				L_00a9: br.s L_00ac
				L_00ab: ldc.i4.1 
				L_00ac: stloc.s V_6
				L_00ae: leave.s L_00c9
				L_00b0: pop 
				L_00b1: ldstr "Infinity"
				L_00b6: call System.Windows.Forms.MessageBox::System.Windows.Forms.DialogResult Show(System.String)
				L_00bb: pop 
				L_00bc: leave.s L_00be
				L_00be: leave.s L_00c7
				L_00c0: ldloc.2 
				L_00c1: callvirt System.Diagnostics.Process::Void Close()
				L_00c6: endfinally 
				L_00c7: ldc.i4.0 
				L_00c8: ret 
				L_00c9: ldloc.s V_6
				L_00cb: ret 
			*/
			
			
			{
				double n1;
				string d1;
				char[] charArray1 = new char[] { 'E' };
				char[] charSeparators1 = charArray1;
				Process p1 = new Process ();
				p1.StartInfo.UseShellExecute = false;
				p1.StartInfo.RedirectStandardOutput = true;
				p1.StartInfo.FileName = "out.com";
				p1.StartInfo.Arguments = this.textBox4.Text;
				bool b1 = p1.Start ();
				string output1 = p1.StandardOutput.ReadToEnd ();
				string[] result1 = output1.Split (charSeparators1, 2, StringSplitOptions.RemoveEmptyEntries);
				try
				{
					try
					{
						n1 = (Math.Log10 (Convert.ToDouble (result1[0])) + ((double) Convert.ToInt32 (result1[1])));
						n1 = Math.Round (n1, 4);
						d1 = Convert.ToString (n1);
						return (string.Equals (d1, b) ? 1 : 0);
					}
					catch (IndexOutOfRangeException)
					{
						System.Windows.Forms.DialogResult dialogResult1 = MessageBox.Show ("Infinity");
					}
				}
				finally
				{
					p1.Close ();
				}
				return 0;
			}
			
			private void button1_Click (object sender, EventArgs e)
			
			/*
				// Code Size: 385 Bytes
				.maxstack 4
				.locals (Microsoft.CSharp.CSharpCodeProvider V_0, 
         System.CodeDom.Compiler.ICodeCompiler V_1, 
         System.String V_2, 
         System.Windows.Forms.Button V_3, 
         System.CodeDom.Compiler.CompilerParameters V_4, 
         System.CodeDom.Compiler.CompilerResults V_5, 
         System.CodeDom.Compiler.CompilerError V_6, 
         System.Collections.IEnumerator V_7, 
         System.Object[] V_8, 
         System.IDisposable V_9)
				.try L_0086 to L_012e finally L_012e to L_0143
				L_0000: newobj Microsoft.CSharp.CSharpCodeProvider::Void .ctor()
				L_0005: stloc.0 
				L_0006: ldloc.0 
				L_0007: callvirt System.CodeDom.Compiler.CodeDomProvider::System.CodeDom.Compiler.ICodeCompiler CreateCompiler()
				L_000c: stloc.1 
				L_000d: ldstr "Out.com"
				L_0012: stloc.2 
				L_0013: ldarg.1 
				L_0014: castclass System.Windows.Forms.Button
				L_0019: stloc.3 
				L_001a: ldarg.0 
				L_001b: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox2
				L_0020: ldstr ""
				L_0025: callvirt System.Windows.Forms.Control::Void set_Text(System.String)
				L_002a: newobj System.CodeDom.Compiler.CompilerParameters::Void .ctor()
				L_002f: stloc.s V_4
				L_0031: ldloc.s V_4
				L_0033: ldc.i4.1 
				L_0034: callvirt System.CodeDom.Compiler.CompilerParameters::Void set_GenerateExecutable(Boolean)
				L_0039: ldloc.s V_4
				L_003b: ldloc.2 
				L_003c: callvirt System.CodeDom.Compiler.CompilerParameters::Void set_OutputAssembly(System.String)
				L_0041: ldloc.1 
				L_0042: ldloc.s V_4
				L_0044: ldarg.0 
				L_0045: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox1
				L_004a: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_004f: callvirt System.CodeDom.Compiler.ICodeCompiler::System.CodeDom.Compiler.CompilerResults CompileAssemblyFromSource(System.CodeDom.Compiler.CompilerParameters, System.String)
				L_0054: stloc.s V_5
				L_0056: ldloc.s V_5
				L_0058: callvirt System.CodeDom.Compiler.CompilerResults::System.CodeDom.Compiler.CompilerErrorCollection get_Errors()
				L_005d: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_0062: ldc.i4.0 
				L_0063: ble L_0143
				L_0068: ldarg.0 
				L_0069: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox2
				L_006e: call System.Drawing.Color::System.Drawing.Color get_Red()
				L_0073: callvirt System.Windows.Forms.Control::Void set_ForeColor(System.Drawing.Color)
				L_0078: ldloc.s V_5
				L_007a: callvirt System.CodeDom.Compiler.CompilerResults::System.CodeDom.Compiler.CompilerErrorCollection get_Errors()
				L_007f: callvirt System.Collections.CollectionBase::System.Collections.IEnumerator GetEnumerator()
				L_0084: stloc.s V_7
				L_0086: br L_0120
				L_008b: ldloc.s V_7
				L_008d: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0092: castclass System.CodeDom.Compiler.CompilerError
				L_0097: stloc.s V_6
				L_0099: ldarg.0 
				L_009a: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox2
				L_009f: ldc.i4.s 10
				L_00a1: newarr System.Object
				L_00a6: stloc.s V_8
				L_00a8: ldloc.s V_8
				L_00aa: ldc.i4.0 
				L_00ab: ldarg.0 
				L_00ac: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox2
				L_00b1: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_00b6: stelem.ref 
				L_00b7: ldloc.s V_8
				L_00b9: ldc.i4.1 
				L_00ba: ldstr "Line number "
				L_00bf: stelem.ref 
				L_00c0: ldloc.s V_8
				L_00c2: ldc.i4.2 
				L_00c3: ldloc.s V_6
				L_00c5: callvirt System.CodeDom.Compiler.CompilerError::Int32 get_Line()
				L_00ca: box System.Int32
				L_00cf: stelem.ref 
				L_00d0: ldloc.s V_8
				L_00d2: ldc.i4.3 
				L_00d3: ldstr ", Error Number: "
				L_00d8: stelem.ref 
				L_00d9: ldloc.s V_8
				L_00db: ldc.i4.4 
				L_00dc: ldloc.s V_6
				L_00de: callvirt System.CodeDom.Compiler.CompilerError::System.String get_ErrorNumber()
				L_00e3: stelem.ref 
				L_00e4: ldloc.s V_8
				L_00e6: ldc.i4.5 
				L_00e7: ldstr ", '"
				L_00ec: stelem.ref 
				L_00ed: ldloc.s V_8
				L_00ef: ldc.i4.6 
				L_00f0: ldloc.s V_6
				L_00f2: callvirt System.CodeDom.Compiler.CompilerError::System.String get_ErrorText()
				L_00f7: stelem.ref 
				L_00f8: ldloc.s V_8
				L_00fa: ldc.i4.7 
				L_00fb: ldstr ";"
				L_0100: stelem.ref 
				L_0101: ldloc.s V_8
				L_0103: ldc.i4.8 
				L_0104: call System.Environment::System.String get_NewLine()
				L_0109: stelem.ref 
				L_010a: ldloc.s V_8
				L_010c: ldc.i4.s 9
				L_010e: call System.Environment::System.String get_NewLine()
				L_0113: stelem.ref 
				L_0114: ldloc.s V_8
				L_0116: call System.String::System.String Concat(System.Object[])
				L_011b: callvirt System.Windows.Forms.Control::Void set_Text(System.String)
				L_0120: ldloc.s V_7
				L_0122: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0127: brtrue L_008b
				L_012c: leave.s L_0180
				L_012e: ldloc.s V_7
				L_0130: isinst System.IDisposable
				L_0135: stloc.s V_9
				L_0137: ldloc.s V_9
				L_0139: brfalse.s L_0142
				L_013b: ldloc.s V_9
				L_013d: callvirt System.IDisposable::Void Dispose()
				L_0142: endfinally 
				L_0143: ldarg.0 
				L_0144: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox2
				L_0149: call System.Drawing.Color::System.Drawing.Color get_Blue()
				L_014e: callvirt System.Windows.Forms.Control::Void set_ForeColor(System.Drawing.Color)
				L_0153: ldarg.0 
				L_0154: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox2
				L_0159: ldstr "Success!"
				L_015e: callvirt System.Windows.Forms.Control::Void set_Text(System.String)
				L_0163: ldloc.3 
				L_0164: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_0169: ldstr "Run"
				L_016e: call System.String::Boolean op_Equality(System.String, System.String)
				L_0173: brfalse.s L_0180
				L_0175: ldstr "Out.exe"
				L_017a: call System.Diagnostics.Process::System.Diagnostics.Process Start(System.String)
				L_017f: pop 
				L_0180: ret 
			*/
			
			
			{
				object[] objectArray1;
				CSharpCodeProvider codeProvider1 = new CSharpCodeProvider ();
				ICodeCompiler icc1 = codeProvider1.CreateCompiler ();
				string Output1 = "Out.com";
				Button ButtonObject1 = ((Button) sender);
				this.textBox2.Text = "";
				CompilerParameters parameters1 = new CompilerParameters ();
				parameters1.GenerateExecutable = true;
				parameters1.OutputAssembly = Output1;
				CompilerResults results1 = icc1.CompileAssemblyFromSource (parameters1, this.textBox1.Text);
				if (results1.Errors.Count > 0)
				{
					this.textBox2.ForeColor = Color.Red;
					foreach (CompilerError CompErr1 in results1.Errors)
					{
						objectArray1 = new object[] { this.textBox2.Text, "Line number ", CompErr1.Line, ", Error Number: ", CompErr1.ErrorNumber, ", \'", CompErr1.ErrorText, ";", Environment.NewLine, Environment.NewLine };
						this.textBox2.Text = string.Concat (objectArray1);
					}
				}
				else
				{
					this.textBox2.ForeColor = Color.Blue;
					this.textBox2.Text = "Success!";
					if (ButtonObject1.Text == "Run")
					{
						Process process1 = Process.Start ("Out.exe");
					}
				}
			}
			
			private void button2_Click (object sender, EventArgs e)
			
			/*
				// Code Size: 172 Bytes
				.maxstack 4
				.locals (System.String[] V_0, 
         System.String[] V_1, 
         System.Int32 V_2, 
         System.Int32 V_3, 
         System.String[] V_4, 
         System.String[] V_5)
				L_0000: ldc.i4.5 
				L_0001: newarr System.String
				L_0006: stloc.s V_4
				L_0008: ldloc.s V_4
				L_000a: ldc.i4.0 
				L_000b: ldstr "3.7024"
				L_0010: stelem.ref 
				L_0011: ldloc.s V_4
				L_0013: ldc.i4.1 
				L_0014: ldstr "6.5598"
				L_0019: stelem.ref 
				L_001a: ldloc.s V_4
				L_001c: ldc.i4.2 
				L_001d: ldstr "1134.0864"
				L_0022: stelem.ref 
				L_0023: ldloc.s V_4
				L_0025: ldc.i4.3 
				L_0026: ldstr "2567.6046"
				L_002b: stelem.ref 
				L_002c: ldloc.s V_4
				L_002e: ldc.i4.4 
				L_002f: ldstr "35659.4543"
				L_0034: stelem.ref 
				L_0035: ldloc.s V_4
				L_0037: stloc.0 
				L_0038: ldc.i4.5 
				L_0039: newarr System.String
				L_003e: stloc.s V_5
				L_0040: ldloc.s V_5
				L_0042: ldc.i4.0 
				L_0043: ldstr "7"
				L_0048: stelem.ref 
				L_0049: ldloc.s V_5
				L_004b: ldc.i4.1 
				L_004c: ldstr "10"
				L_0051: stelem.ref 
				L_0052: ldloc.s V_5
				L_0054: ldc.i4.2 
				L_0055: ldstr "500"
				L_005a: stelem.ref 
				L_005b: ldloc.s V_5
				L_005d: ldc.i4.3 
				L_005e: ldstr "1000"
				L_0063: stelem.ref 
				L_0064: ldloc.s V_5
				L_0066: ldc.i4.4 
				L_0067: ldstr "10000"
				L_006c: stelem.ref 
				L_006d: ldloc.s V_5
				L_006f: stloc.1 
				L_0070: ldc.i4.0 
				L_0071: stloc.3 
				L_0072: ldc.i4.0 
				L_0073: stloc.2 
				L_0074: br.s L_0096
				L_0076: ldarg.0 
				L_0077: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox4
				L_007c: ldloc.1 
				L_007d: ldloc.2 
				L_007e: ldelem.ref 
				L_007f: callvirt System.Windows.Forms.Control::Void set_Text(System.String)
				L_0084: ldloc.3 
				L_0085: ldarg.0 
				L_0086: ldloc.0 
				L_0087: ldloc.2 
				L_0088: ldelem.ref 
				L_0089: call WindowsApplication1.Form1::Int32 asd(System.String)
				L_008e: ldc.i4.2 
				L_008f: mul 
				L_0090: add 
				L_0091: stloc.3 
				L_0092: ldloc.2 
				L_0093: ldc.i4.1 
				L_0094: add 
				L_0095: stloc.2 
				L_0096: ldloc.2 
				L_0097: ldc.i4.5 
				L_0098: blt.s L_0076
				L_009a: ldarg.0 
				L_009b: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox5
				L_00a0: ldloc.3 
				L_00a1: call System.Convert::System.String ToString(Int32)
				L_00a6: callvirt System.Windows.Forms.Control::Void set_Text(System.String)
				L_00ab: ret 
			*/
			
			
			{
				int k1;
string[] stringArray1 = new string[] { "3.7024", "6.5598", "1134.0864", "2567.6046", "35659.4543" };
				string[] A1 = stringArray1;
string[] stringArray2 = new string[] { "7", "10", "500", "1000", "10000" };
				string[] B1 = stringArray2;
				int score1 = 0;
				for (k1 = 0; (k1 < 5); k1++)
				{
					this.textBox4.Text = B1[k1];
					score1 += (this.asd (A1[k1]) * 2);
				}
				this.textBox5.Text = Convert.ToString (score1);
			}
			
			protected override void Dispose (bool disposing)
			
			/*
				// Code Size: 30 Bytes
				.maxstack 8
				L_0000: ldarg.1 
				L_0001: brfalse.s L_0016
				L_0003: ldarg.0 
				L_0004: ldfld WindowsApplication1.Form1::System.ComponentModel.IContainer components
				L_0009: brfalse.s L_0016
				L_000b: ldarg.0 
				L_000c: ldfld WindowsApplication1.Form1::System.ComponentModel.IContainer components
				L_0011: callvirt System.IDisposable::Void Dispose()
				L_0016: ldarg.0 
				L_0017: ldarg.1 
				L_0018: call System.Windows.Forms.Form::Void Dispose(Boolean)
				L_001d: ret 
			*/
			
			
			{
				if (disposing && (this.components != null))
				{
					this.components.Dispose ();
				}
				base.Dispose (disposing);
			}
			
			private void Form1_Load (object sender, EventArgs e)
			
			/*
				// Code Size: 1 Bytes
				.maxstack 8
				L_0000: ret 
			*/
			
			
			{
			}
			
			private void InitializeComponent ()
			
			/*
				// Code Size: 1138 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: newobj System.Windows.Forms.TextBox::Void .ctor()
				L_0006: stfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox1
				L_000b: ldarg.0 
				L_000c: newobj System.Windows.Forms.TextBox::Void .ctor()
				L_0011: stfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox2
				L_0016: ldarg.0 
				L_0017: newobj System.Windows.Forms.Button::Void .ctor()
				L_001c: stfld WindowsApplication1.Form1::System.Windows.Forms.Button button1
				L_0021: ldarg.0 
				L_0022: newobj System.Windows.Forms.Button::Void .ctor()
				L_0027: stfld WindowsApplication1.Form1::System.Windows.Forms.Button button2
				L_002c: ldarg.0 
				L_002d: newobj System.Windows.Forms.TextBox::Void .ctor()
				L_0032: stfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox4
				L_0037: ldarg.0 
				L_0038: newobj System.Windows.Forms.Button::Void .ctor()
				L_003d: stfld WindowsApplication1.Form1::System.Windows.Forms.Button button3
				L_0042: ldarg.0 
				L_0043: newobj System.Windows.Forms.Label::Void .ctor()
				L_0048: stfld WindowsApplication1.Form1::System.Windows.Forms.Label label1
				L_004d: ldarg.0 
				L_004e: newobj System.Windows.Forms.TextBox::Void .ctor()
				L_0053: stfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox5
				L_0058: ldarg.0 
				L_0059: call System.Windows.Forms.Control::Void SuspendLayout()
				L_005e: ldarg.0 
				L_005f: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox1
				L_0064: ldc.i4.s 20
				L_0066: ldc.i4.s 10
				L_0068: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_006d: callvirt System.Windows.Forms.Control::Void set_Location(System.Drawing.Point)
				L_0072: ldarg.0 
				L_0073: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox1
				L_0078: ldc.i4.1 
				L_0079: callvirt System.Windows.Forms.TextBoxBase::Void set_Multiline(Boolean)
				L_007e: ldarg.0 
				L_007f: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox1
				L_0084: ldstr "textBox1"
				L_0089: callvirt System.Windows.Forms.Control::Void set_Name(System.String)
				L_008e: ldarg.0 
				L_008f: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox1
				L_0094: ldc.i4 355
				L_0099: ldc.i4 238
				L_009e: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_00a3: callvirt System.Windows.Forms.Control::Void set_Size(System.Drawing.Size)
				L_00a8: ldarg.0 
				L_00a9: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox1
				L_00ae: ldc.i4.0 
				L_00af: callvirt System.Windows.Forms.Control::Void set_TabIndex(Int32)
				L_00b4: ldarg.0 
				L_00b5: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox2
				L_00ba: ldc.i4 416
				L_00bf: ldc.i4.s 11
				L_00c1: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_00c6: callvirt System.Windows.Forms.Control::Void set_Location(System.Drawing.Point)
				L_00cb: ldarg.0 
				L_00cc: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox2
				L_00d1: ldc.i4.1 
				L_00d2: callvirt System.Windows.Forms.TextBoxBase::Void set_Multiline(Boolean)
				L_00d7: ldarg.0 
				L_00d8: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox2
				L_00dd: ldstr "textBox2"
				L_00e2: callvirt System.Windows.Forms.Control::Void set_Name(System.String)
				L_00e7: ldarg.0 
				L_00e8: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox2
				L_00ed: ldc.i4 142
				L_00f2: ldc.i4 196
				L_00f7: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_00fc: callvirt System.Windows.Forms.Control::Void set_Size(System.Drawing.Size)
				L_0101: ldarg.0 
				L_0102: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox2
				L_0107: ldc.i4.1 
				L_0108: callvirt System.Windows.Forms.Control::Void set_TabIndex(Int32)
				L_010d: ldarg.0 
				L_010e: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button1
				L_0113: ldc.i4.s 35
				L_0115: ldc.i4 263
				L_011a: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_011f: callvirt System.Windows.Forms.Control::Void set_Location(System.Drawing.Point)
				L_0124: ldarg.0 
				L_0125: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button1
				L_012a: ldstr "button1"
				L_012f: callvirt System.Windows.Forms.Control::Void set_Name(System.String)
				L_0134: ldarg.0 
				L_0135: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button1
				L_013a: ldc.i4.s 78
				L_013c: ldc.i4.s 30
				L_013e: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_0143: callvirt System.Windows.Forms.Control::Void set_Size(System.Drawing.Size)
				L_0148: ldarg.0 
				L_0149: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button1
				L_014e: ldc.i4.2 
				L_014f: callvirt System.Windows.Forms.Control::Void set_TabIndex(Int32)
				L_0154: ldarg.0 
				L_0155: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button1
				L_015a: ldstr "Build"
				L_015f: callvirt System.Windows.Forms.Control::Void set_Text(System.String)
				L_0164: ldarg.0 
				L_0165: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button1
				L_016a: ldc.i4.1 
				L_016b: callvirt System.Windows.Forms.ButtonBase::Void set_UseVisualStyleBackColor(Boolean)
				L_0170: ldarg.0 
				L_0171: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button1
				L_0176: ldarg.0 
				L_0177: ldftn WindowsApplication1.Form1::Void button1_Click(System.Object, System.EventArgs)
				L_017d: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0182: callvirt System.Windows.Forms.Control::Void add_Click(System.EventHandler)
				L_0187: ldarg.0 
				L_0188: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button2
				L_018d: ldc.i4 146
				L_0192: ldc.i4 267
				L_0197: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_019c: callvirt System.Windows.Forms.Control::Void set_Location(System.Drawing.Point)
				L_01a1: ldarg.0 
				L_01a2: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button2
				L_01a7: ldstr "button2"
				L_01ac: callvirt System.Windows.Forms.Control::Void set_Name(System.String)
				L_01b1: ldarg.0 
				L_01b2: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button2
				L_01b7: ldc.i4.s 77
				L_01b9: ldc.i4.s 25
				L_01bb: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_01c0: callvirt System.Windows.Forms.Control::Void set_Size(System.Drawing.Size)
				L_01c5: ldarg.0 
				L_01c6: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button2
				L_01cb: ldc.i4.3 
				L_01cc: callvirt System.Windows.Forms.Control::Void set_TabIndex(Int32)
				L_01d1: ldarg.0 
				L_01d2: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button2
				L_01d7: ldstr "Factorial"
				L_01dc: callvirt System.Windows.Forms.Control::Void set_Text(System.String)
				L_01e1: ldarg.0 
				L_01e2: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button2
				L_01e7: ldc.i4.1 
				L_01e8: callvirt System.Windows.Forms.ButtonBase::Void set_UseVisualStyleBackColor(Boolean)
				L_01ed: ldarg.0 
				L_01ee: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button2
				L_01f3: ldarg.0 
				L_01f4: ldftn WindowsApplication1.Form1::Void button2_Click(System.Object, System.EventArgs)
				L_01fa: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_01ff: callvirt System.Windows.Forms.Control::Void add_Click(System.EventHandler)
				L_0204: ldarg.0 
				L_0205: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox4
				L_020a: ldc.i4 419
				L_020f: ldc.i4 228
				L_0214: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0219: callvirt System.Windows.Forms.Control::Void set_Location(System.Drawing.Point)
				L_021e: ldarg.0 
				L_021f: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox4
				L_0224: ldstr "textBox4"
				L_0229: callvirt System.Windows.Forms.Control::Void set_Name(System.String)
				L_022e: ldarg.0 
				L_022f: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox4
				L_0234: ldc.i4 128
				L_0239: ldc.i4.s 20
				L_023b: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_0240: callvirt System.Windows.Forms.Control::Void set_Size(System.Drawing.Size)
				L_0245: ldarg.0 
				L_0246: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox4
				L_024b: ldc.i4.5 
				L_024c: callvirt System.Windows.Forms.Control::Void set_TabIndex(Int32)
				L_0251: ldarg.0 
				L_0252: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox4
				L_0257: ldstr "7"
				L_025c: callvirt System.Windows.Forms.Control::Void set_Text(System.String)
				L_0261: ldarg.0 
				L_0262: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button3
				L_0267: ldc.i4 254
				L_026c: ldc.i4 269
				L_0271: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0276: callvirt System.Windows.Forms.Control::Void set_Location(System.Drawing.Point)
				L_027b: ldarg.0 
				L_027c: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button3
				L_0281: ldstr "button3"
				L_0286: callvirt System.Windows.Forms.Control::Void set_Name(System.String)
				L_028b: ldarg.0 
				L_028c: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button3
				L_0291: ldc.i4.s 98
				L_0293: ldc.i4.s 24
				L_0295: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_029a: callvirt System.Windows.Forms.Control::Void set_Size(System.Drawing.Size)
				L_029f: ldarg.0 
				L_02a0: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button3
				L_02a5: ldc.i4.6 
				L_02a6: callvirt System.Windows.Forms.Control::Void set_TabIndex(Int32)
				L_02ab: ldarg.0 
				L_02ac: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button3
				L_02b1: ldstr "button3"
				L_02b6: callvirt System.Windows.Forms.Control::Void set_Text(System.String)
				L_02bb: ldarg.0 
				L_02bc: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button3
				L_02c1: ldc.i4.1 
				L_02c2: callvirt System.Windows.Forms.ButtonBase::Void set_UseVisualStyleBackColor(Boolean)
				L_02c7: ldarg.0 
				L_02c8: ldfld WindowsApplication1.Form1::System.Windows.Forms.Label label1
				L_02cd: ldc.i4.1 
				L_02ce: callvirt System.Windows.Forms.Control::Void set_AutoSize(Boolean)
				L_02d3: ldarg.0 
				L_02d4: ldfld WindowsApplication1.Form1::System.Windows.Forms.Label label1
				L_02d9: ldc.i4 411
				L_02de: ldc.i4 272
				L_02e3: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_02e8: callvirt System.Windows.Forms.Control::Void set_Location(System.Drawing.Point)
				L_02ed: ldarg.0 
				L_02ee: ldfld WindowsApplication1.Form1::System.Windows.Forms.Label label1
				L_02f3: ldstr "label1"
				L_02f8: callvirt System.Windows.Forms.Control::Void set_Name(System.String)
				L_02fd: ldarg.0 
				L_02fe: ldfld WindowsApplication1.Form1::System.Windows.Forms.Label label1
				L_0303: ldc.i4.s 38
				L_0305: ldc.i4.s 13
				L_0307: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_030c: callvirt System.Windows.Forms.Control::Void set_Size(System.Drawing.Size)
				L_0311: ldarg.0 
				L_0312: ldfld WindowsApplication1.Form1::System.Windows.Forms.Label label1
				L_0317: ldc.i4.7 
				L_0318: callvirt System.Windows.Forms.Control::Void set_TabIndex(Int32)
				L_031d: ldarg.0 
				L_031e: ldfld WindowsApplication1.Form1::System.Windows.Forms.Label label1
				L_0323: ldstr "Score:"
				L_0328: callvirt System.Windows.Forms.Control::Void set_Text(System.String)
				L_032d: ldarg.0 
				L_032e: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox5
				L_0333: ldc.i4 455
				L_0338: ldc.i4 267
				L_033d: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0342: callvirt System.Windows.Forms.Control::Void set_Location(System.Drawing.Point)
				L_0347: ldarg.0 
				L_0348: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox5
				L_034d: ldstr "textBox5"
				L_0352: callvirt System.Windows.Forms.Control::Void set_Name(System.String)
				L_0357: ldarg.0 
				L_0358: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox5
				L_035d: ldc.i4.1 
				L_035e: callvirt System.Windows.Forms.TextBoxBase::Void set_ReadOnly(Boolean)
				L_0363: ldarg.0 
				L_0364: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox5
				L_0369: ldc.i4.s 92
				L_036b: ldc.i4.s 20
				L_036d: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_0372: callvirt System.Windows.Forms.Control::Void set_Size(System.Drawing.Size)
				L_0377: ldarg.0 
				L_0378: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox5
				L_037d: ldc.i4.8 
				L_037e: callvirt System.Windows.Forms.Control::Void set_TabIndex(Int32)
				L_0383: ldarg.0 
				L_0384: ldc.r4 6
				L_0389: ldc.r4 13
				L_038e: newobj System.Drawing.SizeF::Void .ctor(Single, Single)
				L_0393: call System.Windows.Forms.ContainerControl::Void set_AutoScaleDimensions(System.Drawing.SizeF)
				L_0398: ldarg.0 
				L_0399: ldc.i4.1 
				L_039a: call System.Windows.Forms.ContainerControl::Void set_AutoScaleMode(System.Windows.Forms.AutoScaleMode)
				L_039f: ldarg.0 
				L_03a0: ldc.i4 570
				L_03a5: ldc.i4 320
				L_03aa: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_03af: call System.Windows.Forms.Form::Void set_ClientSize(System.Drawing.Size)
				L_03b4: ldarg.0 
				L_03b5: call System.Windows.Forms.Control::ControlCollection get_Controls()
				L_03ba: ldarg.0 
				L_03bb: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox5
				L_03c0: callvirt System.Windows.Forms.Control+ControlCollection::Void Add(System.Windows.Forms.Control)
				L_03c5: ldarg.0 
				L_03c6: call System.Windows.Forms.Control::ControlCollection get_Controls()
				L_03cb: ldarg.0 
				L_03cc: ldfld WindowsApplication1.Form1::System.Windows.Forms.Label label1
				L_03d1: callvirt System.Windows.Forms.Control+ControlCollection::Void Add(System.Windows.Forms.Control)
				L_03d6: ldarg.0 
				L_03d7: call System.Windows.Forms.Control::ControlCollection get_Controls()
				L_03dc: ldarg.0 
				L_03dd: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button3
				L_03e2: callvirt System.Windows.Forms.Control+ControlCollection::Void Add(System.Windows.Forms.Control)
				L_03e7: ldarg.0 
				L_03e8: call System.Windows.Forms.Control::ControlCollection get_Controls()
				L_03ed: ldarg.0 
				L_03ee: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox4
				L_03f3: callvirt System.Windows.Forms.Control+ControlCollection::Void Add(System.Windows.Forms.Control)
				L_03f8: ldarg.0 
				L_03f9: call System.Windows.Forms.Control::ControlCollection get_Controls()
				L_03fe: ldarg.0 
				L_03ff: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button2
				L_0404: callvirt System.Windows.Forms.Control+ControlCollection::Void Add(System.Windows.Forms.Control)
				L_0409: ldarg.0 
				L_040a: call System.Windows.Forms.Control::ControlCollection get_Controls()
				L_040f: ldarg.0 
				L_0410: ldfld WindowsApplication1.Form1::System.Windows.Forms.Button button1
				L_0415: callvirt System.Windows.Forms.Control+ControlCollection::Void Add(System.Windows.Forms.Control)
				L_041a: ldarg.0 
				L_041b: call System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0420: ldarg.0 
				L_0421: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox2
				L_0426: callvirt System.Windows.Forms.Control+ControlCollection::Void Add(System.Windows.Forms.Control)
				L_042b: ldarg.0 
				L_042c: call System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0431: ldarg.0 
				L_0432: ldfld WindowsApplication1.Form1::System.Windows.Forms.TextBox textBox1
				L_0437: callvirt System.Windows.Forms.Control+ControlCollection::Void Add(System.Windows.Forms.Control)
				L_043c: ldarg.0 
				L_043d: ldstr "Form1"
				L_0442: call System.Windows.Forms.Control::Void set_Name(System.String)
				L_0447: ldarg.0 
				L_0448: ldstr "Quiz Evaluator-Prof. Yousef  B. Mahdy"
				L_044d: callvirt System.Windows.Forms.Control::Void set_Text(System.String)
				L_0452: ldarg.0 
				L_0453: ldarg.0 
				L_0454: ldftn WindowsApplication1.Form1::Void Form1_Load(System.Object, System.EventArgs)
				L_045a: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_045f: call System.Windows.Forms.Form::Void add_Load(System.EventHandler)
				L_0464: ldarg.0 
				L_0465: ldc.i4.0 
				L_0466: call System.Windows.Forms.Control::Void ResumeLayout(Boolean)
				L_046b: ldarg.0 
				L_046c: call System.Windows.Forms.Control::Void PerformLayout()
				L_0471: ret 
			*/
			
			
			{
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.textBox2 = new System.Windows.Forms.TextBox();
                this.button1 = new System.Windows.Forms.Button();
                this.button2 = new System.Windows.Forms.Button();
                this.textBox4 = new System.Windows.Forms.TextBox();
                this.button3 = new System.Windows.Forms.Button();
                this.label1 = new System.Windows.Forms.Label();
                this.textBox5 = new System.Windows.Forms.TextBox();
                this.SuspendLayout();
                // 
                // textBox1
                // 
                this.textBox1.Location = new System.Drawing.Point(20, 10);
                this.textBox1.Multiline = true;
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(355, 238);
                this.textBox1.TabIndex = 0;
                // 
                // textBox2
                // 
                this.textBox2.Location = new System.Drawing.Point(416, 11);
                this.textBox2.Multiline = true;
                this.textBox2.Name = "textBox2";
                this.textBox2.Size = new System.Drawing.Size(142, 196);
                this.textBox2.TabIndex = 1;
                // 
                // button1
                // 
                this.button1.Location = new System.Drawing.Point(35, 263);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(78, 30);
                this.button1.TabIndex = 2;
                this.button1.Text = "Build";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                // 
                // button2
                // 
                this.button2.Location = new System.Drawing.Point(146, 267);
                this.button2.Name = "button2";
                this.button2.Size = new System.Drawing.Size(77, 25);
                this.button2.TabIndex = 3;
                this.button2.Text = "Factorial";
                this.button2.UseVisualStyleBackColor = true;
                this.button2.Click += new System.EventHandler(this.button2_Click);
                // 
                // textBox4
                // 
                this.textBox4.Location = new System.Drawing.Point(419, 228);
                this.textBox4.Name = "textBox4";
                this.textBox4.Size = new System.Drawing.Size(128, 20);
                this.textBox4.TabIndex = 5;
                this.textBox4.Text = "7";
                // 
                // button3
                // 
                this.button3.Location = new System.Drawing.Point(254, 269);
                this.button3.Name = "button3";
                this.button3.Size = new System.Drawing.Size(98, 24);
                this.button3.TabIndex = 6;
                this.button3.Text = "button3";
                this.button3.UseVisualStyleBackColor = true;
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(411, 272);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(38, 13);
                this.label1.TabIndex = 7;
                this.label1.Text = "Score:";
                // 
                // textBox5
                // 
                this.textBox5.Location = new System.Drawing.Point(455, 267);
                this.textBox5.Name = "textBox5";
                this.textBox5.ReadOnly = true;
                this.textBox5.Size = new System.Drawing.Size(92, 20);
                this.textBox5.TabIndex = 8;
                // 
                // frm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(570, 320);
                this.Controls.Add(this.textBox5);
                this.Controls.Add(this.label1);
                this.Controls.Add(this.button3);
                this.Controls.Add(this.textBox4);
                this.Controls.Add(this.button2);
                this.Controls.Add(this.button1);
                this.Controls.Add(this.textBox2);
                this.Controls.Add(this.textBox1);
                this.Name = "frm";
                this.Text = "Quiz Evaluator-Prof. Yousef  B. Mahdy";
                this.Load += new System.EventHandler(this.Form1_Load);
                this.ResumeLayout(false);
                this.PerformLayout();

			}
			
		#endregion
	}
	
}

