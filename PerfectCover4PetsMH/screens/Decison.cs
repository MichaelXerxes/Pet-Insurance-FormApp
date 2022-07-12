using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectCover4PetsMH.screens
{
    public partial class frmDecison : Form
    {
        public frmDecison Current;// current form object
        public frmDecison()
        {//constructor
            InitializeComponent();
            Current = this;
            this.ControlBox = false;
            cmBoxNumberPets.SelectedIndex = 0;
            btnMutli.Enabled = false;
            timerMultiBtn.Start();
            timerMultiBtn.Interval = 2000;
        }


        private void btnSIngle_Click(object sender, EventArgs e)
        {// start quote(new HolderDetails form) for one pet only
            
            frmHolderDetails frmHolder = new frmHolderDetails(1);
            Current.Close();
            frmHolder.Show();
        }

        private void btnMutli_Click(object sender, EventArgs e)
        {// start quote(new HolderDetails form) for one or maxium 10 pets

            frmHolderDetails frmHolder = new frmHolderDetails(numberOfPets());
            Current.Close();
            frmHolder.Show();
        }
        private int numberOfPets()
        {       //method to assign number of pets dusing comboBox selected index and return int number
            int number;
            number = cmBoxNumberPets.SelectedIndex+1;

            return number;
        }

        private void timerMultiBtn_Tick(object sender, EventArgs e)
        {// timer to check is user change combo Box index . If is 0 then button stay enabled = false
            
            if (cmBoxNumberPets.SelectedIndex!=0)
            {
                btnMutli.Enabled = true;
              
            }
            else if (cmBoxNumberPets.SelectedIndex==0)
            {
                btnMutli.Enabled = false;
            }
        }
    }
}
