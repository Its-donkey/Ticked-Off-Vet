
Public Class frmMainFrame

    Public currentlyOpenedForm As Form

    Private Sub frmMainFrame_Load(sender As Object, e As EventArgs) Handles Me.Load
        currentlyOpenedForm = frmMenu
        OpenForm(frmMenu)
    End Sub

    Friend Shared Function currentlyOpenedMenu() As frmCustomerManagement
        Throw New NotImplementedException()
    End Function

    Private Sub mnuTopBarCustomersUpdate_Click(sender As Object, e As EventArgs) Handles mnuTopBarCustomersUpdate.Click
        OpenCustomersForm(0)
    End Sub

    Private Sub mnuTopBarFileExit_Click(sender As Object, e As EventArgs) Handles mnuTopBarFileExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuTopBarHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuTopBarHelpAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub picLogo_Click(sender As Object, e As EventArgs) Handles picLogo.Click
        OpenForm(frmMenu)
    End Sub

    Private Sub ShowAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllToolStripMenuItem.Click
        OpenCustomersForm(1)
    End Sub
End Class