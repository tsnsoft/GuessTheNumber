using System;

namespace kz.tsnproff.GuessTheNumber
{
    interface IOutText
    {
        void outMessage(String text);

        void outMessage(String text, String caption);
    }
}
