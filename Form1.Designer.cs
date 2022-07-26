namespace SimpleHex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.hexCode = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnAddFaves = new System.Windows.Forms.Button();
            this.btnViewFaves = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(12, 12);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(161, 110);
            this.colorBox.TabIndex = 0;
            this.colorBox.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 157);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // hexCode
            // 
            this.hexCode.Location = new System.Drawing.Point(12, 128);
            this.hexCode.Name = "hexCode";
            this.hexCode.Size = new System.Drawing.Size(161, 23);
            this.hexCode.TabIndex = 2;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(98, 157);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnAddFaves
            // 
            this.btnAddFaves.Enabled = false;
            this.btnAddFaves.Location = new System.Drawing.Point(12, 186);
            this.btnAddFaves.Name = "btnAddFaves";
            this.btnAddFaves.Size = new System.Drawing.Size(161, 23);
            this.btnAddFaves.TabIndex = 4;
            this.btnAddFaves.Text = "Add to Favorites";
            this.btnAddFaves.UseVisualStyleBackColor = true;
            this.btnAddFaves.Click += new System.EventHandler(this.btnAddFaves_Click);
            // 
            // btnViewFaves
            // 
            this.btnViewFaves.Enabled = false;
            this.btnViewFaves.Location = new System.Drawing.Point(12, 215);
            this.btnViewFaves.Name = "btnViewFaves";
            this.btnViewFaves.Size = new System.Drawing.Size(161, 23);
            this.btnViewFaves.TabIndex = 5;
            this.btnViewFaves.Text = "View Favorites";
            this.btnViewFaves.UseVisualStyleBackColor = true;
            this.btnViewFaves.Click += new System.EventHandler(this.btnViewFaves_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 249);
            this.Controls.Add(this.btnViewFaves);
            this.Controls.Add(this.btnAddFaves);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.hexCode);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.colorBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox colorBox;
        private Button btnGenerate;
        private TextBox hexCode;
        private Button btnCopy;
        private Button btnAddFaves;
        private Button btnViewFaves;
    }
}