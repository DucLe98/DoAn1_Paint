namespace PaintApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nrDoDay = new System.Windows.Forms.NumericUpDown();
            this.pb_color = new System.Windows.Forms.PictureBox();
            this.btn_cong = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_lucGiac = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.btn_Square = new System.Windows.Forms.Button();
            this.btn_elip = new System.Windows.Forms.Button();
            this.btn_Rec = new System.Windows.Forms.Button();
            this.btLine = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrDoDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_color)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pb_color);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_cong);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btn_lucGiac);
            this.panel1.Controls.Add(this.btn_circle);
            this.panel1.Controls.Add(this.btn_Square);
            this.panel1.Controls.Add(this.btn_elip);
            this.panel1.Controls.Add(this.nrDoDay);
            this.panel1.Controls.Add(this.btn_Rec);
            this.panel1.Controls.Add(this.btLine);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 101);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(321, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 41);
            this.button4.TabIndex = 5;
            this.button4.Text = "Fill";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(321, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "Draw";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(567, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Size";
            // 
            // nrDoDay
            // 
            this.nrDoDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrDoDay.Location = new System.Drawing.Point(474, 6);
            this.nrDoDay.Name = "nrDoDay";
            this.nrDoDay.Size = new System.Drawing.Size(41, 22);
            this.nrDoDay.TabIndex = 0;
            this.nrDoDay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // pb_color
            // 
            this.pb_color.Location = new System.Drawing.Point(474, 34);
            this.pb_color.Name = "pb_color";
            this.pb_color.Size = new System.Drawing.Size(28, 26);
            this.pb_color.TabIndex = 4;
            this.pb_color.TabStop = false;
            this.pb_color.Click += new System.EventHandler(this.pb_color_Click);
            // 
            // btn_cong
            // 
            this.btn_cong.BackgroundImage = global::PaintApp.Properties.Resources.Benzier;
            this.btn_cong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cong.Location = new System.Drawing.Point(124, 55);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(58, 41);
            this.btn_cong.TabIndex = 2;
            this.btn_cong.UseVisualStyleBackColor = true;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::PaintApp.Properties.Resources.tamgiac;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(188, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 43);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::PaintApp.Properties.Resources.thoi;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(252, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 43);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_lucGiac
            // 
            this.btn_lucGiac.BackgroundImage = global::PaintApp.Properties.Resources.lucgiac;
            this.btn_lucGiac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lucGiac.Location = new System.Drawing.Point(188, 6);
            this.btn_lucGiac.Name = "btn_lucGiac";
            this.btn_lucGiac.Size = new System.Drawing.Size(58, 43);
            this.btn_lucGiac.TabIndex = 2;
            this.btn_lucGiac.UseVisualStyleBackColor = true;
            this.btn_lucGiac.Click += new System.EventHandler(this.btn_lucGiac_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.BackgroundImage = global::PaintApp.Properties.Resources.Circle;
            this.btn_circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_circle.Location = new System.Drawing.Point(124, 4);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(58, 45);
            this.btn_circle.TabIndex = 2;
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // btn_Square
            // 
            this.btn_Square.BackgroundImage = global::PaintApp.Properties.Resources.Square;
            this.btn_Square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Square.Location = new System.Drawing.Point(62, 55);
            this.btn_Square.Name = "btn_Square";
            this.btn_Square.Size = new System.Drawing.Size(56, 41);
            this.btn_Square.TabIndex = 2;
            this.btn_Square.UseVisualStyleBackColor = true;
            this.btn_Square.Click += new System.EventHandler(this.btn_Square_Click);
            // 
            // btn_elip
            // 
            this.btn_elip.BackgroundImage = global::PaintApp.Properties.Resources.elipse;
            this.btn_elip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elip.Location = new System.Drawing.Point(62, 3);
            this.btn_elip.Name = "btn_elip";
            this.btn_elip.Size = new System.Drawing.Size(56, 46);
            this.btn_elip.TabIndex = 1;
            this.btn_elip.UseVisualStyleBackColor = true;
            this.btn_elip.Click += new System.EventHandler(this.btn_elip_Click);
            // 
            // btn_Rec
            // 
            this.btn_Rec.BackgroundImage = global::PaintApp.Properties.Resources.Rect;
            this.btn_Rec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Rec.Location = new System.Drawing.Point(3, 55);
            this.btn_Rec.Name = "btn_Rec";
            this.btn_Rec.Size = new System.Drawing.Size(53, 41);
            this.btn_Rec.TabIndex = 0;
            this.btn_Rec.UseVisualStyleBackColor = true;
            this.btn_Rec.Click += new System.EventHandler(this.btn_Rec_Click);
            // 
            // btLine
            // 
            this.btLine.BackgroundImage = global::PaintApp.Properties.Resources.Line;
            this.btLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLine.Location = new System.Drawing.Point(3, 3);
            this.btLine.Name = "btLine";
            this.btLine.Size = new System.Drawing.Size(53, 46);
            this.btLine.TabIndex = 0;
            this.btLine.UseVisualStyleBackColor = true;
            this.btLine.Click += new System.EventHandler(this.btLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.plMain_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrDoDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_color)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btLine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nrDoDay;
        private System.Windows.Forms.Button btn_Rec;
        private System.Windows.Forms.Button btn_elip;
        private System.Windows.Forms.Button btn_Square;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cong;
        private System.Windows.Forms.PictureBox pb_color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_lucGiac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}

