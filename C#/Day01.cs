using System;

public class MaxMinArray {
    public static void FindMaxMin(int[] arr) {
        int max = arr[0];
        int min = arr[0];

        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] > max) {
                max = arr[i];
            }
            if (arr[i] < min) {
                min = arr[i];
            }
        }

        Console.WriteLine("Maximum: " + max);
        Console.WriteLine("Minimum: " + min);
    }

    public static void Main(string[] args) {
        int[] arr = { 5, 9, 3, 7, 2, 1 };
        FindMaxMin(arr);
    }
}
