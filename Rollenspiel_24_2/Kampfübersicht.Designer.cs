namespace Rollenspiel_24_2
{
    partial class Kampfübersicht
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
            StatGegner = new ListBox();
            StatSpieler = new ListBox();
            Attack = new Button();
            Item = new Button();
            Fliehen = new Button();
            SuspendLayout();
            // 
            // StatGegner
            // 
            StatGegner.FormattingEnabled = true;
            StatGegner.ItemHeight = 15;
            StatGegner.Location = new Point(555, 31);
            StatGegner.Name = "StatGegner";
            StatGegner.Size = new Size(222, 334);
            StatGegner.TabIndex = 0;
            // 
            // StatSpieler
            // 
            StatSpieler.FormattingEnabled = true;
            StatSpieler.ItemHeight = 15;
            StatSpieler.Location = new Point(12, 31);
            StatSpieler.Name = "StatSpieler";
            StatSpieler.Size = new Size(222, 334);
            StatSpieler.TabIndex = 1;
            // 
            // Attack
            // 
            Attack.Font = new Font("Segoe UI", 15F);
            Attack.Location = new Point(326, 70);
            Attack.Name = "Attack";
            Attack.Size = new Size(146, 60);
            Attack.TabIndex = 2;
            Attack.Text = "Attack";
            Attack.UseVisualStyleBackColor = true;
            Attack.Click += Attack_Click;
            // 
            // Item
            // 
            Item.Font = new Font("Segoe UI", 15F);
            Item.Location = new Point(326, 170);
            Item.Name = "Item";
            Item.Size = new Size(146, 60);
            Item.TabIndex = 3;
            Item.Text = "Item";
            Item.UseVisualStyleBackColor = true;
            // 
            // Fliehen
            // 
            Fliehen.Font = new Font("Segoe UI", 15F);
            Fliehen.Location = new Point(326, 293);
            Fliehen.Name = "Fliehen";
            Fliehen.Size = new Size(146, 60);
            Fliehen.TabIndex = 4;
            Fliehen.Text = "Fliehen";
            Fliehen.UseVisualStyleBackColor = true;
            // 
            // Kampfübersicht
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Fliehen);
            Controls.Add(Item);
            Controls.Add(Attack);
            Controls.Add(StatSpieler);
            Controls.Add(StatGegner);
            Name = "Kampfübersicht";
            Text = "Kampfübersicht";
            ResumeLayout(false);
        }

        #endregion

        private ListBox StatGegner;
        private ListBox StatSpieler;
        private Button Attack;
        private Button Item;
        private Button Fliehen;
    }
}