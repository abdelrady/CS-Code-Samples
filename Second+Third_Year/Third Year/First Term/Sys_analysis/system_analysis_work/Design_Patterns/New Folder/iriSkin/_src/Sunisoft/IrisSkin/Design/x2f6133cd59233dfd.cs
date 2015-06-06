//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin.Design

{
		
		#region Namespace Import Declarations
		
			using Sunisoft.IrisSkin;
			using System.CodeDom;
			using System.Collections;
			using System.ComponentModel;
			using System.ComponentModel.Design.Serialization;
			using System;
			
			
		#endregion
		
	public class x2f6133cd59233dfd : CodeDomSerializer
	
	{
		
		#region Constructors
		
			public x2f6133cd59233dfd ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.ComponentModel.Design.Serialization.CodeDomSerializer::Void .ctor()
				L_0006: ret 
			*/
		#endregion
		
		#region Methods
		
			public override object Deserialize (IDesignerSerializationManager manager, object codeDomObject)
			
			/*
				// Code Size: 46 Bytes
				.maxstack 4
				.locals (System.ComponentModel.Design.Serialization.CodeDomSerializer V_0)
				L_0000: ldarg.1 
				L_0001: ldtoken Sunisoft.IrisSkin.SkinEngine
				L_0006: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_000b: callvirt System.Type::System.Type get_BaseType()
				L_0010: ldtoken System.ComponentModel.Design.Serialization.CodeDomSerializer
				L_0015: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_001a: callvirt System.ComponentModel.Design.Serialization.IDesignerSerializationManager::System.Object GetSerializer(System.Type, System.Type)
				L_001f: castclass System.ComponentModel.Design.Serialization.CodeDomSerializer
				L_0024: stloc.0 
				L_0025: ldloc.0 
				L_0026: ldarg.1 
				L_0027: ldarg.2 
				L_0028: callvirt System.ComponentModel.Design.Serialization.CodeDomSerializer::System.Object Deserialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager, System.Object)
				L_002d: ret 
			*/
			
			
			{
				CodeDomSerializer codeDomSerializer1 = ((CodeDomSerializer) manager.GetSerializer (typeof (ISkinEngine).BaseType, typeof (CodeDomSerializer)));
				return codeDomSerializer1.Deserialize (manager, codeDomObject);
			}
			
			public override object Serialize (IDesignerSerializationManager manager, object value)
			
			/*
				// Code Size: 551 Bytes
				.maxstack 7
				.locals (System.ComponentModel.Design.Serialization.CodeDomSerializer V_0, 
         System.Object V_1, 
         System.Boolean V_2, 
         System.CodeDom.CodeStatementCollection V_3, 
         System.CodeDom.CodeFieldReferenceExpression V_4, 
         System.CodeDom.CodeObjectCreateExpression V_5, 
         System.CodeDom.CodeExpression V_6, 
         System.CodeDom.CodePropertyReferenceExpression V_7, 
         System.CodeDom.CodePrimitiveExpression V_8, 
         System.CodeDom.CodeStatement V_9, 
         System.CodeDom.CodeStatement V_10, 
         System.Int32 V_11, 
         System.Collections.IEnumerator V_12, 
         System.CodeDom.CodeExpression[] V_13, 
         System.IDisposable V_14)
				.try L_004a to L_0182 finally L_0182 to L_0197
				L_0000: ldarg.1 
				L_0001: ldtoken Sunisoft.IrisSkin.SkinEngine
				L_0006: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_000b: callvirt System.Type::System.Type get_BaseType()
				L_0010: ldtoken System.ComponentModel.Design.Serialization.CodeDomSerializer
				L_0015: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_001a: callvirt System.ComponentModel.Design.Serialization.IDesignerSerializationManager::System.Object GetSerializer(System.Type, System.Type)
				L_001f: castclass System.ComponentModel.Design.Serialization.CodeDomSerializer
				L_0024: stloc.0 
				L_0025: ldloc.0 
				L_0026: ldarg.1 
				L_0027: ldarg.2 
				L_0028: callvirt System.ComponentModel.Design.Serialization.CodeDomSerializer::System.Object Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager, System.Object)
				L_002d: stloc.1 
				L_002e: ldc.i4.1 
				L_002f: stloc.2 
				L_0030: ldloc.1 
				L_0031: isinst System.CodeDom.CodeStatementCollection
				L_0036: brfalse L_0225
				L_003b: ldloc.1 
				L_003c: castclass System.CodeDom.CodeStatementCollection
				L_0041: stloc.3 
				L_0042: ldloc.3 
				L_0043: callvirt System.Collections.CollectionBase::System.Collections.IEnumerator GetEnumerator()
				L_0048: stloc.s V_12
				L_004a: br L_0174
				L_004f: ldloc.s V_12
				L_0051: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0056: castclass System.CodeDom.CodeStatement
				L_005b: stloc.s V_9
				L_005d: ldloc.s V_9
				L_005f: isinst System.CodeDom.CodeAssignStatement
				L_0064: brfalse L_0174
				L_0069: ldloc.s V_9
				L_006b: castclass System.CodeDom.CodeAssignStatement
				L_0070: callvirt System.CodeDom.CodeAssignStatement::System.CodeDom.CodeExpression get_Left()
				L_0075: stloc.s V_6
				L_0077: ldloc.s V_6
				L_0079: isinst System.CodeDom.CodePropertyReferenceExpression
				L_007e: brfalse.s L_00ec
				L_0080: ldloc.s V_6
				L_0082: castclass System.CodeDom.CodePropertyReferenceExpression
				L_0087: stloc.s V_7
				L_0089: ldloc.s V_7
				L_008b: callvirt System.CodeDom.CodePropertyReferenceExpression::System.String get_PropertyName()
				L_0090: ldstr "BuiltIn"
				L_0095: call System.String::Boolean op_Equality(System.String, System.String)
				L_009a: brfalse L_0174
				L_009f: ldloc.s V_9
				L_00a1: castclass System.CodeDom.CodeAssignStatement
				L_00a6: callvirt System.CodeDom.CodeAssignStatement::System.CodeDom.CodeExpression get_Right()
				L_00ab: isinst System.CodeDom.CodePrimitiveExpression
				L_00b0: brfalse L_0174
				L_00b5: ldloc.s V_9
				L_00b7: castclass System.CodeDom.CodeAssignStatement
				L_00bc: callvirt System.CodeDom.CodeAssignStatement::System.CodeDom.CodeExpression get_Right()
				L_00c1: castclass System.CodeDom.CodePrimitiveExpression
				L_00c6: stloc.s V_8
				L_00c8: ldloc.s V_8
				L_00ca: callvirt System.CodeDom.CodePrimitiveExpression::System.Object get_Value()
				L_00cf: isinst System.Boolean
				L_00d4: brfalse L_0174
				L_00d9: ldloc.s V_8
				L_00db: callvirt System.CodeDom.CodePrimitiveExpression::System.Object get_Value()
				L_00e0: unbox System.Boolean
				L_00e5: ldind.i1 
				L_00e6: stloc.2 
				L_00e7: br L_0174
				L_00ec: ldloc.s V_6
				L_00ee: isinst System.CodeDom.CodeFieldReferenceExpression
				L_00f3: brfalse L_0174
				L_00f8: ldloc.s V_9
				L_00fa: castclass System.CodeDom.CodeAssignStatement
				L_00ff: callvirt System.CodeDom.CodeAssignStatement::System.CodeDom.CodeExpression get_Left()
				L_0104: castclass System.CodeDom.CodeFieldReferenceExpression
				L_0109: stloc.s V_4
				L_010b: ldloc.s V_4
				L_010d: callvirt System.CodeDom.CodeFieldReferenceExpression::System.String get_FieldName()
				L_0112: ldarg.1 
				L_0113: ldarg.2 
				L_0114: callvirt System.ComponentModel.Design.Serialization.IDesignerSerializationManager::System.String GetName(System.Object)
				L_0119: call System.String::Boolean op_Inequality(System.String, System.String)
				L_011e: brtrue.s L_0174
				L_0120: ldloc.s V_9
				L_0122: castclass System.CodeDom.CodeAssignStatement
				L_0127: callvirt System.CodeDom.CodeAssignStatement::System.CodeDom.CodeExpression get_Right()
				L_012c: isinst System.CodeDom.CodeObjectCreateExpression
				L_0131: brfalse.s L_0174
				L_0133: ldtoken Sunisoft.IrisSkin.SkinEngine
				L_0138: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_013d: ldc.i4.1 
				L_013e: newarr System.CodeDom.CodeExpression
				L_0143: stloc.s V_13
				L_0145: ldloc.s V_13
				L_0147: ldc.i4.0 
				L_0148: ldtoken System.ComponentModel.Component
				L_014d: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_0152: newobj System.CodeDom.CodeThisReferenceExpression::Void .ctor()
				L_0157: newobj System.CodeDom.CodeCastExpression::Void .ctor(System.Type, System.CodeDom.CodeExpression)
				L_015c: stelem.ref 
				L_015d: ldloc.s V_13
				L_015f: newobj System.CodeDom.CodeObjectCreateExpression::Void .ctor(System.Type, System.CodeDom.CodeExpression[])
				L_0164: stloc.s V_5
				L_0166: ldloc.s V_9
				L_0168: castclass System.CodeDom.CodeAssignStatement
				L_016d: ldloc.s V_5
				L_016f: callvirt System.CodeDom.CodeAssignStatement::Void set_Right(System.CodeDom.CodeExpression)
				L_0174: ldloc.s V_12
				L_0176: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_017b: brtrue L_004f
				L_0180: leave.s L_0197
				L_0182: ldloc.s V_12
				L_0184: isinst System.IDisposable
				L_0189: stloc.s V_14
				L_018b: ldloc.s V_14
				L_018d: brfalse.s L_0196
				L_018f: ldloc.s V_14
				L_0191: callvirt System.IDisposable::Void Dispose()
				L_0196: endfinally 
				L_0197: ldloc.2 
				L_0198: brtrue L_0225
				L_019d: ldloc.3 
				L_019e: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_01a3: ldc.i4.1 
				L_01a4: sub 
				L_01a5: stloc.s V_11
				L_01a7: br L_021d
				L_01ac: ldloc.3 
				L_01ad: ldloc.s V_11
				L_01af: callvirt System.CodeDom.CodeStatementCollection::System.CodeDom.CodeStatement get_Item(Int32)
				L_01b4: stloc.s V_10
				L_01b6: ldloc.s V_10
				L_01b8: isinst System.CodeDom.CodeAssignStatement
				L_01bd: brfalse.s L_0217
				L_01bf: ldloc.s V_10
				L_01c1: castclass System.CodeDom.CodeAssignStatement
				L_01c6: callvirt System.CodeDom.CodeAssignStatement::System.CodeDom.CodeExpression get_Left()
				L_01cb: stloc.s V_6
				L_01cd: ldloc.s V_6
				L_01cf: isinst System.CodeDom.CodePropertyReferenceExpression
				L_01d4: brfalse.s L_0217
				L_01d6: ldloc.s V_6
				L_01d8: castclass System.CodeDom.CodePropertyReferenceExpression
				L_01dd: stloc.s V_7
				L_01df: ldloc.s V_7
				L_01e1: callvirt System.CodeDom.CodePropertyReferenceExpression::System.String get_PropertyName()
				L_01e6: ldstr "SkinStream"
				L_01eb: call System.String::Boolean op_Equality(System.String, System.String)
				L_01f0: brfalse.s L_01fc
				L_01f2: ldloc.3 
				L_01f3: ldloc.s V_11
				L_01f5: callvirt System.Collections.CollectionBase::Void RemoveAt(Int32)
				L_01fa: br.s L_0217
				L_01fc: ldloc.s V_7
				L_01fe: callvirt System.CodeDom.CodePropertyReferenceExpression::System.String get_PropertyName()
				L_0203: ldstr "SkinStreamMain"
				L_0208: call System.String::Boolean op_Equality(System.String, System.String)
				L_020d: brfalse.s L_0217
				L_020f: ldloc.3 
				L_0210: ldloc.s V_11
				L_0212: callvirt System.Collections.CollectionBase::Void RemoveAt(Int32)
				L_0217: ldloc.s V_11
				L_0219: ldc.i4.1 
				L_021a: sub 
				L_021b: stloc.s V_11
				L_021d: ldloc.s V_11
				L_021f: ldc.i4.0 
				L_0220: bge L_01ac
				L_0225: ldloc.1 
				L_0226: ret 
			*/
			
			
			{
				CodeFieldReferenceExpression codeFieldReferenceExpression1;
				CodeObjectCreateExpression codeObjectCreateExpression1;
				CodeExpression codeExpression1;
				CodePropertyReferenceExpression codePropertyReferenceExpression1;
				CodePrimitiveExpression codePrimitiveExpression1;
				CodeStatement codeStatement2;
				CodeExpression[] codeExpressionArray1;
				CodeDomSerializer codeDomSerializer1 = ((CodeDomSerializer) manager.GetSerializer (typeof (ISkinEngine).BaseType, typeof (CodeDomSerializer)));
				object object1 = codeDomSerializer1.Serialize (manager, value);
				bool b1 = true;
				if (! (object1 is CodeStatementCollection))
				{
					return object1;
				}
				CodeStatementCollection codeStatementCollection1 = ((CodeStatementCollection) object1);
				foreach (CodeStatement codeStatement1 in codeStatementCollection1)
				{
					if (codeStatement1 is CodeAssignStatement)
					{
						codeExpression1 = ((CodeAssignStatement) codeStatement1).Left;
						if (! (codeExpression1 is CodePropertyReferenceExpression))
						{
							if (codeExpression1 is CodeFieldReferenceExpression)
							{
								codeFieldReferenceExpression1 = ((CodeFieldReferenceExpression) ((CodeAssignStatement) codeStatement1).Left);
								if ((codeFieldReferenceExpression1.FieldName != manager.GetName (value)) || (! (((CodeAssignStatement) codeStatement1).Right is CodeObjectCreateExpression)))
								{
									continue;
								}
								codeExpressionArray1 = new CodeExpression[] { ((CodeExpression) new CodeCastExpression (typeof (Component), ((CodeExpression) new CodeThisReferenceExpression ()))) };
								codeObjectCreateExpression1 = new CodeObjectCreateExpression (typeof (ISkinEngine), codeExpressionArray1);
								((CodeAssignStatement) codeStatement1).Right = ((CodeExpression) codeObjectCreateExpression1);
							}
							continue;
						}
						codePropertyReferenceExpression1 = ((CodePropertyReferenceExpression) codeExpression1);
						if ((codePropertyReferenceExpression1.PropertyName != "BuiltIn") || (! (((CodeAssignStatement) codeStatement1).Right is CodePrimitiveExpression)))
						{
							continue;
						}
						codePrimitiveExpression1 = ((CodePrimitiveExpression) ((CodeAssignStatement) codeStatement1).Right);
						if (! (codePrimitiveExpression1.Value is bool))
						{
							continue;
						}
						b1 = ((bool) codePrimitiveExpression1.Value);
					}
				}
				if (! b1)
				{
					for (int i1 = (codeStatementCollection1.Count - 1); (i1 >= 0); i1--)
					{
						codeStatement2 = codeStatementCollection1[i1];
						if (codeStatement2 is CodeAssignStatement)
						{
							codeExpression1 = ((CodeAssignStatement) codeStatement2).Left;
							if (codeExpression1 is CodePropertyReferenceExpression)
							{
								codePropertyReferenceExpression1 = ((CodePropertyReferenceExpression) codeExpression1);
								switch (codePropertyReferenceExpression1.PropertyName)
								{
									case "SkinStream":
									
									{
											codeStatementCollection1.RemoveAt (i1);
											break;
									}
									default:
									
									{
											if (codePropertyReferenceExpression1.PropertyName == "SkinStreamMain")
											{
												codeStatementCollection1.RemoveAt (i1);
											}
											break;
									}
								}
							}
						}
					}
				}
				return object1;
			}
			
		#endregion
	}
	
}

