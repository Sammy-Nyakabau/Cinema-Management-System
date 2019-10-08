<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomer3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCustomer3))
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.TblCustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cinema_2DataSet = New DemoProject2.Cinema_2DataSet()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager = New DemoProject2.Cinema_2DataSetTableAdapters.TableAdapterManager()
        Me.TblCustomersTableAdapter1 = New DemoProject2.Cinema_2DataSetTableAdapters.tblCustomersTableAdapter()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TblCustomersTableAdapter = New DemoProject2.Cinema_1DataSetTableAdapters.tblCustomersTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Cinema_1DataSet = New DemoProject2.Cinema_1DataSet()
        Me.TblCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        CType(Me.TblCustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cinema_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cinema_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.BackColor = System.Drawing.Color.Transparent
        LastNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        LastNameLabel.Location = New System.Drawing.Point(83, 159)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 62
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.BackColor = System.Drawing.Color.Transparent
        FirstNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        FirstNameLabel.Location = New System.Drawing.Point(84, 127)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 60
        FirstNameLabel.Text = "First Name:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.BackColor = System.Drawing.Color.Transparent
        CustomerIDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        CustomerIDLabel.Location = New System.Drawing.Point(84, 91)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(68, 13)
        CustomerIDLabel.TabIndex = 57
        CustomerIDLabel.Text = "Customer ID:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(158, 156)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 63
        '
        'TblCustomersBindingSource1
        '
        Me.TblCustomersBindingSource1.DataMember = "tblCustomers"
        Me.TblCustomersBindingSource1.DataSource = Me.Cinema_2DataSet
        '
        'Cinema_2DataSet
        '
        Me.Cinema_2DataSet.DataSetName = "Cinema_2DataSet"
        Me.Cinema_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(158, 88)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerID.TabIndex = 59
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblBookingsTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomersTableAdapter = Me.TblCustomersTableAdapter1
        Me.TableAdapterManager.UpdateOrder = DemoProject2.Cinema_2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblCustomersTableAdapter1
        '
        Me.TblCustomersTableAdapter1.ClearBeforeFill = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(158, 124)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 61
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Location = New System.Drawing.Point(120, 213)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 23)
        Me.btnSave.TabIndex = 58
        Me.btnSave.Text = "Save "
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TblCustomersTableAdapter
        '
        Me.TblCustomersTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Image = Global.DemoProject2.My.Resources.Resources.Button2
        Me.Label6.Location = New System.Drawing.Point(44, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(214, 24)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Create New Customer"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 259)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(338, 57)
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'Cinema_1DataSet
        '
        Me.Cinema_1DataSet.DataSetName = "Cinema_1DataSet"
        Me.Cinema_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCustomersBindingSource
        '
        Me.TblCustomersBindingSource.DataMember = "tblCustomers"
        Me.TblCustomersBindingSource.DataSource = Me.Cinema_1DataSet
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 50)
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'AddCustomer3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DemoProject2.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(338, 316)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddCustomer3"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddCustomer"
        CType(Me.TblCustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cinema_2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cinema_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLastName As TextBox
    Friend WithEvents TblCustomersBindingSource1 As BindingSource
    Friend WithEvents Cinema_2DataSet As Cinema_2DataSet
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents TableAdapterManager As Cinema_2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblCustomersTableAdapter1 As Cinema_2DataSetTableAdapters.tblCustomersTableAdapter
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents TblCustomersTableAdapter As Cinema_1DataSetTableAdapters.tblCustomersTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Cinema_1DataSet As Cinema_1DataSet
    Friend WithEvents TblCustomersBindingSource As BindingSource
    Friend WithEvents PictureBox1 As PictureBox
End Class
