namespace Kosci
{
    partial class Game
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.brnPowrot = new System.Windows.Forms.Button();
            this.dice01 = new System.Windows.Forms.PictureBox();
            this.dice02 = new System.Windows.Forms.PictureBox();
            this.dice03 = new System.Windows.Forms.PictureBox();
            this.dice04 = new System.Windows.Forms.PictureBox();
            this.dice05 = new System.Windows.Forms.PictureBox();
            this.dice06 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dice01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice06)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(24, 278);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(153, 58);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Rzuć kośćmi";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.button1_Click);
            // 
            // brnPowrot
            // 
            this.brnPowrot.Location = new System.Drawing.Point(443, 390);
            this.brnPowrot.Name = "brnPowrot";
            this.brnPowrot.Size = new System.Drawing.Size(148, 48);
            this.brnPowrot.TabIndex = 2;
            this.brnPowrot.Text = "Menu Główne";
            this.brnPowrot.UseVisualStyleBackColor = true;
            this.brnPowrot.Click += new System.EventHandler(this.brnPowrot_Click);
            // 
            // dice01
            // 
            this.dice01.Image = global::Kosci.Properties.Resources.dices6;
            this.dice01.Location = new System.Drawing.Point(12, 12);
            this.dice01.Name = "dice01";
            this.dice01.Size = new System.Drawing.Size(77, 77);
            this.dice01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice01.TabIndex = 3;
            this.dice01.TabStop = false;
            this.dice01.Click += new System.EventHandler(this.dice01_Click);
            // 
            // dice02
            // 
            this.dice02.Image = global::Kosci.Properties.Resources.dices1;
            this.dice02.Location = new System.Drawing.Point(110, 12);
            this.dice02.Name = "dice02";
            this.dice02.Size = new System.Drawing.Size(77, 77);
            this.dice02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice02.TabIndex = 4;
            this.dice02.TabStop = false;
            // 
            // dice03
            // 
            this.dice03.Image = global::Kosci.Properties.Resources.dices1;
            this.dice03.Location = new System.Drawing.Point(12, 95);
            this.dice03.Name = "dice03";
            this.dice03.Size = new System.Drawing.Size(77, 77);
            this.dice03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice03.TabIndex = 5;
            this.dice03.TabStop = false;
            // 
            // dice04
            // 
            this.dice04.Image = global::Kosci.Properties.Resources.dices1;
            this.dice04.Location = new System.Drawing.Point(110, 95);
            this.dice04.Name = "dice04";
            this.dice04.Size = new System.Drawing.Size(77, 77);
            this.dice04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice04.TabIndex = 6;
            this.dice04.TabStop = false;
            // 
            // dice05
            // 
            this.dice05.Image = global::Kosci.Properties.Resources.dices2;
            this.dice05.Location = new System.Drawing.Point(12, 178);
            this.dice05.Name = "dice05";
            this.dice05.Size = new System.Drawing.Size(77, 77);
            this.dice05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice05.TabIndex = 7;
            this.dice05.TabStop = false;
            // 
            // dice06
            // 
            this.dice06.Image = global::Kosci.Properties.Resources.dices2;
            this.dice06.Location = new System.Drawing.Point(110, 178);
            this.dice06.Name = "dice06";
            this.dice06.Size = new System.Drawing.Size(77, 77);
            this.dice06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice06.TabIndex = 8;
            this.dice06.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.dice06);
            this.Controls.Add(this.dice05);
            this.Controls.Add(this.dice04);
            this.Controls.Add(this.dice03);
            this.Controls.Add(this.dice02);
            this.Controls.Add(this.dice01);
            this.Controls.Add(this.brnPowrot);
            this.Controls.Add(this.btnRoll);
            this.Name = "Game";
            this.Text = "Kości";
            ((System.ComponentModel.ISupportInitialize)(this.dice01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice06)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRoll;
        private Button brnPowrot;
        private PictureBox dice01;
        private PictureBox dice02;
        private PictureBox dice03;
        private PictureBox dice04;
        private PictureBox dice05;
        private PictureBox dice06;
    }
}