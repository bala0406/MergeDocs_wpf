namespace MergeDocs
{
    partial class MergeDocs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.FilesList = new System.Windows.Forms.ListView();
            this.ImportPanel = new System.Windows.Forms.Panel();
            this.Files_text = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AddFiles = new Bunifu.Framework.UI.BunifuImageButton();
            this.TextViewer = new System.Windows.Forms.RichTextBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.WordProcessor = new TXTextControl.TextControl();
            this.FullPage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.WordProcessorPanel = new System.Windows.Forms.Panel();
            this.ImportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.WordProcessorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilesList
            // 
            this.FilesList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.FilesList.Location = new System.Drawing.Point(0, 34);
            this.FilesList.Name = "FilesList";
            this.FilesList.Size = new System.Drawing.Size(396, 251);
            this.FilesList.TabIndex = 3;
            this.FilesList.UseCompatibleStateImageBehavior = false;
            this.FilesList.View = System.Windows.Forms.View.List;
            this.FilesList.SelectedIndexChanged += new System.EventHandler(this.FilesList_SelectedIndexChanged);
            // 
            // ImportPanel
            // 
            this.ImportPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.ImportPanel.Controls.Add(this.Files_text);
            this.ImportPanel.Controls.Add(this.AddFiles);
            this.ImportPanel.Controls.Add(this.FilesList);
            this.ImportPanel.Location = new System.Drawing.Point(12, 12);
            this.ImportPanel.Name = "ImportPanel";
            this.ImportPanel.Size = new System.Drawing.Size(396, 285);
            this.ImportPanel.TabIndex = 4;
            // 
            // Files_text
            // 
            this.Files_text.AutoSize = true;
            this.Files_text.BackColor = System.Drawing.SystemColors.Highlight;
            this.Files_text.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Files_text.ForeColor = System.Drawing.Color.White;
            this.Files_text.Location = new System.Drawing.Point(0, 2);
            this.Files_text.Name = "Files_text";
            this.Files_text.Size = new System.Drawing.Size(62, 29);
            this.Files_text.TabIndex = 7;
            this.Files_text.Text = "Files";
            // 
            // AddFiles
            // 
            this.AddFiles.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddFiles.Image = global::MergeDocs.Properties.Resources.add;
            this.AddFiles.ImageActive = null;
            this.AddFiles.InitialImage = global::MergeDocs.Properties.Resources.add_plus_button;
            this.AddFiles.Location = new System.Drawing.Point(368, 6);
            this.AddFiles.Name = "AddFiles";
            this.AddFiles.Size = new System.Drawing.Size(25, 25);
            this.AddFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddFiles.TabIndex = 6;
            this.AddFiles.TabStop = false;
            this.AddFiles.Zoom = 10;
            this.AddFiles.Click += new System.EventHandler(this.AddFiles_Click);
            this.AddFiles.MouseLeave += new System.EventHandler(this.AddFiles_MouseLeave);
            this.AddFiles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddFiles_MouseMove);
            // 
            // TextViewer
            // 
            this.TextViewer.Location = new System.Drawing.Point(12, 303);
            this.TextViewer.Name = "TextViewer";
            this.TextViewer.Size = new System.Drawing.Size(556, 531);
            this.TextViewer.TabIndex = 5;
            this.TextViewer.Text = "";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::MergeDocs.Properties.Resources.right_arrow;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(574, 337);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.Control;
            this.Close.Image = global::MergeDocs.Properties.Resources.close_button;
            this.Close.ImageActive = null;
            this.Close.Location = new System.Drawing.Point(1236, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 25);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 6;
            this.Close.TabStop = false;
            this.Close.Zoom = 10;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // WordProcessor
            // 
            this.WordProcessor.Font = new System.Drawing.Font("Arial", 10F);
            this.WordProcessor.Location = new System.Drawing.Point(0, 3);
            this.WordProcessor.Name = "WordProcessor";
            this.WordProcessor.Size = new System.Drawing.Size(609, 700);
            this.WordProcessor.TabIndex = 8;
            this.WordProcessor.Text = "textControl1";
            this.WordProcessor.UserNames = null;
            // 
            // FullPage
            // 
            this.FullPage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FullPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.FullPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FullPage.BorderRadius = 0;
            this.FullPage.ButtonText = "View as FullPage";
            this.FullPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullPage.DisabledColor = System.Drawing.Color.Gray;
            this.FullPage.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullPage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FullPage.Iconcolor = System.Drawing.Color.Transparent;
            this.FullPage.Iconimage = null;
            this.FullPage.Iconimage_right = null;
            this.FullPage.Iconimage_right_Selected = null;
            this.FullPage.Iconimage_Selected = null;
            this.FullPage.IconMarginLeft = 0;
            this.FullPage.IconMarginRight = 0;
            this.FullPage.IconRightVisible = true;
            this.FullPage.IconRightZoom = 0D;
            this.FullPage.IconVisible = true;
            this.FullPage.IconZoom = 90D;
            this.FullPage.IsTab = false;
            this.FullPage.Location = new System.Drawing.Point(925, 743);
            this.FullPage.Name = "FullPage";
            this.FullPage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.FullPage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.FullPage.OnHoverTextColor = System.Drawing.Color.White;
            this.FullPage.selected = false;
            this.FullPage.Size = new System.Drawing.Size(116, 33);
            this.FullPage.TabIndex = 10;
            this.FullPage.Text = "View as FullPage";
            this.FullPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FullPage.Textcolor = System.Drawing.Color.White;
            this.FullPage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullPage.Click += new System.EventHandler(this.FullPage_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // WordProcessorPanel
            // 
            this.WordProcessorPanel.Controls.Add(this.WordProcessor);
            this.WordProcessorPanel.Location = new System.Drawing.Point(652, 34);
            this.WordProcessorPanel.Name = "WordProcessorPanel";
            this.WordProcessorPanel.Size = new System.Drawing.Size(609, 700);
            this.WordProcessorPanel.TabIndex = 11;
            // 
            // MergeDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 846);
            this.Controls.Add(this.FullPage);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.TextViewer);
            this.Controls.Add(this.ImportPanel);
            this.Controls.Add(this.WordProcessorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MergeDocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      ";
            this.ImportPanel.ResumeLayout(false);
            this.ImportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.WordProcessorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView FilesList;
        private System.Windows.Forms.Panel ImportPanel;
        private Bunifu.Framework.UI.BunifuImageButton AddFiles;
        private System.Windows.Forms.RichTextBox TextViewer;
        private Bunifu.Framework.UI.BunifuImageButton Close;
        private Bunifu.Framework.UI.BunifuCustomLabel Files_text;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private TXTextControl.TextControl WordProcessor;
        private Bunifu.Framework.UI.BunifuFlatButton FullPage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel WordProcessorPanel;
    }
}

