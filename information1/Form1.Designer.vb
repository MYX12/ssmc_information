<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtDob = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.dgvInformation = New System.Windows.Forms.DataGridView()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.errorEmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorName = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorPhone = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorDob = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorAddress = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorDob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDob
        '
        Me.txtDob.Location = New System.Drawing.Point(182, 170)
        Me.txtDob.Name = "txtDob"
        Me.txtDob.Size = New System.Drawing.Size(171, 27)
        Me.txtDob.TabIndex = 20
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(182, 219)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(171, 27)
        Me.txtAddress.TabIndex = 19
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(182, 123)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(171, 27)
        Me.txtPhoneNumber.TabIndex = 18
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Location = New System.Drawing.Point(49, 173)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(40, 20)
        Me.lblDob.TabIndex = 17
        Me.lblDob.Text = "DOB"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(49, 222)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(62, 20)
        Me.lblAddress.TabIndex = 16
        Me.lblAddress.Text = "Address"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(35, 123)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(108, 20)
        Me.lblPhoneNumber.TabIndex = 15
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Location = New System.Drawing.Point(40, 80)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(103, 20)
        Me.lblEmailAddress.TabIndex = 14
        Me.lblEmailAddress.Text = "Email Address"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(182, 77)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(171, 27)
        Me.txtEmailAddress.TabIndex = 13
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(40, 35)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 20)
        Me.lblName.TabIndex = 12
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(182, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(171, 27)
        Me.txtName.TabIndex = 11
        '
        'dgvInformation
        '
        Me.dgvInformation.AllowUserToAddRows = False
        Me.dgvInformation.AllowUserToDeleteRows = False
        Me.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInformation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colName, Me.colEmail, Me.colPhone, Me.colDob, Me.colAddress})
        Me.dgvInformation.Location = New System.Drawing.Point(40, 285)
        Me.dgvInformation.Name = "dgvInformation"
        Me.dgvInformation.ReadOnly = True
        Me.dgvInformation.RowHeadersWidth = 51
        Me.dgvInformation.RowTemplate.Height = 29
        Me.dgvInformation.Size = New System.Drawing.Size(707, 200)
        Me.dgvInformation.TabIndex = 21
        '
        'colName
        '
        Me.colName.HeaderText = "Name"
        Me.colName.MinimumWidth = 6
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Width = 125
        '
        'colEmail
        '
        Me.colEmail.HeaderText = "Email Address"
        Me.colEmail.MinimumWidth = 6
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.Width = 125
        '
        'colPhone
        '
        Me.colPhone.HeaderText = "Phone Num"
        Me.colPhone.MinimumWidth = 6
        Me.colPhone.Name = "colPhone"
        Me.colPhone.ReadOnly = True
        Me.colPhone.Width = 125
        '
        'colDob
        '
        Me.colDob.HeaderText = "DOB"
        Me.colDob.MinimumWidth = 6
        Me.colDob.Name = "colDob"
        Me.colDob.ReadOnly = True
        Me.colDob.Width = 125
        '
        'colAddress
        '
        Me.colAddress.HeaderText = "Address"
        Me.colAddress.MinimumWidth = 6
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        Me.colAddress.Width = 125
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(488, 55)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(94, 29)
        Me.btnSubmit.TabIndex = 22
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(488, 110)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(94, 29)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(488, 168)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 29)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'errorEmail
        '
        Me.errorEmail.ContainerControl = Me
        '
        'errorName
        '
        Me.errorName.ContainerControl = Me
        '
        'errorPhone
        '
        Me.errorPhone.ContainerControl = Me
        '
        'errorDob
        '
        Me.errorDob.ContainerControl = Me
        '
        'errorAddress
        '
        Me.errorAddress.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 497)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.dgvInformation)
        Me.Controls.Add(Me.txtDob)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.lblDob)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblEmailAddress)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorDob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDob As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents lblDob As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents dgvInformation As DataGridView
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colPhone As DataGridViewTextBoxColumn
    Friend WithEvents colDob As DataGridViewTextBoxColumn
    Friend WithEvents colAddress As DataGridViewTextBoxColumn
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents errorEmail As ErrorProvider
    Friend WithEvents errorName As ErrorProvider
    Friend WithEvents errorPhone As ErrorProvider
    Friend WithEvents errorDob As ErrorProvider
    Friend WithEvents errorAddress As ErrorProvider
End Class
