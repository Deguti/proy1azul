
Imports System.Data
Imports System.Data.SqlClient
Public Class Form2
    Public stringConeccion As String = “Data Source = DESKTOP-2ROLQTO; Initial Catalog = EstuCursos; Integrated Security = True”
    Dim allEstudiantesSelect As String = "SELECT * FROM Estudiantes "
    Dim allCursosSelect As String = "SELECT * FROM Cursos "
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextEstudiantes.Text <> "" Then

                Dim InsertSql As String
                InsertSql = $"Select cu.CodigoCurso, cu.NombreCurso from CodigodeEstuCurso ec 
inner join Estudiantes e on ec.CodigoEstudiante = e.CodigoEstudiante 
inner join Cursos cu on ec.CodigoCursos = cu.CodigoCurso where e.NombreEstudiante= '{TextEstudiantes.Text}'"
                Call CargarGridCurso(InsertSql)



            Else
                Call CargarGridCurso(allCursosSelect)

            End If
        Catch ex As Exception


        End Try
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Call CargarGridEstudiante(allEstudiantesSelect)
        Call CargarGridCurso(allCursosSelect)
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub CargarGridEstudiante(ByVal sqlEstudiante As String)

        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        'Try
        da = New SqlDataAdapter(sqlEstudiante, stringConeccion)
        da.Fill(dt)
        Me.GridView1.DataSource = dt
        'LabelInfo.Text = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
        'String.Format("Total datos en la tabla: {0}", dt.Rows.Count)el 0 se sustituye por el valor de la par o que le asignes
        'Catch ex As Exception

        '   LabelInfo.Text = "Error: " & ex.Message
        'End Try
    End Sub
    Private Sub CargarGridCurso(ByVal sqlCurso As String)

        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        'Try
        da = New SqlDataAdapter(sqlCurso, stringConeccion)
        da.Fill(dt)
        Me.GridView2.DataSource = dt
        'LabelInfo.Text = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
        'String.Format("Total datos en la tabla: {0}", dt.Rows.Count)el 0 se sustituye por el valor de la par o que le asignes
        'Catch ex As Exception

        '   LabelInfo.Text = "Error: " & ex.Message
        'End Try
    End Sub

    Private Sub GridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If TextCurso.Text <> "" Then

                Dim InsertSql As String
                InsertSql = $"Select e.CodigoEstudiante, e.NombreEstudiante from CodigodeEstuCurso ec 
inner join Estudiantes e on ec.CodigoEstudiante = e.CodigoEstudiante 
inner join Cursos cu on ec.CodigoCursos = cu.CodigoCurso where cu.NombreCurso= '{TextCurso.Text}'"
                Call CargarGridEstudiante(InsertSql)



            Else
                Call CargarGridEstudiante(allEstudiantesSelect)

            End If
        Catch ex As Exception


        End Try
    End Sub
End Class