public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        bool isSatisfyCondition(int i, int j)
        {
            if (i != j * 2) return false;

            return true;
        }

        for (var i = 0; i < arr.Length; i++)
        {
            for (var j = 0; j < arr.Length; j++)
            {

                if (i == j) continue;

                if (isSatisfyCondition(arr[i], arr[j])) return true;
            }
        }

        return false;
    }
}