Public Class frmMenu
    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        OpenCustomersForm(0)
    End Sub

    Private Sub btnOpenPets_Click(sender As Object, e As EventArgs) Handles btnOpenPets.Click
        OpenPetsForm(0)
    End Sub
End Class