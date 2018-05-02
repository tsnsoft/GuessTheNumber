using System;
using System.Windows.Forms;

namespace kz.tsnproff.GuessTheNumber
{
    public partial class LauncherGUI : Form
    {
        public LauncherGUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            int min = (int)numericUpDownMin.Value;
            int max = (int)numericUpDownMax.Value;
            if (min > max)
            {
                MessageBox.Show("Неправильно указан диапазон!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IOutText outText = new OutTextWindow();
            IInquiryNumber inquiryNumber = new InquiryNumberWindow();
            Engine engine = new Engine(outText, inquiryNumber);
            int number = engine.defineHiddenNumber(min, max);
            outText.outMessage("Ваше загаданное число: " + number, "Результат");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LauncherGUI_Load(object sender, EventArgs e)
        {

        }

        private void LauncherGUI_Shown(object sender, EventArgs e)
        {
            
        }

    }

}
