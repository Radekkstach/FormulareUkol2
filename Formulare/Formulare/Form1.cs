using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 fm = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
        //    Form form2 = new Form();


        //    //form 2 textbox
        //    TextBox textBox = new TextBox();
        //    textBox.Location = new Point(10, 20);
        //    textBox.Text = "Vlozte text";
        //    textBox.Size = new Size(100, 100);
        //    textBox.Multiline = true;
        //    form2.Controls.Add(textBox);


        //    // form2 tlacitko OK
        //    Button buttonOK = new Button();
        //    buttonOK.Location = new Point(120, 10);
        //    buttonOK.Text = "OK";
        //    buttonOK.UseVisualStyleBackColor = true;
        //    buttonOK.Size = new Size(30, 30);
        //    buttonOK.DialogResult = DialogResult.OK;
        //    form2.Controls.Add(buttonOK);

        //    //form 2 tlacitko CANCEL
        //    Button buttonCancel = new Button();
        //    buttonCancel.Location = new Point(160, 10);
        //    buttonCancel.Text = "Cancel";
        //    buttonCancel.UseVisualStyleBackColor = true;
        //    buttonCancel.Size = new Size(80, 30);
        //    buttonCancel.DialogResult = DialogResult.Cancel;
        //    form2.Controls.Add(buttonCancel);


        //    form2.ShowDialog();
            
            int sirka = (int)numericUpDown1.Value;
            int vyska = (int)numericUpDown2.Value;
            fm.Size = new Size(sirka, vyska);

            if(checkBox1.Checked == true)
            {
                fm.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                fm.FormBorderStyle = FormBorderStyle.Sizable;
            }


            fm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                fm.BackColor = colorDialog.Color;

            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
                fm.Font = fontDialog.Font;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                checkBox1.Text = "Měnit velikost - Zakázáno";
            else
                checkBox1.Text = "Měnit velikost - Povoleno";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
