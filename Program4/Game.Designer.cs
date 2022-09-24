namespace Program4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.MapSizeButton = new System.Windows.Forms.Button();
            this.MapRows = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MapCol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RowGuess = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GuessEnterButton = new System.Windows.Forms.Button();
            this.ColumnGuess = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Instructions = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MapOutput = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MapSizeButton
            // 
            this.MapSizeButton.Location = new System.Drawing.Point(124, 55);
            this.MapSizeButton.Name = "MapSizeButton";
            this.MapSizeButton.Size = new System.Drawing.Size(57, 23);
            this.MapSizeButton.TabIndex = 0;
            this.MapSizeButton.Text = "Enter";
            this.MapSizeButton.UseVisualStyleBackColor = true;
            this.MapSizeButton.Click += new System.EventHandler(this.MapSizeButton_Click);
            // 
            // MapRows
            // 
            this.MapRows.Location = new System.Drawing.Point(6, 55);
            this.MapRows.Name = "MapRows";
            this.MapRows.Size = new System.Drawing.Size(34, 22);
            this.MapRows.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rows";
            // 
            // MapCol
            // 
            this.MapCol.Location = new System.Drawing.Point(64, 55);
            this.MapCol.Name = "MapCol";
            this.MapCol.Size = new System.Drawing.Size(44, 22);
            this.MapCol.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Columns";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MapRows);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MapSizeButton);
            this.groupBox1.Controls.Add(this.MapCol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map Size";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RowGuess);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.GuessEnterButton);
            this.groupBox2.Controls.Add(this.ColumnGuess);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Guess";
            // 
            // RowGuess
            // 
            this.RowGuess.Location = new System.Drawing.Point(6, 55);
            this.RowGuess.Name = "RowGuess";
            this.RowGuess.Size = new System.Drawing.Size(34, 22);
            this.RowGuess.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Column #";
            // 
            // GuessEnterButton
            // 
            this.GuessEnterButton.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessEnterButton.Location = new System.Drawing.Point(124, 55);
            this.GuessEnterButton.Name = "GuessEnterButton";
            this.GuessEnterButton.Size = new System.Drawing.Size(57, 23);
            this.GuessEnterButton.TabIndex = 0;
            this.GuessEnterButton.Text = "Enter";
            this.GuessEnterButton.UseVisualStyleBackColor = true;
            this.GuessEnterButton.Click += new System.EventHandler(this.GuessEnterButton_Click);
            // 
            // ColumnGuess
            // 
            this.ColumnGuess.Location = new System.Drawing.Point(64, 55);
            this.ColumnGuess.Name = "ColumnGuess";
            this.ColumnGuess.Size = new System.Drawing.Size(44, 22);
            this.ColumnGuess.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Row #";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.ForestGreen;
            this.Title.Location = new System.Drawing.Point(300, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(262, 32);
            this.Title.TabIndex = 9;
            this.Title.Text = "Tropical Island Game!";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(568, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Instructions
            // 
            this.Instructions.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.ForeColor = System.Drawing.Color.ForestGreen;
            this.Instructions.Location = new System.Drawing.Point(12, 27);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(200, 35);
            this.Instructions.TabIndex = 11;
            this.Instructions.Text = "Instructions";
            this.Instructions.UseVisualStyleBackColor = true;
            this.Instructions.Click += new System.EventHandler(this.Instructions_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MapOutput);
            this.groupBox3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox3.Location = new System.Drawing.Point(272, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 219);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Map";
            // 
            // MapOutput
            // 
            this.MapOutput.AutoSize = true;
            this.MapOutput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapOutput.Location = new System.Drawing.Point(30, 21);
            this.MapOutput.Name = "MapOutput";
            this.MapOutput.Size = new System.Drawing.Size(0, 22);
            this.MapOutput.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(238, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.QuitButton.Location = new System.Drawing.Point(728, 254);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(102, 53);
            this.QuitButton.TabIndex = 7;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.RestartButton.Location = new System.Drawing.Point(620, 254);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(102, 53);
            this.RestartButton.TabIndex = 14;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(856, 341);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Game";
            this.Text = "Tropical Island Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button MapSizeButton;
        public System.Windows.Forms.TextBox MapRows;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox MapCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox RowGuess;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button GuessEnterButton;
        public System.Windows.Forms.TextBox ColumnGuess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Instructions;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label MapOutput;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button RestartButton;
    }
}

