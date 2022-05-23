using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    internal class Infomation
    {
        public void Info()
        {
                    MessageBox.Show(
                    "Подумай что ты делаешь! Ты же не дурак", "Ошибка", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
        }
        public void InfoDel()
        {
            MessageBox.Show(
            "Ооо боже, не дели на ноль, \n а то я тебя на ноль поделю!", "Грубая ошибка",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
        }

    }
}
