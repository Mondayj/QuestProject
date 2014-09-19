Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim strSecretName As String = "Jeremy"
        Dim strNameGuess As String = Me.txtName.Text
        Dim strQuest As String = "Seek the Grail"
        Dim strQuestGuess As String = Me.txtQuest.Text
        Dim strSecretColor As String = "Black"
        Dim strColorGuess As String = Me.txtColor.Text

        If strSecretName = strNameGuess Then
            Me.lblQ1Answer.Text = "You may pass"
        Else
            Me.lblQ1Answer.Text = "You die!"

        End If

        If strQuest = strQuestGuess Then
            Me.lblQ2Answer.Text = "You may pass"
        Else
            Me.lblQ2Answer.Text = "You die!"
        End If

        If strSecretColor = strColorGuess Then
            Me.lblQ3Answer.Text = "You may pass"
        Else
            Me.lblQ3Answer.Text = "You die!"

        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblQ1Answer.Click

    End Sub
End Class
