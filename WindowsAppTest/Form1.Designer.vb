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
        Me.AddRowdt = New System.Windows.Forms.Button()
        Me.AddRowcombo = New System.Windows.Forms.Button()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveByID = New System.Windows.Forms.Button()
        Me.LoadByID = New System.Windows.Forms.Button()
        Me.SaveByRowIndex = New System.Windows.Forms.Button()
        Me.LoadByRowIndex = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSaveLoadIndex = New System.Windows.Forms.TextBox()
        Me.txtSaveLoadID = New System.Windows.Forms.TextBox()
        Me.txtLoadData = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DgvControl1 = New MPCController.DgvControl()
        Me.SuspendLayout()
        '
        'AddRowdt
        '
        Me.AddRowdt.Location = New System.Drawing.Point(141, 360)
        Me.AddRowdt.Name = "AddRowdt"
        Me.AddRowdt.Size = New System.Drawing.Size(190, 23)
        Me.AddRowdt.TabIndex = 1
        Me.AddRowdt.Text = "Add DateTimePicker Row"
        Me.AddRowdt.UseVisualStyleBackColor = True
        '
        'AddRowcombo
        '
        Me.AddRowcombo.Location = New System.Drawing.Point(141, 403)
        Me.AddRowcombo.Name = "AddRowcombo"
        Me.AddRowcombo.Size = New System.Drawing.Size(190, 23)
        Me.AddRowcombo.TabIndex = 2
        Me.AddRowcombo.Text = "Add ComboBox Row"
        Me.AddRowcombo.UseVisualStyleBackColor = True
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(185, 287)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(100, 22)
        Me.txt_ID.TabIndex = 3
        '
        'txt_Name
        '
        Me.txt_Name.Location = New System.Drawing.Point(185, 324)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(100, 22)
        Me.txt_Name.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'SaveByID
        '
        Me.SaveByID.Location = New System.Drawing.Point(422, 288)
        Me.SaveByID.Name = "SaveByID"
        Me.SaveByID.Size = New System.Drawing.Size(107, 23)
        Me.SaveByID.TabIndex = 8
        Me.SaveByID.Text = "SaveByID"
        Me.SaveByID.UseVisualStyleBackColor = True
        '
        'LoadByID
        '
        Me.LoadByID.Location = New System.Drawing.Point(422, 374)
        Me.LoadByID.Name = "LoadByID"
        Me.LoadByID.Size = New System.Drawing.Size(107, 23)
        Me.LoadByID.TabIndex = 9
        Me.LoadByID.Text = "LoadByID"
        Me.LoadByID.UseVisualStyleBackColor = True
        '
        'SaveByRowIndex
        '
        Me.SaveByRowIndex.Location = New System.Drawing.Point(422, 331)
        Me.SaveByRowIndex.Name = "SaveByRowIndex"
        Me.SaveByRowIndex.Size = New System.Drawing.Size(107, 23)
        Me.SaveByRowIndex.TabIndex = 10
        Me.SaveByRowIndex.Text = "SaveByRowIndex"
        Me.SaveByRowIndex.UseVisualStyleBackColor = True
        '
        'LoadByRowIndex
        '
        Me.LoadByRowIndex.Location = New System.Drawing.Point(422, 417)
        Me.LoadByRowIndex.Name = "LoadByRowIndex"
        Me.LoadByRowIndex.Size = New System.Drawing.Size(107, 23)
        Me.LoadByRowIndex.TabIndex = 11
        Me.LoadByRowIndex.Text = "LoadByIndex"
        Me.LoadByRowIndex.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(588, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "RowIndex"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(635, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "ID"
        '
        'txtSaveLoadIndex
        '
        Me.txtSaveLoadIndex.Location = New System.Drawing.Point(662, 329)
        Me.txtSaveLoadIndex.Name = "txtSaveLoadIndex"
        Me.txtSaveLoadIndex.Size = New System.Drawing.Size(232, 22)
        Me.txtSaveLoadIndex.TabIndex = 13
        '
        'txtSaveLoadID
        '
        Me.txtSaveLoadID.Location = New System.Drawing.Point(662, 292)
        Me.txtSaveLoadID.Name = "txtSaveLoadID"
        Me.txtSaveLoadID.Size = New System.Drawing.Size(232, 22)
        Me.txtSaveLoadID.TabIndex = 12
        '
        'txtLoadData
        '
        Me.txtLoadData.Location = New System.Drawing.Point(662, 392)
        Me.txtLoadData.Name = "txtLoadData"
        Me.txtLoadData.Size = New System.Drawing.Size(342, 22)
        Me.txtLoadData.TabIndex = 16
        Me.txtLoadData.Text = "True:newID:newName:DateTimePicker"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(588, 395)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "LoadData"
        '
        'DgvControl1
        '
        Me.DgvControl1.AutoSize = True
        Me.DgvControl1.Location = New System.Drawing.Point(86, 92)
        Me.DgvControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvControl1.Name = "DgvControl1"
        Me.DgvControl1.Size = New System.Drawing.Size(876, 72)
        Me.DgvControl1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLoadData)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSaveLoadIndex)
        Me.Controls.Add(Me.txtSaveLoadID)
        Me.Controls.Add(Me.LoadByRowIndex)
        Me.Controls.Add(Me.SaveByRowIndex)
        Me.Controls.Add(Me.LoadByID)
        Me.Controls.Add(Me.SaveByID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.AddRowcombo)
        Me.Controls.Add(Me.AddRowdt)
        Me.Controls.Add(Me.DgvControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvControl1 As MPCController.DgvControl
    Friend WithEvents AddRowdt As Button
    Friend WithEvents AddRowcombo As Button
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveByID As Button
    Friend WithEvents LoadByID As Button
    Friend WithEvents SaveByRowIndex As Button
    Friend WithEvents LoadByRowIndex As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSaveLoadIndex As TextBox
    Friend WithEvents txtSaveLoadID As TextBox
    Friend WithEvents txtLoadData As TextBox
    Friend WithEvents Label5 As Label
End Class
