Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        Dim Surname As String
        Dim age As Integer
        Dim Tribe As String
        Dim Greet As String
        Dim Gender As String
        Dim GenderDesc As String

        name = txtName.Text
        Surname = txtSurname.Text
        age = txtYear.Text
        Gender = lstGender.SelectedItem

        Tribe = txtTribe.Text.ToLower
        If Tribe = "tshivenda" Then
            Greet = "ndaa"
        ElseIf Tribe = "xhosa" Then
            Greet = "molo"
        ElseIf Tribe = "siswati" Then
            Greet = "sawubona"
        ElseIf Tribe = "sipedi" Then
            Greet = "thobela"
        ElseIf Tribe = "tswana" Then
            Greet = "dumelang"
        ElseIf Tribe = "zulu" Then
            Greet = "sawubona"
        ElseIf Tribe = "afrikaans" Then
            Greet = "hallo"
        ElseIf Tribe = "ndebele" Then
            Greet = "lotjani"
        ElseIf Tribe = "xitsonga" Then
            Greet = "avuxeni"
        ElseIf Tribe = "sisotho" Then
            Greet = "dumela"
        Else Greet = "hi"
        End If


        If Gender = "Male" Then
            GenderDesc = "man"
        ElseIf Gender = "Female" Then
            GenderDesc = "lady"
        Else GenderDesc = " please select your gender"
        End If


        MsgBox(Greet & " " & name & " " & Surname & " you are  " & 2023 - age & " years old " & GenderDesc & " who speaks " & Tribe)
    End Sub
End Class
