using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diplom;
using static System.Windows.Forms.AxHost;

namespace Diplom
{
    public partial class OpisanieSxemForm : Form
    {
        private Timer таймер;
        public OpisanieSxemForm()
        {
            // Подписываемся на событие Paint формы
            this.Paint += new PaintEventHandler(DiagramForm_Paint);
            InitializeComponent();
            

            string текст = "Кодер предназначен\r\n  для преобразования\r\n  сигнала АИМ в ИКМ\r\n  сигнал.\r\n  Т.е. импульса АИМ\r\n  в восьмиразрядную\r\n  кодовую группу.\r\n                  ---*---\r\n Схема кодера сос-\r\n  тоит из компарато-\r\n  ра,который необхо-\r\n  дим для сравнения\r\n  амплитуды двух АИМ\r\n  сигналов (входного\r\n  и сигнала с ГЭТ).\r\n                  ---*---\r\n ГЭТ вырабатывает\r\n  токи определенной\r\n  величины,равные 1,\r\n  2,4,8,16,32,64,128,\r\n  256,512,1024 усло-\r\n  вных единиц.\r\n  Т.к. в телефонии\r\n  передаются сигналы\r\n  положительной и от-\r\n  рицательной поляр-\r\n  ности,то в схеме\r\n  кодера применяются\r\n  два генератора\r\n  эталонных токов-\r\n  один для положи-\r\n  тельных импульсов,\r\n  другой-для отри-\r\n  цательных.\r\n                  ---*---\r\n Компрессирующая\r\n  логика предназна-\r\n  чена для включения\r\n  и выключения клю-\r\n  чей Кл1-Кл11 в ГЭТ.\r\n                  ---*---\r\n Преобразователь\r\n  кода служит для\r\n  преобразования\r\n  параллельного кода\r\n  в последовательный.\r\n";

            textBoxText.Text = текст;
            textBoxText.Multiline = true;
            textBoxText.ScrollBars = ScrollBars.Vertical;
            SetInitialFont();

            таймер = new Timer();
            таймер.Interval = 1000; // Устанавливаем интервал в 1000 миллисекунд (1 секунда)
            таймер.Tick += Таймер_Tick; // Устанавливаем обработчик события для таймера
            таймер.Start(); // Запускаем таймер
        }

