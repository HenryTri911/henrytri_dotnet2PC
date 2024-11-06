class Bai3 {
    public static List<string> findStartM (List<string> listString){
        List<string> results = new List<string> ();
        foreach (string str in listString) {
           if (str.Contains("m") == true) {
            results.Add(str);
           }
        }
        return results;
    }
}