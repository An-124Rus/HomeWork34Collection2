﻿internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfClients = 10;

        Queue<int> purchase = new Queue<int>();

        getClientPurchaseSum(ref purchase, numberOfClients);

        ServiceOfQueue(purchase, numberOfClients);
    }

    static void getClientPurchaseSum(ref Queue<int> purchase, int numberOfClients)
    {
        int minValue = 100;
        int maxValue = 1000;
        int clientPurchaseSum;

        Random random = new Random();

        for (int i = 0; i < numberOfClients; i++)
        {
            clientPurchaseSum = random.Next(minValue, maxValue);

            purchase.Enqueue(clientPurchaseSum);
        }
    }

    static void ServiceOfQueue(Queue<int> purchase, int numberOfClients)
    {
        int shopAccountSum = 0;

        for (int i = 1; i < numberOfClients + 1; i++)
        {
            int clientPurchaseSum = purchase.Peek();

            Console.CursorVisible = false;

            Console.WriteLine($"Обслуживание {i} клиента.\n");
            Console.WriteLine($"Клиент {i} купил товаров на сумму - {clientPurchaseSum} руб.\n");

            shopAccountSum += purchase.Dequeue();

            Console.WriteLine($"Общая сумма счёта в магазине после обслуживания {i} клиента - {shopAccountSum} руб.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}