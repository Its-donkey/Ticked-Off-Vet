Module functions
    Sub OpenForm(ByVal formName As Form)
        CloseForms()
        'Set the Parent Form of the Child window.
        formName.MdiParent = frmMainFrame
        'Display the new form.
        formName.Show()
        SetFormSize(formName)
        frmMainFrame.lblPageName.Text = formName.Text
    End Sub

    Sub CloseForms()
        For i = 0 To frmMainFrame.MdiChildren.Length - 1
            frmMainFrame.MdiChildren(i).Close()
        Next
    End Sub

    Sub SetFormSize(ByVal formName As Form)
        formName.Location = New Point(0, 0)
        frmMainFrame.Size = New Point((formName.Size.Width + 20), formName.Size.Height + 165)
    End Sub

    Sub OpenCustomersForm(ByVal tabIndex As Integer)
        If frmMainFrame.currentlyOpenedForm IsNot frmCustomerManagement Then
            frmMainFrame.currentlyOpenedForm = frmCustomerManagement
            OpenForm(frmCustomerManagement)
        End If

        frmCustomerManagement.tabCustomerRecords.SelectedIndex = tabIndex
    End Sub

    Sub OpenPetsForm(ByVal tabIndex As Integer)
        If frmMainFrame.currentlyOpenedForm IsNot frmPetManagement Then
            frmMainFrame.currentlyOpenedForm = frmPetManagement
            OpenForm(frmPetManagement)
        End If

        frmPetManagement.tabPetRecords.SelectedIndex = tabIndex
    End Sub
End Module
