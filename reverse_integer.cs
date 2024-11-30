public class Solution
{
    // https://leetcode.com/problems/reverse-integer/
    public int Reverse(int x)
    {
        bool isPositiveNumber = x > 0 ? true : false;

        var splitDot = x.ToString().Split('.').First();

        string xToString = splitDot.ToString().Replace("-", "").Replace("+", "");

        var xStringReverse = string.Join("", xToString.Reverse());

        var reverseLong = long.Parse(xStringReverse);

        if (reverseLong > Int32.MaxValue || reverseLong < Int32.MinValue) return 0;

        return isPositiveNumber ? (int)reverseLong : -1 * (int)reverseLong;
    }
}