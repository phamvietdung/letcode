public class Solution
{
    public int MaxArea(int[] height)
    {
        var maxArea = 0; var maxY = 0;

        var length = height.Length;

        var maxHeight = height.Max();

        for (var i = 0; i < length; i++)
        {
            if (height[i] == 0) continue;

            if (maxHeight * (length - i) < maxArea) continue;

            for (var j = length - 1; j >= i; j--)
            {
                if (maxY > height[j]) continue;

                var _tempMax2 = j - i;

                if (_tempMax2 <= 0) continue;

                var _tempMax1 = height[i] > height[j] ? height[j] : height[i];

                if (_tempMax1 > maxY)
                {
                    maxY = _tempMax1;

                    var newArea = _tempMax1 * _tempMax2;

                    maxArea = newArea > maxArea ? newArea : maxArea;
                }
            }
        }

        return maxArea;
    }
}