using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Прога_с_MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Каков Ваш вердикт", "Подумой", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    label1.Text = "Вы выбрали Да";
            //}
            //else
            //{
            //    label1.Text = "Вы выбрали Нет";
            //}
            
            //label1.Text = MessageBox.Show("Каков Ваш вердикт", "Подумой", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes ? "Вы выбрали Да" : "Вы выбрали Нет";
            
            //DialogResult result = MessageBox.Show("Каков Ваш вердикт", "Подумой", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            DialogResult result = MessageBox.Show("Каков Ваш вердикт", "Подумой", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                label1.Text = "Вы выбрали Да";

            }
            else if (result == DialogResult.No)
            {
                label1.Text = "Вы выбрали Нет";
            }
            else
                    {
                label1.Text = "Вы отменет";
            }
                
        }

    }
}
