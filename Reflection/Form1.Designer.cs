namespace Reflection
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.texttypename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listMethods = new System.Windows.Forms.ListBox();
            this.listProperties = new System.Windows.Forms.ListBox();
            this.listConstructors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Discover Type Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // texttypename
            // 
            this.texttypename.Location = new System.Drawing.Point(155, 16);
            this.texttypename.Name = "texttypename";
            this.texttypename.Size = new System.Drawing.Size(155, 20);
            this.texttypename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type Name";
            // 
            // listMethods
            // 
            this.listMethods.FormattingEnabled = true;
            this.listMethods.Location = new System.Drawing.Point(26, 110);
            this.listMethods.Name = "listMethods";
            this.listMethods.Size = new System.Drawing.Size(120, 95);
            this.listMethods.TabIndex = 3;
            // 
            // listProperties
            // 
            this.listProperties.FormattingEnabled = true;
            this.listProperties.Location = new System.Drawing.Point(215, 110);
            this.listProperties.Name = "listProperties";
            this.listProperties.Size = new System.Drawing.Size(120, 95);
            this.listProperties.TabIndex = 4;
            // 
            // listConstructors
            // 
            this.listConstructors.FormattingEnabled = true;
            this.listConstructors.Location = new System.Drawing.Point(409, 110);
            this.listConstructors.Name = "listConstructors";
            this.listConstructors.Size = new System.Drawing.Size(120, 95);
            this.listConstructors.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listConstructors);
            this.Controls.Add(this.listProperties);
            this.Controls.Add(this.listMethods);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texttypename);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox texttypename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listMethods;
        private System.Windows.Forms.ListBox listProperties;
        private System.Windows.Forms.ListBox listConstructors;
    }
}