        private void Таймер_Tick(object sender, EventArgs e)
        {
            // Обновляем текст Label с текущей датой и временем
            dataLabel.Text = $"{DateTime.Now.ToString("dd.MM.yyyy")}";
            timeLabel.Text = $"{DateTime.Now.ToString("HH:mm:ss")}";
        }
        private void DiagramForm_Paint(object sender, PaintEventArgs e)
        {
            // Создаем объект Graphics для рисования
            Graphics g = e.Graphics;

            // Определение координат и размеры 1го прямоугольника
            int x1 = 50;
            int y1 = 50;
            int width1 = 300;
            int height1 = 40;
            // Определение координат и размеры 2го прямоугольников
            int x2 = 50;
            int y2 = y1 + 45;
            int width2 = 50;
            int height2 = 30;
            // Определяем координаты и размеры 3го прямоугольника
            int x3 = 50;
            int y3 = y2 + 40;
            int width3 = 50;
            int height3 = 30;
            // Определяем координаты и размеры 4го прямоугольника
            int x4 = 50;
            int y4 = y3 + 40;
            int width4 = 50;
            int height4 = 30;
            // Определяем координаты и размеры 5го прямоугольника
            int x5 = 50;
            int y5 = y4 + 40;
            int width5 = 50;
            int height5 = 30;
            // Определяем координаты и размеры 6го прямоугольника
            int x6 = 50;
            int y6 = y5 + 40;
            int width6 = 50;
            int height6 = 30;
            // Определяем координаты и размеры 7го прямоугольника
            int x7 = 50;
            int y7 = y6 + 40;
            int width7 = 50;
            int height7 = 30;
            // Определяем координаты и размеры 8го прямоугольника
            int x8 = 50;
            int y8 = y7 + 40;
            int width8 = 50;
            int height8 = 30;
            // Определяем координаты и размеры 9го прямоугольника
            int x9 = 50;
            int y9 = y8 + 40;
            int width9 = 50;
            int height9 = 30;
            // Определяем координаты и размеры 10го прямоугольника
            int x10 = 50;
            int y10 = y9 + 40;
            int width10 = 50;
            int height10 = 30;
            // Определяем координаты и размеры 11го прямоугольника
            int x11 = 50;
            int y11 = y10 + 40;
            int width11 = 50;
            int height11 = 30;
            // Определяем координаты и размеры 12го прямоугольника
            int x12 = 50;
            int y12 = y11 + 40;
            int width12 = 50;
            int height12 = 30;
            // Определяем координаты и размеры 13го прямоугольника
            int x27 = 50;
            int y27 = y12 + 40;
            int width27 = 50;
            int height27 = 30;
            // Определяем координаты и размеры 2го (зеркало) прямоугольника
            int x14 = x2 + 250;
            int y14 = y2;
            int width14 = 50;
            int height14 = 30;
            // Определяем координаты и размеры 3го (зеркало) прямоугольника
            int x15 = x3 + 250;
            int y15 = y3;
            int width15 = 50;
            int height15 = 30;
            // Определяем координаты и размеры 4го (зеркало) прямоугольника
            int x16 = x4 + 250;
            int y16 = y4;
            int width16 = 50;
            int height16 = 30;
            // Определяем координаты и размеры 5го (зеркало) прямоугольника
            int x17 = x5 + 250;
            int y17 = y5;
            int width17 = 50;
            int height17 = 30;
            // Определяем координаты и размеры 6го (зеркало) прямоугольника
            int x18 = x6 + 250;
            int y18 = y6;
            int width18 = 50;
            int height18 = 30;
            // Определяем координаты и размеры 7го (зеркало) прямоугольника
            int x19 = x7 + 250;
            int y19 = y7;
            int width19 = 50;
            int height19 = 30;
            // Определяем координаты и размеры 8го (зеркало) прямоугольника
            int x20 = x8 + 250;
            int y20 = y8;
            int width20 = 50;
            int height20 = 30;
            // Определяем координаты и размеры 9го (зеркало) прямоугольника
            int x21 = x9 + 250;
            int y21 = y9;
            int width21 = 50;
            int height21 = 30;
            // Определяем координаты и размеры 10го (зеркало) прямоугольника
            int x22 = x10 + 250;
            int y22 = y10;
            int width22 = 50;
            int height22 = 30;
            // Определяем координаты и размеры 11го (зеркало) прямоугольника
            int x23 = x11 + 250;
            int y23 = y11;
            int width23 = 50;
            int height23 = 30;
            // Определяем координаты и размеры 12го (зеркало) прямоугольника
            int x13 = y12 - 195;
            int y13 = y12;
            int width13 = 50;
            int height13 = 30;
            // Определяем координаты и размеры 13го (зеркало) прямоугольника 
            int x28 = x13;
            int y28 = y13 + 40;
            int width28 = 50;
            int height28 = 30;
            // Определяем координаты и размеры 14 прямоугольника
            int x24 = y1 + 530;
            int y24 = y1;
            int width24 = 60;
            int height24 = 514;
            // Определяем координаты и размеры 15 прямоугольника
            int x25 = x24 - 165;
            int y25 = y24 + 517;
            int width25 = 225;
            int height25 = 50;
            // Определяем координаты и размеры 16 прямоугольника
            int x26 = x24 - 200;
            int y26 = y24 + 95;
            int width26 = 60;
            int height26 = 420;

            // Рисуем прямоугольники и текст
            using (SolidBrush brush = new SolidBrush(Color.Gray))
            using (SolidBrush textBrush = new SolidBrush(Color.Black))
            {
                // Рисуем 1й прямоугольник
                g.FillRectangle(brush, x1, y1, width1, height1);
                DrawText(g, textBrush, "К", x1, y1, width1, height1);
                // Рисуем 2й прямоугольник
                g.FillRectangle(brush, x2, y2, width2, height2);
                DrawText(g, textBrush, "-  Е", x2, y2, width2, height2);
                // Рисуем 3й прямоугольник
                g.FillRectangle(brush, x3, y3, width3, height3);
                DrawText(g, textBrush, "1024", x3, y3, width3, height3);
                // Рисуем 4й прямоугольник
                g.FillRectangle(brush, x4, y4, width4, height4);
                DrawText(g, textBrush, "512", x4, y4, width4, height4);
                // Рисуем 5й прямоугольник
                g.FillRectangle(brush, x5, y5, width5, height5);
                DrawText(g, textBrush, "256", x5, y5, width5, height5);
                // Рисуем 6й прямоугольник
                g.FillRectangle(brush, x6, y6, width6, height6);
                DrawText(g, textBrush, "128", x6, y6, width6, height6);
                // Рисуем 7й прямоугольник
                g.FillRectangle(brush, x7, y7, width7, height7);
                DrawText(g, textBrush, "64", x7, y7, width7, height7);
                // Рисуем 8й прямоугольник
                g.FillRectangle(brush, x8, y8, width8, height8);
                DrawText(g, textBrush, "32", x8, y8, width8, height8);
                // Рисуем 9й прямоугольник
                g.FillRectangle(brush, x9, y9, width9, height9);
                DrawText(g, textBrush, "16", x9, y9, width9, height9);
                // Рисуем 10й прямоугольник
                g.FillRectangle(brush, x10, y10, width10, height10);
                DrawText(g, textBrush, "8", x10, y10, width10, height10);
                // Рисуем 11й прямоугольник
                g.FillRectangle(brush, x11, y11, width11, height11);
                DrawText(g, textBrush, "4", x11, y11, width11, height11);
                // Рисуем 12й прямоугольник
                g.FillRectangle(brush, x12, y12, width12, height12);
                DrawText(g, textBrush, "2", x12, y12, width12, height12);
                // Рисуем 13й прямоугольник
                g.FillRectangle(brush, x27, y27, width27, height27);
                DrawText(g, textBrush, "1", x27, y27, width27, height27);
                // Рисуем 2й (зеркало) прямоугольник
                g.FillRectangle(brush, x14, y14, width14, height14);
                DrawText(g, textBrush, "+  Е", x14, y14, width14, height14);
                // Рисуем 3й (зеркало) прямоугольник
                g.FillRectangle(brush, x15, y15, width15, height15);
                DrawText(g, textBrush, "1024", x15, y15, width15, height15);
                // Рисуем 4й (зеркало) прямоугольник
                g.FillRectangle(brush, x16, y16, width16, height16);
                DrawText(g, textBrush, "512", x16, y16, width16, height16);
                // Рисуем 5й (зеркало) прямоугольник
                g.FillRectangle(brush, x17, y17, width17, height17);
                DrawText(g, textBrush, "256", x17, y17, width17, height17);
                // Рисуем 6й (зеркало) прямоугольник
                g.FillRectangle(brush, x18, y18, width18, height18);
                DrawText(g, textBrush, "128", x18, y18, width18, height18);
                // Рисуем 7й (зеркало) прямоугольник
                g.FillRectangle(brush, x19, y19, width19, height19);
                DrawText(g, textBrush, "64", x19, y19, width19, height19);
                // Рисуем 8й (зеркало) прямоугольник
                g.FillRectangle(brush, x20, y20, width20, height20);
                DrawText(g, textBrush, "32", x20, y20, width20, height20);
                // Рисуем 9й (зеркало) прямоугольник
                g.FillRectangle(brush, x21, y21, width21, height21);
                DrawText(g, textBrush, "16", x21, y21, width21, height21);
                // Рисуем 10й (зеркало) прямоугольник
                g.FillRectangle(brush, x22, y22, width22, height22);
                DrawText(g, textBrush, "8", x22, y22, width22, height22);
                // Рисуем 11й (зеркало) прямоугольник
                g.FillRectangle(brush, x23, y23, width23, height23);
                DrawText(g, textBrush, "4", x23, y23, width23, height23);
                // Рисуем 12й (зеркало) прямоугольник
                g.FillRectangle(brush, x13, y13, width13, height13);
                DrawText(g, textBrush, "2", x13, y13, width13, height13);
                // Рисуем 13й (зеркало) прямоугольник
                g.FillRectangle(brush, x28, y28, width28, height28);
                DrawText(g, textBrush, "1", x28, y28, width28, height28);
                // Рисуем 14й прямоугольник
                g.FillRectangle(brush, x24, y24, width24, height24);
                DrawText(g, textBrush, "Ц.Р.", x24, y24, width24, height24);
                // Рисуем 15й прямоугольник
                g.FillRectangle(brush, x25, y25, width25, height25);
                DrawText(g, textBrush, "П.К.", x25, y25, width25, height25);
                // Рисуем 16й прямоугольник
                g.FillRectangle(brush, x26, y26, width26, height26);
                DrawText(g, textBrush, "К.Л.", x26, y26, width26, height26);
            }

            // Линия "1" - правая стенка прямоугольника "1", со стрелкой
            int startX1 = x1 + width1;
            int startY1 = y1 + height1 - 30;
            DrawArrowLine(e, startX1, startY1, Color.Black, 230, 0);

            // Линия "2" - нижняя стенка прямоугольника "1", со стрелкой
            int startX24 = x1 + width1 / 2;
            int startY24 = y1 + height1;
            // Рисуем линию
            DrawLine(e, startX24, startY24, Color.Black, 0, 462);

            int middleX1 = startX24 - 24;
            int middleY1 = startY24 + 60;
            // Рисование горизонтальной линии в середине вертикальной линии
            DrawLine(e, middleX1, middleY1, Color.Black, 48, 0);
            string textOnLine1 = "К_1";
            DrawTextOnLine(e.Graphics, textOnLine1, middleX1, middleY1, middleX1 + 48, middleY1 - 15);

            int middleX2 = startX24 - 24;
            int middleY2 = startY24 + 100;
            // Рисование горизонтальной линии в середине вертикальной линии
            DrawLine(e, middleX2, middleY2, Color.Black, 48, 0);
            string textOnLine2 = "К_2";
            DrawTextOnLine(e.Graphics, textOnLine2, middleX2, middleY2, middleX2 + 48, middleY2 - 15);

            int middleX3 = startX24 - 24;
            int middleY3 = startY24 + 140;
            // Рисование горизонтальной линии в середине вертикальной линии
            DrawLine(e, middleX3, middleY3, Color.Black, 48, 0);
            string textOnLine3 = "К_3";
            DrawTextOnLine(e.Graphics, textOnLine3, middleX3, middleY3, middleX3 + 48, middleY3 - 15);

            int middleX4 = startX24 - 24;
            int middleY4 = startY24 + 180;
            // Рисование горизонтальной линии в середине вертикальной линии
            DrawLine(e, middleX4, middleY4, Color.Black, 48, 0);
            string textOnLine4 = "К_4";
            DrawTextOnLine(e.Graphics, textOnLine4, middleX4, middleY4, middleX4 + 48, middleY4 - 15);

            int middleX5 = startX24 - 24;
            int middleY5 = startY24 + 220;
            // Рисование горизонтальной линии в середине вертикальной линии
            DrawLine(e, middleX5, middleY5, Color.Black, 48, 0);
            string textOnLine5 = "К_5";
            DrawTextOnLine(e.Graphics, textOnLine5, middleX5, middleY5, middleX5 + 48, middleY5 - 15);

            int middleX6 = startX24 - 24;
            int middleY6 = startY24 + 260;
            // Рисование горизонтальной линии в середине вертикальной линии
            DrawLine(e, middleX6, middleY6, Color.Black, 48, 0);
            string textOnLine6 = "К_6";
            DrawTextOnLine(e.Graphics, textOnLine6, middleX6, middleY6, middleX6 + 48, middleY6 - 15);

            int middleX7 = startX24 - 24;
            int middleY7 = startY24 + 300;
            // Рисование горизонтальной линии в середине вертикальной линии
            DrawLine(e, middleX7, middleY7, Color.Black, 48, 0);
            string textOnLine7 = "К_7";
            DrawTextOnLine(e.Graphics, textOnLine7, middleX7, middleY7, middleX7 + 48, middleY7 - 15);

            int middleX8 = startX24 - 24;
            int middleY8 = startY24 + 340;
            // Рисование горизонтальной линии в середине вертикальной линии
            DrawLine(e, middleX8, middleY8, Color.Black, 48, 0);
            string textOnLine8 = "К_8";
            DrawTextOnLine(e.Graphics, textOnLine8, middleX8, middleY8, middleX8 + 48, middleY8 - 15);

            int middleX9 = startX24 - 24;
            int middleY9 = startY24 + 380;
            // Рисование горизонтальной линии в середине вертикальной линии
            DrawLine(e, middleX9, middleY9, Color.Black, 48, 0);
            string textOnLine9 = "К_9";
            DrawTextOnLine(e.Graphics, textOnLine9, middleX9, middleY9, middleX9 + 48, middleY9 - 15);

            int middleX10 = startX24 - 24;
            int middleY10 = startY24 + 420;
            // Рисование горизонтальной линии в середине вертикальной линии
            DrawLine(e, middleX10, middleY10, Color.Black, 48, 0);
            string textOnLine10 = "К_10";
            DrawTextOnLine(e.Graphics, textOnLine10, middleX10, middleY10, middleX10 + 55, middleY10 - 15);

            int middleX11 = startX24 - 24;
            int middleY11 = startY24 + 460;
            // Рисование горизонтальной линии в середине вертикальной линии
            DrawLine(e, middleX11, middleY11, Color.Black, 48, 0);
            string textOnLine11 = "К_11";
            DrawTextOnLine(e.Graphics, textOnLine11, middleX11, middleY11, middleX11 + 55, middleY11 - 15);

            ///////////////////////////

            // Левая стенка прямоугольника "2"
            int startX2 = x2 - 10;
            int startY2 = y2 + height2 / 2;
            // Рисуем линию
            DrawLine(e, startX2, startY2, Color.Black, 10, 0);

            // Левая стенка прямоугольника "3"
            int startX3 = x3 - 10;
            int startY3 = y3 + height3 / 2;
            // Рисуем линию
            DrawLine(e, startX3, startY3, Color.Black, 10, 0);

            // Левая стенка прямоугольника "4"
            int startX4 = x4 - 10;
            int startY4 = y4 + height4 / 2;
            // Рисуем линию
            DrawLine(e, startX4, startY4, Color.Black, 10, 0);

            // Левая стенка прямоугольника "5"
            int startX5 = x5 - 10;
            int startY5 = y5 + height5 / 2;
            // Рисуем линию
            DrawLine(e, startX5, startY5, Color.Black, 10, 0);

            // Левая стенка прямоугольника "6"
            int startX6 = x6 - 10;
            int startY6 = y6 + height6 / 2;
            // Рисуем линию
            DrawLine(e, startX6, startY6, Color.Black, 10, 0);

            // Левая стенка прямоугольника "7"
            int startX7 = x7 - 10;
            int startY7 = y7 + height7 / 2;
            // Рисуем линию
            DrawLine(e, startX7, startY7, Color.Black, 10, 0);

            // Левая стенка прямоугольника "8"
            int startX8 = x8 - 10;
            int startY8 = y8 + height8 / 2;
            // Рисуем линию
            DrawLine(e, startX8, startY8, Color.Black, 10, 0);

            // Левая стенка прямоугольника "9"
            int startX9 = x9 - 10;
            int startY9 = y9 + height9 / 2;
            // Рисуем линию
            DrawLine(e, startX9, startY9, Color.Black, 10, 0);

            // Левая стенка прямоугольника "10"
            int startX10 = x10 - 10;
            int startY10 = y10 + height10 / 2;
            // Рисуем линию
            DrawLine(e, startX10, startY10, Color.Black, 10, 0);

            // Левая стенка прямоугольника "11"
            int startX11 = x11 - 10;
            int startY11 = y11 + height11 / 2;
            // Рисуем линию
            DrawLine(e, startX11, startY11, Color.Black, 10, 0);

            // Левая стенка прямоугольника "12"
            int startX12 = x12 - 10;
            int startY12 = y12 + height12 / 2;
            // Рисуем линию
            DrawLine(e, startX12, startY12, Color.Black, 10, 0);

            // Левая стенка прямоугольника "13"
            int startX27 = x27 - 10;
            int startY27 = y27 + height27 / 2;
            // Рисуем линию
            DrawLine(e, startX27, startY27, Color.Black, 10, 0);

            // Правая стенка прямоугольника "2" (Зеркало)
            int startX14 = x14 + width14;
            int startY14 = y14 + height14 / 2;
            // Рисуем линию
            DrawLine(e, startX14, startY14, Color.Black, 10, 0);

            // Правая стенка прямоугольника "3" (Зеркало)
            int startX15 = x15 + width15;
            int startY15 = y15 + height15 / 2;
            // Рисуем линию
            DrawLine(e, startX15, startY15, Color.Black, 10, 0);

            // Правая стенка прямоугольника "4" (Зеркало)
            int startX16 = x16 + width16;
            int startY16 = y16 + height16 / 2;
            // Рисуем линию
            DrawLine(e, startX16, startY16, Color.Black, 10, 0);

            // Правая стенка прямоугольника "5" (Зеркало)
            int startX17 = x17 + width17;
            int startY17 = y17 + height17 / 2;
            // Рисуем линию
            DrawLine(e, startX17, startY17, Color.Black, 10, 0);

            // Правая стенка прямоугольника "6" (Зеркало)
            int startX18 = x18 + width18;
            int startY18 = y18 + height18 / 2;
            // Рисуем линию
            DrawLine(e, startX18, startY18, Color.Black, 10, 0);

            // Правая стенка прямоугольника "7" (Зеркало)
            int startX19 = x19 + width19;
            int startY19 = y19 + height19 / 2;
            // Рисуем линию
            DrawLine(e, startX19, startY19, Color.Black, 10, 0);

            // Правая стенка прямоугольника "8" (Зеркало)
            int startX20 = x20 + width20;
            int startY20 = y20 + height20 / 2;
            // Рисуем линию
            DrawLine(e, startX20, startY20, Color.Black, 10, 0);

            // Правая стенка прямоугольника "9" (Зеркало)
            int startX21 = x21 + width21;
            int startY21 = y21 + height21 / 2;
            // Рисуем линию
            DrawLine(e, startX21, startY21, Color.Black, 10, 0);

            // Правая стенка прямоугольника "10" (Зеркало)
            int startX22 = x22 + width22;
            int startY22 = y22 + height22 / 2;
            // Рисуем линию
            DrawLine(e, startX22, startY22, Color.Black, 10, 0);

            // Правая стенка прямоугольника "11" (Зеркало)
            int startX23 = x23 + width23;
            int startY23 = y23 + height23 / 2;
            // Рисуем линию
            DrawLine(e, startX23, startY23, Color.Black, 10, 0);

            // Правая стенка прямоугольника "12" (Зеркало)
            int startX13 = x13 + width13;
            int startY13 = y13 + height13 / 2;
            // Рисуем линию
            DrawLine(e, startX13, startY13, Color.Black, 10, 0);

            // Правая стенка прямоугольника "13" (Зеркало)
            int startX28 = x28 + width28;
            int startY28 = y28 + height28 / 2;
            // Рисуем линию
            DrawLine(e, startX28, startY28, Color.Black, 10, 0);

            ////
            int startX29 = x1 - 25;
            int startY29 = y1 + height1 / 2;
            int endX1 = startX29 + 25; // Например, сдвиг на 50 пикселей
            int endY1 = startY29; // Например, сдвиг на 50 пикселей
            DrawArrowLine(e, startX29, startY29, Color.Black, endX1 - startX29, endY1 - startY29);
            ////

            // Новые координаты для начала и конца второй линии (идущей вверх)
            int startX30 = startX27;
            int startY30 = startY27;
            int endX2 = startX30;
            int endY2 = startY30 - 433; // Например, сдвиг на 50 пикселей вверх
            // Рисуем линию
            DrawLine(e, startX30, startY30, Color.Black, endX2 - startX30, endY2 - startY30);
            int startX32 = endX2;
            int startY32 = endY2;
            int endX4 = startX32 - 15; // Например, сдвиг на 100 пикселей вправо
            int endY4 = startY32 - 15;
            // Рисуем линию (идущую в бок)
            DrawLine(e, startX32, startY32, Color.Black, endX4 - startX32, endY4 - startY32);


            // Новые координаты для начала и конца третей линии (идущей вверх)
            int startX31 = startX28 + 10;
            int startY31 = startY28;
            int endX3 = startX31;
            int endY3 = startY31 - 433; // Например, сдвиг на 50 пикселей вверх
            // Рисуем линию
            DrawLine(e, startX31, startY31, Color.Black, endX3 - startX31, endY3 - startY31);

            int startX33 = endX3;
            int startY33 = endY3;
            int endX5 = startX33 + 15; // Например, сдвиг на 100 пикселей вправо
            int endY5 = startY33 - 15;
            // Рисуем линию (идущую в бок)
            DrawLine(e, startX33, startY33, Color.Black, endX5 - startX33, endY5 - startY33);
            int startX34 = x25;
            int startY34 = y25 + 40;
            int endX6 = startX34 - 55; // Например, сдвиг на 55 пикселей влево
            int endY6 = startY34;
            DrawArrowLine(e, startX34, startY34, Color.Black, endX6 - startX34, endY6 - startY34);

            int startX35 = x24;
            int startY35 = y24 + height24 - 454;
            DrawLine(e, startX35, startY35, Color.Black, -140, 0);
            int endX7 = startX35 - 140;
            int endY7 = startY35;
            DrawArrowLine(e, startX35, startY35, Color.Black, endX7 - startX35, endY7 - startY35);
            int startX36 = startX35;
            int startY36 = startY35;
            DrawLine(e, startX36, startY36, Color.Black, -200, 0);
            string textOnLine12 = "1";
            DrawTextOnLine2(e.Graphics, textOnLine12, startX35, startY35, endX7, endY7, 20f, 562, 88);

            int startX37 = x24;
            int startY37 = y24 + height24 - 395;
            DrawLine(e, startX37, startY37, Color.Black, -140, 0);
            int endX8 = startX37 - 140;
            int endY8 = startY37;
            DrawArrowLine(e, startX37, startY37, Color.Black, endX8 - startX37, endY8 - startY37);
            string textOnLine13 = "2";
            DrawTextOnLine2(e.Graphics, textOnLine13, startX37, startY37, endX8, endY8, 20f, 562, 148);

            int startX38 = x24;
            int startY38 = y24 + height24 - 335;
            DrawLine(e, startX38, startY38, Color.Black, -140, 0);
            int endX9 = startX38 - 140;
            int endY9 = startY38;
            DrawArrowLine(e, startX38, startY38, Color.Black, endX9 - startX38, endY9 - startY38);
            string textOnLine14 = "3";
            DrawTextOnLine2(e.Graphics, textOnLine14, startX38, startY38, endX9, endY9, 20f, 562, 208);

            int startX39 = x24;
            int startY39 = y24 + height24 - 275;
            DrawLine(e, startX39, startY39, Color.Black, -140, 0);
            int endX10 = startX39 - 140;
            int endY10 = startY39;
            DrawArrowLine(e, startX39, startY39, Color.Black, endX10 - startX39, endY10 - startY39);
            string textOnLine15 = "4";
            DrawTextOnLine2(e.Graphics, textOnLine15, startX39, startY39, endX10, endY10, 20f, 562, 268);

            int startX40 = x24;
            int startY40 = y24 + height24 - 215;
            DrawLine(e, startX40, startY40, Color.Black, -140, 0);
            int endX11 = startX40 - 140;
            int endY11 = startY40;
            DrawArrowLine(e, startX40, startY40, Color.Black, endX11 - startX40, endY11 - startY40);
            string textOnLine16 = "5";
            DrawTextOnLine2(e.Graphics, textOnLine16, startX40, startY40, endX11, endY11, 20f, 562, 328);

            int startX41 = x24;
            int startY41 = y24 + height24 - 155;
            DrawLine(e, startX41, startY41, Color.Black, -140, 0);
            int endX12 = startX41 - 140;
            int endY12 = startY41;
            DrawArrowLine(e, startX41, startY41, Color.Black, endX12 - startX41, endY12 - startY41);
            string textOnLine17 = "6";
            DrawTextOnLine2(e.Graphics, textOnLine17, startX41, startY41, endX12, endY12, 20f, 562, 388);

            int startX42 = x24;
            int startY42 = y24 + height24 - 95;
            DrawLine(e, startX42, startY42, Color.Black, -140, 0);
            int endX13 = startX42 - 140;
            int endY13 = startY42;
            DrawArrowLine(e, startX42, startY42, Color.Black, endX13 - startX42, endY13 - startY42);
            string textOnLine18 = "7";
            DrawTextOnLine2(e.Graphics, textOnLine18, startX42, startY42, endX13, endY13, 20f, 562, 448);

            int startX43 = x24;
            int startY43 = y24 + height24 - 35;
            DrawLine(e, startX43, startY43, Color.Black, -140, 0);
            int endX14 = startX43 - 140;
            int endY14 = startY43;
            DrawArrowLine(e, startX43, startY43, Color.Black, endX14 - startX43, endY14 - startY43);
            string textOnLine19 = "8";
            DrawTextOnLine2(e.Graphics, textOnLine19, startX43, startY43, endX14, endY14, 20f, 562, 508);


            //////////////////////////////////

            int startX44 = x25 + width25 - 70;
            int startY44 = y25;
            DrawLine(e, startX44, startY44, Color.Black, 0, -39);

            int startX45 = x25 + width25 - 85;
            int startY45 = y25;
            DrawLine(e, startX45, startY45, Color.Black, 0, -99);

            int startX46 = x25 + width25 - 100;
            int startY46 = y25;
            DrawLine(e, startX46, startY46, Color.Black, 0, -159);

            int startX47 = x25 + width25 - 115;
            int startY47 = y25;
            DrawLine(e, startX47, startY47, Color.Black, 0, -219);

            int startX48 = x25 + width25 - 130;
            int startY48 = y25;
            DrawLine(e, startX48, startY48, Color.Black, 0, -279);

            int startX49 = x25 + width25 - 145;
            int startY49 = y25;
            DrawLine(e, startX49, startY49, Color.Black, 0, -339);

            int startX50 = x25 + width25 - 160;
            int startY50 = y25;
            DrawLine(e, startX50, startY50, Color.Black, 0, -399);

            int startX51 = x25 + width25 - 175;
            int startY51 = y25;
            DrawLine(e, startX51, startY51, Color.Black, 0, -458);

            //////////////////////////////////

            int startX52 = x3 + width3;
            int startY52 = y3 + height3 / 2;
            DrawLine(e, startX52, startY52, Color.Black, 58, 0);
            DrawLine(e, startX52 + 58, startY52, Color.Black, 12, -12);

            int startX53 = x4 + width4;
            int startY53 = y4 + height4 / 2;
            DrawLine(e, startX53, startY53, Color.Black, 58, 0);
            DrawLine(e, startX53 + 58, startY53, Color.Black, 12, -12);

            int startX54 = x5 + width5;
            int startY54 = y5 + height5 / 2;
            DrawLine(e, startX54, startY54, Color.Black, 58, 0);
            DrawLine(e, startX54 + 58, startY54, Color.Black, 12, -12);

            int startX55 = x6 + width6;
            int startY55 = y6 + height6 / 2;
            DrawLine(e, startX55, startY55, Color.Black, 58, 0);
            DrawLine(e, startX55 + 58, startY55, Color.Black, 12, -12);

            int startX56 = x7 + width7;
            int startY56 = y7 + height7 / 2;
            DrawLine(e, startX56, startY56, Color.Black, 58, 0);
            DrawLine(e, startX56 + 58, startY56, Color.Black, 12, -12);

            int startX57 = x8 + width8;
            int startY57 = y8 + height8 / 2;
            DrawLine(e, startX57, startY57, Color.Black, 58, 0);
            DrawLine(e, startX57 + 58, startY57, Color.Black, 12, -12);

            int startX58 = x9 + width9;
            int startY58 = y9 + height9 / 2;
            DrawLine(e, startX58, startY58, Color.Black, 58, 0);
            DrawLine(e, startX58 + 58, startY58, Color.Black, 12, -12);

            int startX59 = x10 + width10;
            int startY59 = y10 + height10 / 2;
            DrawLine(e, startX59, startY59, Color.Black, 58, 0);
            DrawLine(e, startX59 + 58, startY59, Color.Black, 12, -12);

            int startX60 = x11 + width11;
            int startY60 = y11 + height11 / 2;
            DrawLine(e, startX60, startY60, Color.Black, 58, 0);
            DrawLine(e, startX60 + 58, startY60, Color.Black, 12, -12);

            int startX61 = x12 + width12;
            int startY61 = y12 + height12 / 2;
            DrawLine(e, startX61, startY61, Color.Black, 58, 0);
            DrawLine(e, startX61 + 58, startY61, Color.Black, 12, -12);

            int startX62 = x27 + width27;
            int startY62 = y27 + height27 / 2;
            DrawLine(e, startX62, startY62, Color.Black, 58, 0);
            DrawLine(e, startX62 + 58, startY62, Color.Black, 12, -12);

            //////////////////////////////////

            int startX63 = x15;
            int startY63 = y15 + height15 / 2;
            DrawLine(e, startX63, startY63, Color.Black, -58, 0);
            DrawLine(e, startX63 - 58, startY63, Color.Black, -12, -12);

            int startX64 = x16;
            int startY64 = y16 + height16 / 2;
            DrawLine(e, startX64, startY64, Color.Black, -58, 0);
            DrawLine(e, startX64 - 58, startY64, Color.Black, -12, -12);

            int startX65 = x17;
            int startY65 = y17 + height17 / 2;
            DrawLine(e, startX65, startY65, Color.Black, -58, 0);
            DrawLine(e, startX65 - 58, startY65, Color.Black, -12, -12);

            int startX66 = x18;
            int startY66 = y18 + height18 / 2;
            DrawLine(e, startX66, startY66, Color.Black, -58, 0);
            DrawLine(e, startX66 - 58, startY66, Color.Black, -12, -12);

            int startX67 = x19;
            int startY67 = y19 + height19 / 2;
            DrawLine(e, startX67, startY67, Color.Black, -58, 0);
            DrawLine(e, startX67 - 58, startY67, Color.Black, -12, -12);

            int startX68 = x20;
            int startY68 = y20 + height20 / 2;
            DrawLine(e, startX68, startY68, Color.Black, -58, 0);
            DrawLine(e, startX68 - 58, startY68, Color.Black, -12, -12);

            int startX69 = x21;
            int startY69 = y21 + height21 / 2;
            DrawLine(e, startX69, startY69, Color.Black, -58, 0);
            DrawLine(e, startX69 - 58, startY69, Color.Black, -12, -12);

            int startX70 = x22;
            int startY70 = y22 + height22 / 2;
            DrawLine(e, startX70, startY70, Color.Black, -58, 0);
            DrawLine(e, startX70 - 58, startY70, Color.Black, -12, -12);

            int startX71 = x23;
            int startY71 = y23 + height23 / 2;
            DrawLine(e, startX71, startY71, Color.Black, -58, 0);
            DrawLine(e, startX71 - 58, startY71, Color.Black, -12, -12);

            int startX72 = x13;
            int startY72 = y13 + height13 / 2;
            DrawLine(e, startX72, startY72, Color.Black, -58, 0);
            DrawLine(e, startX72 - 58, startY72, Color.Black, -12, -12);

            int startX73 = x28;
            int startY73 = y28 + height28 / 2;
            DrawLine(e, startX73, startY73, Color.Black, -58, 0);
            DrawLine(e, startX73 - 58, startY73, Color.Black, -12, -12);
        }

