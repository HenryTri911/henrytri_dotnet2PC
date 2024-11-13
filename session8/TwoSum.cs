class TwoSum
{
    public static List<int> twoSum(List<int>lst, int target)
    {
        for(int i = 0; i <lst.Count-1; i++)
        {
            for (int j = i +1; j <lst.Count; j++)
            {
                if(lst[i] + lst[j]==target)
                {
                    return new List<int>{i,j};
                }
            }
        }
        return null;
    }

    public static List<int> twoSumDictionary(List<int> lst, int target)
    {
        // khai báo Dictionary để đánh dấu từng số trong danh sách
        Dictionary<int,int> seenNumber = new Dictionary<int, int>();
        for(int i =0; i <lst.Count;i++)
        {
            int completion = target -lst[i];
            if(seenNumber.ContainsKey(completion))
            {
                return new List<int> {seenNumber[completion],i};
            }
            else
            {
                //nếu conpletion ko nằm trong dic => add vào dic để đánh dấu
                seenNumber.Add(lst[i],i);
            }
        }
        return null;
    }
    public static Dictionary<string, int> solanxuanhien(string[] words)
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {          
                wordCount[word]++;
            }
            else
            {  
                wordCount[word] = 1;
            }
        }
        return wordCount;
    }
}