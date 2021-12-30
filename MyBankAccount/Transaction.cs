﻿// See https://aka.ms/new-console-template for more information
public class Transaction
{
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Note { get; }

    public Transaction(decimal amount, DateTime date, string note)
    {
        Amount = amount;
        Date = date;
        Note = note;
    }
}