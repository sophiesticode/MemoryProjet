Public Class Form_Regles

    ' Au chargement du formulaire de Règles du Jeu, le texte est initialisé
    Private Sub Form_Regles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtRegles.Text = "Le jeu se compose de 20 cartes disposées aléatoirement face contre le plateau." _
            & vbCrLf & "Un carré est un ensemble de 4 cartes identiques." & vbCrLf _
            & "L'objectif du jeu est d'identifier un maximum de 5 carrés." & vbCrLf _
            & "Le nombre de carrés et le temps sont comptés." & vbCrLf & "Les joueurs ex-aequo sur leur nombre maximal 
            de carrés identifiés seront classés selon le temps qu'ils auront mis à les trouver." & vbCrLf _
            & "Soyez réactifs, le temps court !"
    End Sub

    ' POur retourner à l'accueil
    Private Sub BtnAccueil_Click(sender As Object, e As EventArgs) Handles BtnAccueil.Click
        If sender.Text = "Accueil" Then
            Form_Accueil.Show()
        Else
            Form_Jeu.Chrono.Start()
        End If
        Me.Hide()
    End Sub
End Class