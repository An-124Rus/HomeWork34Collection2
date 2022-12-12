using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.CursorVisible = false;

        int numberOfClients = 10;

        Queue<int> purchase = new Queue<int>();

        LoadClientPurchaseSum(purchase, numberOfClients);

        ServiceOfQueue(purchase);
    }

    static void LoadClientPurchaseSum(Queue<int> purchase, int numberOfClients)
    {
        int minValue = 100;
        int maxValue = 1000;

        Random random = new Random();

        for (int i = 0; i < numberOfClients; i++)
            purchase.Enqueue(random.Next(minValue, maxValue));
    }

    static void ServiceOfQueue(Queue<int> purchase)
    {
        int shopAccountSum = 0;
        int index = 1;


        while (purchase.Count > 0)
        {
            int clientPurchaseSum = purchase.Peek();

            Console.WriteLine($"Обслуживание {index} клиента.\n");
            Console.WriteLine($"Клиент {index} купил товаров на сумму - {clientPurchaseSum} руб.\n");
            Console.WriteLine($"Сумма счёта в магазине до обслуживания {index} клиента - {shopAccountSum} руб.");

            shopAccountSum += purchase.Dequeue();

            Console.WriteLine($"Сумма счёта в магазине после обслуживания {index} клиента - {shopAccountSum} руб.");
            Console.ReadKey();
            Console.Clear();

            index++;
        }
    }
}