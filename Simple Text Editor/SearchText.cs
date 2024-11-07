using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Text_Editor
{
    class SearchText
    {
        private string Find_Input, Replace_Input;
        

        public string Replace_Encapsule
        {
            get
            {
                return Replace_Input;
            }
            set
            {
                Replace_Input = value;
            }
        }
        public string Find_Encapsule
        {
            get
            {
                return Find_Input;
            }
            set
            {
                Find_Input = value;
            }
        }
        public void find(RichTextBox rtb, TabControl TabsControl)
        {
            if (TabsControl.SelectedTab.Controls.ContainsKey("New Page"+(TabsControl.SelectedIndex+1)))
            {
                rtb = (RichTextBox)TabsControl.SelectedTab.Controls["New Page"+(TabsControl.SelectedIndex+1)];
                End_Encapsule = rtb.Text.LastIndexOf(Find_Encapsule);
                while (Start_Encapsule<=End_Encapsule)
                {
                    rtb.Find(Find_Encapsule, Start_Encapsule, rtb.TextLength, RichTextBoxFinds.MatchCase);
                    rtb.SelectionColor = System.Drawing.Color.Violet;
                    Start_Encapsule = rtb.Text.IndexOf(Find_Encapsule)+1;
                }
            }
        }

        private int start, end;

        public int End_Encapsule
        {
            get
            {
                return end;
            }
            set
            {
                end = value;
            }
        }
        public int Start_Encapsule
        {
            get
            {
                return start;
            }
            set
            {
                start = value;
            }
        }

        public void replace(RichTextBox rtb,TabControl TabsControl,string theme)
        {
            if (TabsControl.SelectedTab.Controls.ContainsKey("New Page" + (TabsControl.SelectedIndex + 1)))
            {
                rtb = (RichTextBox)TabsControl.SelectedTab.Controls["New Page" + (TabsControl.SelectedIndex + 1)];
                rtb.Text = rtb.Text.Replace(Find_Encapsule,Replace_Encapsule);
                rtb.ForeColor = System.Drawing.Color.LightGray;

                if (theme == "Light")
                {
                    rtb.ForeColor = System.Drawing.Color.Black;
                }
                else if (theme == "Dark")
                {
                    rtb.ForeColor = System.Drawing.Color.White;
                }
            }
        }
    }
}
