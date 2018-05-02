
namespace kz.tsnproff.GuessTheNumber
{
    class InquiryNumberTest : IInquiryNumber
    {

        private int hiddenNumber;

        public InquiryNumberTest(int hiddenNumber)
        {
            this.hiddenNumber = hiddenNumber;
        }

        public bool isHigherQuery(int number)
        {
            return hiddenNumber > number;
        }

        public bool isHigherQuery(int number, int hiddenNumber)
        {
            return hiddenNumber > number;
        }

    }
}
