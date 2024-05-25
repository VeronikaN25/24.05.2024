namespace _24._05._2024
{
    partial class Trigonometry
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sinResult = new System.Windows.Forms.Label();
            this.cosResult = new System.Windows.Forms.Label();
            this.tanResult = new System.Windows.Forms.Label();
            this.ctanResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(618, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(290, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Посчитать углы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAngle.Location = new System.Drawing.Point(54, 59);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(183, 34);
            this.textBoxAngle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 3;
            // 
            // sinResult
            // 
            this.sinResult.AutoSize = true;
            this.sinResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sinResult.Location = new System.Drawing.Point(49, 134);
            this.sinResult.Name = "sinResult";
            this.sinResult.Size = new System.Drawing.Size(209, 29);
            this.sinResult.TabIndex = 4;
            this.sinResult.Text = "Результат синуса";
            // 
            // cosResult
            // 
            this.cosResult.AutoSize = true;
            this.cosResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cosResult.Location = new System.Drawing.Point(51, 196);
            this.cosResult.Name = "cosResult";
            this.cosResult.Size = new System.Drawing.Size(235, 29);
            this.cosResult.TabIndex = 5;
            this.cosResult.Text = "Результат косинуса";
            // 
            // tanResult
            // 
            this.tanResult.AutoSize = true;
            this.tanResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tanResult.Location = new System.Drawing.Point(51, 255);
            this.tanResult.Name = "tanResult";
            this.tanResult.Size = new System.Drawing.Size(235, 29);
            this.tanResult.TabIndex = 6;
            this.tanResult.Text = "Результат тангенса";
            // 
            // ctanResult
            // 
            this.ctanResult.AutoSize = true;
            this.ctanResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctanResult.Location = new System.Drawing.Point(53, 313);
            this.ctanResult.Name = "ctanResult";
            this.ctanResult.Size = new System.Drawing.Size(261, 29);
            this.ctanResult.TabIndex = 7;
            this.ctanResult.Text = "Результат котангенса";
            this.ctanResult.Click += new System.EventHandler(this.label5_Click);
            // 
            // Trigonometry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctanResult);
            this.Controls.Add(this.tanResult);
            this.Controls.Add(this.cosResult);
            this.Controls.Add(this.sinResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAngle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Trigonometry";
            this.Text = "Trigonometry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sinResult;
        private System.Windows.Forms.Label cosResult;
        private System.Windows.Forms.Label tanResult;
        private System.Windows.Forms.Label ctanResult;
    }
}