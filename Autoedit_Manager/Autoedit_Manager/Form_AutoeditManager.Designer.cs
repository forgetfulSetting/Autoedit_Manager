namespace Autoedit_Manager
{
    partial class Form_AutoeditManager
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
            this.button_NewXml = new System.Windows.Forms.Button();
            this.saveFileDialog_XMLFile = new System.Windows.Forms.SaveFileDialog();
            this.AutoeditTreeview = new System.Windows.Forms.TreeView();
            this.button_Add_Autoedit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_NewXml
            // 
            this.button_NewXml.Location = new System.Drawing.Point(12, 12);
            this.button_NewXml.Name = "button_NewXml";
            this.button_NewXml.Size = new System.Drawing.Size(75, 23);
            this.button_NewXml.TabIndex = 0;
            this.button_NewXml.Text = "New XML";
            this.button_NewXml.UseVisualStyleBackColor = true;
            this.button_NewXml.Click += new System.EventHandler(this.button_NewXml_Click);
            // 
            // AutoeditTreeview
            // 
            this.AutoeditTreeview.Location = new System.Drawing.Point(12, 50);
            this.AutoeditTreeview.Name = "AutoeditTreeview";
            this.AutoeditTreeview.Size = new System.Drawing.Size(254, 240);
            this.AutoeditTreeview.TabIndex = 1;
            // 
            // button_Add_Autoedit
            // 
            this.button_Add_Autoedit.Location = new System.Drawing.Point(12, 434);
            this.button_Add_Autoedit.Name = "button_Add_Autoedit";
            this.button_Add_Autoedit.Size = new System.Drawing.Size(254, 23);
            this.button_Add_Autoedit.TabIndex = 2;
            this.button_Add_Autoedit.Text = "Add Autoedit";
            this.button_Add_Autoedit.UseVisualStyleBackColor = true;
            this.button_Add_Autoedit.Click += new System.EventHandler(this.button_Add_Autoedit_Click);
            // 
            // Form_AutoeditManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 469);
            this.Controls.Add(this.button_Add_Autoedit);
            this.Controls.Add(this.AutoeditTreeview);
            this.Controls.Add(this.button_NewXml);
            this.Name = "Form_AutoeditManager";
            this.Text = "Autoedit Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_NewXml;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_XMLFile;
        private System.Windows.Forms.TreeView AutoeditTreeview;
        private System.Windows.Forms.Button button_Add_Autoedit;

    }
}

