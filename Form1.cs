using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_11._1
{
    public partial class Form1 :Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }
        public class Student
        {   public string name;
            public double rost;
            private double ves = 40;

            public double GetEat ()
            {

                return ves;
            }
            public double SetEat (int eda, int ves)
            {
                if (eda > 5 && eda < 10)
                {
                    this.rost = rost - 1;
                    this.ves += eda * 0.7;
                    
                }
                else if(eda>10)
                {
                    this.rost = rost - 2;
                    this.ves += eda * 0.5;
                }
               
                return ves;
            } 
        }
        private void Form1_Load (object sender, EventArgs e)
        {
           

        }

        private void button1_Click (object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.name = textBox1.Text;
            student1.rost = (double) (numericUpDown1.Value);
           
            student1.SetEat((int) numericUpDown3.Value, (int) numericUpDown2.Value);
            MessageBox.Show(string.Format("Студент:{0}\nРост:{1}\nВес:{2}\nСъеденной еды: {3}кг", student1.name, student1.rost, student1.GetEat(), (int) numericUpDown3.Value));

        }
    }
}
