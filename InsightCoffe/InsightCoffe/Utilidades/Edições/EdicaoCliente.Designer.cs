namespace InsightCoffe.Utilidades.Edições
{
    partial class EdicaoCliente
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
            this.maskedBId = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // maskedBId
            // 
            this.maskedBId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedBId.Location = new System.Drawing.Point(33, 28);
            this.maskedBId.Mask = "000,000,000-00";
            this.maskedBId.Name = "maskedBId";
            this.maskedBId.Size = new System.Drawing.Size(139, 26);
            this.maskedBId.TabIndex = 0;
            this.maskedBId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedBCPF_KeyPress);
            // 
            // EdicaoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 82);
            this.Controls.Add(this.maskedBId);
            this.Name = "EdicaoCliente";
            this.Text = "Insira o CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedBId;
    }
}