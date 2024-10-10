using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void fillTextBox(int x);
        string textvalue = "";
        public void FillMathNote(int ExamNote)
        {
            textvalue += "Your Math Note is : "+ ExamNote+Environment.NewLine;
        }
        public void FillChemistryNote(int ExamNote)
        {
            textvalue += "Your Chemistry Note is: " + ExamNote + Environment.NewLine;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ShowinTextBox()
        {
            textBox1.Text = textvalue;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fillTextBox filltext = new fillTextBox (FillMathNote);
            filltext += FillChemistryNote;
            filltext(80);
            ShowinTextBox();
        }
    }
}
