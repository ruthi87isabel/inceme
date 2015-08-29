using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTools
{
    public static  class FuzzyStrings
    {
        public static double JaroWinklerDistance(this string source, string target)
        {
            double jaroDistance = source.JaroDistance(target);
            double commonPrefixLength = CommonPrefixLength(source, target);

            return jaroDistance + (commonPrefixLength * 0.1 * (1 - jaroDistance));
        }

        public static double JaroWinklerDistanceWithPrefixScale(string source, string target, double p)
        {
            double prefixScale;

            if (p > 0.25) { prefixScale = 0.25; } // The maximu value for distance to not exceed 1
            else if (p < 0) { prefixScale = 0; } // The Jaro Distance
            else { prefixScale = p; }

            double jaroDistance = source.JaroDistance(target);
            double commonPrefixLength = CommonPrefixLength(source, target);

            return jaroDistance + (commonPrefixLength * prefixScale * (1 - jaroDistance));
        }

        public static double JaroDistance(this string source, string target)
        {
            int m = source.Intersect(target).Count();

            if (m == 0) { return 0; }
            string sourceTargetIntersetAsString = "";
            string targetSourceIntersetAsString = "";
            IEnumerable<char> sourceIntersectTarget = source.Intersect(target);
            IEnumerable<char> targetIntersectSource = target.Intersect(source);
            foreach (char character in sourceIntersectTarget) { sourceTargetIntersetAsString += character; }
            foreach (char character in targetIntersectSource) { targetSourceIntersetAsString += character; }
            double t = sourceTargetIntersetAsString.LevenshteinDistance(targetSourceIntersetAsString) / 2;
            return ((m / source.Length) + (m / target.Length) + ((m - t) / m)) / 3;
        }

        public static int LevenshteinDistance(this string source, string target)
        {
            if (source.Length == 0) { return target.Length; }
            if (target.Length == 0) { return source.Length; }

            int distance = source[source.Length - 1] == target[target.Length - 1] ? 0 : 1;

            return Math.Min(Math.Min(LevenshteinDistance(source.Substring(0, source.Length - 1), target) + 1,
                                     LevenshteinDistance(source, target.Substring(0, target.Length - 1))) + 1,
                                     LevenshteinDistance(source.Substring(0, source.Length - 1), target.Substring(0, target.Length - 1)) + distance);
        }

        public static double NormalizedLevenshteinDistance(this string source, string target)
        {
            int unnormalizedLevenshteinDistance = source.LevenshteinDistance(target);

            return unnormalizedLevenshteinDistance - source.LevenshteinDistanceLowerBounds(target);
        }

        public static int LevenshteinDistanceUpperBounds(this string source, string target)
        {
            // If the two strings are the same length then the Hamming Distance is the upper bounds of the Levenshtien Distance.
            if (source.Length == target.Length) { return source.HammingDistance(target); }

            // Otherwise, the upper bound is the length of the longer string.
            if (source.Length > target.Length) { return source.Length; }
            if (target.Length > source.Length) { return target.Length; }

            return 9999;
        }

        public static int LevenshteinDistanceLowerBounds(this string source, string target)
        {
            // If the two strings are the same length then the lower bound is zero.
            if (source.Length == target.Length) { return 0; }

            // If the two strings are different lengths then the lower bounds is the difference in length.
            return Math.Abs(source.Length - target.Length);
        }

        public static int HammingDistance(this string source, string target)
        {
            int distance = 0;

            if (source.Length == target.Length)
            {
                for (int i = 0; i < source.Length; i++)
                {
                    if (!source[i].Equals(target[i]))
                    {
                        distance++;
                    }
                }
                return distance;
            }
            return 99999;
        }

        private static double CommonPrefixLength(string source, string target)
        {
            int maximumPrefixLength = 4;
            int commonPrefixLength = 0;
            if (source.Length <= 4 || target.Length <= 4) { maximumPrefixLength = Math.Min(source.Length, target.Length); }

            for (int i = 0; i < maximumPrefixLength; i++)
            {
                if (source[i].Equals(target[i])) { commonPrefixLength++; }
                else { return commonPrefixLength; }
            }

            return commonPrefixLength;
        }
    }
}
