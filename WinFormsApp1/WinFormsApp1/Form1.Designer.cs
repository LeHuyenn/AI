
namespace WinFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.endNode = new System.Windows.Forms.TextBox();
            this.startNode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.findWayFollowDepth = new System.Windows.Forms.Button();
            this.stepInDepth = new System.Windows.Forms.TextBox();
            this.wayInDepth = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.findWayFollowWidth = new System.Windows.Forms.Button();
            this.stepInWidth = new System.Windows.Forms.TextBox();
            this.wayInWidth = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1127, 390);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Граф";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(626, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Матрица смежности";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(55, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Изображение графа";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources._2021_10_15__4_;
            this.pictureBox1.Location = new System.Drawing.Point(55, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.endNode);
            this.groupBox2.Controls.Add(this.startNode);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(26, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1127, 109);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры поиска";
            // 
            // endNode
            // 
            this.endNode.Location = new System.Drawing.Point(223, 68);
            this.endNode.Name = "endNode";
            this.endNode.Size = new System.Drawing.Size(67, 27);
            this.endNode.TabIndex = 4;
            this.endNode.TextChanged += new System.EventHandler(this.endNode_TextChanged);
            // 
            // startNode
            // 
            this.startNode.Location = new System.Drawing.Point(223, 27);
            this.startNode.Name = "startNode";
            this.startNode.Size = new System.Drawing.Size(67, 27);
            this.startNode.TabIndex = 3;
            this.startNode.TextChanged += new System.EventHandler(this.startNode_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(613, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Очистить результаты поиска";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(26, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Целевая вершина - ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(26, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Начальная вершина - ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.findWayFollowDepth);
            this.groupBox3.Controls.Add(this.stepInDepth);
            this.groupBox3.Controls.Add(this.wayInDepth);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(26, 577);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1127, 114);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск в глубнину";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(26, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Шагов : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(26, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Путь : ";
            // 
            // findWayFollowDepth
            // 
            this.findWayFollowDepth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.findWayFollowDepth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.findWayFollowDepth.Location = new System.Drawing.Point(721, 52);
            this.findWayFollowDepth.Name = "findWayFollowDepth";
            this.findWayFollowDepth.Size = new System.Drawing.Size(120, 29);
            this.findWayFollowDepth.TabIndex = 2;
            this.findWayFollowDepth.Text = "Найти путь";
            this.findWayFollowDepth.UseVisualStyleBackColor = false;
            this.findWayFollowDepth.Click += new System.EventHandler(this.findWayFollowDepth_Click);
            // 
            // stepInDepth
            // 
            this.stepInDepth.Location = new System.Drawing.Point(165, 69);
            this.stepInDepth.Name = "stepInDepth";
            this.stepInDepth.Size = new System.Drawing.Size(125, 27);
            this.stepInDepth.TabIndex = 1;
            // 
            // wayInDepth
            // 
            this.wayInDepth.Location = new System.Drawing.Point(165, 36);
            this.wayInDepth.Name = "wayInDepth";
            this.wayInDepth.Size = new System.Drawing.Size(383, 27);
            this.wayInDepth.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.findWayFollowWidth);
            this.groupBox4.Controls.Add(this.stepInWidth);
            this.groupBox4.Controls.Add(this.wayInWidth);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(26, 718);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1127, 125);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск в ширину";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(26, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Шагов : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(26, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Путь : ";
            // 
            // findWayFollowWidth
            // 
            this.findWayFollowWidth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.findWayFollowWidth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.findWayFollowWidth.Location = new System.Drawing.Point(721, 55);
            this.findWayFollowWidth.Name = "findWayFollowWidth";
            this.findWayFollowWidth.Size = new System.Drawing.Size(120, 29);
            this.findWayFollowWidth.TabIndex = 2;
            this.findWayFollowWidth.Text = "Найти путь";
            this.findWayFollowWidth.UseVisualStyleBackColor = false;
            this.findWayFollowWidth.Click += new System.EventHandler(this.findWayFollowWidth_Click);
            // 
            // stepInWidth
            // 
            this.stepInWidth.Location = new System.Drawing.Point(165, 79);
            this.stepInWidth.Name = "stepInWidth";
            this.stepInWidth.Size = new System.Drawing.Size(125, 27);
            this.stepInWidth.TabIndex = 1;
            // 
            // wayInWidth
            // 
            this.wayInWidth.Location = new System.Drawing.Point(165, 36);
            this.wayInWidth.Name = "wayInWidth";
            this.wayInWidth.Size = new System.Drawing.Size(383, 27);
            this.wayInWidth.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormsApp1.Properties.Resources._2021_10_15__7_1;
            this.pictureBox2.Location = new System.Drawing.Point(626, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(418, 260);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 880);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Поиск на графе";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox endNode;
        private System.Windows.Forms.TextBox startNode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox stepInDepth;
        private System.Windows.Forms.TextBox wayInDepth;
        private System.Windows.Forms.Button findWayFollowDepth;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button findWayFollowWidth;
        private System.Windows.Forms.TextBox stepInWidth;
        private System.Windows.Forms.TextBox wayInWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

