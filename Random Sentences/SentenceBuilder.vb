Imports System.Text

Public Class SentenceBuilder
    Dim rand As Random = New Random()
    Dim Adjectives As New List(Of String) From {"other", "new", "good", "high", "old", "great", "small",
                                                "young", "little", "best", "hard", "white", "red"}
    Dim Articles As New List(Of String) From {"the", "a", "an"}
    Dim Nouns As New List(Of String) From {"apple"}
    Dim Prepositions As New List(Of String) From {"in", "from", "with", "of", "to", "for"}
    Dim Verbs As New List(Of String) From {"flew", "walked", "looked", "sat"}
    Dim SentenceStructure As New List(Of List(Of String)) From {Articles, Adjectives, Nouns,
                                                                Verbs, Prepositions,
                                                                Articles, Adjectives, Nouns}

    Function Build() As String
        Dim sb As StringBuilder = New StringBuilder()
        assembleWords(sb)
        capitalizeFirstWord(sb)
        replaceFinalSpaceWithPeriod(sb)
        Return sb.ToString()
    End Function
  
    Private Sub capitalizeFirstWord(sb As StringBuilder)
        sb(0) = sb(0).ToString().ToUpper()
    End Sub

    Private Sub assembleWords(sb As StringBuilder)
        For Each WordCandidate As List(Of String) In SentenceStructure
            sb.Append(getRandomFromList(WordCandidate))
            sb.Append(" ")
        Next
    End Sub

    Private Sub replaceFinalSpaceWithPeriod(sb As StringBuilder)
        sb.Remove(sb.Length - 1, 1)
        sb.Append(".")
    End Sub

    Private Function getRandomFromList(wordlist As List(Of String)) As String
        Return wordlist(rand.Next(wordlist.Count))
    End Function

End Class
