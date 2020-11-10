namespace Tagdíj
{
    partial class Befizeteslekerdezes
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1_lekerdezes = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Befizetések lekérdezése";
            // 
            // button1_lekerdezes
            // 
            this.button1_lekerdezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_lekerdezes.Location = new System.Drawing.Point(279, 362);
            this.button1_lekerdezes.Name = "button1_lekerdezes";
            this.button1_lekerdezes.Size = new System.Drawing.Size(225, 76);
            this.button1_lekerdezes.TabIndex = 1;
            this.button1_lekerdezes.Text = "Lekérdezés";
            this.button1_lekerdezes.UseVisualStyleBackColor = true;
            this.button1_lekerdezes.Click += new System.EventHandler(this.button1_lekerdezes_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(792, 315);
            this.dataGridView1.TabIndex = 2;
            // 
            // Befizeteslekerdezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1_lekerdezes);
            this.Controls.Add(this.label1);
            this.Name = "Befizeteslekerdezes";
            this.Text = "Befizeteslekerdezes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Befizeteslekerdezes_FormClosing);
            this.Load += new System.EventHandler(this.Befizeteslekerdezes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_lekerdezes;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}