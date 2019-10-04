namespace PictureViewer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCropNormal = new System.Windows.Forms.Button();
            this.btnCropFaceOld = new System.Windows.Forms.Button();
            this.btnCropFaceNew = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewMachineNormal = new System.Windows.Forms.Button();
            this.btnNewMachineFace = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUndo, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCropNormal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCropFaceOld, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCropFaceNew, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNewMachineNormal, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNewMachineFace, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1049, 636);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox, 5);
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1043, 536);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.Location = new System.Drawing.Point(839, 545);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUndo.Size = new System.Drawing.Size(207, 42);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "Quay lại";
            this.btnUndo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::PictureViewer.Properties.Resources.print;
            this.btnPrint.Location = new System.Drawing.Point(3, 545);
            this.btnPrint.Name = "btnPrint";
            this.tableLayoutPanel1.SetRowSpan(this.btnPrint, 2);
            this.btnPrint.Size = new System.Drawing.Size(203, 88);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCropNormal
            // 
            this.btnCropNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCropNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCropNormal.Image = global::PictureViewer.Properties.Resources.crop;
            this.btnCropNormal.Location = new System.Drawing.Point(212, 545);
            this.btnCropNormal.Name = "btnCropNormal";
            this.btnCropNormal.Size = new System.Drawing.Size(203, 42);
            this.btnCropNormal.TabIndex = 2;
            this.btnCropNormal.Text = "Cắt ảnh thường";
            this.btnCropNormal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCropNormal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCropNormal.UseVisualStyleBackColor = true;
            this.btnCropNormal.Click += new System.EventHandler(this.btnCropNormal_Click);
            // 
            // btnCropFaceOld
            // 
            this.btnCropFaceOld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCropFaceOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCropFaceOld.Image = global::PictureViewer.Properties.Resources.crop;
            this.btnCropFaceOld.Location = new System.Drawing.Point(421, 545);
            this.btnCropFaceOld.Name = "btnCropFaceOld";
            this.btnCropFaceOld.Size = new System.Drawing.Size(203, 42);
            this.btnCropFaceOld.TabIndex = 3;
            this.btnCropFaceOld.Text = "Cắt ảnh mặt C";
            this.btnCropFaceOld.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCropFaceOld.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCropFaceOld.UseVisualStyleBackColor = true;
            this.btnCropFaceOld.Click += new System.EventHandler(this.btnCropFaceOld_Click);
            // 
            // btnCropFaceNew
            // 
            this.btnCropFaceNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCropFaceNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCropFaceNew.Image = global::PictureViewer.Properties.Resources.crop;
            this.btnCropFaceNew.Location = new System.Drawing.Point(630, 545);
            this.btnCropFaceNew.Name = "btnCropFaceNew";
            this.btnCropFaceNew.Size = new System.Drawing.Size(203, 42);
            this.btnCropFaceNew.TabIndex = 6;
            this.btnCropFaceNew.Text = "Cắt ảnh mặt M";
            this.btnCropFaceNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCropFaceNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCropFaceNew.UseVisualStyleBackColor = true;
            this.btnCropFaceNew.Click += new System.EventHandler(this.btnCropFaceNew_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.printToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.openToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnNewMachineNormal
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnNewMachineNormal, 2);
            this.btnNewMachineNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewMachineNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNewMachineNormal.Image = global::PictureViewer.Properties.Resources.crop;
            this.btnNewMachineNormal.Location = new System.Drawing.Point(212, 593);
            this.btnNewMachineNormal.Name = "btnNewMachineNormal";
            this.btnNewMachineNormal.Size = new System.Drawing.Size(412, 40);
            this.btnNewMachineNormal.TabIndex = 2;
            this.btnNewMachineNormal.Text = "Cắt ảnh thường máy mới";
            this.btnNewMachineNormal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewMachineNormal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewMachineNormal.UseVisualStyleBackColor = true;
            this.btnNewMachineNormal.Click += new System.EventHandler(this.btnNewMachineNormal_Click);
            // 
            // btnNewMachineFace
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnNewMachineFace, 2);
            this.btnNewMachineFace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewMachineFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNewMachineFace.Image = global::PictureViewer.Properties.Resources.crop;
            this.btnNewMachineFace.Location = new System.Drawing.Point(630, 593);
            this.btnNewMachineFace.Name = "btnNewMachineFace";
            this.btnNewMachineFace.Size = new System.Drawing.Size(416, 40);
            this.btnNewMachineFace.TabIndex = 7;
            this.btnNewMachineFace.Text = "Cắt ảnh mặt máy mới";
            this.btnNewMachineFace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewMachineFace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewMachineFace.UseVisualStyleBackColor = true;
            this.btnNewMachineFace.Click += new System.EventHandler(this.btnNewMachineFace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 660);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1041, 603);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewer - Phongkham158";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCropFaceOld;
        private System.Windows.Forms.Button btnCropNormal;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Button btnCropFaceNew;
        private System.Windows.Forms.Button btnNewMachineNormal;
        private System.Windows.Forms.Button btnNewMachineFace;
    }
}

