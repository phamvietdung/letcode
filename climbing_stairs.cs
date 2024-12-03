public class Solution {
    public int ClimbStairs(int n) {
     int[] SplitToOneAndTwo(int total, int range)
            {

                var result = new int[range];

                var timesOf2 = total - range;

                var timesOf1 = total - timesOf2 * 2;

                //Console.WriteLine($"[{range}]times : {timesOf1} {timesOf2}");

                for (var i = 0; i < timesOf2; i++)
                {
                    result[i] = 2;
                };

                if(timesOf1 > 0)
                {
                    for (var i = timesOf2; i < timesOf1 + timesOf2; i++)
                    {
                        result[i] = 1;
                    }
                }

               


                return result;
            }

            static BigInteger Factorial(int n)
            {
                BigInteger result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }

            BigInteger HowManyUniQueStringMakeFrom2Number(int[] numbers)
            {
                var times1 = numbers.Where(w => w.Equals(1)).Count();

                var times2 = numbers.Where(w => w.Equals(2)).Count();

                var total = numbers.Count();

                var _ = Factorial(total);
                var _1 = Factorial(times1);
                var _2 = Factorial(times2);

                return Factorial(total) / (Factorial(times1) * Factorial(times2));
            }

            var isOdd = !(n % 2 == 0);

            var minRange = isOdd ? (n / 2) + 1 : n / 2;

            var maxRange = n;

            int count = 0;

            int[] range = new int[maxRange];

            for (var i = minRange; i <= maxRange; i++)
            {
                //var _ = SplitToOneAndTwo(n, i);

                count += (int)HowManyUniQueStringMakeFrom2Number(SplitToOneAndTwo(n, i));



                //Console.WriteLine(string.Join(",", _));
            }

            return count;   
    }
}
