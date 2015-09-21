Public Class NewDateForm

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click

        Me.DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub

End Class