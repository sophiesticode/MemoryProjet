Public Class Form_Accueil
    ' Au chargement du formulaire d'accueil
    Private Sub Form_Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNvPartie.Enabled = False
        Form_Param.Form_Param_Load(sender, e)
    End Sub

    Private Sub Form_Accueil_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        ChargerCbboxNoms()
    End Sub

    ' Chargement de la combobox des noms des joueurs déjà inscrits
    Private Sub ChargerCbboxNoms()
        Me.cbbNom.Items.Clear()
        If Not IsNothing(ModuleMemory.GetJoueur(0).nom) Then
            For i As Integer = 0 To ModuleMemory.GetNbJoueurs - 1
                Me.cbbNom.Items.Add(ModuleMemory.GetJoueur(i).nom)
            Next
        End If
    End Sub

    ' Au clic sur Nouvelle Partie
    Private Sub BtnNvPartie_Click(sender As Object, e As EventArgs) Handles btnNvPartie.Click
        Me.Hide()
        Form_Jeu.Show()
    End Sub

    ' A la saisie d'un nom, verification de la saisie
    Private Sub CbbNom_TextChanged(sender As Object, e As EventArgs) Handles cbbNom.KeyPress, cbbNom.TextChanged
        If sender.Text.Length > 2 Then
            btnNvPartie.Enabled = True
        Else
            btnNvPartie.Enabled = False
        End If
    End Sub


    ' Au clic sur Quitter
    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Dim res As MsgBoxResult
        res = MsgBox("Voulez-vous vraiment arrêter l'application ?",
                     MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Confirmation")
        If res = MsgBoxResult.Yes Then
            ModuleMemory.EnregistrerTabFic()
            Me.Close()
        End If
    End Sub

    ' Au clic sur Scores
    Private Sub BtnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        Form_Scores.Show()
        Me.Hide()
    End Sub

    ' Au clic sur Paramètres
    Private Sub BtnParam_Click(sender As Object, e As EventArgs) Handles btnParam.Click
        Form_Param.Show()
        Me.Hide()
    End Sub

    ' Au clic sur Règles du jeu
    Private Sub BtnRegles_Click(sender As Object, e As EventArgs) Handles btnRegles.Click
        Form_Regles.Show()
        Me.Hide()
        Form_Regles.BtnAccueil.Text = "Accueil"
    End Sub

End Class
