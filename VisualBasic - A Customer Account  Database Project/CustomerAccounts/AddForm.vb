' James Sahler Parsons, jam2090280
' CIS159, section 13576
' January 7th 2012, Final Project

Public Class AddForm

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim myCustomer As New CustomerData
        Dim intStopperCustNum As Integer = 0
        Dim intStopperZip As Integer = 0            ' declaring the variables
        Dim intStopperPhone As Integer = 0
        Dim intStopperAccount As Integer = 0
        Dim intStopperBlank As Integer = 0
        Dim intStopperDate As Integer = 0
        intAddPress = 1

        If intAddPress = 1 Then       ' only goes through the validation when someone presses the 'add' button
            intAddPress = 0

            ' validates that no spaces are left blank or whitespace, and that numbers are in apporpriate format
            If String.IsNullOrWhiteSpace(txtLast.Text) Or String.IsNullOrWhiteSpace(txtFirst.Text) Or String.IsNullOrWhiteSpace(txtAddress.Text) Or String.IsNullOrWhiteSpace(txtCity.Text) Or String.IsNullOrWhiteSpace(txtState.Text) Then
                MessageBox.Show("Please make sure no sells are left blank")
            Else
                intStopperBlank = 1
            End If
            Try
                Int32.Parse(txtCustNum.Text)
                intStopperCustNum = 1
            Catch
                MessageBox.Show("Please enter a valid customer number in integer form, like 456")
            End Try
            Try
                myCustomer.intZip = CInt(txtZip.Text)
                intStopperZip = 1
            Catch ex As Exception
                MessageBox.Show("Please enter a valid zip code in digits, like 85749")
            End Try
            Try
                myCustomer.lngPhone = CLng(txtPhone.Text)
                intStopperPhone = 1
            Catch ex As Exception
                MessageBox.Show("Please enter a valid phone number using just the digits, like 5555555555")
            End Try
            Try
                myCustomer.decAccount = CDec(txtAccount.Text)
                If myCustomer.decAccount >= 0 Then
                    intStopperAccount = 1
                Else
                    MessageBox.Show("Please enter a positive number for Account Balance")
                End If
            Catch ex As Exception
                MessageBox.Show("Please enter a valid account balance using just digits and a decimal, like 55.75")
            End Try
            Try
                myCustomer.dtmPayment = CDate(txtPayment.Text)
                intStopperDate = 1
            Catch ex As Exception
                MessageBox.Show("Please enter a valid date, like 12/12/2018")
            End Try
        End If

        If intStopperCustNum = 1 And intStopperZip = 1 And intStopperPhone = 1 And intStopperAccount = 1 And intStopperBlank = 1 And intStopperDate = 1 Then
            ' if all input is the correct format then it creates a structure with the input info
            intPermanentIndex = intPermanentIndex + 1
            myCustomer.strLast = txtLast.Text
            myCustomer.strFirst = txtFirst.Text
            myCustomer.intCustNum = CInt(txtCustNum.Text)
            myCustomer.strAddress = txtAddress.Text
            myCustomer.strCity = txtCity.Text
            myCustomer.strState = txtState.Text
            myCustomer.intZip = CInt(txtZip.Text)
            myCustomer.lngPhone = CLng(txtPhone.Text)
            myCustomer.decAccount = CDec(txtAccount.Text)
            myCustomer.dtmPayment = txtPayment.Text
            myCustomer.intPermanentIndex = (intPermanentIndex)

            Customers.Add(myCustomer, myCustomer.intPermanentIndex)  ' adds it to the collection
            intCollectionIndex = intCollectionIndex + 1

            ' creates an instance of the structure
            Dim cust As CustomerData = CType(Customers.Item(intCollectionIndex), CustomerData)

            ' formats it back into a structure
            MessageBox.Show("Customer " + txtFirst.Text + " " + txtLast.Text + " added")

            FormFill()      ' uses the info to fill out the main form
            FormClear()  ' clears the form
            txtLast.Focus()   'and returns the focus back to the first textbox
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()   ' closes the form
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        FormClear()   ' clears the form

    End Sub

    Private Sub FormClear()   ' the form clear method, clears the form
        txtLast.Text = ""
        txtFirst.Text = ""
        txtCustNum.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZip.Text = ""
        txtPhone.Text = ""
        txtAccount.Text = ""
        txtPayment.Text = ""
    End Sub



End Class