<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Accueil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Accueil))
        Me.lblNom = New System.Windows.Forms.Label()
        Me.cbbNom = New System.Windows.Forms.ComboBox()
        Me.btnNvPartie = New System.Windows.Forms.Button()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.btnParam = New System.Windows.Forms.Button()
        Me.btnRegles = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.BackColor = System.Drawing.Color.Transparent
        Me.lblNom.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNom.Location = New System.Drawing.Point(150, 147)
        Me.lblNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(54, 23)
        Me.lblNom.TabIndex = 0
        Me.lblNom.Text = "Nom : "
        '
        'cbbNom
        '
        Me.cbbNom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbNom.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbbNom.FormattingEnabled = True
        Me.cbbNom.Location = New System.Drawing.Point(203, 144)
        Me.cbbNom.Margin = New System.Windows.Forms.Padding(2)
        Me.cbbNom.Name = "cbbNom"
        Me.cbbNom.Size = New System.Drawing.Size(161, 31)
        Me.cbbNom.TabIndex = 1
        '
        'btnNvPartie
        '
        Me.btnNvPartie.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnNvPartie.Location = New System.Drawing.Point(203, 202)
        Me.btnNvPartie.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNvPartie.Name = "btnNvPartie"
        Me.btnNvPartie.Size = New System.Drawing.Size(161, 44)
        Me.btnNvPartie.TabIndex = 2
        Me.btnNvPartie.Text = "Nouvelle Partie"
        Me.btnNvPartie.UseVisualStyleBackColor = True
        '
        'btnScores
        '
        Me.btnScores.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnScores.Location = New System.Drawing.Point(203, 273)
        Me.btnScores.Margin = New System.Windows.Forms.Padding(2)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(161, 44)
        Me.btnScores.TabIndex = 3
        Me.btnScores.Text = "Scores"
        Me.btnScores.UseVisualStyleBackColor = True
        '
        'btnParam
        '
        Me.btnParam.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnParam.Location = New System.Drawing.Point(203, 343)
        Me.btnParam.Margin = New System.Windows.Forms.Padding(2)
        Me.btnParam.Name = "btnParam"
        Me.btnParam.Size = New System.Drawing.Size(161, 44)
        Me.btnParam.TabIndex = 4
        Me.btnParam.Text = "Paramètres"
        Me.btnParam.UseVisualStyleBackColor = True
        '
        'btnRegles
        '
        Me.btnRegles.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegles.Location = New System.Drawing.Point(366, 436)
        Me.btnRegles.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegles.Name = "btnRegles"
        Me.btnRegles.Size = New System.Drawing.Size(161, 44)
        Me.btnRegles.TabIndex = 5
        Me.btnRegles.Text = "Règles du Jeu"
        Me.btnRegles.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnQuitter.ForeColor = System.Drawing.Color.Black
        Me.btnQuitter.Location = New System.Drawing.Point(87, 436)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(113, 44)
        Me.btnQuitter.TabIndex = 7
        Me.btnQuitter.Text = "QUITTER"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.BackColor = System.Drawing.Color.Transparent
        Me.lblTitre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitre.Font = New System.Drawing.Font("Poor Richard", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitre.Location = New System.Drawing.Point(178, -5)
        Me.lblTitre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(219, 68)
        Me.lblTitre.TabIndex = 8
        Me.lblTitre.Text = "memory"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(161, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 31)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "un jeu de concentration"
        '
        'Form_Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(596, 521)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnRegles)
        Me.Controls.Add(Me.btnParam)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.btnNvPartie)
        Me.Controls.Add(Me.cbbNom)
        Me.Controls.Add(Me.lblNom)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form_Accueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACCUEIL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNom As Label
    Friend WithEvents cbbNom As ComboBox
    Friend WithEvents btnNvPartie As Button
    Friend WithEvents btnScores As Button
    Friend WithEvents btnParam As Button
    Friend WithEvents btnRegles As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents lblTitre As Label
    Friend WithEvents Label1 As Label
End Class
