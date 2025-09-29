Module RememberingVB

    Sub Main()
        Console.WriteLine("Hello, World!")
        'Console.Beep(75, 500)
        'play notes

        'C
        Console.Beep(262, 500)
        'G
        Console.Beep(196, 250)
        'Gb
        Console.Beep(185, 250)
        'G#
        Console.Beep(208, 500)
        'G
        Console.Beep(196, 500)

        'silent rest
        System.Threading.Thread.Sleep(500)

        'B
        Console.Beep(247, 500)
        'C
        Console.Beep(262, 500)


        Console.Read()
    End Sub

End Module
