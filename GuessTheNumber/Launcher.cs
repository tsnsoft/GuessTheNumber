using System;

namespace kz.tsnproff.GuessTheNumber
{
    public class Launcher
    {
        public static void main()
        {
            int rangeMin = 1;
            int rangeMax = 10;
            OutTextConsole outText = new OutTextConsole();
            IInquiryNumber inquiryNumber = new InquiryNumberConsole();
            Engine engine = new Engine(outText, inquiryNumber);
            outText.outMessage(String.Format("Загадайте число от {0} до {1} включительно...\n\n", rangeMin, rangeMax));
            int number = engine.defineHiddenNumber(rangeMin, rangeMax);
            outText.outMessage("и значит нашли!\n\nВаше загаданное число: " + number);
        }

    }
}
