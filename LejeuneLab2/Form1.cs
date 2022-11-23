using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LejeuneLab2
{
    public partial class frmGregLab : Form
    {
        /* Gregory Lejuene, October 3rd 2022
        The purpose of this lab is to flex the git muscle!
        */
        public frmGregLab()
        {
            InitializeComponent();
            txtNumber.Select();
        }

        
        private void btnExit_Click(object sender, EventArgs e)
               //This event closes the application when Exit is selected
        {
        this.Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
                //When the picture button is selected it makes the selected image visable and ensures the info is hidden
        {
        picSkiing.Visible = true;
        lblInfo.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
                //Reset button will clear all text boxes, make the picture and info invisable, empty string the answer label, and select the top text box
        {
            txtMultiplier.Clear();
            txtNumber.Clear();
            picSkiing.Visible=false;
            txtNumber.Select();
            lblAnswerOutput.Text ="";
        }

        private void btnData_Click(object sender, EventArgs e)
                //Data button will show details about my skiing experience, and hide the picture if neccessary
        {
            string infoTxt = "My topic is "+lblTopic.Text+".\n\nUntil Covid happened I skied regularly at Poley Mountain. I have traveled to Quebec and New Hampshire to ski.\n\nI'm hoping to get back to it soon this year as it's great exercise and fun.";
            lblInfo.Text = infoTxt;
            lblInfo.Visible=true;
            picSkiing.Visible = false;
 
        }
        private void picSkiing_Click(object sender, EventArgs e)
                //When picture of the ski slope is selected, show a message box detailing the picture
        {
            MessageBox.Show("Some folks riding the slopes","Gregory Lejeune");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
               //When Calculate button is selected, performs the neccessary math to multiply the value entered by user in Number and Multiplier text box
        {
            int numberValue = Convert.ToInt32(txtNumber.Text);
            int multiplierValue = Convert.ToInt32(txtMultiplier.Text);
            int answerValue = numberValue*multiplierValue;
            lblAnswerOutput.Text = answerValue.ToString();

        }

        private void btnHide_Click(object sender, EventArgs e)
               //When Hide button is selected, ensures that picture and info that displays when Data button is selected is properly hidden
        {
            picSkiing.Visible = false;
            lblInfo.Visible = false;
        }
    }
}
