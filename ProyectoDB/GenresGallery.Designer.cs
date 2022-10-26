namespace ProyectoDB
{
    partial class GenresGallery
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
            this.container = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(132, 59);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(740, 373);
            this.container.TabIndex = 1;
            // 
            // GenresGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 491);
            this.Controls.Add(this.container);
            this.Name = "GenresGallery";
            this.Text = "GenresGallery";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel container;
    }
}