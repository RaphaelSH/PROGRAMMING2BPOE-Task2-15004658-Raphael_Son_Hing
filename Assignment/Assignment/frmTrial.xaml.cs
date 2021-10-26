using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assignment
{
    /// <summary>
    /// Interaction logic for frmTrial.xaml
    /// </summary>
    public partial class frmTrial : Window
    {
        db_connection db = new db_connection();
        public frmTrial()
        {
            InitializeComponent();
            db.customerConn = new OleDbConnection(db.connParam);

        }
        int intWeeksLeft;

        String strCodeM1, strNameM1;
        String strCodeM2, strNameM2;
        String strCodeM3, strNameM3;
        String strCodeM4, strNameM4;
        String strCodeM5, strNameM5;

        int intCreditsM1, intHoursM1, intSumM1;
        int intCreditsM2, intHoursM2, intSumM2;
        int intCreditsM3, intHoursM3, intSumM3;
        int intCreditsM4, intHoursM4, intSumM4;
        int intCreditsM5, intHoursM5, intSumM5;

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            frmResult res = new frmResult();
            res.ShowDialog();
        }

        String ActivateT1 = "N";
        String ActivateT2 = "N";
        String ActivateT3 = "N";
        String ActivateT4 = "N";
        String ActivateT5 = "N";


        String strDisplay;
        private void btnSetM1_Click(object sender, RoutedEventArgs e)
        {
            if (this.txtCodeM1.Text.Equals("")) //Prevents blank data entries
            {
                MessageBox.Show("Enter Code, for example, PROG6212");
            }
            else if (this.txtNameM1.Text.Equals(""))
            {
                MessageBox.Show("Enter Name, for example, Programming 2B");
            }
            else
            {
                if (this.numHoursDoneM1H1.Text.Equals(""))
                {
                    this.numHoursDoneM1H1.Text = "0";
                }
                if (this.numHoursDoneM1H2.Text.Equals(""))
                {
                    this.numHoursDoneM1H2.Text = "0";
                }
                if (this.numHoursDoneM1H3.Text.Equals(""))
                {
                    this.numHoursDoneM1H3.Text = "0";
                }
                if (this.numHoursDoneM1H4.Text.Equals(""))
                {
                    this.numHoursDoneM1H4.Text = "0";
                }
                strCodeM1 = this.txtCodeM1.Text;
                strNameM1 = this.txtNameM1.Text;
                intCreditsM1 = Convert.ToInt32(this.numCreditsM1.Text);
                intHoursM1 = Convert.ToInt32(this.numHoursM1.Text); ;
                MessageBox.Show("Module set successfully");
                intSumM1 = Convert.ToInt32(this.numHoursDoneM1H1.Text) + Convert.ToInt32(this.numHoursDoneM1H2.Text) + Convert.ToInt32(this.numHoursDoneM1H3.Text) + Convert.ToInt32(this.numHoursDoneM1H4.Text);
                this.tabPage1.Header = strCodeM1;
                ActivateT1 = "Y";
            }
        }
        private void btnSetM2_Click(object sender, RoutedEventArgs e)
        {
            if (this.txtCodeM2.Text.Equals("")) //Prevents blank data entries
            {
                MessageBox.Show("Enter Code, for example, PROG6212");
            }
            else if (this.txtNameM2.Text.Equals(""))
            {
                MessageBox.Show("Enter Name, for example, Programming 2B");
            }
            else
            {
                if (this.numHoursDoneM2H1.Text.Equals(""))
                {
                    this.numHoursDoneM2H1.Text = "0";
                }
                if (this.numHoursDoneM2H2.Text.Equals(""))
                {
                    this.numHoursDoneM2H2.Text = "0";
                }
                if (this.numHoursDoneM2H3.Text.Equals(""))
                {
                    this.numHoursDoneM2H3.Text = "0";
                }
                if (this.numHoursDoneM2H4.Text.Equals(""))
                {
                    this.numHoursDoneM2H4.Text = "0";
                }
                strCodeM2 = this.txtCodeM2.Text;
                strNameM2 = this.txtNameM2.Text;
                intCreditsM2 = Convert.ToInt32(this.numCreditsM2.Text);
                intHoursM2 = Convert.ToInt32(this.numHoursM2.Text); ;
                MessageBox.Show("Module set successfully");
                intSumM2 = Convert.ToInt32(this.numHoursDoneM2H1.Text) + Convert.ToInt32(this.numHoursDoneM2H2.Text) + Convert.ToInt32(this.numHoursDoneM2H3.Text) + Convert.ToInt32(this.numHoursDoneM2H4.Text);
                this.tabPage2.Header = strCodeM2;
                ActivateT2 = "Y";
            }
        }

        private void btnSetM3_Click(object sender, RoutedEventArgs e)
        {
            if (this.txtCodeM3.Text.Equals("")) //Prevents blank data entries
            {
                MessageBox.Show("Enter Code, for example, PROG6212");
            }
            else if (this.txtNameM3.Text.Equals(""))
            {
                MessageBox.Show("Enter Name, for example, Programming 2B");
            }
            else
            {
                if (this.numHoursDoneM3H1.Text.Equals(""))
                {
                    this.numHoursDoneM3H1.Text = "0";
                }
                if (this.numHoursDoneM3H2.Text.Equals(""))
                {
                    this.numHoursDoneM3H2.Text = "0";
                }
                if (this.numHoursDoneM3H3.Text.Equals(""))
                {
                    this.numHoursDoneM3H3.Text = "0";
                }
                if (this.numHoursDoneM3H4.Text.Equals(""))
                {
                    this.numHoursDoneM3H4.Text = "0";
                }
                strCodeM3 = this.txtCodeM3.Text;
                strNameM3 = this.txtNameM3.Text;
                intCreditsM3 = Convert.ToInt32(this.numCreditsM3.Text);
                intHoursM3 = Convert.ToInt32(this.numHoursM3.Text); ;
                MessageBox.Show("Module set successfully");
                intSumM3 = Convert.ToInt32(this.numHoursDoneM3H1.Text) + Convert.ToInt32(this.numHoursDoneM3H2.Text) + Convert.ToInt32(this.numHoursDoneM3H3.Text) + Convert.ToInt32(this.numHoursDoneM3H4.Text);
                this.tabPage3.Header = strCodeM3;
                ActivateT3 = "Y";
            }
        }

        private void btnSetM4_Click(object sender, RoutedEventArgs e)
        {
            if (this.txtCodeM4.Text.Equals("")) //Prevents blank data entries
            {
                MessageBox.Show("Enter Code, for example, PROG6212");
            }
            else if (this.txtNameM4.Text.Equals(""))
            {
                MessageBox.Show("Enter Name, for example, Programming 2B");
            }
            else
            {
                if (this.numHoursDoneM4H1.Text.Equals(""))
                {
                    this.numHoursDoneM4H1.Text = "0";
                }
                if (this.numHoursDoneM4H2.Text.Equals(""))
                {
                    this.numHoursDoneM4H2.Text = "0";
                }
                if (this.numHoursDoneM4H3.Text.Equals(""))
                {
                    this.numHoursDoneM4H3.Text = "0";
                }
                if (this.numHoursDoneM4H4.Text.Equals(""))
                {
                    this.numHoursDoneM4H4.Text = "0";
                }
                strCodeM4 = this.txtCodeM4.Text;
                strNameM4 = this.txtNameM4.Text;
                intCreditsM4 = Convert.ToInt32(this.numCreditsM4.Text);
                intHoursM4 = Convert.ToInt32(this.numHoursM4.Text); ;
                MessageBox.Show("Module set successfully");
                intSumM4 = Convert.ToInt32(this.numHoursDoneM4H1.Text) + Convert.ToInt32(this.numHoursDoneM4H2.Text) + Convert.ToInt32(this.numHoursDoneM4H3.Text) + Convert.ToInt32(this.numHoursDoneM4H4.Text);
                this.tabPage4.Header = strCodeM4;
                ActivateT4 = "Y";
            }
        }

        private void btnSetM5_Click(object sender, RoutedEventArgs e)
        {
            if (this.txtCodeM5.Text.Equals("")) //Prevents blank data entries
            {
                MessageBox.Show("Enter Code, for example, PROG6212");
            }
            else if (this.txtNameM5.Text.Equals(""))
            {
                MessageBox.Show("Enter Name, for example, Programming 2B");
            }
            else
            {
                if (this.numHoursDoneM5H1.Text.Equals(""))
                {
                    this.numHoursDoneM5H1.Text = "0";
                }
                if (this.numHoursDoneM5H2.Text.Equals(""))
                {
                    this.numHoursDoneM5H2.Text = "0";
                }
                if (this.numHoursDoneM5H3.Text.Equals(""))
                {
                    this.numHoursDoneM5H3.Text = "0";
                }
                if (this.numHoursDoneM5H4.Text.Equals(""))
                {
                    this.numHoursDoneM5H4.Text = "0";
                }
                strCodeM5 = this.txtCodeM5.Text;
                strNameM5 = this.txtNameM5.Text;
                intCreditsM5 = Convert.ToInt32(this.numCreditsM5.Text);
                intHoursM5 = Convert.ToInt32(this.numHoursM5.Text); ;
                MessageBox.Show("Module set successfully");
                intSumM5 = Convert.ToInt32(this.numHoursDoneM5H1.Text) + Convert.ToInt32(this.numHoursDoneM5H2.Text) + Convert.ToInt32(this.numHoursDoneM5H3.Text) + Convert.ToInt32(this.numHoursDoneM5H4.Text);
                this.tabPage5.Header = strCodeM5;
                ActivateT5 = "Y";
            }
        }

        private void btnActivate_Click(object sender, RoutedEventArgs e)
        {
            strDisplay = "Thank you for using this app " + this.txtName.Text + ".\nYour resullts are as follows:";
            intWeeksLeft = Convert.ToInt32(this.numWeeksLeft.Text);
            if (intWeeksLeft.Equals(0))
            {
                MessageBox.Show("If there are no weeks left you are out of time");
            }
            else
            {
                if (ActivateT1.Equals("Y"))
                {
                    double dblTotalM1 = ((intCreditsM1 * 10) / intWeeksLeft) - intHoursM1;
                    strDisplay += "\n\n" + strCodeM1 + " or " + strNameM1 + " has " + dblTotalM1 + " hours left.\nHours recorded: " + intSumM1;
                }
                if (ActivateT2.Equals("Y"))
                {
                    double dblTotalM2 = ((intCreditsM2 * 10) / intWeeksLeft) - intHoursM2;
                    strDisplay += "\n\n" + strCodeM2 + " or " + strNameM2 + " has " + dblTotalM2 + " hours left.\nHours recorded: " + intSumM2;
                }
                if (ActivateT3.Equals("Y"))
                {
                    double dblTotalM3 = ((intCreditsM3 * 10) / intWeeksLeft) - intHoursM3;
                    strDisplay += "\n\n" + strCodeM3 + " or " + strNameM3 + " has " + dblTotalM3 + " hours left.\nHours recorded: " + intSumM3;
                }
                if (ActivateT4.Equals("Y"))
                {
                    double dblTotalM4 = ((intCreditsM4 * 10) / intWeeksLeft) - intHoursM4;
                    strDisplay += "\n\n" + strCodeM4 + " or " + strNameM4 + " has " + dblTotalM4 + " hours left.\nHours recorded: " + intSumM4;
                }
                if (ActivateT5.Equals("Y"))
                {
                    double dblTotalM5 = ((intCreditsM5 * 10) / intWeeksLeft) - intHoursM5;
                    strDisplay += "\n\n" + strCodeM5 + " or " + strNameM5 + " has " + dblTotalM5 + " hours left.\nHours recorded: " + intSumM5;
                }
                this.lblDisplay.Content = strDisplay;
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            ActivateT1 = "N";
            ActivateT2 = "N";
            ActivateT3 = "N";
            ActivateT4 = "N";
            ActivateT5 = "N";
            this.lblDisplay.Content = "";
            this.txtCodeM1.Text = "";
            this.txtNameM1.Text = "";
            this.numCreditsM1.Text = "0";
            this.numHoursM1.Text = "0";
            this.numHoursDoneM1H1.Text = "0";
            this.numHoursDoneM1H2.Text = "0";
            this.numHoursDoneM1H3.Text = "0";
            this.numHoursDoneM1H4.Text = "0";
            this.txtCodeM2.Text = "";
            this.txtNameM2.Text = "";
            this.numCreditsM2.Text = "0";
            this.numHoursM2.Text = "0";
            this.numHoursDoneM2H1.Text = "0";
            this.numHoursDoneM2H2.Text = "0";
            this.numHoursDoneM2H3.Text = "0";
            this.numHoursDoneM2H4.Text = "0";
            this.txtCodeM3.Text = "";
            this.txtNameM3.Text = "";
            this.numCreditsM3.Text = "0";
            this.numHoursM3.Text = "0";
            this.numHoursDoneM3H1.Text = "0";
            this.numHoursDoneM3H2.Text = "0";
            this.numHoursDoneM3H3.Text = "0";
            this.numHoursDoneM3H4.Text = "0";
            this.txtCodeM4.Text = "";
            this.txtNameM4.Text = "";
            this.numCreditsM4.Text = "0";
            this.numHoursM4.Text = "0";
            this.numHoursDoneM4H1.Text = "0";
            this.numHoursDoneM4H2.Text = "0";
            this.numHoursDoneM4H3.Text = "0";
            this.numHoursDoneM4H4.Text = "0";
            this.txtCodeM5.Text = "";
            this.txtNameM5.Text = "";
            this.numCreditsM5.Text = "0";
            this.numHoursM5.Text = "0";
            this.numHoursDoneM5H1.Text = "0";
            this.numHoursDoneM5H2.Text = "0";
            this.numHoursDoneM5H3.Text = "0";
            this.numHoursDoneM5H4.Text = "0";
            this.tabPage1.Header = "Module 1";
            this.tabPage2.Header = "Module 2";
            this.tabPage3.Header = "Module 3";
            this.tabPage4.Header = "Module 4";
            this.tabPage5.Header = "Module 5";
            intSumM1 = 0;
            intSumM2 = 0;
            intSumM3 = 0;
            intSumM4 = 0;
            intSumM5 = 0;
        }

        private void btnDatanase_Click(object sender, RoutedEventArgs e)
        {
             db.customerConn.Open();
                db.oleDbCmd.Connection = db.customerConn;
                db.oleDbCmd.CommandText = "insert into tblStudent(name, password) values (" +
                    this.txtNameM1.Text + ",'" +
                    this.txtNameM1.Text + "');";
                int temp = db.oleDbCmd.ExecuteNonQuery();
                if (temp > 0)
                {
                    this.txtNameM1.Text = "";
                    this.txtNameM1.Text = "";

                    MessageBox.Show("Student Successfuly Added!!!", "SAVED");
                }

                else
                {
                    MessageBox.Show("Record Fail to Added");
                }

                db.customerConn.Close();
        }
    }
}
