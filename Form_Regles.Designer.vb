<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Regles
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Regles))
        Me.TxtRegles = New System.Windows.Forms.Label()
        Me.BtnAccueil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtRegles
        '
        Me.TxtRegles.AutoEllipsis = True
        Me.TxtRegles.BackColor = System.Drawing.Color.Transparent
        Me.TxtRegles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtRegles.Font = New System.Drawing.Font("Poor Richard", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtRegles.Location = New System.Drawing.Point(94, 56)
        Me.TxtRegles.Name = "TxtRegles"
        Me.TxtRegles.Size = New System.Drawing.Size(633, 267)
        Me.TxtRegles.TabIndex = 0
        Me.TxtRegles.Text = "TxtRegles"
        Me.TxtRegles.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TxtRegles.UseCompatibleTextRendering = True
        Me.TxtRegles.UseMnemonic = False
        '
        'BtnAccueil
        '
        Me.BtnAccueil.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAccueil.Location = New System.Drawing.Point(306, 359)
        Me.BtnAccueil.Name = "BtnAccueil"
        Me.BtnAccueil.Size = New System.Drawing.Size(188, 51)
        Me.BtnAccueil.TabIndex = 1
        Me.BtnAccueil.Text = "Txt"
        Me.BtnAccueil.UseVisualStyleBackColor = True
        '
        'Form_Regles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnAccueil)
        Me.Controls.Add(Me.TxtRegles)
        Me.DoubleBuffered = True
        Me.Name = "Form_Regles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGLES DU JEU"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtRegles As Label
    Friend WithEvents BtnAccueil As Button
End Class
