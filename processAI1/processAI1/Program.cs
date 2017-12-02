using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Threading;

namespace processAI1
{
    class Program
    {

        // On instancie notre echiquier (different de l'instance de jeu) utile pour nos calculs
        private EchiquierIA echIA = EchiquierIA.Instance();

        static void Main(string[] args)
        {
            try
            {
                bool stop = false;
                int[] tabVal = new int[64];
                String value;
                String[] coord = new String[] { "", "", "" };
                String[] tabCoord = new string[] { "a8","b8","c8","d8","e8","f8","g8","h8",
                                                   "a7","b7","c7","d7","e7","f7","g7","h7",
                                                   "a6","b6","c6","d6","e6","f6","g6","h6",
                                                   "a5","b5","c5","d5","e5","f5","g5","h5",
                                                   "a4","b4","c4","d4","e4","f4","g4","h4",
                                                   "a3","b3","c3","d3","e3","f3","g3","h3",
                                                   "a2","b2","c2","d2","e2","f2","g2","h2",
                                                   "a1","b1","c1","d1","e1","f1","g1","h1" };

                

                while (!stop)
                {
                    using (var mmf = MemoryMappedFile.OpenExisting("plateau"))
                    {
                        using(var mmf2 = MemoryMappedFile.OpenExisting("repAI1"))
                        {
                            Mutex mutexStartAI1 = Mutex.OpenExisting("mutexStartAI1");
                            Mutex mutexAI1 = Mutex.OpenExisting("mutexAI1");
                            mutexAI1.WaitOne();
                            
                            mutexStartAI1.WaitOne();

                            using (var accessor = mmf.CreateViewAccessor())
                            {
                                ushort Size = accessor.ReadUInt16(0);
                                byte[] Buffer = new byte[Size];
                                accessor.ReadArray(0 + 2, Buffer, 0, Buffer.Length);

                                value = ASCIIEncoding.ASCII.GetString(Buffer);
                                if (value == "stop") stop = true;
                                else
                                {
                                    String[] substrings = value.Split(',');
                                    for (int i = 0; i < substrings.Length; i++)
                                    {
                                        tabVal[i] = Convert.ToInt32(substrings[i]);
                                    }
                                }
                            }
                            if (!stop)
                            {
                                /******************************************************************************************************/
                                /***************************************** ECRIRE LE CODE DE L'IA *************************************/
                                /******************************************************************************************************/

                                List<String> mesPieces = new List<String>();
                                for (int i = 0; i < tabVal.Length; i++)
                                {
                                    if (tabVal[i] > 0) mesPieces.Add(tabCoord[i]);
                                }

                                List<String> reste = new List<String>();
                                for (int i = 0; i < tabVal.Length; i++)
                                {
                                    if (tabVal[i] <= 0) reste.Add(tabCoord[i]);
                                }

                                Random rnd = new Random();
                                coord[0] = mesPieces[rnd.Next(mesPieces.Count)];
                                //coord[0] = "b7";
                                //coord[1] = "b8";
                                coord[1] = tabCoord[rnd.Next(reste.Count)];
                                //coord[2] = "P";

                                
                                /********************************************************************************************************/
                                /********************************************************************************************************/
                                /********************************************************************************************************/

                                using (var accessor = mmf2.CreateViewAccessor())
                                {
                                    value = coord[0];
                                    for (int i = 1; i < coord.Length; i++)
                                    {
                                        value += "," + coord[i];
                                    }
                                    byte[] Buffer = ASCIIEncoding.ASCII.GetBytes(value);
                                    accessor.Write(0, (ushort)Buffer.Length);
                                    accessor.WriteArray(0 + 2, Buffer, 0, Buffer.Length);
                                }
                            }
                            mutexAI1.ReleaseMutex();
                            mutexStartAI1.ReleaseMutex();
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Memory-mapped file does not exist. Run Process A first.");
                Console.ReadLine();
            }
        }

        //*********************** FONCTIONS SUPPLEMENTAIRES ************************

        
        // Liste les plateaux possibles a partir du plateau courant
        public List<int[]> DeduitListePlateau(int[] plateau, int[] mesPieces)
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

            // On met l'echiquier dans l'etat adeqat
            echIA.SetPlateau(plateau);

            /* TODO pour affiner la recherche des déplacements possibles
            
            switch (piece)
            {
                case 1: // cas pion 
                    //do thing
                    break;
                case 21: // cas tour
                    //do thing
                    break;
                case 22: // cas tour
                    //do thing
                    break;
                case 31: // cas cavalier
                    //do thing
                    break;
                case 32: // cas cavalier
                    //do thing
                    break;
                case 4: // cas fou
                    //do thing
                    break;
                case 5: // cas dame
                    //do thing
                    break;
                case 6: // cas roi
                    //do thing
                    break;
                
            }
            */

            // parcours le plateau a la recherche de deplacements possibles pour la piece
            foreach( int arrivee in plateau)
            {
                if(echIA.valide(piece, arrivee))
                {
                    listeDepl.Add(arrivee);
                }
            }

            return listeDepl;
        }


        // Renvoie un plateeau de jeu avec le deplacement effectue
        public int[] DeduitPlateau(int depart, int arrivee, int[] plateau)
        {
            plateau[arrivee] = plateau[depart];
            plateau[depart] = 0;
            return plateau;
        }


        // Calcul le score d'un plateau
        public int ScorePlateau (int[] plateau)
        {
            int score = 0;
            int bonus = 0;
            foreach (int val in plateau)
            {
                // Determine à qui appartient la piece
                if (val > 0)
                {
                    bonus = 1; // appartient a l'IA
                }
                else {
                    bonus = -1; // appartient a l'adversaire
                }

                // ajoute le score associe à la piece
                switch (val)
                {
                    case 1 : // cas pion
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
                    case 6: // cas roi
                        score += (1000 * bonus);
                        break;
                }

            }
            return score;
        }
    }
}
