using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.CursorVisible = false;

        int numberOfClients = 10;

        Queue<int> clientsPurchases = new Queue<int>();

        CreateClientsPurchasesSum(clientsPurchases, numberOfClients);

        ServeQueue(clientsPurchases);
    }

    static void CreateClientsPurchasesSum(Queue<int> clientsPurchases, int numberOfClients)
    {
        int minValue = 100;
        int maxValue = 1000;

        Random random = new Random();

        for (int i = 0; i < numberOfClients; i++)
            clientsPurchases.Enqueue(random.Next(minValue, maxValue));
    }

    static void ServeQueue(Queue<int> clientsPurchases)
    {
        int shopAccountSum = 0;
        int index = 1;

        while (clientsPurchases.Count > 0)
        {
            int clientPurchaseSum = clientsPurchases.Peek();

            Console.WriteLine($"Обслуживание {index} клиента.\n");
            Console.WriteLine($"Клиент {index} купил товаров на сумму - {clientPurchaseSum} руб.\n");
            Console.WriteLine($"Сумма счёта в магазине до обслуживания {index} клиента - {shopAccountSum} руб.");

            shopAccountSum += clientsPurchases.Dequeue();

            Console.WriteLine($"Сумма счёта в магазине после обслуживания {index} клиента - {shopAccountSum} руб.");
            Console.ReadKey();
            Console.Clear();

            index++;
        }
    }
}