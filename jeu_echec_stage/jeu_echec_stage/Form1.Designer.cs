namespace jeu_echec_stage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlPlateau = new System.Windows.Forms.Panel();
            this.lblDep = new System.Windows.Forms.Label();
            this.lblCoord8 = new System.Windows.Forms.Label();
            this.lblCoord7 = new System.Windows.Forms.Label();
            this.lblCoord6 = new System.Windows.Forms.Label();
            this.lblCoord5 = new System.Windows.Forms.Label();
            this.lblCoord4 = new System.Windows.Forms.Label();
            this.lblCoord3 = new System.Windows.Forms.Label();
            this.lblCoord2 = new System.Windows.Forms.Label();
            this.lblCoord1 = new System.Windows.Forms.Label();
            this.lblCoordA = new System.Windows.Forms.Label();
            this.lblCoordB = new System.Windows.Forms.Label();
            this.lblCoordC = new System.Windows.Forms.Label();
            this.lblCoordD = new System.Windows.Forms.Label();
            this.lblCoordE = new System.Windows.Forms.Label();
            this.lblCoordF = new System.Windows.Forms.Label();
            this.lblCoordG = new System.Windows.Forms.Label();
            this.lblCoordH = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnJouer = new System.Windows.Forms.Button();
            this.lblTrait = new System.Windows.Forms.Label();
            this.pnlPieceB = new System.Windows.Forms.Panel();
            this.pnlPieceN = new System.Windows.Forms.Panel();
            this.tmrB = new System.Windows.Forms.Timer(this.components);
            this.tmrN = new System.Windows.Forms.Timer(this.components);
            this.lblAICoordDep = new System.Windows.Forms.Label();
            this.lblAICoordArr = new System.Windows.Forms.Label();
            this.lblAIPromotion = new System.Windows.Forms.Label();
            this.btnPat = new System.Windows.Forms.Button();
            this.lblGagnant = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlPlateau
            // 
            this.pnlPlateau.Location = new System.Drawing.Point(381, 117);
            this.pnlPlateau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPlateau.Name = "pnlPlateau";
            this.pnlPlateau.Size = new System.Drawing.Size(267, 123);
            this.pnlPlateau.TabIndex = 5;
            // 
            // lblDep
            // 
            this.lblDep.Location = new System.Drawing.Point(21, 238);
            this.lblDep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(297, 16);
            this.lblDep.TabIndex = 6;
            this.lblDep.Text = "Coordonnées du déplacement";
            this.lblDep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCoord8
            // 
            this.lblCoord8.AutoSize = true;
            this.lblCoord8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoord8.Location = new System.Drawing.Point(341, 144);
            this.lblCoord8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoord8.Name = "lblCoord8";
            this.lblCoord8.Size = new System.Drawing.Size(19, 20);
            this.lblCoord8.TabIndex = 8;
            this.lblCoord8.Text = "8";
            // 
            // lblCoord7
            // 
            this.lblCoord7.AutoSize = true;
            this.lblCoord7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoord7.Location = new System.Drawing.Point(341, 218);
            this.lblCoord7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoord7.Name = "lblCoord7";
            this.lblCoord7.Size = new System.Drawing.Size(19, 20);
            this.lblCoord7.TabIndex = 9;
            this.lblCoord7.Text = "7";
            // 
            // lblCoord6
            // 
            this.lblCoord6.AutoSize = true;
            this.lblCoord6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoord6.Location = new System.Drawing.Point(341, 292);
            this.lblCoord6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoord6.Name = "lblCoord6";
            this.lblCoord6.Size = new System.Drawing.Size(19, 20);
            this.lblCoord6.TabIndex = 10;
            this.lblCoord6.Text = "6";
            // 
            // lblCoord5
            // 
            this.lblCoord5.AutoSize = true;
            this.lblCoord5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoord5.Location = new System.Drawing.Point(341, 366);
            this.lblCoord5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoord5.Name = "lblCoord5";
            this.lblCoord5.Size = new System.Drawing.Size(19, 20);
            this.lblCoord5.TabIndex = 11;
            this.lblCoord5.Text = "5";
            // 
            // lblCoord4
            // 
            this.lblCoord4.AutoSize = true;
            this.lblCoord4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoord4.Location = new System.Drawing.Point(341, 439);
            this.lblCoord4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoord4.Name = "lblCoord4";
            this.lblCoord4.Size = new System.Drawing.Size(19, 20);
            this.lblCoord4.TabIndex = 12;
            this.lblCoord4.Text = "4";
            // 
            // lblCoord3
            // 
            this.lblCoord3.AutoSize = true;
            this.lblCoord3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoord3.Location = new System.Drawing.Point(341, 513);
            this.lblCoord3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoord3.Name = "lblCoord3";
            this.lblCoord3.Size = new System.Drawing.Size(19, 20);
            this.lblCoord3.TabIndex = 13;
            this.lblCoord3.Text = "3";
            // 
            // lblCoord2
            // 
            this.lblCoord2.AutoSize = true;
            this.lblCoord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoord2.Location = new System.Drawing.Point(341, 587);
            this.lblCoord2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoord2.Name = "lblCoord2";
            this.lblCoord2.Size = new System.Drawing.Size(19, 20);
            this.lblCoord2.TabIndex = 14;
            this.lblCoord2.Text = "2";
            // 
            // lblCoord1
            // 
            this.lblCoord1.AutoSize = true;
            this.lblCoord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoord1.Location = new System.Drawing.Point(341, 661);
            this.lblCoord1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoord1.Name = "lblCoord1";
            this.lblCoord1.Size = new System.Drawing.Size(19, 20);
            this.lblCoord1.TabIndex = 15;
            this.lblCoord1.Text = "1";
            // 
            // lblCoordA
            // 
            this.lblCoordA.AutoSize = true;
            this.lblCoordA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordA.Location = new System.Drawing.Point(411, 80);
            this.lblCoordA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordA.Name = "lblCoordA";
            this.lblCoordA.Size = new System.Drawing.Size(19, 20);
            this.lblCoordA.TabIndex = 16;
            this.lblCoordA.Text = "a";
            // 
            // lblCoordB
            // 
            this.lblCoordB.AutoSize = true;
            this.lblCoordB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordB.Location = new System.Drawing.Point(491, 80);
            this.lblCoordB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordB.Name = "lblCoordB";
            this.lblCoordB.Size = new System.Drawing.Size(19, 20);
            this.lblCoordB.TabIndex = 17;
            this.lblCoordB.Text = "b";
            // 
            // lblCoordC
            // 
            this.lblCoordC.AutoSize = true;
            this.lblCoordC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordC.Location = new System.Drawing.Point(571, 80);
            this.lblCoordC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordC.Name = "lblCoordC";
            this.lblCoordC.Size = new System.Drawing.Size(19, 20);
            this.lblCoordC.TabIndex = 18;
            this.lblCoordC.Text = "c";
            // 
            // lblCoordD
            // 
            this.lblCoordD.AutoSize = true;
            this.lblCoordD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordD.Location = new System.Drawing.Point(651, 80);
            this.lblCoordD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordD.Name = "lblCoordD";
            this.lblCoordD.Size = new System.Drawing.Size(19, 20);
            this.lblCoordD.TabIndex = 19;
            this.lblCoordD.Text = "d";
            // 
            // lblCoordE
            // 
            this.lblCoordE.AutoSize = true;
            this.lblCoordE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordE.Location = new System.Drawing.Point(731, 80);
            this.lblCoordE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordE.Name = "lblCoordE";
            this.lblCoordE.Size = new System.Drawing.Size(19, 20);
            this.lblCoordE.TabIndex = 20;
            this.lblCoordE.Text = "e";
            // 
            // lblCoordF
            // 
            this.lblCoordF.AutoSize = true;
            this.lblCoordF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordF.Location = new System.Drawing.Point(811, 80);
            this.lblCoordF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordF.Name = "lblCoordF";
            this.lblCoordF.Size = new System.Drawing.Size(15, 20);
            this.lblCoordF.TabIndex = 21;
            this.lblCoordF.Text = "f";
            // 
            // lblCoordG
            // 
            this.lblCoordG.AutoSize = true;
            this.lblCoordG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordG.Location = new System.Drawing.Point(891, 80);
            this.lblCoordG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordG.Name = "lblCoordG";
            this.lblCoordG.Size = new System.Drawing.Size(19, 20);
            this.lblCoordG.TabIndex = 22;
            this.lblCoordG.Text = "g";
            // 
            // lblCoordH
            // 
            this.lblCoordH.AutoSize = true;
            this.lblCoordH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordH.Location = new System.Drawing.Point(971, 80);
            this.lblCoordH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordH.Name = "lblCoordH";
            this.lblCoordH.Size = new System.Drawing.Size(19, 20);
            this.lblCoordH.TabIndex = 23;
            this.lblCoordH.Text = "h";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(21, 384);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(297, 16);
            this.lblResult.TabIndex = 24;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJouer
            // 
            this.btnJouer.Location = new System.Drawing.Point(107, 431);
            this.btnJouer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(100, 28);
            this.btnJouer.TabIndex = 27;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // lblTrait
            // 
            this.lblTrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrait.Location = new System.Drawing.Point(16, 117);
            this.lblTrait.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrait.Name = "lblTrait";
            this.lblTrait.Size = new System.Drawing.Size(303, 25);
            this.lblTrait.TabIndex = 28;
            this.lblTrait.Text = "Trait aux blancs";
            this.lblTrait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPieceB
            // 
            this.pnlPieceB.Location = new System.Drawing.Point(1056, 117);
            this.pnlPieceB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPieceB.Name = "pnlPieceB";
            this.pnlPieceB.Size = new System.Drawing.Size(267, 123);
            this.pnlPieceB.TabIndex = 29;
            // 
            // pnlPieceN
            // 
            this.pnlPieceN.Location = new System.Drawing.Point(1056, 439);
            this.pnlPieceN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPieceN.Name = "pnlPieceN";
            this.pnlPieceN.Size = new System.Drawing.Size(267, 123);
            this.pnlPieceN.TabIndex = 30;
            // 
            // lblAICoordDep
            // 
            this.lblAICoordDep.AutoSize = true;
            this.lblAICoordDep.Location = new System.Drawing.Point(111, 286);
            this.lblAICoordDep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAICoordDep.Name = "lblAICoordDep";
            this.lblAICoordDep.Size = new System.Drawing.Size(0, 17);
            this.lblAICoordDep.TabIndex = 35;
            // 
            // lblAICoordArr
            // 
            this.lblAICoordArr.AutoSize = true;
            this.lblAICoordArr.Location = new System.Drawing.Point(172, 286);
            this.lblAICoordArr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAICoordArr.Name = "lblAICoordArr";
            this.lblAICoordArr.Size = new System.Drawing.Size(0, 17);
            this.lblAICoordArr.TabIndex = 36;
            // 
            // lblAIPromotion
            // 
            this.lblAIPromotion.Location = new System.Drawing.Point(25, 342);
            this.lblAIPromotion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAIPromotion.Name = "lblAIPromotion";
            this.lblAIPromotion.Size = new System.Drawing.Size(293, 16);
            this.lblAIPromotion.TabIndex = 37;
            this.lblAIPromotion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPat
            // 
            this.btnPat.Location = new System.Drawing.Point(107, 490);
            this.btnPat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPat.Name = "btnPat";
            this.btnPat.Size = new System.Drawing.Size(100, 28);
            this.btnPat.TabIndex = 38;
            this.btnPat.Text = "Pat";
            this.btnPat.UseVisualStyleBackColor = true;
            this.btnPat.Click += new System.EventHandler(this.btnPat_Click);
            // 
            // lblGagnant
            // 
            this.lblGagnant.Location = new System.Drawing.Point(21, 171);
            this.lblGagnant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGagnant.Name = "lblGagnant";
            this.lblGagnant.Size = new System.Drawing.Size(265, 53);
            this.lblGagnant.TabIndex = 40;
            this.lblGagnant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(183, 583);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(100, 28);
            this.btnQuitter.TabIndex = 41;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnRejouer
            // 
            this.btnRejouer.Location = new System.Drawing.Point(29, 583);
            this.btnRejouer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(100, 28);
            this.btnRejouer.TabIndex = 42;
            this.btnRejouer.Text = "Rejouer";
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblGagnant);
            this.Controls.Add(this.btnPat);
            this.Controls.Add(this.lblAIPromotion);
            this.Controls.Add(this.lblAICoordArr);
            this.Controls.Add(this.lblAICoordDep);
            this.Controls.Add(this.pnlPieceN);
            this.Controls.Add(this.pnlPieceB);
            this.Controls.Add(this.lblTrait);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCoordH);
            this.Controls.Add(this.lblCoordG);
            this.Controls.Add(this.lblCoordF);
            this.Controls.Add(this.lblCoordE);
            this.Controls.Add(this.lblCoordD);
            this.Controls.Add(this.lblCoordC);
            this.Controls.Add(this.lblCoordB);
            this.Controls.Add(this.lblCoordA);
            this.Controls.Add(this.lblCoord1);
            this.Controls.Add(this.lblCoord2);
            this.Controls.Add(this.lblCoord3);
            this.Controls.Add(this.lblCoord4);
            this.Controls.Add(this.lblCoord5);
            this.Controls.Add(this.lblCoord6);
            this.Controls.Add(this.lblCoord7);
            this.Controls.Add(this.lblCoord8);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.pnlPlateau);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Gestionnaire de jeu d\'Echec";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlPlateau;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblCoord8;
        private System.Windows.Forms.Label lblCoord7;
        private System.Windows.Forms.Label lblCoord6;
        private System.Windows.Forms.Label lblCoord5;
        private System.Windows.Forms.Label lblCoord4;
        private System.Windows.Forms.Label lblCoord3;
        private System.Windows.Forms.Label lblCoord2;
        private System.Windows.Forms.Label lblCoord1;
        private System.Windows.Forms.Label lblCoordA;
        private System.Windows.Forms.Label lblCoordB;
        private System.Windows.Forms.Label lblCoordC;
        private System.Windows.Forms.Label lblCoordD;
        private System.Windows.Forms.Label lblCoordE;
        private System.Windows.Forms.Label lblCoordF;
        private System.Windows.Forms.Label lblCoordG;
        private System.Windows.Forms.Label lblCoordH;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Label lblTrait;
        private System.Windows.Forms.Panel pnlPieceB;
        private System.Windows.Forms.Panel pnlPieceN;
        private System.Windows.Forms.Timer tmrB;
        private System.Windows.Forms.Timer tmrN;
        private System.Windows.Forms.Label lblAICoordDep;
        private System.Windows.Forms.Label lblAICoordArr;
        private System.Windows.Forms.Label lblAIPromotion;
        private System.Windows.Forms.Button btnPat;
        private System.Windows.Forms.Label lblGagnant;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnRejouer;
    }
}

