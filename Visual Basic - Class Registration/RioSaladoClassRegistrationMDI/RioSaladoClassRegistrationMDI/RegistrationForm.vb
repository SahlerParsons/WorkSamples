' James Sahler Parsons, jam2090280
' CIS259, section 28876
' March 25th 2018, Final Project

Public Class RegistrationForm
    ' an array of course times
    Dim m_CourseDaysTimes() As String = {"MW 8:00am", "MW 11:00am", "TR 8:00am", "TR 9:00am", "MW 9:00am", "MW 12:00pm", "TR 10:00am", "TR 11:00am"}

    Private Sub cboCourses_SelectedIndexChanged() Handles cboCourses.SelectedIndexChanged
        ' matches the times in the array to their corresponding course when the selection changes
        ' and outputs the date / time to the date/time label
        lblDateTime.Text = m_CourseDaysTimes(cboCourses.SelectedIndex)
    End Sub

    ' confirm button click event handler
    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        If cboCourses.SelectedIndex <> -1 Then ' makes sure a course is selected
            ' sets the course title and the date time all to a variable
            Dim testerstring As String = cboCourses.SelectedItem.ToString() & " [" & lblDateTime.Text & "]"
            ' adds the title and date/time to the collection by calling the method in the mdi main
            CType(Me.MdiParent, MdiMain).AddCourse(testerstring)
        Else
            MessageBox.Show("Please select a course") ' otherwise shows the error message
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close() ' closes the form
    End Sub

End Class
