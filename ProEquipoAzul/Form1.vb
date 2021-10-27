Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Public stringConeccion As String = “Data Source = DESKTOP-2ROLQTO; Initial Catalog = EstuCursos; Integrated Security = True”
    Dim stringSelect As String = "SELECT * FROM Estudiantes "
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call CargarGrid()

    End Sub

    Private Sub CargarGrid()

        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter(stringSelect, stringConeccion)
            da.Fill(dt)
            Me.GridView1.DataSource = dt
            'LabelInfo.Text = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
            'String.Format("Total datos en la tabla: {0}", dt.Rows.Count)el 0 se sustituye por el valor de la par o que le asignes
        Catch ex As Exception

            LabelInfo.Text = "Error: " & ex.Message
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextCodigo.Text <> "" And TextEstudiante.Text <> "" Then
                Dim InsertSql As String
                InsertSql = "INSERT INTO Estudiantes (CodigoEstudiante, NombreEstudiante) VALUES (@CodigoEstudiante, @NombreEstudiante)"

                Using con As New SqlConnection(stringConeccion)

                    Dim cmd As New SqlCommand(InsertSql, con)
                    cmd.Parameters.AddWithValue("@CodigoEstudiante", TextCodigo.Text)
                    cmd.Parameters.AddWithValue("@NombreEstudiante", TextEstudiante.Text)
                    con.Open()
                    Dim t As Integer = CInt(cmd.ExecuteScalar())
                    con.Close()

                End Using

                Call CargarGrid()
                MsgBox("Ha agregado un estudiante satisfactoriamente")


            End If
        Catch ex As Exception

            LabelInfo.Text = "Error: " & ex.Message
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If TextEstudiante.Text <> "" Then

                Dim InsertSql As String
                InsertSql = "Delete from [dbo].[Estudiantes] where CodigoEstudiante = @CodigoEstudiante"

                Using con As New SqlConnection(stringConeccion)

                    Dim cmd As New SqlCommand(InsertSql, con)
                    cmd.Parameters.AddWithValue("@CodigoEstudiante", TextCodigo.Text)
                    con.Open()
                    Dim t As Integer = CInt(cmd.ExecuteScalar())
                    con.Close()

                End Using
                Call CargarGrid()
                MsgBox("Ha eliminado un estudiante satisfactoriamente")

            End If
        Catch ex As Exception

            LabelInfo.Text = "Error: " & ex.Message
        End Try

    End Sub

    Private Sub GridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView1.CellContentClick
        Dim dgv As DataGridViewRow = GridView1.Rows(e.RowIndex)
        TextCodigo.Text = dgv.Cells(0).Value.ToString()
        TextEstudiante.Text = dgv.Cells(1).Value.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If TextEstudiante.Text <> "" Then

                Dim InsertSql As String
                InsertSql = "Update [dbo].[Estudiantes] set NombreEstudiante = @NombreEstudiante where CodigoEstudiante = @CodigoEstudiante"

                Using con As New SqlConnection(stringConeccion)

                    Dim cmd As New SqlCommand(InsertSql, con)
                    cmd.Parameters.AddWithValue("@CodigoEstudiante", TextCodigo.Text)
                    cmd.Parameters.AddWithValue("@NombreEstudiante", TextEstudiante.Text)
                    con.Open()
                    Dim t As Integer = CInt(cmd.ExecuteScalar())
                    con.Close()

                End Using
                Call CargarGrid()
                MsgBox("Ha modificado un estudiante satisfactoriamente")

            End If
        Catch ex As Exception

            LabelInfo.Text = "Error: " & ex.Message
        End Try
    End Sub
End Class
