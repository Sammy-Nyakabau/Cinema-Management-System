<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers2
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
        Me.TblCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cinema_1DataSet = New DemoProject2.Cinema_1DataSet()
        Me.TblCustomersTableAdapter = New DemoProject2.Cinema_1DataSetTableAdapters.tblCustomersTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Cinema_2DataSet = New DemoProject2.Cinema_2DataSet()
        Me.TblCustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCustomersTableAdapter1 = New DemoProject2.Cinema_2DataSetTableAdapters.tblCustomersTableAdapter()
        Me.TableAdapterManager = New DemoProject2.Cinema_2DataSetTableAdapters.TableAdapterManager()
        Me.TblCustomersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cinema_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cinema_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblCustomersBindingSource
        '
        Me.TblCustomersBindingSource.DataMember = "tblCustomers"
        Me.TblCustomersBindingSource.DataSource = Me.Cinema_1DataSet
        '
        'Cinema_1DataSet
        '
        Me.Cinema_1DataSet.DataSetName = "Cinema_1DataSet"
        Me.Cinema_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Label6.Location = New System.Drawing.Point(17, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 24)
        Me.Label6.TabIndex = 1009
        Me.Label6.Text = "Registered Customers"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DemoProject2.My.Resources.Resources.Button2
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 50)
        Me.PictureBox1.TabIndex = 1008
        Me.PictureBox1.TabStop = False
        '
        'Cinema_2DataSet
        '
        Me.Cinema_2DataSet.DataSetName = "Cinema_2DataSet"
        Me.Cinema_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCustomersBindingSource1
        '
        Me.TblCustomersBindingSource1.DataMember = "tblCustomers"
        Me.TblCustomersBindingSource1.DataSource = Me.Cinema_2DataSet
        '
        'TblCustomersTableAdapter1
        '
        Me.TblCustomersTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblBookingsTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomersTableAdapter = Me.TblCustomersTableAdapter1
        Me.TableAdapterManager.UpdateOrder = DemoProject2.Cinema_2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblCustomersDataGridView
        '
        Me.TblCustomersDataGridView.AutoGenerateColumns = False
        Me.TblCustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblCustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblCustomersDataGridView.DataSource = Me.TblCustomersBindingSource1
        Me.TblCustomersDataGridView.Location = New System.Drawing.Point(21, 68)
        Me.TblCustomersDataGridView.Name = "TblCustomersDataGridView"
        Me.TblCustomersDataGridView.Size = New System.Drawing.Size(212, 171)
        Me.TblCustomersDataGridView.TabIndex = 1009
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CustomerID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CustomerID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Email Address"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Email Address"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Customers2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DemoProject2.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(266, 280)
        Me.Controls.Add(Me.TblCustomersDataGridView)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Customers2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select A Customer"
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cinema_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cinema_2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TblCustomersBindingSource As BindingSource
    Friend WithEvents Cinema_1DataSet As Cinema_1DataSet
    Friend WithEvents TblCustomersTableAdapter As Cinema_1DataSetTableAdapters.tblCustomersTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Cinema_2DataSet As Cinema_2DataSet
    Friend WithEvents TblCustomersBindingSource1 As BindingSource
    Friend WithEvents TblCustomersTableAdapter1 As Cinema_2DataSetTableAdapters.tblCustomersTableAdapter
    Friend WithEvents TableAdapterManager As Cinema_2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblCustomersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
