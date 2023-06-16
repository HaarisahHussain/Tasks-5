Imports System

Module Program
    Sub Main()
        'Delcaring variables
        Dim numberOfBottles As String = ("Please enter the number of bottles")
        'Outputs variable
        Console.Write(numberOfBottles)
        Console.Read()
        'Looping counter up until 9 
        For counter = 1 To 9
            'Outputs line by line
            Console.WriteLine(counter & " " & "bottles sitting on the wall")

        Next
        Console.ReadLine()
    End Sub
End Module
