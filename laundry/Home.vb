Imports System.Data.OleDb

Public Class Home

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Tambah.ShowDialog()
    End Sub


    Public dataSet As DataSet
    Public Function showTable()
        dataAdapter = New OleDbDataAdapter("SELECT * FROM laundry", connect)
        DataSet = New DataSet
        dataAdapter.Fill(DataSet, "laundry")
        data.DataSource = DataSet.Tables("laundry")

    End Function


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call connection()
        Call showTable()
    End Sub


    Private Sub data_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data.CellClick

        Dim id As Integer

        Call connection()

        id = data.Rows(e.RowIndex).Cells(0).Value
        command = New OleDbCommand("SELECT * FROM laundry WHERE ID = @id ", connect)
        command.Parameters.Add("@id", OleDbType.Integer).Value = id
        dataReader = command.ExecuteReader
        dataReader.Read()

        Tambah.id.Text = dataReader(0)
        Tambah.inpNama.Text = dataReader(1)
        Tambah.inpAlamat.Text = dataReader(2)
        Tambah.inpKategori.SelectedItem = dataReader(3)
        Tambah.inpBerat.Text = dataReader(4)
        Tambah.inpTotal.Text = dataReader(5)

        Tambah.ShowDialog()




    End Sub


End Class
