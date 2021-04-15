
namespace PropertyGridSqlServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ProductsListBox = new System.Windows.Forms.ListBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.SaveCurrentButton = new System.Windows.Forms.Button();
            this.SaveAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.Location = new System.Drawing.Point(18, 22);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(588, 108);
            this.ProductsListBox.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(16, 146);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(590, 292);
            this.propertyGrid1.TabIndex = 1;
            // 
            // SaveCurrentButton
            // 
            this.SaveCurrentButton.Image = global::PropertyGridSqlServer.Properties.Resources.Save_16x;
            this.SaveCurrentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveCurrentButton.Location = new System.Drawing.Point(624, 22);
            this.SaveCurrentButton.Name = "SaveCurrentButton";
            this.SaveCurrentButton.Size = new System.Drawing.Size(164, 30);
            this.SaveCurrentButton.TabIndex = 2;
            this.SaveCurrentButton.Text = "Save current";
            this.SaveCurrentButton.UseVisualStyleBackColor = true;
            this.SaveCurrentButton.Click += new System.EventHandler(this.SaveCurrentButton_Click);
            // 
            // SaveAllButton
            // 
            this.SaveAllButton.Image = global::PropertyGridSqlServer.Properties.Resources.Save_16x;
            this.SaveAllButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveAllButton.Location = new System.Drawing.Point(624, 58);
            this.SaveAllButton.Name = "SaveAllButton";
            this.SaveAllButton.Size = new System.Drawing.Size(164, 30);
            this.SaveAllButton.TabIndex = 3;
            this.SaveAllButton.Text = "Save all";
            this.SaveAllButton.UseVisualStyleBackColor = true;
            this.SaveAllButton.Click += new System.EventHandler(this.SaveAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveAllButton);
            this.Controls.Add(this.SaveCurrentButton);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.ProductsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL-Server/PropertyGrid";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProductsListBox;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button SaveCurrentButton;
        private System.Windows.Forms.Button SaveAllButton;
    }
}

