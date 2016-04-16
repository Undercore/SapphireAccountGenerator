Imports System.Net

Public Class frmMain
    Private Const SpotifyURL As String = "http://pastebin.com/raw/FnKZKqZr"
    Private Const NetflixURL As String = "http://pastebin.com/raw/NmNJCHWH"
    Private Const MinecraftURL As String = "http://pastebin.com/raw/wxWaC9sh"
    Private Const OrginURL As String = "http://pastebin.com/raw/u2EsXjah"
    Private Const HuluURL As String = "http://pastebin.com/raw/Ve50MPvV"
    Private Const RedditURL As String = "http://pastebin.com/raw/RDLw6Wh0"


    Private wc As WebClient
    Private R As Random

    Sub New()
        wc = New WebClient()
        R = New Random()
        ' Seal.Initialize("A0600000")
        'InitializeComponent()

    End Sub
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Try
            GenerateAccount()
        Catch ex As Exception
            MessageBox.Show("Something went wrong, check if you're connected to the internet.", "Sapphire Account Generator", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub GenerateAccount()
        Select Case comboType.SelectedItem
            Case "Spotify"
                Dim Accounts As String() = wc.DownloadString(SpotifyURL).Split(Environment.NewLine)
                ParseAccount(Accounts(R.Next(1, Accounts.Length)))
            Case "Netflix"
                Dim Accounts As String() = wc.DownloadString(NetflixURL).Split(Environment.NewLine)
                ParseAccount(Accounts(R.Next(1, Accounts.Length)))
            Case "Minecraft"
                Dim Accounts As String() = wc.DownloadString(MinecraftURL).Split(Environment.NewLine)
                ParseAccount(Accounts(R.Next(1, Accounts.Length)))
            Case "Orgin"
                Dim Accounts As String() = wc.DownloadString(OrginURL).Split(Environment.NewLine)
                ParseAccount(Accounts(R.Next(1, Accounts.Length)))
            Case "Hulu"
                Dim Accounts As String() = wc.DownloadString(HuluURL).Split(Environment.NewLine)
                ParseAccount(Accounts(R.Next(1, Accounts.Length)))
            Case "Reddit"
                Dim Accounts As String() = wc.DownloadString(RedditURL).Split(Environment.NewLine)
                ParseAccount(Accounts(R.Next(1, Accounts.Length)))
                'Case ""
                '    Dim Accounts As String() = wc.DownloadString().Split(Environment.NewLine)
                '    ParseAccount(Accounts(R.Next(1, Accounts.Length)))

            Case Else
                MessageBox.Show("You have to select an account type to generate.", "Sapphire Account Generator", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        If (comboType.Text = "Account Type") Then
            MessageBox.Show("You have to select an account type to generate.", "Sapphire Account Generator", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ParseAccount(ByVal Account As String)
        txtUsername.Text = Account.Split(":")(0)
        txtPassword.Text = Account.Split(":")(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (txtUsername.Text = "Username") Then
            MessageBox.Show("Please Generate an account before copying it", "Sapphire Account Generator", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                Clipboard.SetText(txtUsername.Text & ":" & txtPassword.Text, TextDataFormat.Text)
            Catch ex As Exception
                MessageBox.Show("Please generate an account before trying to generate it.", "Sapphire Account Generator", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Account_Check.Click
        Select Case comboType.Text
            Case "Spotify"
                Process.Start("https://accounts.spotify.com/login")
            Case "Netflix"
                Process.Start("https://www.netflix.com/login")
            Case "Minecraft"
                Process.Start("https://www.minecraft.net/login")
            Case "Reddit"
                Process.Start("https://www.reddit.com/login")
            Case "Hulu"
                Process.Start("https://www.hulu.com/account/signin")
            Case "Orgin"
                Process.Start("https://www.Orgin.com/login")
            Case "Account Type"
                MessageBox.Show("Please select an account type to check", "Sapphire Account Generator", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Select
    End Sub

    Private Sub OpenTroubleshooterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenTroubleshooterToolStripMenuItem.Click
        Dim TS As New Troubleshooter()
        TS.Show()
    End Sub

    Private Sub ShowChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowChangelogToolStripMenuItem.Click
        Dim CL As New RTB_Changelog()
        CL.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        MessageBox.Show("Thanks for using the generator!", "Sapphire Account Generator", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Close()

    End Sub
End Class
