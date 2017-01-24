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
End Class