using System;
using System.Linq;

namespace CurveLock
{
  public static class Common
  {
    public static string Id { get; set; }
    public static byte[] PublicKey { get; set; }
    public static byte[] PrivateKey { get; set; }

    public static T[] ConcatArrays<T>(params T[][] arrays)
    {
      var result = new T[arrays.Sum(arr => arr.Length)];
      var offset = 0;

      foreach (var arr in arrays)
      {
        Buffer.BlockCopy(arr, 0, result, offset, arr.Length);
        offset += arr.Length;
      }

      return result;
    }

    public static T[] SubArray<T>(T[] arr, int start, int length)
    {
      var result = new T[length];
      Buffer.BlockCopy(arr, start, result, 0, length);

      return result;
    }

    public static T[] SubArray<T>(T[] arr, int start)
    {
      return SubArray(arr, start, arr.Length - start);
    }
  }
}
