Public Class Form_Jeu
    ' Gestion du temps
    Private tpsSecPartie As Integer
    Private tpsAffiche As Temps
    Private tpsMinPartie As Temps

    ' Réglages des cartes
    Private niveau As Integer                    ' Niveau choisi
    Private theme As String
    Private Const NB_CARTES_THEME As Integer = 5 'Nb Cartes différentes par thème
    Private Const NB_CARTES_CARRE As Integer = 4 'Nb Cartes pour un Carre
    Private Const NB_CARTES As Integer = 20      'Nb Cartes au total

    ' Le stockage des cartes dans un tableau
    ' pour y ajouter le booleen dos et la String nomBgImage
    Private cartes(NB_CARTES - 1) As Carte

    ' Gestion des cartes retournées
    Private cartesRet(NB_CARTES_CARRE - 1) As Carte       'Cartes retournees
    Private nbCartesRet As Integer

    ' Gestion des Carrés identifiés
    Private nomsBgCarresId(NB_CARTES_THEME - 1) As String
    Private nbCarresId As Integer = 0
    Private son As Boolean = False

    ' Joueur en cours 
    Private jEnCours As ModuleMemory.Joueur

    ' Structure d'une carte
    Structure Carte
        Dim carte As Label
        Dim dos As Boolean
        Dim bgNomImage As String
    End Structure

    ' Structure d'un temps en minutes secondes
    Structure Temps
        Dim min As Integer
        Dim sec As Integer
    End Structure

    ' Au chargement du jeu, à la première partie
    Private Sub Form_Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetOptionTempsPartie(True, 60)
        SetOptionBtnPause(Form_Param.CHBPause.Checked)
        SetOptionBtnRegles(Form_Param.CHBRegles.Checked)
        SetOptionRecord(Form_Param.CHBRecord.Checked)
        SetTheme(Form_Param.CbbTh.SelectedItem)
        SetNiveau(Form_Param.TBDifficulte.Value)
    End Sub

    ' A chaque nouvelle partie
    Private Sub Form_Jeu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.TxtNom.Text = Form_Accueil.cbbNom.Text
        jEnCours = ModuleMemory.RechercherJoueur(Me.TxtNom.Text)

        ' enregistrement des cartes dans le tableau de cartes
        For j As Integer = 0 To NB_CARTES - 1
            cartes(j).carte = pnlCartes.Controls(j)
        Next
        ' initialisation des cartes
        GenererTheme(theme)
        For i As Integer = 0 To UBound(cartes)
            cartes(i).carte.Enabled = True
            AfficherDosCarte(i, cartes)
        Next
        nbCartesRet = 0
        For i As Integer = 0 To NB_CARTES_CARRE - 1
            cartesRet(i) = Nothing
        Next
        ' Gestion du temps restant
        Chrono.Interval = 1000
        tpsAffiche = ConvertirEnTps(tpsSecPartie)
        If Me.TxtBestTps.Visible Then AfficherBestTps()
        Chrono.Start()
        ' Gestion du temps d'attente
        Attente.Interval = 1000
        Afficher_TpsRestant(sender, e)
    End Sub


    ' Initialisation des cartes avec leur thème
    Private Sub GenererTheme(themeChoisi As String)
        Dim rd As Random = New Random

        Dim cartesDuThemePlacees(NB_CARTES_THEME - 1) As Integer
        ' les cartes n'ont pas encore été déposées,
        ' il y en a 0 par cartes différentes du thème
        For j As Integer = 0 To UBound(cartesDuThemePlacees)
            cartesDuThemePlacees(j) = 0
        Next
        ' numero d'une des 5 cartes du theme
        ' dont 4 copies sont à répartir
        Dim numCTh As Integer
        For i As Integer = 0 To NB_CARTES - 1
            ' une valeur entre 0 et 4
            Do
                numCTh = rd.Next(NB_CARTES_THEME)
            Loop While cartesDuThemePlacees(numCTh) >= (NB_CARTES_CARRE)
            ' si on n'a pas atteint les 4 copies de la carte
            cartes(i).bgNomImage = themeChoisi & niveau & "_" & (numCTh + 1)
            AfficherMotifCarte(i, cartes)
            cartesDuThemePlacees(numCTh) += 1
        Next i
    End Sub

    ' Actions sur les cartes

    ' On récupère les fichiers .png correspondant aux motifs souhaités
    Private Sub AfficherDosCarte(i As Integer, c() As Carte)
        If c(i).carte.Enabled Then
            cartes(i).carte.Image = System.Drawing.Image.FromFile _
                   ("ressources\DosCarte.png")
            cartes(i).dos = True
        End If
    End Sub

    Private Sub AfficherMotifCarte(i As Integer, c() As Carte)
        If c(i).carte.Enabled Then
            cartes(i).carte.Image = System.Drawing.Image.FromFile _
                   ("ressources\" & cartes(i).bgNomImage & ".png")
            cartes(i).dos = False
        End If
    End Sub

    ' Afficher les motifs de toutes les cartes
    Private Sub ToutAfficher()
        For i As Integer = 0 To NB_CARTES - 1
            AfficherMotifCarte(i, cartes)
        Next
    End Sub

    ' Au clic sur une carte, on la retourne
    Private Sub Carte_Click(sender As Object, e As EventArgs) Handles _
        Lbl_c00.Click, Lbl_c01.Click, Lbl_c02.Click, Lbl_c03.Click, Lbl_c04.Click,
        Lbl_c05.Click, Lbl_c06.Click, Lbl_c07.Click, Lbl_c08.Click, Lbl_c09.Click,
        Lbl_c10.Click, Lbl_c11.Click, Lbl_c12.Click, Lbl_c13.Click, Lbl_c14.Click,
        Lbl_c15.Click, Lbl_c16.Click, Lbl_c17.Click, Lbl_c18.Click, Lbl_c19.Click

        Dim i As Integer = Val(sender.name.SubString(5, 2))
        If cartes(i).dos Then
            If nbCartesRet < NB_CARTES_CARRE Then
                If Me.son Then My.Computer.Audio.Play(".\Ressources\sonCarte.wav", AudioPlayMode.Background)
                AfficherMotifCarte(i, cartes)
                cartesRet(nbCartesRet) = cartes(i)
                nbCartesRet += 1
            End If
            ' Si 4 cartes ont été retournées, vérification du carré
            If nbCartesRet = NB_CARTES_CARRE Then
                Attente.Start()
            End If
        End If
    End Sub

    ' Gestion des carrés
    Private Sub GestionCarre(sender As Object, e As EventArgs) Handles Attente.Tick
        If Carre() Then
            If Me.son Then My.Computer.Audio.Play(".\Ressources\sonApp.wav", AudioPlayMode.Background)
            ValiderCarre()
            tpsMinPartie.min = tpsAffiche.min
            tpsMinPartie.sec = tpsAffiche.sec
            For i As Integer = 0 To NB_CARTES_CARRE - 1
                cartesRet(i) = Nothing
            Next
        Else
            ' S'il n'y a pas carré, les cartes sont toutes retournées et la partie continue
            If Me.son Then My.Computer.Audio.Play(".\Ressources\sonGameOver.wav", AudioPlayMode.Background)
            For i As Integer = 0 To NB_CARTES - 1
                AfficherDosCarte(i, cartes)
            Next
        End If
        ' Le compteur de cartes retournées à 0
        nbCartesRet = 0
        Attente.Stop()
    End Sub

    ' Vérification du carré
    Function Carre() As Boolean
        Return (cartesRet(1).bgNomImage = cartesRet(0).bgNomImage) And
               (cartesRet(2).bgNomImage = cartesRet(0).bgNomImage) And
               (cartesRet(3).bgNomImage = cartesRet(0).bgNomImage)
    End Function

    ' Validation du carré
    Private Sub ValiderCarre()
        For i As Integer = 0 To NB_CARTES - 1
            If cartes(i).bgNomImage = cartesRet(0).bgNomImage Then
                cartes(i).carte.Enabled = False
            End If
        Next
        ' Le motif du carré est stocké dans un tableau de carrés identifiés
        nomsBgCarresId(nbCarresId) = cartesRet(0).bgNomImage
        nbCarresId += 1
    End Sub

    ' Quand tout le temps est écoulé ou que tous les carrés ont été identifiés,
    ' fin de partie et affichage des données de celle-ci
    ' après leur enregistrement dans le module
    Private Sub PartieFinie()
        ToutAfficher()
        Dim tpsCarresSec As Integer = tpsSecPartie - (tpsMinPartie.min * 60 + tpsMinPartie.sec)
        Dim tpsMisPartieSec As Integer = tpsSecPartie - (tpsAffiche.min * 60 + tpsAffiche.sec)
        EnregistrerJoueur(tpsCarresSec, tpsMisPartieSec)
        Dim tpsH As Temps = ConvertirEnTps(tpsCarresSec)
        MsgBox("Vous avez identifié " & nbCarresId & " carrés en " &
               FormaterTps(tpsH.min) & "min et " & FormaterTps(tpsH.sec) & "sec", , "Partie finie")
        Me.Hide()
        ' Retourn à l'accueil du jeu
        Form_Accueil.Show()
    End Sub

    'Enegistrement d'un joueur dans le module
    Private Sub EnregistrerJoueur(tpsCarres As Integer, tpsPartie As Integer)
        ' S'il est déjà enregistré
        If IsNothing(jEnCours.nom) Then
            jEnCours.nom = Me.TxtNom.Text
            jEnCours.tpsMin = tpsCarres
            jEnCours.nbParties = 1
            jEnCours.nbMaxCarres = nbCarresId
            jEnCours.cumulTps = tpsPartie
            ModuleMemory.AjouterJoueur(jEnCours)
        Else
            ' S'il est nouveau
            If nbCarresId > jEnCours.nbMaxCarres Then
                jEnCours.nbMaxCarres = nbCarresId
            ElseIf nbCarresId = jEnCours.nbMaxCarres Then
                If (tpsCarres < jEnCours.tpsMin) Then
                    jEnCours.tpsMin = tpsCarres
                End If
            End If
            jEnCours.cumulTps += tpsPartie
            jEnCours.nbParties += 1
            ModuleMemory.ModifierJoueur(jEnCours)
        End If
        ModuleMemory.TrierTabJ()
    End Sub

    ' Gestion du temps
    Private Function TempsEcoule() As Boolean
        Return (tpsAffiche.min * 60 + tpsAffiche.sec) <= 0
    End Function

    ' Conversion au format de la structure temps
    Private Function ConvertirEnTps(tpsSec As Integer) As Temps
        Dim h As Temps
        h.min = tpsSec \ 60
        h.sec = tpsSec Mod 60
        Return h
    End Function

    ' Formatage du temps pour l'affichage sur deux digits
    Private Function FormaterTps(val As Integer) As String
        If (val < 10 And val >= 0) Then Return "0" & val
        Return val
    End Function

    ' Affichage du temps restant et vérification de partie terminée
    Private Sub Afficher_TpsRestant(sender As Object, e As EventArgs) Handles Chrono.Tick
        If tpsAffiche.sec = 0 And (Not tpsAffiche.min = 0) Then
            tpsAffiche.min -= 1
            tpsAffiche.sec = 59
        Else
            tpsAffiche.sec -= 1
        End If
        Me.TxtTpsRestant.Text = FormaterTps(tpsAffiche.min) & " : " & FormaterTps(tpsAffiche.sec)
        If (nbCarresId = NB_CARTES_THEME) Or (TxtTpsRestant.Visible And TempsEcoule()) Then
            Chrono.Stop()
            PartieFinie()
        End If
    End Sub

    ' Affichage du temps complet formaté
    Public Function Afficher_TpsFormate(tpsSec As Integer) As String
        Dim tpsStructure As Temps = ConvertirEnTps(tpsSec)
        Return FormaterTps(tpsStructure.min) & ":" & FormaterTps(tpsStructure.sec)
    End Function

    ' Affichage du record du joueur si l'option est activée
    Private Sub AfficherBestTps()
        If IsNothing(jEnCours.nom) Then
            TxtBestTps.Text = "aucun, tu es nouveau"
        Else
            TxtBestTps.Text = Afficher_TpsFormate(jEnCours.tpsMin)
        End If
    End Sub


    ' Clics sur les boutons

    ' POur abandonner
    Private Sub BtnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        Dim res As MsgBoxResult
        res = MsgBox("Voulez-vous vraiment quitter la partie ?",
                     MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Confirmation")
        If res = MsgBoxResult.Yes Then
            Me.Hide()
            Form_Accueil.Show()
        End If
    End Sub

    ' Pour mettre en pause
    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        If btnPause.Text = "|| Pause" Then
            Chrono.Stop()
            btnPause.Text = "|> Reprise"
        Else
            Chrono.Start()
            btnPause.Text = "|| Pause"
        End If
    End Sub

    ' Pour visualiser les règles du jeu
    Private Sub BtnRegles_Click(sender As Object, e As EventArgs) Handles btnRegles.Click
        ' Le temps n'est plus décompté
        Chrono.Stop()
        Form_Regles.Show()
        Form_Regles.BtnAccueil.Text = "Retour au jeu"
    End Sub

    ' Réglages des paramètres
    Public Sub SetOptionTempsPartie(b As Boolean, v As Integer)
        Me.lblTpsRestant.Visible = b
        Me.TxtTpsRestant.Visible = b
        Me.tpsSecPartie = v
    End Sub
    Public Sub SetOptionSon(b As Boolean)
        Me.son = b
    End Sub
    Public Sub SetOptionRecord(b As Boolean)
        Me.LblBestTps.Visible = b
        Me.TxtBestTps.Visible = b
    End Sub
    Public Sub SetOptionBtnRegles(b As Boolean)
        Me.btnRegles.Visible = b
        Me.btnRegles.Enabled = b
    End Sub

    Public Sub SetOptionBtnPause(b As Boolean)
        Me.btnPause.Visible = b
        Me.btnPause.Enabled = b
    End Sub
    Public Sub SetTheme(th As String)
        Me.theme = th
    End Sub

    Public Sub SetNiveau(n As Integer)
        Me.niveau = n
    End Sub

End Class