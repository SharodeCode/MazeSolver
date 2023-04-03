
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
            this.panelTimers = new System.Windows.Forms.Panel();
            this.labelMazeSolveTime = new System.Windows.Forms.Label();
            this.labelMazeLoadTime = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMazeSoler = new System.Windows.Forms.Panel();
            this.panelMazeImage = new System.Windows.Forms.Panel();
            this.pictureBoxMaze = new System.Windows.Forms.PictureBox();
            this.panelMazeTimers = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureBoxBackdrop = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.panelFileSubmenu = new System.Windows.Forms.Panel();
            this.btnLargeMaze = new System.Windows.Forms.Button();
            this.btnMediumMaze = new System.Windows.Forms.Button();
            this.btnSmallMaze = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.panelSolveSubmenu = new System.Windows.Forms.Panel();
            this.btnBFS = new System.Windows.Forms.Button();
            this.btnShowJunctions = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelOtherSubmenu = new System.Windows.Forms.Panel();
            this.btnShowPaths = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnDFS = new System.Windows.Forms.Button();
            this.panelTimers.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panelMazeSoler.SuspendLayout();
            this.panelMazeImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaze)).BeginInit();
            this.panelMazeTimers.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackdrop)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelFileSubmenu.SuspendLayout();
            this.panelSolveSubmenu.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelOtherSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTimers
            // 
            this.panelTimers.Controls.Add(this.labelMazeSolveTime);
            this.panelTimers.Controls.Add(this.labelMazeLoadTime);
            this.panelTimers.Location = new System.Drawing.Point(0, 0);
            this.panelTimers.Name = "panelTimers";
            this.panelTimers.Size = new System.Drawing.Size(390, 456);
            this.panelTimers.TabIndex = 9;
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
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.panelChildForm.Controls.Add(this.panelMazeSoler);
            this.panelChildForm.Controls.Add(this.panelTitle);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1234, 761);
            this.panelChildForm.TabIndex = 11;
            // 
            // panelMazeSoler
            // 
            this.panelMazeSoler.Controls.Add(this.panelMazeImage);
            this.panelMazeSoler.Controls.Add(this.panelMazeTimers);
            this.panelMazeSoler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMazeSoler.Location = new System.Drawing.Point(0, 0);
            this.panelMazeSoler.Name = "panelMazeSoler";
            this.panelMazeSoler.Size = new System.Drawing.Size(1234, 761);
            this.panelMazeSoler.TabIndex = 11;
            // 
            // panelMazeImage
            // 
            this.panelMazeImage.AutoScroll = true;
            this.panelMazeImage.AutoSize = true;
            this.panelMazeImage.Controls.Add(this.pictureBoxMaze);
            this.panelMazeImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMazeImage.Location = new System.Drawing.Point(0, 0);
            this.panelMazeImage.Name = "panelMazeImage";
            this.panelMazeImage.Size = new System.Drawing.Size(844, 761);
            this.panelMazeImage.TabIndex = 11;
            // 
            // pictureBoxMaze
            // 
            this.pictureBoxMaze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.pictureBoxMaze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMaze.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMaze.Name = "pictureBoxMaze";
            this.pictureBoxMaze.Padding = new System.Windows.Forms.Padding(100, 100, 0, 0);
            this.pictureBoxMaze.Size = new System.Drawing.Size(844, 761);
            this.pictureBoxMaze.TabIndex = 0;
            this.pictureBoxMaze.TabStop = false;
            // 
            // panelMazeTimers
            // 
            this.panelMazeTimers.Controls.Add(this.panelTimers);
            this.panelMazeTimers.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMazeTimers.Location = new System.Drawing.Point(844, 0);
            this.panelMazeTimers.Name = "panelMazeTimers";
            this.panelMazeTimers.Size = new System.Drawing.Size(390, 761);
            this.panelMazeTimers.TabIndex = 10;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.pictureBoxBackdrop);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1234, 761);
            this.panelTitle.TabIndex = 11;
            // 
            // pictureBoxBackdrop
            // 
            this.pictureBoxBackdrop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxBackdrop.Image = global::MazeSolver.Properties.Resources.Backdrop;
            this.pictureBoxBackdrop.Location = new System.Drawing.Point(230, 156);
            this.pictureBoxBackdrop.Name = "pictureBoxBackdrop";
            this.pictureBoxBackdrop.Size = new System.Drawing.Size(699, 442);
            this.pictureBoxBackdrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackdrop.TabIndex = 10;
            this.pictureBoxBackdrop.TabStop = false;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::MazeSolver.Properties.Resources.Logo;
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(250, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
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
            // panelFileSubmenu
            // 
            this.panelFileSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelFileSubmenu.Controls.Add(this.btnLargeMaze);
            this.panelFileSubmenu.Controls.Add(this.btnMediumMaze);
            this.panelFileSubmenu.Controls.Add(this.btnSmallMaze);
            this.panelFileSubmenu.Controls.Add(this.load);
            this.panelFileSubmenu.Controls.Add(this.save);
            this.panelFileSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFileSubmenu.Location = new System.Drawing.Point(0, 145);
            this.panelFileSubmenu.Name = "panelFileSubmenu";
            this.panelFileSubmenu.Size = new System.Drawing.Size(250, 200);
            this.panelFileSubmenu.TabIndex = 5;
            // 
            // btnLargeMaze
            // 
            this.btnLargeMaze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnLargeMaze.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLargeMaze.FlatAppearance.BorderSize = 0;
            this.btnLargeMaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(182)))), ((int)(((byte)(217)))));
            this.btnLargeMaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(140)))));
            this.btnLargeMaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLargeMaze.ForeColor = System.Drawing.Color.White;
            this.btnLargeMaze.Location = new System.Drawing.Point(0, 160);
            this.btnLargeMaze.Name = "btnLargeMaze";
            this.btnLargeMaze.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLargeMaze.Size = new System.Drawing.Size(250, 40);
            this.btnLargeMaze.TabIndex = 1;
            this.btnLargeMaze.Text = "Large Maze";
            this.btnLargeMaze.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLargeMaze.UseVisualStyleBackColor = false;
            this.btnLargeMaze.Click += new System.EventHandler(this.btnLargeMaze_Click);
            // 
            // btnMediumMaze
            // 
            this.btnMediumMaze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnMediumMaze.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMediumMaze.FlatAppearance.BorderSize = 0;
            this.btnMediumMaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(182)))), ((int)(((byte)(217)))));
            this.btnMediumMaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(140)))));
            this.btnMediumMaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediumMaze.ForeColor = System.Drawing.Color.White;
            this.btnMediumMaze.Location = new System.Drawing.Point(0, 120);
            this.btnMediumMaze.Name = "btnMediumMaze";
            this.btnMediumMaze.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMediumMaze.Size = new System.Drawing.Size(250, 40);
            this.btnMediumMaze.TabIndex = 1;
            this.btnMediumMaze.Text = "Medium Maze";
            this.btnMediumMaze.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMediumMaze.UseVisualStyleBackColor = false;
            this.btnMediumMaze.Click += new System.EventHandler(this.btnMediumMaze_Click);
            // 
            // btnSmallMaze
            // 
            this.btnSmallMaze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnSmallMaze.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSmallMaze.FlatAppearance.BorderSize = 0;
            this.btnSmallMaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(182)))), ((int)(((byte)(217)))));
            this.btnSmallMaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(140)))));
            this.btnSmallMaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmallMaze.ForeColor = System.Drawing.Color.White;
            this.btnSmallMaze.Location = new System.Drawing.Point(0, 80);
            this.btnSmallMaze.Name = "btnSmallMaze";
            this.btnSmallMaze.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSmallMaze.Size = new System.Drawing.Size(250, 40);
            this.btnSmallMaze.TabIndex = 3;
            this.btnSmallMaze.Text = "Small Maze";
            this.btnSmallMaze.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSmallMaze.UseVisualStyleBackColor = false;
            this.btnSmallMaze.Click += new System.EventHandler(this.btnSmallMaze_Click);
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
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.btnSolve.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolve.FlatAppearance.BorderSize = 0;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.ForeColor = System.Drawing.Color.White;
            this.btnSolve.Location = new System.Drawing.Point(0, 345);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSolve.Size = new System.Drawing.Size(250, 45);
            this.btnSolve.TabIndex = 8;
            this.btnSolve.Text = "Solve";
            this.btnSolve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // panelSolveSubmenu
            // 
            this.panelSolveSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelSolveSubmenu.Controls.Add(this.btnBFS);
            this.panelSolveSubmenu.Controls.Add(this.btnDFS);
            this.panelSolveSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSolveSubmenu.Location = new System.Drawing.Point(0, 390);
            this.panelSolveSubmenu.Name = "panelSolveSubmenu";
            this.panelSolveSubmenu.Size = new System.Drawing.Size(250, 80);
            this.panelSolveSubmenu.TabIndex = 7;
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
            // btnShowJunctions
            // 
            this.btnShowJunctions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnShowJunctions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowJunctions.FlatAppearance.BorderSize = 0;
            this.btnShowJunctions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(182)))), ((int)(((byte)(217)))));
            this.btnShowJunctions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(140)))));
            this.btnShowJunctions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowJunctions.ForeColor = System.Drawing.Color.White;
            this.btnShowJunctions.Location = new System.Drawing.Point(0, 0);
            this.btnShowJunctions.Name = "btnShowJunctions";
            this.btnShowJunctions.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnShowJunctions.Size = new System.Drawing.Size(250, 40);
            this.btnShowJunctions.TabIndex = 1;
            this.btnShowJunctions.Text = "Show Junctions";
            this.btnShowJunctions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowJunctions.UseVisualStyleBackColor = false;
            this.btnShowJunctions.Click += new System.EventHandler(this.showJunctions_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.panelSideMenu.Controls.Add(this.panelOtherSubmenu);
            this.panelSideMenu.Controls.Add(this.btnOther);
            this.panelSideMenu.Controls.Add(this.panelSolveSubmenu);
            this.panelSideMenu.Controls.Add(this.btnSolve);
            this.panelSideMenu.Controls.Add(this.panelFileSubmenu);
            this.panelSideMenu.Controls.Add(this.btnFile);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 761);
            this.panelSideMenu.TabIndex = 2;
            // 
            // panelOtherSubmenu
            // 
            this.panelOtherSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelOtherSubmenu.Controls.Add(this.btnShowPaths);
            this.panelOtherSubmenu.Controls.Add(this.btnShowJunctions);
            this.panelOtherSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOtherSubmenu.Location = new System.Drawing.Point(0, 515);
            this.panelOtherSubmenu.Name = "panelOtherSubmenu";
            this.panelOtherSubmenu.Size = new System.Drawing.Size(250, 80);
            this.panelOtherSubmenu.TabIndex = 9;
            // 
            // btnShowPaths
            // 
            this.btnShowPaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnShowPaths.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowPaths.FlatAppearance.BorderSize = 0;
            this.btnShowPaths.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(182)))), ((int)(((byte)(217)))));
            this.btnShowPaths.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(140)))));
            this.btnShowPaths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPaths.ForeColor = System.Drawing.Color.White;
            this.btnShowPaths.Location = new System.Drawing.Point(0, 40);
            this.btnShowPaths.Name = "btnShowPaths";
            this.btnShowPaths.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnShowPaths.Size = new System.Drawing.Size(250, 40);
            this.btnShowPaths.TabIndex = 3;
            this.btnShowPaths.Text = "Show Pathways";
            this.btnShowPaths.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowPaths.UseVisualStyleBackColor = false;
            this.btnShowPaths.Click += new System.EventHandler(this.btnShowPaths_Click);
            // 
            // btnOther
            // 
            this.btnOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(67)))), ((int)(((byte)(118)))));
            this.btnOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOther.FlatAppearance.BorderSize = 0;
            this.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOther.ForeColor = System.Drawing.Color.White;
            this.btnOther.Location = new System.Drawing.Point(0, 470);
            this.btnOther.Name = "btnOther";
            this.btnOther.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOther.Size = new System.Drawing.Size(250, 45);
            this.btnOther.TabIndex = 10;
            this.btnOther.Text = "Other";
            this.btnOther.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOther.UseVisualStyleBackColor = false;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btnDFS
            // 
            this.btnDFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnDFS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDFS.FlatAppearance.BorderSize = 0;
            this.btnDFS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(182)))), ((int)(((byte)(217)))));
            this.btnDFS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(140)))));
            this.btnDFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDFS.ForeColor = System.Drawing.Color.White;
            this.btnDFS.Location = new System.Drawing.Point(0, 0);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDFS.Size = new System.Drawing.Size(250, 40);
            this.btnDFS.TabIndex = 4;
            this.btnDFS.Text = "Depth First Search";
            this.btnDFS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDFS.UseVisualStyleBackColor = false;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // MazeSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(107)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "MazeSolver";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.MazeSolver_Resize);
            this.panelTimers.ResumeLayout(false);
            this.panelTimers.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panelMazeSoler.ResumeLayout(false);
            this.panelMazeSoler.PerformLayout();
            this.panelMazeImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaze)).EndInit();
            this.panelMazeTimers.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackdrop)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelFileSubmenu.ResumeLayout(false);
            this.panelSolveSubmenu.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelOtherSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTimers;
        private System.Windows.Forms.Label labelMazeSolveTime;
        private System.Windows.Forms.Label labelMazeLoadTime;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBoxMaze;
        private System.Windows.Forms.PictureBox pictureBoxBackdrop;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Panel panelFileSubmenu;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Panel panelSolveSubmenu;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button btnShowJunctions;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelMazeSoler;
        private System.Windows.Forms.Panel panelMazeImage;
        private System.Windows.Forms.Panel panelMazeTimers;
        private System.Windows.Forms.Panel panelOtherSubmenu;
        private System.Windows.Forms.Button btnShowPaths;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnLargeMaze;
        private System.Windows.Forms.Button btnMediumMaze;
        private System.Windows.Forms.Button btnSmallMaze;
        private System.Windows.Forms.Button btnDFS;
    }
}

