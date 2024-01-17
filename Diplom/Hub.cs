using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class HubForm : Form
    {
        private string введенноеИмя;
        public HubForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public HubForm(string имя) : this()
        {
            введенноеИмя = имя;
        }

        private void Hub_Load(object sender, EventArgs e)
        {
            NameLabel.Text = $"Студент: {введенноеИмя}.";
        }

        private void Zadanie1Btn_Click(object sender, EventArgs e)
        {
            ScrollTextForm Zadanie1 = new ScrollTextForm();
            Zadanie1.Show();
        }

        private void Zadanie4Btn_Click(object sender, EventArgs e)
        {
            TestForm Zadanie4 = new TestForm();
            Zadanie4.Show();
        }

        private void Zadanie2Btn_Click(object sender, EventArgs e)
        {
            OpisanieSxemForm Zadanie2 = new OpisanieSxemForm();
            Zadanie2.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть приложение?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void ZametkiBtn_Click(object sender, EventArgs e)
        {
            Zametki Zametki1 = new Zametki();
            Zametki1.Show();
        }
    }
}
