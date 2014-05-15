using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotenrechnerII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            //tooltip section start
            
            ToolTip RealPoints = new ToolTip();
            ToolTip maxPoints = new ToolTip();
            ToolTip minPointsOne = new ToolTip();
            ToolTip Points4Minus = new ToolTip();
            ToolTip maxPoints6 = new ToolTip();
            
            
            RealPoints.SetToolTip(tbRealPoints, "Erreichte Punkte");
            maxPoints.SetToolTip(tbMaxPoints, "Erreichbare Pukte");
            minPointsOne.SetToolTip(tbMinPointsOne, "Min.Punkte für 1");
            Points4Minus.SetToolTip(tbPoints4Minus, "Punkte 4-");
            maxPoints6.SetToolTip(tbMaxPoints6, "Max. Punkte 6"); 
            //tooltip section end

        }


        
       
       


        private double realPoints;
        private double maxPoints;
        private double minPointsOne;
        private double points4Minus;
        private double maxPoints6;







        //Area for Text-vanishing at the TB at clicking!!
        private void tbRealPoints_MouseClick(object sender, MouseEventArgs e)
        {
            tbRealPoints.Text = "";
        }
        private void tbMaxPoints_MouseClick(object sender, MouseEventArgs e)
        {
            tbMaxPoints.Text = "";
        }
        private void tbMinPointsOne_MouseClick(object sender, MouseEventArgs e)
        {
            tbMinPointsOne.Text = "";
        }
        private void tbPoints4Minus_MouseClick(object sender, MouseEventArgs e)
        {
            tbPoints4Minus.Text = "";
        }
        private void tbMaxPoints6_Click(object sender, EventArgs e)
        {
            tbMaxPoints6.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            try
            {
                realPoints      = Convert.ToDouble(tbRealPoints.Text);
                maxPoints       = Convert.ToDouble(tbMaxPoints.Text);
                minPointsOne    = Convert.ToDouble(tbMinPointsOne.Text);
                points4Minus    = Convert.ToDouble(tbPoints4Minus.Text);
                maxPoints6      = Convert.ToDouble(tbMaxPoints6.Text);

                Calculate();
            }
            catch (Exception)
            {
                labelError.Text = "Error";

            }

            














        }

        private void Calculate()
        {
            if (realPoints >= minPointsOne)
            {
                labelResult.Text = "1";
            }
            if (realPoints <= maxPoints6)
            {
                labelResult.Text = "6";
            }
            if (realPoints == points4Minus)
            {
                labelResult.Text = "4-";
            }
            if (realPoints < points4Minus && realPoints > maxPoints6)
            {
                CalculateLowSection(); 
            }
            if (realPoints > points4Minus && realPoints < minPointsOne)
            {
                CalculateHighSection();
            }
            else
            {
                labelError.Text = "Error";
            }
        }



        
        
        
        //6+, 5-6, 5-, 5, 5+, 4-5   =>  6
        private void CalculateLowSection(){
            double diff = points4Minus - maxPoints6;
            double sechstel = diff / 6;
            double markNumber = (points4Minus - realPoints) / sechstel;

            if (markNumber>= 0 && markNumber < 1)
            {
                labelResult.Text = "4-5"; 
            }

            if (markNumber >= 1 && markNumber < 2)
            {
                labelResult.Text = "5+";
            }
            if (markNumber >= 2 && markNumber < 3)
            {
                labelResult.Text = "5";
            }
            if (markNumber >= 3 && markNumber < 4)
            {
                labelResult.Text = "5-";
            }
            if (markNumber >= 4 && markNumber < 5)
            {
                labelResult.Text = "5-6";
            }
            if (markNumber >= 5 && markNumber <= 6)
            {
                labelResult.Text = "6+";
            }
            //else
            //{
              //  labelError.Text = "Math Error bitte melden";
            //}
         

        
    
    
    
            }

        //1-, 1-2, 2+, 2, 2-, 2-3, 3+, 3, 3-, 3-4, 4+, 4    => 12
        private void CalculateHighSection() {
            double diff = minPointsOne - points4Minus;
            double zwölftel = diff / 12;
            double markNumber = (minPointsOne - realPoints) / zwölftel;

            if (markNumber >= 0 && markNumber < 1)
            {
                labelResult.Text = "1-";
            }

            if (markNumber >= 1 && markNumber < 2)
            {
                labelResult.Text = "1-2";
            }
            if (markNumber >= 2 && markNumber < 3)
            {
                labelResult.Text = "2+";
            }
            if (markNumber >= 3 && markNumber < 4)
            {
                labelResult.Text = "2";
            }
            if (markNumber >= 4 && markNumber < 5)
            {
                labelResult.Text = "2-";
            }
            if (markNumber >= 5 && markNumber <= 6)
            {
                labelResult.Text = "2-3";
            }
            if (markNumber >= 6 && markNumber < 7)
            {
                labelResult.Text = "3+";
            }
            if (markNumber >= 7 && markNumber < 8)
            {
                labelResult.Text = "3";
            }
            if (markNumber >= 8 && markNumber < 9)
            {
                labelResult.Text = "3-";
            }
            if (markNumber >= 9 && markNumber < 10)
            {
                labelResult.Text = "3-4";
            }
            if (markNumber >= 10 && markNumber < 11)
            {
                labelResult.Text = "4+";
            }
            if (markNumber >= 11 && markNumber <= 12)
            {
                labelResult.Text = "4";
            }
        
        }





       

       
       

       

        

      
    }
}
