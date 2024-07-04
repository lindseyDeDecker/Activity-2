/*
 * Lindsey DeDecker
 * CST - 150
 * Activity 2
 * July 4, 2024
 */


using System.Diagnostics.Eventing.Reader;

namespace CST_150_Activity_2
{
    public partial class FrmSeconds : Form
    {
        public FrmSeconds()
        {
            InitializeComponent();
            lblResults.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserEntry_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Event Handler to Evaluate Seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageSecondsEventHandler(object sender, EventArgs e)
        {
            //Declare and Initialize
            int seconds = 0;            //Declare the value users entered in seconds
            //Working with Constants in c#
            const int SecondsInMinutes = 60;
            const int SecondsInHours = 3600;
            const int SecondsInDays = 86400;

            //Make sure the label is not visible
            lblResults.Visible = false;
            //Default color to black for results
            lblResults.ForeColor = Color.Black;

            //Test to determine if integer was entered correctly by user
            //if try to parse string to int is successful continue else show message to user
            if (int.TryParse(txtUserEntry.Text, out seconds) )
                {

            }
            else
            {
                //This is the code block to be executed if the user did not put an int in
                lblResults.Text = "Please enter an int to continue...";
                lblResults.ForeColor = Color.Red;
                lblResults.Visible = true;
            }

            if(int.TryParse(txtUserEntry.Text, out seconds) )
            {
                //This block of code is where all our buisness logic will be placed.
                //In future classes we will put this code (buisness logic in the buisness layer
                //Practice with nested if statements
                if(seconds >= SecondsInMinutes)
                        {
                    //if we are here we know the user has entered a value that we can, at minimum
                    // display how many minutes are in the seconds entered.
                    lblResults.Text = string.Format("There are {0:#,#} minute(s) in {1:#,#} seconds. \n", seconds / SecondsInMinutes, seconds);
                    lblResults.Visible = true;

                }
               else
                    {
                    //if we are here we know the user did not enter a value that meets the mintime requirements of at least 60
                    //ask the user to enter a valid number
                    lblResults.Text = "Please enter an integer larger than 59.";
                    lblResults.ForeColor = Color.Red;
                    lblResults.Visible= true;
                }
                //------------------------------------------
                //Now that we know there were minutes - test for hours using nested if statements
                //nested statements stop code from being executed if there is no need. 
                if(seconds >= SecondsInHours)
                {
                    //Display how many hours are in the seconds entered.
                    lblResults.Text += string.Format("There are {0:#,#} hours in {1:#,#} seconds. \n", seconds / SecondsInHours, seconds);

                    //Now we can test for days using nested if statements
                    if(seconds >= SecondsInDays)
                    {
                        //Display how many days are in the seconds entered
                        lblResults.Text += string.Format("There are {0:#,#} days in {1:#,#} seconds. \n", seconds / SecondsInDays, seconds);
                    }
                }
            }

        }
    }
}
