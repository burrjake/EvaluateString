Public Class EvaluateStringForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim temp As Integer
        Dim junk As String

        For Each thingy In TextBox1.Text
            'junk = Asc(thingy)
            temp = Asc(temp)

            Select Case temp
                Case 48 To 57
                    MsgBox("your lucky number is...." & Chr(temp))
                Case Else
            End Select
        Next
        'Try
        'temp = CInt(CStr(thingy))
        'MsgBox("your lucky number is.... " & temp)

        ' Catch ex As Exception
        'letter

        'End Try
    End Sub
End Class
