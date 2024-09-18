Imports System.Collections.Generic

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProcessText()
    End Sub

    Private Sub ProcessText()
        Dim lines As String() = TextBox1.Lines
        Dim uniqueLines As New List(Of String)
        Dim duplicateCount As Integer = 0

        For Each line As String In lines
            If Not uniqueLines.Contains(line) Then
                uniqueLines.Add(line)
            Else
                duplicateCount += 1
            End If
        Next

        TextBox1.Lines = uniqueLines.ToArray()
        Clipboard.SetText(String.Join(Environment.NewLine, uniqueLines))
        MessageBox.Show($"Toplam {duplicateCount} aynı satır bulundu ve silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
