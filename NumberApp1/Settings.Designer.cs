namespace NumberExplorer
{
    partial class Settings
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
            this.checkTri = new System.Windows.Forms.CheckBox();
            this.checkSquare = new System.Windows.Forms.CheckBox();
            this.checkPent = new System.Windows.Forms.CheckBox();
            this.checkHex = new System.Windows.Forms.CheckBox();
            this.checkCube = new System.Windows.Forms.CheckBox();
            this.checkSum2Squares = new System.Windows.Forms.CheckBox();
            this.checkSum2Cubes = new System.Windows.Forms.CheckBox();
            this.checkSum3Squares = new System.Windows.Forms.CheckBox();
            this.checkSum3Cubes = new System.Windows.Forms.CheckBox();
            this.checkPerfect = new System.Windows.Forms.CheckBox();
            this.checkRepunit = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkTri
            // 
            this.checkTri.AutoSize = true;
            this.checkTri.Checked = true;
            this.checkTri.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTri.Location = new System.Drawing.Point(200, 49);
            this.checkTri.Name = "checkTri";
            this.checkTri.Size = new System.Drawing.Size(105, 21);
            this.checkTri.TabIndex = 0;
            this.checkTri.Text = "IsTriangular";
            this.checkTri.UseVisualStyleBackColor = true;
            this.checkTri.Click += new System.EventHandler(this.checkBoxAny_Click);
            // 
            // checkSquare
            // 
            this.checkSquare.AutoSize = true;
            this.checkSquare.Checked = true;
            this.checkSquare.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSquare.Location = new System.Drawing.Point(200, 111);
            this.checkSquare.Name = "checkSquare";
            this.checkSquare.Size = new System.Drawing.Size(90, 21);
            this.checkSquare.TabIndex = 2;
            this.checkSquare.Text = "Is Square";
            this.checkSquare.UseVisualStyleBackColor = true;
            this.checkSquare.Click += new System.EventHandler(this.checkBoxAny_Click);
            // 
            // checkPent
            // 
            this.checkPent.AutoSize = true;
            this.checkPent.Checked = true;
            this.checkPent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPent.Location = new System.Drawing.Point(200, 173);
            this.checkPent.Name = "checkPent";
            this.checkPent.Size = new System.Drawing.Size(116, 21);
            this.checkPent.TabIndex = 3;
            this.checkPent.Text = "Is Pentagonal";
            this.checkPent.UseVisualStyleBackColor = true;
            this.checkPent.Click += new System.EventHandler(this.checkBoxAny_Click);
            // 
            // checkHex
            // 
            this.checkHex.AutoSize = true;
            this.checkHex.Checked = true;
            this.checkHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHex.Location = new System.Drawing.Point(200, 235);
            this.checkHex.Name = "checkHex";
            this.checkHex.Size = new System.Drawing.Size(111, 21);
            this.checkHex.TabIndex = 4;
            this.checkHex.Text = "Is Hexagonal";
            this.checkHex.UseVisualStyleBackColor = true;
            this.checkHex.Click += new System.EventHandler(this.checkBoxAny_Click);
            // 
            // checkCube
            // 
            this.checkCube.AutoSize = true;
            this.checkCube.Checked = true;
            this.checkCube.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCube.Location = new System.Drawing.Point(200, 297);
            this.checkCube.Name = "checkCube";
            this.checkCube.Size = new System.Drawing.Size(89, 21);
            this.checkCube.TabIndex = 5;
            this.checkCube.Text = "Is a Cube";
            this.checkCube.UseVisualStyleBackColor = true;
            this.checkCube.Click += new System.EventHandler(this.checkBoxAny_Click);
            // 
            // checkSum2Squares
            // 
            this.checkSum2Squares.AutoSize = true;
            this.checkSum2Squares.Checked = true;
            this.checkSum2Squares.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSum2Squares.Location = new System.Drawing.Point(479, 49);
            this.checkSum2Squares.Name = "checkSum2Squares";
            this.checkSum2Squares.Size = new System.Drawing.Size(175, 21);
            this.checkSum2Squares.TabIndex = 6;
            this.checkSum2Squares.Text = "Is Sum of Two Squares";
            this.checkSum2Squares.UseVisualStyleBackColor = true;
            this.checkSum2Squares.Click += new System.EventHandler(this.checkBoxAny_Click);
            // 
            // checkSum2Cubes
            // 
            this.checkSum2Cubes.AutoSize = true;
            this.checkSum2Cubes.Checked = true;
            this.checkSum2Cubes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSum2Cubes.Location = new System.Drawing.Point(479, 127);
            this.checkSum2Cubes.Name = "checkSum2Cubes";
            this.checkSum2Cubes.Size = new System.Drawing.Size(162, 21);
            this.checkSum2Cubes.TabIndex = 7;
            this.checkSum2Cubes.Text = "Is Sum of Two Cubes";
            this.checkSum2Cubes.UseVisualStyleBackColor = true;
            this.checkSum2Cubes.Click += new System.EventHandler(this.checkBoxAny_Click);
            // 
            // checkSum3Squares
            // 
            this.checkSum3Squares.AutoSize = true;
            this.checkSum3Squares.Checked = true;
            this.checkSum3Squares.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSum3Squares.Location = new System.Drawing.Point(479, 205);
            this.checkSum3Squares.Name = "checkSum3Squares";
            this.checkSum3Squares.Size = new System.Drawing.Size(187, 21);
            this.checkSum3Squares.TabIndex = 8;
            this.checkSum3Squares.Text = "Is Sum of Three Squares";
            this.checkSum3Squares.UseVisualStyleBackColor = true;
            this.checkSum3Squares.Click += new System.EventHandler(this.checkBoxAny_Click);
            // 
            // checkSum3Cubes
            // 
            this.checkSum3Cubes.AutoSize = true;
            this.checkSum3Cubes.Checked = true;
            this.checkSum3Cubes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSum3Cubes.Location = new System.Drawing.Point(479, 283);
            this.checkSum3Cubes.Name = "checkSum3Cubes";
            this.checkSum3Cubes.Size = new System.Drawing.Size(174, 21);
            this.checkSum3Cubes.TabIndex = 9;
            this.checkSum3Cubes.Text = "Is Sum of Three Cubes";
            this.checkSum3Cubes.UseVisualStyleBackColor = true;
            this.checkSum3Cubes.Click += new System.EventHandler(this.checkBoxAny_Click);
            // 
            // checkPerfect
            // 
            this.checkPerfect.AutoSize = true;
            this.checkPerfect.Checked = true;
            this.checkPerfect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPerfect.Location = new System.Drawing.Point(200, 359);
            this.checkPerfect.Name = "checkPerfect";
            this.checkPerfect.Size = new System.Drawing.Size(89, 21);
            this.checkPerfect.TabIndex = 10;
            this.checkPerfect.Text = "Is Perfect";
            this.checkPerfect.UseVisualStyleBackColor = true;
            this.checkPerfect.Click += new System.EventHandler(this.checkBoxAny_Click);
            // 
            // checkRepunit
            // 
            this.checkRepunit.AutoSize = true;
            this.checkRepunit.Checked = true;
            this.checkRepunit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRepunit.Location = new System.Drawing.Point(479, 361);
            this.checkRepunit.Name = "checkRepunit";
            this.checkRepunit.Size = new System.Drawing.Size(93, 21);
            this.checkRepunit.TabIndex = 11;
            this.checkRepunit.Text = "Is Repunit";
            this.checkRepunit.UseVisualStyleBackColor = true;
            this.checkRepunit.Click += new System.EventHandler(this.checkBoxAny_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(489, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 39);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkRepunit);
            this.Controls.Add(this.checkPerfect);
            this.Controls.Add(this.checkSum3Cubes);
            this.Controls.Add(this.checkSum3Squares);
            this.Controls.Add(this.checkSum2Cubes);
            this.Controls.Add(this.checkSum2Squares);
            this.Controls.Add(this.checkCube);
            this.Controls.Add(this.checkHex);
            this.Controls.Add(this.checkPent);
            this.Controls.Add(this.checkSquare);
            this.Controls.Add(this.checkTri);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox checkTri;
        public System.Windows.Forms.CheckBox checkSquare;
        public System.Windows.Forms.CheckBox checkPent;
        public System.Windows.Forms.CheckBox checkHex;
        public System.Windows.Forms.CheckBox checkCube;
        public System.Windows.Forms.CheckBox checkSum2Squares;
        public System.Windows.Forms.CheckBox checkSum2Cubes;
        public System.Windows.Forms.CheckBox checkSum3Squares;
        public System.Windows.Forms.CheckBox checkSum3Cubes;
        public System.Windows.Forms.CheckBox checkPerfect;
        public System.Windows.Forms.CheckBox checkRepunit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}