using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using System.Threading;

namespace DigitalInclusionApp
{
    public partial class MainForm : Form
    {
        Thread t1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            Close();
            openLearning();
        }

        private void btnExercicios_Click(object sender, EventArgs e)
        {

        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openForm(1));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        public void openForm(int i)
        {
            switch (i)
            {
                case 1:
                    Application.Run(new Learning());
                    return;
                case 2:
                    Application.Run(new Exercises());
                    return;
                case 3:
                    Application.Run(new Credits());
                    return;
            }
                
        }

    }
}
