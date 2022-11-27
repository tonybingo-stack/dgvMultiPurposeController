Public Class dgvcontroller
    Private rowIndex As Integer
    Private Checkbox_field(100) As Object
    Private ID_field(100) As Object
    Private Name_field(100) As Object
    Private Action_field(100) As Object
    Private MPC_field(100) As Object

    Private Sub Dgvcontroller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rowIndex = 1
    End Sub

    Private Sub CheckOnlyOneRow_CheckedChanged(sender As Object, e As EventArgs) Handles CheckOnlyOneRow.CheckedChanged
        RowControlAdd("ok", "ok", "ComboBox", "")
    End Sub

    Public Function RowControlAdd(ID As String, Name As String, mpcControlType As String, mpcControlSettings As String)

        rowIndex = rowIndex + 1
        DgvTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))

        '
        'Check{rowIndex}
        '
        Checkbox_field(rowIndex) = New System.Windows.Forms.CheckBox()

        Checkbox_field(rowIndex).Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Checkbox_field(rowIndex).AutoSize = True
        Checkbox_field(rowIndex).Location = New System.Drawing.Point(68, 60)
        Checkbox_field(rowIndex).Name = "Check" & CStr(rowIndex)
        Checkbox_field(rowIndex).Size = New System.Drawing.Size(15, 14)
        Checkbox_field(rowIndex).TabIndex = 8
        Checkbox_field(rowIndex).UseVisualStyleBackColor = True

        DgvTableLayoutPanel.Controls.Add(Checkbox_field(rowIndex), 0, rowIndex)

        '
        'ID{rowIndex}
        '
        ID_field(rowIndex) = New System.Windows.Forms.TextBox()

        ID_field(rowIndex).Anchor = System.Windows.Forms.AnchorStyles.Bottom
        ID_field(rowIndex).Location = New System.Drawing.Point(151, 54)
        ID_field(rowIndex).Name = "ID" & CStr(rowIndex)
        ID_field(rowIndex).ReadOnly = True
        ID_field(rowIndex).Size = New System.Drawing.Size(100, 20)
        ID_field(rowIndex).TabIndex = 9
        ID_field(rowIndex).Text = ID
        ID_field(rowIndex).TextAlign = System.Windows.Forms.HorizontalAlignment.Center

        DgvTableLayoutPanel.Controls.Add(ID_field(rowIndex), 1, rowIndex)

        '
        'Name{rowIndex}
        '
        Name_field(rowIndex) = New System.Windows.Forms.TextBox()

        Name_field(rowIndex).Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Name_field(rowIndex).Location = New System.Drawing.Point(259, 54)
        Name_field(rowIndex).Name = "Name" & CStr(rowIndex)
        Name_field(rowIndex).ReadOnly = True
        Name_field(rowIndex).Size = New System.Drawing.Size(100, 20)
        Name_field(rowIndex).TabIndex = 10
        Name_field(rowIndex).Text = Name
        Name_field(rowIndex).TextAlign = System.Windows.Forms.HorizontalAlignment.Center

        DgvTableLayoutPanel.Controls.Add(Name_field(rowIndex), 2, rowIndex)
        '
        'MPC{rowIndex}
        '

        If String.Compare(mpcControlType, "DateTimePicker") = 0 Then
            MPC_field(rowIndex) = New System.Windows.Forms.DateTimePicker()
        ElseIf String.Compare(mpcControlType, "ComboBox") = 0 Then
            MPC_field(rowIndex) = New System.Windows.Forms.ComboBox()
        End If

        MPC_field(rowIndex).Anchor = System.Windows.Forms.AnchorStyles.Bottom
        MPC_field(rowIndex).Location = New System.Drawing.Point(367, 54)
        MPC_field(rowIndex).Name = "MPC" & CStr(rowIndex)
        MPC_field(rowIndex).Size = New System.Drawing.Size(187, 20)
        MPC_field(rowIndex).TabIndex = 12

        DgvTableLayoutPanel.Controls.Add(MPC_field(rowIndex), 3, rowIndex)

        '
        'Action{rowIndex}
        '
        Action_field(rowIndex) = New System.Windows.Forms.ComboBox()

        If String.Compare(mpcControlType, "DateTimePicker") = 0 Then
            Action_field(rowIndex).Items.AddRange(New Object() {"Today", "Today+7d"})
        ElseIf String.Compare(mpcControlType, "ComboBox") = 0 Then
            Action_field(rowIndex).Items.AddRange(New Object() {"Yes", "No"})
        End If
        Action_field(rowIndex).Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Action_field(rowIndex).FormattingEnabled = True
        Action_field(rowIndex).DisplayMember = "1"
        Action_field(rowIndex).Location = New System.Drawing.Point(562, 53)
        Action_field(rowIndex).Name = "Action" & CStr(rowIndex)
        Action_field(rowIndex).Size = New System.Drawing.Size(121, 21)
        Action_field(rowIndex).TabIndex = 11
        Action_field(rowIndex).Text = "None"
        'Associate the event-handling method with the 
        'SelectedIndexChanged event.
        'Action_field(rowIndex).SelectedIndexChanged += New System.EventHandler(Sub(sender As Object, e As EventArgs)
        ' MsgBox("Lambda caught event.")
        'End Sub

        DgvTableLayoutPanel.Controls.Add(Action_field(rowIndex), 4, rowIndex)
        Return rowIndex

    End Function


    Public Sub Action1_SelectedIndexChanged(sender As Object, e As EventArgs)
        'MessageBox.Show(e.ok)

    End Sub

    Private Sub DgvTableLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles DgvTableLayoutPanel.Paint

    End Sub
End Class
