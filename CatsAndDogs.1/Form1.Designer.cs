
namespace CatsAndDogs._1
{
    partial class Form1
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
            this.dogPicture = new System.Windows.Forms.PictureBox();
            this.catPicture = new System.Windows.Forms.PictureBox();
            this.getTheDog = new System.Windows.Forms.Button();
            this.getACat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dogPicture
            // 
            this.dogPicture.Location = new System.Drawing.Point(878, 82);
            this.dogPicture.Name = "dogPicture";
            this.dogPicture.Size = new System.Drawing.Size(293, 287);
            this.dogPicture.TabIndex = 0;
            this.dogPicture.TabStop = false;
            // 
            // catPicture
            // 
            this.catPicture.Location = new System.Drawing.Point(72, 82);
            this.catPicture.Name = "catPicture";
            this.catPicture.Size = new System.Drawing.Size(293, 287);
            this.catPicture.TabIndex = 1;
            this.catPicture.TabStop = false;
            // 
            // getTheDog
            // 
            this.getTheDog.Location = new System.Drawing.Point(916, 404);
            this.getTheDog.Name = "getTheDog";
            this.getTheDog.Size = new System.Drawing.Size(222, 33);
            this.getTheDog.TabIndex = 2;
            this.getTheDog.Text = "Get the dog Image";
            this.getTheDog.UseVisualStyleBackColor = true;
            this.getTheDog.Click += new System.EventHandler(this.getTheDog_Click);
            // 
            // getACat
            // 
            this.getACat.Location = new System.Drawing.Point(100, 404);
            this.getACat.Name = "getACat";
            this.getACat.Size = new System.Drawing.Size(229, 33);
            this.getACat.TabIndex = 3;
            this.getACat.Text = "Get the cat image";
            this.getACat.UseVisualStyleBackColor = true;
            this.getACat.Click += new System.EventHandler(this.getACat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 573);
            this.Controls.Add(this.getACat);
            this.Controls.Add(this.getTheDog);
            this.Controls.Add(this.catPicture);
            this.Controls.Add(this.dogPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dogPicture;
        private System.Windows.Forms.PictureBox catPicture;
        private System.Windows.Forms.Button getTheDog;
        private System.Windows.Forms.Button getACat;
    }
}

