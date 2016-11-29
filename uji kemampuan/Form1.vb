Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection
    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn = New MySqlConnection("Data source =localhost;userid=root;database=desktop;password=")

        Try

            dbconn.Open()

        Catch ex As Exception

            MsgBox("Error in connection, please check Database and connection to server.")

        End Try
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        Dim nis As String
        Dim nam As String
        Dim kel As String
        Dim tl As String
        Dim tgl As String
        Dim al As String
        Dim amat As String

        nis = n.Text
        nam = na.Text
        kel = k.Text
        tl = t.Text
        tgl = tg.Text
        al = a.Text
        amat = aa.Text
        sql = "INSERT INTO tb_biodata(nis,nama,kelas,tempatlahir,tanggallahir,alamat,alamatasal) VALUES
                ('" + nis + "', '" + nam + "','" + kel + "', '" + tl + "', '" + tgl + "', '" + al + "', '" + amat + "')"
        Try
            dbcomm = New MySqlCommand(Sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error In saving To Database. Error Is :" & ex.Message)
            dbread.Close()
            Exit Sub
        End Try
        MsgBox("Data telah tersimpan")
        n.Text = ""
        na.Text = ""
        k.Text = ""
        t.Text = ""
        a.Text = ""
        aa.Text = ""
    End Sub


    Private Sub Tampil_Click(sender As Object, e As EventArgs) Handles Tampil.Click
        ListBox1.Items.Clear()
        sql = "SELECT * FROM tb_biodata"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                ListBox1.Items.Add(dbread("nis") & " " & dbread("nama") & " " &
                dbread("kelas") & " " & dbread("tempatlahir") & " " &
                dbread("tanggallahir") & " " & dbread("alamat") & " " & dbread("alamatasal"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" &
            ex.Message)
            dbread.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub cari_Click(sender As Object, e As EventArgs) Handles cari.Click
        ListBox1.Items.Clear()
        sql = "SELECT * FROM tb_biodata where nis like '%" & n.Text & "%'"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                ListBox1.Items.Add(dbread("nis") & " " & dbread("nama") & " " &
                dbread("kelas") & " " & dbread("tempatlahir") & " " &
                dbread("tanggallahir") & " " & dbread("alamat") & " " & dbread("alamatasal"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" &
            ex.Message)
            dbread.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        sql = "DELETE FROM tb_biodata where nis='" & n.Text & "'"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                ListBox1.Items.Add(dbread("nis") & " " & dbread("nama") & " " &
                dbread("kelas") & " " & dbread("tempatlahir") & " " &
                dbread("tanggallahir") & " " & dbread("alamat") & " " & dbread("alamatasal"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" &
            ex.Message)
            dbread.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        ListBox1.Items.Clear()
        sql = "SELECT * FROM tb_biodata"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                ListBox1.Items.Add(dbread("nis") & " " & dbread("nama") & " " &
                dbread("kelas") & " " & dbread("tempatlahir") & " " &
                dbread("tanggallahir") & " " & dbread("alamat") & " " & dbread("alamatasal"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" &
            ex.Message)
            dbread.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        sql = "update tb_biodata set nama='Ridjal Fathoni' where nis='123'"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in saving to Database. Error is :" & ex.Message)
            dbread.Close()
            Exit Sub
        End Try
        MsgBox("Data sudah diperbarui")
    End Sub

    Private Sub view_Click(sender As Object, e As EventArgs) Handles view.Click
        sql = "SELECT * FROM tb_biodata"
        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                DataGridView1.Rows.Add(dbread("nis"), dbread("nama"),
                dbread("kelas"), dbread("tempatlahir"), dbread("tanggallahir"), dbread("alamat"), dbread("alamatasal"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" &
            ex.Message)
            dbread.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub pdf_Click(sender As Object, e As EventArgs) Handles pdf.Click
        'Creating iTextSharp Table from the DataTable data
        Dim pdfTable As New PdfPTable(DataGridView1.ColumnCount)
        pdfTable.DefaultCell.Padding = 3
        pdfTable.WidthPercentage = 50
        pdfTable.HorizontalAlignment = Element.ALIGN_MIDDLE

        pdfTable.DefaultCell.BorderWidth = 1
        'Adding Header row
        For Each column As DataGridViewColumn In DataGridView1.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = New iTextSharp.text.BaseColor(240, 240, 240)
            pdfTable.AddCell(cell)
        Next
        'Adding DataRow
        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                'pdfTable.AddCell(cell.Value.ToString())
                If cell.Value <> "" Then
                    'MsgBox(cell.Value)
                    pdfTable.AddCell(cell.Value)
                End If
            Next
        Next
        'Exporting to PDF
        Dim folderPath As String = "D:\SMK TELKOM\KELAS XI\Desktop\"
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        Using stream As New FileStream(folderPath & "DataGridViewExport.pdf",
FileMode.Create)
            Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
            PdfWriter.GetInstance(pdfDoc, stream)
            pdfDoc.Open()
            pdfDoc.Add(pdfTable)
            pdfDoc.Close()
            stream.Close()
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim buf As String
        Dim nis(200) As String
        Dim nama(200), kelas(200), tempat(200), tanggal(200), alamat(200), alamat_asal(200) As String
        Dim i, j, k, l, jmlData As Integer

        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            buf = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            RichTextBox1.Text = buf

            i = 0
            While buf.IndexOf(";") > 0
                nis(i) = buf.Substring(0, buf.IndexOf(";"))
                buf = buf.Remove(0, buf.IndexOf(";") + 1)
                nama(i) = buf.Substring(0, buf.IndexOf(";"))
                buf = buf.Remove(0, buf.IndexOf(";") + 1)
                kelas(i) = buf.Substring(0, buf.IndexOf(";"))
                buf = buf.Remove(0, buf.IndexOf(";") + 1)
                tempat(i) = buf.Substring(0, buf.IndexOf(";"))
                buf = buf.Remove(0, buf.IndexOf(";") + 1)
                tanggal(i) = buf.Substring(0, buf.IndexOf(";"))
                buf = buf.Remove(0, buf.IndexOf(";") + 1)
                alamat(i) = buf.Substring(0, buf.IndexOf(";"))
                buf = buf.Remove(0, buf.IndexOf(";") + 1)
                alamat_asal(i) = buf.Substring(0, buf.IndexOf(Chr(Keys.Return)))
                buf = buf.Remove(0, buf.IndexOf(Chr(Keys.Return)) + 2)
                i += 1

                'MsgBox(nis(i) + ", " + nama(i) + ", " + kelas(i))
            End While

            jmlData = i - 1

            For i = 1 To jmlData
                sql = "INSERT INTO tb_biodata(nis,nama,kelas,tempatlahir,tanggallahir,alamat,alamatasal) VALUES('" & nis(i) & "','" & nama(i) & "','" & kelas(i) & "','" & tempat(i) & "','" & tanggal(i) & "','" & alamat(i) & "','" & alamat_asal(i) & "')"
                Try
                    dbcomm = New MySqlCommand(sql, dbconn)
                    dbread = dbcomm.ExecuteReader()
                    dbread.Close()
                Catch ex As Exception
                    MsgBox("Error in saving to Database. Error is :" & ex.Message)
                    dbread.Close()
                    Exit Sub
                End Try
            Next

            MsgBox("Pengolahaan data sudah selesai.")

        End If
    End Sub
End Class
