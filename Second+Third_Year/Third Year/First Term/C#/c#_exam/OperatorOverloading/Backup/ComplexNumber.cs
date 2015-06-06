// Fig. 10.26: ComplexNumber.cs
// Class that overloads operators for adding, subtracting
// and multiplying complex numbers.

namespace OperatorOverloading 
{
   public class ComplexNumber
   {
      private int real; 
      private int imaginary; 

      // default constructor
      public ComplexNumber() {}

      // constructor
      public ComplexNumber( int a, int b )
      {
         Real = a;
         Imaginary = b;
      }
  
      // return string representation of ComplexNumber
      public override string ToString() 
      { 
         return "( " + real + 
            ( imaginary < 0 ? " - " + (imaginary * -1) : 
            " + "  + imaginary ) + "i )"; 
      } 
  
      // property Real
      public int Real 
      { 
         get 
         { 
            return real; 
         } 

         set 
         { 
            real = value; 
         }
 
      } // end property Real 
  
      // property Imaginary
      public int Imaginary 
      { 
         get 
         { 
            return imaginary; 
         } 

         set 
         { 
            imaginary = value; 
         }
 
      } // end property Imaginary
   
      // overload the addition operator
      public static ComplexNumber operator + ( 
         ComplexNumber x, ComplexNumber y ) 
      { 
         return new ComplexNumber(
            x.Real + y.Real, x.Imaginary + y.Imaginary ); 
      } 

      // provide alternative to overloaded + operator
      // for addition
      public static ComplexNumber Add( ComplexNumber x, 
         ComplexNumber y )
      {
         return x + y;
      }

      // overload the subtraction operator
      public static ComplexNumber operator - ( 
         ComplexNumber x, ComplexNumber y ) 
      { 
         return new ComplexNumber(
            x.Real - y.Real, x.Imaginary - y.Imaginary ); 
      } 

      // provide alternative to overloaded - operator
      // for subtraction
      public static ComplexNumber Subtract( ComplexNumber x, 
         ComplexNumber y )
      {
         return x - y;
      }

      // overload the multiplication operator
      public static ComplexNumber operator * ( 
         ComplexNumber x, ComplexNumber y ) 
      { 
         return new ComplexNumber( 
            x.Real * y.Real - x.Imaginary * y.Imaginary, 
            x.Real * y.Imaginary + y.Real * x.Imaginary ); 
      }

      // provide alternative to overloaded * operator
      // for multiplication
      public static ComplexNumber Multiply( ComplexNumber x,
         ComplexNumber y )
      {
         return x * y;
      }

   } // end class ComplexNumber
}