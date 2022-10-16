namespace TournamentBracketUI
{
    partial class TournamentViewerForm : Form
    {
        private Label Header;
        private Label TournamentName;
        private Label Round;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.Header = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.Round = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Header.Location = new System.Drawing.Point(35, 23);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(198, 34);
            this.Header.TabIndex = 0;
            this.Header.Text = "Tournament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TournamentName.Location = new System.Drawing.Point(239, 23);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(89, 34);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "None";
            // 
            // Round
            // 
            this.Round.AutoSize = true;
            this.Round.Location = new System.Drawing.Point(93, 75);
            this.Round.Name = "Round";
            this.Round.Size = new System.Drawing.Size(72, 21);
            this.Round.TabIndex = 2;
            this.Round.Text = "Round:";
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 472);
            this.Controls.Add(this.Round);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}