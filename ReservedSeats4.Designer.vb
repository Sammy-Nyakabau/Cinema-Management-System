<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservedSeats4
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblBookingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cinema_4DataSet3 = New DemoProject2.Cinema_4DataSet3()
        Me.TblBookingsTableAdapter = New DemoProject2.Cinema_4DataSet3TableAdapters.tblBookingsTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBookingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cinema_4DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Image = Global.DemoProject2.My.Resources.Resources.Button2
        Me.Label6.Location = New System.Drawing.Point(34, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 24)
        Me.Label6.TabIndex = 1015
        Me.Label6.Text = "Reserved Seats"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DemoProject2.My.Resources.Resources.Button2
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 50)
        Me.PictureBox1.TabIndex = 1014
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingIDDataGridViewTextBoxColumn, Me.CustomerDataGridViewTextBoxColumn, Me.SeatDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblBookingsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(216, 150)
        Me.DataGridView1.TabIndex = 1016
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
        'TblBookingsBindingSource
        '
        Me.TblBookingsBindingSource.DataMember = "tblBookings"
        Me.TblBookingsBindingSource.DataSource = Me.Cinema_4DataSet3
        '
        'Cinema_4DataSet3
        '
        Me.Cinema_4DataSet3.DataSetName = "Cinema_4DataSet3"
        Me.Cinema_4DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblBookingsTableAdapter
        '
        Me.TblBookingsTableAdapter.ClearBeforeFill = True
        '
        'ReservedSeats4
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
        Me.Name = "ReservedSeats4"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReservedSeats"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBookingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cinema_4DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cinema_4DataSet3 As Cinema_4DataSet3
    Friend WithEvents TblBookingsBindingSource As BindingSource
    Friend WithEvents TblBookingsTableAdapter As Cinema_4DataSet3TableAdapters.tblBookingsTableAdapter
    Friend WithEvents BookingIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
