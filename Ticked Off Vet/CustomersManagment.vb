Public Class frmCustomerManagement
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TickedoffDataSet)

    End Sub

    Private Sub frmCustomersMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TickedoffDataSet.pet' table. You can move, or remove it, as needed.
        Me.PetTableAdapter.Fill(Me.TickedoffDataSet.pet)
        'TODO: This line of code loads data into the 'TickedoffDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.TickedoffDataSet.customer)

    End Sub

    Private Sub tabCustomerRecords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabCustomerRecords.SelectedIndexChanged
        Select Case tabCustomerRecords.SelectedIndex
            Case 0
                Me.Size = New Point(500, 550)
                SetFormSize(Me)
            Case 1
                Me.Size = New Point(1470, 550)
                SetFormSize(Me)
        End Select
    End Sub

    Private Sub dgdViewAllCustomers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdViewAllCustomers.CellDoubleClick
        Dim selectedCell As Integer = dgdViewAllCustomers.Rows(dgdViewAllCustomers.CurrentCell.RowIndex).Cells(0).Value

        OpenCustomersForm(0)
        tabCustomerInformation.SelectedIndex = 0
        CustomerBindingSource.IndexOf(selectedCell)
    End Sub

    Private Sub DisplayNameToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CustomerTableAdapter.DisplayName(Me.TickedoffDataSet.customer)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub lstPetsOwned_DoubleClick(sender As Object, e As EventArgs) Handles lstPetsOwned.DoubleClick

        Dim selectedPet As String = lstPetsOwned.SelectedValue
        OpenPetsForm(0)
        frmPetManagement.PetBindingSource.Position = frmPetManagement.PetBindingSource.Find("petID", selectedPet)
    End Sub
End Class