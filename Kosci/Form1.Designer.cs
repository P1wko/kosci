namespace Kosci
{
    partial class Menu
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
            this.btnGraj = new System.Windows.Forms.Button();
            this.btnZasady = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGraj
            // 
            this.btnGraj.Location = new System.Drawing.Point(233, 140);
            this.btnGraj.Name = "btnGraj";
            this.btnGraj.Size = new System.Drawing.Size(65, 40);
            this.btnGraj.TabIndex = 0;
            this.btnGraj.Text = "Graj";
            this.btnGraj.UseVisualStyleBackColor = true;
            this.btnGraj.Click += new System.EventHandler(this.btnGraj_Click);
            // 
            // btnZasady
            // 
            this.btnZasady.Location = new System.Drawing.Point(233, 192);
            this.btnZasady.Name = "btnZasady";
            this.btnZasady.Size = new System.Drawing.Size(65, 40);
            this.btnZasady.TabIndex = 1;
            this.btnZasady.Text = "Zasady Gry";
            this.btnZasady.UseVisualStyleBackColor = true;
            this.btnZasady.Click += new System.EventHandler(this.btnZasady_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(233, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Wyjście";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 443);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnZasady);
            this.Controls.Add(this.btnGraj);
            this.Name = "Menu";
            this.Text = "Kości";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGraj;
        private Button btnZasady;
        private Button btnExit;
    }
}