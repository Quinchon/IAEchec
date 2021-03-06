﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processAI2
{
    public class FonctionsIA
    {




        //Constructeur
        public FonctionsIA()
        {
        }


        //***********************
        //*********************** FONCTIONS ************************
        //***********************

        // Liste les plateaux possibles a partir du plateau courant
        public List<int[]> DeduitListePlateau(int[] plateau, List<int> mesPieces)
        {
            List<int[]> listePlateau = new List<int[]>();

            // Pour chacune des pieces de l'IA
            foreach (int piece in mesPieces)
            {
                List<int> listeDeplacementPossible = DeduitDeplacementPossible(piece, plateau);

                // Pour chacun des deplacements possibles de la piece en question
                foreach (int deplacement in listeDeplacementPossible)
                {
                    listePlateau.Add(DeduitPlateau(piece, deplacement, plateau));
                }
            }

            return listePlateau;

        }

        // Determine les deplacement possibles pour une piece
        public List<int> DeduitDeplacementPossible(int piece, int[] plateau)
        {
            List<int> listeDepl = new List<int>();
            int trait = 0;

            // Cas blancs
            if (plateau[piece] > 0)
            {
                trait = 1;
            }
            // Cas noirs
            if (plateau[piece] < 0)
            {
                trait = -1;
            }


            // Sert à sortir d'une la boucle si on arrive sur une autre piece
            bool stop = false;
            // Sert à avancer et tester les cases suivantes
            int facteur = 1;

            switch (Math.Abs(plateau[piece]))
            {
                case 1: //////////************ Cas pion *************///////////////

                    // Cas pion n'a pas encore bougé
                    if (((piece >= 8) && (piece <= 15) && trait == -1) || ((piece >= 48) && (piece <= 55) && trait == 1))
                    {
                        // Une case devant
                        if (plateau[piece + (8 * -trait)] == 0)
                        {
                            listeDepl.Add(piece + (8 * -trait));

                            // Deux cases devant
                            if (plateau[piece + (16 * -trait)] == 0)
                            {
                                listeDepl.Add(piece + (16 * -trait));
                            }
                        }
                    }
                    else
                    {
                        // Une case devant
                        if (piece + (8 * -trait) > 0 || piece + (8 * -trait) < 63)
                        {
                            if (plateau[piece + (8 * -trait)] == 0)
                            {
                                listeDepl.Add(piece + (8 * -trait));
                            }
                        }

                    }

                    // En diagonale
                    // Si sur bord gauche
                    if (piece % 8 == 0)
                    {
                        if (plateau[piece + -trait * (8 - trait)] * trait < 0)
                        {
                            listeDepl.Add(piece + -trait * (8 - trait));
                        }
                    }
                    // Si sur bord droit
                    if (piece % 8 == 7)
                    {
                        if (plateau[piece + -trait * (8 + trait)] * trait < 0)
                        {
                            listeDepl.Add(piece + -trait * (8 + trait));
                        }
                    }
                    // Si sur aucun bord
                    if (piece % 8 != 0 && piece % 8 != 7)
                    {
                        if (plateau[piece + -trait * (8 - trait)] * trait < 0)
                        {
                            listeDepl.Add(piece + -trait * (8 - trait));
                        }
                        if (plateau[piece + -trait * (8 + trait)] * trait < 0)
                        {
                            listeDepl.Add(piece + -trait * (8 + trait));
                        }
                    }
                    break;

                case 21: //////////************ Cas tour *************///////////////
                case 22: // cas tour

                    // Sert à sortir de la boucle si on arrive sur une autre piece
                    stop = false;
                    // Sert à avancer et tester les cases suivantes
                    facteur = 1;

                    // Cas tour descend
                    while (piece + 8 * facteur <= 63 && !stop)
                    {
                        if (plateau[piece + 8 * facteur] == 0)
                        {
                            listeDepl.Add(piece + 8 * facteur);
                        }
                        if (plateau[piece + 8 * facteur] * trait < 0)
                        {
                            listeDepl.Add(piece + 8 * facteur);
                            stop = true;
                        }
                        if (plateau[piece + 8 * facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }

                    // Cas tour monte
                    facteur = 1;
                    stop = false;
                    while (piece - 8 * facteur >= 0 && !stop)
                    {
                        if (plateau[piece - 8 * facteur] == 0)
                        {
                            listeDepl.Add(piece - 8 * facteur);
                        }
                        if (plateau[piece - 8 * facteur] * trait < 0)
                        {
                            listeDepl.Add(piece - 8 * facteur);
                            stop = true;
                        }
                        if (plateau[piece - 8 * facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }

                    // Cas à droite
                    facteur = 1;
                    stop = false;
                    while (piece % 8 + facteur < 8 && !stop)
                    {
                        if (plateau[piece + facteur] == 0)
                        {
                            listeDepl.Add(piece + facteur);
                        }
                        if (plateau[piece + facteur] * trait < 0)
                        {
                            listeDepl.Add(piece + facteur);
                            stop = true;
                        }
                        if (plateau[piece + facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }

                    // Cas à gauche
                    facteur = 1;
                    stop = false;
                    while (piece % 8 - facteur > -1 && !stop)
                    {
                        if (plateau[piece - facteur] == 0)
                        {
                            listeDepl.Add(piece - facteur);
                        }
                        if (plateau[piece - facteur] * trait < 0)
                        {
                            listeDepl.Add(piece - facteur);
                            stop = true;
                        }
                        if (plateau[piece - facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }

                    break;


                case 4: //////////************ Cas fou *************///////////////

                    // Sert à sortir de la boucle si on arrive sur une autre piece
                    stop = false;
                    // Sert à avancer et tester les cases suivantes
                    facteur = 1;

                    // Cas fou descend droite
                    while ((piece % 8 + facteur < 8) && (piece + 9 * facteur <= 63) && !stop)
                    {
                        if (plateau[piece + 9 * facteur] == 0)
                        {
                            listeDepl.Add(piece + 9 * facteur);
                        }
                        if (plateau[piece + 9 * facteur] * trait < 0)
                        {
                            listeDepl.Add(piece + 9 * facteur);
                            stop = true;
                        }
                        if (plateau[piece + 9 * facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }

                    // Cas fou descend gauche
                    stop = false;
                    facteur = 1;
                    while ((piece % 8 - facteur > -1) && (piece + 7 * facteur < 63) && !stop)
                    {
                        if (plateau[piece + 7 * facteur] == 0)
                        {
                            listeDepl.Add(piece + 7 * facteur);
                        }
                        if (plateau[piece + 7 * facteur] * trait < 0)
                        {
                            listeDepl.Add(piece + 7 * facteur);
                            stop = true;
                        }
                        if (plateau[piece + 7 * facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }

                    // Cas fou monte droite
                    stop = false;
                    facteur = 1;
                    while ((piece % 8 + facteur < 8) && (piece - 7 * facteur > 0) && !stop)
                    {
                        if (plateau[piece - 7 * facteur] == 0)
                        {
                            listeDepl.Add(piece - 7 * facteur);
                        }
                        if (plateau[piece - 7 * facteur] * trait < 0)
                        {
                            listeDepl.Add(piece - 7 * facteur);
                            stop = true;
                        }
                        if (plateau[piece - 7 * facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }

                    // Cas fou monte gauche
                    stop = false;
                    facteur = 1;
                    while ((piece % 8 - facteur > -1) && (piece - 9 * facteur >= 0) && !stop)
                    {
                        if (plateau[piece - 9 * facteur] == 0)
                        {
                            listeDepl.Add(piece - 9 * facteur);
                        }
                        if (plateau[piece - 9 * facteur] * trait < 0)
                        {
                            listeDepl.Add(piece - 9 * facteur);
                            stop = true;
                        }
                        if (plateau[piece - 9 * facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }

                    break;
                case 31: //////////************ Cas cavalier *************///////////////
                case 32: // Cas cavalier

                    // Cas gauche
                    // Cas haut
                    if ((piece % 8 - 2 > -1) && (piece - 10 >= 0))
                    {
                        if (plateau[piece - 10] == 0)
                        {
                            listeDepl.Add(piece - 10);
                        }
                        if (plateau[piece - 10] * trait < 0)
                        {
                            listeDepl.Add(piece - 10);
                        }
                    }
                    if ((piece % 8 - 1 > -1) && (piece - 17 >= 0))
                    {
                        if (plateau[piece - 17] == 0)
                        {
                            listeDepl.Add(piece - 17);
                        }
                        if (plateau[piece - 17] * trait < 0)
                        {
                            listeDepl.Add(piece - 17);
                        }
                    }
                    // Cas bas
                    if ((piece % 8 - 2 > -1) && (piece + 6 <= 63))
                    {
                        if (plateau[piece + 6] == 0)
                        {
                            listeDepl.Add(piece + 6);
                        }
                        if (plateau[piece + 6] * trait < 0)
                        {
                            listeDepl.Add(piece + 6);
                        }
                    }
                    if ((piece % 8 - 1 > -1) && (piece + 15 <= 63))
                    {
                        if (plateau[piece + 15] == 0)
                        {
                            listeDepl.Add(piece + 15);
                        }
                        if (plateau[piece + 15] * trait < 0)
                        {
                            listeDepl.Add(piece + 15);
                        }
                    }

                    // Cas droit
                    // Cas bas
                    if ((piece % 8 + 2 < 8) && (piece + 10 <= 63))
                    {
                        if (plateau[piece + 10] == 0)
                        {
                            listeDepl.Add(piece + 10);
                        }
                        if (plateau[piece + 10] * trait < 0)
                        {
                            listeDepl.Add(piece + 10);
                        }
                    }
                    if ((piece % 8 + 1 < 8) && (piece + 17 <= 63))
                    {
                        if (plateau[piece + 17] == 0)
                        {
                            listeDepl.Add(piece + 17);
                        }
                        if (plateau[piece + 17] * trait < 0)
                        {
                            listeDepl.Add(piece + 17);
                        }
                    }
                    // Cas haut
                    if ((piece % 8 + 2 < 8) && (piece - 6 >= 0))
                    {
                        if (plateau[piece - 6] == 0)
                        {
                            listeDepl.Add(piece - 6);
                        }
                        if (plateau[piece - 6] * trait < 0)
                        {
                            listeDepl.Add(piece - 6);
                        }
                    }
                    if ((piece % 8 + 1 < 8) && (piece - 15 >= 0))
                    {
                        if (plateau[piece - 15] == 0)
                        {
                            listeDepl.Add(piece - 15);
                        }
                        if (plateau[piece - 15] * trait < 0)
                        {
                            listeDepl.Add(piece - 15);
                        }
                    }
                    break;

                case 5: //////////************ Cas dame *************///////////////

                    // Sert à sortir de la boucle si on arrive sur une autre piece
                    stop = false;
                    // Sert à avancer et tester les cases suivantes
                    facteur = 1;

                    // Cas dame descend droite
                    while ((piece % 8 + facteur < 8) && (piece + 9 * facteur <= 63) && !stop)
                    {
                        if (plateau[piece + 9 * facteur] == 0)
                        {
                            listeDepl.Add(piece + 9 * facteur);
                        }
                        if (plateau[piece + 9 * facteur] * trait < 0)
                        {
                            listeDepl.Add(piece + 9 * facteur);
                            stop = true;
                        }
                        if (plateau[piece + 9 * facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }

                    // Cas dame descend gauche
                    stop = false;
                    facteur = 1;
                    while ((piece % 8 - facteur > -1) && (piece + 7 * facteur < 63) && !stop)
                    {
                        if (plateau[piece + 7 * facteur] == 0)
                        {
                            listeDepl.Add(piece + 7 * facteur);
                        }
                        if (plateau[piece + 7 * facteur] * trait < 0)
                        {
                            listeDepl.Add(piece + 7 * facteur);
                            stop = true;
                        }
                        if (plateau[piece + 7 * facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }

                    // Cas dame monte droite
                    stop = false;
                    facteur = 1;
                    while ((piece % 8 + facteur < 8) && (piece - 7 * facteur > 0) && !stop)
                    {
                        if (plateau[piece - 7 * facteur] == 0)
                        {
                            listeDepl.Add(piece - 7 * facteur);
                        }
                        if (plateau[piece - 7 * facteur] * trait < 0)
                        {
                            listeDepl.Add(piece - 7 * facteur);
                            stop = true;
                        }
                        if (plateau[piece - 7 * facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }

                    // Cas dame monte gauche
                    stop = false;
                    facteur = 1;
                    while ((piece % 8 - facteur > -1) && (piece - 9 * facteur >= 0) && !stop)
                    {
                        if (plateau[piece - 9 * facteur] == 0)
                        {
                            listeDepl.Add(piece - 9 * facteur);
                        }
                        if (plateau[piece - 9 * facteur] * trait < 0)
                        {
                            listeDepl.Add(piece - 9 * facteur);
                            stop = true;
                        }
                        if (plateau[piece - 9 * facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }
                    // Sert à sortir de la boucle si on arrive sur une autre piece
                    stop = false;
                    // Sert à avancer et tester les cases suivantes
                    facteur = 1;

                    // Cas dame descend
                    while (piece + 8 * facteur <= 63 && !stop)
                    {
                        if (plateau[piece + 8 * facteur] == 0)
                        {
                            listeDepl.Add(piece + 8 * facteur);
                        }
                        if (plateau[piece + 8 * facteur] * trait < 0)
                        {
                            listeDepl.Add(piece + 8 * facteur);
                            stop = true;
                        }
                        if (plateau[piece + 8 * facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }

                    // Cas dame monte
                    facteur = 1;
                    stop = false;
                    while (piece - 8 * facteur >= 0 && !stop)
                    {
                        if (plateau[piece - 8 * facteur] == 0)
                        {
                            listeDepl.Add(piece - 8 * facteur);
                        }
                        if (plateau[piece - 8 * facteur] * trait < 0)
                        {
                            listeDepl.Add(piece - 8 * facteur);
                            stop = true;
                        }
                        if (plateau[piece - 8 * facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }

                    // Cas dame à droite
                    facteur = 1;
                    stop = false;
                    while (piece % 8 + facteur < 8 && !stop)
                    {
                        if (plateau[piece + facteur] == 0)
                        {
                            listeDepl.Add(piece + facteur);
                        }
                        if (plateau[piece + facteur] * trait < 0)
                        {
                            listeDepl.Add(piece + facteur);
                            stop = true;
                        }
                        if (plateau[piece + facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }

                    // Cas dame à gauche
                    facteur = 1;
                    stop = false;
                    while (piece % 8 - facteur > -1 && !stop)
                    {
                        if (plateau[piece - facteur] == 0)
                        {
                            listeDepl.Add(piece - facteur);
                        }
                        if (plateau[piece - facteur] * trait < 0)
                        {
                            listeDepl.Add(piece - facteur);
                            stop = true;
                        }
                        if (plateau[piece - facteur] * trait > 0)
                        {
                            stop = true;
                        }
                        facteur += 1;
                    }



                    break;
                case 6: //////////************ Cas roi *************///////////////

                    // Cas haut gauche
                    if ((piece % 8 - 1 > -1) && (piece - 9 >= 0))
                    {
                        if (plateau[piece - 9] == 0)
                        {
                            listeDepl.Add(piece - 9);
                        }
                        if (plateau[piece - 9] * trait < 0)
                        {
                            listeDepl.Add(piece - 9);
                        }
                    }
                    // Cas gauche
                    if ((piece % 8 - 1 > -1))
                    {
                        if (plateau[piece - 1] == 0)
                        {
                            listeDepl.Add(piece - 1);
                        }
                        if (plateau[piece - 1] * trait < 0)
                        {
                            listeDepl.Add(piece - 1);
                        }
                    }
                    // Cas bas gauche
                    if ((piece % 8 - 1 > -1) && (piece + 7 <= 63))
                    {
                        if (plateau[piece + 7] == 0)
                        {
                            listeDepl.Add(piece + 7);
                        }
                        if (plateau[piece + 7] * trait < 0)
                        {
                            listeDepl.Add(piece + 7);
                        }
                    }
                    // Cas haut
                    if ((piece - 8 >= 0))
                    {
                        if (plateau[piece - 8] == 0)
                        {
                            listeDepl.Add(piece - 8);
                        }
                        if (plateau[piece - 8] * trait < 0)
                        {
                            listeDepl.Add(piece - 8);
                        }
                    }
                    // Cas bas
                    if ((piece + 8 <= 63))
                    {
                        if (plateau[piece + 8] == 0)
                        {
                            listeDepl.Add(piece + 8);
                        }
                        if (plateau[piece + 8] * trait < 0)
                        {
                            listeDepl.Add(piece + 8);
                        }
                    }
                    // Cas haut droit
                    if ((piece % 8 + 1 < 8) && (piece - 7 >= 0))
                    {
                        if (plateau[piece - 7] == 0)
                        {
                            listeDepl.Add(piece - 7);
                        }
                        if (plateau[piece - 7] * trait < 0)
                        {
                            listeDepl.Add(piece - 7);
                        }
                    }
                    // Cas droit
                    if (piece % 8 + 1 < 8)
                    {
                        if (plateau[piece + 1] == 0)
                        {
                            listeDepl.Add(piece + 1);
                        }
                        if (plateau[piece + 1] * trait < 0)
                        {
                            listeDepl.Add(piece + 1);
                        }
                    }
                    // Cas bas droit
                    if ((piece % 8 + 1 < 8) && (piece + 9 <= 63))
                    {
                        if (plateau[piece + 9] == 0)
                        {
                            listeDepl.Add(piece + 9);
                        }
                        if (plateau[piece + 9] * trait < 0)
                        {
                            listeDepl.Add(piece + 9);
                        }
                    }
                    break;
            }

            return listeDepl;
        }


        // Renvoie un plateeau de jeu avec le deplacement effectue
        public int[] DeduitPlateau(int depart, int arrivee, int[] plateau)
        {
            int[] nPlateau = (int[])plateau.Clone();

            // Si promotion
            if (Math.Abs(nPlateau[depart]) == 1 && ((arrivee >= 0 && arrivee <= 7) || (arrivee >= 56 && arrivee <= 63)))
            {
                nPlateau[arrivee] = nPlateau[depart] * 5; // On choisi une dame
            }
            else
            {
                nPlateau[arrivee] = nPlateau[depart];
            }
            nPlateau[depart] = 0;
            return nPlateau;
        }


        // Calcul le score d'un plateau
        public int ScorePlateau(int[] plateau)
        {
            int score = 0;
            int bonus = 0;
            foreach (int val in plateau)
            {
                // Determine à qui appartient la piece
                if (val < 0)
                {
                    bonus = 1; // appartient a l'IA
                }
                else
                {
                    bonus = -1; // appartient a l'adversaire
                }


                // ajoute le score associe à la piece
                switch (Math.Abs(val))
                {
                    case 1: // cas pion
                        score += (1 * bonus);
                        break;
                    case 21: // cas tour
                        score += (5 * bonus);
                        break;
                    case 22: // cas tour
                        score += (5 * bonus);
                        break;
                    case 31: // cas cavalier
                        score += (3 * bonus);
                        break;
                    case 32: // cas cavalier
                        score += (3 * bonus);
                        break;
                    case 4: // cas fou
                        score += (3 * bonus);
                        break;
                    case 5: // cas dame
                        score += (10 * bonus);
                        break;
                        //case 6: // cas roi
                        //    score += (1000 * bonus);
                        //    break;
                }
                if (val == -6)
                {
                    score += 1000;
                }
                if (val == 6)
                {
                    score -= 200;
                }

            }
            return score;
        }

        //*********************
        //********************* Exploration de l'arbre (algo minmax) ******************
        //*********************

        // Structure pour gérer des moves. Combinaison de piece, deplacement et plateau résultant
        public struct move
        {
            public int piece;
            public int deplacement;
            public int[] plateau;

            public move(int p, int dep, int[] plt)
            {
                piece = p;
                deplacement = dep;
                plateau = plt;
            }

            public override string ToString()
            {
                return "piece: " + piece + " /deplacement: " + deplacement + " /plateau :" + plateau;
            }
        }



        // Renvoie le déplacement a effectuer (piece et deplacement)
        public int[] Fonction1(int[] currentPlateau, int profondeurMax)
        {

            int alpha = -10000;
            int beta = 10000;
            
            int[] deplacement = new int[3]; // contient le résultat de la fonction
            List<int[]> listeTrios = new List<int[]>(); // Contient les trios (piece, deplacement, score)
            List<move> listeMoves = new List<move>(); // Contient une piece, un deplacement et un plateau par move

            List<int> mesPieces = new List<int>(); // Liste les pieces de l'IA (liste de leurs index sur le plateau)
            for (int i = 0; i < currentPlateau.Length; i++)
            {
                if (currentPlateau[i] < 0) mesPieces.Add(i);
            }



            // Pour chacune des pieces de l'IA
            foreach (int piece in mesPieces)
            {
                List<int> listeDeplacementPossible = DeduitDeplacementPossible(piece, currentPlateau);

                // Pour chacun des deplacements possibles de la piece en question
                foreach (int depl in listeDeplacementPossible)
                {
                    // On ajoute le move trouve a la liste
                    listeMoves.Add(new move(piece, depl, DeduitPlateau(piece, depl, currentPlateau)));
                }
            }
            // La liste des moves est complete

            // Pour chaque move on va determine le score associe et creer un trio (piece, deplacement, score) associe
            foreach (move m in listeMoves)
            {
                int[] trio = { m.piece, m.deplacement, RecMin(m.plateau, profondeurMax - 1, alpha, beta) };
                listeTrios.Add(trio);
            }

            // on determine le meilleur score et on retient l'index du trio correspondant
            int index = DetermineMeilleurTrio(listeTrios);

            // On retient le résultat que l'on va envoyer pour notre tour de jeu
            deplacement[0] = listeTrios.ElementAt(index)[0];
            deplacement[1] = listeTrios.ElementAt(index)[1];

            // Cas ou pion est promu
            if (currentPlateau[deplacement[0]] == -1 && (deplacement[1] >= 56 && deplacement[1] <= 63))
            {
                deplacement[2] = 1;
            }
            else
            {
                deplacement[2] = 0;
            }

            return deplacement;
        }


        // Renvoie l'index dans la liste du meilleur trio en fonction du score
        public int DetermineMeilleurTrio(List<int[]> listeTrios)
        {

            List<int> index = new List<int>();
            int bestScore = listeTrios.ElementAt(0)[2];
            index.Add(0);
            for (int i = 1; i < listeTrios.Count; i++)
            {
                if (listeTrios.ElementAt(i)[2] == bestScore)
                {

                    index.Add(i);
                }
                if (listeTrios.ElementAt(i)[2] > bestScore)
                {
                    index.Clear();
                    index.Add(i);
                    bestScore = listeTrios.ElementAt(i)[2];
                }
            }
            Random rnd = new Random();

            // On renvoit un élément aléatoire de la liste des meilleurs deplacements possibles avec un même score 
            return index.ElementAt(rnd.Next(0, index.Count));
        }




        // Recursion max (pour simuler le tour de l'IA)
        public int RecMax(int[] CurrentPlateau, int profondeur, int alpha, int beta)
        {
            int bestScore = -2000; // Initialise le meilleur score pour cette branche

            if (profondeur <= 0)
            {
                bestScore = ScorePlateau(CurrentPlateau);
            }
            else
            {
                List<int> mesPieces = new List<int>(); // Liste les pieces de l'IA
                for (int i = 0; i < CurrentPlateau.Length; i++)
                {
                    if (CurrentPlateau[i] < 0) mesPieces.Add(i);
                }

                List<int[]> listePlateau = DeduitListePlateau(CurrentPlateau, mesPieces); // Liste des plateaux possible à partir du plateau courant

                // Determine le meilleur score parmi les plateaux trouves
                foreach (int[] plt in listePlateau)
                {
                    int score = RecMin(plt, profondeur - 1, alpha, beta);
                    if (score > bestScore)
                    {
                        bestScore = score;
                        if (bestScore >= beta)
                        {
                            return bestScore;
                        }
                        if (bestScore >= alpha)
                        {
                            alpha = bestScore;
                        }
                    }
                }

            }

            return bestScore;
        }

        // Recursion min (pour simuler le tour de l'adversaire)
        public int RecMin(int[] CurrentPlateau, int profondeur, int alpha, int beta)
        {

            int worstScore = 2000; // Initialise le meilleur score pour cette branche

            if (profondeur <= 0)
            {
                worstScore = ScorePlateau(CurrentPlateau);
            }
            else
            {
                List<int> mesPieces = new List<int>(); // Liste les pieces de l'IA
                for (int i = 0; i < CurrentPlateau.Length; i++)
                {
                    if (CurrentPlateau[i] > 0) mesPieces.Add(i);
                }

                List<int[]> listePlateau = DeduitListePlateau(CurrentPlateau, mesPieces); // Liste des plateaux possible à partir du plateau courant

                // Determine le moins bon score parmi les plateaux trouves
                foreach (int[] plt in listePlateau)
                {
                    int score = RecMax(plt, profondeur - 1, alpha, beta);
                    if (score < worstScore)
                    {
                        worstScore = score;
                        if (worstScore <= alpha)
                        {
                            return worstScore;
                        }
                        if (worstScore <= beta)
                        {
                            beta = worstScore;
                        }
                    }
                }

            }

            return worstScore;
        }
    }

}

