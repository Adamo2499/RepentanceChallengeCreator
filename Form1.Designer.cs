namespace RepentanceChallengeCreator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.challengePackName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.challengesList = new System.Windows.Forms.ListBox();
            this.createChallenge = new System.Windows.Forms.Button();
            this.modifyChallenge = new System.Windows.Forms.Button();
            this.removeChallenge = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repentance Challenge Creator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Challenge pack name: ";
            // 
            // challengePackName
            // 
            this.challengePackName.AutoSize = true;
            this.challengePackName.Location = new System.Drawing.Point(359, 38);
            this.challengePackName.Name = "challengePackName";
            this.challengePackName.Size = new System.Drawing.Size(132, 20);
            this.challengePackName.TabIndex = 2;
            this.challengePackName.Text = "My challenge pack";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // challengesList
            // 
            this.challengesList.FormattingEnabled = true;
            this.challengesList.ItemHeight = 20;
            this.challengesList.Location = new System.Drawing.Point(37, 67);
            this.challengesList.Name = "challengesList";
            this.challengesList.Size = new System.Drawing.Size(721, 304);
            this.challengesList.TabIndex = 4;
            // 
            // createChallenge
            // 
            this.createChallenge.Location = new System.Drawing.Point(37, 393);
            this.createChallenge.Name = "createChallenge";
            this.createChallenge.Size = new System.Drawing.Size(206, 29);
            this.createChallenge.TabIndex = 5;
            this.createChallenge.Text = "Create new challenge";
            this.createChallenge.UseVisualStyleBackColor = true;
            this.createChallenge.Click += new System.EventHandler(this.createChallenge_Click);
            // 
            // modifyChallenge
            // 
            this.modifyChallenge.Location = new System.Drawing.Point(304, 393);
            this.modifyChallenge.Name = "modifyChallenge";
            this.modifyChallenge.Size = new System.Drawing.Size(206, 29);
            this.modifyChallenge.TabIndex = 6;
            this.modifyChallenge.Text = "Modify challenge";
            this.modifyChallenge.UseVisualStyleBackColor = true;
            this.modifyChallenge.Click += new System.EventHandler(this.modifyChallenge_Click);
            // 
            // removeChallenge
            // 
            this.removeChallenge.Location = new System.Drawing.Point(552, 395);
            this.removeChallenge.Name = "removeChallenge";
            this.removeChallenge.Size = new System.Drawing.Size(206, 29);
            this.removeChallenge.TabIndex = 7;
            this.removeChallenge.Text = "Remove challenge";
            this.removeChallenge.UseVisualStyleBackColor = true;
            this.removeChallenge.Click += new System.EventHandler(this.removeChallenge_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Save Challenge Pack";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.removeChallenge);
            this.Controls.Add(this.modifyChallenge);
            this.Controls.Add(this.createChallenge);
            this.Controls.Add(this.challengesList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.challengePackName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Repentance Challenge Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label challengePackName;
        private Button button1;
        private ListBox challengesList;
        private Button createChallenge;
        private Button modifyChallenge;
        private Button removeChallenge;
        private Button button2;
        private Button button3;
    }
}