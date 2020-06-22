using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using iTextSharp.text;
using MergeDocs.Classes;
using Path = System.IO.Path;
using System.Web.UI.WebControls;


namespace MergeDocs
{
    public partial class MergeDocs : Form
    {


        private string[] Paths, Files;                  //To store the names and path of the file

        public MergeDocs()
        {
            InitializeComponent();
        }

        private void AddFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();    //Enables to browse Files

            openFileDialog.Multiselect = true;                       //Allows to import more than one file at a time

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Files = openFileDialog.SafeFileNames;   //Saves the name of the files
                Paths = openFileDialog.FileNames;       //Saves the path of the files

                for (int i = 0; i < Files.Length; i++)
                {
                    FilesList.Items.Add(Files[i]);      //Displays the imported files in list box 
                }

            }
        }

        private void FilesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path;
            FilesList.MultiSelect = false;

            if (FilesList.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                path = Paths[FilesList.SelectedIndices[0] - 1];
            }

            TextViewer.Text = new DocReader().PdfReader(path);
        }

        private void AddFiles_MouseMove(object sender, MouseEventArgs e)
        {
            AddFiles.BackColor = Color.White;                   //Changes the colour of the add button when mouse is moved over
        }

        private void AddFiles_MouseLeave(object sender, EventArgs e)
        {
            AddFiles.BackColor = Color.Empty;                   //Resets the color of the add button when the mouse is left
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {



            Clipboard.SetText(TextViewer.SelectedText);       //Copies selected text into clipborad
            WordProcessor.Text += Clipboard.GetText();        //copies text from clipboard to wordprocessor  

            //  WordProcessor.Text += "\n" + TextViewer.SelectedText;
            //  WordProcessor.Text += "\n" + TextViewer.SelectedText;


        }

        private void FullPage_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

