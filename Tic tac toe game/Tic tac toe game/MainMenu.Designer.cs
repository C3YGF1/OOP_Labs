namespace Tic_tac_toe_game
{
    partial class MainMenu
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
            this.lbClose = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbLoses = new System.Windows.Forms.Label();
            this.lbWins = new System.Windows.Forms.Label();
            this.lbGames = new System.Windows.Forms.Label();
            this.lbRating = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbInformation = new System.Windows.Forms.Label();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.lbUsers = new System.Windows.Forms.Label();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.buttonDeserialize = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbClose.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbClose.ForeColor = System.Drawing.Color.White;
            this.lbClose.Location = new System.Drawing.Point(311, 0);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(29, 30);
            this.lbClose.TabIndex = 0;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            this.lbClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.lbClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Black;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.lbClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(340, 37);
            this.panelTop.TabIndex = 14;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Main menu";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.lbInformation);
            this.MainPanel.Controls.Add(this.lvUsers);
            this.MainPanel.Controls.Add(this.lbUsers);
            this.MainPanel.Controls.Add(this.buttonSerialize);
            this.MainPanel.Controls.Add(this.buttonDeserialize);
            this.MainPanel.Controls.Add(this.buttonSelect);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 37);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(340, 366);
            this.MainPanel.TabIndex = 15;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tbUsername);
            this.panel2.Controls.Add(this.lbUsername);
            this.panel2.Location = new System.Drawing.Point(174, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 178);
            this.panel2.TabIndex = 37;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(9, 137);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(138, 31);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.buttonAdd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbLoses);
            this.panel3.Controls.Add(this.lbWins);
            this.panel3.Controls.Add(this.lbGames);
            this.panel3.Controls.Add(this.lbRating);
            this.panel3.Location = new System.Drawing.Point(4, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 81);
            this.panel3.TabIndex = 4;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // lbLoses
            // 
            this.lbLoses.AutoSize = true;
            this.lbLoses.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLoses.Location = new System.Drawing.Point(4, 56);
            this.lbLoses.Name = "lbLoses";
            this.lbLoses.Size = new System.Drawing.Size(59, 18);
            this.lbLoses.TabIndex = 8;
            this.lbLoses.Text = "Loses: ";
            // 
            // lbWins
            // 
            this.lbWins.AutoSize = true;
            this.lbWins.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWins.Location = new System.Drawing.Point(4, 38);
            this.lbWins.Name = "lbWins";
            this.lbWins.Size = new System.Drawing.Size(50, 18);
            this.lbWins.TabIndex = 7;
            this.lbWins.Text = "Wins: ";
            // 
            // lbGames
            // 
            this.lbGames.AutoSize = true;
            this.lbGames.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbGames.Location = new System.Drawing.Point(4, 20);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(65, 18);
            this.lbGames.TabIndex = 6;
            this.lbGames.Text = "Games: ";
            // 
            // lbRating
            // 
            this.lbRating.AutoSize = true;
            this.lbRating.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRating.Location = new System.Drawing.Point(4, 2);
            this.lbRating.Name = "lbRating";
            this.lbRating.Size = new System.Drawing.Size(62, 18);
            this.lbRating.TabIndex = 5;
            this.lbRating.Text = "Rating: ";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.Location = new System.Drawing.Point(3, 22);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(148, 22);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.tbUsername.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.Location = new System.Drawing.Point(6, 4);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(80, 18);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username";
            this.lbUsername.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.lbUsername.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // lbInformation
            // 
            this.lbInformation.AutoSize = true;
            this.lbInformation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbInformation.Location = new System.Drawing.Point(174, 3);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(116, 22);
            this.lbInformation.TabIndex = 36;
            this.lbInformation.Text = "Information";
            // 
            // lvUsers
            // 
            this.lvUsers.Location = new System.Drawing.Point(11, 30);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(144, 178);
            this.lvUsers.TabIndex = 31;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.List;
            this.lvUsers.SelectedIndexChanged += new System.EventHandler(this.lvUsers_SelectedIndexChanged);
            this.lvUsers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.lvUsers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // lbUsers
            // 
            this.lbUsers.AutoSize = true;
            this.lbUsers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsers.Location = new System.Drawing.Point(12, 3);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(64, 22);
            this.lbUsers.TabIndex = 30;
            this.lbUsers.Text = "Users";
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.BackColor = System.Drawing.Color.Gray;
            this.buttonSerialize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSerialize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSerialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSerialize.Font = new System.Drawing.Font("Arial Black", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSerialize.Location = new System.Drawing.Point(0, 216);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(340, 50);
            this.buttonSerialize.TabIndex = 34;
            this.buttonSerialize.Text = "Serialize";
            this.buttonSerialize.UseVisualStyleBackColor = false;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            this.buttonSerialize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.buttonSerialize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // buttonDeserialize
            // 
            this.buttonDeserialize.BackColor = System.Drawing.Color.Gray;
            this.buttonDeserialize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeserialize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDeserialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeserialize.Font = new System.Drawing.Font("Arial Black", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeserialize.Location = new System.Drawing.Point(0, 266);
            this.buttonDeserialize.Name = "buttonDeserialize";
            this.buttonDeserialize.Size = new System.Drawing.Size(340, 50);
            this.buttonDeserialize.TabIndex = 32;
            this.buttonDeserialize.Text = "Deserialize";
            this.buttonDeserialize.UseVisualStyleBackColor = false;
            this.buttonDeserialize.Click += new System.EventHandler(this.buttonDeserialize_Click);
            this.buttonDeserialize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.buttonDeserialize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.Gray;
            this.buttonSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.Font = new System.Drawing.Font("Arial Black", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSelect.Location = new System.Drawing.Point(0, 316);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(340, 50);
            this.buttonSelect.TabIndex = 33;
            this.buttonSelect.Text = "Select profile";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            this.buttonSelect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.buttonSelect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 403);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbClose;
        private Panel panelTop;
        private Panel MainPanel;
        private Panel panel2;
        private TextBox tbUsername;
        private Label lbUsername;
        private Label lbInformation;
        private ListView lvUsers;
        private Label lbUsers;
        private Button buttonSerialize;
        private Button buttonDeserialize;
        private Button buttonSelect;
        private Panel panel3;
        private Label lbLoses;
        private Label lbWins;
        private Label lbGames;
        private Label lbRating;
        private Button buttonAdd;
        private Label label1;
    }
}