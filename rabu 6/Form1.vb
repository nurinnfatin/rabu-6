Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNamaHari.Click
        Dim strNamaHari(6) As String

        strNamaHari(0) = "Ahad"
        strNamaHari(1) = "Isnin"
        strNamaHari(2) = "Selasa"
        strNamaHari(3) = "Rabu"
        strNamaHari(4) = "Khamis"
        strNamaHari(5) = "Jumaat"
        strNamaHari(6) = "Sabtu"
        lblNamaHari.Text = strNamaHari(6)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strNamaHari(6) As String
        Dim nilai As Integer
        strNamaHari(0) = "Ahad"
        strNamaHari(1) = "Isnin"
        strNamaHari(2) = "Selasa"
        strNamaHari(3) = "Rabu"
        strNamaHari(4) = "Khamis"
        strNamaHari(5) = "Jumaat"
        strNamaHari(6) = "Sabtu"

        Array.Sort(strNamaHari)

        For y = 0 To 6
            lstjawab.Items.Add(strNamaHari(y))

        Next


    End Sub
End Class

