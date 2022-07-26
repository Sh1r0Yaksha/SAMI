namespace SAMI
{
    partial class IntroductionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroductionForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.introductionLabel = new System.Windows.Forms.Label();
            this.specifySALTLabel = new System.Windows.Forms.Label();
            this.haveSALTButton = new System.Windows.Forms.Button();
            this.notSALTButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 478);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // introductionLabel
            // 
            this.introductionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.introductionLabel.Location = new System.Drawing.Point(275, 12);
            this.introductionLabel.Name = "introductionLabel";
            this.introductionLabel.Size = new System.Drawing.Size(333, 272);
            this.introductionLabel.TabIndex = 1;
            this.introductionLabel.Text = "This is a program which automatically downloads and installs the required compone" +
    "nts needed to install mods in the game Smol Ame";
            // 
            // specifySALTLabel
            // 
            this.specifySALTLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specifySALTLabel.Location = new System.Drawing.Point(275, 284);
            this.specifySALTLabel.Name = "specifySALTLabel";
            this.specifySALTLabel.Size = new System.Drawing.Size(300, 72);
            this.specifySALTLabel.TabIndex = 2;
            this.specifySALTLabel.Text = "Please specify if you have SALT installed or not";
            // 
            // haveSALTButton
            // 
            this.haveSALTButton.Location = new System.Drawing.Point(275, 461);
            this.haveSALTButton.Name = "haveSALTButton";
            this.haveSALTButton.Size = new System.Drawing.Size(147, 29);
            this.haveSALTButton.TabIndex = 3;
            this.haveSALTButton.Text = "I have SALT";
            this.haveSALTButton.UseVisualStyleBackColor = true;
            this.haveSALTButton.Click += new System.EventHandler(this.haveSALTButton_Click);
            // 
            // notSALTButton
            // 
            this.notSALTButton.Location = new System.Drawing.Point(446, 461);
            this.notSALTButton.Name = "notSALTButton";
            this.notSALTButton.Size = new System.Drawing.Size(147, 29);
            this.notSALTButton.TabIndex = 4;
            this.notSALTButton.Text = "I do not have SALT";
            this.notSALTButton.UseVisualStyleBackColor = true;
            // 
            // IntroductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 502);
            this.Controls.Add(this.notSALTButton);
            this.Controls.Add(this.haveSALTButton);
            this.Controls.Add(this.specifySALTLabel);
            this.Controls.Add(this.introductionLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IntroductionForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label introductionLabel;
        private Label specifySALTLabel;
        private Button haveSALTButton;
        private Button notSALTButton;
    }
}