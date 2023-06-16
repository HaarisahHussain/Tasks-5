Imports System

Module Program
    Sub Main()

        'Delcaring variables
        Dim number1 As Integer
        Dim number2 As Integer
        'Declaring Constants 
        number1 = 1
        number2 = 1
        '{0} represents a position within a string which will later be replaced with a value. 
        ' "" represents invokation
        'Creating a loop that continiously outputs "1"

        While number2 < 200
            'Output variable to the console line 
            Console.WriteLine(number2)
            'num 2 value changes and 1 is being added/minus each time a one is outputted to the console
            number2 = number2 + number1
            number1 = number2 - number1

        End While
        Console.ReadLine()
    End Sub
End Module