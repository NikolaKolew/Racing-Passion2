namespace RacingPassion
{
    partial class Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car));
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.brand = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.engine = new System.Windows.Forms.TextBox();
            this.hp = new System.Windows.Forms.TextBox();
            this.fuel = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(956, 468);
            this.back.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(140, 61);
            this.back.TabIndex = 0;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add new car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Engine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 33);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fuel Type";
            // 
            // brand
            // 
            this.brand.Location = new System.Drawing.Point(479, 99);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(181, 39);
            this.brand.TabIndex = 8;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(479, 154);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(181, 39);
            this.model.TabIndex = 9;
            // 
            // engine
            // 
            this.engine.Location = new System.Drawing.Point(479, 219);
            this.engine.Name = "engine";
            this.engine.Size = new System.Drawing.Size(181, 39);
            this.engine.TabIndex = 10;
            // 
            // hp
            // 
            this.hp.Location = new System.Drawing.Point(479, 288);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(181, 39);
            this.hp.TabIndex = 11;
            // 
            // fuel
            // 
            this.fuel.Location = new System.Drawing.Point(479, 353);
            this.fuel.Name = "fuel";
            this.fuel.Size = new System.Drawing.Size(181, 39);
            this.fuel.TabIndex = 12;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(479, 428);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(181, 61);
            this.add.TabIndex = 13;
            this.add.Text = "Add car";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 33);
            this.label7.TabIndex = 14;
            this.label7.Text = "User:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(101, 99);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 33);
            this.username.TabIndex = 15;
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 544);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.add);
            this.Controls.Add(this.fuel);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.engine);
            this.Controls.Add(this.model);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back);
            this.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Car";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox engine;
        private System.Windows.Forms.TextBox hp;
        private System.Windows.Forms.TextBox fuel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label username;
    }
}