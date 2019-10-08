<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReservedSeats
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cinema_1DataSet = New DemoProject2.Cinema_1DataSet()
        Me.TblCustomersTableAdapter = New DemoProject2.Cinema_1DataSetTableAdapters.tblCustomersTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Cinema_1DataSet1 = New DemoProject2.Cinema_1DataSet1()
        Me.TblBookingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblBookingsTableAdapter = New DemoProject2.Cinema_1DataSet1TableAdapters.tblBookingsTableAdapter()
        Me.BookingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cinema_1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cinema_1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBookingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingIDDataGridViewTextBoxColumn, Me.CustomerDataGridViewTextBoxColumn, Me.SeatDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblBookingsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 141)
        Me.DataGridView1.TabIndex = 1007
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
        Me.Label6.Location = New System.Drawing.Point(34, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 24)
        Me.Label6.TabIndex = 1009
        Me.Label6.Text = "Reserved Seats"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DemoProject2.My.Resources.Resources.Button2
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 50)
        Me.PictureBox1.TabIndex = 1008
        Me.PictureBox1.TabStop = False
        '
        'Cinema_1DataSet1
        '
        Me.Cinema_1DataSet1.DataSetName = "Cinema_1DataSet1"
        Me.Cinema_1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblBookingsBindingSource
        '
        Me.TblBookingsBindingSource.DataMember = "tblBookings"
        Me.TblBookingsBindingSource.DataSource = Me.Cinema_1DataSet1
        '
        'TblBookingsTableAdapter
        '
        Me.TblBookingsTableAdapter.ClearBeforeFill = True
        '
        'BookingIDDataGridViewTextBoxColumn
        '
        Me.BookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID"
        Me.BookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID"
        Me.BookingIDDataGridViewTextBoxColumn.Name = "BookingIDDataGridViewTextBoxColumn"
        '
        'CustomerDataGridViewTextBoxColumn
        '
        Me.CustomerDataGridViewTextBoxColumn.DataPropertyName = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.Name = "CustomerDataGridViewTextBoxColumn"
        '
        'SeatDataGridViewTextBoxColumn
        '
        Me.SeatDataGridViewTextBoxColumn.DataPropertyName = "Seat"
        Me.SeatDataGridViewTextBoxColumn.HeaderText = "Seat"
        Me.SeatDataGridViewTextBoxColumn.Name = "SeatDataGridViewTextBoxColumn"
        '
        'ReservedSeats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DemoProject2.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(248, 237)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReservedSeats"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReservedSeats"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cinema_1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cinema_1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBookingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cinema_1DataSet As Cinema_1DataSet
    Friend WithEvents TblCustomersBindingSource As BindingSource
    Friend WithEvents TblCustomersTableAdapter As Cinema_1DataSetTableAdapters.tblCustomersTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Cinema_1DataSet1 As Cinema_1DataSet1
    Friend WithEvents TblBookingsBindingSource As BindingSource
    Friend WithEvents TblBookingsTableAdapter As Cinema_1DataSet1TableAdapters.tblBookingsTableAdapter
    Friend WithEvents BookingIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
