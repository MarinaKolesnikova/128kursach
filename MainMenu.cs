using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GoodVision
{
    public partial class MainMenu : Form
    {
        
		public MainMenu()
        {
            InitializeComponent();
           
        }
		UserClass User=new UserClass() ;
		GoodVisionClass MyVision;
		

		private void StaticticButton_Click(object sender, EventArgs e)  // просмотр статистики
        {
            StatisticForm statForm = new StatisticForm();
            statForm.Show();
            this.Hide();

        }

        private void VisionCheckButton_Click(object sender, EventArgs e) // переход к форме тестирования
        {
            VisionCheck VChForm = new VisionCheck();
            VChForm.Show();
            this.Hide();
        }


        // вызываем помощь для главного меню
        private void HelpButton_Click(object sender, EventArgs e) 
        {
            HellpMessage help = new HellpMessage();
            help.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            FileStream session = new FileStream("session.txt", FileMode.Open, FileAccess.Read);
            if (session != null)
            {
                StreamReader reader = new StreamReader(session);
                User.Nick = reader.ReadToEnd();
                session.Close();
            }
            //считать данные из файла данной сессии (имя)
            //открыть файл по имени пользователья с его данными

            HelloLab.Text = "Вітаємо, " + User.Nick;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      

      

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.eye1;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

            pictureBox1.Image = Properties.Resources.eye2;
        }
    }
}
