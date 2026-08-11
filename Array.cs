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
      int[] number = [1, 2, 3, 5, 6];
      int number1 = 34;
      bool isfound = false;
      for (int i = 0; i < number.Length; i++)
      {

         if (number[i] == number1)
         {
            Console.WriteLine(i);
            isfound = true;

         }



      }
      if (!isfound)
      {
         Console.WriteLine("no index is present");
      }


   }
}
