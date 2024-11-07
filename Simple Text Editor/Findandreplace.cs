using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Text_Editor
{
    public partial class Findandreplace : Form
    {
        string theme_name;
        RichTextBox selectedRichTextBox;
        TabControl tabscontrol;

        SearchText ed = new SearchText();
        Form1 m = new Form1();

        public void join(RichTextBox r, TabControl t)
        {
            selectedRichTextBox = r;
            tabscontrol = t;
        }

        public Findandreplace()
        {
            InitializeComponent();
        }

        private void btnreplace_Click(object sender, EventArgs e)
        {
            
            if (txtfind.Text=="")
            {
                MessageBox.Show("Firstly, please enter a word to find in your document!!", "Hey User!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtreplace.Text=="")
            {
                MessageBox.Show("Firstly, please enter a word to replace in your document!!", "Hey User! What do u want to replace?",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ed.Find_Encapsule = txtfind.Text;
                ed.Replace_Encapsule = txtreplace.Text;
                ed.replace(selectedRichTextBox, tabscontrol,theme_name);
                //m.keyword_highlight();
            }
            
        }

        public void setThemeName(string name)
        {
            theme_name = name;
        }

        private void frmfindandreplace_Load(object sender, EventArgs e)
        {
            
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            if (txtfind.Text=="")
            {
                MessageBox.Show("Firstly, please enter a word to find in your document!!", "Hey User!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ed.Start_Encapsule = 0;
                ed.Find_Encapsule = txtfind.Text;
                ed.find(selectedRichTextBox, tabscontrol);
            }
            
            
        }
    }
}
