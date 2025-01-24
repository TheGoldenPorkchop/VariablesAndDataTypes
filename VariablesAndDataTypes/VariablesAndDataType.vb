''Angel Nava
'Spring 2025
'RCET2265
'VariablesAndDataType
'link needed
Option Explicit On
Option Strict Off
Module VariablesAndDataType

    Sub Main()

        Dim jellyBeans As Integer
        Dim laffyTaffy As Integer
        Dim baconCola As String
        Dim money As Decimal

        Dim userInputFruit As String

        Console.WriteLine(jellyBeans)

        jellyBeans = 120
        Console.WriteLine(jellyBeans)

        jellyBeans += jellyBeans
        Console.WriteLine(jellyBeans)

        laffyTaffy = 25
        Console.WriteLine(laffyTaffy)

        baconCola = "I love sugar"
        Console.WriteLine(baconCola)

        money = 9.126789876543D 'a random number
        jellyBeans = CInt(1.56)
        baconCola = "7"

        jellyBeans = CInt(baconCola)

        'user input

        Console.WriteLine("Please enter a fruit")
        userInputFruit = Console.ReadLine()
        Console.WriteLine("You selected: " & userInputFruit)
        Console.WriteLine()

    End Sub

End Module
