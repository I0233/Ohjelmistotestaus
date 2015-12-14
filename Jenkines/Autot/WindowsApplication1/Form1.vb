Public Class Autot

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Auto_db.Autot' table. You can move, or remove it, as needed.
        Me.AutotTableAdapter.Fill(Me.Auto_db.Autot)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Lisaa_Click(sender As Object, e As EventArgs) Handles Lisaa.Click

    End Sub
End Class
