' James Sahler Parsons, jam2090280
' CIS159, section 13576
' January 7th 2012, Final Project

Imports System.IO

Public Class MainForm

    Dim SaveFile As StreamWriter   ' declaring the streamreader and streamwriter objects
    Dim ReadFile As StreamReader


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strInput As String = ""
        Dim aeisFile As StreamReader
        Dim strLabelNameTag As String    ' declaring the variables
        Dim intStopper As Integer = 0
        Dim c As Integer = 0
        Dim strLower As String
        Dim strUpper As String
        aeisFile = File.OpenText("AEIS.txt")   ' opens the AEIS text file

        Do Until aeisFile.EndOfStream          ' concatenates the entire text file to one string
            strInput = strInput + aeisFile.ReadLine()
        Loop
        strLower = strInput.ToLower            ' makes it all lower case

        Dim intAEISLength As Integer = strInput.Length
        Do                             ' these loops cycle through the AEIS text file and search for the correct letter
            intStopper = 0
            If strInput(c) = "j" Then
                strUpper = strInput(c)
                strUpper = strUpper.ToUpper
                strLabelNameTag = strUpper   ' then concatenates it to the string strLabelNameTag
                intStopper = 1
            Else
                c = c + 1
            End If
        Loop Until intStopper = 1

        Do
            intStopper = 0
            If strInput(c) = "a" Then
                strLabelNameTag = strLabelNameTag + strInput(c)
                intStopper = 1
            Else
                c = c + 1
            End If
        Loop Until intStopper = 1

        Do
            intStopper = 0
            If strInput(c) = "m" Then
                strLabelNameTag = strLabelNameTag + strInput(c)
                intStopper = 1
            Else
                c = c + 1
            End If
        Loop Until intStopper = 1

        Do
            intStopper = 0
            If strInput(c) = "e" Then
                strLabelNameTag = strLabelNameTag + strInput(c)
                intStopper = 1
            Else
                c = c + 1
            End If
        Loop Until intStopper = 1

        Do
            intStopper = 0
            If strInput(c) = "s" Then
                strLabelNameTag = strLabelNameTag + strInput(c)
                intStopper = 1
            Else
                c = c + 1
            End If
        Loop Until intStopper = 1

        strLabelNameTag = strLabelNameTag + " "

        Do
            intStopper = 0
            If strInput(c) = "p" Then
                strUpper = strInput(c)
                strUpper = strUpper.ToUpper
                strLabelNameTag = strLabelNameTag + strUpper
                intStopper = 1
            Else
                c = c + 1
            End If
        Loop Until intStopper = 1

        Do
            intStopper = 0
            If strInput(c) = "a" Then
                strLabelNameTag = strLabelNameTag + strInput(c)
                intStopper = 1
            Else
                c = c + 1
            End If
        Loop Until intStopper = 1

        Do
            intStopper = 0
            If strInput(c) = "r" Then
                strLabelNameTag = strLabelNameTag + strInput(c)
                intStopper = 1
            Else
                c = c + 1
            End If
        Loop Until intStopper = 1

        Do
            intStopper = 0
            If strInput(c) = "s" Then
                strLabelNameTag = strLabelNameTag + strInput(c)
                intStopper = 1
            Else
                c = c + 1
            End If
        Loop Until intStopper = 1

        Do
            intStopper = 0
            If strInput(c) = "o" Then
                strLabelNameTag = strLabelNameTag + strInput(c)
                intStopper = 1
            Else
                c = c + 1
            End If
        Loop Until intStopper = 1

        Do
            intStopper = 0
            If strInput(c) = "n" Then
                strLabelNameTag = strLabelNameTag + strInput(c)
                intStopper = 1
            Else
                c = c + 1
            End If
        Loop Until intStopper = 1

        Do
            intStopper = 0
            If strInput(c) = "s" Then
                strLabelNameTag = strLabelNameTag + strInput(c)
                intStopper = 1
            Else
                c = c + 1
            End If
        Loop Until intStopper = 1

        lblNameTag.Text = strLabelNameTag   ' outputs my name to the label

        FormFill()         ' fills the form
    End Sub


    Private Sub AddNewRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewRecordToolStripMenuItem.Click
        Dim frmAddForm As New AddForm
        frmAddForm.Show()              ' creates a new instance of the AddForm and displays it
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()                      ' closes the form
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()                       ' closes the form
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        FormClear()              ' calls the method that clears the form

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
   
        Try
            intCollectionIndex = intCollectionIndex - 1  ' cycles through the collection to one index number lesser than the current one
            Dim cust As CustomerData = CType(Customers.Item(intCollectionIndex), CustomerData)
            FormFill()       ' and calls the method to display it
        Catch ex As Exception
            MessageBox.Show("You have reached the start of the collection")
            intCollectionIndex = intCollectionIndex + 1
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Try
            intCollectionIndex = intCollectionIndex + 1  ' cycles through the collection to the next structure
            Dim cust As CustomerData = CType(Customers.Item(intCollectionIndex), CustomerData)
            FormFill()                                   ' and calls the method to display it
        Catch ex As Exception
            MessageBox.Show("You have reached the end of the collection")
            intCollectionIndex = intCollectionIndex - 1
        End Try
    End Sub

    Private Sub BylastNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BylastNameToolStripMenuItem.Click

        Dim intIndex As Integer = 1       ' declare the local variables
        Dim intStopper As Integer = 0
        Dim strCustNameInput As String
        strCustNameInput = InputBox("Please enter Last Name to search for", "Customer Last Name Search")  ' asks the user for what name they want to search for andd sets it to a string

        Do
            Dim cust As CustomerData
            cust = CType(Customers.Item(intIndex), CustomerData)
            If cust.strLast = strCustNameInput Then  ' cycles through the collection to find a match
                lblLast.Text = cust.strLast
                lblFirst.Text = cust.strFirst
                lblCustNum.Text = cust.intCustNum
                lblAddress.Text = cust.strAddress
                lblCity.Text = cust.strCity
                lblState.Text = cust.strState
                lblZip.Text = cust.intZip
                lblPhone.Text = cust.lngPhone
                lblAccount.Text = cust.decAccount
                lblPayment.Text = cust.dtmPayment
                intStopper = 1
            End If
            intIndex = intIndex + 1  ' if no match is found the collection index is increased by one, and it cycles again
        Loop While intIndex <= Customers.Count And intStopper <> 1

        If intStopper <> 1 Then
            MessageBox.Show("No record found with that Customer Name, check case and name and try again")
        End If

    End Sub

    Private Sub FormClear()     ' method to clear the form, sets all labels to empty
        lblLast.Text = String.Empty
        lblFirst.Text = String.Empty
        lblCustNum.Text = String.Empty
        lblAddress.Text = String.Empty
        lblCity.Text = String.Empty
        lblState.Text = String.Empty
        lblZip.Text = String.Empty
        lblPhone.Text = String.Empty
        lblAccount.Text = String.Empty
        lblPayment.Text = String.Empty
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If intOpener = 0 Then
            intOpener = 1
            SaveFile = File.CreateText("SaveList.txt")  ' if no file exists, it creates one
            SaveToFile()                                 ' calls the method to save the information
        Else
            SaveFile = File.AppendText("SaveList.txt")  ' if the file already exists it just appends it
            SaveToFile()                                 ' calls the method to save the information
        End If

        SaveFile.Close() ' closes the file


    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        ReadFile = File.OpenText("SaveList.txt")   ' opens the file

        Do Until ReadFile.EndOfStream
            intCollectionIndex = intCollectionIndex + 1
            ReadFromFile()          ' reads from the file
        Loop

        ReadFile.Close()    ' closes the file

    End Sub

    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage

        Dim printFile As StreamReader  ' new streamreader object
        Dim intY1 As Integer = 200
        Dim intY2 As Integer = 220
        Dim strLast As String
        Dim strFirst As String
        Dim strCustNum As String    ' strings to hold the info from each readline()
        Dim strAddress As String
        Dim strCity As String
        Dim strState As String
        Dim strZip As String
        Dim strPhone As String
        Dim strAccount As String
        Dim strPayment As String
        Dim strNotUsed As String
        Dim strTotal As String
        Dim strTotal2 As String
        Dim strSpacer As String = "  "
    
        Try
            printFile = File.OpenText("SaveList.txt")  ' opens the file and prints the header
            e.Graphics.DrawString("Customer Information", New Font("Courier", 18, FontStyle.Bold), Brushes.Black, 300, 80)

            Do Until printFile.EndOfStream ' loops until end of document

                strLast = printFile.ReadLine()     ' reads the file and sets it values to strings
                strFirst = printFile.ReadLine()
                strCustNum = printFile.ReadLine()
                strAddress = printFile.ReadLine()
                strCity = printFile.ReadLine()
                strState = printFile.ReadLine()
                strZip = printFile.ReadLine()
                strPhone = printFile.ReadLine()
                strAccount = printFile.ReadLine()
                strPayment = printFile.ReadLine()
                strNotUsed = printFile.ReadLine()

                ' uses string.format to format it so it looks nice
                strTotal = String.Format("{0, 20}{1, 5}{2, -20}{3, 5}{4, 30}{5, 15}{6,15}{7,10} ", strLast, strSpacer, strFirst, strCustNum, strAddress, strCity, strState, strZip)
                strTotal2 = String.Format("{0, 40}{1, 20}{2, 25}{3, 25} ", strSpacer, strPhone, strAccount, strPayment)

                ' and prints
                e.Graphics.DrawString(strTotal, New Font("courier", 12, FontStyle.Regular), Brushes.Black, 10, intY1)   ' prints the data
                e.Graphics.DrawString(strTotal2, New Font("courier", 12, FontStyle.Regular), Brushes.Black, 10, intY2)

                intY1 = intY1 + 50  ' increments the x and y variables, so the print position iterates
                intY2 = intY2 + 50
            Loop

            printFile.Close()  ' closes the file
        Catch
            MessageBox.Show("Something went wrong")  ' these are not the droids you're looking for
        End Try
  
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        pdPrint.Print()   ' calls the print method
    End Sub

    Private Sub ByCustomerNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByCustomerNumberToolStripMenuItem.Click

        Dim intIndex As Integer = 1       ' declare the local variables
        Dim intStopper As Integer = 0
        Dim strCustNumInput As String
        Dim intCustInputNum As Integer
        strCustNumInput = InputBox("Please enter Customer Number to search for", "Customer Number Search")  ' asks the user for what number they want to search for andd sets it to a string

        Try
            Int32.Parse(strCustNumInput)       ' tries to convert input into integer, or asks user again for customer number
            intCustInputNum = strCustNumInput
        Catch ex As Exception
            strCustNumInput = InputBox("Please enter Customer Number that is a valid integer to search for", "Customer Number Search")
        End Try

        Do
            Dim cust As CustomerData
            cust = CType(Customers.Item(intIndex), CustomerData)
            If cust.intCustNum = strCustNumInput Then  ' cycles through the collection to find a match
                lblLast.Text = cust.strLast
                lblFirst.Text = cust.strFirst
                lblCustNum.Text = cust.intCustNum
                lblAddress.Text = cust.strAddress
                lblCity.Text = cust.strCity
                lblState.Text = cust.strState
                lblZip.Text = cust.intZip
                lblPhone.Text = cust.lngPhone
                lblAccount.Text = cust.decAccount
                lblPayment.Text = cust.dtmPayment
                intStopper = 1
            End If
            intIndex = intIndex + 1  ' if no match is found the collection index is increased by one, and it cycles again
        Loop While intIndex <= Customers.Count And intStopper <> 1

        If intStopper <> 1 Then
            MessageBox.Show("No record found with that Customer Number, please try again")
        End If

    End Sub

    Private Sub SaveToFile()  ' the savetofile method

        Dim cust As CustomerData = CType(Customers.Item(intCollectionIndex), CustomerData)

        SaveFile.WriteLine(cust.strLast)  ' creates a new 'cust' structure and writes it to the file
        SaveFile.WriteLine(cust.strFirst)
        SaveFile.WriteLine(cust.intCustNum)
        SaveFile.WriteLine(cust.strAddress)
        SaveFile.WriteLine(cust.strCity)
        SaveFile.WriteLine(cust.strState)
        SaveFile.WriteLine(cust.intZip)
        SaveFile.WriteLine(cust.lngPhone)
        SaveFile.WriteLine(cust.decAccount)
        SaveFile.WriteLine(cust.dtmPayment)
        SaveFile.WriteLine(cust.intPermanentIndex)

        MessageBox.Show("Record of " + cust.strLast + " has been saved to SaveFile.txt")
    End Sub

    Private Sub ReadFromFile()

        Dim cust As New CustomerData      ' creates a new 'cust' structure and populates it with values from the file
        cust.strLast = ReadFile.ReadLine()
        cust.strFirst = ReadFile.ReadLine()
        cust.intCustNum = ReadFile.ReadLine()
        cust.strAddress = ReadFile.ReadLine()
        cust.strCity = ReadFile.ReadLine()
        cust.strState = ReadFile.ReadLine()
        cust.intZip = ReadFile.ReadLine()
        cust.lngPhone = ReadFile.ReadLine()
        cust.decAccount = ReadFile.ReadLine()
        cust.dtmPayment = ReadFile.ReadLine()
        cust.intPermanentIndex = ReadFile.ReadLine()
 
        Customers.Add(cust)

        lblLast.Text = cust.strLast      ' displays the info
        lblFirst.Text = cust.strFirst
        lblCustNum.Text = cust.intCustNum
        lblAddress.Text = cust.strAddress
        lblCity.Text = cust.strCity
        lblState.Text = cust.strState
        lblZip.Text = cust.intZip
        lblPhone.Text = cust.lngPhone
        lblAccount.Text = cust.decAccount
        lblPayment.Text = cust.dtmPayment

    End Sub


    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MessageBox.Show("Created by James Sahler Parsons, jam2090280.  CIS159 final project.  A visual basic program for storing, saving, printing, and reading customer data.")
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim frmAddForm As New AddForm
        frmAddForm.Show()              ' creates a new instance of the AddForm and displays it
    End Sub

End Class





