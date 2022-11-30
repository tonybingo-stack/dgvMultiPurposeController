Public Class Form1
    Private Sub Dgvcontroller1_Load(sender As Object, e As EventArgs)
        'Dgvcontroller1.RowControlAdd("ok", "ok", "ComboBox", "")
    End Sub

    Private Sub AddRowdt_Click(sender As Object, e As EventArgs) Handles AddRowdt.Click
        DgvControl1.RowControlAdd(txt_ID.Text, txt_Name.Text, "DateTimePicker", "")
    End Sub

    Private Sub AddRowcombo_Click(sender As Object, e As EventArgs) Handles AddRowcombo.Click
        DgvControl1.RowControlAdd(txt_ID.Text, txt_Name.Text, "ComboBox", "")
    End Sub

    Private Sub SaveByID_Click(sender As Object, e As EventArgs) Handles SaveByID.Click
        MessageBox.Show(DgvControl1.SaveDataByID(txtSaveLoadID.Text))
    End Sub

    Private Sub SaveByRowIndex_Click(sender As Object, e As EventArgs) Handles SaveByRowIndex.Click
        MessageBox.Show(DgvControl1.SaveDataByIndex(txtSaveLoadIndex.Text))
    End Sub

    Private Sub LoadByID_Click(sender As Object, e As EventArgs) Handles LoadByID.Click
        DgvControl1.LoadDataByID(txtSaveLoadID.Text, txtLoadData.Text)
    End Sub

    Private Sub LoadByRowIndex_Click(sender As Object, e As EventArgs) Handles LoadByRowIndex.Click
        DgvControl1.LoadDataByIndex(CInt(txtSaveLoadIndex.Text), txtLoadData.Text)
    End Sub

    Private Sub BoderColorBtn_Click(sender As Object, e As EventArgs) Handles BoderColorBtn.Click
        'ColorDlg.ShowDialog()
        If ColorDlg.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            DgvControl1.SetBorderColor(ColorDlg.Color)
        End If
    End Sub
End Class
