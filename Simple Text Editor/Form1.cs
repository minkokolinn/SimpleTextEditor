using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Simple_Text_Editor
{
    public partial class Form1 : Form
    {
        private string strpath;
        private string filename;
        RichTextBox selectedRichTextBox;
        public Font defaultFont = new Font("Calibri",16f);
        private Boolean saveStatus = false;
        string keyInput;

        Theme tm = new Theme();
        

        simpletextdatasetTableAdapters.keyword_tblTableAdapter objadapter = 
            new simpletextdatasetTableAdapters.keyword_tblTableAdapter();
        DataTable dtb = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr=MessageBox.Show("Are you sure you want to exit?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Newpage();
            
        }

        public void keyPressHandler(object sender, KeyPressEventArgs e)
        {
            saveStatus = false;
            keyInput = e.KeyChar.ToString();
            //if ()
            //{
                
            //}
            if (tbMainControl.SelectedTab.Text != ("New Page" + (tbMainControl.SelectedIndex + 1)))
            {
                keyword_highlight();
            }

        }

        public void mouseClickHandler(object sender, MouseEventArgs e)
        {
            bracketMatching();
        }

        public void bracketMatching()
        {
            selectedRichTextBox = (RichTextBox)tbMainControl
                .SelectedTab.Controls["New Page" + (tbMainControl.SelectedIndex + 1)];
            keyword_highlight();
            int insertionPoint = selectedRichTextBox.SelectionStart;
            selectedRichTextBox.SelectionLength = 0;

            if (selectedRichTextBox.Find("{",insertionPoint,
                insertionPoint+1,RichTextBoxFinds.MatchCase)==insertionPoint)
            {
                selectedRichTextBox.SelectionColor = Color.Blue;
                while (insertionPoint<=selectedRichTextBox.TextLength)
                {
                    selectedRichTextBox.Find("}", insertionPoint,
                        selectedRichTextBox.TextLength, RichTextBoxFinds.MatchCase);
                    selectedRichTextBox.SelectionBackColor = Color.Blue;
                    break;
                }
            }
            else if (selectedRichTextBox.Find("[", insertionPoint,
               insertionPoint + 1, RichTextBoxFinds.MatchCase) == insertionPoint)
            {
                selectedRichTextBox.SelectionColor = Color.Blue;
                while (insertionPoint <= selectedRichTextBox.TextLength)
                {
                    selectedRichTextBox.Find("]", insertionPoint,
                        selectedRichTextBox.TextLength, RichTextBoxFinds.MatchCase);
                    selectedRichTextBox.SelectionBackColor = Color.Blue;
                    break;
                }
            }
            else if (selectedRichTextBox.Find("(", insertionPoint,
               insertionPoint + 1, RichTextBoxFinds.MatchCase) == insertionPoint)
            {
                selectedRichTextBox.SelectionColor = Color.Blue;
                while (insertionPoint <= selectedRichTextBox.TextLength)
                {
                    selectedRichTextBox.Find(")", insertionPoint,
                        selectedRichTextBox.TextLength, RichTextBoxFinds.MatchCase);
                    selectedRichTextBox.SelectionBackColor = Color.Blue;
                    break;
                }
            }
            //ta char bracket tay htae yan
        }

        public void keyword_highlight()
        {
            int start = 0;
            if (tbMainControl.SelectedTab.Controls.ContainsKey("New Page" + (tbMainControl.SelectedIndex + 1)))
            {
                selectedRichTextBox = (RichTextBox)tbMainControl.
                    SelectedTab.Controls["New Page" + (tbMainControl.SelectedIndex + 1)];

                //dtb = objadapter.GetData();
                int count = dtb.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    string key = dtb.Rows[i]["KeyWordName"].ToString();
                    int end = selectedRichTextBox.Text.LastIndexOf(key);
                    int CursorPosition = selectedRichTextBox.SelectionStart;
                    while (start <= end)
                    {
                        string color = dtb.Rows[i]["Color"].ToString();
                        selectedRichTextBox.Find(key, start, selectedRichTextBox.TextLength, RichTextBoxFinds.MatchCase);
                        selectedRichTextBox.SelectionColor = Color.FromName(color);
                        selectedRichTextBox.SelectionLength = 0;
                        selectedRichTextBox.SelectionStart = CursorPosition;
                        selectedRichTextBox.SelectionColor = Color.White;
                        start = selectedRichTextBox.Text.IndexOf(key, start) + 1;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (saveStatus == false  && tbMainControl.SelectedTab.Text != ("New Page" + (tbMainControl.SelectedIndex+1)))
            {
                DialogResult dr=MessageBox.Show("Do u want to save this file?","Save Changes?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr==DialogResult.Yes)
                {
                    try
                    {
                        FileStream fs = new FileStream(tbMainControl.SelectedTab.Text, FileMode.Truncate, FileAccess.ReadWrite);
                        StreamWriter sw = new StreamWriter(fs);

                        if (tbMainControl.SelectedTab.Controls.ContainsKey("New Page" + (tbMainControl.SelectedIndex + 1)))
                        {
                            selectedRichTextBox = (RichTextBox)tbMainControl.SelectedTab.Controls["New Page" + (tbMainControl.SelectedIndex + 1)];
                            sw.WriteLine(selectedRichTextBox.Text+"\n");
                        }

                        sw.Close();
                        MessageBox.Show("Save Successful", "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        saveStatus = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Something wrong in file processing", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        tbMainControl.TabPages.RemoveAt(tbMainControl.SelectedIndex);
                    }
                }
                else
                {
                    tbMainControl.TabPages.RemoveAt(tbMainControl.SelectedIndex);
                }
            }
            else
            {
                tbMainControl.TabPages.RemoveAt(tbMainControl.SelectedIndex);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbMainControl.SelectedTab.Text !=("New Page"+(tbMainControl.SelectedIndex + 1)))
            {
                try
                {
                    FileStream fs = new FileStream(tbMainControl.SelectedTab.Text, FileMode.Truncate, FileAccess.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs);

                    if (tbMainControl.SelectedTab.Controls.ContainsKey("New Page" + (tbMainControl.SelectedIndex + 1)))
                    {
                        selectedRichTextBox = (RichTextBox)tbMainControl.SelectedTab.Controls["New Page" + (tbMainControl.SelectedIndex + 1)];
                        sw.WriteLine(selectedRichTextBox.Text+"\n");
                    }
                    sw.Close();
                    MessageBox.Show("Save Successful", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    saveStatus = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Something wrong in file processing", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (tbMainControl.SelectedIndex > -1)
                {
                    save();
                }
            }
        }

        private void save()
        {
            if (tbMainControl.SelectedIndex>-1)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    tbMainControl.SelectedTab.Name = sfd.FileName;
                    try
                    {
                        FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
                        StreamWriter sw = new StreamWriter(fs);

                        if (tbMainControl.SelectedTab.Controls.ContainsKey("New Page" + (tbMainControl.SelectedIndex + 1)))
                        {
                            selectedRichTextBox = (RichTextBox)tbMainControl.SelectedTab.Controls["New Page" + (tbMainControl.SelectedIndex + 1)];
                            sw.WriteLine(selectedRichTextBox.Text);
                        }

                        sw.Close();
                        MessageBox.Show("Save Successful", "Innformation", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        saveStatus = true;

                        strpath = sfd.FileName;
                        tbMainControl.SelectedTab.Text = strpath;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something wrong in file processing", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        private void btnnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                TabPage tb = new TabPage();
                tb.Text = ofd.FileName;
                tb.Name = ofd.FileName;

                RichTextBox txtbox = new RichTextBox();
                txtbox.BackColor = Color.Black;
                txtbox.ForeColor = Color.White; 

                txtbox.Width = tbMainControl.Width;
                txtbox.Height = tbMainControl.Height;
                txtbox.Font = defaultFont;

                tb.Controls.Add(txtbox);
                tbMainControl.TabPages.Add(tb);
                txtbox.Name = "New Page" + tbMainControl.TabPages.Count;

                txtbox.Focus();
                txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressHandler);
                txtbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClickHandler);
                txtbox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keyDownHandler);
                tbMainControl.SelectTab(tb.Name);

                try
                {
                    FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.ReadWrite);
                    StreamReader sr = new StreamReader(fs);
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        txtbox.Text += line + "\n";
                        line = sr.ReadLine();
                    }
                    sr.Close();
                    keyword_highlight();
                }
                catch (Exception)
                {
                     MessageBox.Show("Save Successful", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Newpage();
        }




        public void Newpage()
        {
            TabPage tb = new TabPage();
            tb.Text = "New Page" + (tbMainControl.TabPages.Count + 1);
            tb.Name = "New Page" + (tbMainControl.TabPages.Count + 1);
            RichTextBox rtb = new RichTextBox();

            tb.Controls.Add(rtb);
            rtb.BackColor = Color.Black;
            rtb.ForeColor = Color.White; 
            rtb.Width = tbMainControl.Width;
            rtb.Height = tbMainControl.Height;
            rtb.Font = defaultFont;

            tbMainControl.Controls.Add(tb);
            tbMainControl.SelectTab(tb.Name);
            rtb.Name = "New Page" + (tbMainControl.TabPages.Count);

            rtb.Focus();
            rtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressHandler);
            rtb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClickHandler);
            rtb.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keyDownHandler);
            tbMainControl.SelectTab(tb.Name);
        }

        private void btnSaveas_Click(object sender, EventArgs e)
        {
            save();   
        }

        private void findReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Findandreplace fp = new Findandreplace();
            fp.Show();
            fp.join(selectedRichTextBox, tbMainControl);
        }

        private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Findandreplace fr = new Findandreplace();
            fr.setThemeName("Light");
            tm.get_theme = "Light";
            if (tbMainControl.TabPages.Count > 0)
            {
                if (tbMainControl.SelectedTab.Controls.ContainsKey
                        ("New Page" + (tbMainControl.SelectedIndex + 1)))
                {
                    selectedRichTextBox = (RichTextBox)tbMainControl
                                .SelectedTab.Controls["New Page" + (tbMainControl.SelectedIndex + 1)];
                    selectedRichTextBox.BackColor = Color.DarkGray;
                    selectedRichTextBox.ForeColor = Color.Black;
                }
                keyword_highlight();
            }
            
        }

        private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Findandreplace fr = new Findandreplace();
            fr.setThemeName("Dark");
            tm.get_theme = "Dark";
            if (tbMainControl.TabPages.Count > 0)
            {
                if (tbMainControl.SelectedTab.Controls.ContainsKey
                        ("New Page" + (tbMainControl.SelectedIndex + 1)))
                {
                    selectedRichTextBox = (RichTextBox)tbMainControl
                                .SelectedTab.Controls["New Page" + (tbMainControl.SelectedIndex + 1)];
                    selectedRichTextBox.BackColor = Color.Black;
                    selectedRichTextBox.ForeColor = Color.White;
                }
                keyword_highlight();
            }
        }

        public void keyDownHandler(object sender, PreviewKeyDownEventArgs e)
        {
            if (keyInput == "{")
            {
                if (e.KeyData == Keys.Tab)
                {
                    selectedRichTextBox = (RichTextBox)tbMainControl
                .SelectedTab.Controls["New Page" + (tbMainControl.SelectedIndex + 1)];

                    int start = selectedRichTextBox.SelectionStart;

                    selectedRichTextBox.Text = selectedRichTextBox.Text.Insert(start, "\n\n}");
                    selectedRichTextBox.SelectionStart = start + 1;
                    selectedRichTextBox.ForeColor = Color.LightGray;

                    if (tm.get_theme == "Light")
                    {
                        selectedRichTextBox.ForeColor = Color.Black;
                    }
                    else if (tm.get_theme == "Dark")
                    {
                        selectedRichTextBox.ForeColor = Color.White;
                    }
                    keyword_highlight();
                }
                keyInput = "";
            }
        }


        public void ItalicSelectedText(RichTextBox control2)
        {
            if (tbMainControl.SelectedIndex > -1)
            {
                if (control2.Text.ToString() == "")
                {
                    MessageBox.Show("There is no word!!");
                }
                else if (control2.SelectedText.ToString() == "")
                {
                    MessageBox.Show("Please selection your text");
                }
                else
                {
                    control2.SelectionFont = new Font(control2.Font.FontFamily, control2.Font.Size, FontStyle.Italic);
                }
            }
            else
            {
                MessageBox.Show("There is no page to do instructions!!!");
            }
            

        }

        public void BoldSelectedText(RichTextBox control)
        {
            if (tbMainControl.SelectedIndex>-1)
            {
                if (control.SelectedText.ToString() == "")
                {
                    MessageBox.Show("Please selection your text");
                }
                else if (control.Text.ToString() == "")
                {
                    MessageBox.Show("There is no word!!");
                }
                else
                {
                    control.SelectionFont = new Font(control.Font.FontFamily, control.Font.Size, FontStyle.Bold);
                }
            }
            else
            {
                MessageBox.Show("There is no page to do instructions!!!");
            }

        }

        public void UnderlineSelectedText(RichTextBox control3)
        {
            if (tbMainControl.SelectedIndex > -1)
            {
                if (control3.SelectedText.ToString() == "")
                {
                    MessageBox.Show("Please selection your text");
                }
                else if (control3.Text.ToString() == "")
                {
                    MessageBox.Show("There is no word!!");
                }
                else
                {
                    control3.SelectionFont = new Font(control3.Font.FontFamily, control3.Font.Size, FontStyle.Underline);
                }
            }
            else
            {
                MessageBox.Show("There is no page to do instructions!!!");
            }

        }

        public void normalSelectedText(RichTextBox control3)
        {
            if (tbMainControl.SelectedIndex > -1)
            {
                if (control3.SelectedText.ToString() == "")
                {
                    MessageBox.Show("Please selection your text");
                }
                else if (control3.Text.ToString() == "")
                {
                    MessageBox.Show("There is no word!!");
                }
                else
                {
                    control3.SelectionFont = new Font(control3.Font.FontFamily, control3.Font.Size, FontStyle.Regular);
                }
            }
            else
            {
                MessageBox.Show("There is no page to do instructions!!!");
            }

        }

       
        private void btnitalic_Click(object sender, EventArgs e)
        {
            ItalicSelectedText(selectedRichTextBox);
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            BoldSelectedText(selectedRichTextBox);
        }

        private void btnunderline_Click(object sender, EventArgs e)
        {
            UnderlineSelectedText(selectedRichTextBox);
        }

        private void btnnormal_Click(object sender, EventArgs e)
        {
            normalSelectedText(selectedRichTextBox);
        }



        

        

    }
}
