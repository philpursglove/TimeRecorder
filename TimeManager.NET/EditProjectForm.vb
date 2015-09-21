Public Class EditProjectForm

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click

        Me.DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub

    Private Sub NewProjectNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewProjectNameTextBox.TextChanged

        If NewProjectNameTextBox.TextLength > 0 Then
            Me.OKButton.Enabled = True
        Else
            Me.OKButton.Enabled = False
        End If
    End Sub
End Class