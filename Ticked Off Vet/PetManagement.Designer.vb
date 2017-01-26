<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPetManagement
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
        Me.components = New System.ComponentModel.Container()
        Dim PetIDLabel As System.Windows.Forms.Label
        Dim PetNameLabel As System.Windows.Forms.Label
        Dim SpeciesLabel As System.Windows.Forms.Label
        Dim BreedLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPetManagement))
        Dim OwnerLabel As System.Windows.Forms.Label
        Dim DisplayLabel As System.Windows.Forms.Label
        Me.tabPetRecords = New System.Windows.Forms.TabControl()
        Me.tabPetRecord = New System.Windows.Forms.TabPage()
        Me.PetBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PetBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PetIDTextBox = New System.Windows.Forms.TextBox()
        Me.PetNameTextBox = New System.Windows.Forms.TextBox()
        Me.SpeciesTextBox = New System.Windows.Forms.TextBox()
        Me.BreedTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.tabAllPets = New System.Windows.Forms.TabPage()
        Me.pnlViewAllPets = New System.Windows.Forms.Panel()
        Me.PetDataGridView = New System.Windows.Forms.DataGridView()
        Me.OwnerTextBox = New System.Windows.Forms.TextBox()
        Me.PetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TickedoffDataSet = New Ticked_Off_Vet.tickedoffDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PetTableAdapter = New Ticked_Off_Vet.tickedoffDataSetTableAdapters.petTableAdapter()
        Me.TableAdapterManager = New Ticked_Off_Vet.tickedoffDataSetTableAdapters.TableAdapterManager()
        Me.DisplayComboBox = New System.Windows.Forms.ComboBox()
        PetIDLabel = New System.Windows.Forms.Label()
        PetNameLabel = New System.Windows.Forms.Label()
        SpeciesLabel = New System.Windows.Forms.Label()
        BreedLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        OwnerLabel = New System.Windows.Forms.Label()
        DisplayLabel = New System.Windows.Forms.Label()
        Me.tabPetRecords.SuspendLayout()
        Me.tabPetRecord.SuspendLayout()
        CType(Me.PetBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PetBindingNavigator.SuspendLayout()
        Me.tabAllPets.SuspendLayout()
        Me.pnlViewAllPets.SuspendLayout()
        CType(Me.PetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TickedoffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PetIDLabel
        '
        PetIDLabel.AutoSize = True
        PetIDLabel.Location = New System.Drawing.Point(92, 34)
        PetIDLabel.Name = "PetIDLabel"
        PetIDLabel.Size = New System.Drawing.Size(39, 13)
        PetIDLabel.TabIndex = 0
        PetIDLabel.Text = "pet ID:"
        '
        'PetNameLabel
        '
        PetNameLabel.AutoSize = True
        PetNameLabel.Location = New System.Drawing.Point(92, 60)
        PetNameLabel.Name = "PetNameLabel"
        PetNameLabel.Size = New System.Drawing.Size(56, 13)
        PetNameLabel.TabIndex = 2
        PetNameLabel.Text = "pet Name:"
        '
        'SpeciesLabel
        '
        SpeciesLabel.AutoSize = True
        SpeciesLabel.Location = New System.Drawing.Point(92, 86)
        SpeciesLabel.Name = "SpeciesLabel"
        SpeciesLabel.Size = New System.Drawing.Size(46, 13)
        SpeciesLabel.TabIndex = 4
        SpeciesLabel.Text = "species:"
        '
        'BreedLabel
        '
        BreedLabel.AutoSize = True
        BreedLabel.Location = New System.Drawing.Point(92, 112)
        BreedLabel.Name = "BreedLabel"
        BreedLabel.Size = New System.Drawing.Size(37, 13)
        BreedLabel.TabIndex = 6
        BreedLabel.Text = "breed:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(92, 139)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 8
        DOBLabel.Text = "DOB:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(92, 164)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(43, 13)
        GenderLabel.TabIndex = 10
        GenderLabel.Text = "gender:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(92, 190)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(41, 13)
        WeightLabel.TabIndex = 12
        WeightLabel.Text = "weight:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(92, 216)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(67, 13)
        CustomerIDLabel.TabIndex = 14
        CustomerIDLabel.Text = "customer ID:"
        '
        'tabPetRecords
        '
        Me.tabPetRecords.Controls.Add(Me.tabPetRecord)
        Me.tabPetRecords.Controls.Add(Me.tabAllPets)
        Me.tabPetRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPetRecords.Location = New System.Drawing.Point(0, 0)
        Me.tabPetRecords.Name = "tabPetRecords"
        Me.tabPetRecords.SelectedIndex = 0
        Me.tabPetRecords.Size = New System.Drawing.Size(484, 511)
        Me.tabPetRecords.TabIndex = 0
        '
        'tabPetRecord
        '
        Me.tabPetRecord.AutoScroll = True
        Me.tabPetRecord.Controls.Add(DisplayLabel)
        Me.tabPetRecord.Controls.Add(Me.DisplayComboBox)
        Me.tabPetRecord.Controls.Add(OwnerLabel)
        Me.tabPetRecord.Controls.Add(Me.OwnerTextBox)
        Me.tabPetRecord.Controls.Add(Me.PetBindingNavigator)
        Me.tabPetRecord.Controls.Add(PetIDLabel)
        Me.tabPetRecord.Controls.Add(Me.PetIDTextBox)
        Me.tabPetRecord.Controls.Add(PetNameLabel)
        Me.tabPetRecord.Controls.Add(Me.PetNameTextBox)
        Me.tabPetRecord.Controls.Add(SpeciesLabel)
        Me.tabPetRecord.Controls.Add(Me.SpeciesTextBox)
        Me.tabPetRecord.Controls.Add(BreedLabel)
        Me.tabPetRecord.Controls.Add(Me.BreedTextBox)
        Me.tabPetRecord.Controls.Add(DOBLabel)
        Me.tabPetRecord.Controls.Add(Me.DOBDateTimePicker)
        Me.tabPetRecord.Controls.Add(GenderLabel)
        Me.tabPetRecord.Controls.Add(Me.GenderTextBox)
        Me.tabPetRecord.Controls.Add(WeightLabel)
        Me.tabPetRecord.Controls.Add(Me.WeightTextBox)
        Me.tabPetRecord.Controls.Add(CustomerIDLabel)
        Me.tabPetRecord.Controls.Add(Me.CustomerIDTextBox)
        Me.tabPetRecord.Location = New System.Drawing.Point(4, 22)
        Me.tabPetRecord.Name = "tabPetRecord"
        Me.tabPetRecord.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPetRecord.Size = New System.Drawing.Size(476, 485)
        Me.tabPetRecord.TabIndex = 0
        Me.tabPetRecord.Text = "Pet Record"
        Me.tabPetRecord.UseVisualStyleBackColor = True
        '
        'PetBindingNavigator
        '
        Me.PetBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PetBindingNavigator.BindingSource = Me.PetBindingSource
        Me.PetBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PetBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PetBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PetBindingNavigatorSaveItem})
        Me.PetBindingNavigator.Location = New System.Drawing.Point(3, 3)
        Me.PetBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PetBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PetBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PetBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PetBindingNavigator.Name = "PetBindingNavigator"
        Me.PetBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PetBindingNavigator.Size = New System.Drawing.Size(470, 25)
        Me.PetBindingNavigator.TabIndex = 16
        Me.PetBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PetBindingNavigatorSaveItem
        '
        Me.PetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PetBindingNavigatorSaveItem.Image = CType(resources.GetObject("PetBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PetBindingNavigatorSaveItem.Name = "PetBindingNavigatorSaveItem"
        Me.PetBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PetBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PetIDTextBox
        '
        Me.PetIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetBindingSource, "petID", True))
        Me.PetIDTextBox.Location = New System.Drawing.Point(165, 31)
        Me.PetIDTextBox.Name = "PetIDTextBox"
        Me.PetIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PetIDTextBox.TabIndex = 1
        '
        'PetNameTextBox
        '
        Me.PetNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetBindingSource, "petName", True))
        Me.PetNameTextBox.Location = New System.Drawing.Point(165, 57)
        Me.PetNameTextBox.Name = "PetNameTextBox"
        Me.PetNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PetNameTextBox.TabIndex = 3
        '
        'SpeciesTextBox
        '
        Me.SpeciesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetBindingSource, "species", True))
        Me.SpeciesTextBox.Location = New System.Drawing.Point(165, 83)
        Me.SpeciesTextBox.Name = "SpeciesTextBox"
        Me.SpeciesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SpeciesTextBox.TabIndex = 5
        '
        'BreedTextBox
        '
        Me.BreedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetBindingSource, "breed", True))
        Me.BreedTextBox.Location = New System.Drawing.Point(165, 109)
        Me.BreedTextBox.Name = "BreedTextBox"
        Me.BreedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BreedTextBox.TabIndex = 7
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PetBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(165, 135)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DOBDateTimePicker.TabIndex = 9
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetBindingSource, "gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(165, 161)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GenderTextBox.TabIndex = 11
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetBindingSource, "weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(165, 187)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(200, 20)
        Me.WeightTextBox.TabIndex = 13
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetBindingSource, "customerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(165, 213)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CustomerIDTextBox.TabIndex = 15
        '
        'tabAllPets
        '
        Me.tabAllPets.Controls.Add(Me.pnlViewAllPets)
        Me.tabAllPets.Location = New System.Drawing.Point(4, 22)
        Me.tabAllPets.Name = "tabAllPets"
        Me.tabAllPets.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAllPets.Size = New System.Drawing.Size(476, 485)
        Me.tabAllPets.TabIndex = 1
        Me.tabAllPets.Text = "View All Pets"
        Me.tabAllPets.UseVisualStyleBackColor = True
        '
        'pnlViewAllPets
        '
        Me.pnlViewAllPets.AutoScroll = True
        Me.pnlViewAllPets.Controls.Add(Me.PetDataGridView)
        Me.pnlViewAllPets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlViewAllPets.Location = New System.Drawing.Point(3, 3)
        Me.pnlViewAllPets.Name = "pnlViewAllPets"
        Me.pnlViewAllPets.Size = New System.Drawing.Size(470, 479)
        Me.pnlViewAllPets.TabIndex = 0
        '
        'PetDataGridView
        '
        Me.PetDataGridView.AutoGenerateColumns = False
        Me.PetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PetDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.PetDataGridView.DataSource = Me.PetBindingSource
        Me.PetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PetDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PetDataGridView.Name = "PetDataGridView"
        Me.PetDataGridView.Size = New System.Drawing.Size(470, 479)
        Me.PetDataGridView.TabIndex = 0
        '
        'OwnerLabel
        '
        OwnerLabel.AutoSize = True
        OwnerLabel.Location = New System.Drawing.Point(92, 242)
        OwnerLabel.Name = "OwnerLabel"
        OwnerLabel.Size = New System.Drawing.Size(39, 13)
        OwnerLabel.TabIndex = 17
        OwnerLabel.Text = "owner:"
        '
        'OwnerTextBox
        '
        Me.OwnerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetBindingSource, "owner", True))
        Me.OwnerTextBox.Location = New System.Drawing.Point(165, 239)
        Me.OwnerTextBox.Name = "OwnerTextBox"
        Me.OwnerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OwnerTextBox.TabIndex = 18
        '
        'PetBindingSource
        '
        Me.PetBindingSource.DataMember = "pet"
        Me.PetBindingSource.DataSource = Me.TickedoffDataSet
        '
        'TickedoffDataSet
        '
        Me.TickedoffDataSet.DataSetName = "tickedoffDataSet"
        Me.TickedoffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "petID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "petID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "petName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "petName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "species"
        Me.DataGridViewTextBoxColumn3.HeaderText = "species"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "breed"
        Me.DataGridViewTextBoxColumn4.HeaderText = "breed"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "gender"
        Me.DataGridViewTextBoxColumn6.HeaderText = "gender"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "weight"
        Me.DataGridViewTextBoxColumn7.HeaderText = "weight"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "customerID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "customerID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'PetTableAdapter
        '
        Me.PetTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.petTableAdapter = Me.PetTableAdapter
        Me.TableAdapterManager.stateTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Ticked_Off_Vet.tickedoffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DisplayLabel
        '
        DisplayLabel.AutoSize = True
        DisplayLabel.Location = New System.Drawing.Point(272, 334)
        DisplayLabel.Name = "DisplayLabel"
        DisplayLabel.Size = New System.Drawing.Size(42, 13)
        DisplayLabel.TabIndex = 19
        DisplayLabel.Text = "display:"
        '
        'DisplayComboBox
        '
        Me.DisplayComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetBindingSource, "display", True))
        Me.DisplayComboBox.DataSource = Me.PetBindingSource
        Me.DisplayComboBox.DisplayMember = "display"
        Me.DisplayComboBox.FormattingEnabled = True
        Me.DisplayComboBox.Location = New System.Drawing.Point(320, 331)
        Me.DisplayComboBox.Name = "DisplayComboBox"
        Me.DisplayComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DisplayComboBox.TabIndex = 20
        Me.DisplayComboBox.ValueMember = "petID"
        '
        'frmPetManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 511)
        Me.Controls.Add(Me.tabPetRecords)
        Me.Name = "frmPetManagement"
        Me.Text = "Pet Management"
        Me.tabPetRecords.ResumeLayout(False)
        Me.tabPetRecord.ResumeLayout(False)
        Me.tabPetRecord.PerformLayout()
        CType(Me.PetBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PetBindingNavigator.ResumeLayout(False)
        Me.PetBindingNavigator.PerformLayout()
        Me.tabAllPets.ResumeLayout(False)
        Me.pnlViewAllPets.ResumeLayout(False)
        CType(Me.PetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TickedoffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabPetRecords As TabControl
    Friend WithEvents tabPetRecord As TabPage
    Friend WithEvents tabAllPets As TabPage
    Friend WithEvents pnlViewAllPets As Panel
    Friend WithEvents TickedoffDataSet As tickedoffDataSet
    Friend WithEvents PetBindingSource As BindingSource
    Friend WithEvents PetTableAdapter As tickedoffDataSetTableAdapters.petTableAdapter
    Friend WithEvents TableAdapterManager As tickedoffDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PetDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents PetIDTextBox As TextBox
    Friend WithEvents PetNameTextBox As TextBox
    Friend WithEvents SpeciesTextBox As TextBox
    Friend WithEvents BreedTextBox As TextBox
    Friend WithEvents DOBDateTimePicker As DateTimePicker
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents PetBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PetBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents OwnerTextBox As TextBox
    Friend WithEvents DisplayComboBox As ComboBox
End Class
