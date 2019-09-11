namespace harmanFireGame
{
    partial class RussianRoulette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RussianRoulette));
            this.start = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.Trigger = new System.Windows.Forms.PictureBox();
            this.Shoot = new System.Windows.Forms.Button();
            this.Shotaway = new System.Windows.Forms.Button();
            this.tryAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Trigger)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(12, 261);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(90, 36);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Load
            // 
            this.Load.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.Location = new System.Drawing.Point(12, 318);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(90, 36);
            this.Load.TabIndex = 2;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Spin
            // 
            this.Spin.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin.Location = new System.Drawing.Point(12, 373);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(90, 36);
            this.Spin.TabIndex = 3;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // Trigger
            // 
            this.Trigger.BackColor = System.Drawing.Color.Transparent;
            this.Trigger.Location = new System.Drawing.Point(221, 58);
            this.Trigger.Name = "Trigger";
            this.Trigger.Size = new System.Drawing.Size(382, 197);
            this.Trigger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Trigger.TabIndex = 4;
            this.Trigger.TabStop = false;
            // 
            // Shoot
            // 
            this.Shoot.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoot.Location = new System.Drawing.Point(700, 251);
            this.Shoot.Name = "Shoot";
            this.Shoot.Size = new System.Drawing.Size(90, 36);
            this.Shoot.TabIndex = 5;
            this.Shoot.Text = "Shoot";
            this.Shoot.UseVisualStyleBackColor = true;
            this.Shoot.Click += new System.EventHandler(this.Shoot_Click);
            // 
            // Shotaway
            // 
            this.Shotaway.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shotaway.Location = new System.Drawing.Point(700, 309);
            this.Shotaway.Name = "Shotaway";
            this.Shotaway.Size = new System.Drawing.Size(90, 62);
            this.Shotaway.TabIndex = 6;
            this.Shotaway.Text = "Shoot Away";
            this.Shotaway.UseVisualStyleBackColor = true;
            this.Shotaway.Click += new System.EventHandler(this.Shotaway_Click);
            // 
            // tryAgain
            // 
            this.tryAgain.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryAgain.Location = new System.Drawing.Point(552, 402);
            this.tryAgain.Name = "tryAgain";
            this.tryAgain.Size = new System.Drawing.Size(156, 36);
            this.tryAgain.TabIndex = 7;
            this.tryAgain.Text = "Once More";
            this.tryAgain.UseVisualStyleBackColor = true;
            this.tryAgain.Click += new System.EventHandler(this.tryAgain_Click);
            // 
            // RussianRoulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tryAgain);
            this.Controls.Add(this.Shotaway);
            this.Controls.Add(this.Shoot);
            this.Controls.Add(this.Trigger);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.start);
            this.Name = "RussianRoulette";
            this.Text = "RussianRoulette";
            ((System.ComponentModel.ISupportInitialize)(this.Trigger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.PictureBox Trigger;
        private System.Windows.Forms.Button Shoot;
        private System.Windows.Forms.Button Shotaway;
        private System.Windows.Forms.Button tryAgain;
    }
}