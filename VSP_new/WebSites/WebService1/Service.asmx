

<%@ WebService Language="c#" Class="MathService"%>
using System;
using System.Web.Services;
[WebService(Namespace="http://localhost/test")]
public class MathService : WebService
{
  [WebMethod]
  public int Add(int a, int b)
  {
   int answer;
   answer = a + b;
   return answer;
  }
  [WebMethod]
  public int Subtract(int a, int b)
  {
   int answer;
   answer = a - b;
   return answer;
  }
  [WebMethod]
  public int Multiply(int a, int b)
  {
   int answer;
   answer = a * b;
   return answer;
  }
  [WebMethod]
  public int Divide(int a, int b)
  {
   int answer;
   if (b != 0)
   {
     answer = a / b;
     return answer;
   } else
     return 0;
  }
}

