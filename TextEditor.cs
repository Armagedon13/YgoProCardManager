using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DevPro_CardManager.Enums;
using System.IO;
using System.Data.SQLite;
using DevPro_CardManager.Properties;
using System.Linq;
using DevPro_CardManager;
using System.Text;
using System.Threading.Tasks;

namespace DevPro_CardManager
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
            TextEditorSetName.Text = File.ReadAllText(@"Assets\setname.txt");

           


        }


        private void TextEditorSetName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File.Exists(@"Assets\setname.txt");
            TextEditorSetName.SaveFile(System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal)
             + @"Assets\setname.txt",
             RichTextBoxStreamType.RichNoOleObjs);
        }

       
    }
}
