
namespace FlowChartProgramPractice
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
            this.startButton = new System.Windows.Forms.Button();
            this.helloWorldlabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.goodbyeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(321, 180);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(157, 64);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // helloWorldlabel
            // 
            this.helloWorldlabel.AutoSize = true;
            this.helloWorldlabel.BackColor = System.Drawing.Color.Black;
            this.helloWorldlabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helloWorldlabel.Location = new System.Drawing.Point(355, 247);
            this.helloWorldlabel.Name = "helloWorldlabel";
            this.helloWorldlabel.Size = new System.Drawing.Size(92, 24);
            this.helloWorldlabel.TabIndex = 1;
            this.helloWorldlabel.Text = "Hello World";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(321, 110);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(157, 64);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // goodbyeLabel
            // 
            this.goodbyeLabel.AutoSize = true;
            this.goodbyeLabel.BackColor = System.Drawing.Color.Black;
            this.goodbyeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodbyeLabel.ForeColor = System.Drawing.Color.White;
            this.goodbyeLabel.Location = new System.Drawing.Point(348, 299);
            this.goodbyeLabel.Name = "goodbyeLabel";
            this.goodbyeLabel.Size = new System.Drawing.Size(99, 25);
            this.goodbyeLabel.TabIndex = 3;
            this.goodbyeLabel.Text = "Good Bye";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goodbyeLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.helloWorldlabel);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label helloWorldlabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label goodbyeLabel;
    }
}

