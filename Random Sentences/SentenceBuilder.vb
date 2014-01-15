Imports System.Text
  
Public Class SentenceBuilder
    Dim rand As Random
    Dim Adjectives As New List(Of String) From {"other", "new", "good", "high", "old", "great", "small",
                                                "young", "little", "best", "hard", "white", "red"}
    Dim Articles As New List(Of String) From {"the", "a", "an"}
    Dim Nouns As New List(Of String) From {"apple"}
    Dim Prepositions As New List(Of String) From {"in", "from", "with", "of", "to", "for"}
    Dim Verbs As New List(Of String) From {"flew", "walked", "looked", "sat"}

    Public Sub New()
        rand = New Random()
    End Sub

    Function Build() As String
        Dim sb As StringBuilder = New StringBuilder()

        sb.Append(getRandomFromList(Articles))
        sb.Append(" ")
        sb.Append(getRandomFromList(Adjectives))
        sb.Append(" ")
        sb.Append(getRandomFromList(Nouns))
        sb.Append(" ")
        sb.Append(getRandomFromList(Verbs))
        sb.Append(" ")
        sb.Append(getRandomFromList(Prepositions))
        sb.Append(" ")
        sb.Append(getRandomFromList(Articles))
        sb.Append(" ")
        sb.Append(getRandomFromList(Adjectives))
        sb.Append(" ")
        sb.Append(getRandomFromList(Nouns))
        sb.Append(".")
        Return sb.ToString()
    End Function

    Private Function getRandomFromList(wordlist As List(Of String)) As String
        Return wordlist(rand.Next(wordlist.Count))
    End Function

End Class
