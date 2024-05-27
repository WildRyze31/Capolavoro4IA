using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lista_e_grafo
{
    public partial class Form1 : Form
    {
        private Grafo grafo;
        private Lista<string> lista;

        public Form1()
        {
            InitializeComponent();
            grafo = new Grafo();
            lista = new Lista<string>();
        }

        // Gestione dei grafi
        private void AggiungiNodo_Click(object sender, EventArgs e)
        {
            string nodo1 = TextNodo1.Text.Trim();
            string nodo2 = TextNodo2.Text.Trim();
            bool bidirezionale = CheckboxBidirezionale.Checked;

            if (!string.IsNullOrEmpty(nodo1) && !string.IsNullOrEmpty(nodo2))
            {
                grafo.AggiungiArco(nodo1, nodo2, bidirezionale);
                AggiornaListBoxGrafi();
            }
        }

        private void EliminaNodo_Click(object sender, EventArgs e)
        {
            string nodo1 = TextNodo1.Text.Trim();
            string nodo2 = TextNodo2.Text.Trim();
            bool bidirezionale = CheckboxBidirezionale.Checked;

            if (!string.IsNullOrEmpty(nodo1) && !string.IsNullOrEmpty(nodo2))
            {
                grafo.RimuoviArco(nodo1, nodo2, bidirezionale);
                AggiornaListBoxGrafi();
            }
        }

        private void ModificaNodo_Click(object sender, EventArgs e)
        {
            string vecchioNodo1 = Nodo1Modifica.Text.Trim();
            string vecchioNodo2 = Nodo2Modifica.Text.Trim();
            string nuovoNodo1 = TextNodo1.Text.Trim();
            string nuovoNodo2 = TextNodo2.Text.Trim();
            string nuovoNodo1Nuovo = Nodo1Nuovo.Text.Trim();
            string nuovoNodo2Nuovo = Nodo2Nuovo.Text.Trim();
            bool bidirezionale = CheckboxBidirezionale.Checked;

            if (string.IsNullOrEmpty(vecchioNodo1) || string.IsNullOrEmpty(vecchioNodo2) ||
                string.IsNullOrEmpty(nuovoNodo1) || string.IsNullOrEmpty(nuovoNodo2) ||
                string.IsNullOrEmpty(nuovoNodo1Nuovo) || string.IsNullOrEmpty(nuovoNodo2Nuovo))
            {
                MessageBox.Show("Per favore, compila tutti i campi.");
                return;
            }

            if (!grafo.VerificaArco(vecchioNodo1, vecchioNodo2))
            {
                MessageBox.Show("L'arco da modificare non esiste.");
                return;
            }

            if (grafo.VerificaArco(nuovoNodo1Nuovo, nuovoNodo2Nuovo))
            {
                MessageBox.Show("L'arco con i nuovi nodi già esiste.");
                return;
            }

            grafo.ModificaArco(vecchioNodo1, vecchioNodo2, nuovoNodo1Nuovo, nuovoNodo2Nuovo, bidirezionale);
            AggiornaListBoxGrafi();
        }

        private void AggiornaListBoxGrafi()
        {
            listgrafi.Items.Clear();
            List<string> connessioni = grafo.OttieniConnessioni();
            foreach (var connessione in connessioni)
            {
                listgrafi.Items.Add(connessione);
            }
        }

        private void EliminaButton_Click(object sender, EventArgs e)
        {
            int posizione;
            if (!int.TryParse(PosizioneTextBox.Text, out posizione))
            {
                MessageBox.Show("La posizione deve essere un numero intero valido.");
                return;
            }

            try
            {
                lista.Cancella(posizione);
                AggiornaListBoxLista();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("La posizione specificata non è valida.");
            }
            panelista.Invalidate();
        }

        private void AggiungiButton_Click(object sender, EventArgs e)
        {
            string valore = ValoreTextBox.Text;

            if (CheckBoxT.Checked)
            {
                lista.AggiungiInTesta(valore);
            }
            else if (CheckBoxC.Checked)
            {
                lista.AggiungiInCoda(valore);
            }
            else if (CheckBoxOrdine.Checked)
            {
                lista.AggiungiInOrdine(valore);
            }
            else
            {
                int posizione;
                if (!int.TryParse(PosizioneTextBox.Text, out posizione))
                {
                    MessageBox.Show("La posizione deve essere un numero intero valido.");
                    return;
                }

                try
                {
                    lista.AggiungiInPosizione(valore, posizione);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("La posizione specificata non è valida.");
                    return;
                }
            }

            AggiornaListBoxLista();
            panelista.Invalidate();
        }

        private void AggiornaListBoxLista()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(lista.GetElementi().ToArray());
        }

        private void panelista_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            List<string> elementi = lista.GetElementi();
            int x = 10;
            int y = 20;
            int nodoDiametro = 50;
            int distanza = 70;

            Pen penna = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.LightBlue);
            Font font = new Font("Arial", 10);

            for (int i = 0; i < elementi.Count; i++)
            {
                g.FillEllipse(brush, x, y, nodoDiametro, nodoDiametro);
                g.DrawEllipse(penna, x, y, nodoDiametro, nodoDiametro);

                string valore = elementi[i];
                SizeF stringSize = g.MeasureString(valore, font);
                g.DrawString(valore, font, Brushes.Black, x + (nodoDiametro - stringSize.Width) / 2, y + (nodoDiametro - stringSize.Height) / 2);

                if (i < elementi.Count - 1)
                {
                    g.DrawLine(penna, x + nodoDiametro, y + nodoDiametro / 2, x + nodoDiametro + distanza - 10, y + nodoDiametro / 2);
                    g.DrawLine(penna, x + nodoDiametro + distanza - 10, y + nodoDiametro / 2, x + nodoDiametro + distanza - 20, y + nodoDiametro / 2 - 10);
                    g.DrawLine(penna, x + nodoDiametro + distanza - 10, y + nodoDiametro / 2, x + nodoDiametro + distanza - 20, y + nodoDiametro / 2 + 10);
                }

                x += nodoDiametro + distanza;
            }
        }

        private void PosizioneTextBox_TextChanged(object sender, EventArgs e)
        {
            int posizione;
            if (int.TryParse(PosizioneTextBox.Text, out posizione))
            {
                if (posizione >= 0 && posizione < listBox1.Items.Count)
                {
                    string valore = listBox1.Items[posizione].ToString();
                    ValoreTextBox.Text = valore;
                }
                else
                {
                    ValoreTextBox.Text = string.Empty;
                }
            }
            else
            {
                ValoreTextBox.Text = string.Empty;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string elementoSelezionato = listBox1.SelectedItem.ToString();
                ValoreTextBox.Text = elementoSelezionato;
                int posizione = listBox1.SelectedIndex;
                PosizioneTextBox.Text = posizione.ToString();
            }
        }

        private void CheckBoxT_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxT.Checked)
            {
                CheckBoxValore.Checked = false;
                CheckBoxC.Checked = false;
                PosizioneTextBox.Enabled = false;
                CheckBoxOrdine.Checked = false;
            }
            else
            {
                PosizioneTextBox.Enabled = true;
            }
        }

        private void CheckBoxValore_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxValore.Checked)
            {
                CheckBoxT.Checked = false;
                CheckBoxC.Checked = false;
                PosizioneTextBox.Enabled = true;
                CheckBoxOrdine.Checked = false;
            }
        }

        private void CheckBoxC_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxC.Checked)
            {
                CheckBoxValore.Checked = false;
                CheckBoxT.Checked = false;
                PosizioneTextBox.Enabled = false;
                CheckBoxOrdine.Checked = false;
            }
            else
            {
                PosizioneTextBox.Enabled = true;
            }
        }

        private void CheckBoxOrdine_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxOrdine.Checked)
            {
                CheckBoxValore.Checked = false;
                CheckBoxT.Checked = false;
                CheckBoxC.Checked = false;
                PosizioneTextBox.Enabled = false;
            }
            else
            {
                PosizioneTextBox.Enabled = true;
            }
        }

        private void listgrafi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listgrafi.SelectedIndex != -1)
            {
                string elementoSelezionato = listgrafi.SelectedItem.ToString();
                string[] nodi = elementoSelezionato.Split(new string[] { " -> " }, StringSplitOptions.None);

                if (nodi.Length == 2)
                {
                    TextNodo1.Text = nodi[0];
                    TextNodo2.Text = nodi[1];
                    Nodo1Modifica.Text = nodi[0];
                    Nodo2Modifica.Text = nodi[1];
                }
            }
        }

        private void buttonBFS_Click_1(object sender, EventArgs e)
        {
            if (listgrafi.SelectedItem != null)
            {
                string elementoSelezionato = listgrafi.SelectedItem.ToString();
                string[] nodi = elementoSelezionato.Split(new string[] { " -> " }, StringSplitOptions.None);

                if (nodi.Length == 2)
                {
                    string nodoPartenza = nodi[0];
                    List<string> nodiVisitati = grafo.BFS(nodoPartenza);
                    MessageBox.Show("Visita in ampiezza (BFS):\n" + string.Join(", ", nodiVisitati));
                }
            }
        }

        private void buttonDFS_Click_1(object sender, EventArgs e)
        {
            if (listgrafi.SelectedItem != null)
            {
                string elementoSelezionato = listgrafi.SelectedItem.ToString();
                string[] nodi = elementoSelezionato.Split(new string[] { " -> " }, StringSplitOptions.None);

                if (nodi.Length == 2)
                {
                    string nodoPartenza = nodi[0];
                    List<string> nodiVisitati = grafo.DFS(nodoPartenza);
                    MessageBox.Show("Visita in profondità (DFS):\n" + string.Join(", ", nodiVisitati));
                }
            }
        }
    }
}
