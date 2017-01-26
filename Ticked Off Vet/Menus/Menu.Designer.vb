<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnOpenPets = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCustomers
        '
        Me.btnCustomers.Location = New System.Drawing.Point(192, 12)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(75, 23)
        Me.btnCustomers.TabIndex = 0
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnOpenPets
        '
        Me.btnOpenPets.Location = New System.Drawing.Point(192, 41)
        Me.btnOpenPets.Name = "btnOpenPets"
        Me.btnOpenPets.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenPets.TabIndex = 1
        Me.btnOpenPets.Text = "Pets"
        Me.btnOpenPets.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(459, 511)
        Me.Controls.Add(Me.btnOpenPets)
        Me.Controls.Add(Me.btnCustomers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMenu"
        Me.Text = "Main menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnOpenPets As Button
End Class
