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
        Predicate<int> numTestPredicate;

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

        private void btnEvens_Click(object sender, EventArgs e)
        {
            numTestPredicate = new Predicate<int>(isEven);
            displayPredicatedNumbers(listBox2);
        }
  
        private void btnUnderTen_Click(object sender, EventArgs e)
        {
            numTestPredicate = new Predicate<int>(isUnderTen);
            displayPredicatedNumbers(listBox2);
        }

        private bool isEven(int inputInterger)
        {
            bool isAnOddNumber = ((inputInterger % 2) == 0);
            return isAnOddNumber;
        }

        private bool isUnderTen(int inputInterger)
        {
            bool numIsUnderTen = false;
            if (inputInterger < 10)
                numIsUnderTen = true;
            return numIsUnderTen;
        }

        private void displayPredicatedNumbers(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (int num in randomNumberList.FindAll(numTestPredicate))
                listBox2.Items.Add(num.ToString());            
        }
    }
}
