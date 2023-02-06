Imports System.Buffers
Imports System.Reflection.Emit

Public Class Form2
    Public Sub Reset()
        btn_Beranda.Visible = False
        btn_Capaian.Visible = False
        btn_Materi.Visible = False
        btn_Keluar.Visible = False

        Label1.Visible = False
        LabelAwal.Visible = False
        Panel4.Visible = False
        Panel3.Visible = False

        Bab1.Visible = False
        Bab2.Visible = False
        Bab3.Visible = False
        Bab4.Visible = False
        Bab5.Visible = False
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Reset()
        LabelAwal.Visible = True
        btn_Capaian.Visible = True
        btn_Materi.Visible = True
        btn_Keluar.Visible = True
        Panel1.Visible = True
    End Sub
    Private Sub btn_Capaian_Click(sender As Object, e As EventArgs) Handles btn_Capaian.Click
        Call Reset()
        btn_Beranda.Visible = True
        Label1.Visible = True
        Panel4.Visible = True
        Panel3.Visible = True
    End Sub
    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Form1.Close()
        Me.Close()
    End Sub
    Private Sub btn_Beranda_Click(sender As Object, e As EventArgs) Handles btn_Beranda.Click
        Call Reset()
        btn_Capaian.Visible = True
        btn_Materi.Visible = True
        btn_Keluar.Visible = True
        Panel1.Visible = True
        LabelAwal.Visible = True
    End Sub
    Private Sub btn_Materi_Click(sender As Object, e As EventArgs) Handles btn_Materi.Click
        Call Reset()
        Bab1.Visible = True
        Bab2.Visible = True
        Bab3.Visible = True
        Bab4.Visible = True
        Bab5.Visible = True
        btn_Beranda.Visible = True
        Panel4.Visible = True
        Panel3.Visible = True
    End Sub
    Private Sub Bab1_Click_1(sender As Object, e As EventArgs) Handles Bab1.Click
        Dim form = New FormBab1
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel1.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Bab2_Click(sender As Object, e As EventArgs) Handles Bab2.Click
        Dim form = New FormBab2
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel1.Controls.Add(form)
        form.Show()
    End Sub
    Private Sub Bab3_Click(sender As Object, e As EventArgs) Handles Bab3.Click
        Dim form = New FormBab3
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel1.Controls.Add(form)
        form.Show()
    End Sub
    Private Sub Bab4_Click(sender As Object, e As EventArgs) Handles Bab4.Click
        Dim form = New FormBab4
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel1.Controls.Add(form)
        form.Show()
    End Sub
    Private Sub Bab5_Click(sender As Object, e As EventArgs) Handles Bab5.Click
        Dim form = New FormBab5
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel1.Controls.Add(form)
        form.Show()
    End Sub

End Class