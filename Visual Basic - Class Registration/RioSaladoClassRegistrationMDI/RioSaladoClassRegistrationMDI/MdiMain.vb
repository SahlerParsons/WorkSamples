' James Sahler Parsons, jam2090280
' CIS259, section 28876
' March 25th 2018, Final Project

Imports System.Windows.Forms

Public Class MdiMain
    ' a collection to hold the courses that are chosen
    Private m_RegisteredCourses As New Collection
    ' method to add courses to the collection
    Public Sub AddCourse(ByVal course As String)
        Dim stopper As Integer = 0 ' resets the tester on every click
        For Each coursething In m_RegisteredCourses ' iterates through the collection
            If coursething = course Then ' to see if a course has already been chosen
                MessageBox.Show("You already have this class, please choose another")
                stopper = 1
            End If
        Next
        If stopper <> 1 Then ' if it hasnt then then it is added to the collection and the list refreshes
            m_RegisteredCourses.Add(course)
            RefreshList()
        End If
    End Sub
    ' method to remove a selected course from the collection, and then updates the listbox
    Public Sub Delete(ByVal collnumber As Integer)
        m_RegisteredCourses.Remove(collnumber + 1)
        RefreshList()
    End Sub
    ' method to refresh the listbox 
    Public Sub RefreshList()
        RegisteredCoursesForm.lstCourses.Items.Clear() ' first clears the list box
        For Each course In m_RegisteredCourses  ' then iterates through the collection and
            RegisteredCoursesForm.lstCourses.Items.Add(course) ' re-adds all the courses
        Next
    End Sub
    ' click event for view registered courses menu selection
    Private Sub RegisteredCoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisteredCoursesToolStripMenuItem.Click

        RegisteredCoursesForm.MdiParent = Me ' sets the main mdi form as the registered courses parent form
        RegisteredCoursesForm.Show()  ' shows an instance of the registered courses form
        RefreshList() ' refreshes the list box

    End Sub

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New RegistrationForm
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("James Sahler Parsons, CIS259 Final Project") ' about message
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close() ' closes the form
    End Sub
End Class

