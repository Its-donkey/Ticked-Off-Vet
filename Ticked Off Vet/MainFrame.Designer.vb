<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainFrame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainFrame))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mnuTopBar = New System.Windows.Forms.MenuStrip()
        Me.mnuTopBarFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarCustomersUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarCustomersShowAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.PetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarPetsUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarPetsShowAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPageName = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.mnuTopBar.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.mnuTopBar)
        Me.Panel1.Controls.Add(Me.lblPageName)
        Me.Panel1.Controls.Add(Me.picLogo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 122)
        Me.Panel1.TabIndex = 3
        '
        'mnuTopBar
        '
        Me.mnuTopBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.mnuTopBar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuTopBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopBarFile, Me.mnuTopBarCustomers, Me.PetsToolStripMenuItem, Me.mnuTopBarHelp})
        Me.mnuTopBar.Location = New System.Drawing.Point(0, 98)
        Me.mnuTopBar.Name = "mnuTopBar"
        Me.mnuTopBar.Size = New System.Drawing.Size(534, 24)
        Me.mnuTopBar.TabIndex = 4
        Me.mnuTopBar.Text = "MenuStrip1"
        '
        'mnuTopBarFile
        '
        Me.mnuTopBarFile.DropDownDirection = Global.Ticked_Off_Vet.My.MySettings.Default.DropDownDirection
        Me.mnuTopBarFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopBarFileExit})
        Me.mnuTopBarFile.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuTopBarFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mnuTopBarFile.Name = "mnuTopBarFile"
        Me.mnuTopBarFile.Size = New System.Drawing.Size(43, 20)
        Me.mnuTopBarFile.Text = "&File"
        '
        'mnuTopBarFileExit
        '
        Me.mnuTopBarFileExit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuTopBarFileExit.Name = "mnuTopBarFileExit"
        Me.mnuTopBarFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuTopBarFileExit.Size = New System.Drawing.Size(144, 22)
        Me.mnuTopBarFileExit.Text = "E&xit"
        '
        'mnuTopBarCustomers
        '
        Me.mnuTopBarCustomers.DropDownDirection = Global.Ticked_Off_Vet.My.MySettings.Default.DropDownDirection
        Me.mnuTopBarCustomers.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopBarCustomersUpdate, Me.mnuTopBarCustomersShowAll})
        Me.mnuTopBarCustomers.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuTopBarCustomers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mnuTopBarCustomers.Name = "mnuTopBarCustomers"
        Me.mnuTopBarCustomers.Size = New System.Drawing.Size(89, 20)
        Me.mnuTopBarCustomers.Text = "&Customers"
        '
        'mnuTopBarCustomersUpdate
        '
        Me.mnuTopBarCustomersUpdate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuTopBarCustomersUpdate.Name = "mnuTopBarCustomersUpdate"
        Me.mnuTopBarCustomersUpdate.Size = New System.Drawing.Size(127, 22)
        Me.mnuTopBarCustomersUpdate.Text = "&Update"
        '
        'mnuTopBarCustomersShowAll
        '
        Me.mnuTopBarCustomersShowAll.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuTopBarCustomersShowAll.Name = "mnuTopBarCustomersShowAll"
        Me.mnuTopBarCustomersShowAll.Size = New System.Drawing.Size(127, 22)
        Me.mnuTopBarCustomersShowAll.Text = "&Show All"
        '
        'PetsToolStripMenuItem
        '
        Me.PetsToolStripMenuItem.DropDownDirection = Global.Ticked_Off_Vet.My.MySettings.Default.DropDownDirection
        Me.PetsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopBarPetsUpdate, Me.mnuTopBarPetsShowAll})
        Me.PetsToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PetsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PetsToolStripMenuItem.Name = "PetsToolStripMenuItem"
        Me.PetsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.PetsToolStripMenuItem.Text = "&Pets"
        '
        'mnuTopBarPetsUpdate
        '
        Me.mnuTopBarPetsUpdate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuTopBarPetsUpdate.Name = "mnuTopBarPetsUpdate"
        Me.mnuTopBarPetsUpdate.Size = New System.Drawing.Size(152, 22)
        Me.mnuTopBarPetsUpdate.Text = "&Update"
        '
        'mnuTopBarPetsShowAll
        '
        Me.mnuTopBarPetsShowAll.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuTopBarPetsShowAll.Name = "mnuTopBarPetsShowAll"
        Me.mnuTopBarPetsShowAll.Size = New System.Drawing.Size(152, 22)
        Me.mnuTopBarPetsShowAll.Text = "&Show All"
        '
        'mnuTopBarHelp
        '
        Me.mnuTopBarHelp.DropDownDirection = Global.Ticked_Off_Vet.My.MySettings.Default.DropDownDirection
        Me.mnuTopBarHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopBarHelpAbout})
        Me.mnuTopBarHelp.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuTopBarHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mnuTopBarHelp.Name = "mnuTopBarHelp"
        Me.mnuTopBarHelp.Size = New System.Drawing.Size(49, 20)
        Me.mnuTopBarHelp.Text = "&Help"
        '
        'mnuTopBarHelpAbout
        '
        Me.mnuTopBarHelpAbout.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuTopBarHelpAbout.Name = "mnuTopBarHelpAbout"
        Me.mnuTopBarHelpAbout.Size = New System.Drawing.Size(214, 22)
        Me.mnuTopBarHelpAbout.Text = "About Ticked Vet Clinic"
        '
        'lblPageName
        '
        Me.lblPageName.AutoSize = True
        Me.lblPageName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblPageName.Location = New System.Drawing.Point(275, 70)
        Me.lblPageName.Name = "lblPageName"
        Me.lblPageName.Size = New System.Drawing.Size(118, 24)
        Me.lblPageName.TabIndex = 2
        Me.lblPageName.Text = "Main Menu"
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Ticked_Off_Vet.My.Resources.Resources.TickedOff_Logo
        Me.picLogo.Location = New System.Drawing.Point(3, 3)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(266, 95)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'frmMainFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(534, 511)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMainFrame"
        Me.Text = "Ticked Off Vet Clinic"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.mnuTopBar.ResumeLayout(False)
        Me.mnuTopBar.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPageName As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents mnuTopBar As MenuStrip
    Friend WithEvents mnuTopBarFile As ToolStripMenuItem
    Friend WithEvents mnuTopBarFileExit As ToolStripMenuItem
    Friend WithEvents mnuTopBarCustomers As ToolStripMenuItem
    Friend WithEvents mnuTopBarCustomersUpdate As ToolStripMenuItem
    Friend WithEvents mnuTopBarHelp As ToolStripMenuItem
    Friend WithEvents mnuTopBarHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuTopBarCustomersShowAll As ToolStripMenuItem
    Friend WithEvents PetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuTopBarPetsUpdate As ToolStripMenuItem
    Friend WithEvents mnuTopBarPetsShowAll As ToolStripMenuItem
End Class
