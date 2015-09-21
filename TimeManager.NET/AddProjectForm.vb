Public Class AddProjectForm

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub AddProjectForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ProjectCodeTextBox.Text = String.Empty
        Me.ProjectNameTextBox.Text = String.Empty

    End Sub

    Private Sub ValidateProjectData(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ProjectCodeTextBox.Validating, ProjectNameTextBox.Validating

        If ProjectCodeTextBox.TextLength > 0 AndAlso ProjectNameTextBox.TextLength > 0 Then
            Me.OKButton.Enabled = True
        Else
            Me.OKButton.Enabled = False
        End If

    End Sub

End Class