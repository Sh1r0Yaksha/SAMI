namespace SAMI
{
    partial class HaveSALTForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameOfModsLabel = new System.Windows.Forms.Label();
            this.modsDataGridView = new System.Windows.Forms.DataGridView();
            this.installModButton = new System.Windows.Forms.Button();
            this.footerLabel = new System.Windows.Forms.Label();
            this.modsWebsiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.launchGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameOfModsLabel
            // 
            this.nameOfModsLabel.Location = new System.Drawing.Point(12, 9);
            this.nameOfModsLabel.Name = "nameOfModsLabel";
            this.nameOfModsLabel.Size = new System.Drawing.Size(368, 25);
            this.nameOfModsLabel.TabIndex = 0;
            this.nameOfModsLabel.Text = "Here are the mods currently available for Smol Ame";
            // 
            // modsDataGridView
            // 
            this.modsDataGridView.AllowUserToAddRows = false;
            this.modsDataGridView.AllowUserToDeleteRows = false;
            this.modsDataGridView.AllowUserToResizeColumns = false;
            this.modsDataGridView.AllowUserToResizeRows = false;
            this.modsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.modsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.modsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.modsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modsDataGridView.EnableHeadersVisualStyles = false;
            this.modsDataGridView.Location = new System.Drawing.Point(12, 37);
            this.modsDataGridView.MultiSelect = false;
            this.modsDataGridView.Name = "modsDataGridView";
            this.modsDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.modsDataGridView.RowHeadersVisible = false;
            this.modsDataGridView.RowHeadersWidth = 51;
            this.modsDataGridView.RowTemplate.Height = 29;
            this.modsDataGridView.RowTemplate.ReadOnly = true;
            this.modsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modsDataGridView.ShowEditingIcon = false;
            this.modsDataGridView.ShowRowErrors = false;
            this.modsDataGridView.Size = new System.Drawing.Size(585, 350);
            this.modsDataGridView.TabIndex = 1;
            // 
            // installModButton
            // 
            this.installModButton.Location = new System.Drawing.Point(12, 393);
            this.installModButton.Name = "installModButton";
            this.installModButton.Size = new System.Drawing.Size(191, 29);
            this.installModButton.TabIndex = 2;
            this.installModButton.Text = "Install/Uninstall mod";
            this.installModButton.UseVisualStyleBackColor = true;
            this.installModButton.Click += new System.EventHandler(this.installModButton_Click);
            // 
            // footerLabel
            // 
            this.footerLabel.Location = new System.Drawing.Point(12, 434);
            this.footerLabel.Name = "footerLabel";
            this.footerLabel.Size = new System.Drawing.Size(585, 27);
            this.footerLabel.TabIndex = 3;
            this.footerLabel.Text = "Want to know more about the mods? Or trying to make new mods for the game? Visit";
            // 
            // modsWebsiteLinkLabel
            // 
            this.modsWebsiteLinkLabel.AutoSize = true;
            this.modsWebsiteLinkLabel.Location = new System.Drawing.Point(160, 461);
            this.modsWebsiteLinkLabel.Name = "modsWebsiteLinkLabel";
            this.modsWebsiteLinkLabel.Size = new System.Drawing.Size(234, 20);
            this.modsWebsiteLinkLabel.TabIndex = 4;
            this.modsWebsiteLinkLabel.TabStop = true;
            this.modsWebsiteLinkLabel.Text = "https://smolamemods.netlify.app/";
            this.modsWebsiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.modsWebsiteLinkLabel_LinkClicked);
            // 
            // launchGameButton
            // 
            this.launchGameButton.Location = new System.Drawing.Point(476, 393);
            this.launchGameButton.Name = "launchGameButton";
            this.launchGameButton.Size = new System.Drawing.Size(121, 29);
            this.launchGameButton.TabIndex = 5;
            this.launchGameButton.Text = "Launch Game";
            this.launchGameButton.UseVisualStyleBackColor = true;
            this.launchGameButton.Click += new System.EventHandler(this.launchGameButton_Click);
            // 
            // HaveSALTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 502);
            this.Controls.Add(this.launchGameButton);
            this.Controls.Add(this.modsWebsiteLinkLabel);
            this.Controls.Add(this.footerLabel);
            this.Controls.Add(this.installModButton);
            this.Controls.Add(this.modsDataGridView);
            this.Controls.Add(this.nameOfModsLabel);
            this.Name = "HaveSALTForm";
            this.Text = "Smol Ame Mod Installer";
            this.Load += new System.EventHandler(this.HaveSALTForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameOfModsLabel;
        private DataGridView modsDataGridView;
        private Button installModButton;
        private Label footerLabel;
        private LinkLabel modsWebsiteLinkLabel;
        private Button launchGameButton;
    }
}