class WordCount
{
    public static void process ()
    {
        Console.WriteLine ("Mời bạn nhập đoạn văn:");
        string text = Console.ReadLine();
        //B1: tách từ
        string [] words = text.Split(new[] {',','.',' ','?','!'}, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string,int> wordcounts=new Dictionary<string, int>();
        foreach (string word in words)
        {
            //chuyển các từ viết hoa thành viết thường
            string lowerWord = word.ToLower ();
            if (wordcounts.ContainsKey(lowerWord))
            {
                wordcounts[lowerWord]++;
            }
            else
            {
                wordcounts[lowerWord]=1;
            }
        }
        Console.WriteLine("Số lần xuất hiện từ từ là:");
        foreach (KeyValuePair<string,int> pointer in wordcounts)
        {
        Console.WriteLine ($"Từ '{pointer.Key}' xuất hiện {pointer.Value} lần"); 
        }
    }
}