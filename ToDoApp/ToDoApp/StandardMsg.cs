using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ToDoApp
{
    class StandardMsg
    {
        public static void MsgBox(string txt, string msgBtn, string msgIcon)
        {
            MessageBox.Show(txt, "ToDo Lists", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
