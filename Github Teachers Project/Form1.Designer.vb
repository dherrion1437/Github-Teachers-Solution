<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LstTeach = New System.Windows.Forms.ListBox()
        Me.Picseiler = New System.Windows.Forms.PictureBox()
        CType(Me.Picseiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LstTeach
        '
        Me.LstTeach.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstTeach.FormattingEnabled = True
        Me.LstTeach.ItemHeight = 29
        Me.LstTeach.Items.AddRange(New Object() {"#1. Ms. Seiler", "", "#2. Ms. Green", "", "#3. Ms. Kukay", "", "#4. Ms. Selimovic", "", "#5. Ms. Clark"})
        Me.LstTeach.Location = New System.Drawing.Point(485, 52)
        Me.LstTeach.Name = "LstTeach"
        Me.LstTeach.Size = New System.Drawing.Size(286, 294)
        Me.LstTeach.TabIndex = 1
        '
        'Picseiler
        '
        Me.Picseiler.Image = Global.Github_Teachers_Project.My.Resources.Resources.seiler
        Me.Picseiler.Location = New System.Drawing.Point(153, 71)
        Me.Picseiler.Name = "Picseiler"
        Me.Picseiler.Size = New System.Drawing.Size(191, 200)
        Me.Picseiler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picseiler.TabIndex = 6
        Me.Picseiler.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Picseiler)
        Me.Controls.Add(Me.LstTeach)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Picseiler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LstTeach As ListBox
    Friend WithEvents Picseiler As PictureBox
End Class
