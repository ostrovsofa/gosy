namespace WinFormsApp1
{
    partial class FormGame
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
            buttonSave = new Button();
            buttonDeleteGame = new Button();
            buttonSavePlayer = new Button();
            button1 = new Button();
            btnDelete = new Button();
            listViewGamePlayers = new ListView();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(31, 28);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "buttonSave";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteGame
            // 
            buttonDeleteGame.Location = new Point(148, 28);
            buttonDeleteGame.Name = "buttonDeleteGame";
            buttonDeleteGame.Size = new Size(160, 29);
            buttonDeleteGame.TabIndex = 2;
            buttonDeleteGame.Text = "buttonDeleteGame";
            buttonDeleteGame.UseVisualStyleBackColor = true;
            // 
            // buttonSavePlayer
            // 
            buttonSavePlayer.Location = new Point(327, 28);
            buttonSavePlayer.Name = "buttonSavePlayer";
            buttonSavePlayer.Size = new Size(161, 29);
            buttonSavePlayer.TabIndex = 3;
            buttonSavePlayer.Text = "buttonSavePlayer";
            buttonSavePlayer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(509, 32);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(39, 83);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "button2";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // listViewGamePlayers
            // 
            listViewGamePlayers.Location = new Point(33, 155);
            listViewGamePlayers.Name = "listViewGamePlayers";
            listViewGamePlayers.Size = new Size(416, 244);
            listViewGamePlayers.TabIndex = 6;
            listViewGamePlayers.UseCompatibleStateImageBehavior = false;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewGamePlayers);
            Controls.Add(btnDelete);
            Controls.Add(button1);
            Controls.Add(buttonSavePlayer);
            Controls.Add(buttonDeleteGame);
            Controls.Add(buttonSave);
            Name = "FormGame";
            Text = "Form1";
            Load += FormGame_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSave;
        private Button buttonDeleteGame;
        private Button buttonSavePlayer;
        private Button button1;
        private Button btnDelete;
        private ListView listViewGamePlayers;
    }
}
