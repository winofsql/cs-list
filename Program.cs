using System;
using System.Collections.Generic;

namespace cs_list
{
  class Program
  {

    static void Main(string[] args)
    {
      var ll = "------";
      var list = new List<string>();

      Console.WriteLine( $"Before Capacity:Count {list.Capacity} : {list.Count}" );

      list.Add("飲料用 ヨーグルト");
      list.Add("鳥弁当");
      list.Add("レーズンデニッシュ");
      list.Add("カップトマトスープ");
      list.Add("カップきのこスープ");

      Console.WriteLine( $"After Capacity/Count {list.Capacity} : {list.Count}" );


      forprint( list );

      Console.WriteLine();

      foreach(string data in list)
      {
        Console.WriteLine(data);
      }

      list.Insert(1, ll);
      list.Insert(3, ll);
      list.Insert(3, ll);
      list.Insert(3, ll);

      forprint( list );

      list[3] = "ハンバーグ弁当";
      list.RemoveAt(4);
      list.Remove("カップトマトスープ");

      forprint( list );

      list.Sort();

      forprint( list );

      list.RemoveRange(0, 2);

      forprint( list );

      list.Clear();

      list.Add("食べやすいチーズ");
      list.Add("ごまドレッシング");
      list.Add("ポン酢");
      list.Add("生卵");
      list.Add("れんこんつくね");

      forprint( list );

    }

    private static void forprint(List<string> list)
    {
      Console.WriteLine();

      for (int i = 0; i < list.Count; i++)
      {
        Console.WriteLine($"{i} : {list[i]}");
      }
    }
  }
}
