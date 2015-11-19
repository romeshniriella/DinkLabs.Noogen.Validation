#region Copyright © 2005 Noogen Technologies Inc.
// Author:
//	Tommy Noogen (tom@noogen.net)
//
// (C) 2005 Noogen Technologies Inc. (http://www.noogen.net)
// 
// MIT X.11 LICENSE
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ValidationProviderDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class DemoForm : System.Windows.Forms.Form
	{
		private Noogen.Validation.ValidationProvider validationProvider1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button ValidateButton;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label7;
		private System.ComponentModel.IContainer components;

		public DemoForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			Noogen.Validation.ValidationRule vr = new Noogen.Validation.ValidationRule();
			vr.CustomValidationMethod +=new Noogen.Validation.CustomValidationEventHandler(vr_CustomValidationMethod);
			this.validationProvider1.SetValidationRule(this.textBox6, vr);

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DemoForm));
			Noogen.Validation.ValidationRule validationRule1 = new Noogen.Validation.ValidationRule();
			Noogen.Validation.ValidationRule validationRule2 = new Noogen.Validation.ValidationRule();
			Noogen.Validation.ValidationRule validationRule3 = new Noogen.Validation.ValidationRule();
			Noogen.Validation.ValidationRule validationRule4 = new Noogen.Validation.ValidationRule();
			Noogen.Validation.ValidationRule validationRule5 = new Noogen.Validation.ValidationRule();
			Noogen.Validation.ValidationRule validationRule6 = new Noogen.Validation.ValidationRule();
			this.validationProvider1 = new Noogen.Validation.ValidationProvider(this.components);
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.ValidateButton = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// validationProvider1
			// 
			this.validationProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
			this.validationProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("validationProvider1.Icon")));
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
														   "a",
														   "b",
														   "c",
														   "d",
														   "e",
														   "f",
														   "g"});
			this.comboBox1.Location = new System.Drawing.Point(256, 48);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(104, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.Text = "[Choose]";
			validationRule1.ErrorMessage = "Please choose a value.";
			validationRule1.InitialValue = "[Choose]";
			validationRule1.IsRequired = true;
			this.validationProvider1.SetValidationRule(this.comboBox1, validationRule1);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(256, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			validationRule2.ErrorMessage = "%ControlName% cannot be empty.";
			validationRule2.IsRequired = true;
			this.validationProvider1.SetValidationRule(this.textBox1, validationRule2);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(256, 80);
			this.textBox2.Name = "textBox2";
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "textBox2";
			validationRule3.ErrorMessage = "%ControlName% cannot be equal to \"textBox2\".";
			validationRule3.Operator = Noogen.Validation.ValidationCompareOperator.NotEqual;
			validationRule3.ValueToCompare = "textBox2";
			this.validationProvider1.SetValidationRule(this.textBox2, validationRule3);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(256, 104);
			this.textBox3.Name = "textBox3";
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "textBox3";
			validationRule4.DataType = Noogen.Validation.ValidationDataType.Double;
			validationRule4.ErrorMessage = "%ControlName% is not between 1 and 10.";
			validationRule4.MaximumValue = "10";
			validationRule4.MinimumValue = "1";
			this.validationProvider1.SetValidationRule(this.textBox3, validationRule4);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(256, 144);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(104, 20);
			this.textBox4.TabIndex = 8;
			this.textBox4.Text = "textBox4";
			validationRule5.ErrorMessage = "%ControlName% must be 7 characters long.";
			validationRule5.RegExPattern = "^\\S{7}$";
			this.validationProvider1.SetValidationRule(this.textBox4, validationRule5);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(144, 176);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(216, 20);
			this.textBox5.TabIndex = 10;
			this.textBox5.Text = "textBox5";
			validationRule6.ErrorMessage = "%ControlName% is not a valid email address, mailbox@domain";
			validationRule6.RegExPattern = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9}" +
				")$";
			this.validationProvider1.SetValidationRule(this.textBox5, validationRule6);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Required Validation: Not Empty";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(216, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Compare Validation: Not Equal textBox2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(184, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Validate Range: Between 1 and 10";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(224, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Required Validation: Not [Choose]";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(184, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Regular Expression: Text Length=7";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 32);
			this.label6.TabIndex = 11;
			this.label6.Text = "Regular Expression: Email Addy";
			// 
			// ValidateButton
			// 
			this.ValidateButton.Location = new System.Drawing.Point(280, 216);
			this.ValidateButton.Name = "ValidateButton";
			this.ValidateButton.TabIndex = 12;
			this.ValidateButton.Text = "Validate";
			this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(136, 216);
			this.textBox6.Name = "textBox6";
			this.textBox6.TabIndex = 13;
			this.textBox6.Text = "textBox6";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 216);
			this.label7.Name = "label7";
			this.label7.TabIndex = 14;
			this.label7.Text = "Custom Validation:";
			// 
			// DemoForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(392, 254);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.ValidateButton);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DemoForm";
			this.Text = "Noogen ValidationProvider Demo";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new DemoForm());
		}

		private void ValidateButton_Click(object sender, System.EventArgs e)
		{
			this.validationProvider1.ValidationMessages(!this.validationProvider1.Validate());
		}

		private void vr_CustomValidationMethod(object sender, Noogen.Validation.CustomValidationEventArgs e)
		{
			e.IsValid = e.Value.ToString().Equals("abc") || e.Value.ToString().Equals("123") ;
			e.ErrorMessage = "%ControlName% is not in ('abc', '123').";
		}
	}
}
