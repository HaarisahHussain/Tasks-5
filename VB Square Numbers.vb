Imports System

Module Program
    Sub Main(args As String())
        'Delcaring variable
        Dim squared As Integer
        'Looping counter until it reaches 20
        For counter = 1 To 20
            'calculation which will square numbers from the loop
            squared = counter * counter
            Console.WriteLine("1 is:" & "" & squared)
        Next
        Console.ReadLine()
    End Sub
End Module
