public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int count = 0;
        if(n == 0 || (flowerbed.Length == 1 && flowerbed[0] == 0 && n == 1))
        {
            return true;
        }
        if (flowerbed.Length == 1 && flowerbed[0] == 1 && n == 1)
        {
            return false;
        }
        for (int i = 0; i < flowerbed.Length; ++i)
        {
            if (i == 0)
            {
                if (flowerbed[i + 1] == 0 && flowerbed[i] == 0)
                {
                    ++count;
                    flowerbed[i] = 1;
                    continue;

                }
            }
            else if (i == flowerbed.Length - 1)
            {
                if (flowerbed[i - 1] == 0 && flowerbed[i] == 0)
                {
                    ++count;
                    flowerbed[i] = 1;
                    continue;
                }
            }
            else if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0 && flowerbed[i] == 0)
            {
                ++count;
                flowerbed[i] = 1;
                continue;

            }
        }

        return count >= n;
    }
}