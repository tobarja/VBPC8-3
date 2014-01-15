Public Class Form1
    Dim builder As SentenceBuilder

    Private Sub btnMakeSentence_Click(sender As Object, e As EventArgs) Handles btnMakeSentence.Click
        Sentences.Items.Add(builder.Build())
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        builder = New SentenceBuilder()
    End Sub
End Class
