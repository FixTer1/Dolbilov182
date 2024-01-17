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
    public partial class LoginForm : Form
    {
        private bool ПроверкаЛогина(string группа, string имя)
        {
            return !string.IsNullOrEmpty(группа) && !string.IsNullOrEmpty(имя);
        }

        private Timer таймер;
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            таймер = new Timer();
            таймер.Interval = 1000; // Устанавливаем интервал в 1000 миллисекунд (1 секунда)
            таймер.Tick += Таймер_Tick; // Устанавливаем обработчик события для таймера
            таймер.Start(); // Запускаем таймер
        }

        private void Таймер_Tick(object sender, EventArgs e)
        {
            // Обновляем текст Label с текущей датой и временем
            dataLabel.Text = $"{DateTime.Now.ToString("dd.MM.yyyy")}";
            timerLabel.Text = $"{DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void BxodBtn_Click(object sender, EventArgs e)
        {
            string группа = GroupTb.Text;
            string имя = FItb.Text;

            if (ПроверкаЛогина(имя, группа))
            {
                MessageBox.Show("Вход выполнен успешно!");

                HubForm hub = new HubForm(имя);
                hub.Show();
            }
            else
            {
                MessageBox.Show("Вы запонили не все поля ввода.");
            }
        }
    }
}
