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
        Me.gbxTask = New System.Windows.Forms.GroupBox()
        Me.btnClearTask = New System.Windows.Forms.Button()
        Me.btnAddTask = New System.Windows.Forms.Button()
        Me.txtbTaskIn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRmvTask = New System.Windows.Forms.Button()
        Me.lstboxToDoList = New System.Windows.Forms.ListBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnDoing = New System.Windows.Forms.Button()
        Me.btnToDo = New System.Windows.Forms.Button()
        Me.gbxState = New System.Windows.Forms.GroupBox()
        Me.txbTaskState = New System.Windows.Forms.TextBox()
        Me.btnSaveList = New System.Windows.Forms.Button()
        Me.BtnImportList = New System.Windows.Forms.Button()
        Me.gbxTask.SuspendLayout()
        Me.gbxState.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxTask
        '
        Me.gbxTask.Controls.Add(Me.btnClearTask)
        Me.gbxTask.Controls.Add(Me.btnAddTask)
        Me.gbxTask.Controls.Add(Me.txtbTaskIn)
        Me.gbxTask.Controls.Add(Me.Label1)
        Me.gbxTask.Location = New System.Drawing.Point(12, 12)
        Me.gbxTask.Name = "gbxTask"
        Me.gbxTask.Size = New System.Drawing.Size(301, 75)
        Me.gbxTask.TabIndex = 0
        Me.gbxTask.TabStop = False
        Me.gbxTask.Text = "gbxTask"
        '
        'btnClearTask
        '
        Me.btnClearTask.Location = New System.Drawing.Point(9, 42)
        Me.btnClearTask.Name = "btnClearTask"
        Me.btnClearTask.Size = New System.Drawing.Size(75, 23)
        Me.btnClearTask.TabIndex = 4
        Me.btnClearTask.Text = "Clear"
        Me.btnClearTask.UseVisualStyleBackColor = True
        '
        'btnAddTask
        '
        Me.btnAddTask.Location = New System.Drawing.Point(213, 42)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTask.TabIndex = 2
        Me.btnAddTask.Text = "Add Task"
        Me.btnAddTask.UseVisualStyleBackColor = True
        '
        'txtbTaskIn
        '
        Me.txtbTaskIn.Location = New System.Drawing.Point(46, 13)
        Me.txtbTaskIn.Name = "txtbTaskIn"
        Me.txtbTaskIn.Size = New System.Drawing.Size(242, 20)
        Me.txtbTaskIn.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Task:"
        '
        'btnRmvTask
        '
        Me.btnRmvTask.Location = New System.Drawing.Point(420, 192)
        Me.btnRmvTask.Name = "btnRmvTask"
        Me.btnRmvTask.Size = New System.Drawing.Size(75, 23)
        Me.btnRmvTask.TabIndex = 3
        Me.btnRmvTask.Text = "Remove Task"
        Me.btnRmvTask.UseVisualStyleBackColor = True
        '
        'lstboxToDoList
        '
        Me.lstboxToDoList.FormattingEnabled = True
        Me.lstboxToDoList.Location = New System.Drawing.Point(319, 15)
        Me.lstboxToDoList.Name = "lstboxToDoList"
        Me.lstboxToDoList.Size = New System.Drawing.Size(318, 173)
        Me.lstboxToDoList.TabIndex = 1
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Green
        Me.btnDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(9, 19)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 4
        Me.btnDone.Text = "Done (1)"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'btnDoing
        '
        Me.btnDoing.BackColor = System.Drawing.Color.Yellow
        Me.btnDoing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoing.Location = New System.Drawing.Point(9, 48)
        Me.btnDoing.Name = "btnDoing"
        Me.btnDoing.Size = New System.Drawing.Size(75, 23)
        Me.btnDoing.TabIndex = 5
        Me.btnDoing.Text = "Doing (2)"
        Me.btnDoing.UseVisualStyleBackColor = False
        '
        'btnToDo
        '
        Me.btnToDo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnToDo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToDo.Location = New System.Drawing.Point(9, 77)
        Me.btnToDo.Name = "btnToDo"
        Me.btnToDo.Size = New System.Drawing.Size(75, 23)
        Me.btnToDo.TabIndex = 6
        Me.btnToDo.Text = "To Do (3)"
        Me.btnToDo.UseVisualStyleBackColor = False
        '
        'gbxState
        '
        Me.gbxState.Controls.Add(Me.btnDone)
        Me.gbxState.Controls.Add(Me.btnToDo)
        Me.gbxState.Controls.Add(Me.btnDoing)
        Me.gbxState.Location = New System.Drawing.Point(218, 93)
        Me.gbxState.Name = "gbxState"
        Me.gbxState.Size = New System.Drawing.Size(95, 121)
        Me.gbxState.TabIndex = 7
        Me.gbxState.TabStop = False
        Me.gbxState.Text = "gbxState"
        '
        'txbTaskState
        '
        Me.txbTaskState.Location = New System.Drawing.Point(319, 194)
        Me.txbTaskState.Name = "txbTaskState"
        Me.txbTaskState.ReadOnly = True
        Me.txbTaskState.Size = New System.Drawing.Size(95, 20)
        Me.txbTaskState.TabIndex = 5
        '
        'btnSaveList
        '
        Me.btnSaveList.Location = New System.Drawing.Point(45, 141)
        Me.btnSaveList.Name = "btnSaveList"
        Me.btnSaveList.Size = New System.Drawing.Size(120, 23)
        Me.btnSaveList.TabIndex = 9
        Me.btnSaveList.Text = "Save To Do List"
        Me.btnSaveList.UseVisualStyleBackColor = True
        '
        'BtnImportList
        '
        Me.BtnImportList.Location = New System.Drawing.Point(45, 170)
        Me.BtnImportList.Name = "BtnImportList"
        Me.BtnImportList.Size = New System.Drawing.Size(120, 23)
        Me.BtnImportList.TabIndex = 10
        Me.BtnImportList.Text = "Import To Do List"
        Me.BtnImportList.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 232)
        Me.Controls.Add(Me.BtnImportList)
        Me.Controls.Add(Me.btnSaveList)
        Me.Controls.Add(Me.txbTaskState)
        Me.Controls.Add(Me.gbxState)
        Me.Controls.Add(Me.lstboxToDoList)
        Me.Controls.Add(Me.btnRmvTask)
        Me.Controls.Add(Me.gbxTask)
        Me.Name = "Form1"
        Me.Text = "Task List Manager"
        Me.gbxTask.ResumeLayout(False)
        Me.gbxTask.PerformLayout()
        Me.gbxState.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxTask As GroupBox
    Friend WithEvents btnAddTask As Button
    Friend WithEvents txtbTaskIn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstboxToDoList As ListBox
    Friend WithEvents btnClearTask As Button
    Friend WithEvents btnRmvTask As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents btnDoing As Button
    Friend WithEvents btnToDo As Button
    Friend WithEvents gbxState As GroupBox
    Friend WithEvents txbTaskState As TextBox
    Friend WithEvents btnSaveList As Button
    Friend WithEvents BtnImportList As Button
End Class
