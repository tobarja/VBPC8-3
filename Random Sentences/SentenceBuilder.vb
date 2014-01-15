Imports System.Text
  
Public Class SentenceBuilder
    Dim rand As Random
    Dim Articles As New List(Of String) From {"the", "a", "an"}
    Dim Nouns As New List(Of String) From {"apple"}

    Public Sub New()
        rand = New Random()
    End Sub

    Function Build() As String
        Dim sb As StringBuilder = New StringBuilder()

        sb.Append(getRandomFromList(Articles))
        Return sb.ToString()
    End Function

    Private Function getRandomFromList(wordlist As List(Of String)) As String
        Return wordlist(rand.Next(wordlist.Count))
    End Function

End Class
