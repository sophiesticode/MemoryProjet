<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Param
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Param))
        Me.LbDifficulte = New System.Windows.Forms.Label()
        Me.TBDifficulte = New System.Windows.Forms.TrackBar()
        Me.LBFacile = New System.Windows.Forms.Label()
        Me.LBNormal = New System.Windows.Forms.Label()
        Me.LBDiffcile = New System.Windows.Forms.Label()
        Me.LbTps = New System.Windows.Forms.Label()
        Me.TxtReglageTps = New System.Windows.Forms.TextBox()
        Me.LbSec = New System.Windows.Forms.Label()
        Me.LbTheme = New System.Windows.Forms.Label()
        Me.CbbTh = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RBNon = New System.Windows.Forms.RadioButton()
        Me.RBOui = New System.Windows.Forms.RadioButton()
        Me.CHBSon = New System.Windows.Forms.CheckBox()
        Me.GBAffichage = New System.Windows.Forms.GroupBox()
        Me.CHBRegles = New System.Windows.Forms.CheckBox()
        Me.CHBRecord = New System.Windows.Forms.CheckBox()
        Me.CHBPause = New System.Windows.Forms.CheckBox()
        Me.LblChemin = New System.Windows.Forms.Label()
        Me.TxtChemin = New System.Windows.Forms.TextBox()
        Me.BtnAccueilRet = New System.Windows.Forms.Button()
        CType(Me.TBDifficulte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GBAffichage.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbDifficulte
        '
        Me.LbDifficulte.AutoSize = True
        Me.LbDifficulte.BackColor = System.Drawing.Color.Transparent
        Me.LbDifficulte.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LbDifficulte.Location = New System.Drawing.Point(52, 68)
        Me.LbDifficulte.Name = "LbDifficulte"
        Me.LbDifficulte.Size = New System.Drawing.Size(81, 21)
        Me.LbDifficulte.TabIndex = 0
        Me.LbDifficulte.Text = "Difficulté :"
        '
        'TBDifficulte
        '
        Me.TBDifficulte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TBDifficulte.LargeChange = 1
        Me.TBDifficulte.Location = New System.Drawing.Point(162, 60)
        Me.TBDifficulte.Maximum = 3
        Me.TBDifficulte.Minimum = 1
        Me.TBDifficulte.Name = "TBDifficulte"
        Me.TBDifficulte.Size = New System.Drawing.Size(222, 56)
        Me.TBDifficulte.TabIndex = 1
        Me.TBDifficulte.Value = 1
        '
        'LBFacile
        '
        Me.LBFacile.AutoSize = True
        Me.LBFacile.BackColor = System.Drawing.Color.Transparent
        Me.LBFacile.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LBFacile.Location = New System.Drawing.Point(152, 31)
        Me.LBFacile.Name = "LBFacile"
        Me.LBFacile.Size = New System.Drawing.Size(51, 21)
        Me.LBFacile.TabIndex = 2
        Me.LBFacile.Text = "Facile"
        '
        'LBNormal
        '
        Me.LBNormal.AutoSize = True
        Me.LBNormal.BackColor = System.Drawing.Color.Transparent
        Me.LBNormal.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LBNormal.Location = New System.Drawing.Point(237, 31)
        Me.LBNormal.Name = "LBNormal"
        Me.LBNormal.Size = New System.Drawing.Size(61, 21)
        Me.LBNormal.TabIndex = 3
        Me.LBNormal.Text = "Normal"
        '
        'LBDiffcile
        '
        Me.LBDiffcile.AutoSize = True
        Me.LBDiffcile.BackColor = System.Drawing.Color.Transparent
        Me.LBDiffcile.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LBDiffcile.Location = New System.Drawing.Point(337, 31)
        Me.LBDiffcile.Name = "LBDiffcile"
        Me.LBDiffcile.Size = New System.Drawing.Size(67, 21)
        Me.LBDiffcile.TabIndex = 4
        Me.LBDiffcile.Text = "Difficile"
        '
        'LbTps
        '
        Me.LbTps.AutoSize = True
        Me.LbTps.BackColor = System.Drawing.Color.Transparent
        Me.LbTps.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LbTps.Location = New System.Drawing.Point(56, 143)
        Me.LbTps.Name = "LbTps"
        Me.LbTps.Size = New System.Drawing.Size(103, 21)
        Me.LbTps.TabIndex = 5
        Me.LbTps.Text = "Temps alloué :"
        '
        'TxtReglageTps
        '
        Me.TxtReglageTps.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtReglageTps.Location = New System.Drawing.Point(162, 188)
        Me.TxtReglageTps.Name = "TxtReglageTps"
        Me.TxtReglageTps.Size = New System.Drawing.Size(98, 28)
        Me.TxtReglageTps.TabIndex = 8
        Me.TxtReglageTps.Text = "60"
        Me.TxtReglageTps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LbSec
        '
        Me.LbSec.AutoSize = True
        Me.LbSec.BackColor = System.Drawing.Color.Transparent
        Me.LbSec.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LbSec.Location = New System.Drawing.Point(260, 190)
        Me.LbSec.Name = "LbSec"
        Me.LbSec.Size = New System.Drawing.Size(30, 21)
        Me.LbSec.TabIndex = 9
        Me.LbSec.Text = "sec"
        '
        'LbTheme
        '
        Me.LbTheme.AutoSize = True
        Me.LbTheme.BackColor = System.Drawing.Color.Transparent
        Me.LbTheme.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LbTheme.Location = New System.Drawing.Point(52, 246)
        Me.LbTheme.Name = "LbTheme"
        Me.LbTheme.Size = New System.Drawing.Size(60, 21)
        Me.LbTheme.TabIndex = 10
        Me.LbTheme.Text = "Thème :"
        '
        'CbbTh
        '
        Me.CbbTh.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CbbTh.FormattingEnabled = True
        Me.CbbTh.Location = New System.Drawing.Point(159, 246)
        Me.CbbTh.Name = "CbbTh"
        Me.CbbTh.Size = New System.Drawing.Size(151, 29)
        Me.CbbTh.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.RBNon)
        Me.Panel1.Controls.Add(Me.RBOui)
        Me.Panel1.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel1.Location = New System.Drawing.Point(162, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(221, 49)
        Me.Panel1.TabIndex = 12
        '
        'RBNon
        '
        Me.RBNon.AutoSize = True
        Me.RBNon.Location = New System.Drawing.Point(156, 13)
        Me.RBNon.Name = "RBNon"
        Me.RBNon.Size = New System.Drawing.Size(59, 25)
        Me.RBNon.TabIndex = 9
        Me.RBNon.Text = "Non"
        Me.RBNon.UseVisualStyleBackColor = True
        '
        'RBOui
        '
        Me.RBOui.AutoSize = True
        Me.RBOui.Checked = True
        Me.RBOui.Location = New System.Drawing.Point(13, 14)
        Me.RBOui.Name = "RBOui"
        Me.RBOui.Size = New System.Drawing.Size(59, 25)
        Me.RBOui.TabIndex = 8
        Me.RBOui.TabStop = True
        Me.RBOui.Text = "Oui"
        Me.RBOui.UseVisualStyleBackColor = True
        '
        'CHBSon
        '
        Me.CHBSon.AutoSize = True
        Me.CHBSon.BackColor = System.Drawing.Color.Transparent
        Me.CHBSon.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CHBSon.Location = New System.Drawing.Point(338, 249)
        Me.CHBSon.Name = "CHBSon"
        Me.CHBSon.Size = New System.Drawing.Size(56, 25)
        Me.CHBSon.TabIndex = 13
        Me.CHBSon.Text = "Son"
        Me.CHBSon.UseVisualStyleBackColor = False
        '
        'GBAffichage
        '
        Me.GBAffichage.BackColor = System.Drawing.Color.Transparent
        Me.GBAffichage.Controls.Add(Me.CHBRegles)
        Me.GBAffichage.Controls.Add(Me.CHBRecord)
        Me.GBAffichage.Controls.Add(Me.CHBPause)
        Me.GBAffichage.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GBAffichage.Location = New System.Drawing.Point(36, 296)
        Me.GBAffichage.Name = "GBAffichage"
        Me.GBAffichage.Size = New System.Drawing.Size(432, 74)
        Me.GBAffichage.TabIndex = 14
        Me.GBAffichage.TabStop = False
        Me.GBAffichage.Text = "Boutons optionnels : "
        '
        'CHBRegles
        '
        Me.CHBRegles.AutoSize = True
        Me.CHBRegles.Location = New System.Drawing.Point(301, 35)
        Me.CHBRegles.Name = "CHBRegles"
        Me.CHBRegles.Size = New System.Drawing.Size(122, 25)
        Me.CHBRegles.TabIndex = 2
        Me.CHBRegles.Text = "Règles du jeu"
        Me.CHBRegles.UseVisualStyleBackColor = True
        '
        'CHBRecord
        '
        Me.CHBRecord.AutoSize = True
        Me.CHBRecord.Location = New System.Drawing.Point(162, 35)
        Me.CHBRecord.Name = "CHBRecord"
        Me.CHBRecord.Size = New System.Drawing.Size(80, 25)
        Me.CHBRecord.TabIndex = 1
        Me.CHBRecord.Text = "Record"
        Me.CHBRecord.UseVisualStyleBackColor = True
        '
        'CHBPause
        '
        Me.CHBPause.AutoSize = True
        Me.CHBPause.Location = New System.Drawing.Point(20, 35)
        Me.CHBPause.Name = "CHBPause"
        Me.CHBPause.Size = New System.Drawing.Size(71, 25)
        Me.CHBPause.TabIndex = 0
        Me.CHBPause.Text = "Pause"
        Me.CHBPause.UseVisualStyleBackColor = True
        '
        'LblChemin
        '
        Me.LblChemin.AutoSize = True
        Me.LblChemin.BackColor = System.Drawing.Color.Transparent
        Me.LblChemin.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblChemin.Location = New System.Drawing.Point(81, 385)
        Me.LblChemin.Name = "LblChemin"
        Me.LblChemin.Size = New System.Drawing.Size(129, 21)
        Me.LblChemin.TabIndex = 15
        Me.LblChemin.Text = "Sauvegarde dans :"
        '
        'TxtChemin
        '
        Me.TxtChemin.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtChemin.Location = New System.Drawing.Point(216, 385)
        Me.TxtChemin.Name = "TxtChemin"
        Me.TxtChemin.Size = New System.Drawing.Size(218, 28)
        Me.TxtChemin.TabIndex = 16
        '
        'BtnAccueilRet
        '
        Me.BtnAccueilRet.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAccueilRet.Location = New System.Drawing.Point(196, 435)
        Me.BtnAccueilRet.Name = "BtnAccueilRet"
        Me.BtnAccueilRet.Size = New System.Drawing.Size(94, 51)
        Me.BtnAccueilRet.TabIndex = 17
        Me.BtnAccueilRet.Text = "Retour"
        Me.BtnAccueilRet.UseVisualStyleBackColor = True
        '
        'Form_Param
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(514, 517)
        Me.Controls.Add(Me.BtnAccueilRet)
        Me.Controls.Add(Me.TxtChemin)
        Me.Controls.Add(Me.LblChemin)
        Me.Controls.Add(Me.GBAffichage)
        Me.Controls.Add(Me.CHBSon)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CbbTh)
        Me.Controls.Add(Me.LbTheme)
        Me.Controls.Add(Me.LbSec)
        Me.Controls.Add(Me.TxtReglageTps)
        Me.Controls.Add(Me.LbTps)
        Me.Controls.Add(Me.LBDiffcile)
        Me.Controls.Add(Me.LBNormal)
        Me.Controls.Add(Me.LBFacile)
        Me.Controls.Add(Me.TBDifficulte)
        Me.Controls.Add(Me.LbDifficulte)
        Me.Name = "Form_Param"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PARAMETRES"
        CType(Me.TBDifficulte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GBAffichage.ResumeLayout(False)
        Me.GBAffichage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbDifficulte As Label
    Friend WithEvents TBDifficulte As TrackBar
    Friend WithEvents LBFacile As Label
    Friend WithEvents LBDiffcile As Label
    Friend WithEvents LBNormal As Label
    Friend WithEvents LbTpsAlloue As Label
    Friend WithEvents LbTps As Label
    Friend WithEvents TxtReglageTps As TextBox
    Friend WithEvents LbSec As Label
    Friend WithEvents LbTheme As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CHBSon As CheckBox
    Friend WithEvents GBAffichage As GroupBox
    Friend WithEvents CHBRegles As CheckBox
    Friend WithEvents CHBRecord As CheckBox
    Friend WithEvents CHBPause As CheckBox
    Friend WithEvents LblChemin As Label
    Friend WithEvents TxtChemin As TextBox
    Friend WithEvents CbbTh As ComboBox
    Friend WithEvents RBNon As RadioButton
    Friend WithEvents RBOui As RadioButton
    Friend WithEvents BtnAccueilRet As Button
End Class
