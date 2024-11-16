class TuDienAnhViet {
    public static void process ()
    {
        // 1. Thêm từ

        Dictionary<string,string> dictionary = new Dictionary<string, string>();
        while(true) // dừng đến khi user nhập vào option4(thoát thì dừng chương trình)
        {
            Console.WriteLine("1. Thêm từ");
            Console.WriteLine("2. Tra từ");
            Console.WriteLine("3. Xóa từ");
            Console.WriteLine("4. Tra từ tiếng việt");
            Console.WriteLine("5. Thoát");
            Console.WriteLine("Mời bạn chọn chức năng");
            int choice = Convert.ToInt32(Console.ReadLine());
            //int choice = int.Parse(Console.ReadLine());
            if (choice==1)
            {
                Console.WriteLine("Mời bạn nhập từ tiếng Anh:");
                string english = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập tiếng Việt tương ứng:");
                string vietnamese = Console.ReadLine ();
                //them english và vietnamese vào Dic
                //c1:
                dictionary[english]=vietnamese;
                //c2:
                // dictionary.Add (english,vietnamese);
                Console.WriteLine("Đã thêm thành công");
            }
            else if (choice==2)
            {
                Console.WriteLine("Mời bạn nhập từ cần tra:");
                string english = Console.ReadLine(); 
                // ContainsKey để tìm cặp key-value
                if (dictionary.ContainsKey(english))
                {
                    Console.WriteLine($"Nghĩa của từ {english} là: {dictionary[english]}");
                }
                else 
                {
                    Console.WriteLine("Từ này chưa có trong từ điển");
                }
                Console.WriteLine ("-------------");
            }
            else if (choice ==3)
            {
                //Remove để xóa từ trong từ điển
                Console.WriteLine("Mời bạn nhập từ cần xóa: ");
                string english = Console.ReadLine();
                if(dictionary.Remove(english)==true)
                {
                    Console.WriteLine("Xóa từ thành công");
                }
                else
                {
                    Console.WriteLine("từ này không tồn tại");
                }
                Console.WriteLine ("-------------");
            }
            else if (choice==4)
            {
                Console.WriteLine("Mời bạn nhập từ tiếng việt");
                string vietnamese = Console.ReadLine();
                string englishOutput = null; //biến flag để đánh dấu, nếu ko tìm thấy từ tiếng ANh tương ứng => ko tìm thấy
                //duyệt từng key-value trong dictionary và so sánh với value nhập từ bàn phím
                foreach(KeyValuePair<string,string> pointer in dictionary)
                {
                    if(pointer.Value == vietnamese )
                    {
                        englishOutput = pointer.Key;
                        break; //nếu tìm thấy rồi thì không duyệt dictionary
                    }
                }
                if(englishOutput!=null)
                {
                    Console.WriteLine ($"Từ tiếng Anh tương ứng là: {englishOutput}");
                }
                else 
                {
                    Console.WriteLine ("Không tìm thấy từ tiếng ANh tương ứng");
                }
                Console.WriteLine ("-------------");
            }
            else
            {
                break;
            }
        }
    }



}