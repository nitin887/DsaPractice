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
      int[] number = [1, 2, 3, 4, 5];
      int n = number.Length - 1;
      bool isfound = false;
      for (int i = 1; i < number.Length; i++)
      {
         number[i - 1] = number[i];
      }

      if (isfound)
      {
         n--;
      }

      for (int i = 0; i < n; i++)
      {
         Console.WriteLine(number[i]);

      }
   }
}
