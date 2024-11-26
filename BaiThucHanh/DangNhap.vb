Public Class DangNhap
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtmatkhau_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ten As String = TextBox1.Text
        Dim mk As String = TextBox2.Text
        If (ten = "anhkhoa" AndAlso mk = "123") Then
            Dim anhkhoa As New SachThieuNhi()
            anhkhoa.Show()
            Me.Hide()
        End If
        If (ten = "congtrang" AndAlso mk = "123") Then
            Dim anhkhoa1 As New SachNgoaiNgu()
            anhkhoa1.Show()
            Me.Hide()
        End If
        If (ten = "tuan" AndAlso mk = "123") Then
            Dim anhkhoa2 As New SachkyNangSong()
            anhkhoa2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked

    End Sub
End Class