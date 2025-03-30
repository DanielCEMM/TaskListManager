Imports System.IO ' Necessary for file manipulation

Public Class Form1
    ' Variables
    Dim state As Char
    Dim TasksDict As New Dictionary(Of String, Char)

    ' Clear textbox
    Private Sub btnClearTask_Click(sender As Object, e As EventArgs) Handles btnClearTask.Click
        txtbTaskIn.Text = ""
    End Sub

    ' Add task to List and Dictionary
    Private Sub btnAddTask_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click
        Dim task As String = txtbTaskIn.Text
        If Not String.IsNullOrEmpty(task) Then
            lstboxToDoList.Items.Add(task)
            If Not TasksDict.ContainsKey(task) Then
                TasksDict.Add(task, "3"c)
            End If
            txtbTaskIn.Text = ""
        End If
    End Sub

    ' Remove task from list
    Private Sub btnRmvTask_Click(sender As Object, e As EventArgs) Handles btnRmvTask.Click
        Dim selectedTask As String = TryCast(lstboxToDoList.SelectedItem, String)
        If selectedTask IsNot Nothing Then
            lstboxToDoList.Items.Remove(selectedTask)
            TasksDict.Remove(selectedTask)
        End If
    End Sub

    ' States: 1 = Done; 2 = Doing; 3 = To Do
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        UpdateState("1"c)
    End Sub

    Private Sub btnDoing_Click(sender As Object, e As EventArgs) Handles btnDoing.Click
        UpdateState("2"c)
    End Sub

    Private Sub btnToDo_Click(sender As Object, e As EventArgs) Handles btnToDo.Click
        UpdateState("3"c)
    End Sub

    ' Helper method to update state in dictionary
    Private Sub UpdateState(newState As Char)
        Dim selectedTask As String = TryCast(lstboxToDoList.SelectedItem, String)
        If selectedTask IsNot Nothing AndAlso TasksDict.ContainsKey(selectedTask) Then
            TasksDict(selectedTask) = newState
            state = newState
            txbTaskState.Text = state & " = " & GetStateDescription(state)
        End If
    End Sub

    ' Update txbTaskState when selection changes
    Private Sub lstboxToDoList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxToDoList.SelectedIndexChanged
        Dim selectedTask As String = TryCast(lstboxToDoList.SelectedItem, String)
        If selectedTask IsNot Nothing AndAlso TasksDict.ContainsKey(selectedTask) Then
            state = TasksDict(selectedTask)
            txbTaskState.Text = state & " = " & GetStateDescription(state)
        Else
            txbTaskState.Text = ""
        End If
    End Sub

    ' Save the list and dictionary to a file
    Private Sub BtnSaveList_Click(sender As Object, e As EventArgs) Handles btnSaveList.Click
        Using saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Text files (*.txt)|*.txt"
            saveDialog.Title = "Save Task List"
            saveDialog.DefaultExt = "txt"
            If saveDialog.ShowDialog() = DialogResult.OK Then
                Try
                    Using writer As New StreamWriter(saveDialog.FileName)
                        For Each kvp In TasksDict
                            writer.WriteLine(kvp.Key & "," & kvp.Value)
                        Next
                    End Using
                    MessageBox.Show("Task list saved successfully!")
                Catch ex As Exception
                    MessageBox.Show("Error saving the task list: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    ' Import the list and dictionary from a file
    Private Sub BtnImportList_Click(sender As Object, e As EventArgs) Handles BtnImportList.Click
        Using openDialog As New OpenFileDialog()
            openDialog.Filter = "Text files (*.txt)|*.txt"
            openDialog.Title = "Load Task List"
            If openDialog.ShowDialog() = DialogResult.OK Then
                Try
                    ' Clear the current list and dictionary
                    lstboxToDoList.Items.Clear()
                    TasksDict.Clear()

                    ' Read the file
                    Dim lines As String() = File.ReadAllLines(openDialog.FileName)
                    For Each line As String In lines
                        Dim parts As String() = line.Split(","c)
                        If parts.Length = 2 Then
                            Dim task As String = parts(0).Trim()
                            Dim state As Char = parts(1).Trim()(0)
                            lstboxToDoList.Items.Add(task)
                            TasksDict.Add(task, state)
                        End If
                    Next
                    MessageBox.Show("Task list loaded successfully!")
                Catch ex As Exception
                    MessageBox.Show("Error loading the task list: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    ' Helper method to describe the state
    Private Function GetStateDescription(state As Char) As String
        Select Case state
            Case "1"c
                Return "Done"
            Case "2"c
                Return "Doing"
            Case "3"c
                Return "To Do"
            Case Else
                Return "Unknown"
        End Select
    End Function
End Class