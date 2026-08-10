using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO.Pipelines;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Security.Cryptography;
class Revision
{
   /*         



   */
   static void Main()
   {
      int[] number = [1, 2, 3, 4];
      int[] numbers = new int[number.Length + 1];
      for (int i = 0; i < numbers.Length; i++)
      {
         if (i == numbers.Length - 1)
         {
            numbers[i] = 12;

         }
         else
         {
            numbers[i] = number[i];
         }

      }
      foreach (int x in numbers)
      {
         Console.WriteLine(x);
      }

   }
}