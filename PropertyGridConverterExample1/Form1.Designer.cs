
namespace PropertyGridConverterExample1
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
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.AssignGoodButton = new System.Windows.Forms.Button();
            this.AssignBadButton = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(12, 12);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(727, 208);
            this.propertyGrid.TabIndex = 0;
            // 
            // AssignGoodButton
            // 
            this.AssignGoodButton.Location = new System.Drawing.Point(12, 236);
            this.AssignGoodButton.Name = "AssignGoodButton";
            this.AssignGoodButton.Size = new System.Drawing.Size(157, 23);
            this.AssignGoodButton.TabIndex = 1;
            this.AssignGoodButton.Text = "Assign item (good)";
            this.AssignGoodButton.UseVisualStyleBackColor = true;
            this.AssignGoodButton.Click += new System.EventHandler(this.AssignGoodButton_Click);
            // 
            // AssignBadButton
            // 
            this.AssignBadButton.Location = new System.Drawing.Point(175, 236);
            this.AssignBadButton.Name = "AssignBadButton";
            this.AssignBadButton.Size = new System.Drawing.Size(157, 23);
            this.AssignBadButton.TabIndex = 2;
            this.AssignBadButton.Text = "Assign item (bad)";
            this.AssignBadButton.UseVisualStyleBackColor = true;
            this.AssignBadButton.Click += new System.EventHandler(this.AssignBadButton_Click);
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(338, 236);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(75, 23);
            this.GetButton.TabIndex = 3;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 271);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.AssignBadButton);
            this.Controls.Add(this.AssignGoodButton);
            this.Controls.Add(this.propertyGrid);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validate properties in PropertyGrid simple";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button AssignGoodButton;
        private System.Windows.Forms.Button AssignBadButton;
        private System.Windows.Forms.Button GetButton;
    }
}

