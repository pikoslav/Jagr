using static System.Console;
using System.Diagnostics;

namespace Jagr;


public class Program
{
  public static void Main()
  {
    var items = new CategoryValue[]
    {
      new CategoryValue("Platform", Environment.OSVersion.Platform),
      new CategoryValue("Version", Environment.OSVersion.Version),
      new CategoryValue("64bit OS", Environment.Is64BitOperatingSystem),
      new CategoryValue("64bit process", Environment.Is64BitProcess),
    };
    Dump(items);
  }

  private record struct CategoryValue(String Category, Object Value);

  private static void Dump(IList<CategoryValue> items)
  {
    var padding = items.Max(x => x.Category.Length);
    foreach(var item in items)
    {
      WriteLine(item.Category.PadRight(padding) + " ... " + item.Value.ToString());
    }
  }

}