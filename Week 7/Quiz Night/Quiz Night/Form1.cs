using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Night
{
    public partial class Form1 : Form
    {
        ScoreManager scoreManager;
        
        public Form1()
        {
            InitializeComponent();
            scoreManager = new ScoreManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int correct = Convert.ToInt16(txtCorrectInput.Text);
            int incorrect = Convert.ToInt16(txtIncorrectInput.Text);
            int teamType = 0;
            if(rdoAdult.Checked)
                teamType = 0;
            if (rdoChild.Checked)
                teamType = 1;
            scoreManager.selectScoreComputer(teamType);
            lblComputedScore.Text = scoreManager.computeScore(correct, incorrect);
        }
    }
}
