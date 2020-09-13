'Ian Gunter
'RCET 0265
'Multiplication Table
'Fall 2020
'https://github.com/IanGunter/Multiplication-Table.git

Option Explicit On
Option Strict On
Option Compare Text



Module MultiplicationTable

    Sub Main()
        Dim column As Integer
        Dim row As Integer
        Dim table(12, 12) As Integer
        Dim numberInput As Integer
        Dim input As String
        Dim goodData As Boolean

        'Set the window size of the console so the table fits inside it. 
        Console.SetWindowSize(100, 40)

        Do
            Console.WriteLine("Enter a number for a multiplication table Or press Q to quit.")
            Try
                input = Console.ReadLine()
                'CInt(input) converts the input into a number.
                numberInput = CInt(input)


                If numberInput < 13 And numberInput > 0 Then
                    'goodData = True is a boolean flag used to catch errors.
                    goodData = True
                    My.Computer.Audio.Play(My.Resources.OOT_PressStart, AudioPlayMode.Background)

                ElseIf numberInput > 12 Or numberInput < 1 Then
                    Console.Clear()
                    My.Computer.Audio.Play(My.Resources.OOT_Error, AudioPlayMode.Background)
                    Console.WriteLine("Only numbers 1 to 12 will work...")
                    Console.ReadLine()
                    Console.Clear()

                End If

            Catch
                If input = "Q" Then
                    Exit Sub
                End If

                'goodData = False is a boolean flag used to catch errors.
                goodData = False
                My.Computer.Audio.Play(My.Resources.OOT_Error, AudioPlayMode.Background)
                Console.WriteLine("Only numbers 1 to 12 will work...")
                Console.ReadLine()
                Console.Clear()


            End Try
        Loop Until goodData = True


        Console.WriteLine("Enjoy your " & numberInput & "X" & numberInput & " Multiplication Table.")

        'Section below creates the Table based off of number input.

        For Column = 1 To numberInput

            For row = 1 To numberInput

                'table(row,column) = row * column creates the numbers and dimensions of the table.

                table(row, column) = row * column
                Console.Write(table(row, column) & vbTab)

            Next
            Console.WriteLine()
        Next
        Console.ReadLine()




    End Sub

End Module
