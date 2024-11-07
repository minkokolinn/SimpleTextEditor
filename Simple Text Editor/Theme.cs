using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Text_Editor
{
    class Theme
    {
        string theme;
        public string get_theme
        {
            get { return theme; }
            set { theme = value; }
        }

        string backcolor;
        public string get_backcolor
        {
            get { return backcolor; }
            set { backcolor = value; }
        }

        string forecolor;
        public string get_forecolor
        {
            get { return forecolor; }
            set { forecolor = value; }
        }
    }
}
