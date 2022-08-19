// See https://aka.ms/new-console-template for more information
using Entities;
using System.Text.Json;

Dictionary<string, List<TransactionEntity>> dic = new();

List<List<TransactionEntity>> GroupTransactions(List<TransactionEntity> transactions)
{
    foreach(var transaction in transactions)
    {
        if (!dic.ContainsKey(transaction.PaymentMethod))
            dic.Add(transaction.PaymentMethod, new List<TransactionEntity> { transaction });
        else
            dic[transaction.PaymentMethod].Add(transaction);

        // Em caso de necessidade de contar um chave unica...
        
        // if (!dic.ContainsKey(transaction.PaymentMethod))
        //     dic.Add($"{transaction.Id}-{transaction.PaymentMethod}", new List<TransactionEntity> { transaction });
        // else
        //     dic[$"{transaction.Id}-{transaction.PaymentMethod}"].Add(transaction);
    }

    return dic.Select(x => x.Value).ToList();
}

Console.WriteLine(JsonSerializer.Serialize(GroupTransactions(new TransactionEntity().Seed())));
