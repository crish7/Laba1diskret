using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laba1diskret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        public bool prov(double x, double y)//Проверка заштрихованой области 1
        {
            if (x >= 0 && y <= 3 && y >= x)
            {
                return true;
            }
            else return false;
        }
        public bool prov1(double x, double y)//Проверка заштрихованой области 2
        {
            if (y <= 0 && x <= 3 && y >= -x)
            {
                return true;
            }
            else return false;
        }
        public bool prov2(double x, double y)//Проверка заштрихованой области 3
        {
            if (x <= 0 && y >= -3 && y <= x)
            {
                return true;
            }
            else return false;
        }
        public bool prov3(double x, double y)//Проверка заштрихованой области 4
        {
            if (y >= 0 && x >= -3 && y <= -x)
            {
                return true;
            }
            else return false;
        }  
                
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox1.Text);//инициализация переменной 
                double y = double.Parse(textBox2.Text);//инициализация переменной 
             if ((prov(x,y)==true)||(prov1(x,y)==true)||(prov2(x,y)==true)||(prov3(x,y)==true))//Вызов функций
                    MessageBox.Show("Данная точка ("+x+","+y+") входит в заштрихованую площадь", "Решение", MessageBoxButtons.OK);//выыод окна с результатом
                else
                 MessageBox.Show("Данная точка (" + x + "," + y + ") не входит в заштрихованую площадь", "Решение", MessageBoxButtons.OK);

            }
            catch (FormatException)//обработка исключенных ситуаций
            {
                MessageBox.Show("Ошибка.Вводите цифры", "Ошибка", MessageBoxButtons.OK);
            }
            }
    }
}
