using System;
using System.IO;
using System.Globalization;

namespace debugws2
{
  class Program
  {
    private long sum()
    {
      string[] data = File.ReadAllLines("data");
      long total = 0;

      for (int x = 0; x < data.Length; x++)
      {
        total += cnv(data[x]);//check if lines arent being skipped
      }

      return total;
    }

    private int cnv(string val)
    {
      Int32.TryParse(val, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int value);
      //Console.Write("String: "+ val);
      //Console.WriteLine(" - INT {0}: "+ value);
      return value;
    }

    static void Main(string[] args)
    {
      var p = new Program();
      Console.WriteLine("Total: {0}", p.sum());
    }
  }
}