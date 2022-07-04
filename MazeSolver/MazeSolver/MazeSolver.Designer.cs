
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
            this.btnBFS = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelFileSubmenu = new System.Windows.Forms.Panel();
            this.btnFile = new System.Windows.Forms.Button();
            this.panelSolveSubmenu = new System.Windows.Forms.Panel();
            this.btnSolve = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMazeLoadTime = new System.Windows.Forms.Label();
            this.labelMazeSolveTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.panelFileSubmenu.SuspendLayout();
            this.panelSolveSubmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 491);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // showJunctions
            // 
            this.showJunctions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.showJunctions.Dock = System.Windows.Forms.DockStyle.Top;
            this.showJunctions.FlatAppearance.BorderSize = 0;
            this.showJunctions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(182)))), ((int)(((byte)(217)))));
            this.showJunctions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(140)))));
            this.showJunctions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showJunctions.ForeColor = System.Drawing.Color.White;
            this.showJunctions.Location = new System.Drawing.Point(0, 0);
            this.showJunctions.Name = "showJunctions";
            this.showJunctions.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.showJunctions.Size = new System.Drawing.Size(250, 40);
            this.showJunctions.TabIndex = 1;
            this.showJunctions.Text = "Show Junctions";
            this.showJunctions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showJunctions.UseVisualStyleBackColor = false;
            this.showJunctions.Click += new System.EventHandler(this.showJunctions_Click);
            // 
            // btnBFS
            // 
            this.btnBFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnBFS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBFS.FlatAppearance.BorderSize = 0;
            this.btnBFS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(182)))), ((int)(((byte)(217)))));
            this.btnBFS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(140)))));
            this.btnBFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBFS.ForeColor = System.Drawing.Color.White;
            this.btnBFS.Location = new System.Drawing.Point(0, 40);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnBFS.Size = new System.Drawing.Size(250, 40);
            this.btnBFS.TabIndex = 3;
            this.btnBFS.Text = "Breadth First Search";
            this.btnBFS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBFS.UseVisualStyleBackColor = false;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.save.Dock = System.Windows.Forms.DockStyle.Top;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(182)))), ((int)(((byte)(217)))));
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(140)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(0, 0);
            this.save.Name = "save";
            this.save.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.save.Size = new System.Drawing.Size(250, 40);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.load.Dock = System.Windows.Forms.DockStyle.Top;
            this.load.FlatAppearance.BorderSize = 0;
            this.load.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(182)))), ((int)(((byte)(217)))));
            this.load.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(140)))));
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.ForeColor = System.Drawing.Color.White;
            this.load.Location = new System.Drawing.Point(0, 40);
            this.load.Name = "load";
            this.load.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.load.Size = new System.Drawing.Size(250, 40);
            this.load.TabIndex = 0;
            this.load.Text = "Load";
            this.load.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.panelSideMenu.Controls.Add(this.panelSolveSubmenu);
            this.panelSideMenu.Controls.Add(this.btnSolve);
            this.panelSideMenu.Controls.Add(this.panelFileSubmenu);
            this.panelSideMenu.Controls.Add(this.btnFile);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 898);
            this.panelSideMenu.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelFileSubmenu
            // 
            this.panelFileSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelFileSubmenu.Controls.Add(this.load);
            this.panelFileSubmenu.Controls.Add(this.save);
            this.panelFileSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFileSubmenu.Location = new System.Drawing.Point(0, 145);
            this.panelFileSubmenu.Name = "panelFileSubmenu";
            this.panelFileSubmenu.Size = new System.Drawing.Size(250, 80);
            this.panelFileSubmenu.TabIndex = 5;
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.btnFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.ForeColor = System.Drawing.Color.White;
            this.btnFile.Location = new System.Drawing.Point(0, 100);
            this.btnFile.Name = "btnFile";
            this.btnFile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFile.Size = new System.Drawing.Size(250, 45);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "File";
            this.btnFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // panelSolveSubmenu
            // 
            this.panelSolveSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelSolveSubmenu.Controls.Add(this.btnBFS);
            this.panelSolveSubmenu.Controls.Add(this.showJunctions);
            this.panelSolveSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSolveSubmenu.Location = new System.Drawing.Point(0, 270);
            this.panelSolveSubmenu.Name = "panelSolveSubmenu";
            this.panelSolveSubmenu.Size = new System.Drawing.Size(250, 80);
            this.panelSolveSubmenu.TabIndex = 7;
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.btnSolve.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolve.FlatAppearance.BorderSize = 0;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.ForeColor = System.Drawing.Color.White;
            this.btnSolve.Location = new System.Drawing.Point(0, 225);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSolve.Size = new System.Drawing.Size(250, 45);
            this.btnSolve.TabIndex = 8;
            this.btnSolve.Text = "Solve";
            this.btnSolve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(352, 696);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 80);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMazeSolveTime);
            this.panel1.Controls.Add(this.labelMazeLoadTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 456);
            this.panel1.TabIndex = 9;
            // 
            // labelMazeLoadTime
            // 
            this.labelMazeLoadTime.AutoSize = true;
            this.labelMazeLoadTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.labelMazeLoadTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMazeLoadTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMazeLoadTime.ForeColor = System.Drawing.Color.White;
            this.labelMazeLoadTime.Location = new System.Drawing.Point(0, 0);
            this.labelMazeLoadTime.Name = "labelMazeLoadTime";
            this.labelMazeLoadTime.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.labelMazeLoadTime.Size = new System.Drawing.Size(400, 56);
            this.labelMazeLoadTime.TabIndex = 0;
            this.labelMazeLoadTime.Text = "Maze Load Time: 00:00:00";
            // 
            // labelMazeSolveTime
            // 
            this.labelMazeSolveTime.AutoSize = true;
            this.labelMazeSolveTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.labelMazeSolveTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMazeSolveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMazeSolveTime.ForeColor = System.Drawing.Color.White;
            this.labelMazeSolveTime.Location = new System.Drawing.Point(0, 56);
            this.labelMazeSolveTime.Name = "labelMazeSolveTime";
            this.labelMazeSolveTime.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.labelMazeSolveTime.Size = new System.Drawing.Size(400, 56);
            this.labelMazeSolveTime.TabIndex = 10;
            this.labelMazeSolveTime.Text = "Maze Solve Time: 00:00:00";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(335, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1057, 509);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 509);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(448, 509);
            this.panel5.TabIndex = 11;
            // 
            // MazeSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(107)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1850, 898);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "MazeSolver";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelFileSubmenu.ResumeLayout(false);
            this.panelSolveSubmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button showJunctions;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelFileSubmenu;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSolveSubmenu;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMazeSolveTime;
        private System.Windows.Forms.Label labelMazeLoadTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

