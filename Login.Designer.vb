<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginInfo))
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UsersDataSet = New DemoProject2.UsersDataSet()
        Me.AdminBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminTableAdapter = New DemoProject2.UsersDataSetTableAdapters.AdminTableAdapter()
        Me.TableAdapterManager = New DemoProject2.UsersDataSetTableAdapters.TableAdapterManager()
        Me.UsernamesTableAdapter = New DemoProject2.UsersDataSetTableAdapters.UsernamesTableAdapter()
        Me.UsernamesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.linkVisitor = New System.Windows.Forms.LinkLabel()
        Me.UsernamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsernamesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsernamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTime.Location = New System.Drawing.Point(135, 238)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(45, 15)
        Me.lblTime.TabIndex = 25
        Me.lblTime.Text = "Label5"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDate.Location = New System.Drawing.Point(141, 223)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(45, 15)
        Me.lblDate.TabIndex = 24
        Me.lblDate.Text = "Label4"
        '
        'Timer1
        '
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogin.BackgroundImage = Global.DemoProject2.My.Resources.Resources.Login
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.Location = New System.Drawing.Point(408, 227)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(104, 36)
        Me.btnLogin.TabIndex = 23
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(429, 146)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(140, 20)
        Me.txtPassword.TabIndex = 22
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(429, 102)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(140, 20)
        Me.txtUsername.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(359, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(359, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Username:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.DemoProject2.My.Resources.Resources.TimeBoxFinal
        Me.PictureBox1.Location = New System.Drawing.Point(52, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'UsersDataSet
        '
        Me.UsersDataSet.DataSetName = "UsersDataSet"
        Me.UsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminBindingSource1
        '
        Me.AdminBindingSource1.DataMember = "Admin"
        Me.AdminBindingSource1.DataSource = Me.UsersDataSet
        '
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Me.AdminTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = DemoProject2.UsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsernamesTableAdapter = Me.UsernamesTableAdapter
        '
        'UsernamesTableAdapter
        '
        Me.UsernamesTableAdapter.ClearBeforeFill = True
        '
        'UsernamesBindingSource1
        '
        Me.UsernamesBindingSource1.DataMember = "Usernames"
        Me.UsernamesBindingSource1.DataSource = Me.UsersDataSet
        '
        'linkVisitor
        '
        Me.linkVisitor.ActiveLinkColor = System.Drawing.Color.Black
        Me.linkVisitor.AutoSize = True
        Me.linkVisitor.BackColor = System.Drawing.Color.Transparent
        Me.linkVisitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkVisitor.LinkColor = System.Drawing.Color.White
        Me.linkVisitor.Location = New System.Drawing.Point(443, 279)
        Me.linkVisitor.Name = "linkVisitor"
        Me.linkVisitor.Size = New System.Drawing.Size(54, 13)
        Me.linkVisitor.TabIndex = 26
        Me.linkVisitor.TabStop = True
        Me.linkVisitor.Text = "Visitor..."
        '
        'UsernamesBindingSource
        '
        Me.UsernamesBindingSource.DataMember = "Usernames"
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "Admin"
        '
        'LoginInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DemoProject2.My.Resources.Resources.Presentation1
        Me.ClientSize = New System.Drawing.Size(589, 345)
        Me.Controls.Add(Me.linkVisitor)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsernamesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsernamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernamesBindingSource As BindingSource
    Friend WithEvents AdminBindingSource As BindingSource
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UsersDataSet As UsersDataSet
    Friend WithEvents AdminBindingSource1 As BindingSource
    Friend WithEvents AdminTableAdapter As UsersDataSetTableAdapters.AdminTableAdapter
    Friend WithEvents TableAdapterManager As UsersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsernamesTableAdapter As UsersDataSetTableAdapters.UsernamesTableAdapter
    Friend WithEvents UsernamesBindingSource1 As BindingSource
    Friend WithEvents linkVisitor As LinkLabel
End Class
