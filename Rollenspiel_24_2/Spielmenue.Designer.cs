namespace Rollenspiel_24_2
{
    partial class Spielmenue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Logik.Karte karte1 = new Logik.Karte();
            kartenView1 = new KartenView();
            btnHoch = new Button();
            btnRunter = new Button();
            btnRechts = new Button();
            btnLinks = new Button();
            btnSpieler = new Button();
            btnInventar = new Button();
            SuspendLayout();
            // 
            // kartenView1
            // 
            kartenView1.BorderStyle = BorderStyle.Fixed3D;
            kartenView1.Karte = karte1;
            kartenView1.Location = new Point(72, 53);
            kartenView1.Name = "kartenView1";
            kartenView1.Size = new Size(364, 342);
            kartenView1.TabIndex = 0;
            kartenView1.Load += kartenView1_Load;
            // 
            // btnHoch
            // 
            btnHoch.Cursor = Cursors.PanNorth;
            btnHoch.Location = new Point(591, 259);
            btnHoch.Name = "btnHoch";
            btnHoch.Size = new Size(75, 30);
            btnHoch.TabIndex = 1;
            btnHoch.Text = "Hoch";
            btnHoch.UseVisualStyleBackColor = true;
            btnHoch.Click += btn_oben_Click;
            // 
            // btnRunter
            // 
            btnRunter.Cursor = Cursors.PanSouth;
            btnRunter.Location = new Point(591, 356);
            btnRunter.Name = "btnRunter";
            btnRunter.Size = new Size(75, 30);
            btnRunter.TabIndex = 2;
            btnRunter.Text = "Runter";
            btnRunter.UseVisualStyleBackColor = true;
            btnRunter.Click += btnRunter_Click;
            // 
            // btnRechts
            // 
            btnRechts.Cursor = Cursors.PanEast;
            btnRechts.Location = new Point(665, 310);
            btnRechts.Name = "btnRechts";
            btnRechts.Size = new Size(75, 30);
            btnRechts.TabIndex = 3;
            btnRechts.Text = "Rechts";
            btnRechts.UseVisualStyleBackColor = true;
            btnRechts.Click += button2_Click;
            // 
            // btnLinks
            // 
            btnLinks.Cursor = Cursors.PanWest;
            btnLinks.Location = new Point(520, 310);
            btnLinks.Name = "btnLinks";
            btnLinks.Size = new Size(75, 30);
            btnLinks.TabIndex = 4;
            btnLinks.Text = "Links";
            btnLinks.UseVisualStyleBackColor = true;
            btnLinks.Click += btnLinks_Click;
            // 
            // btnSpieler
            // 
            btnSpieler.Location = new Point(520, 90);
            btnSpieler.Name = "btnSpieler";
            btnSpieler.Size = new Size(220, 30);
            btnSpieler.TabIndex = 5;
            btnSpieler.Text = "Spieler";
            btnSpieler.UseVisualStyleBackColor = true;
            // 
            // btnInventar
            // 
            btnInventar.Location = new Point(520, 150);
            btnInventar.Name = "btnInventar";
            btnInventar.Size = new Size(220, 30);
            btnInventar.TabIndex = 6;
            btnInventar.Text = "Inventar";
            btnInventar.UseVisualStyleBackColor = true;
            // 
            // Spielmenue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(784, 441);
            Controls.Add(btnInventar);
            Controls.Add(btnSpieler);
            Controls.Add(btnLinks);
            Controls.Add(btnRechts);
            Controls.Add(btnRunter);
            Controls.Add(btnHoch);
            Controls.Add(kartenView1);
            Name = "Spielmenue";
            Text = "Spielmenue";
            ResumeLayout(false);
        }

        #endregion

        private KartenView kartenView1;
        private Button btnHoch;
        private Button btnRunter;
        private Button btnRechts;
        private Button btnLinks;
        private Button btnSpieler;
        private Button btnInventar;
    }
}