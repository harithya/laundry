
Imports System.Data.OleDb

Public Class Tambah

    Private Sub Tambah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim kategori(2) As String
        Dim i As Integer
        kategori(0) = "Baju"
        kategori(1) = "Selimut"
        kategori(2) = "Tikar"

        For i = 0 To 2
            inpKategori.Items.Add(kategori(i))
        Next

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        command = New OleDbCommand("INSERT INTO laundry (nama,alamat,jenis,berat,harga) VALUES  (@nama,@alamat,@kategori,@berat,@harga) ", connect)
        command.Parameters.Add("@nama", OleDbType.Char).Value = inpNama.Text
        command.Parameters.Add("@alamat", OleDbType.Char).Value = inpAlamat.Text
        command.Parameters.Add("@kategori", OleDbType.Char).Value = inpKategori.Text
        command.Parameters.Add("@berat", OleDbType.Integer).Value = inpBerat.Text
        command.Parameters.Add("@harga", OleDbType.Integer).Value = inpTotal.Text

        command.ExecuteNonQuery()
        MsgBox("Berhasil menambahkan data")
        Me.Close()
        Home.showTable()



    End Sub


    Private Sub inpBerat_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles inpBerat.KeyUp

        Dim harga As Integer
        Dim kt As String
        Dim berat As Double

        kt = inpKategori.Text

        If kt = "Baju" Then
            harga = 2000
        ElseIf kt = "Selimut" Then
            harga = 3000
        ElseIf kt = "Tikar" Then
            harga = 4000
        Else
            harga = 0
        End If

        If inpBerat.Text = "" Then
            berat = 0
        Else
            berat = inpBerat.Text
        End If

        inpTotal.Text = berat * harga



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Call connection()

        command = New OleDbCommand("DELETE FROM laundry WHERE id=@id", connect)
        command.Parameters.Add("@id", OleDbType.Integer).Value = id.Text
        command.ExecuteNonQuery()

        MsgBox("Berhasil Menghapus data")
        Me.Close()
        Home.showTable()




    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        command = New OleDbCommand("UPDATE laundry SET nama=@nama, alamat=@alamat, jenis=@kategori, berat=@berat, harga=@harga WHERE id=@id", connect)
        command.Parameters.AddWithValue("@nama", inpNama.Text)
        command.Parameters.AddWithValue("@alamat", inpAlamat.Text)
        command.Parameters.AddWithValue("@kategori", inpKategori.Text)
        command.Parameters.AddWithValue("@berat", inpBerat.Text)
        command.Parameters.AddWithValue("@harga", inpTotal.Text)
        command.Parameters.AddWithValue("@id", id.Text)

        command.ExecuteNonQuery()
        MsgBox("Berhasil mengubah data")
        Me.Close()
        Home.showTable()

    End Sub
End Class