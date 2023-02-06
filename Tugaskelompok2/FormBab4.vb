Public Class FormBab4
    Public Sub Reset()
        Next1.Visible = False
        Next2.Visible = False
        Next3.Visible = False
        Next4.Visible = False
        Next5.Visible = False
        Next6.Visible = False
        Next7.Visible = False
        Next8.Visible = False
        Next9.Visible = False

        Back1.Visible = False
        Back2.Visible = False
        Back3.Visible = False
        Back4.Visible = False
        Back5.Visible = False
        Back6.Visible = False
        Back7.Visible = False
        Back8.Visible = False
        Back9.Visible = False
        btn_Keluar.Visible = False

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False

        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Reset()
        btn_Keluar.Visible = True
        Label1.Visible = True
        PictureBox1.Visible = True
        Next1.Visible = True
    End Sub
    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub Next1_Click(sender As Object, e As EventArgs) Handles Next1.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label2.Visible = True
        PictureBox2.Visible = True
        Next2.Visible = True
        Back1.Visible = True
    End Sub
    Private Sub Next2_Click(sender As Object, e As EventArgs) Handles Next2.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label3.Visible = True
        PictureBox3.Visible = True
        Next3.Visible = True
        Back2.Visible = True
    End Sub
    Private Sub Next3_Click(sender As Object, e As EventArgs) Handles Next3.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label4.Visible = True
        PictureBox4.Visible = True
        Next4.Visible = True
        Back3.Visible = True
    End Sub
    Private Sub Next4_Click(sender As Object, e As EventArgs) Handles Next4.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label5.Visible = True
        Next5.Visible = True
        Back4.Visible = True
    End Sub
    Private Sub Next5_Click(sender As Object, e As EventArgs) Handles Next5.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label6.Visible = True
        Next6.Visible = True
        Back5.Visible = True
    End Sub
    Private Sub Next6_Click(sender As Object, e As EventArgs) Handles Next6.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label7.Visible = True
        Next7.Visible = True
        Back6.Visible = True
    End Sub
    Private Sub Next7_Click(sender As Object, e As EventArgs) Handles Next7.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label8.Visible = True
        Next8.Visible = True
        Back7.Visible = True
    End Sub
    Private Sub Next8_Click(sender As Object, e As EventArgs) Handles Next8.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label9.Visible = True
        Next9.Visible = True
        Back8.Visible = True
    End Sub
    Private Sub Next9_Click(sender As Object, e As EventArgs) Handles Next9.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label10.Visible = True
        Back9.Visible = True
    End Sub
    Private Sub Back1_Click(sender As Object, e As EventArgs) Handles Back1.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label1.Visible = True
        Next1.Visible = True
    End Sub
    Private Sub Back2_Click(sender As Object, e As EventArgs) Handles Back2.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label2.Visible = True
        Next2.Visible = True
        Back1.Visible = True

    End Sub
    Private Sub Back3_Click(sender As Object, e As EventArgs) Handles Back3.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label3.Visible = True
        Next3.Visible = True
        Back2.Visible = True
    End Sub
    Private Sub Back4_Click(sender As Object, e As EventArgs) Handles Back4.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label4.Visible = True
        Next4.Visible = True
        Back3.Visible = True
    End Sub
    Private Sub Back5_Click(sender As Object, e As EventArgs) Handles Back5.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label5.Visible = True
        Next5.Visible = True
        Back4.Visible = True
    End Sub
    Private Sub Back6_Click(sender As Object, e As EventArgs) Handles Back6.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label6.Visible = True
        Next6.Visible = True
        Back5.Visible = True
    End Sub
    Private Sub Back7_Click(sender As Object, e As EventArgs) Handles Back7.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label7.Visible = True
        Next7.Visible = True
        Back6.Visible = True
    End Sub
    Private Sub Back8_Click(sender As Object, e As EventArgs) Handles Back8.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label8.Visible = True
        Next8.Visible = True
        Back7.Visible = True
    End Sub
    Private Sub Back9_Click(sender As Object, e As EventArgs) Handles Back9.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label9.Visible = True
        Next9.Visible = True
        Back8.Visible = True
    End Sub
End Class