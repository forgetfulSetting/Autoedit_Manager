using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Autoedit_Manager.Classes;
using System.IO;


namespace Autoedit_Manager
{
    public partial class Form_AutoeditManager : Form
    {
        private Classes.XML xmlFile; //Unsure

        public Form_AutoeditManager()
        {
            InitializeComponent();
        }

  
        private void button_NewXml_Click(object sender, EventArgs e)
        {
            //Opens a dialog box, prompting the user to choose whether to discard the changes, or not.
            DialogResult unsavedChanges_Result = MessageBox.Show("Current XML file has unsaved changes. Are you sure you want to discard them?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); //(Specified text, caption, buttons)

            if (unsavedChanges_Result == System.Windows.Forms.DialogResult.No) //If the dialog box returns a "No", then go back to the main method.
            {
                return;
            }

            saveFileDialog_XMLFile.Filter = "XML Files|*.xml"; //Setting the filter"Description of filter"|filter pattern
            DialogResult saveFileDialog_XMLFile_Result = saveFileDialog_XMLFile.ShowDialog(); // Open the dialog box and store the OK in the variable
            if (saveFileDialog_XMLFile_Result == System.Windows.Forms.DialogResult.OK)
            {
                ClearForm();
                AutoeditTreeview.Nodes.Add("Test Node");
            }

        }

        private void ClearForm()
        {

        }

        private void button_Add_Autoedit_Click(object sender, EventArgs e)
        {
            DialogResult newAutoedit = MessageBox.Show("Please add new Autoedit Parameter");
            AutoeditTreeview.Nodes.Add("Test1");
        }

    }
}

    