using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predicate_Task
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<int> randomNumberList;

        public Form1()
        {
            InitializeComponent();          
            randomNumberList = new List<int>();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            randomNumberList.Clear();
            for (int i = 0; i < 100; i++)
            {
                int randNum = random.Next(100);
                randomNumberList.Add(randNum);
            }
            foreach (int num in randomNumberList)
                listBox1.Items.Add(num.ToString());
        }

        //Add lambda filter
        private void LambdaFilter(Predicate<int> filter)
        {
            listBox2.Items.Clear();

            //List<int> filtered = allNumbers.FindAll()
        }

        private void btnEvens_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (int num in randomNumberList.FindAll(x => x % 2 == 0))
                listBox2.Items.Add(num.ToString());
        }
  
        private void btnUnderTen_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (int num in randomNumberList.FindAll(x => x < 10))
                listBox2.Items.Add(num.ToString());
        }       
    }
}
