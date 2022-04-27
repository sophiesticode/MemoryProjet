Public Class Form_Param
    ' Le tableau des thèmes possibles par l'application pour les cartes du jeu
    Private tabTh() As String = {"Animaux", "Fleurs", "Nourriture"}

    ' Au chargement du formulaire, la combobox du thème
    ' est initialisée et réglée au thème "Animaux"
    Public Sub Form_Param_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CbbTh.Items.Clear()
        For i As Integer = 0 To UBound(tabTh)
            Me.CbbTh.Items.Add(tabTh(i))
        Next
        Me.CbbTh.SelectedIndex = 0
    End Sub

    ' Au changement de niveau sélectionné
    Private Sub TBDifficulte_Scroll(sender As Object, e As EventArgs) Handles TBDifficulte.Scroll
        Form_Jeu.SetNiveau(TBDifficulte.Value)
    End Sub

    ' Si l'option de temps limite est modifiée
    ' Ce réglage est modifié dans le formulaire de jeu
    Private Sub CHBOui_CheckedChanged(sender As Object, e As EventArgs) Handles _
            RBNon.CheckedChanged, RBOui.CheckedChanged
        If RBOui.Checked Then
            TxtReglageTps.Enabled = True
            TxtReglageTps_TextChanged(sender, e)
        Else
            TxtReglageTps.Enabled = False
            Form_Jeu.SetOptionTempsPartie(False, 0)
        End If
    End Sub
    Private Sub TxtReglageTps_TextChanged(sender As Object, e As EventArgs) Handles TxtReglageTps.TextChanged
        Form_Jeu.SetOptionTempsPartie(True, Val(TxtReglageTps.Text))
    End Sub

    ' Si une nouvelle valeur de temps limite est saisie,
    ' ce doit être un caractère numérique ou un retour arrière
    Private Sub TxtReglageTps_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtReglageTps.KeyPress
        If Not (e.KeyChar = vbBack) And Not IsNumeric(e.KeyChar) Then e.Handled = True
    End Sub

    ' Pour modifier l'option de son
    Private Sub CHBSon_CheckedChanged(sender As Object, e As EventArgs) Handles CHBSon.CheckedChanged
        Form_Jeu.SetOptionSon(CHBSon.Checked)
    End Sub

    ' Pour modifier l'option de bouton Pause
    Private Sub CHBPause_CheckedChanged(sender As Object, e As EventArgs) Handles CHBPause.CheckedChanged
        Form_Jeu.SetOptionBtnPause(CHBPause.Checked)
    End Sub

    ' Pour modifier l'option de bouton Règles du jeu
    Private Sub CHBRegles_CheckedChanged(sender As Object, e As EventArgs) Handles CHBRegles.CheckedChanged
        Form_Jeu.SetOptionBtnRegles(CHBPause.Checked)
    End Sub

    ' Pour modifier l'option d' Affichage du record du joueur
    Private Sub BtnRecord_CheckedChanged(sender As Object, e As EventArgs) Handles CHBRecord.CheckedChanged
        Form_Jeu.SetOptionRecord(CHBRecord.Checked)
    End Sub

    ' Pour modifier le chemin d'enregistrement du fichier de données de joueurs inscrits
    Private Sub TxtChemin_TextChanged(sender As Object, e As EventArgs) Handles TxtChemin.TextChanged
        ModuleMemory.SetChemin(TxtChemin.Text)
    End Sub

    ' Si le thème est modifié
    Private Sub CbbTh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbbTh.SelectedIndexChanged
        Form_Jeu.SetTheme(CbbTh.SelectedItem)
    End Sub

    ' Pour retourner à l'accueil
    Private Sub BtnAccueilRet_Click(sender As Object, e As EventArgs) Handles BtnAccueilRet.Click
        Me.Hide()
        Form_Accueil.Show()
    End Sub
End Class