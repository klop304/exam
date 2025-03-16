using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool prov = false;

        private void button1_Click(object sender, EventArgs e)
        {
            // Переключение состояния формы 
            prov = !prov;
            // Форма в состоянии проверки
            if (prov)
            {
                button1.Text = "Начать снова";
                // Забираем  данные введенный пользователем
                
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);
                
                if ((a + c > b) && (c + b > a) && (a + b > c))
                    // если треуголник равносторонний
                    if (a == b && b == c)
                        label1.Text = " треугольник \n равносторонний";
                    // если треугольник равнобедренный
                    else if (a == c || b == c || a == b)
                        label1.Text = " треугольник \n равнобедренный";
                    // иначе треугольник разносторонний
                    else
                        label1.Text = " треугольник \n разносторонний";
                // Если треугольника не существует
                else
                    label1.Text = " треугольник \n не существует";
            }


            // Если была нажата кнопка "Начать заново"
            else
            {
                
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label1.Text = "Введите длины сторон треугольника";
                button1.Text = "Проверить";
            }
        }
    }
}
    

