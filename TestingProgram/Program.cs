using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using CryptoPrice;
using CryptoPrice.Definitions;
namespace TestingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            CryptoCore cp = new CryptoCore("");

            cp.SetCurrency = Fiat.USN;
            //cp.SetCurrency = "XAU";
            String test = "";
            Console.WriteLine(test);




            #region create blocks of code
            //List<String> Finished = new List<string>();

            //foreach (String line in System.IO.File.ReadLines(@"C:\Source\CryptoPrice\TestingProgram\Currencies.txt"))
            //{
            //    if (Finished.Contains(line) == false)
            //    {
            //        StringBuilder sb = new StringBuilder();
            //        sb.Append(String.Format("public static String {0}", line));
            //        sb.Append("{");
            //        String code = "get { return \"%%\"; }";
            //        code = code.Replace("%%", line);
            //        sb.Append(code);
            //        sb.Append("}");

            //        Finished.Add(line);
            //        Console.WriteLine(sb);
            //    }
            //}
            #endregion
        }
    }
}
