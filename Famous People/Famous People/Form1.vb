Public Class Form1
    Dim pathname As String 'define pathname
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pathname = Application.StartupPath 'set pathname to current pathname
    End Sub

    Function PopulateFields(person As String)
        Dim filereaderpath As String
        filereaderpath = pathname
        Dim Turing, Berners, Hopper, Babbage, Shannon As System.IO.StreamReader
        Turing = My.Computer.FileSystem.OpenTextFileReader(filereaderpath & "turing.txt") 'open text files ready
        Berners = My.Computer.FileSystem.OpenTextFileReader(filereaderpath & "berners.txt")
        Hopper = My.Computer.FileSystem.OpenTextFileReader(filereaderpath & "hopper.txt")
        Babbage = My.Computer.FileSystem.OpenTextFileReader(filereaderpath & "babbage.txt")
        Shannon = My.Computer.FileSystem.OpenTextFileReader(filereaderpath & "shannon.txt")

        Select Case person
            Case "Turing"
                pbx_Photo.ImageLocation = pathname & "turing.jfif"
                txt_Born.Text = "23 June 1912"
                txt_Died.Text = "7 June 1954"
                txt_Facts.Text = Turing.ReadToEnd()
            Case "Berners"
                pbx_Photo.ImageLocation = pathname & "berners.jfif"
                txt_Born.Text = "8 June 1955"
                txt_Died.Text = "N/A"
                txt_Facts.Text = Berners.ReadToEnd()
            Case "Hopper"
                pbx_Photo.ImageLocation = pathname & "hopper.jpg"
                txt_Born.Text = "9 December 1906"
                txt_Died.Text = "1 January 1992"
                txt_Facts.Text = Hopper.ReadToEnd()
            Case "Babbage"
                pbx_Photo.ImageLocation = pathname & "babbage.jpg"
                txt_Born.Text = "26 December 1791"
                txt_Died.Text = "18 October 1871"
                txt_Facts.Text = Babbage.ReadToEnd()
            Case "Shannon"
                pbx_Photo.ImageLocation = pathname & "shannon.jpg"
                txt_Born.Text = "30 April 1916"
                txt_Died.Text = "24 February 2001"
                txt_Facts.Text = Shannon.ReadToEnd()
        End Select

    End Function

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

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txt_Born.Clear()
        txt_Died.Clear()
        pbx_Photo.Image = Nothing
        txt_Facts.Clear()
    End Sub
End Class
