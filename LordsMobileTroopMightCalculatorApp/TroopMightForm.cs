/*Programed by Zander Hermans TroopMightForm.cs
 * created 1/7/2022
 * v1.2.1.1
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LordsMobileTroopMightCalculatorApp
{
    
    public partial class TroopMightForm : Form
    {
        
        public double totalT1,
                TotalT2 = 0,
                TotalT3 = 0,
                TotalT4 = 0, TotalT5 = 0;




        public double t4inf = 0,
            t4range = 0,
            t4cav = 0,
            t4siege = 0;

        private void RssButton_Click(object sender, EventArgs e)
        {
            ResourceRequirementForm f2 = new ResourceRequirementForm();
            f2.ShowDialog(); // Shows Form2
        }

        public TroopMightForm()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            //all varibles needed for program to work
            const double T1TROOPMIGHT = 2;
            const double T2TROOPMIGHT = 8;
            const double T3TROOPMIGHT = 24;
            const double T4TROOPMIGHT = 36;
            const double T5TROOPMIGHT = 48;
            const double LUMGEARMIGHT = 12;
            string gett1inf,
                gett1range,
                gett1cav,
                gett1siege, gett2inf,
                gett2range,
                gett2cav,
                gett2siege;
            string gett3inf,
                gett3range,
                gett3cav,
                gett3siege;
            string gett4inf,
                gett4range,
                gett4cav,
                gett4siege,
                gett5inf,
                gett5range,
                gett5cav,
                gett5siege;
            string getlumgear;
           
            double lumgear = 0;
           double
                TotalT1troopMight = 0,
                TotalT2TroopMight = 0,
                TotalT3TroopMight = 0,
                TotalT4TroopMight = 0,
                TotalT5TroopMight = 0,
                TotalLumGearMight = 0,
                totalTroopMight = 0;
            double TotalTroops = 0;
            //retrieves t1 troops information
            try
            {
                gett1inf = T1InfTextBox.Text;
                Globals.t1inf = Convert.ToDouble(gett1inf);


                gett1range = T1RangeTextBox.Text;
                Globals.t1range = Convert.ToDouble(gett1range);


                gett1cav = T1CavTextbox.Text;
                Globals.t1cav = Convert.ToDouble(gett1cav);

                gett1siege = T1SiegeTextBox.Text;
                Globals.t1siege = Convert.ToDouble(gett1siege);

                //retrieves t2 troops information
                gett2inf = T2infTextBox.Text;
                Globals.t2inf = Convert.ToDouble(gett2inf);


                gett2range = T2rangeTextbox.Text;
                Globals.t2range = Convert.ToDouble(gett2range);


                gett2cav = T2CavTextBox.Text;
                Globals.t2cav = Convert.ToDouble(gett2cav);


                gett2siege = T2SiegeTextBox.Text;
                Globals.t2siege = Convert.ToDouble(gett2siege);

                //retrieves t3 troops information
                gett3inf = T3InfTextBox.Text;
                Globals.t3inf = Convert.ToDouble(gett3inf);


                gett3range = T3RangeTextBox.Text;
                Globals.t3range = Convert.ToDouble(gett3range);


                gett3cav = T3CavTextBox.Text;
                Globals.t3cav = Convert.ToDouble(gett3cav);


                gett3siege = T3SiegeTextBox.Text;
                Globals.t3siege = Convert.ToDouble(gett3siege);


                //retrieves t4 troops information
                gett4inf = T4InfTextBox.Text;
                Globals.t4inf = Convert.ToDouble(gett4inf);


                gett4range = T4RangeTextBox.Text;
                Globals.t4range = Convert.ToDouble(gett4range);


                gett4cav = T4CavTextBox.Text;
                Globals.t4cav = Convert.ToDouble(gett4cav);


                gett4siege = T4SiegeTextBox.Text;
                Globals.t4siege = Convert.ToDouble(gett4siege);


                //retrieves t5 troops information
                gett5inf = T5InfTextBox.Text;
                Globals.t5inf = Convert.ToDouble(gett5inf);


                gett5range = T5RangeTextBox.Text; 
                Globals.t5range = Convert.ToDouble(gett5range);

                gett5cav = T5CavTextBox.Text;
                Globals.t5cav = Convert.ToDouble(gett5cav);


                gett5siege = T5SiegeTextBox.Text;
                Globals.t5siege = Convert.ToDouble(gett5siege);

                //retrieves luminous gear information
                getlumgear = LuminousGearTextBox.Text;
                lumgear = Convert.ToDouble(getlumgear);
            }
            catch
            {
                MessageBox.Show("Please enter a number greater than zero", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //all the logic to find troop might and troop count
            totalT1 = Globals.t1inf + Globals.t1cav + Globals.t1range + Globals.t1siege;
            TotalT1troopMight = totalT1 * T1TROOPMIGHT;
            TotalT2 = Globals.t2inf + Globals.t2range + Globals.t2cav + Globals.t2siege;
            TotalT2TroopMight = TotalT2 * T2TROOPMIGHT;
            TotalT3 = Globals.t3inf + Globals.t3range + Globals.t3cav + Globals.t3siege;
            TotalT3TroopMight = TotalT3 * T3TROOPMIGHT;
            TotalT4 = Globals.t4inf + Globals.t4range + Globals.t4cav + Globals.t4siege;
            TotalT4TroopMight = TotalT4 * T4TROOPMIGHT;
            TotalT5 = Globals.t5inf + Globals.t5range + Globals.t5cav + Globals.t5siege;
            TotalT5TroopMight = TotalT5 * T5TROOPMIGHT;
            TotalLumGearMight = lumgear * LUMGEARMIGHT;

            totalTroopMight = TotalT1troopMight + TotalT2TroopMight + TotalT3TroopMight + TotalT4TroopMight + TotalT5TroopMight + TotalLumGearMight;
            TotalTroops = totalT1 + TotalT2 + TotalT3 + TotalT4 + TotalT5;
            TotalTroopsmightLbl.Text = totalTroopMight.ToString("N");
            TotalTroopsCountlbl.Text = Convert.ToString(TotalTroops);
        }

        private void ClearTroopsBtn_Click(object sender, EventArgs e)
        {
            //resets all information in text boxes and certain lables
            T1InfTextBox.Text = "0";
            T1RangeTextBox.Text = "0";
            T1CavTextbox.Text = "0";
            T1SiegeTextBox.Text = "0";
            T2infTextBox.Text = "0";
            T2rangeTextbox.Text = "0";
            T2CavTextBox.Text = "0";
            T2SiegeTextBox.Text = "0";
            T3InfTextBox.Text = "0";
            T3RangeTextBox.Text = "0";
            T3CavTextBox.Text = "0";
            T3SiegeTextBox.Text = "0";
            T4InfTextBox.Text = "0";
            T4RangeTextBox.Text = "0";
            T4CavTextBox.Text = "0";
            T4SiegeTextBox.Text = "0";
            T5InfTextBox.Text = "0";
            T5RangeTextBox.Text = "0";
            T5CavTextBox.Text = "0";
            T5SiegeTextBox.Text = "0";
            LuminousGearTextBox.Text = "0";
            TotalTroopsmightLbl.Text = "0";
            TotalTroopsCountlbl.Text = "0";
        }


    }
    
    
}
