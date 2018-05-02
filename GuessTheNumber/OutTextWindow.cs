using System;
using System.Windows.Forms;

namespace kz.tsnproff.GuessTheNumber
{
    class OutTextWindow : IOutText
    {
        public void outMessage(String text, String caption)
        {

            MessageBox.Show(text, caption);
        }

        public void outMessage(String text)
        {
        }

    }
}
