Public Class Form1
    Dim pathname As String 'define pathname

    Function PopulateFields(person As String)
        Dim fileReader As System.IO.StreamReader, filereaderpath As String
        filereaderpath = pathname
        Dim Turing, Berners, Hopper, Babbage, Shannon
        Using reader As System.IO.StreamReader
            'in progress
        End Using
        If person = "Turing" Then
            Turing =
            txt_Facts.Text = ""
            pbx_Photo.ImageLocation = pathname & "turing.jfif"
            txt_Born.Text = "23 June 1912"
            txt_Died.Text = "7 June 1954"
        ElseIf person = "Berners" Then
            Berners = My.Computer.FileSystem.ReadAllText(filereaderpath & "berners.txt")
            pbx_Photo.ImageLocation = pathname & "berners.jfif"
            txt_Born.Text = "8 June 1955"
            txt_Died.Text = "N/A"
            txt_Facts.Text = ""
        ElseIf person = "Hopper" Then
            Hopper = My.Computer.FileSystem.ReadAllText(filereaderpath & "hopper.txt")
            pbx_Photo.ImageLocation = pathname & "hopper.jpg"
            txt_Born.Text = "9 December 1906"
            txt_Died.Text = "1 January 1992"
            txt_Facts.Text = ""
        ElseIf person = "Babbage" Then
            Babbage = My.Computer.FileSystem.ReadAllText(filereaderpath & "babbage.txt")
            pbx_Photo.ImageLocation = pathname & "babbage.jpg"
            txt_Born.Text = "26 December 1791"
            txt_Died.Text = "18 October 1871"
            txt_Facts.Text = ""
        ElseIf person = "Shannon" Then
            Shannon = My.Computer.FileSystem.ReadAllText(filereaderpath & "shannon.txt")
            pbx_Photo.ImageLocation = pathname & "shannon.jpg"
            txt_Born.Text = "30 April 1916"
            txt_Died.Text = "24 February 2001"
            txt_Facts.Text = ""
        End If

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(pathname)
        pathname = Application.StartupPath 'set pathname to current pathname
    End Sub

    Private Sub btn_Turing_Click(sender As Object, e As EventArgs) Handles btn_Turing.Click
        PopulateFields("Turing")
    End Sub

    Private Sub btn_Berners_Click(sender As Object, e As EventArgs) Handles btn_Berners.Click
        PopulateFields("Berners")
    End Sub

    Private Sub btn_Hopper_Click(sender As Object, e As EventArgs) Handles btn_Hopper.Click
        PopulateFields("Hopper")
    End Sub

    Private Sub btn_Babbage_Click(sender As Object, e As EventArgs) Handles btn_Babbage.Click
        PopulateFields("Babbage")
    End Sub

    Private Sub btn_Shannon_Click(sender As Object, e As EventArgs) Handles btn_Shannon.Click
        PopulateFields("Shannon")
    End Sub
End Class
