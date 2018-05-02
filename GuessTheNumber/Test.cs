using System;

namespace kz.tsnproff.GuessTheNumber
{
    class Test
    {
        public static void main()
        {
            int rangeMin = 1;
            int rangeMax = 10;
            OutTextConsole outText = new OutTextConsole();
            IInquiryNumber inquiryNumber = new InquiryNumberConsole();
            Engine engine = new Engine(outText, inquiryNumber);
            outText.outMessage(String.Format("Тест алгоритма для границ [{0}-{1}]:\n", rangeMin, rangeMax));
            for (int min = rangeMin; min <= rangeMax; min++)
            {
                for (int max = min; max <= rangeMax; max++)
                {
                    for (int hiddenNumber = min; hiddenNumber <= max; hiddenNumber++)
                    {
                        outText.outMessage(
                                String.Format("\nПроверка границ [{0}-{1}] для числа {2}...\n", min, max, hiddenNumber));
                        int defineNumber = engine.defineHiddenNumber(min, max, hiddenNumber);
                        if (defineNumber != hiddenNumber)
                        {
                            outText.outMessage("Ошибка при проверке!\n");
                            Environment.Exit(-1);
                        }
                        else
                            outText.outMessage("нашли число: " + hiddenNumber + "\n");
                    }
                }
            }
            outText.outMessage("\nТест пройден успешно!\n");
        }
    }
}
