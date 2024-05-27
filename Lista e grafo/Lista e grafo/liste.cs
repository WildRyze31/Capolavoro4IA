using System;
using System.Collections.Generic;

namespace Lista_e_grafo
{
    public class Lista<T>
    {
        private List<T> elementi;

        public Lista()
        {
            elementi = new List<T>();
        }

        public void AggiungiInTesta(T elemento)
        {
            elementi.Insert(0, elemento);
        }

        public void AggiungiInCoda(T elemento)
        {
            elementi.Add(elemento);
        }

        public void AggiungiInOrdine(T elemento)
        {
            for (int i = 0; i < elementi.Count; i++)
            {
                if (Comparer<T>.Default.Compare(elementi[i], elemento) > 0)
                {
                    elementi.Insert(i, elemento);
                    return;
                }
            }
            elementi.Add(elemento);
        }

        public void AggiungiInPosizione(T elemento, int posizione)
        {
            if (posizione < 0 || posizione > elementi.Count)
                throw new ArgumentOutOfRangeException("Posizione non valida.");
            elementi.Insert(posizione, elemento);
        }

        public void Cancella(int posizione)
        {
            if (posizione < 0 || posizione >= elementi.Count)
                throw new ArgumentOutOfRangeException("Posizione non valida.");
            elementi.RemoveAt(posizione);
        }

        public List<T> GetElementi()
        {
            return elementi;
        }
    }
}
