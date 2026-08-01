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
      int[] arr = [1, 2, 34, 5];
      int[] arr1 = [1, 2, 34, 5];
      bool issame = false;
      int i = 0;
      int j = 0;
      while (i < arr.Length && j < arr.Length)
      {
         if (arr[i] != arr1[j])
         {
            issame = false;
            break;

         }
         else
         {
            issame = true;
            i++;
            j++;
         }

      }
      Console.WriteLine(issame);
   }

}