Public Class FormBab1
    Public Sub Reset()
        Next1.Visible = False
        Next2.Visible = False
        Next3.Visible = False
        Next4.Visible = False
        Next5.Visible = False
        Back1.Visible = False
        Back2.Visible = False
        Back3.Visible = False
        Back4.Visible = False
        Back5.Visible = False
        btn_Keluar.Visible = False

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Reset()
        btn_Keluar.Visible = True
        Label1.Visible = True
        Next1.Visible = True
    End Sub
    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub Next1_Click(sender As Object, e As EventArgs) Handles Next1.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label2.Visible = True
        Next2.Visible = True
        Back1.Visible = True
    End Sub
    Private Sub Next2_Click(sender As Object, e As EventArgs) Handles Next2.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label3.Visible = True
        Next3.Visible = True
        Back2.Visible = True
    End Sub
    Private Sub Next3_Click(sender As Object, e As EventArgs) Handles Next3.Click
        Call Reset()
        btn_Keluar.Visible = True
        Label4.Visible = True
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
        Back5.Visible = True
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
End Class