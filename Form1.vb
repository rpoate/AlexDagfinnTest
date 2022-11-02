Imports Zoople.SpellCheckWordEventArgs

Public Class Form1

    Dim sEmailBody As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SetBodyControlStatus(ByVal controlisenabled As Boolean, ByVal value As String)

        HtmlEditZoople1.Visible = True
        HtmlEditZoople1.Enabled = controlisenabled

        If Not value Is Nothing Then
            HtmlEditZoople1.Text = value
        End If

    End Sub

    Private Sub frmPrint_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        sEmailBody = HtmlEditZoople1.DocumentHTML
        If Not HtmlEditZoople1 Is Nothing Then HtmlEditZoople1.Dispose()
    End Sub

    Private Sub htmlEditZoople_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles HtmlEditZoople1.TextChanged

        If 1 = 0 Then ' please refer to formclosing event
            sEmailBody = HtmlEditZoople1.Text
        End If

    End Sub


End Class
