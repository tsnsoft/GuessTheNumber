using System;

namespace kz.tsnproff.GuessTheNumber
{
    class Engine
    {
        private IOutText outText;
        private IInquiryNumber inquiryNumber;

        public Engine(IOutText outText, IInquiryNumber inquiryNumber)
        {
            this.outText = outText;
            this.inquiryNumber = inquiryNumber;
        }

        public int defineHiddenNumber(int rangeMin, int rangeMax)
        {
            return define(rangeMin, rangeMax, inquiryNumber);
        }

        public int defineHiddenNumber(int rangeMin, int rangeMax, int hiddenNumberTest)
        {
            return define(rangeMin, rangeMax, new InquiryNumberTest(hiddenNumberTest));
        }

        private int define(int rangeMin, int rangeMax, IInquiryNumber inquiryNumber)
        {
            while (true)
            {
                outText.outMessage(String.Format("Предполагаю что число в диапазоне [{0}-{1}], ", rangeMin, rangeMax));
                if (rangeMax == rangeMin)
                    return rangeMin;
                int rangeMiddle = rangeMin + (rangeMax - rangeMin) / 2;
                if (inquiryNumber.isHigherQuery(rangeMiddle))
                    rangeMin = rangeMiddle + 1;
                else
                {
                    if ((rangeMax == (rangeMin)))
                        return rangeMiddle;
                    rangeMax = rangeMiddle;
                }

            }
        }

    }
}
