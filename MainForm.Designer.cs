/*
 * Created by SharpDevelop.
 * User: Naren Jr
 * Date: 14/05/2016
 * Time: 10:03 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Permutador
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox OffsetG;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox PermutadoG;
		private System.Windows.Forms.Button add08;
		private System.Windows.Forms.Button add09;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button Convertir;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox SeparadoG;
		private System.Windows.Forms.Button PegarB;
		private System.Windows.Forms.Label label5;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.OffsetG = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.PermutadoG = new System.Windows.Forms.TextBox();
			this.add08 = new System.Windows.Forms.Button();
			this.add09 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.Convertir = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.SeparadoG = new System.Windows.Forms.TextBox();
			this.PegarB = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// OffsetG
			// 
			this.OffsetG.Location = new System.Drawing.Point(95, 58);
			this.OffsetG.Name = "OffsetG";
			this.OffsetG.Size = new System.Drawing.Size(100, 20);
			this.OffsetG.TabIndex = 0;
			this.OffsetG.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(29, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Offset: ";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(41, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(244, 39);
			this.label2.TabIndex = 2;
			this.label2.Text = "Permutador ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(29, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Permutado";
			// 
			// PermutadoG
			// 
			this.PermutadoG.Location = new System.Drawing.Point(95, 97);
			this.PermutadoG.Name = "PermutadoG";
			this.PermutadoG.ReadOnly = true;
			this.PermutadoG.Size = new System.Drawing.Size(100, 20);
			this.PermutadoG.TabIndex = 4;
			this.PermutadoG.TextChanged += new System.EventHandler(this.PermutadoGTextChanged);
			// 
			// add08
			// 
			this.add08.Location = new System.Drawing.Point(109, 192);
			this.add08.Name = "add08";
			this.add08.Size = new System.Drawing.Size(75, 23);
			this.add08.TabIndex = 5;
			this.add08.Text = "Agregar 08";
			this.add08.UseVisualStyleBackColor = true;
			this.add08.Click += new System.EventHandler(this.Button1Click);
			// 
			// add09
			// 
			this.add09.Location = new System.Drawing.Point(190, 192);
			this.add09.Name = "add09";
			this.add09.Size = new System.Drawing.Size(75, 23);
			this.add09.TabIndex = 6;
			this.add09.Text = "Agregar 09";
			this.add09.UseVisualStyleBackColor = true;
			this.add09.Click += new System.EventHandler(this.Add09Click);
			// 
			// button3
			// 
			this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button3.Location = new System.Drawing.Point(208, 94);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(57, 23);
			this.button3.TabIndex = 7;
			this.button3.Text = "Copiar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// Convertir
			// 
			this.Convertir.Location = new System.Drawing.Point(28, 192);
			this.Convertir.Name = "Convertir";
			this.Convertir.Size = new System.Drawing.Size(75, 23);
			this.Convertir.TabIndex = 8;
			this.Convertir.Text = "Convertir";
			this.Convertir.UseVisualStyleBackColor = true;
			this.Convertir.Click += new System.EventHandler(this.ConvertirClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(29, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Separado";
			// 
			// SeparadoG
			// 
			this.SeparadoG.Location = new System.Drawing.Point(95, 140);
			this.SeparadoG.Name = "SeparadoG";
			this.SeparadoG.ReadOnly = true;
			this.SeparadoG.Size = new System.Drawing.Size(100, 20);
			this.SeparadoG.TabIndex = 10;
			this.SeparadoG.TextChanged += new System.EventHandler(this.SeparadoGTextChanged);
			// 
			// PegarB
			// 
			this.PegarB.Location = new System.Drawing.Point(208, 54);
			this.PegarB.Name = "PegarB";
			this.PegarB.Size = new System.Drawing.Size(57, 23);
			this.PegarB.TabIndex = 11;
			this.PegarB.Text = "Pegar";
			this.PegarB.UseVisualStyleBackColor = true;
			this.PegarB.Click += new System.EventHandler(this.PegarBClick);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(221, 229);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 16);
			this.label5.TabIndex = 12;
			this.label5.Text = "Naren Jr. 2016";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 248);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.PegarB);
			this.Controls.Add(this.SeparadoG);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Convertir);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.add09);
			this.Controls.Add(this.add08);
			this.Controls.Add(this.PermutadoG);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OffsetG);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Permutador";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
