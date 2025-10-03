using System;
using System.Threading;
using System.Windows.Forms;

namespace TestTaskProject
{
    public partial class FormStart : Form
    {
        Thread thread;
        public FormStart()
        {
            InitializeComponent();
        }

        private void ButtonListEmployers_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenFormListEmployers);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenFormListEmployers(object obj)
        {
            Application.Run(new FormListEmployers());
        }

        private void ButtonStaticInfo_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenFormStaticInfo);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenFormStaticInfo(object obj)
        {
            Application.Run(new FormStaticInfo());
        }
    }
}
