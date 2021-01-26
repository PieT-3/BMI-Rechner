
namespace BMI_Rechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Eingabe_Größe = new System.Windows.Forms.TextBox();
            this.lbl_Eingabe_Größe = new System.Windows.Forms.Label();
            this.lbl_Eingabe_Gewicht = new System.Windows.Forms.Label();
            this.tb_Eingabe_Gewicht = new System.Windows.Forms.TextBox();
            this.tb_Rückmeldung_Anwender = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_BMI_berechnen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Eingabe_Größe
            // 
            this.tb_Eingabe_Größe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Eingabe_Größe.Location = new System.Drawing.Point(103, 3);
            this.tb_Eingabe_Größe.MaxLength = 5;
            this.tb_Eingabe_Größe.Name = "tb_Eingabe_Größe";
            this.tb_Eingabe_Größe.Size = new System.Drawing.Size(1069, 20);
            this.tb_Eingabe_Größe.TabIndex = 1;
            // 
            // lbl_Eingabe_Größe
            // 
            this.lbl_Eingabe_Größe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Eingabe_Größe.Location = new System.Drawing.Point(3, 0);
            this.lbl_Eingabe_Größe.Name = "lbl_Eingabe_Größe";
            this.lbl_Eingabe_Größe.Size = new System.Drawing.Size(94, 43);
            this.lbl_Eingabe_Größe.TabIndex = 3;
            this.lbl_Eingabe_Größe.Text = "Eingabe Größe:";
            // 
            // lbl_Eingabe_Gewicht
            // 
            this.lbl_Eingabe_Gewicht.AutoSize = true;
            this.lbl_Eingabe_Gewicht.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Eingabe_Gewicht.Location = new System.Drawing.Point(3, 43);
            this.lbl_Eingabe_Gewicht.Name = "lbl_Eingabe_Gewicht";
            this.lbl_Eingabe_Gewicht.Size = new System.Drawing.Size(94, 43);
            this.lbl_Eingabe_Gewicht.TabIndex = 4;
            this.lbl_Eingabe_Gewicht.Text = "Eingabe Gewicht:";
            // 
            // tb_Eingabe_Gewicht
            // 
            this.tb_Eingabe_Gewicht.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Eingabe_Gewicht.Location = new System.Drawing.Point(103, 46);
            this.tb_Eingabe_Gewicht.Name = "tb_Eingabe_Gewicht";
            this.tb_Eingabe_Gewicht.Size = new System.Drawing.Size(1069, 20);
            this.tb_Eingabe_Gewicht.TabIndex = 5;
            // 
            // tb_Rückmeldung_Anwender
            // 
            this.tb_Rückmeldung_Anwender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Rückmeldung_Anwender.Location = new System.Drawing.Point(3, 16);
            this.tb_Rückmeldung_Anwender.Name = "tb_Rückmeldung_Anwender";
            this.tb_Rückmeldung_Anwender.ReadOnly = true;
            this.tb_Rückmeldung_Anwender.Size = new System.Drawing.Size(1175, 400);
            this.tb_Rückmeldung_Anwender.TabIndex = 9;
            this.tb_Rückmeldung_Anwender.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 148);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingabedaten";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.tb_Eingabe_Gewicht, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_Eingabe_Größe, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_BMI_berechnen, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Eingabe_Gewicht, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Eingabe_Größe, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1175, 129);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // btn_BMI_berechnen
            // 
            this.btn_BMI_berechnen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_BMI_berechnen.Location = new System.Drawing.Point(3, 89);
            this.btn_BMI_berechnen.Name = "btn_BMI_berechnen";
            this.btn_BMI_berechnen.Size = new System.Drawing.Size(94, 37);
            this.btn_BMI_berechnen.TabIndex = 0;
            this.btn_BMI_berechnen.Text = "BMI berechnen";
            this.btn_BMI_berechnen.UseVisualStyleBackColor = true;
            this.btn_BMI_berechnen.Click += new System.EventHandler(this.btn_BMI_berechnen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Rückmeldung_Anwender);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1181, 419);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BMI-Auswertung";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 567);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "BMI-Rechner";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Eingabe_Größe;
        private System.Windows.Forms.Label lbl_Eingabe_Größe;
        private System.Windows.Forms.Label lbl_Eingabe_Gewicht;
        private System.Windows.Forms.TextBox tb_Eingabe_Gewicht;
        private System.Windows.Forms.RichTextBox tb_Rückmeldung_Anwender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_BMI_berechnen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

