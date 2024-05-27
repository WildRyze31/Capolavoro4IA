using System;
using System.Collections.Generic;

namespace Lista_e_grafo
{
    public class Grafo
    {
        private Dictionary<string, List<string>> listaAdiacenza;

        public Grafo()
        {
            listaAdiacenza = new Dictionary<string, List<string>>();
        }

        public void AggiungiArco(string nodo1, string nodo2, bool bidirezionale)
        {
            if (!listaAdiacenza.ContainsKey(nodo1))
            {
                listaAdiacenza[nodo1] = new List<string>();
            }
            if (!listaAdiacenza[nodo1].Contains(nodo2))
            {
                listaAdiacenza[nodo1].Add(nodo2);
            }

            if (bidirezionale)
            {
                if (!listaAdiacenza.ContainsKey(nodo2))
                {
                    listaAdiacenza[nodo2] = new List<string>();
                }
                if (!listaAdiacenza[nodo2].Contains(nodo1))
                {
                    listaAdiacenza[nodo2].Add(nodo1);
                }
            }
        }

        public void RimuoviArco(string nodo1, string nodo2, bool bidirezionale)
        {
            if (listaAdiacenza.ContainsKey(nodo1))
            {
                listaAdiacenza[nodo1].Remove(nodo2);
                if (listaAdiacenza[nodo1].Count == 0)
                {
                    listaAdiacenza.Remove(nodo1);
                }
            }

            if (bidirezionale)
            {
                if (listaAdiacenza.ContainsKey(nodo2))
                {
                    listaAdiacenza[nodo2].Remove(nodo1);
                    if (listaAdiacenza[nodo2].Count == 0)
                    {
                        listaAdiacenza.Remove(nodo2);
                    }
                }
            }
        }

        public void ModificaArco(string vecchioNodo1, string vecchioNodo2, string nuovoNodo1, string nuovoNodo2, bool bidirezionale)
        {
            RimuoviArco(vecchioNodo1, vecchioNodo2, bidirezionale);
            AggiungiArco(nuovoNodo1, nuovoNodo2, bidirezionale);
        }

        public bool VerificaArco(string nodo1, string nodo2)
        {
            if (listaAdiacenza.ContainsKey(nodo1))
            {
                return listaAdiacenza[nodo1].Contains(nodo2);
            }
            return false;
        }

        public List<string> BFS(string nodoPartenza)
        {
            List<string> nodiVisitati = new List<string>();
            Queue<string> coda = new Queue<string>();
            HashSet<string> visitati = new HashSet<string>();

            coda.Enqueue(nodoPartenza);
            visitati.Add(nodoPartenza);

            while (coda.Count > 0)
            {
                string nodoCorrente = coda.Dequeue();
                nodiVisitati.Add(nodoCorrente);

                if (listaAdiacenza.ContainsKey(nodoCorrente))
                {
                    foreach (string vicino in listaAdiacenza[nodoCorrente])
                    {
                        if (!visitati.Contains(vicino))
                        {
                            coda.Enqueue(vicino);
                            visitati.Add(vicino);
                        }
                    }
                }
            }

            return nodiVisitati;
        }

        public List<string> DFS(string nodoPartenza)
        {
            List<string> nodiVisitati = new List<string>();
            Stack<string> stack = new Stack<string>();
            HashSet<string> visitati = new HashSet<string>();

            stack.Push(nodoPartenza);

            while (stack.Count > 0)
            {
                string nodoCorrente = stack.Pop();

                if (!visitati.Contains(nodoCorrente))
                {
                    nodiVisitati.Add(nodoCorrente);
                    visitati.Add(nodoCorrente);

                    if (listaAdiacenza.ContainsKey(nodoCorrente))
                    {
                        foreach (string vicino in listaAdiacenza[nodoCorrente])
                        {
                            if (!visitati.Contains(vicino))
                            {
                                stack.Push(vicino);
                            }
                        }
                    }
                }
            }

            return nodiVisitati;
        }


        public List<string> OttieniConnessioni()
        {
            List<string> connessioni = new List<string>();
            foreach (var nodo in listaAdiacenza)
            {
                foreach (var vicino in nodo.Value)
                {
                    connessioni.Add($"{nodo.Key} -> {vicino}");
                }
            }
            return connessioni;
        }
    }
}
