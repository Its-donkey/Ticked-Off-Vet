<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerManagement
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
        Dim TitleLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim SuburbLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Street2Label As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim Street1Label As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Phone2Label As System.Windows.Forms.Label
        Dim Phone1Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerManagement))
        Me.TickedoffDataSet = New Ticked_Off_Vet.tickedoffDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Ticked_Off_Vet.tickedoffDataSetTableAdapters.customerTableAdapter()
        Me.TableAdapterManager = New Ticked_Off_Vet.tickedoffDataSetTableAdapters.TableAdapterManager()
        Me.tabCustomerRecords = New System.Windows.Forms.TabControl()
        Me.tabCustomerRecord = New System.Windows.Forms.TabPage()
        Me.CustomerComboBox = New System.Windows.Forms.ComboBox()
        Me.tabCustomerInformation = New System.Windows.Forms.TabControl()
        Me.tabCustomerDetails = New System.Windows.Forms.TabPage()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.SuburbTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Street2TextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Street1TextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Phone2TextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Phone1TextBox = New System.Windows.Forms.TextBox()
        Me.tabPetDetails = New System.Windows.Forms.TabPage()
        Me.lstPetsOwned = New System.Windows.Forms.ListBox()
        Me.PetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bndCustomers = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bndCustomersAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.bndCustomersCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.bndCustomersDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.bndCustomersMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.bndCustomersMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.bndCustomersSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.bndCustomersPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.bndCustomersSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bndCustomersMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.bndCustomersMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.bndCustomersSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bndCustomersNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.tabAllCustomers = New System.Windows.Forms.TabPage()
        Me.dgdViewAllCustomers = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PetTableAdapter = New Ticked_Off_Vet.tickedoffDataSetTableAdapters.petTableAdapter()
        TitleLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        SuburbLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Street2Label = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        Street1Label = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Phone2Label = New System.Windows.Forms.Label()
        Phone1Label = New System.Windows.Forms.Label()
        CType(Me.TickedoffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCustomerRecords.SuspendLayout()
        Me.tabCustomerRecord.SuspendLayout()
        Me.tabCustomerInformation.SuspendLayout()
        Me.tabCustomerDetails.SuspendLayout()
        Me.tabPetDetails.SuspendLayout()
        CType(Me.PetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bndCustomers.SuspendLayout()
        Me.tabAllCustomers.SuspendLayout()
        CType(Me.dgdViewAllCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(99, 9)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(26, 13)
        TitleLabel.TabIndex = 82
        TitleLabel.Text = "title:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(99, 35)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(57, 13)
        FirstNameLabel.TabIndex = 84
        FirstNameLabel.Text = "first Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(99, 61)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(57, 13)
        LastNameLabel.TabIndex = 86
        LastNameLabel.Text = "last Name:"
        '
        'SuburbLabel
        '
        SuburbLabel.AutoSize = True
        SuburbLabel.Location = New System.Drawing.Point(99, 269)
        SuburbLabel.Name = "SuburbLabel"
        SuburbLabel.Size = New System.Drawing.Size(42, 13)
        SuburbLabel.TabIndex = 102
        SuburbLabel.Text = "suburb:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(99, 87)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(43, 13)
        GenderLabel.TabIndex = 88
        GenderLabel.Text = "gender:"
        '
        'Street2Label
        '
        Street2Label.AutoSize = True
        Street2Label.Location = New System.Drawing.Point(99, 243)
        Street2Label.Name = "Street2Label"
        Street2Label.Size = New System.Drawing.Size(42, 13)
        Street2Label.TabIndex = 100
        Street2Label.Text = "street2:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(99, 114)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 90
        DOBLabel.Text = "DOB:"
        '
        'Street1Label
        '
        Street1Label.AutoSize = True
        Street1Label.Location = New System.Drawing.Point(99, 217)
        Street1Label.Name = "Street1Label"
        Street1Label.Size = New System.Drawing.Size(42, 13)
        Street1Label.TabIndex = 98
        Street1Label.Text = "street1:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(99, 139)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 92
        EmailLabel.Text = "email:"
        '
        'Phone2Label
        '
        Phone2Label.AutoSize = True
        Phone2Label.Location = New System.Drawing.Point(99, 191)
        Phone2Label.Name = "Phone2Label"
        Phone2Label.Size = New System.Drawing.Size(46, 13)
        Phone2Label.TabIndex = 96
        Phone2Label.Text = "phone2:"
        '
        'Phone1Label
        '
        Phone1Label.AutoSize = True
        Phone1Label.Location = New System.Drawing.Point(99, 165)
        Phone1Label.Name = "Phone1Label"
        Phone1Label.Size = New System.Drawing.Size(46, 13)
        Phone1Label.TabIndex = 94
        Phone1Label.Text = "phone1:"
        '
        'TickedoffDataSet
        '
        Me.TickedoffDataSet.DataSetName = "tickedoffDataSet"
        Me.TickedoffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.TickedoffDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.petTableAdapter = Nothing
        Me.TableAdapterManager.stateTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Ticked_Off_Vet.tickedoffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'tabCustomerRecords
        '
        Me.tabCustomerRecords.Controls.Add(Me.tabCustomerRecord)
        Me.tabCustomerRecords.Controls.Add(Me.tabAllCustomers)
        Me.tabCustomerRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCustomerRecords.Location = New System.Drawing.Point(0, 0)
        Me.tabCustomerRecords.Name = "tabCustomerRecords"
        Me.tabCustomerRecords.SelectedIndex = 0
        Me.tabCustomerRecords.Size = New System.Drawing.Size(500, 550)
        Me.tabCustomerRecords.TabIndex = 0
        '
        'tabCustomerRecord
        '
        Me.tabCustomerRecord.AutoScroll = True
        Me.tabCustomerRecord.Controls.Add(Me.CustomerComboBox)
        Me.tabCustomerRecord.Controls.Add(Me.tabCustomerInformation)
        Me.tabCustomerRecord.Controls.Add(Me.bndCustomers)
        Me.tabCustomerRecord.Location = New System.Drawing.Point(4, 22)
        Me.tabCustomerRecord.Name = "tabCustomerRecord"
        Me.tabCustomerRecord.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCustomerRecord.Size = New System.Drawing.Size(492, 524)
        Me.tabCustomerRecord.TabIndex = 0
        Me.tabCustomerRecord.Text = "Customer Record"
        Me.tabCustomerRecord.UseVisualStyleBackColor = True
        '
        'CustomerComboBox
        '
        Me.CustomerComboBox.DataSource = Me.CustomerBindingSource
        Me.CustomerComboBox.DisplayMember = "displayName"
        Me.CustomerComboBox.FormattingEnabled = True
        Me.CustomerComboBox.Location = New System.Drawing.Point(184, 31)
        Me.CustomerComboBox.Name = "CustomerComboBox"
        Me.CustomerComboBox.Size = New System.Drawing.Size(300, 21)
        Me.CustomerComboBox.TabIndex = 60
        Me.CustomerComboBox.ValueMember = "customerID"
        '
        'tabCustomerInformation
        '
        Me.tabCustomerInformation.Controls.Add(Me.tabCustomerDetails)
        Me.tabCustomerInformation.Controls.Add(Me.tabPetDetails)
        Me.tabCustomerInformation.Location = New System.Drawing.Point(-4, 59)
        Me.tabCustomerInformation.Name = "tabCustomerInformation"
        Me.tabCustomerInformation.SelectedIndex = 0
        Me.tabCustomerInformation.Size = New System.Drawing.Size(494, 442)
        Me.tabCustomerInformation.TabIndex = 60
        '
        'tabCustomerDetails
        '
        Me.tabCustomerDetails.Controls.Add(TitleLabel)
        Me.tabCustomerDetails.Controls.Add(Me.TitleTextBox)
        Me.tabCustomerDetails.Controls.Add(FirstNameLabel)
        Me.tabCustomerDetails.Controls.Add(Me.FirstNameTextBox)
        Me.tabCustomerDetails.Controls.Add(Me.SuburbTextBox)
        Me.tabCustomerDetails.Controls.Add(LastNameLabel)
        Me.tabCustomerDetails.Controls.Add(SuburbLabel)
        Me.tabCustomerDetails.Controls.Add(Me.LastNameTextBox)
        Me.tabCustomerDetails.Controls.Add(Me.Street2TextBox)
        Me.tabCustomerDetails.Controls.Add(GenderLabel)
        Me.tabCustomerDetails.Controls.Add(Street2Label)
        Me.tabCustomerDetails.Controls.Add(Me.GenderTextBox)
        Me.tabCustomerDetails.Controls.Add(Me.Street1TextBox)
        Me.tabCustomerDetails.Controls.Add(DOBLabel)
        Me.tabCustomerDetails.Controls.Add(Street1Label)
        Me.tabCustomerDetails.Controls.Add(Me.DOBDateTimePicker)
        Me.tabCustomerDetails.Controls.Add(Me.Phone2TextBox)
        Me.tabCustomerDetails.Controls.Add(EmailLabel)
        Me.tabCustomerDetails.Controls.Add(Phone2Label)
        Me.tabCustomerDetails.Controls.Add(Me.EmailTextBox)
        Me.tabCustomerDetails.Controls.Add(Me.Phone1TextBox)
        Me.tabCustomerDetails.Controls.Add(Phone1Label)
        Me.tabCustomerDetails.Location = New System.Drawing.Point(4, 22)
        Me.tabCustomerDetails.Name = "tabCustomerDetails"
        Me.tabCustomerDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCustomerDetails.Size = New System.Drawing.Size(486, 416)
        Me.tabCustomerDetails.TabIndex = 0
        Me.tabCustomerDetails.Text = "Details"
        Me.tabCustomerDetails.UseVisualStyleBackColor = True
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(172, 6)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TitleTextBox.TabIndex = 83
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "firstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(172, 32)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirstNameTextBox.TabIndex = 85
        '
        'SuburbTextBox
        '
        Me.SuburbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "suburb", True))
        Me.SuburbTextBox.Location = New System.Drawing.Point(172, 266)
        Me.SuburbTextBox.Name = "SuburbTextBox"
        Me.SuburbTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SuburbTextBox.TabIndex = 103
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "lastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(172, 58)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LastNameTextBox.TabIndex = 87
        '
        'Street2TextBox
        '
        Me.Street2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "street2", True))
        Me.Street2TextBox.Location = New System.Drawing.Point(172, 240)
        Me.Street2TextBox.Name = "Street2TextBox"
        Me.Street2TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Street2TextBox.TabIndex = 101
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(172, 84)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GenderTextBox.TabIndex = 89
        '
        'Street1TextBox
        '
        Me.Street1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "street1", True))
        Me.Street1TextBox.Location = New System.Drawing.Point(172, 214)
        Me.Street1TextBox.Name = "Street1TextBox"
        Me.Street1TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Street1TextBox.TabIndex = 99
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(172, 110)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DOBDateTimePicker.TabIndex = 91
        '
        'Phone2TextBox
        '
        Me.Phone2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "phone2", True))
        Me.Phone2TextBox.Location = New System.Drawing.Point(172, 188)
        Me.Phone2TextBox.Name = "Phone2TextBox"
        Me.Phone2TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Phone2TextBox.TabIndex = 97
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(172, 136)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 93
        '
        'Phone1TextBox
        '
        Me.Phone1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "phone1", True))
        Me.Phone1TextBox.Location = New System.Drawing.Point(172, 162)
        Me.Phone1TextBox.Name = "Phone1TextBox"
        Me.Phone1TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Phone1TextBox.TabIndex = 95
        '
        'tabPetDetails
        '
        Me.tabPetDetails.AutoScroll = True
        Me.tabPetDetails.Controls.Add(Me.lstPetsOwned)
        Me.tabPetDetails.Location = New System.Drawing.Point(4, 22)
        Me.tabPetDetails.Name = "tabPetDetails"
        Me.tabPetDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPetDetails.Size = New System.Drawing.Size(486, 416)
        Me.tabPetDetails.TabIndex = 1
        Me.tabPetDetails.Text = "Pet Details"
        Me.tabPetDetails.UseVisualStyleBackColor = True
        '
        'lstPetsOwned
        '
        Me.lstPetsOwned.DataSource = Me.PetBindingSource
        Me.lstPetsOwned.DisplayMember = "petName"
        Me.lstPetsOwned.FormattingEnabled = True
        Me.lstPetsOwned.Location = New System.Drawing.Point(96, 6)
        Me.lstPetsOwned.Name = "lstPetsOwned"
        Me.lstPetsOwned.Size = New System.Drawing.Size(300, 212)
        Me.lstPetsOwned.TabIndex = 0
        Me.lstPetsOwned.ValueMember = "petID"
        '
        'PetBindingSource
        '
        Me.PetBindingSource.DataMember = "pet_ibfk_1"
        Me.PetBindingSource.DataSource = Me.CustomerBindingSource
        '
        'bndCustomers
        '
        Me.bndCustomers.AddNewItem = Me.bndCustomersAddNewItem
        Me.bndCustomers.BindingSource = Me.CustomerBindingSource
        Me.bndCustomers.CountItem = Me.bndCustomersCountItem
        Me.bndCustomers.DeleteItem = Me.bndCustomersDeleteItem
        Me.bndCustomers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bndCustomersMoveFirstItem, Me.bndCustomersMovePreviousItem, Me.bndCustomersSeparator, Me.bndCustomersPositionItem, Me.bndCustomersCountItem, Me.bndCustomersSeparator1, Me.bndCustomersMoveNextItem, Me.bndCustomersMoveLastItem, Me.bndCustomersSeparator2, Me.bndCustomersAddNewItem, Me.bndCustomersDeleteItem, Me.bndCustomersNavigatorSaveItem})
        Me.bndCustomers.Location = New System.Drawing.Point(3, 3)
        Me.bndCustomers.MoveFirstItem = Me.bndCustomersMoveFirstItem
        Me.bndCustomers.MoveLastItem = Me.bndCustomersMoveLastItem
        Me.bndCustomers.MoveNextItem = Me.bndCustomersMoveNextItem
        Me.bndCustomers.MovePreviousItem = Me.bndCustomersMovePreviousItem
        Me.bndCustomers.Name = "bndCustomers"
        Me.bndCustomers.PositionItem = Me.bndCustomersPositionItem
        Me.bndCustomers.Size = New System.Drawing.Size(486, 25)
        Me.bndCustomers.TabIndex = 59
        Me.bndCustomers.Text = "BindingNavigator1"
        '
        'bndCustomersAddNewItem
        '
        Me.bndCustomersAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bndCustomersAddNewItem.Image = CType(resources.GetObject("bndCustomersAddNewItem.Image"), System.Drawing.Image)
        Me.bndCustomersAddNewItem.Name = "bndCustomersAddNewItem"
        Me.bndCustomersAddNewItem.RightToLeftAutoMirrorImage = True
        Me.bndCustomersAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.bndCustomersAddNewItem.Text = "Add new"
        '
        'bndCustomersCountItem
        '
        Me.bndCustomersCountItem.Name = "bndCustomersCountItem"
        Me.bndCustomersCountItem.Size = New System.Drawing.Size(35, 22)
        Me.bndCustomersCountItem.Text = "of {0}"
        Me.bndCustomersCountItem.ToolTipText = "Total number of items"
        '
        'bndCustomersDeleteItem
        '
        Me.bndCustomersDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bndCustomersDeleteItem.Image = CType(resources.GetObject("bndCustomersDeleteItem.Image"), System.Drawing.Image)
        Me.bndCustomersDeleteItem.Name = "bndCustomersDeleteItem"
        Me.bndCustomersDeleteItem.RightToLeftAutoMirrorImage = True
        Me.bndCustomersDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.bndCustomersDeleteItem.Text = "Delete"
        '
        'bndCustomersMoveFirstItem
        '
        Me.bndCustomersMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bndCustomersMoveFirstItem.Image = CType(resources.GetObject("bndCustomersMoveFirstItem.Image"), System.Drawing.Image)
        Me.bndCustomersMoveFirstItem.Name = "bndCustomersMoveFirstItem"
        Me.bndCustomersMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.bndCustomersMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.bndCustomersMoveFirstItem.Text = "Move first"
        '
        'bndCustomersMovePreviousItem
        '
        Me.bndCustomersMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bndCustomersMovePreviousItem.Image = CType(resources.GetObject("bndCustomersMovePreviousItem.Image"), System.Drawing.Image)
        Me.bndCustomersMovePreviousItem.Name = "bndCustomersMovePreviousItem"
        Me.bndCustomersMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.bndCustomersMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.bndCustomersMovePreviousItem.Text = "Move previous"
        '
        'bndCustomersSeparator
        '
        Me.bndCustomersSeparator.Name = "bndCustomersSeparator"
        Me.bndCustomersSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'bndCustomersPositionItem
        '
        Me.bndCustomersPositionItem.AccessibleName = "Position"
        Me.bndCustomersPositionItem.AutoSize = False
        Me.bndCustomersPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bndCustomersPositionItem.Name = "bndCustomersPositionItem"
        Me.bndCustomersPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.bndCustomersPositionItem.Text = "0"
        Me.bndCustomersPositionItem.ToolTipText = "Current position"
        '
        'bndCustomersSeparator1
        '
        Me.bndCustomersSeparator1.Name = "bndCustomersSeparator1"
        Me.bndCustomersSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bndCustomersMoveNextItem
        '
        Me.bndCustomersMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bndCustomersMoveNextItem.Image = CType(resources.GetObject("bndCustomersMoveNextItem.Image"), System.Drawing.Image)
        Me.bndCustomersMoveNextItem.Name = "bndCustomersMoveNextItem"
        Me.bndCustomersMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.bndCustomersMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.bndCustomersMoveNextItem.Text = "Move next"
        '
        'bndCustomersMoveLastItem
        '
        Me.bndCustomersMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bndCustomersMoveLastItem.Image = CType(resources.GetObject("bndCustomersMoveLastItem.Image"), System.Drawing.Image)
        Me.bndCustomersMoveLastItem.Name = "bndCustomersMoveLastItem"
        Me.bndCustomersMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.bndCustomersMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.bndCustomersMoveLastItem.Text = "Move last"
        '
        'bndCustomersSeparator2
        '
        Me.bndCustomersSeparator2.Name = "bndCustomersSeparator2"
        Me.bndCustomersSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'bndCustomersNavigatorSaveItem
        '
        Me.bndCustomersNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bndCustomersNavigatorSaveItem.Image = CType(resources.GetObject("bndCustomersNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.bndCustomersNavigatorSaveItem.Name = "bndCustomersNavigatorSaveItem"
        Me.bndCustomersNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.bndCustomersNavigatorSaveItem.Text = "Save Data"
        '
        'tabAllCustomers
        '
        Me.tabAllCustomers.Controls.Add(Me.dgdViewAllCustomers)
        Me.tabAllCustomers.Location = New System.Drawing.Point(4, 22)
        Me.tabAllCustomers.Name = "tabAllCustomers"
        Me.tabAllCustomers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAllCustomers.Size = New System.Drawing.Size(492, 524)
        Me.tabAllCustomers.TabIndex = 1
        Me.tabAllCustomers.Text = "View All Customers"
        Me.tabAllCustomers.UseVisualStyleBackColor = True
        '
        'dgdViewAllCustomers
        '
        Me.dgdViewAllCustomers.AutoGenerateColumns = False
        Me.dgdViewAllCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdViewAllCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.dgdViewAllCustomers.DataSource = Me.CustomerBindingSource
        Me.dgdViewAllCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgdViewAllCustomers.Location = New System.Drawing.Point(3, 3)
        Me.dgdViewAllCustomers.Name = "dgdViewAllCustomers"
        Me.dgdViewAllCustomers.Size = New System.Drawing.Size(486, 518)
        Me.dgdViewAllCustomers.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "customerID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "customerID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "firstName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "firstName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "lastName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "lastName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "gender"
        Me.DataGridViewTextBoxColumn5.HeaderText = "gender"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "email"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "phone1"
        Me.DataGridViewTextBoxColumn8.HeaderText = "phone1"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "phone2"
        Me.DataGridViewTextBoxColumn9.HeaderText = "phone2"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "street1"
        Me.DataGridViewTextBoxColumn10.HeaderText = "street1"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "street2"
        Me.DataGridViewTextBoxColumn11.HeaderText = "street2"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "suburb"
        Me.DataGridViewTextBoxColumn12.HeaderText = "suburb"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "state"
        Me.DataGridViewTextBoxColumn13.HeaderText = "state"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "postcode"
        Me.DataGridViewTextBoxColumn14.HeaderText = "postcode"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'PetTableAdapter
        '
        Me.PetTableAdapter.ClearBeforeFill = True
        '
        'frmCustomerManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 550)
        Me.Controls.Add(Me.tabCustomerRecords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomerManagement"
        Me.Text = "Customer Menu"
        CType(Me.TickedoffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCustomerRecords.ResumeLayout(False)
        Me.tabCustomerRecord.ResumeLayout(False)
        Me.tabCustomerRecord.PerformLayout()
        Me.tabCustomerInformation.ResumeLayout(False)
        Me.tabCustomerDetails.ResumeLayout(False)
        Me.tabCustomerDetails.PerformLayout()
        Me.tabPetDetails.ResumeLayout(False)
        CType(Me.PetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bndCustomers.ResumeLayout(False)
        Me.bndCustomers.PerformLayout()
        Me.tabAllCustomers.ResumeLayout(False)
        CType(Me.dgdViewAllCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TickedoffDataSet As tickedoffDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As tickedoffDataSetTableAdapters.customerTableAdapter
    Friend WithEvents TableAdapterManager As tickedoffDataSetTableAdapters.TableAdapterManager
    Friend WithEvents tabCustomerRecords As TabControl
    Friend WithEvents tabCustomerRecord As TabPage
    Friend WithEvents tabAllCustomers As TabPage
    Friend WithEvents bndCustomers As BindingNavigator
    Friend WithEvents bndCustomersAddNewItem As ToolStripButton
    Friend WithEvents bndCustomersCountItem As ToolStripLabel
    Friend WithEvents bndCustomersDeleteItem As ToolStripButton
    Friend WithEvents bndCustomersMoveFirstItem As ToolStripButton
    Friend WithEvents bndCustomersMovePreviousItem As ToolStripButton
    Friend WithEvents bndCustomersSeparator As ToolStripSeparator
    Friend WithEvents bndCustomersPositionItem As ToolStripTextBox
    Friend WithEvents bndCustomersSeparator1 As ToolStripSeparator
    Friend WithEvents bndCustomersMoveNextItem As ToolStripButton
    Friend WithEvents bndCustomersMoveLastItem As ToolStripButton
    Friend WithEvents bndCustomersSeparator2 As ToolStripSeparator
    Friend WithEvents bndCustomersNavigatorSaveItem As ToolStripButton
    Friend WithEvents dgdViewAllCustomers As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents tabCustomerInformation As TabControl
    Friend WithEvents tabCustomerDetails As TabPage
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents SuburbTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents Street2TextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents Street1TextBox As TextBox
    Friend WithEvents DOBDateTimePicker As DateTimePicker
    Friend WithEvents Phone2TextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Phone1TextBox As TextBox
    Friend WithEvents tabPetDetails As TabPage
    Friend WithEvents PetTableAdapter As tickedoffDataSetTableAdapters.petTableAdapter
    Friend WithEvents CustomerComboBox As ComboBox
    Friend WithEvents lstPetsOwned As ListBox
    Friend WithEvents PetBindingSource As BindingSource
End Class
