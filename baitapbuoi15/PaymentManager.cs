using System.Transactions;
using Newtonsoft.Json;
public class PaymentManager
{
    private List<Transaction> transactions;
    private string filePath = "transactions.json";

    private void LoadTransactions()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            transactions = JsonConvert.DeserializeObject<List<Transaction>>(json)??new List<Transaction>();
        }
        else
        {
            transactions = new List<Transaction>();
        }
    }

    private void SaveTransaction()
    {
        string json = JsonConvert.SerializeObject(transactions,Formatting.Indented);
        File.WriteAllText(filePath,json);
    }

    public PaymentManager()
    {
        LoadTransactions();
    }

    
    public void AddTransaction(string method, double amount)
    {
        var transaction=new Transaction
        {
            PaymentMenthod=method,
            Amount =amount
        };
        transactions.Add(transaction);
        SaveTransaction();
    }

    public void ViewTransactions()
    {
        Console.WriteLine("Lịch sử giao dịch:");
        foreach (var transaction in transactions)
        {
            Console.WriteLine($"Phương thức thanh toán:{transaction.PaymentMenthod} - Số tiền :{transaction.Amount}");
        }
    }
}