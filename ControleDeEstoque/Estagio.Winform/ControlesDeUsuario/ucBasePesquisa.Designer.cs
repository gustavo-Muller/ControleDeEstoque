﻿namespace Estagio.WinForm.ControlesDeUsuario
{
    partial class ucBasePesquisa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.txtPesquisa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPesquisa, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(473, 22);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPesquisa.Location = new System.Drawing.Point(0, 2);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.ReadOnly = true;
            this.txtPesquisa.Size = new System.Drawing.Size(443, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisa.Image = global::Estagio.WinForm.Properties.Resources.search_16;
            this.btnPesquisa.Location = new System.Drawing.Point(443, 0);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(30, 22);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // ucBasePesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucBasePesquisa";
            this.Size = new System.Drawing.Size(473, 22);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
    }
}
