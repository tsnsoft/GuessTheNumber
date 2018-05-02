using System;

namespace kz.tsnproff.GuessTheNumber
{
    class InquiryNumberConsole : IInquiryNumber
    {

        private IOutText outText;

        public InquiryNumberConsole()
        {
            this.outText = new OutTextConsole();
        }

        public bool isHigherQuery(int number)
        {
            outText.outMessage(String.Format("ваше загаданное число больше {0} (если равно {1}, то не больше) [y/n] ? ",
                    number, number));

            //string s = Console.ReadLine();
            //char c = s.ToCharArray().ElementAt(0);
            char c = Console.ReadKey().KeyChar; Console.WriteLine();

            return (c == 'y') || (c == 'Y') || (c == 'д') || (c == 'Д');
        }

        public bool isHigherQuery(int number, int hiddenNumber)
        {
            return hiddenNumber > number;
        }
    }
}
