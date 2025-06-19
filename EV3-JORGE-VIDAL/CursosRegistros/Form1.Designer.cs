using System;
using System.Drawing;
using System.Windows.Forms;


namespace RegistroCursos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbxID = new TextBox();
            tbxNOMBRES = new TextBox();
            tbxAPELLIDOPAT = new TextBox();
            tbxAPELLIDOMAT = new TextBox();
            tbxRUT = new TextBox();
            tbxNMATRICULA = new TextBox();
            tbxCURSO = new TextBox();
            dataGridView1 = new DataGridView();
            btnAGREGAR = new Button();
            btnEDITAR = new Button();
            btnELIMINAR = new Button();
            label9 = new Label();
            tbxBUSCAR = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(407, 9);
            label1.Name = "label1";
            label1.Size = new Size(403, 37);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Registro de Cursos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 54);
            label2.Name = "label2";
            label2.Size = new Size(35, 21);
            label2.TabIndex = 1;
            label2.Text = "ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 90);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombres :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 133);
            label4.Name = "label4";
            label4.Size = new Size(147, 21);
            label4.TabIndex = 3;
            label4.Text = "Apellido Paterno :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(-1, 184);
            label5.Name = "label5";
            label5.Size = new Size(152, 21);
            label5.TabIndex = 4;
            label5.Text = "Apellido Materno :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(4, 242);
            label6.Name = "label6";
            label6.Size = new Size(49, 21);
            label6.TabIndex = 5;
            label6.Text = "RUT :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(4, 297);
            label7.Name = "label7";
            label7.Size = new Size(115, 21);
            label7.TabIndex = 6;
            label7.Text = "Nº Matricula :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(4, 347);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 7;
            label8.Text = "Curso :";
            // 
            // tbxID
            // 
            tbxID.Location = new Point(157, 52);
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(187, 23);
            tbxID.TabIndex = 8;
            // 
            // tbxNOMBRES
            // 
            tbxNOMBRES.Location = new Point(157, 88);
            tbxNOMBRES.Name = "tbxNOMBRES";
            tbxNOMBRES.Size = new Size(187, 23);
            tbxNOMBRES.TabIndex = 9;
            // 
            // tbxAPELLIDOPAT
            // 
            tbxAPELLIDOPAT.Location = new Point(157, 131);
            tbxAPELLIDOPAT.Name = "tbxAPELLIDOPAT";
            tbxAPELLIDOPAT.Size = new Size(187, 23);
            tbxAPELLIDOPAT.TabIndex = 10;
            // 
            // tbxAPELLIDOMAT
            // 
            tbxAPELLIDOMAT.Location = new Point(157, 182);
            tbxAPELLIDOMAT.Name = "tbxAPELLIDOMAT";
            tbxAPELLIDOMAT.Size = new Size(187, 23);
            tbxAPELLIDOMAT.TabIndex = 11;
            // 
            // tbxRUT
            // 
            tbxRUT.Location = new Point(157, 240);
            tbxRUT.Name = "tbxRUT";
            tbxRUT.Size = new Size(187, 23);
            tbxRUT.TabIndex = 12;
            // 
            // tbxNMATRICULA
            // 
            tbxNMATRICULA.Location = new Point(157, 295);
            tbxNMATRICULA.Name = "tbxNMATRICULA";
            tbxNMATRICULA.Size = new Size(187, 23);
            tbxNMATRICULA.TabIndex = 13;
            // 
            // tbxCURSO
            // 
            tbxCURSO.Location = new Point(157, 347);
            tbxCURSO.Name = "tbxCURSO";
            tbxCURSO.Size = new Size(187, 23);
            tbxCURSO.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonShadow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(406, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(807, 126);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnAGREGAR
            // 
            btnAGREGAR.BackColor = Color.Lime;
            btnAGREGAR.Location = new Point(454, 220);
            btnAGREGAR.Name = "btnAGREGAR";
            btnAGREGAR.Size = new Size(168, 50);
            btnAGREGAR.TabIndex = 16;
            btnAGREGAR.Text = "AGREGAR";
            btnAGREGAR.UseVisualStyleBackColor = false;
            btnAGREGAR.Click += btnAGREGAR_Click;
            // 
            // btnEDITAR
            // 
            btnEDITAR.BackColor = SystemColors.HotTrack;
            btnEDITAR.ForeColor = SystemColors.ButtonHighlight;
            btnEDITAR.Location = new Point(687, 220);
            btnEDITAR.Name = "btnEDITAR";
            btnEDITAR.Size = new Size(168, 50);
            btnEDITAR.TabIndex = 17;
            btnEDITAR.Text = "EDITAR";
            btnEDITAR.UseVisualStyleBackColor = false;
            btnEDITAR.Click += btnEDITAR_Click;
            // 
            // btnELIMINAR
            // 
            btnELIMINAR.BackColor = Color.Red;
            btnELIMINAR.ForeColor = SystemColors.ButtonHighlight;
            btnELIMINAR.Location = new Point(924, 220);
            btnELIMINAR.Name = "btnELIMINAR";
            btnELIMINAR.Size = new Size(168, 50);
            btnELIMINAR.TabIndex = 18;
            btnELIMINAR.Text = "ELIMINAR";
            btnELIMINAR.UseVisualStyleBackColor = false;
            btnELIMINAR.Click += btnELIMINAR_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(391, 307);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 19;
            label9.Text = "Buscar :";
            // 
            // tbxBUSCAR
            // 
            tbxBUSCAR.Location = new Point(476, 307);
            tbxBUSCAR.Name = "tbxBUSCAR";
            tbxBUSCAR.Size = new Size(653, 23);
            tbxBUSCAR.TabIndex = 20;
            tbxBUSCAR.TextChanged += tbxBUSCAR_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(476, 411);
            label10.Name = "label10";
            label10.Size = new Size(310, 30);
            label10.TabIndex = 21;
            label10.Text = "Jorge Pablo Andres Vidal Millar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1377, 450);
            Controls.Add(label10);
            Controls.Add(tbxBUSCAR);
            Controls.Add(label9);
            Controls.Add(btnELIMINAR);
            Controls.Add(btnEDITAR);
            Controls.Add(btnAGREGAR);
            Controls.Add(dataGridView1);
            Controls.Add(tbxCURSO);
            Controls.Add(tbxNMATRICULA);
            Controls.Add(tbxRUT);
            Controls.Add(tbxAPELLIDOMAT);
            Controls.Add(tbxAPELLIDOPAT);
            Controls.Add(tbxNOMBRES);
            Controls.Add(tbxID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbxID;
        private TextBox tbxNOMBRES;
        private TextBox tbxAPELLIDOPAT;
        private TextBox tbxAPELLIDOMAT;
        private TextBox tbxRUT;
        private TextBox tbxNMATRICULA;
        private TextBox tbxCURSO;
        private DataGridView dataGridView1;
        private Button btnAGREGAR;
        private Button btnEDITAR;
        private Button btnELIMINAR;
        private Label label9;
        private TextBox tbxBUSCAR;
        private Label label10;
    }
}
