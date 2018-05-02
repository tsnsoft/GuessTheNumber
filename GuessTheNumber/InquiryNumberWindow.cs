using System;
using System.Windows.Forms;

namespace kz.tsnproff.GuessTheNumber
{
    class InquiryNumberWindow : IInquiryNumber
    {

        public bool isHigherQuery(int number, int hiddenNumber)
        {
            return hiddenNumber > number;
        }

        public bool isHigherQuery(int number)
        {
            string message = String.Format("Ваше загаданное число больше {0} [Yes / No] ?\n (если равно {1}, то ответ не больше - [No])", number, number);
            string caption = "Ответьте на вопрос";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    return true;
                case DialogResult.No:
                    return false;
            }
            return false;
        }

    }
}
