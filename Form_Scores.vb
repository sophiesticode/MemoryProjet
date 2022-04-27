Public Class Form_Scores
    Dim idJSelec As Integer = 0

    ' Chargement de la combobox de noms des utilisateurs inscrits
    Private Sub ChargerCBBEtLB(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Dim j As Joueur

        ' Si au moins un joueur est inscrit,
        ' chargement de la combobox
        If Not IsNothing(ModuleMemory.GetJoueur(0).nom) Then
            For i As Integer = 0 To ModuleMemory.GetNbJoueurs - 1
                j = ModuleMemory.GetJoueur(i)
                Me.CBBNoms.Items.Add(j.nom)
                LBNom.Items.Add(j.nom)
                LBMaxCarres.Items.Add(j.nbMaxCarres)
                LBTpsRech.Items.Add(Form_Jeu.Afficher_TpsFormate(j.tpsMin))
                LBNbParties.Items.Add(j.nbParties)
                LBCumulTps.Items.Add(Form_Jeu.Afficher_TpsFormate(j.cumulTps))
            Next
        End If
    End Sub

    ' Si l'on sélectionne une valeur dans une des listes (combobox et listbox)
    ' toutes les listes sont synchronisée sur le même joueur
    Private Sub Liste_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBNoms.SelectedIndexChanged,
            LBNom.SelectedIndexChanged, LBMaxCarres.SelectedIndexChanged, LBTpsRech.SelectedIndexChanged,
            LBNbParties.SelectedIndexChanged, LBCumulTps.SelectedIndexChanged
        idJSelec = sender.SelectedIndex
        For i As Integer = 0 To PnlLScores.Controls.Count - 1
            Dim liste As Object = PnlLScores.Controls(i)
            liste.SelectedIndex = idJSelec
        Next
        CBBNoms.SelectedIndex = idJSelec
    End Sub

    ' Modification de l'ordre d'affichage de tout le formulaire
    Private Sub BtnOrdre_Click(sender As Object, e As EventArgs) Handles BtnOrdre.Click
        Dim nomJ As String = ""
        If Not IsNothing(CBBNoms.SelectedItem) Then nomJ = CBBNoms.SelectedItem
        InverserListe(CBBNoms)
        If Not IsNothing(CBBNoms.SelectedIndex) Then
            CBBNoms.SelectedIndex = CBBNoms.Items.IndexOf(nomJ)
            idJSelec = CBBNoms.SelectedIndex
        End If

        For i As Integer = 0 To PnlLScores.Controls.Count - 1
            Dim liste As Object = PnlLScores.Controls(i)
            InverserListe(liste)
            liste.SelectedIndex = idJSelec
        Next
        ' Modification de l'apparence du bouton
        If BtnOrdre.Text = "=> Ordre décroissant" Then
            BtnOrdre.Text = "=> Ordre croissant"
        Else
            BtnOrdre.Text = "=> Ordre décroissant"
        End If
    End Sub

    ' Fonction pour inverser la liste
    Private Sub InverserListe(liste As Object)
        Dim listeCachee As Object = New Object
        If TypeOf (liste) Is ListBox Then
            listeCachee = New ListBox
        ElseIf TypeOf (liste) Is ComboBox Then
            listeCachee = New ComboBox
        End If

        For i = 0 To liste.Items.Count - 1
            listeCachee.Items.Add(liste.Items(i))
        Next

        liste.Items.Clear()
        liste.Sorted = False
        liste.Visible = False

        Dim dernier As Integer = listeCachee.Items.Count - 1
        For i = dernier To 0 Step -1
            liste.Items.Add(listeCachee.Items(i))
        Next

        liste.Visible = True
    End Sub

    ' Affichage d'une fenêtre indiquant les données du joueur sélectionné
    ' si clic sur Rechercher
    Private Sub BtnRech_Click(sender As Object, e As EventArgs) Handles BtnRech.Click
        If Not CBBNoms.SelectedItem = "" Then
            MsgBox("meilleur score : " & LBMaxCarres.SelectedItem & " carrés en " &
               LBTpsRech.SelectedItem & "min" & vbCrLf & "nbParties : " & LBNbParties.SelectedItem &
               vbCrLf & "temps de jeu : " & LBCumulTps.SelectedItem & "s", , LBNom.SelectedItem)
        End If
    End Sub

    ' Pour retourner à l'accueil
    Private Sub BtnRetA_Click(sender As Object, e As EventArgs) Handles BtnRetA.Click
        Me.Close()
        Form_Accueil.Show()
    End Sub
End Class