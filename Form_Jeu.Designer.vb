<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Jeu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Jeu))
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblTpsRestant = New System.Windows.Forms.Label()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnAbandon = New System.Windows.Forms.Button()
        Me.btnRegles = New System.Windows.Forms.Button()
        Me.LblBestTps = New System.Windows.Forms.Label()
        Me.Chrono = New System.Windows.Forms.Timer(Me.components)
        Me.TxtTpsRestant = New System.Windows.Forms.Label()
        Me.Attente = New System.Windows.Forms.Timer(Me.components)
        Me.pnlCartes = New System.Windows.Forms.Panel()
        Me.Lbl_c00 = New System.Windows.Forms.Label()
        Me.Lbl_c01 = New System.Windows.Forms.Label()
        Me.Lbl_c02 = New System.Windows.Forms.Label()
        Me.Lbl_c03 = New System.Windows.Forms.Label()
        Me.Lbl_c04 = New System.Windows.Forms.Label()
        Me.Lbl_c05 = New System.Windows.Forms.Label()
        Me.Lbl_c06 = New System.Windows.Forms.Label()
        Me.Lbl_c07 = New System.Windows.Forms.Label()
        Me.Lbl_c08 = New System.Windows.Forms.Label()
        Me.Lbl_c09 = New System.Windows.Forms.Label()
        Me.Lbl_c10 = New System.Windows.Forms.Label()
        Me.Lbl_c11 = New System.Windows.Forms.Label()
        Me.Lbl_c12 = New System.Windows.Forms.Label()
        Me.Lbl_c13 = New System.Windows.Forms.Label()
        Me.Lbl_c14 = New System.Windows.Forms.Label()
        Me.Lbl_c15 = New System.Windows.Forms.Label()
        Me.Lbl_c16 = New System.Windows.Forms.Label()
        Me.Lbl_c17 = New System.Windows.Forms.Label()
        Me.Lbl_c18 = New System.Windows.Forms.Label()
        Me.Lbl_c19 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.Label()
        Me.TxtBestTps = New System.Windows.Forms.Label()
        Me.pnlCartes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.BackColor = System.Drawing.Color.Transparent
        Me.lblNom.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNom.ForeColor = System.Drawing.Color.Black
        Me.lblNom.Location = New System.Drawing.Point(34, 59)
        Me.lblNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(51, 23)
        Me.lblNom.TabIndex = 0
        Me.lblNom.Text = "Nom :"
        '
        'lblTpsRestant
        '
        Me.lblTpsRestant.AutoSize = True
        Me.lblTpsRestant.BackColor = System.Drawing.Color.Transparent
        Me.lblTpsRestant.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTpsRestant.ForeColor = System.Drawing.Color.Black
        Me.lblTpsRestant.Location = New System.Drawing.Point(147, 59)
        Me.lblTpsRestant.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTpsRestant.Name = "lblTpsRestant"
        Me.lblTpsRestant.Size = New System.Drawing.Size(117, 23)
        Me.lblTpsRestant.TabIndex = 1
        Me.lblTpsRestant.Text = "Temps restant :"
        '
        'btnPause
        '
        Me.btnPause.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPause.Location = New System.Drawing.Point(383, 59)
        Me.btnPause.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(94, 44)
        Me.btnPause.TabIndex = 4
        Me.btnPause.Text = "|| Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnAbandon
        '
        Me.btnAbandon.Font = New System.Drawing.Font("Poor Richard", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAbandon.Location = New System.Drawing.Point(496, 59)
        Me.btnAbandon.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAbandon.Name = "btnAbandon"
        Me.btnAbandon.Size = New System.Drawing.Size(117, 44)
        Me.btnAbandon.TabIndex = 5
        Me.btnAbandon.Text = "ABANDON"
        Me.btnAbandon.UseVisualStyleBackColor = True
        '
        'btnRegles
        '
        Me.btnRegles.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegles.Location = New System.Drawing.Point(575, 592)
        Me.btnRegles.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegles.Name = "btnRegles"
        Me.btnRegles.Size = New System.Drawing.Size(38, 44)
        Me.btnRegles.TabIndex = 6
        Me.btnRegles.Text = "?"
        Me.btnRegles.UseVisualStyleBackColor = True
        '
        'LblBestTps
        '
        Me.LblBestTps.AutoSize = True
        Me.LblBestTps.BackColor = System.Drawing.Color.Transparent
        Me.LblBestTps.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblBestTps.ForeColor = System.Drawing.Color.Black
        Me.LblBestTps.Location = New System.Drawing.Point(34, 114)
        Me.LblBestTps.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblBestTps.Name = "LblBestTps"
        Me.LblBestTps.Size = New System.Drawing.Size(227, 23)
        Me.LblBestTps.TabIndex = 7
        Me.LblBestTps.Text = "Meilleur temps de recherche :"
        '
        'Chrono
        '
        '
        'TxtTpsRestant
        '
        Me.TxtTpsRestant.AutoSize = True
        Me.TxtTpsRestant.BackColor = System.Drawing.Color.Transparent
        Me.TxtTpsRestant.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtTpsRestant.ForeColor = System.Drawing.Color.Black
        Me.TxtTpsRestant.Location = New System.Drawing.Point(279, 59)
        Me.TxtTpsRestant.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TxtTpsRestant.Name = "TxtTpsRestant"
        Me.TxtTpsRestant.Size = New System.Drawing.Size(88, 23)
        Me.TxtTpsRestant.TabIndex = 17
        Me.TxtTpsRestant.Text = "tpsRestant"
        '
        'Attente
        '
        '
        'pnlCartes
        '
        Me.pnlCartes.BackColor = System.Drawing.Color.Transparent
        Me.pnlCartes.Controls.Add(Me.Lbl_c00)
        Me.pnlCartes.Controls.Add(Me.Lbl_c01)
        Me.pnlCartes.Controls.Add(Me.Lbl_c02)
        Me.pnlCartes.Controls.Add(Me.Lbl_c03)
        Me.pnlCartes.Controls.Add(Me.Lbl_c04)
        Me.pnlCartes.Controls.Add(Me.Lbl_c05)
        Me.pnlCartes.Controls.Add(Me.Lbl_c06)
        Me.pnlCartes.Controls.Add(Me.Lbl_c07)
        Me.pnlCartes.Controls.Add(Me.Lbl_c08)
        Me.pnlCartes.Controls.Add(Me.Lbl_c09)
        Me.pnlCartes.Controls.Add(Me.Lbl_c10)
        Me.pnlCartes.Controls.Add(Me.Lbl_c11)
        Me.pnlCartes.Controls.Add(Me.Lbl_c12)
        Me.pnlCartes.Controls.Add(Me.Lbl_c13)
        Me.pnlCartes.Controls.Add(Me.Lbl_c14)
        Me.pnlCartes.Controls.Add(Me.Lbl_c15)
        Me.pnlCartes.Controls.Add(Me.Lbl_c16)
        Me.pnlCartes.Controls.Add(Me.Lbl_c17)
        Me.pnlCartes.Controls.Add(Me.Lbl_c18)
        Me.pnlCartes.Controls.Add(Me.Lbl_c19)
        Me.pnlCartes.Location = New System.Drawing.Point(57, 160)
        Me.pnlCartes.Name = "pnlCartes"
        Me.pnlCartes.Size = New System.Drawing.Size(496, 489)
        Me.pnlCartes.TabIndex = 15
        '
        'Lbl_c00
        '
        Me.Lbl_c00.Image = CType(resources.GetObject("Lbl_c00.Image"), System.Drawing.Image)
        Me.Lbl_c00.Location = New System.Drawing.Point(15, 17)
        Me.Lbl_c00.Name = "Lbl_c00"
        Me.Lbl_c00.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c00.TabIndex = 1
        '
        'Lbl_c01
        '
        Me.Lbl_c01.Image = CType(resources.GetObject("Lbl_c01.Image"), System.Drawing.Image)
        Me.Lbl_c01.Location = New System.Drawing.Point(108, 17)
        Me.Lbl_c01.Name = "Lbl_c01"
        Me.Lbl_c01.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c01.TabIndex = 2
        Me.Lbl_c01.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Lbl_c01.UseMnemonic = False
        '
        'Lbl_c02
        '
        Me.Lbl_c02.Image = CType(resources.GetObject("Lbl_c02.Image"), System.Drawing.Image)
        Me.Lbl_c02.Location = New System.Drawing.Point(202, 17)
        Me.Lbl_c02.Name = "Lbl_c02"
        Me.Lbl_c02.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c02.TabIndex = 3
        Me.Lbl_c02.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Lbl_c02.UseMnemonic = False
        '
        'Lbl_c03
        '
        Me.Lbl_c03.Image = CType(resources.GetObject("Lbl_c03.Image"), System.Drawing.Image)
        Me.Lbl_c03.Location = New System.Drawing.Point(297, 17)
        Me.Lbl_c03.Name = "Lbl_c03"
        Me.Lbl_c03.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c03.TabIndex = 4
        Me.Lbl_c03.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Lbl_c03.UseMnemonic = False
        '
        'Lbl_c04
        '
        Me.Lbl_c04.Image = CType(resources.GetObject("Lbl_c04.Image"), System.Drawing.Image)
        Me.Lbl_c04.Location = New System.Drawing.Point(396, 17)
        Me.Lbl_c04.Name = "Lbl_c04"
        Me.Lbl_c04.Size = New System.Drawing.Size(80, 101)
        Me.Lbl_c04.TabIndex = 19
        '
        'Lbl_c05
        '
        Me.Lbl_c05.Image = CType(resources.GetObject("Lbl_c05.Image"), System.Drawing.Image)
        Me.Lbl_c05.Location = New System.Drawing.Point(15, 137)
        Me.Lbl_c05.Name = "Lbl_c05"
        Me.Lbl_c05.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c05.TabIndex = 5
        '
        'Lbl_c06
        '
        Me.Lbl_c06.Image = CType(resources.GetObject("Lbl_c06.Image"), System.Drawing.Image)
        Me.Lbl_c06.Location = New System.Drawing.Point(108, 137)
        Me.Lbl_c06.Name = "Lbl_c06"
        Me.Lbl_c06.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c06.TabIndex = 6
        Me.Lbl_c06.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Lbl_c06.UseMnemonic = False
        '
        'Lbl_c07
        '
        Me.Lbl_c07.Image = CType(resources.GetObject("Lbl_c07.Image"), System.Drawing.Image)
        Me.Lbl_c07.Location = New System.Drawing.Point(202, 137)
        Me.Lbl_c07.Name = "Lbl_c07"
        Me.Lbl_c07.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c07.TabIndex = 7
        Me.Lbl_c07.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Lbl_c07.UseMnemonic = False
        '
        'Lbl_c08
        '
        Me.Lbl_c08.Image = CType(resources.GetObject("Lbl_c08.Image"), System.Drawing.Image)
        Me.Lbl_c08.Location = New System.Drawing.Point(297, 137)
        Me.Lbl_c08.Name = "Lbl_c08"
        Me.Lbl_c08.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c08.TabIndex = 8
        Me.Lbl_c08.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Lbl_c08.UseMnemonic = False
        '
        'Lbl_c09
        '
        Me.Lbl_c09.Image = CType(resources.GetObject("Lbl_c09.Image"), System.Drawing.Image)
        Me.Lbl_c09.Location = New System.Drawing.Point(398, 137)
        Me.Lbl_c09.Name = "Lbl_c09"
        Me.Lbl_c09.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c09.TabIndex = 18
        '
        'Lbl_c10
        '
        Me.Lbl_c10.Image = CType(resources.GetObject("Lbl_c10.Image"), System.Drawing.Image)
        Me.Lbl_c10.Location = New System.Drawing.Point(15, 258)
        Me.Lbl_c10.Name = "Lbl_c10"
        Me.Lbl_c10.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c10.TabIndex = 9
        '
        'Lbl_c11
        '
        Me.Lbl_c11.Image = CType(resources.GetObject("Lbl_c11.Image"), System.Drawing.Image)
        Me.Lbl_c11.Location = New System.Drawing.Point(108, 258)
        Me.Lbl_c11.Name = "Lbl_c11"
        Me.Lbl_c11.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c11.TabIndex = 10
        Me.Lbl_c11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Lbl_c11.UseMnemonic = False
        '
        'Lbl_c12
        '
        Me.Lbl_c12.Image = CType(resources.GetObject("Lbl_c12.Image"), System.Drawing.Image)
        Me.Lbl_c12.Location = New System.Drawing.Point(202, 258)
        Me.Lbl_c12.Name = "Lbl_c12"
        Me.Lbl_c12.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c12.TabIndex = 11
        Me.Lbl_c12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Lbl_c12.UseMnemonic = False
        '
        'Lbl_c13
        '
        Me.Lbl_c13.Image = CType(resources.GetObject("Lbl_c13.Image"), System.Drawing.Image)
        Me.Lbl_c13.Location = New System.Drawing.Point(297, 258)
        Me.Lbl_c13.Name = "Lbl_c13"
        Me.Lbl_c13.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c13.TabIndex = 12
        Me.Lbl_c13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Lbl_c13.UseMnemonic = False
        '
        'Lbl_c14
        '
        Me.Lbl_c14.Image = CType(resources.GetObject("Lbl_c14.Image"), System.Drawing.Image)
        Me.Lbl_c14.Location = New System.Drawing.Point(398, 258)
        Me.Lbl_c14.Name = "Lbl_c14"
        Me.Lbl_c14.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c14.TabIndex = 17
        '
        'Lbl_c15
        '
        Me.Lbl_c15.Image = CType(resources.GetObject("Lbl_c15.Image"), System.Drawing.Image)
        Me.Lbl_c15.Location = New System.Drawing.Point(15, 375)
        Me.Lbl_c15.Name = "Lbl_c15"
        Me.Lbl_c15.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c15.TabIndex = 13
        '
        'Lbl_c16
        '
        Me.Lbl_c16.Image = CType(resources.GetObject("Lbl_c16.Image"), System.Drawing.Image)
        Me.Lbl_c16.Location = New System.Drawing.Point(108, 375)
        Me.Lbl_c16.Name = "Lbl_c16"
        Me.Lbl_c16.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c16.TabIndex = 14
        Me.Lbl_c16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Lbl_c16.UseMnemonic = False
        '
        'Lbl_c17
        '
        Me.Lbl_c17.Image = CType(resources.GetObject("Lbl_c17.Image"), System.Drawing.Image)
        Me.Lbl_c17.Location = New System.Drawing.Point(202, 375)
        Me.Lbl_c17.Name = "Lbl_c17"
        Me.Lbl_c17.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c17.TabIndex = 15
        Me.Lbl_c17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Lbl_c17.UseMnemonic = False
        '
        'Lbl_c18
        '
        Me.Lbl_c18.Image = CType(resources.GetObject("Lbl_c18.Image"), System.Drawing.Image)
        Me.Lbl_c18.Location = New System.Drawing.Point(297, 375)
        Me.Lbl_c18.Name = "Lbl_c18"
        Me.Lbl_c18.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c18.TabIndex = 16
        Me.Lbl_c18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Lbl_c18.UseMnemonic = False
        '
        'Lbl_c19
        '
        Me.Lbl_c19.Image = CType(resources.GetObject("Lbl_c19.Image"), System.Drawing.Image)
        Me.Lbl_c19.Location = New System.Drawing.Point(398, 376)
        Me.Lbl_c19.Name = "Lbl_c19"
        Me.Lbl_c19.Size = New System.Drawing.Size(78, 101)
        Me.Lbl_c19.TabIndex = 0
        '
        'TxtNom
        '
        Me.TxtNom.AutoSize = True
        Me.TxtNom.BackColor = System.Drawing.Color.Transparent
        Me.TxtNom.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtNom.ForeColor = System.Drawing.Color.Black
        Me.TxtNom.Location = New System.Drawing.Point(84, 59)
        Me.TxtNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(42, 23)
        Me.TxtNom.TabIndex = 18
        Me.TxtNom.Text = "nom"
        '
        'TxtBestTps
        '
        Me.TxtBestTps.AutoSize = True
        Me.TxtBestTps.BackColor = System.Drawing.Color.Transparent
        Me.TxtBestTps.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtBestTps.ForeColor = System.Drawing.Color.Black
        Me.TxtBestTps.Location = New System.Drawing.Point(261, 114)
        Me.TxtBestTps.Name = "TxtBestTps"
        Me.TxtBestTps.Size = New System.Drawing.Size(66, 23)
        Me.TxtBestTps.TabIndex = 19
        Me.TxtBestTps.Text = "bestTps"
        '
        'Form_Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(649, 678)
        Me.Controls.Add(Me.TxtBestTps)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.TxtTpsRestant)
        Me.Controls.Add(Me.pnlCartes)
        Me.Controls.Add(Me.LblBestTps)
        Me.Controls.Add(Me.btnRegles)
        Me.Controls.Add(Me.btnAbandon)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.lblTpsRestant)
        Me.Controls.Add(Me.lblNom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form_Jeu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MEMORY"
        Me.pnlCartes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNom As Label
    Friend WithEvents lblTpsRestant As Label
    Friend WithEvents btnPause As Button
    Friend WithEvents btnAbandon As Button
    Friend WithEvents btnRegles As Button
    Friend WithEvents LblBestTps As Label
    Friend WithEvents Chrono As Timer
    Friend WithEvents Attente As Timer
    Friend WithEvents pnlCartes As Panel
    Friend WithEvents Lbl_c01 As Label
    Friend WithEvents Lbl_c00 As Label
    Friend WithEvents Lbl_c18 As Label
    Friend WithEvents Lbl_c17 As Label
    Friend WithEvents Lbl_c16 As Label
    Friend WithEvents Lbl_c15 As Label
    Friend WithEvents Lbl_c13 As Label
    Friend WithEvents Lbl_c12 As Label
    Friend WithEvents Lbl_c11 As Label
    Friend WithEvents Lbl_c10 As Label
    Friend WithEvents Lbl_c08 As Label
    Friend WithEvents Lbl_c07 As Label
    Friend WithEvents Lbl_c06 As Label
    Friend WithEvents Lbl_c05 As Label
    Friend WithEvents Lbl_c03 As Label
    Friend WithEvents Lbl_c02 As Label
    Friend WithEvents Lbl_c04 As Label
    Friend WithEvents Lbl_c09 As Label
    Friend WithEvents Lbl_c14 As Label
    Friend WithEvents Lbl_c45 As Label
    Friend WithEvents TxtNom As Label
    Friend WithEvents TxtTpsRestant As Label
    Friend WithEvents Lbl_c19 As Label
    Friend WithEvents TxtBestTps As Label
End Class
