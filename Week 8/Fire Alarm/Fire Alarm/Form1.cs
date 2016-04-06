using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_Alarm
{
    public partial class Form1 : Form
    {
        FireAlarmSubject fireSubject;
        InstructionsObserver instObserver;
        AlarmObserver almObserver;
        EFireCategory fireCategory;

        public Form1()
        {
            InitializeComponent();
            fireSubject = new FireAlarmSubject();
            instObserver = new InstructionsObserver(fireSubject);
            almObserver = new AlarmObserver(fireSubject);
        }
        
        private void btnFireAlarm_Click(object sender, EventArgs e)
        {
            if (rdoMinor.Checked)
                fireCategory = EFireCategory.MINOR;
            if (rdoSerious.Checked)
                fireCategory = EFireCategory.SERIOUS;
            if (rdoInferno.Checked)
                fireCategory = EFireCategory.INFERNO;

            fireSubject.OnFireEvent(fireCategory);
        }
    }
}
