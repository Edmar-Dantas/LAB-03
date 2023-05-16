namespace LAB_03
{
    partial class JanelaPrincipal
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
            this.BoxScreenImg = new System.Windows.Forms.PictureBox();
            this.openFileDialogBuscar = new System.Windows.Forms.OpenFileDialog();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BoxScreenImg)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxScreenImg
            // 
            this.BoxScreenImg.Location = new System.Drawing.Point(4, 52);
            this.BoxScreenImg.Name = "BoxScreenImg";
            this.BoxScreenImg.Size = new System.Drawing.Size(324, 428);
            this.BoxScreenImg.TabIndex = 0;
            this.BoxScreenImg.TabStop = false;
            // 
            // openFileDialogBuscar
            // 
            this.openFileDialogBuscar.FileName = "openFileDialogBuscar";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(133, 495);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "&Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 530);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.BoxScreenImg);
            this.MaximizeBox = false;
            this.Name = "JanelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Imagens >>>>>>";
            ((System.ComponentModel.ISupportInitialize)(this.BoxScreenImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox BoxScreenImg;
        private OpenFileDialog openFileDialogBuscar;
        private Button btn_buscar;
    }
}