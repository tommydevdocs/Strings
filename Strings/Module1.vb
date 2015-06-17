Module Module1

    Sub Main()
        'Dim strings(3) As String
        'strings(0) = "My ""so called"" life"
        'strings(1) = "What if I need" & vbNewLine & "a new line"
        'strings(2) = "What if I need" & vbTab & "a new tab"
        'For Each phrase In strings
        '    Console.WriteLine(phrase)
        'Next

        Dim strings(6) As String
        strings(0) = String.Format("{0}!", "A car for sale")
        strings(1) = String.Format("Make: {0} Model: {1} {2}", "BMW", "745li", "1995")
        strings(2) = String.Format("{0:C}", 23000.0)
        strings(3) = String.Format("{0:N}", 1234567890)
        strings(4) = String.Format("{0:P}", 0.23)
        strings(5) = String.Format("{0:(###)###-####}", 8193199510)

        For Each phrase In strings
            Console.WriteLine(phrase)
        Next

        Console.ReadLine()

        
    End Sub

End Module
