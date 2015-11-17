using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Autoedit_Manager.Classes;

namespace Autoedit_Manager
{
    public partial class Form_AutoeditManager : Form
    {
       
        public Form_AutoeditManager()
        {
            InitializeComponent();
        }

        private void button_NewXml_Click(object sender, EventArgs e)
        { //Opens a dialog box, prompting the user to choose whether to discard the changes, or not.
            DialogResult unsavedChanges_Result = MessageBox.Show(XML.TestString, "Testbox", MessageBoxButtons.YesNo); //(Specified text, caption, buttons)

            
        }

    }
}
