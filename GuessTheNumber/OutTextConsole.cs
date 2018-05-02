using System;

namespace kz.tsnproff.GuessTheNumber
{
    class OutTextConsole : IOutText
    {
        public void outMessage(String text)
        {
            Console.Write(text);
        }


        public void outMessage(string text, string caption)
        {
        }
    }
}
