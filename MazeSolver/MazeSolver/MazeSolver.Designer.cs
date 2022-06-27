
namespace MazeSolver
{
    partial class MazeSolver
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showJunctions = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(206, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // showJunctions
            // 
            this.showJunctions.Dock = System.Windows.Forms.DockStyle.Top;
            this.showJunctions.Location = new System.Drawing.Point(0, 51);
            this.showJunctions.Name = "showJunctions";
            this.showJunctions.Size = new System.Drawing.Size(269, 51);
            this.showJunctions.TabIndex = 1;
            this.showJunctions.Text = "Show Junctions";
            this.showJunctions.UseVisualStyleBackColor = true;
            this.showJunctions.Click += new System.EventHandler(this.showJunctions_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.showJunctions);
            this.panel1.Controls.Add(this.load);
            this.panel1.Location = new System.Drawing.Point(662, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 415);
            this.panel1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 204);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(269, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(269, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Dock = System.Windows.Forms.DockStyle.Top;
            this.save.Location = new System.Drawing.Point(0, 102);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(269, 51);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Dock = System.Windows.Forms.DockStyle.Top;
            this.load.Location = new System.Drawing.Point(0, 0);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(269, 51);
            this.load.TabIndex = 0;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button showJunctions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button save;
    }
}

