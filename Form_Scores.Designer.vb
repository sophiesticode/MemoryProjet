<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Scores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Scores))
        Me.LblNom = New System.Windows.Forms.Label()
        Me.CBBNoms = New System.Windows.Forms.ComboBox()
        Me.BtnRech = New System.Windows.Forms.Button()
        Me.BtnOrdre = New System.Windows.Forms.Button()
        Me.LBNom = New System.Windows.Forms.ListBox()
        Me.LBMaxCarres = New System.Windows.Forms.ListBox()
        Me.LBTpsRech = New System.Windows.Forms.ListBox()
        Me.LBNbParties = New System.Windows.Forms.ListBox()
        Me.LBCumulTps = New System.Windows.Forms.ListBox()
        Me.BtnRetA = New System.Windows.Forms.Button()
        Me.PnlLScores = New System.Windows.Forms.Panel()
        Me.LbLegCumulTps = New System.Windows.Forms.Label()
        Me.LbLegNbParties = New System.Windows.Forms.Label()
        Me.LbLegTps = New System.Windows.Forms.Label()
        Me.LbLegNbCarr = New System.Windows.Forms.Label()
        Me.LbLegNoms = New System.Windows.Forms.Label()
        Me.PnlLScores.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblNom
        '
        Me.LblNom.AutoSize = True
        Me.LblNom.BackColor = System.Drawing.Color.Transparent
        Me.LblNom.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNom.Location = New System.Drawing.Point(121, 49)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(51, 23)
        Me.LblNom.TabIndex = 0
        Me.LblNom.Text = "Nom :"
        '
        'CBBNoms
        '
        Me.CBBNoms.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CBBNoms.FormattingEnabled = True
        Me.CBBNoms.Location = New System.Drawing.Point(202, 49)
        Me.CBBNoms.Name = "CBBNoms"
        Me.CBBNoms.Size = New System.Drawing.Size(151, 31)
        Me.CBBNoms.TabIndex = 1
        '
        'BtnRech
        '
        Me.BtnRech.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnRech.Location = New System.Drawing.Point(475, 47)
        Me.BtnRech.Name = "BtnRech"
        Me.BtnRech.Size = New System.Drawing.Size(121, 42)
        Me.BtnRech.TabIndex = 2
        Me.BtnRech.Text = "Rechercher"
        Me.BtnRech.UseVisualStyleBackColor = True
        '
        'BtnOrdre
        '
        Me.BtnOrdre.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnOrdre.Location = New System.Drawing.Point(167, 364)
        Me.BtnOrdre.Name = "BtnOrdre"
        Me.BtnOrdre.Size = New System.Drawing.Size(193, 47)
        Me.BtnOrdre.TabIndex = 3
        Me.BtnOrdre.Text = "=> Ordre décroissant"
        Me.BtnOrdre.UseVisualStyleBackColor = True
        '
        'LBNom
        '
        Me.LBNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBNom.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LBNom.FormattingEnabled = True
        Me.LBNom.ItemHeight = 23
        Me.LBNom.Location = New System.Drawing.Point(29, 11)
        Me.LBNom.Name = "LBNom"
        Me.LBNom.Size = New System.Drawing.Size(121, 161)
        Me.LBNom.TabIndex = 4
        '
        'LBMaxCarres
        '
        Me.LBMaxCarres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBMaxCarres.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LBMaxCarres.FormattingEnabled = True
        Me.LBMaxCarres.ItemHeight = 23
        Me.LBMaxCarres.Location = New System.Drawing.Point(181, 11)
        Me.LBMaxCarres.Name = "LBMaxCarres"
        Me.LBMaxCarres.Size = New System.Drawing.Size(70, 161)
        Me.LBMaxCarres.TabIndex = 5
        '
        'LBTpsRech
        '
        Me.LBTpsRech.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBTpsRech.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LBTpsRech.FormattingEnabled = True
        Me.LBTpsRech.ItemHeight = 23
        Me.LBTpsRech.Location = New System.Drawing.Point(304, 11)
        Me.LBTpsRech.Name = "LBTpsRech"
        Me.LBTpsRech.Size = New System.Drawing.Size(70, 161)
        Me.LBTpsRech.TabIndex = 6
        '
        'LBNbParties
        '
        Me.LBNbParties.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBNbParties.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LBNbParties.FormattingEnabled = True
        Me.LBNbParties.ItemHeight = 23
        Me.LBNbParties.Location = New System.Drawing.Point(418, 11)
        Me.LBNbParties.Name = "LBNbParties"
        Me.LBNbParties.Size = New System.Drawing.Size(70, 161)
        Me.LBNbParties.TabIndex = 10
        '
        'LBCumulTps
        '
        Me.LBCumulTps.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LBCumulTps.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LBCumulTps.FormattingEnabled = True
        Me.LBCumulTps.ItemHeight = 23
        Me.LBCumulTps.Location = New System.Drawing.Point(524, 11)
        Me.LBCumulTps.Name = "LBCumulTps"
        Me.LBCumulTps.Size = New System.Drawing.Size(70, 161)
        Me.LBCumulTps.TabIndex = 12
        '
        'BtnRetA
        '
        Me.BtnRetA.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnRetA.Location = New System.Drawing.Point(395, 364)
        Me.BtnRetA.Name = "BtnRetA"
        Me.BtnRetA.Size = New System.Drawing.Size(193, 47)
        Me.BtnRetA.TabIndex = 14
        Me.BtnRetA.Text = "Retour"
        Me.BtnRetA.UseVisualStyleBackColor = True
        '
        'PnlLScores
        '
        Me.PnlLScores.BackColor = System.Drawing.Color.Transparent
        Me.PnlLScores.Controls.Add(Me.LBCumulTps)
        Me.PnlLScores.Controls.Add(Me.LBNbParties)
        Me.PnlLScores.Controls.Add(Me.LBTpsRech)
        Me.PnlLScores.Controls.Add(Me.LBMaxCarres)
        Me.PnlLScores.Controls.Add(Me.LBNom)
        Me.PnlLScores.Location = New System.Drawing.Point(57, 145)
        Me.PnlLScores.Name = "PnlLScores"
        Me.PnlLScores.Size = New System.Drawing.Size(613, 187)
        Me.PnlLScores.TabIndex = 15
        '
        'LbLegCumulTps
        '
        Me.LbLegCumulTps.AutoSize = True
        Me.LbLegCumulTps.BackColor = System.Drawing.Color.Transparent
        Me.LbLegCumulTps.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LbLegCumulTps.Location = New System.Drawing.Point(556, 121)
        Me.LbLegCumulTps.Name = "LbLegCumulTps"
        Me.LbLegCumulTps.Size = New System.Drawing.Size(129, 21)
        Me.LbLegCumulTps.TabIndex = 20
        Me.LbLegCumulTps.Text = "Cumul Tps de Jeu"
        '
        'LbLegNbParties
        '
        Me.LbLegNbParties.AutoSize = True
        Me.LbLegNbParties.BackColor = System.Drawing.Color.Transparent
        Me.LbLegNbParties.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LbLegNbParties.Location = New System.Drawing.Point(470, 121)
        Me.LbLegNbParties.Name = "LbLegNbParties"
        Me.LbLegNbParties.Size = New System.Drawing.Size(80, 21)
        Me.LbLegNbParties.TabIndex = 19
        Me.LbLegNbParties.Text = "Nb Parties"
        '
        'LbLegTps
        '
        Me.LbLegTps.AutoSize = True
        Me.LbLegTps.BackColor = System.Drawing.Color.Transparent
        Me.LbLegTps.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LbLegTps.Location = New System.Drawing.Point(337, 121)
        Me.LbLegTps.Name = "LbLegTps"
        Me.LbLegTps.Size = New System.Drawing.Size(127, 21)
        Me.LbLegTps.TabIndex = 18
        Me.LbLegTps.Text = "Tps de Recherche"
        '
        'LbLegNbCarr
        '
        Me.LbLegNbCarr.AutoSize = True
        Me.LbLegNbCarr.BackColor = System.Drawing.Color.Transparent
        Me.LbLegNbCarr.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LbLegNbCarr.Location = New System.Drawing.Point(219, 121)
        Me.LbLegNbCarr.Name = "LbLegNbCarr"
        Me.LbLegNbCarr.Size = New System.Drawing.Size(112, 21)
        Me.LbLegNbCarr.TabIndex = 17
        Me.LbLegNbCarr.Text = "Nb Max Carrés"
        '
        'LbLegNoms
        '
        Me.LbLegNoms.AutoSize = True
        Me.LbLegNoms.BackColor = System.Drawing.Color.Transparent
        Me.LbLegNoms.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LbLegNoms.Location = New System.Drawing.Point(128, 121)
        Me.LbLegNoms.Name = "LbLegNoms"
        Me.LbLegNoms.Size = New System.Drawing.Size(47, 21)
        Me.LbLegNoms.TabIndex = 16
        Me.LbLegNoms.Text = "Noms"
        '
        'Form_Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(757, 450)
        Me.Controls.Add(Me.LbLegCumulTps)
        Me.Controls.Add(Me.LbLegNbParties)
        Me.Controls.Add(Me.LbLegTps)
        Me.Controls.Add(Me.LbLegNbCarr)
        Me.Controls.Add(Me.LbLegNoms)
        Me.Controls.Add(Me.PnlLScores)
        Me.Controls.Add(Me.BtnRetA)
        Me.Controls.Add(Me.BtnOrdre)
        Me.Controls.Add(Me.BtnRech)
        Me.Controls.Add(Me.CBBNoms)
        Me.Controls.Add(Me.LblNom)
        Me.Name = "Form_Scores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SCORES"
        Me.PnlLScores.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNom As Label
    Friend WithEvents CBBNoms As ComboBox
    Friend WithEvents BtnRech As Button
    Friend WithEvents BtnOrdre As Button
    Friend WithEvents LBNom As ListBox
    Friend WithEvents LBMaxCarres As ListBox
    Friend WithEvents LBTpsRech As ListBox
    Friend WithEvents LBNbParties As ListBox
    Friend WithEvents LBCumulTps As ListBox
    Friend WithEvents BtnRetA As Button
    Friend WithEvents PnlListes As Panel
    Friend WithEvents LbLegCumulTps As Label
    Friend WithEvents LbLegNbParties As Label
    Friend WithEvents LbLegTps As Label
    Friend WithEvents LbLegNbCarr As Label
    Friend WithEvents LbLegNoms As Label
    Friend WithEvents PnlLScores As Panel
End Class