        private void DrawLine(PaintEventArgs e, int startX, int startY, Color color, int offsetX, int offsetY)
        {
            using (Pen linePen = new Pen(color, 2))
            {
                int endX = startX + offsetX;
                int endY = startY + offsetY;

                e.Graphics.DrawLine(linePen, startX, startY, endX, endY);
            }
        }

        private void DrawArrowLine(PaintEventArgs e, int startX, int startY, Color color, int offsetX, int offsetY)
        {
            using (Pen arrowPen = new Pen(color, 3))
            {
                // Создаем кисть для закрашивания стрелки того же цвета, что и линия
                using (SolidBrush arrowBrush = new SolidBrush(color))
                {
                    int endX = startX + offsetX;
                    int endY = startY + offsetY;

                    e.Graphics.DrawLine(arrowPen, startX, startY, endX, endY);

                    // Вычисляем угол наклона стрелки
                    float angle = (float)Math.Atan2(endY - startY, endX - startX);

                    // Создаем капюшон (стрелку) для линии
                    AdjustableArrowCap arrowCap = new AdjustableArrowCap(4, 4);
                    arrowPen.CustomEndCap = arrowCap;

                    // Рисуем стрелку на конце линии
                    e.Graphics.DrawLine(arrowPen, startX, startY, endX, endY);
                }
            }
        }
        private void DrawTextOnLine(Graphics g, string text, int startX, int startY, int endX, int endY)
        {
            if (string.IsNullOrEmpty(text))
                return;

            Font font = new Font("Arial", 12);
            SizeF textSize = g.MeasureString(text, font);

            // Рассчитываем координаты для размещения текста
            float textX = (startX + endX - textSize.Width) / 2;
            float textY = (startY + endY - textSize.Height) / 2;

            g.DrawString(text, font, Brushes.Black, textX, textY);
            font.Dispose();
        }

