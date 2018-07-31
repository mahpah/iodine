using System;

namespace Iodine.Infrastructure.Setup
{
    public static class Utils
    {
        public static int Rand(int from, int to)
        {
            var gen = new Random();
            return gen.Next(from, to);
        }

        public static string Rand(params string[] sources)
        {
            return sources[Rand(0, sources.Length - 1)];
        }

        public static string ToCamelCasing(this string str)
        {
            if (string.IsNullOrEmpty(str)) return str;
            return char.ToLowerInvariant(str[0]) + str.Substring(1);
        }
    }
}
