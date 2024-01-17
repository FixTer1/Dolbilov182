using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diplom
{
    public partial class ScrollTextForm : Form
    {
        private Timer таймер;
        public ScrollTextForm()
        {
            InitializeComponent();

            string текст = "1. Цель работы: \r\n  \r\n    1.1 Закрепить знания по теме \" Нелинейное\r\n кодирование\". \r\n    1.2 Исследовать работу схемы кодера нелинейного.\r\n\r\n 2. Рекомендуемая литература:\r\n  \r\n    2.1. Ю.В.Скалин и др. \"Цифровые системы передачи\" - М : Радио  и\r\n связь, - 1987.\r\n    2.2. Н.Н.Баева и др.\"Многоканальные системы передачи\"- М : Радио\r\n и связь, - 1997.\r\n\r\n 3. Подготовка к работе.\r\n\r\n    3.1. Изучить структурную схему кодера нелинейного.\r\n    3.2. Подготовить бланк отчета.\r\n\r\n 4. Содержание отчета\r\n\r\n    4.1. Название лабораторной работы.\r\n    4.2. Цель работы.\r\n    4.3. Структурная схема кодера нелинейного.\r\n    4.4. Временные диаграммы работы схемы.\r\n\r\n 5. Задание\r\n\r\n    5.1. Зарисовать структурную схему кодера нелинейного.\r\n Для этого в меню необходимо выбрать пункт  \" ОПИСАНИЕ\r\n СХЕМЫ \". В данном пункте приводится описание схемы\r\n кодера  нелинейного.\r\n\r\n \"Прокручивать\" текст можно с помощью клавиш \u0018 \u0019.\r\n\r\n    5.2. Исследовать работу схемы в автоматическом режиме.\r\n\r\n    5.3. Зарисовать в отчете временные диаграммы работы схемы.\r\n\r\n 6. Ответить на контрольные вопросы.\r\n\r\n    6.1. При выполнении работы внимательно смотрите на экран\r\n монитора ПК и руководствуйтесь теми указаниями которые\r\n Вам выдает компьютер.\r\n \r\n    Помните, что ответить на контрольные вопросы можно\r\n только имея перед собой структурную схему кодера\r\n нелинейного и временные диаграммы работы.";

            textBoxText.Text = текст;
            textBoxText.Multiline = true;
            textBoxText.ScrollBars = ScrollBars.Vertical;
            SetInitialFont();


            таймер = new Timer();
            таймер.Interval = 1000; // Устанавливаем интервал в 1000 миллисекунд (1 секунда)
            таймер.Tick += Таймер_Tick; // Устанавливаем обработчик события для таймера
            таймер.Start(); // Запускаем таймер
        }

        private void SetInitialFont()
        {
            // Устанавливаем начальный шрифт и размер текста
            textBoxText.Font = new System.Drawing.Font("Arial", 12); // Например, Arial, размер 12
        }

        private void Таймер_Tick(object sender, EventArgs e)
        {
            // Обновляем текст Label с текущей датой и временем
            dataLabel.Text = $"{DateTime.Now.ToString("dd.MM.yyyy")}";
            timerLabel.Text = $"{DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnChangeFont_Click(object sender, EventArgs e)
        {
            // Создаем диалоговое окно выбора шрифта
            FontDialog fontDialog = new FontDialog();

            // Устанавливаем текущий шрифт и размер
            fontDialog.Font = textBoxText.Font;

            // Если пользователь выбрал шрифт и нажал "ОК"
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // Устанавливаем новый шрифт и размер
                textBoxText.Font = fontDialog.Font;
            }
        }
    }
}
