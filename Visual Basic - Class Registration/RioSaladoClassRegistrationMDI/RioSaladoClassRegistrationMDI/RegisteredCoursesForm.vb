' James Sahler Parsons, jam2090280
' CIS259, section 28876
' March 25th 2018, Final Project

Public Class RegisteredCoursesForm

    ' method to delete the selected course from the list box
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim collnumber As Integer = lstCourses.SelectedIndex ' sets the selected index to a variable
        If collnumber <> -1 Then ' makes sure something is actually selected
            CType(Me.MdiParent, MdiMain).Delete(collnumber) ' and if it is it gets the course and calls the delete method
        Else
            MessageBox.Show("Please select a course to delete") ' otherwise shows the error message
        End If
    End Sub

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()  ' closes the form
    End Sub
End Class