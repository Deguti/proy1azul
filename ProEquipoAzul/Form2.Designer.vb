<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextEstudiantes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextCurso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridView1 = New System.Windows.Forms.DataGridView()
        Me.GridView2 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextEstudiantes
        '
        Me.TextEstudiantes.Location = New System.Drawing.Point(165, 64)
        Me.TextEstudiantes.Name = "TextEstudiantes"
        Me.TextEstudiantes.Size = New System.Drawing.Size(100, 20)
        Me.TextEstudiantes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre al estudiante"
        '
        'TextCurso
        '
        Me.TextCurso.Location = New System.Drawing.Point(542, 71)
        Me.TextCurso.Name = "TextCurso"
        Me.TextCurso.Size = New System.Drawing.Size(100, 20)
        Me.TextCurso.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(395, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre el curso"
        '
        'GridView1
        '
        Me.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView1.Location = New System.Drawing.Point(415, 126)
        Me.GridView1.Name = "GridView1"
        Me.GridView1.Size = New System.Drawing.Size(240, 150)
        Me.GridView1.TabIndex = 4
        '
        'GridView2
        '
        Me.GridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView2.Location = New System.Drawing.Point(25, 126)
        Me.GridView2.Name = "GridView2"
        Me.GridView2.Size = New System.Drawing.Size(240, 150)
        Me.GridView2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(91, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 44)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Buscar Cursos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(472, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 44)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Buscar Estudiantes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GridView2)
        Me.Controls.Add(Me.GridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextCurso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextEstudiantes)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextEstudiantes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextCurso As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GridView1 As DataGridView
    Friend WithEvents GridView2 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