        private void DrawTextOnLine2(Graphics g, string text, int startX, int startY, int endX, int endY, float distanceFromEdge, float textX, float textY)
        {
            if (string.IsNullOrEmpty(text))
                return;

            Font font = new Font("Arial", 14);
            SizeF textSize = g.MeasureString(text, font);

            float totalLength = (float)Math.Sqrt(Math.Pow(endX - startX, 2) + Math.Pow(endY - startY, 2));
            float ratio = (totalLength - distanceFromEdge) / totalLength;

            float calculatedTextX = startX + (endX - startX) * ratio - textSize.Width / 2;
            float calculatedTextY = startY + (endY - startY) * ratio - textSize.Height / 2;

            float finalTextX = (textX == 0) ? calculatedTextX : textX;
            float finalTextY = (textY == 0) ? calculatedTextY : textY;

            g.DrawString(text, font, Brushes.Black, finalTextX, finalTextY);
            font.Dispose();
        }


        private void DrawText(Graphics g, SolidBrush textBrush, string text, int x, int y, int width, int height)
        {
            Font font = new Font("Arial", 10, FontStyle.Bold);
            float textX = x + width - g.MeasureString(text, font).Width;  // Центрирование по горизонтали
            float textY = y + (height - g.MeasureString(text, font).Height) / 2;  // Центрирование по вертикали
            g.DrawString(text, font, textBrush, textX, textY);
            font.Dispose();
        }

        [STAThread]
        static void MyMain()
        {
            // Создаем экземпляр формы и запускаем приложение
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OpisanieSxemForm());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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

        private void SetInitialFont()
        {
            // Устанавливаем начальный шрифт и размер текста
            textBoxText.Font = new System.Drawing.Font("Arial", 10); // Например, Arial, размер 10
        }
    }
}

