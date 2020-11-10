namespace Tagdíj
{
    partial class Befizetesekuj
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_ujAzon = new System.Windows.Forms.TextBox();
            this.dateTimePicker1_ujdatum = new System.Windows.Forms.DateTimePicker();
            this.textBox1_ujosszeg = new System.Windows.Forms.TextBox();
            this.button1_Befizetes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új befizetés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(175, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Azonosító:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(175, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dátum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(175, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Összeg:";
            // 
            // textBox1_ujAzon
            // 
            this.textBox1_ujAzon.Location = new System.Drawing.Point(286, 82);
            this.textBox1_ujAzon.Name = "textBox1_ujAzon";
            this.textBox1_ujAzon.Size = new System.Drawing.Size(155, 20);
            this.textBox1_ujAzon.TabIndex = 4;
            // 
            // dateTimePicker1_ujdatum
            // 
            this.dateTimePicker1_ujdatum.Location = new System.Drawing.Point(286, 146);
            this.dateTimePicker1_ujdatum.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1_ujdatum.MinDate = new System.DateTime(2019, 1, 17, 0, 0, 0, 0);
            this.dateTimePicker1_ujdatum.Name = "dateTimePicker1_ujdatum";
            this.dateTimePicker1_ujdatum.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1_ujdatum.TabIndex = 5;
            // 
            // textBox1_ujosszeg
            // 
            this.textBox1_ujosszeg.Location = new System.Drawing.Point(282, 201);
            this.textBox1_ujosszeg.Name = "textBox1_ujosszeg";
            this.textBox1_ujosszeg.Size = new System.Drawing.Size(159, 20);
            this.textBox1_ujosszeg.TabIndex = 6;
            // 
            // button1_Befizetes
            // 
            this.button1_Befizetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_Befizetes.Location = new System.Drawing.Point(273, 277);
            this.button1_Befizetes.Name = "button1_Befizetes";
            this.button1_Befizetes.Size = new System.Drawing.Size(180, 51);
            this.button1_Befizetes.TabIndex = 7;
            this.button1_Befizetes.Text = "Befizetés";
            this.button1_Befizetes.UseVisualStyleBackColor = true;
            // 
            // Befizetesekuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_Befizetes);
            this.Controls.Add(this.textBox1_ujosszeg);
            this.Controls.Add(this.dateTimePicker1_ujdatum);
            this.Controls.Add(this.textBox1_ujAzon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Befizetesekuj";
            this.Text = "Befizetesekuj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Befizetesekuj_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_ujAzon;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_ujdatum;
        private System.Windows.Forms.TextBox textBox1_ujosszeg;
        private System.Windows.Forms.Button button1_Befizetes;
    }
}