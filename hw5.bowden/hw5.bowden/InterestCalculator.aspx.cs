using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hw5.bowden
{
    public partial class InterestCalculator : System.Web.UI.Page
    {

        //class level variables
        double loanAmount = 0; 
        double loanTerm = 0;
        double interestRate = 0;
        
        //alert function
        private void MessageBoxShow(string message)
        {
            //write javascript to the client to create an alert
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "');", true);
        }//end MessageBoxShow

        //make sure LoanAmount is a valid double
        private string ValidateLoanAmount(string InputString)
        {
            //main try catch block
            try
            {
                //convert our input string to a double value
                loanAmount = Double.Parse(InputString);

                //prevent a zero dollar loan amount
                if (loanAmount == 0)
                {
                    throw new System.Exception("zero dollar loanAmount");
                }

                //return an empty string to indicate success.
                return "";
            }
            catch
            {
                //return an error message
                return "Loan Amount is not valid\\n";
            }
        }//end ValidateLoanAmount

        //make sure that InterestRate is valid double
        private string ValidateInterestRate(string InputString)
        {
            //main try catch block
            try
            {
                //convert our input string to a double value
                interestRate = Double.Parse(InputString);

                //return an empty string to indicate success.
                return "";
            }
            catch
            {
                //return an error message
                return "Interest Rate is not valid\\n";
            }
        }//end ValidateInterestRate

        //make sure LoanTerm is a valid double 
        private string ValidateLoanTerm(string InputString)
        {
            //main try catch block
            try
            {
                //convert our input string to a double value
                loanTerm = Double.Parse(InputString);

                //loanTerm must be greater than zero because it represent a period of time
                if(loanTerm<= 0)
                {
                    throw new System.Exception();
                }

                //return an empty string to indicate success.
                return "";
            }
            catch
            {
                //return an error message
                return "Loan Term is not valid\\n";
            }
        }//end ValidateLoanTerm

        //runs all three validate procedures
        private bool ValidateAll()
        {
            //start with a blank alert message
            string alertMessage = "";

            //run each individual validation procedure
            alertMessage = ValidateLoanAmount(this.txtLoanAmount.Text);
            alertMessage += ValidateLoanTerm(this.txtLoanTerm.Text);
            alertMessage += ValidateInterestRate(this.txtInterestRate.Text);

            //determine if we had an error
            if (alertMessage.Length > 0)
            {
                MessageBoxShow(alertMessage);
                return false;
            }
            else
            {
                return true;
            }

        }//end ValidateAll

        //transfer page to Help Page
        protected void btnHelp_Click(object sender, EventArgs e)
        {
            Response.Redirect("Help.aspx?Scr=");
        }//end btn Help_Click

        //calculate 
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            //set the incoming data and validate the values
            if (ValidateAll())
            {
                //perform the loan calculation
                double loanM = (interestRate / 1200.0);
                double numberMonths = loanTerm * 12;
                double negNumberMonths = 0 - numberMonths;
                double monthlyPayment = loanAmount  * loanM / (1 - System.Math.Pow((1 + loanM), negNumberMonths));

                //write the payment to the web page
                txtMonthlyPayment.Text = String.Format("{0:C2}", monthlyPayment);
            }
        }//end btn Calculate_Click
    }
}