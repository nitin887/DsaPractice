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
      int low = 0;
      int target = 3;
      int high = number.Length - 1;
      while (low < high)
      {
         int mid = low + (high - low) / 2;
         if (number[mid] == target)
         {
            Console.WriteLine(mid);
         }
         if (number[mid] < target)
         {
            low = mid + 1;
         }
         else
         {
            high = mid - 1;
         }
      }

   }


}

