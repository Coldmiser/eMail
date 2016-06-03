Imports System.Net.Mail

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Mail As New MailMessage
        Mail.Subject = "test email"
        Mail.To.Add("user@gmail.com")
        Mail.From = New MailAddress("user@hotmail.com")
        Mail.Body = "This is a test email using VB.NET " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

        'MessageBox.Show(Mail.Body)

        'using Hotmail server
        Dim SMTP As New SmtpClient("smtp.live.com")
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential("user@hotmail.com", "password")
        SMTP.Port = "587"
        'SMTP.DeliveryMethod = SmtpDeliveryMethod.Network
        Try
            SMTP.Send(Mail)
            MessageBox.Show("Sent", "Status", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Failed", "Status", MessageBoxButtons.OK)
        End Try
        Application.Exit()
        End
    End Sub

End Class
