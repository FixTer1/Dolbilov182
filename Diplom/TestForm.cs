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
    public partial class TestForm : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex;

        private Label questionLabel;
        private List<RadioButton> answerRadioButtons;
        private Button nextButton;

        public TestForm()
        {
            InitializeComponent();
            InitializeQuestions();
            LoadQuestion();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeQuestions()
        {
            // Создаем 10 вопросов и варианты ответов
            questions = new List<Question>
            {
            new Question("Какова максимальная амплитуда АИМ сигнала на входе кодера?", new List<string> { "1024", "1984", "128", "2048", "2908" }, 3),
            new Question("Какова максимальная ошибка квантования нелинейного кодера?", new List<string> { "ошибка квантования = 0,5", "ошибка квантования = 64", "ошибка квантования = 32", "ошибка квантования = 1", "ошибка квантования = 15"}, 1),
            new Question("Назначение компаратора?", new List<string> { "Для подключения эталонных токов", "Для преобразования сигнала АИМ-1 в АИМ-2", "Для включения ЛУ", "Для сравнения тока АИМ-2 и тока ГЭТ", "Для подключения преобразователя кода" }, 3),
            new Question("назначение преобразователя кода?", new List<string> { "Для преобразования параллельного кода в последователый", "Модулирует передаваемый сигнал по амплитуде", "Управляет работой ЛУ", "Дискретизирует передаваемый сигнал по времени", "Преобразует сигнал АИМ-1 в АИМ-2" }, 0),
            new Question("Назначение кодера нелинейного?", new List<string> { "Для преобразования АИМ сигнала в ИКМ", "Для преобразования ИКМ сигнала в АИМ", "Для преобразования АИМ-1 в АИМ-2", "Для преобразования аналогового сигнала в цифровой", "Для дискретизации сигнала" }, 0),
            new Question("Какое максимальное количество ключей в ГЭТ?", new List<string> { "8", "11", "9", "15", "13" }, 2),
            new Question("Почему в кодере используется два ГЭТ?", new List<string> { "В телефонии сигналы положительной и отрицательной полярности", "Чтобы увеличить количество эатлонных токов", "Преобразует сигнал из АИМ-1 в АИМ-2", "Для повышения надежности аппаратуры", "Для повышения качества передаваемого сигнала" }, 4),
            new Question("Назначения ключей в ГЭТ?", new List<string> { "Включают эталонные токи", "Выключают эталонные токи", "Включают и выключают эталонные токи", "Для дискретизации сигнала", "Для управления логическим устройством" }, 2),
            new Question("На входе компаратора ток 32 условные единицы?", new List<string> { "На выходе ПК кодовая группа 10100011", "На выходе ПК кодовая группа 10000011", "На выходе ПК кодовая группа 01100011", "На выходе ПК кодовая группа 10100000", "На выходе ПК кодовая группа 11000000" }, 4),
            new Question("На входе компаратора ток 64 условных единицы?", new List<string> { "На выходе ПК кодовая группа 10100000", "На выходе ПК кодовая группа 00101000", "На выходе ПК кодовая группа 10110000", "На выходе ПК кодовая группа 11000000", "На выходе ПК кодовая группа 10101010" }, 1),
            // Добавьте еще вопросы аналогичным образом
            };
        }

        private void LoadQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                Question currentQuestion = questions[currentQuestionIndex];

                // Очищаем предыдущие элементы управления
                ClearControls();

                // Добавляем варианты ответов в виде RadioButton
                answerRadioButtons = new List<RadioButton>();
                foreach (string option in currentQuestion.Options)
                {
                    RadioButton radioButton = new RadioButton
                    {
                        Text = option,
                        Dock = DockStyle.Top,
                        Font = new Font("Times New Roman", 14) // Шрифт
                    };

                    radioButton.CheckedChanged += RadioButton_CheckedChanged; // Добавляем обработчик события
                    answerRadioButtons.Add(radioButton);
                    groupBox1.Controls.Add(radioButton);
                }

                // Добавляем кнопку "Далее"
                nextButton = new Button
                {
                    Text = "Далее",
                    Dock = DockStyle.Top,
                    Font = new Font("Times New Roman", 14), // Шрифт
                    Height = 40 //Увеличиваем высоту кнопки
                };

                nextButton.Click += NextButton_Click;
                groupBox1.Controls.Add(nextButton);

                // Добавляем текст вопроса
                questionLabel = new Label
                {
                    Text = currentQuestion.Text,
                    Dock = DockStyle.Top,
                    Font = new Font("Times New Roman", 14, FontStyle.Bold) // Жирный шрифт
                };

                groupBox1.Controls.Add(questionLabel);
            }
            else
            {
                // Вопросы закончились - выводим статистику
                ShowResults();
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Сохраняем ответ пользователя при изменении состояния RadioButton
            RadioButton radioButton = (RadioButton)sender;
            int selectedOptionIndex = answerRadioButtons.IndexOf(radioButton);
            questions[currentQuestionIndex].UserAnswerIndex = selectedOptionIndex;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Переходим к следующему вопросу
            currentQuestionIndex++;

            // Загружаем следующий вопрос
            LoadQuestion();
        }

        private void ShowResults()
        {
            // Выводим статистику
            int correctAnswers = questions.Count(q => q.CorrectAnswerIndex == q.UserAnswerIndex);
            int totalQuestions = questions.Count;

            double score = (double)correctAnswers / totalQuestions * 100;

            string resultMessage = $"Тест завершен!\nПравильных ответов: {correctAnswers}/{totalQuestions}\nОценка: {GetGrade(score)}";
            MessageBox.Show(resultMessage);

            this.Close();
        }

        private string GetGrade(double score)
        {
            if (score >= 90)
                return "Отлично";
            else if (score >= 70)
                return "Хорошо";
            else if (score >= 50)
                return "Удовлетворительно";
            else
                return "Неудовлетворительно";
        }

        private void ClearControls()
        {
            groupBox1.Controls.Clear();
        }
    }

        public class Question
        {
            public string Text { get; }
            public List<string> Options { get; }
            public int CorrectAnswerIndex { get; }
            public int UserAnswerIndex { get; set; }

            public Question(string text, List<string> options, int correctAnswerIndex)
            {
                Text = text;
                Options = options;
                CorrectAnswerIndex = correctAnswerIndex;
                UserAnswerIndex = -1; // -1 означает, что ответ еще не выбран
            }
        }
}
