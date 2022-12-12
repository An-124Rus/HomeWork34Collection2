using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.CursorVisible = false;

        int numberOfClients = 10;

        Queue<int> purchases = new Queue<int>();

        CreateClientPurchaseSum(purchases, numberOfClients);

        ServeQueue(purchases);
    }

    static void CreateClientPurchaseSum(Queue<int> purchases, int numberOfClients)
    {
        int minValue = 100;
        int maxValue = 1000;

        Random random = new Random();

        for (int i = 0; i < numberOfClients; i++)
            purchases.Enqueue(random.Next(minValue, maxValue));
    }

    static void ServeQueue(Queue<int> purchases)
    {
        int shopAccountSum = 0;
        int index = 1;

        while (purchases.Count > 0)
        {
            int clientPurchaseSum = purchases.Peek();

            Console.WriteLine($"Обслуживание {index} клиента.\n");
            Console.WriteLine($"Клиент {index} купил товаров на сумму - {clientPurchaseSum} руб.\n");
            Console.WriteLine($"Сумма счёта в магазине до обслуживания {index} клиента - {shopAccountSum} руб.");

            shopAccountSum += purchases.Dequeue();

            Console.WriteLine($"Сумма счёта в магазине после обслуживания {index} клиента - {shopAccountSum} руб.");
            Console.ReadKey();
            Console.Clear();

            index++;
        }
    }
}