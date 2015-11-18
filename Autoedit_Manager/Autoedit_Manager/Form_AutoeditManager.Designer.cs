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
            // Form_AutoeditManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 469);
            this.Controls.Add(this.button_NewXml);
            this.Name = "Form_AutoeditManager";
            this.Text = "Autoedit Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_NewXml;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_XMLFile;

    }
}

