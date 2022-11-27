<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dgvcontroller
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.Label_MPC = New System.Windows.Forms.Label()
        Me.Label_Action = New System.Windows.Forms.Label()
        Me.DgvTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Check1 = New System.Windows.Forms.CheckBox()
        Me.ID1 = New System.Windows.Forms.TextBox()
        Me.Name1 = New System.Windows.Forms.TextBox()
        Me.Action1 = New System.Windows.Forms.ComboBox()
        Me.MPC1 = New System.Windows.Forms.DateTimePicker()
        Me.CheckOnlyOneRow = New System.Windows.Forms.CheckBox()
        Me.DgvTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(-11, -12)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label_ID
        '
        Me.Label_ID.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label_ID.AutoSize = True
        Me.Label_ID.BackColor = System.Drawing.SystemColors.Control
        Me.Label_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ID.Location = New System.Drawing.Point(191, 22)
        Me.Label_ID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(20, 13)
        Me.Label_ID.TabIndex = 2
        Me.Label_ID.Text = "ID"
        '
        'Label_Name
        '
        Me.Label_Name.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label_Name.AutoSize = True
        Me.Label_Name.BackColor = System.Drawing.SystemColors.Control
        Me.Label_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Name.Location = New System.Drawing.Point(289, 22)
        Me.Label_Name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(39, 13)
        Me.Label_Name.TabIndex = 3
        Me.Label_Name.Text = "Name"
        '
        'Label_MPC
        '
        Me.Label_MPC.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label_MPC.AutoSize = True
        Me.Label_MPC.BackColor = System.Drawing.SystemColors.Control
        Me.Label_MPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_MPC.Location = New System.Drawing.Point(444, 22)
        Me.Label_MPC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_MPC.Name = "Label_MPC"
        Me.Label_MPC.Size = New System.Drawing.Size(33, 13)
        Me.Label_MPC.TabIndex = 5
        Me.Label_MPC.Text = "MPC"
        '
        'Label_Action
        '
        Me.Label_Action.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label_Action.AutoSize = True
        Me.Label_Action.BackColor = System.Drawing.SystemColors.Control
        Me.Label_Action.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Action.Location = New System.Drawing.Point(601, 22)
        Me.Label_Action.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Action.Name = "Label_Action"
        Me.Label_Action.Size = New System.Drawing.Size(43, 13)
        Me.Label_Action.TabIndex = 7
        Me.Label_Action.Text = "Action"
        '
        'DgvTableLayoutPanel
        '
        Me.DgvTableLayoutPanel.AutoScroll = True
        Me.DgvTableLayoutPanel.AutoSize = True
        Me.DgvTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.DgvTableLayoutPanel.ColumnCount = 5
        Me.DgvTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DgvTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DgvTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DgvTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DgvTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.DgvTableLayoutPanel.Controls.Add(Me.Label_Action, 4, 0)
        Me.DgvTableLayoutPanel.Controls.Add(Me.Label_ID, 1, 0)
        Me.DgvTableLayoutPanel.Controls.Add(Me.Label_Name, 2, 0)
        Me.DgvTableLayoutPanel.Controls.Add(Me.Label_MPC, 3, 0)
        Me.DgvTableLayoutPanel.Controls.Add(Me.Check1, 0, 1)
        Me.DgvTableLayoutPanel.Controls.Add(Me.ID1, 1, 1)
        Me.DgvTableLayoutPanel.Controls.Add(Me.Name1, 2, 1)
        Me.DgvTableLayoutPanel.Controls.Add(Me.Action1, 4, 1)
        Me.DgvTableLayoutPanel.Controls.Add(Me.MPC1, 3, 1)
        Me.DgvTableLayoutPanel.Controls.Add(Me.CheckOnlyOneRow, 0, 0)
        Me.DgvTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvTableLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.DgvTableLayoutPanel.Name = "DgvTableLayoutPanel"
        Me.DgvTableLayoutPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.DgvTableLayoutPanel.RowCount = 2
        Me.DgvTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.DgvTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.DgvTableLayoutPanel.Size = New System.Drawing.Size(691, 72)
        Me.DgvTableLayoutPanel.TabIndex = 8
        '
        'Check1
        '
        Me.Check1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Check1.AutoSize = True
        Me.Check1.Location = New System.Drawing.Point(68, 50)
        Me.Check1.Name = "Check1"
        Me.Check1.Size = New System.Drawing.Size(15, 14)
        Me.Check1.TabIndex = 8
        Me.Check1.UseVisualStyleBackColor = True
        '
        'ID1
        '
        Me.ID1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ID1.Location = New System.Drawing.Point(151, 44)
        Me.ID1.Name = "ID1"
        Me.ID1.ReadOnly = True
        Me.ID1.Size = New System.Drawing.Size(100, 20)
        Me.ID1.TabIndex = 9
        Me.ID1.Text = "ID1"
        Me.ID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Name1
        '
        Me.Name1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Name1.Location = New System.Drawing.Point(259, 44)
        Me.Name1.Name = "Name1"
        Me.Name1.ReadOnly = True
        Me.Name1.Size = New System.Drawing.Size(100, 20)
        Me.Name1.TabIndex = 10
        Me.Name1.Text = "Name1"
        Me.Name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Action1
        '
        Me.Action1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Action1.DisplayMember = "1"
        Me.Action1.FormattingEnabled = True
        Me.Action1.Items.AddRange(New Object() {"Today", "Today+7d"})
        Me.Action1.Location = New System.Drawing.Point(562, 43)
        Me.Action1.Name = "Action1"
        Me.Action1.Size = New System.Drawing.Size(121, 21)
        Me.Action1.TabIndex = 11
        Me.Action1.Text = "None"
        '
        'MPC1
        '
        Me.MPC1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.MPC1.Location = New System.Drawing.Point(367, 44)
        Me.MPC1.Name = "MPC1"
        Me.MPC1.Size = New System.Drawing.Size(187, 20)
        Me.MPC1.TabIndex = 12
        '
        'CheckOnlyOneRow
        '
        Me.CheckOnlyOneRow.AutoSize = True
        Me.CheckOnlyOneRow.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CheckOnlyOneRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckOnlyOneRow.Location = New System.Drawing.Point(8, 15)
        Me.CheckOnlyOneRow.Name = "CheckOnlyOneRow"
        Me.CheckOnlyOneRow.Size = New System.Drawing.Size(135, 17)
        Me.CheckOnlyOneRow.TabIndex = 13
        Me.CheckOnlyOneRow.Text = "CheckOnlyOneRow"
        Me.CheckOnlyOneRow.UseVisualStyleBackColor = True
        '
        'dgvcontroller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.DgvTableLayoutPanel)
        Me.Controls.Add(Me.CheckBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "dgvcontroller"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(697, 78)
        Me.DgvTableLayoutPanel.ResumeLayout(False)
        Me.DgvTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label_ID As Label
    Friend WithEvents Label_Name As Label
    Friend WithEvents Label_MPC As Label
    Friend WithEvents Label_Action As Label
    Friend WithEvents DgvTableLayoutPanel As TableLayoutPanel
    Friend WithEvents CheckOnlyOneRow As CheckBox
    Friend WithEvents Check1 As CheckBox
    Friend WithEvents ID1 As TextBox
    Friend WithEvents Name1 As TextBox
    Friend WithEvents Action1 As ComboBox
    Friend WithEvents MPC1 As DateTimePicker
End Class
