Imports System

Module Program
    Sub Main()
        Dim number, mean, average As Integer
        Dim total, grandTotal As Integer

        Console.WriteLine("Enter numbers to be added")
        number = Console.ReadLine
        Console.WriteLine("Number to be averaged")
        average = Console.ReadLine
        For counter = 1 To number
            Console.WriteLine("enter numbers")
            grandTotal = Console.ReadLine
            total = grandTotal + number
        Next
        Console.WriteLine("Total is:" & total)
        mean = (total / average)
        Console.WriteLine("Mean is:" & mean)
        Console.ReadLine()


    End Sub
End Module
