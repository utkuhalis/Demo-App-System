Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MaskedTextBox1.Text = "AHFD4-94DHU-34Y9W-14SH6" Then
            MsgBox("Lisans Başarılı.", MsgBoxStyle.Information)
            Label1.Text = "Program Lisanslı."
            Label1.ForeColor = Color.Lime
            MaskedTextBox1.Visible = False
            Button1.Visible = False
            Label1.Location = New Point(77, 59)
            My.Settings.lisans = 1
            My.Settings.Save()
        Else
            MsgBox("Yalnış Lisans Girildi.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.lisans = 1 Then
            Label1.Text = "Program Lisanslı."
            Label1.ForeColor = Color.Lime
            MaskedTextBox1.Visible = False
            Button1.Visible = False
            Label1.Location = New Point(77, 59)
        Else
            My.Settings.girişhakkı -= 1
            Label1.Text = "Son " & My.Settings.girişhakkı & " Giriş Hakkı Kaldı."
            My.Settings.Save()
            If My.Settings.girişhakkı = 0 Then
                MsgBox("Demo Kullanım Süreniz Doldu!", MsgBoxStyle.Critical)
                End
            End If
        End If
    End Sub
End Class
