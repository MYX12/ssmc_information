Public Class Form1
    Dim THREAD1, THREAD2, THREAD3, THREAD4 As System.Threading.Thread
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        THREAD1 = New System.Threading.Thread(AddressOf Validation)
        THREAD1.Start()
    End Sub

    Private Sub dgvInformation_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInformation.CellClick
        THREAD2 = New System.Threading.Thread(AddressOf Getrow)
        THREAD2.Start()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        THREAD3 = New System.Threading.Thread(AddressOf Editrow)
        THREAD3.Start()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        THREAD4 = New System.Threading.Thread(AddressOf Deleterow)
        THREAD4.Start()
    End Sub

    Private Sub Validation()
        'validation part
        If (String.IsNullOrEmpty(txtName.Text.Trim())) Then
            errorName.SetError(txtName, "Name is required")
        ElseIf (String.IsNullOrEmpty(txtEmailAddress.Text.Trim())) Then
            errorEmail.SetError(txtEmailAddress, "Email Address is required")
        ElseIf (String.IsNullOrEmpty(txtPhoneNumber.Text.Trim())) Then
            errorPhone.SetError(txtPhoneNumber, "Phone Number is required")
        ElseIf (String.IsNullOrEmpty(txtDob.Text.Trim())) Then
            errorDob.SetError(txtDob, "Dob is required")
        ElseIf (String.IsNullOrEmpty(txtAddress.Text.Trim())) Then
            errorAddress.SetError(txtAddress, "Address is required")
        Else
            errorName.SetError(txtName, "")
            errorEmail.SetError(txtEmailAddress, "")
            errorPhone.SetError(txtPhoneNumber, "")
            errorDob.SetError(txtDob, "")
            errorAddress.SetError(txtAddress, "")
            If IsNumeric(txtName.Text) Then
                errorName.SetError(txtName, "You have input a numeric value and this is not valid")
            ElseIf Not IsNumeric(txtPhoneNumber.Text) Then
                errorPhone.SetError(txtPhoneNumber, "You have input a string and this is not valid")
            Else
                errorName.SetError(txtName, "")
                errorPhone.SetError(txtPhoneNumber, "")
                Me.dgvInformation.Rows.Add(txtName.Text, txtEmailAddress.Text, txtPhoneNumber.Text,
            txtDob.Text, txtAddress.Text)
                'clear txtbox values
                txtName.Text = ""
                txtEmailAddress.Text = ""
                txtPhoneNumber.Text = ""
                txtDob.Text = ""
                txtAddress.Text = ""
            End If
        End If
    End Sub
    Private Sub Getrow()
        Dim dr As DataGridViewRow = dgvInformation.SelectedRows(0)
        txtName.Text = dr.Cells(0).Value
        txtEmailAddress.Text = dr.Cells(1).Value
        txtPhoneNumber.Text = dr.Cells(2).Value
        txtDob.Text = dr.Cells(3).Value
        txtAddress.Text = dr.Cells(4).Value
    End Sub
    Private Sub Editrow()
        Dim update As DataGridViewRow = dgvInformation.SelectedRows(0)
        update.Cells(0).Value = txtName.Text
        update.Cells(1).Value = txtEmailAddress.Text
        update.Cells(2).Value = txtPhoneNumber.Text
        update.Cells(3).Value = txtDob.Text
        update.Cells(4).Value = txtAddress.Text
        'clear txtbox values
        txtName.Text = ""
        txtEmailAddress.Text = ""
        txtPhoneNumber.Text = ""
        txtDob.Text = ""
        txtAddress.Text = ""
    End Sub
    Private Sub Deleterow()
        dgvInformation.Rows.RemoveAt(dgvInformation.SelectedRows(0).Index)
        'clear txtbox values
        txtName.Text = ""
        txtEmailAddress.Text = ""
        txtPhoneNumber.Text = ""
        txtDob.Text = ""
        txtAddress.Text = ""
    End Sub
End Class
