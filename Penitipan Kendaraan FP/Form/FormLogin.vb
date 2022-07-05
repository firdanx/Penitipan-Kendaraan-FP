Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        DTGrid = KontrolPegawai.loginKasir(txtUsername.Text).ToTable
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("Silahkan isikan username dan password anda")
        ElseIf txtPassword.Text = "" Then
            MsgBox("Silahkan isikan password anda")
        ElseIf txtUsername.Text = "" Then
            MsgBox("Silahkan isikan username anda")
        Else
            If DTGrid.Rows.Count > 0 Then
                EntitasPegawai.IdPegawai = DTGrid.Rows(0).Item(0)
                EntitasPegawai.Username = DTGrid.Rows(0).Item(1)
                EntitasPegawai.Password = DTGrid.Rows(0).Item(2)
                EntitasPegawai.Nama = DTGrid.Rows(0).Item(3)

                KODELOG = EntitasPegawai.IdPegawai
                NAMALOG = EntitasPegawai.Nama

                If txtPassword.Text = EntitasPegawai.Password Then
                    FormPencatatan.Show()
                    txtPassword.Text = ""
                    txtUsername.Text = ""
                    Me.Hide()
                Else
                    MessageBox.Show("PASSWORD SALAH!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPassword.Text = ""
                    txtUsername.Focus()
                End If
            Else
                MessageBox.Show("ID tidak dikenal!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Text = ""
                txtUsername.Text = ""
                txtUsername.Focus()
            End If
        End If
    End Sub
End Class
