namespace Lab0
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.arg_a = new System.Windows.Forms.TextBox();
            this.arg_x = new System.Windows.Forms.TextBox();
            this.arg_z = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(26, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate first statement";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkBlue;
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(500, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Calculate second statement";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(300, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Finish";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter argument a:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(33, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter argument x:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(33, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter argument z:";
            // 
            // arg_a
            // 
            this.arg_a.Location = new System.Drawing.Point(197, 12);
            this.arg_a.Name = "arg_a";
            this.arg_a.Size = new System.Drawing.Size(100, 23);
            this.arg_a.TabIndex = 6;
            this.arg_a.TextChanged += new System.EventHandler(this.arg_a_TextChanged);
            // 
            // arg_x
            // 
            this.arg_x.Location = new System.Drawing.Point(197, 52);
            this.arg_x.Name = "arg_x";
            this.arg_x.Size = new System.Drawing.Size(100, 23);
            this.arg_x.TabIndex = 7;
            this.arg_x.TextChanged += new System.EventHandler(this.arg_x_TextChanged);
            // 
            // arg_z
            // 
            this.arg_z.Location = new System.Drawing.Point(197, 90);
            this.arg_z.Name = "arg_z";
            this.arg_z.Size = new System.Drawing.Size(100, 23);
            this.arg_z.TabIndex = 8;
            this.arg_z.TextChanged += new System.EventHandler(this.arg_z_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(337, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 117);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.arg_z);
            this.Controls.Add(this.arg_x);
            this.Controls.Add(this.arg_a);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Lab0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
       /* private TextBox a_arg;
        private Label label1;
        private TextBox arg_x;
        private Label label2;
        private TextBox arg_z;*/
       // private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox arg_a;
        private TextBox arg_x;
        private TextBox arg_z;
        private PictureBox pictureBox1;
    }
}