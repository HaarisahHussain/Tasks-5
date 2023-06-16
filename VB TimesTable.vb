Imports System

Module Program
    Sub Main(args As String())

        'Delcaring a variable
        Dim number As String
        'Asking the user for input
        Console.Write("Please enter a number between 1-12")
        'Assigning the variable
        number = Console.ReadLine()
        'Looping counter up until 12
        For counter = 1 To 12
            'Outputs the calculation as well as text
            Console.WriteLine("The answer is: " & " " & counter * number)
        Next
        Console.ReadLine()
    End Sub
End Module
