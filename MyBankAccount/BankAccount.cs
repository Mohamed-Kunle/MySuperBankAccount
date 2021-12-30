// See https://aka.ms/new-console-template for more information
public class BankAccount
{
    public string Number { get; }
    public string Owner { get; set; }

    public decimal Balance
    {
        get
        {
            decimal balance = 0;

            foreach (var item in alltransations)
            {
                balance += item.Amount;
            }
            return balance;
        }
    }

    List<Transaction> alltransations = new List<Transaction>();

    private static int AccountNumberSeed = 123456789;

    public BankAccount(string name , decimal initialBalance)
    {
        Owner = name;
        Number = AccountNumberSeed.ToString();

        MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

        AccountNumberSeed++;
    }


    public void MakeDeposit(decimal amount, DateTime date, string note="Hello")
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Lacagtaad la baxayso wa inay ka waynaata 0");
        }

        Console.WriteLine($"Waxaad dhigatay lacag dhan {amount.ToString("C")}");
        var deposit = new Transaction(amount, date, note);
        alltransations.Add(deposit);
    }

    public void MakeWithDrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Lacagtaad la dhigayso wa inay ka waynaata 0");
        }
        if (Balance - amount < 0)
        {
            throw new InvalidOperationException( "Hadhaagu kuguma filna");
        }
        Console.WriteLine($"Waxaad la baxday lacag dhan {amount.ToString("C")}");
        var withdrawal = new Transaction(-amount, date, note);
        alltransations.Add(withdrawal);
    }

    public string GetAccountHistory()
    {
        var report = new StringBuilder();

        //HEADER
        report.AppendLine("Date\t \tAmount\tNote  ");

        foreach (var item in alltransations)
        {
            //ROW
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}$\t{item.Note}");
        }

        return report.ToString();
    }
}

