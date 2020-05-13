' James Sahler Parsons, jam2090280
' CIS159, section 13576
' January 7th 2012, Final Project


Module Module1


    Structure CustomerData   ' the structure

        Dim strLast As String
        Dim strFirst As String
        Dim intCustNum As Integer
        Dim strAddress As String
        Dim strCity As String
        Dim strState As String
        Dim intZip As Integer
        Dim lngPhone As Long
        Dim decAccount As Decimal
        Dim dtmPayment As Date
        Dim intPermanentIndex As Integer

    End Structure

    Public Customers As New Collection   ' the collection (of structures)

    Public intCollectionIndex As Integer = 0
    Public intAddPress As Integer = 0
    Public intPermanentIndex As Integer = 0
    Public intOpener As Integer = 0



    Public Sub FormFill()    ' the form fill method, fills out the main form with a member of the collection
        If Customers.Count > 0 Then
            Dim cust As CustomerData = CType(Customers.Item(intCollectionIndex), CustomerData)
            MainForm.lblLast.Text = cust.strLast
            MainForm.lblFirst.Text = cust.strFirst
            MainForm.lblCustNum.Text = cust.intCustNum
            MainForm.lblAddress.Text = cust.strAddress
            MainForm.lblCity.Text = cust.strCity
            MainForm.lblState.Text = cust.strState
            MainForm.lblZip.Text = cust.intZip
            MainForm.lblPhone.Text = cust.lngPhone
            MainForm.lblAccount.Text = cust.decAccount
            MainForm.lblPayment.Text = cust.dtmPayment
        End If
    End Sub

End Module






