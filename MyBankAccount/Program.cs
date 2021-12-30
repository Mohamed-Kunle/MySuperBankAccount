// See https://aka.ms/new-console-template for more information


Console.WriteLine("My Super, Banck Account!");
Console.WriteLine();
Console.WriteLine("-------------------------------------------");


BankAccount account = new BankAccount("Mohamed",1000);

account.MakeWithDrawal(21, DateTime.Now, "Xbox Game");
account.MakeWithDrawal(611, DateTime.Now, "Ps5  Game");



Console.WriteLine();
Console.WriteLine(account.GetAccountHistory());

Console.WriteLine($"The account {account.Number} is created for {account.Owner} with balance  {account.Balance.ToString("C")}");