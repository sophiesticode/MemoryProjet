Module ModuleMemory
    Dim TabJoueurs() As Joueur
    Dim nbJoueurs As Integer
    Dim cheminFic As String = ""
    ' Un Joueur
    Public Structure Joueur
        Public nom As String
        Public nbMaxCarres As Integer
        Public tpsMin As Integer
        Public nbParties As Integer
        Public cumulTps As Integer
    End Structure

    ' Programme principal
    Sub Main()
        ' Initialisation du tableau
        ChargerTabJoueurs()
        TrierTabJ()

        ' Démarrage de l'application
        Application.Run(Form_Accueil)
    End Sub

    ' Ajouter un joueur
    Public Sub AjouterJoueur(j As Joueur)
        ReDim Preserve TabJoueurs(nbJoueurs)
        TabJoueurs(nbJoueurs) = j
        nbJoueurs += 1
    End Sub

    Public Sub ModifierJoueur(j As Joueur)
        Dim i As Integer = ChercherIndiceJ(j.nom)
        TabJoueurs(i) = j
    End Sub

    ' Réglage du chemin du fichier enregistrant les joueurs
    Public Sub SetChemin(ch As String)
        Dim numC As Integer = FreeFile()
        FileOpen(numC, "cheminFic.txt", OpenMode.Output)
        WriteLine(numC, ch)
        FileClose(numC)
    End Sub

    Public Sub LireChemin()
        Dim numC As Integer = FreeFile()
        FileOpen(numC, "cheminFic.txt", OpenMode.Input)
        Input(numC, cheminFic)
        FileClose(numC)
    End Sub

    ' Nombre de joueurs
    Public Function GetNbJoueurs() As Integer
        Return nbJoueurs
    End Function

    ' Obtenir un joueur
    Public Function GetJoueur(i As Integer) As Joueur
        Return TabJoueurs(i)
    End Function

    Public Function RechercherJoueur(nom As String) As Joueur
        Dim i As Integer = ChercherIndiceJ(nom)
        If i >= 0 Then Return TabJoueurs(i)
        Return Nothing
    End Function

    Public Function ChercherIndiceJ(nomJ As String) As Integer
        For i As Integer = 0 To UBound(TabJoueurs)
            If GetJoueur(i).nom = nomJ Then Return i
        Next
        Return -1
    End Function

    ' Chaine correspondant aux données du joueur i
    Public Function AfficherJoueur(i As Integer) As String
        Return TabJoueurs(i).nom & " " & TabJoueurs(i).nbMaxCarres _
         & " " & TabJoueurs(i).tpsMin & " " & TabJoueurs(i).nbParties _
         & " " & TabJoueurs(i).cumulTps
    End Function

    ' Enregistrement dans fichier texte du joueur i
    Sub EnregistrerTabFic()
        LireChemin()
        Dim numJ As Integer = FreeFile()
        FileOpen(numJ, cheminFic & "Joueurs.txt", OpenMode.Output)
        For i As Integer = 0 To UBound(TabJoueurs)
            WriteLine(numJ, AfficherJoueur(i))
        Next
        FileClose(numJ)
    End Sub

    Private Sub ChargerTabJoueurs()
        Dim s() As String
        Dim donneesJ As String = ""
        Dim num As Integer = FreeFile()
        Dim j As Joueur
        FileOpen(num, cheminFic & "Joueurs.txt", OpenMode.Input)
        Do Until EOF(num)
            Input(num, donneesJ)
            s = donneesJ.Split(" ")
            j.nom = s(0)
            j.nbMaxCarres = Val(s(1))
            j.tpsMin = Val(s(2))
            j.nbParties = Val(s(3))
            j.cumulTps = Val(s(4))
            AjouterJoueur(j)
        Loop
        FileClose(num)
    End Sub

    Public Sub TrierTabJ()
        For i As Integer = 0 To UBound(TabJoueurs)
            For j As Integer = i + 1 To UBound(TabJoueurs)
                If TabJoueurs(j).nbMaxCarres < TabJoueurs(i).nbMaxCarres Then
                    EchangerJoueurs(i, j)
                End If
                If TabJoueurs(j).nbMaxCarres = TabJoueurs(i).nbMaxCarres And
                    TabJoueurs(j).tpsMin < TabJoueurs(i).tpsMin Then
                    EchangerJoueurs(i, j)
                End If
            Next
        Next
    End Sub

    Private Sub EchangerJoueurs(indice1 As Integer, Indice2 As Integer)
        Dim tmp As Joueur = TabJoueurs(indice1)
        TabJoueurs(indice1) = TabJoueurs(Indice2)
        TabJoueurs(Indice2) = tmp
    End Sub

End Module
