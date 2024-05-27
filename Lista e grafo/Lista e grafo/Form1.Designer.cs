namespace Lista_e_grafo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabControl tabControl1;
            tabPage1 = new TabPage();
            panelista = new Panel();
            listBox1 = new ListBox();
            label1 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            panel2 = new Panel();
            CheckBoxOrdine = new CheckBox();
            CheckBoxC = new CheckBox();
            CheckBoxT = new CheckBox();
            CheckBoxValore = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            EliminaButton = new Button();
            AggiungiButton = new Button();
            label4 = new Label();
            label3 = new Label();
            PosizioneTextBox = new TextBox();
            ValoreTextBox = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            label10 = new Label();
            panel3 = new Panel();
            label23 = new Label();
            label22 = new Label();
            Nodo2Nuovo = new TextBox();
            Nodo1Nuovo = new TextBox();
            label21 = new Label();
            label20 = new Label();
            buttonDFS = new Button();
            buttonBFS = new Button();
            label19 = new Label();
            panel4 = new Panel();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            CheckboxBidirezionale = new CheckBox();
            label11 = new Label();
            TextNodo2 = new TextBox();
            TextNodo1 = new TextBox();
            EliminaNodo = new Button();
            AggiungiNodo = new Button();
            ModificaNodo = new Button();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            Nodo2Modifica = new TextBox();
            Nodo1Modifica = new TextBox();
            label15 = new Label();
            label9 = new Label();
            listgrafi = new ListBox();
            tabControl1 = new TabControl();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(5, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(973, 579);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.GradientActiveCaption;
            tabPage1.Controls.Add(panelista);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(965, 551);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Crud Liste";
            // 
            // panelista
            // 
            panelista.Location = new Point(21, 295);
            panelista.Name = "panelista";
            panelista.Size = new Size(457, 140);
            panelista.TabIndex = 4;
            panelista.Paint += panelista_Paint;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(21, 55);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(457, 229);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 18);
            label1.Name = "label1";
            label1.Size = new Size(292, 25);
            label1.TabIndex = 0;
            label1.Text = "Programma per gestione liste";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(EliminaButton);
            panel1.Controls.Add(AggiungiButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(PosizioneTextBox);
            panel1.Controls.Add(ValoreTextBox);
            panel1.Location = new Point(505, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 380);
            panel1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(3, 207);
            label8.Name = "label8";
            label8.Size = new Size(310, 13);
            label8.TabIndex = 11;
            label8.Text = "Si consiglia di aggiungere prima la posizione e poi il valore";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(CheckBoxOrdine);
            panel2.Controls.Add(CheckBoxC);
            panel2.Controls.Add(CheckBoxT);
            panel2.Controls.Add(CheckBoxValore);
            panel2.Location = new Point(17, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 109);
            panel2.TabIndex = 4;
            // 
            // CheckBoxOrdine
            // 
            CheckBoxOrdine.AutoSize = true;
            CheckBoxOrdine.Location = new Point(3, 83);
            CheckBoxOrdine.Name = "CheckBoxOrdine";
            CheckBoxOrdine.Size = new Size(125, 19);
            CheckBoxOrdine.TabIndex = 5;
            CheckBoxOrdine.Text = "Aggiungi in ordine";
            CheckBoxOrdine.UseVisualStyleBackColor = true;
            CheckBoxOrdine.CheckedChanged += CheckBoxOrdine_CheckedChanged;
            // 
            // CheckBoxC
            // 
            CheckBoxC.AutoSize = true;
            CheckBoxC.Location = new Point(3, 37);
            CheckBoxC.Name = "CheckBoxC";
            CheckBoxC.Size = new Size(117, 19);
            CheckBoxC.TabIndex = 4;
            CheckBoxC.Text = "Aggiungi in coda";
            CheckBoxC.UseVisualStyleBackColor = true;
            CheckBoxC.CheckedChanged += CheckBoxC_CheckedChanged;
            // 
            // CheckBoxT
            // 
            CheckBoxT.AutoSize = true;
            CheckBoxT.Location = new Point(3, 12);
            CheckBoxT.Name = "CheckBoxT";
            CheckBoxT.Size = new Size(116, 19);
            CheckBoxT.TabIndex = 2;
            CheckBoxT.Text = "Aggiungi in testa";
            CheckBoxT.UseVisualStyleBackColor = true;
            CheckBoxT.CheckedChanged += CheckBoxT_CheckedChanged;
            // 
            // CheckBoxValore
            // 
            CheckBoxValore.AutoSize = true;
            CheckBoxValore.Location = new Point(3, 61);
            CheckBoxValore.Name = "CheckBoxValore";
            CheckBoxValore.Size = new Size(151, 19);
            CheckBoxValore.TabIndex = 3;
            CheckBoxValore.Text = "Aggiungi tramite valore";
            CheckBoxValore.UseVisualStyleBackColor = true;
            CheckBoxValore.CheckedChanged += CheckBoxValore_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(3, 320);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 10;
            label7.Text = "pulsante Aggiungi ";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(3, 305);
            label6.Name = "label6";
            label6.Size = new Size(231, 15);
            label6.TabIndex = 9;
            label6.Text = "aggiungi solamente il valore e poi premi il ";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(3, 290);
            label5.Name = "label5";
            label5.Size = new Size(291, 15);
            label5.TabIndex = 8;
            label5.Text = "P.S se hai selezionato l'opzione aggiungi in testa/coda";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // EliminaButton
            // 
            EliminaButton.BackColor = Color.Coral;
            EliminaButton.Location = new Point(178, 240);
            EliminaButton.Name = "EliminaButton";
            EliminaButton.Size = new Size(100, 35);
            EliminaButton.TabIndex = 7;
            EliminaButton.Text = "Elimina";
            EliminaButton.UseVisualStyleBackColor = false;
            EliminaButton.Click += EliminaButton_Click;
            // 
            // AggiungiButton
            // 
            AggiungiButton.BackColor = SystemColors.MenuHighlight;
            AggiungiButton.Location = new Point(19, 240);
            AggiungiButton.Name = "AggiungiButton";
            AggiungiButton.Size = new Size(100, 35);
            AggiungiButton.TabIndex = 6;
            AggiungiButton.Text = "Aggiungi";
            AggiungiButton.UseVisualStyleBackColor = false;
            AggiungiButton.Click += AggiungiButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(143, 174);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 5;
            label4.Text = "Posizione";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(143, 126);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 4;
            label3.Text = "Valore";
            // 
            // PosizioneTextBox
            // 
            PosizioneTextBox.Location = new Point(17, 171);
            PosizioneTextBox.Name = "PosizioneTextBox";
            PosizioneTextBox.Size = new Size(100, 23);
            PosizioneTextBox.TabIndex = 1;
            PosizioneTextBox.TextChanged += PosizioneTextBox_TextChanged;
            // 
            // ValoreTextBox
            // 
            ValoreTextBox.Location = new Point(17, 123);
            ValoreTextBox.Name = "ValoreTextBox";
            ValoreTextBox.Size = new Size(100, 23);
            ValoreTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(505, 18);
            label2.Name = "label2";
            label2.Size = new Size(195, 25);
            label2.TabIndex = 1;
            label2.Text = "Panello di controllo";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.GradientActiveCaption;
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(listgrafi);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(965, 551);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Crud Grafi";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(463, 19);
            label10.Name = "label10";
            label10.Size = new Size(195, 25);
            label10.TabIndex = 3;
            label10.Text = "Panello di controllo";
            // 
            // panel3
            // 
            panel3.Controls.Add(label23);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(Nodo2Nuovo);
            panel3.Controls.Add(Nodo1Nuovo);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(buttonDFS);
            panel3.Controls.Add(buttonBFS);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(ModificaNodo);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(Nodo2Modifica);
            panel3.Controls.Add(Nodo1Modifica);
            panel3.Controls.Add(label15);
            panel3.Location = new Point(463, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(437, 428);
            panel3.TabIndex = 2;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(17, 247);
            label23.Name = "label23";
            label23.Size = new Size(74, 13);
            label23.TabIndex = 23;
            label23.Text = "Nuovo nodo 1";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(184, 247);
            label22.Name = "label22";
            label22.Size = new Size(74, 13);
            label22.TabIndex = 22;
            label22.Text = "Nuovo nodo 2";
            // 
            // Nodo2Nuovo
            // 
            Nodo2Nuovo.Location = new Point(184, 263);
            Nodo2Nuovo.Name = "Nodo2Nuovo";
            Nodo2Nuovo.Size = new Size(100, 23);
            Nodo2Nuovo.TabIndex = 21;
            // 
            // Nodo1Nuovo
            // 
            Nodo1Nuovo.Location = new Point(17, 263);
            Nodo1Nuovo.Name = "Nodo1Nuovo";
            Nodo1Nuovo.Size = new Size(100, 23);
            Nodo1Nuovo.TabIndex = 20;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.Red;
            label21.Location = new Point(136, 352);
            label21.Name = "label21";
            label21.Size = new Size(260, 13);
            label21.TabIndex = 19;
            label21.Text = "si vuole partire a fare la visita in ampiezza e profondità";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(136, 339);
            label20.Name = "label20";
            label20.Size = new Size(283, 13);
            label20.TabIndex = 18;
            label20.Text = "P.s:Ricorda di selezionare nella listbox l'elemento dal quale ";
            // 
            // buttonDFS
            // 
            buttonDFS.BackColor = Color.Plum;
            buttonDFS.Location = new Point(19, 381);
            buttonDFS.Name = "buttonDFS";
            buttonDFS.Size = new Size(100, 27);
            buttonDFS.TabIndex = 18;
            buttonDFS.Text = "DFS";
            buttonDFS.UseVisualStyleBackColor = false;
            buttonDFS.Click += buttonDFS_Click_1;
            // 
            // buttonBFS
            // 
            buttonBFS.BackColor = Color.MediumSlateBlue;
            buttonBFS.Location = new Point(19, 339);
            buttonBFS.Name = "buttonBFS";
            buttonBFS.Size = new Size(100, 27);
            buttonBFS.TabIndex = 18;
            buttonBFS.Text = "BFS";
            buttonBFS.UseVisualStyleBackColor = false;
            buttonBFS.Click += buttonBFS_Click_1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(16, 307);
            label19.Name = "label19";
            label19.Size = new Size(228, 18);
            label19.TabIndex = 17;
            label19.Text = "Visita in Ampiezza/Profondità";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(CheckboxBidirezionale);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(TextNodo2);
            panel4.Controls.Add(TextNodo1);
            panel4.Controls.Add(EliminaNodo);
            panel4.Controls.Add(AggiungiNodo);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(431, 169);
            panel4.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(180, 37);
            label14.Name = "label14";
            label14.Size = new Size(41, 13);
            label14.TabIndex = 17;
            label14.Text = "Nodo 2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(13, 37);
            label13.Name = "label13";
            label13.Size = new Size(41, 13);
            label13.TabIndex = 16;
            label13.Text = "Nodo 1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(130, 56);
            label12.Name = "label12";
            label12.Size = new Size(26, 20);
            label12.TabIndex = 15;
            label12.Text = "->";
            // 
            // CheckboxBidirezionale
            // 
            CheckboxBidirezionale.AutoSize = true;
            CheckboxBidirezionale.Location = new Point(13, 96);
            CheckboxBidirezionale.Name = "CheckboxBidirezionale";
            CheckboxBidirezionale.Size = new Size(171, 19);
            CheckboxBidirezionale.TabIndex = 14;
            CheckboxBidirezionale.Text = "Collegamento bidirezionale";
            CheckboxBidirezionale.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(10, 9);
            label11.Name = "label11";
            label11.Size = new Size(174, 18);
            label11.TabIndex = 13;
            label11.Text = "Aggiungi/Elimina nodo";
            // 
            // TextNodo2
            // 
            TextNodo2.Location = new Point(180, 53);
            TextNodo2.Name = "TextNodo2";
            TextNodo2.Size = new Size(100, 23);
            TextNodo2.TabIndex = 12;
            // 
            // TextNodo1
            // 
            TextNodo1.Location = new Point(13, 53);
            TextNodo1.Name = "TextNodo1";
            TextNodo1.Size = new Size(100, 23);
            TextNodo1.TabIndex = 11;
            // 
            // EliminaNodo
            // 
            EliminaNodo.BackColor = Color.LightSalmon;
            EliminaNodo.Location = new Point(171, 135);
            EliminaNodo.Name = "EliminaNodo";
            EliminaNodo.Size = new Size(85, 27);
            EliminaNodo.TabIndex = 10;
            EliminaNodo.Text = "Elimina";
            EliminaNodo.UseVisualStyleBackColor = false;
            EliminaNodo.Click += EliminaNodo_Click;
            // 
            // AggiungiNodo
            // 
            AggiungiNodo.BackColor = Color.Plum;
            AggiungiNodo.Location = new Point(12, 135);
            AggiungiNodo.Name = "AggiungiNodo";
            AggiungiNodo.Size = new Size(100, 27);
            AggiungiNodo.TabIndex = 9;
            AggiungiNodo.Text = "Aggiungi";
            AggiungiNodo.UseVisualStyleBackColor = false;
            AggiungiNodo.Click += AggiungiNodo_Click;
            // 
            // ModificaNodo
            // 
            ModificaNodo.BackColor = Color.MediumSlateBlue;
            ModificaNodo.Location = new Point(317, 239);
            ModificaNodo.Name = "ModificaNodo";
            ModificaNodo.Size = new Size(100, 27);
            ModificaNodo.TabIndex = 15;
            ModificaNodo.Text = "Modifica";
            ModificaNodo.UseVisualStyleBackColor = false;
            ModificaNodo.Click += ModificaNodo_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(184, 205);
            label16.Name = "label16";
            label16.Size = new Size(89, 13);
            label16.TabIndex = 14;
            label16.Text = "Nodo 2 (Vecchiio)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(17, 205);
            label17.Name = "label17";
            label17.Size = new Size(87, 13);
            label17.TabIndex = 13;
            label17.Text = "Nodo 1 (Vecchio)";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label18.Location = new Point(134, 224);
            label18.Name = "label18";
            label18.Size = new Size(26, 20);
            label18.TabIndex = 12;
            label18.Text = "->";
            // 
            // Nodo2Modifica
            // 
            Nodo2Modifica.Location = new Point(184, 221);
            Nodo2Modifica.Name = "Nodo2Modifica";
            Nodo2Modifica.Size = new Size(100, 23);
            Nodo2Modifica.TabIndex = 11;
            // 
            // Nodo1Modifica
            // 
            Nodo1Modifica.Location = new Point(17, 221);
            Nodo1Modifica.Name = "Nodo1Modifica";
            Nodo1Modifica.Size = new Size(100, 23);
            Nodo1Modifica.TabIndex = 10;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(16, 175);
            label15.Name = "label15";
            label15.Size = new Size(115, 18);
            label15.TabIndex = 9;
            label15.Text = "Modifica nodo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 19);
            label9.Name = "label9";
            label9.Size = new Size(295, 25);
            label9.TabIndex = 1;
            label9.Text = "Programma per gestione grafi";
            // 
            // listgrafi
            // 
            listgrafi.FormattingEnabled = true;
            listgrafi.ItemHeight = 15;
            listgrafi.Location = new Point(6, 66);
            listgrafi.Name = "listgrafi";
            listgrafi.Size = new Size(424, 394);
            listgrafi.TabIndex = 0;
            listgrafi.SelectedIndexChanged += listgrafi_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(950, 585);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private CheckBox CheckBoxValore;
        private CheckBox CheckBoxT;
        private TextBox PosizioneTextBox;
        private TextBox ValoreTextBox;
        private Label label5;
        private Button EliminaButton;
        private Button AggiungiButton;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private CheckBox CheckBoxC;
        private Label label8;
        private CheckBox CheckBoxOrdine;
        private ListBox listBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panelista;
        private Label label10;
        private Panel panel3;
        private Label label9;
        private ListBox listgrafi;
        private Button ModificaNodo;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox Nodo2Modifica;
        private TextBox Nodo1Modifica;
        private Label label15;
        private Panel panel4;
        private Label label14;
        private Label label13;
        private Label label12;
        private CheckBox CheckboxBidirezionale;
        private Label label11;
        private TextBox TextNodo2;
        private TextBox TextNodo1;
        private Button EliminaNodo;
        private Button AggiungiNodo;
        private Label label20;
        private Button buttonDFS;
        private Button buttonBFS;
        private Label label19;
        private Label label21;
        private Label label23;
        private Label label22;
        private TextBox Nodo2Nuovo;
        private TextBox Nodo1Nuovo;
    }
}