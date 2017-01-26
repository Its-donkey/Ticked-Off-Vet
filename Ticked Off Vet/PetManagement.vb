Imports System.ComponentModel

Public Class frmPetManagement

    Private Sub PetBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PetBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TickedoffDataSet)

    End Sub

    Private Sub PetBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PetBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TickedoffDataSet)

    End Sub

    Private Sub frmPetManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TickedoffDataSet.pet' table. You can move, or remove it, as needed.
        Me.PetTableAdapter.Fill(Me.TickedoffDataSet.pet)
    End Sub

    Private Sub tabPetRecords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabPetRecords.SelectedIndexChanged
        Select Case tabPetRecords.SelectedIndex
            Case 0
                Me.Size = New Point(500, 550)
                SetFormSize(Me)
            Case 1
                Me.Size = New Point(890, 550)
                SetFormSize(Me)
        End Select
    End Sub

    Private Sub dgdViewAllPets_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdViewAllPets.CellDoubleClick
        Dim selectedPet As Integer = dgdViewAllPets.Rows(dgdViewAllPets.CurrentCell.RowIndex).Cells(0).Value

        OpenPetsForm(0)
        tabPetInformation.SelectedIndex = 0
        PetBindingSource.Position = PetBindingSource.Find("petID", selectedPet)
    End Sub

    Private Sub OwnerTextBox_DoubleClick(sender As Object, e As EventArgs) Handles OwnerTextBox.DoubleClick
        Dim petOwner As Integer = PetBindingSource.Current.Item("customerID")

        OpenCustomersForm(0)
        frmCustomerManagement.tabCustomerInformation.SelectedIndex = 0
        frmCustomerManagement.CustomerBindingSource.Position = frmCustomerManagement.CustomerBindingSource.Find("customerID", petOwner)
    End Sub
End Class