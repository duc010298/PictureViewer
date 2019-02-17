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
            this.btnOpen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnCropOld = new System.Windows.Forms.Button();
            this.btnCropNormal = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpen
            // 
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(3, 527);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(159, 41);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCropOld, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCropNormal, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOpen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUndo, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 571);
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
            this.pictureBox.Size = new System.Drawing.Size(985, 518);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            // 
            // btnCropOld
            // 
            this.btnCropOld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCropOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCropOld.Image = global::PictureViewer.Properties.Resources.crop;
            this.btnCropOld.Location = new System.Drawing.Point(608, 527);
            this.btnCropOld.Name = "btnCropOld";
            this.btnCropOld.Size = new System.Drawing.Size(214, 41);
            this.btnCropOld.TabIndex = 3;
            this.btnCropOld.Text = "Cắt ảnh mặt";
            this.btnCropOld.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCropOld.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCropOld.UseVisualStyleBackColor = true;
            this.btnCropOld.Click += new System.EventHandler(this.btnCropOld_Click);
            // 
            // btnCropNormal
            // 
            this.btnCropNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCropNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCropNormal.Image = global::PictureViewer.Properties.Resources.crop;
            this.btnCropNormal.Location = new System.Drawing.Point(388, 527);
            this.btnCropNormal.Name = "btnCropNormal";
            this.btnCropNormal.Size = new System.Drawing.Size(214, 41);
            this.btnCropNormal.TabIndex = 2;
            this.btnCropNormal.Text = "Cắt ảnh thường";
            this.btnCropNormal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCropNormal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCropNormal.UseVisualStyleBackColor = true;
            this.btnCropNormal.Click += new System.EventHandler(this.btnCropNormal_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::PictureViewer.Properties.Resources.print;
            this.btnPrint.Location = new System.Drawing.Point(168, 527);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(214, 41);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.Location = new System.Drawing.Point(828, 527);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUndo.Size = new System.Drawing.Size(160, 41);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "Quay lại";
            this.btnUndo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 571);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewer - Phongkham158";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnCropOld;
        private System.Windows.Forms.Button btnCropNormal;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnUndo;
    }
}

