
namespace Rollenspiel_24_2
{
    partial class GUISpieler
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
            lblPlayer = new Label();
            lblLebenDesc = new Label();
            lblManaDesc = new Label();
            lblRuestungDesc = new Label();
            lblAngriffDesc = new Label();
            lblKlasseDesc = new Label();
            lblErfahrungDesc = new Label();
            lblLevel = new Label();
            lblLeben = new Label();
            lblMana = new Label();
            lblAngriff = new Label();
            lblRuestung = new Label();
            lblKlasse = new Label();
            btnInventar = new Button();
            btnBeenden = new Button();
            SuspendLayout();
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayer.Location = new Point(162, 46);
            lblPlayer.Margin = new Padding(4, 0, 4, 0);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(107, 17);
            lblPlayer.TabIndex = 0;
            lblPlayer.Text = "Spielername";
            lblPlayer.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLebenDesc
            // 
            lblLebenDesc.AutoSize = true;
            lblLebenDesc.Location = new Point(87, 122);
            lblLebenDesc.Margin = new Padding(4, 0, 4, 0);
            lblLebenDesc.Name = "lblLebenDesc";
            lblLebenDesc.Size = new Size(53, 17);
            lblLebenDesc.TabIndex = 1;
            lblLebenDesc.Text = "Leben";
            // 
            // lblManaDesc
            // 
            lblManaDesc.AutoSize = true;
            lblManaDesc.Location = new Point(87, 152);
            lblManaDesc.Margin = new Padding(4, 0, 4, 0);
            lblManaDesc.Name = "lblManaDesc";
            lblManaDesc.Size = new Size(44, 17);
            lblManaDesc.TabIndex = 2;
            lblManaDesc.Text = "Mana";
            lblManaDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblRuestungDesc
            // 
            lblRuestungDesc.AutoSize = true;
            lblRuestungDesc.Location = new Point(288, 152);
            lblRuestungDesc.Margin = new Padding(4, 0, 4, 0);
            lblRuestungDesc.Name = "lblRuestungDesc";
            lblRuestungDesc.Size = new Size(71, 17);
            lblRuestungDesc.TabIndex = 3;
            lblRuestungDesc.Text = "Rüstung";
            lblRuestungDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAngriffDesc
            // 
            lblAngriffDesc.AutoSize = true;
            lblAngriffDesc.Location = new Point(288, 122);
            lblAngriffDesc.Margin = new Padding(4, 0, 4, 0);
            lblAngriffDesc.Name = "lblAngriffDesc";
            lblAngriffDesc.Size = new Size(71, 17);
            lblAngriffDesc.TabIndex = 4;
            lblAngriffDesc.Text = "Angriff";
            lblAngriffDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblKlasseDesc
            // 
            lblKlasseDesc.AutoSize = true;
            lblKlasseDesc.Location = new Point(500, 122);
            lblKlasseDesc.Margin = new Padding(4, 0, 4, 0);
            lblKlasseDesc.Name = "lblKlasseDesc";
            lblKlasseDesc.Size = new Size(62, 17);
            lblKlasseDesc.TabIndex = 5;
            lblKlasseDesc.Text = "Klasse";
            lblKlasseDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblErfahrungDesc
            // 
            lblErfahrungDesc.AutoSize = true;
            lblErfahrungDesc.Location = new Point(464, 46);
            lblErfahrungDesc.Margin = new Padding(4, 0, 4, 0);
            lblErfahrungDesc.Name = "lblErfahrungDesc";
            lblErfahrungDesc.Size = new Size(98, 17);
            lblErfahrungDesc.TabIndex = 6;
            lblErfahrungDesc.Text = "Erfahrung:";
            lblErfahrungDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(692, 46);
            lblLevel.Margin = new Padding(4, 0, 4, 0);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(17, 17);
            lblLevel.TabIndex = 7;
            lblLevel.Text = "1";
            lblLevel.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLeben
            // 
            lblLeben.AutoSize = true;
            lblLeben.BackColor = SystemColors.Menu;
            lblLeben.Font = new Font("Ebrima", 11.25F, FontStyle.Bold);
            lblLeben.Location = new Point(162, 122);
            lblLeben.Margin = new Padding(4, 0, 4, 0);
            lblLeben.Name = "lblLeben";
            lblLeben.Size = new Size(18, 20);
            lblLeben.TabIndex = 8;
            lblLeben.Text = "1";
            lblLeben.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblMana
            // 
            lblMana.AutoSize = true;
            lblMana.BackColor = SystemColors.Menu;
            lblMana.Font = new Font("Ebrima", 11.25F, FontStyle.Bold);
            lblMana.Location = new Point(162, 152);
            lblMana.Margin = new Padding(4, 0, 4, 0);
            lblMana.Name = "lblMana";
            lblMana.Size = new Size(18, 20);
            lblMana.TabIndex = 9;
            lblMana.Text = "1";
            lblMana.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAngriff
            // 
            lblAngriff.AutoSize = true;
            lblAngriff.BackColor = SystemColors.Menu;
            lblAngriff.Font = new Font("Ebrima", 11.25F, FontStyle.Bold);
            lblAngriff.Location = new Point(388, 122);
            lblAngriff.Margin = new Padding(4, 0, 4, 0);
            lblAngriff.Name = "lblAngriff";
            lblAngriff.Size = new Size(18, 20);
            lblAngriff.TabIndex = 10;
            lblAngriff.Text = "1";
            lblAngriff.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblRuestung
            // 
            lblRuestung.AutoSize = true;
            lblRuestung.BackColor = SystemColors.Menu;
            lblRuestung.Font = new Font("Ebrima", 11.25F, FontStyle.Bold);
            lblRuestung.Location = new Point(388, 152);
            lblRuestung.Margin = new Padding(4, 0, 4, 0);
            lblRuestung.Name = "lblRuestung";
            lblRuestung.Size = new Size(18, 20);
            lblRuestung.TabIndex = 11;
            lblRuestung.Text = "1";
            lblRuestung.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblKlasse
            // 
            lblKlasse.AutoSize = true;
            lblKlasse.BackColor = SystemColors.Menu;
            lblKlasse.Font = new Font("Ebrima", 11.25F, FontStyle.Bold);
            lblKlasse.Location = new Point(617, 122);
            lblKlasse.Margin = new Padding(4, 0, 4, 0);
            lblKlasse.Name = "lblKlasse";
            lblKlasse.Size = new Size(44, 20);
            lblKlasse.TabIndex = 12;
            lblKlasse.Text = "none";
            lblKlasse.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnInventar
            // 
            btnInventar.Location = new Point(162, 270);
            btnInventar.Name = "btnInventar";
            btnInventar.Size = new Size(112, 33);
            btnInventar.TabIndex = 13;
            btnInventar.Text = "Inventar";
            btnInventar.UseVisualStyleBackColor = true;
            // 
            // btnBeenden
            // 
            btnBeenden.Location = new Point(628, 359);
            btnBeenden.Name = "btnBeenden";
            btnBeenden.Size = new Size(115, 28);
            btnBeenden.TabIndex = 14;
            btnBeenden.Text = "schließen";
            btnBeenden.UseVisualStyleBackColor = true;
            btnBeenden.Click += btnBeenden_Click;
            // 
            // GUISpieler
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 426);
            Controls.Add(btnBeenden);
            Controls.Add(btnInventar);
            Controls.Add(lblKlasse);
            Controls.Add(lblRuestung);
            Controls.Add(lblAngriff);
            Controls.Add(lblMana);
            Controls.Add(lblLeben);
            Controls.Add(lblLevel);
            Controls.Add(lblErfahrungDesc);
            Controls.Add(lblKlasseDesc);
            Controls.Add(lblAngriffDesc);
            Controls.Add(lblRuestungDesc);
            Controls.Add(lblManaDesc);
            Controls.Add(lblLebenDesc);
            Controls.Add(lblPlayer);
            Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "GUISpieler";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayer;
        private Label lblLebenDesc;
        private Label lblManaDesc;
        private Label lblRuestungDesc;
        private Label lblAngriffDesc;
        private Label lblKlasseDesc;
        private Label lblErfahrungDesc;
        private Label lblLevel;
        private Label lblLeben;
        private Label lblMana;
        private Label lblAngriff;
        private Label lblRuestung;
        private Label lblKlasse;
        private Button btnInventar;
        private Button btnBeenden;
    }
}