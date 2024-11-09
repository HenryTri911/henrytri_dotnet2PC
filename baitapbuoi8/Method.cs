class Bai2
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numDict.ContainsKey(complement))
            {
                return new int[] { numDict[complement], i };
            }

            if (!numDict.ContainsKey(nums[i]))
            {
                numDict[nums[i]] = i;
            }
        }

        return new int[] { }; // Trả về mảng rỗng nếu không tìm thấy
    }
}

class Bai3
{
public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int uniqueIndex = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[uniqueIndex])
            {
                uniqueIndex++;
                nums[uniqueIndex] = nums[i];
            }
        }

        return uniqueIndex + 1;
    }
}

class Bai4
{
public static IList<int> PhanTuNhieuNhat(int[] nums, int k) 
    {
          var tanSo = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (tanSo.ContainsKey(num))
                tanSo[num]++;
            else
                tanSo[num] = 1;
        }
        var sapXepTheoTanSo = tanSo.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
        return sapXepTheoTanSo.Take(k).ToList();
    }
}

class Bai5
{
public static int MaxProfit(int[] prices) 
    {
        if (prices == null || prices.Length < 2)
            return 0;

        int minPrice = prices[0];
        int maxProfit = 0;

        foreach (var price in prices)
        {
            if (price < minPrice)
            {
                minPrice = price; 
            }
            else
            {
                int profit = price - minPrice; 
                if (profit > maxProfit)
                {
                    maxProfit = profit; 
                }
            }
        }
        return maxProfit; 
    }

}