using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //В лейбел label1 занесли данные о ФИО 0-го пользователя
            //Из таблицы пользователей
          //Лэйбел.Свойство текст =
          //Класс-Контекст.Название модели.Название таблицы.Преобразовать в список[взять 0-й элемнет].ФИО
            label1.Text = AppContext.DB.User.ToList()[0].FIO;
      
            
            //В источник данных bindingSource1 добавляются данные из таблицы User
            bindingSource1.DataSource = AppContext.DB.User.ToList();
        }
    }
}
