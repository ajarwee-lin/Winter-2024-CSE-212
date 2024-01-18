using System;
using System.Collections.Generic;

class ArraysTester
{
    static void Main()
    {
        // Testing the MultiplesOf function
        List<double> multiples = MultiplesOf(3, 5);
        Console.WriteLine("Multiples of 3 (5 times): " + string.Join(", ", multiples));

        // Testing the RotateListRight function
        List<int> dataList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int amountToRotate = 5;
        List<int> rotatedList = RotateListRight(dataList, amountToRotate);
        Console.WriteLine($"Rotated List to the Right by {amountToRotate}: " + string.Join(", ", rotatedList));
    }

    static List<double> MultiplesOf(double startingNumber, int numberOfMultiples)
    {
        List<double> result = new List<double>();
        for (int i = 1; i <= numberOfMultiples; i++)
        {
            result.Add(startingNumber * i);
        }
        return result;
    }

    static List<T> RotateListRight<T>(List<T> data, int amount)
    {
        int n = data.Count;
        // Calculate the effective rotation amount to avoid unnecessary full cycles
        int rotationAmount = amount % n;

        // Use List methods to perform the rotation
        List<T> rotatedList = data.GetRange(n - rotationAmount, rotationAmount);
        rotatedList.AddRange(data.GetRange(0, n - rotationAmount));

        return rotatedList;
    }
}
