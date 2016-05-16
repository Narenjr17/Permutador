﻿/*
 * Created by SharpDevelop.
 * User: Naren Jr
 * Date: 14/05/2016
 * Time: 10:03 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Permutador
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e){
			
		}
		void ConvertirClick(object sender, EventArgs e){
			String offset = OffsetG.Text;
			if (offset.Length<6){
				for (int i=offset.Length;i<6;i++){
					offset= "0"+ offset;
				}
			}
			string[] Bytes;
			Bytes = new string[3];
			if(offset.Length<=6){
			Bytes[0] = offset.Substring(0, 2);
			Bytes[1] = offset.Substring(2, 2);
			Bytes[2] = offset.Substring(4);
			offset = (Bytes[2]+Bytes[1]+Bytes[0]);
			
			PermutadoG.Text = offset; //Resultado
			SeparadoG.Text = (Bytes[0]+" "+Bytes[1]+" "+Bytes[2]); //Mostrar el puntero separado
			}
			if(offset.Length>6){
				MessageBox.Show("El offset contiene mas de 6 valores."); //se detiene
			}
		}
		void PermutadoGTextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e){
			String com=PermutadoG.Text,Add ="08",offset=OffsetG.Text;
			if(com.Length<6){
				MessageBox.Show("El campo esta vacio");
			}
			if(com.Length==6){
				PermutadoG.Text = (com + Add);
			}
			if(com.Length>6 && com.Length<=8){
				
				if (offset.Length<6){
				for (int i=offset.Length;i<6;i++){
					offset= "0"+ offset;
					}
				}
				string[] Bytes;
				Bytes = new string[4];
				Bytes[0] = offset.Substring(0, 2);
				Bytes[1] = offset.Substring(2, 2);
				Bytes[2] = offset.Substring(4, 2);
				Bytes[3] = offset.Substring(5);
				PermutadoG.Text = (Bytes[2]+Bytes[1]+Bytes[0]+Add);
			}
		}
		void Add09Click(object sender, EventArgs e){
			String com=PermutadoG.Text,Add ="09",offset=OffsetG.Text;
			if(com.Length<6){
				MessageBox.Show("El campo esta vacio");
			}
			if(com.Length==6){
				PermutadoG.Text = (com + Add);
			}
			if(com.Length>6 && com.Length<=8){
				if (offset.Length<6){
				for (int i=offset.Length;i<6;i++){
					offset= "0"+ offset;
					}
				}
				string[] Bytes;
				Bytes = new string[4];
				Bytes[0] = offset.Substring(0, 2);
				Bytes[1] = offset.Substring(2, 2);
				Bytes[2] = offset.Substring(4, 2);
				Bytes[3] = offset.Substring(5);
				PermutadoG.Text = (Bytes[2]+Bytes[1]+Bytes[0]+Add);
			}
		}
		void SeparadoGTextChanged(object sender, EventArgs e){
	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e){
			Clipboard.SetDataObject(PermutadoG.Text);
		}
		void PegarBClick(object sender, EventArgs e){
			 IDataObject iData = Clipboard.GetDataObject();

    // Determines whether the data is in a format you can use.
    if(iData.GetDataPresent(DataFormats.Text)) {
       // Yes it is, so display it in a text box.
       OffsetG.Text = (String)iData.GetData(DataFormats.Text);
		}
	}
}
}