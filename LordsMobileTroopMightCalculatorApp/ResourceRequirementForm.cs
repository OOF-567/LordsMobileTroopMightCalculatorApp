// LordsMobileTroopMightCalculatorApp v1.2.1.1 Copyright Zander Hermans
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
    public partial class ResourceRequirementForm : Form
    {

        double t1sub;
        double t2sub;
        double t3sub;
        double t4sub;



        public ResourceRequirementForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            const double T1TROOPCOSTWOOD = 50;
            const double T1TROOPCOSTFOOD = 50;
            const double T1TROOPCOSTSTONE = 50;
            const double T1TROOPCOSTORE = 50;
            const double T1TROOPCOSTGOLD = 0;
            const double T2TROOPCOSTWOOD = 100;
            const double T2TROOPCOSTFOOD = 100;
            const double T2TROOPCOSTSTONE = 100;
            const double T2TROOPCOSTORE = 100;
            const double T2TROOPCOSTGOLD = 5;
            const double T3TROOPCOSTWOOD = 150;
            const double T3TROOPCOSTFOOD = 150;
            const double T3TROOPCOSTSTONE = 150;
            const double T3TROOPCOSTORE = 150;
            const double T3TROOPCOSTGOLD = 10;
            const double T4TROOPCOSTWOOD = 1000;
            const double T4TROOPCOSTFOOD = 1000;
            const double T4TROOPCOSTSTONE = 1000;
            const double T4TROOPCOSTORE = 1000;
            const double T4TROOPCOSTGOLD = 500;
            const double t1t2Sub_Lvl1 = .995;
            const double t1t2Sub_Lvl2 = .99;
            const double t1t2Sub_Lvl3 = .985;
            const double t1t2Sub_Lvl4 = .975;
            const double t1t2Sub_Lvl5 = .965;
            const double t1t2Sub_Lvl6 = .955;
            const double t1t2Sub_Lvl7 = .93;
            const double t1t2Sub_Lvl8 = .9;
            const double t1t2Sub_Lvl9 = .84;
            const double t1t2Sub_Lvl10 = .60;
            const double t3t4SUB_Lvl1 = .995;
            const double t3t4SUB_Lvl2 = .99;
            const double t3t4SUB_Lvl3 = .985;
            const double t3t4SUB_Lvl4 = .98;
            const double t3t4SUB_Lvl5 = .97;
            const double t3t4SUB_Lvl6 = .96;
            const double t3t4SUB_Lvl7 = .95;
            const double t3t4SUB_Lvl8 = .93;
            const double t3t4SUB_Lvl9 = .89;
            const double t3t4SUB_Lvl10 = .70;
            double t1wood, t1gold, t1food, t1ore, t1stone, t2wood, t2gold, t2food, t2ore, t2stone, t3wood, t3ore, t3food, t3gold, t3stone, t4wood, t4ore, t4gold, t4stone, t4food;
            double t1infwood, t1infgold, t1inffood, t1infstone, t1infore, t1rangewood, t1rangegold, t1rangefood, t1rangestone, t1rangeore;
            double t1cavwood, t1cavgold, t1cavfood, t1cavstone, t1cavore, t1siegewood, t1siegefood, t1siegestone, t1siegeore,t1siegegold;
            double t2infwood, t2infgold, t2inffood, t2infstone, t2infore, t2rangewood, t2rangegold, t2rangefood, t2rangestone, t2rangeore;
            double t2cavwood, t2cavgold, t2cavfood, t2cavstone, t2cavore, t2siegewood, t2siegefood, t2siegestone, t2siegeore,t2siegegold;
            double t3infwood, t3infgold, t3inffood, t3infstone, t3infore, t3rangewood, t3rangegold, t3rangefood, t3rangestone, t3rangeore;
            double t3cavwood, t3cavgold, t3cavfood, t3cavstone, t3cavore, t3siegewood, t3siegefood, t3siegestone, t3siegeore,t3siegegold;
            double t4infwood, t4infgold, t4inffood, t4infstone, t4infore, t4rangewood, t4rangegold, t4rangefood, t4rangestone, t4rangeore;
            double t4cavwood, t4cavgold, t4cavfood, t4cavstone, t4cavore, t4siegewood, t4siegefood, t4siegestone, t4siegeore,t4siegegold;
            double totalwoodt1, totalfoodt1, totaloret1, totalstonet1, totalgoldt1;
            double totalwoodt2, totalfoodt2, totaloret2, totalstonet2, totalgoldt2;
            double totalwoodt3, totalfoodt3, totaloret3, totalstonet3, totalgoldt3;
            double totalwoodt4, totalfoodt4, totaloret4, totalstonet4, totalgoldt4;
            
            try
            {
                t1sub = double.Parse(T1SubsidyTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number 0-10", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //main logic of the program, calculates might values based on what was entered and rss costs
            if (t1sub == 1)
            {
                t1wood = T1TROOPCOSTWOOD * t1t2Sub_Lvl1; t1stone = T1TROOPCOSTSTONE * t1t2Sub_Lvl1; t1gold = T1TROOPCOSTGOLD * t1t2Sub_Lvl1; t1food = T1TROOPCOSTFOOD * t1t2Sub_Lvl1; t1ore = T1TROOPCOSTORE * t1t2Sub_Lvl1;
                t1infwood = Globals.t1inf * t1wood;
                t1inffood = Globals.t1inf * t1food;
                t1infore = Globals.t1inf * t1ore;
                t1rangewood = Globals.t1range * t1wood;
                t1rangefood = Globals.t1range * t1food;
                t1rangestone = Globals.t1range * t1stone;
                t1cavfood = Globals.t1cav * t1food;
                t1cavstone = Globals.t1cav * t1stone;
                t1cavore = Globals.t1cav * t1ore;
                t1cavgold = t1gold;
                t1cavwood = 0;
                t1rangeore = 0;
                t1infstone = 0;
                t1infgold = t1gold;
                t1rangegold = t1gold;
                t1siegefood = t1food*Globals.t1siege;
                t1siegestone = t1stone * Globals.t1siege;
                t1siegewood = t1wood * Globals.t1siege;
                t1siegeore = t1ore * Globals.t1siege;
                t1siegegold = 0;
                totalwoodt1 = t1infwood + t1cavwood + t1rangewood+t1siegewood;
                totalstonet1 = t1infstone + t1cavstone + t1rangestone+t1siegestone;
                totaloret1 = t1infore + t1cavore + t1rangeore+t1siegeore;
                totalfoodt1 = t1inffood + t1rangefood + t1cavfood+t1siegefood;
                totalgoldt1 = t1cavgold + t1infgold + t1rangegold+t1siegegold;
            }
            else if (t1sub == 2)
            {
                t1wood = T1TROOPCOSTWOOD * t1t2Sub_Lvl2; t1stone = T1TROOPCOSTSTONE * t1t2Sub_Lvl2; t1gold = T1TROOPCOSTGOLD * t1t2Sub_Lvl2; t1food = T1TROOPCOSTFOOD * t1t2Sub_Lvl2; t1ore = T1TROOPCOSTORE * t1t2Sub_Lvl2;
                t1infwood = Globals.t1inf * t1wood;
                t1inffood = Globals.t1inf * t1food;
                t1infore = Globals.t1inf * t1ore;
                t1rangewood = Globals.t1range * t1wood;
                t1rangefood = Globals.t1range * t1food;
                t1rangestone = Globals.t1range * t1stone;
                t1cavfood = Globals.t1cav * t1food;
                t1cavstone = Globals.t1cav * t1stone;
                t1cavore = Globals.t1cav * t1ore;
                t1cavgold = t1gold;
                t1cavwood = 0;
                t1rangeore = 0;
                t1infstone = 0;
                t1infgold = t1gold;
                t1rangegold = t1gold;
                t1siegefood = t1food * Globals.t1siege;
                t1siegestone = t1stone * Globals.t1siege;
                t1siegewood = t1wood * Globals.t1siege;
                t1siegeore = t1ore * Globals.t1siege;
                t1siegegold = 0;
                totalwoodt1 = t1infwood + t1cavwood + t1rangewood + t1siegewood;
                totalstonet1 = t1infstone + t1cavstone + t1rangestone + t1siegestone;
                totaloret1 = t1infore + t1cavore + t1rangeore + t1siegeore;
                totalfoodt1 = t1inffood + t1rangefood + t1cavfood + t1siegefood;
                totalgoldt1 = t1cavgold + t1infgold + t1rangegold + t1siegegold;


            }
            else if (t1sub == 3)
            {
                t1wood = T1TROOPCOSTWOOD * t1t2Sub_Lvl3; t1stone = T1TROOPCOSTSTONE * t1t2Sub_Lvl3; t1gold = T1TROOPCOSTGOLD * t1t2Sub_Lvl3; t1food = T1TROOPCOSTFOOD * t1t2Sub_Lvl3; t1ore = T1TROOPCOSTORE * t1t2Sub_Lvl3;
                t1infwood = Globals.t1inf * t1wood;
                t1inffood = Globals.t1inf * t1food;
                t1infore = Globals.t1inf * t1ore;
                t1rangewood = Globals.t1range * t1wood;
                t1rangefood = Globals.t1range * t1food;
                t1rangestone = Globals.t1range * t1stone;
                t1cavfood = Globals.t1cav * t1food;
                t1cavstone = Globals.t1cav * t1stone;
                t1cavore = Globals.t1cav * t1ore;
                t1cavgold = t1gold;
                t1cavwood = 0;
                t1rangeore = 0;
                t1infstone = 0;
                t1infgold = t1gold;
                t1rangegold = t1gold;
                t1siegefood = t1food * Globals.t1siege;
                t1siegestone = t1stone * Globals.t1siege;
                t1siegewood = t1wood * Globals.t1siege;
                t1siegeore = t1ore * Globals.t1siege;
                t1siegegold = 0;
                totalwoodt1 = t1infwood + t1cavwood + t1rangewood + t1siegewood;
                totalstonet1 = t1infstone + t1cavstone + t1rangestone + t1siegestone;
                totaloret1 = t1infore + t1cavore + t1rangeore + t1siegeore;
                totalfoodt1 = t1inffood + t1rangefood + t1cavfood + t1siegefood;
                totalgoldt1 = t1cavgold + t1infgold + t1rangegold + t1siegegold;


            }
            else if (t1sub == 4)
            {
                t1wood = T1TROOPCOSTWOOD * t1t2Sub_Lvl4; t1stone = T1TROOPCOSTSTONE * t1t2Sub_Lvl4; t1gold = T1TROOPCOSTGOLD * t1t2Sub_Lvl4; t1food = T1TROOPCOSTFOOD * t1t2Sub_Lvl4; t1ore = T1TROOPCOSTORE * t1t2Sub_Lvl4;
                t1infwood = Globals.t1inf * t1wood;
                t1inffood = Globals.t1inf * t1food;
                t1infore = Globals.t1inf * t1ore;
                t1rangewood = Globals.t1range * t1wood;
                t1rangefood = Globals.t1range * t1food;
                t1rangestone = Globals.t1range * t1stone;
                t1cavfood = Globals.t1cav * t1food;
                t1cavstone = Globals.t1cav * t1stone;
                t1cavore = Globals.t1cav * t1ore;
                t1cavgold = t1gold;
                t1cavwood = 0;
                t1rangeore = 0;
                t1infstone = 0;
                t1infgold = t1gold;
                t1rangegold = t1gold;
                t1siegefood = t1food * Globals.t1siege;
                t1siegestone = t1stone * Globals.t1siege;
                t1siegewood = t1wood * Globals.t1siege;
                t1siegeore = t1ore * Globals.t1siege;
                t1siegegold = 0;
                totalwoodt1 = t1infwood + t1cavwood + t1rangewood + t1siegewood;
                totalstonet1 = t1infstone + t1cavstone + t1rangestone + t1siegestone;
                totaloret1 = t1infore + t1cavore + t1rangeore + t1siegeore;
                totalfoodt1 = t1inffood + t1rangefood + t1cavfood + t1siegefood;
                totalgoldt1 = t1cavgold + t1infgold + t1rangegold + t1siegegold;


            }
            else if (t1sub == 5)
            {
                t1wood = T1TROOPCOSTWOOD * t1t2Sub_Lvl5; t1stone = T1TROOPCOSTSTONE * t1t2Sub_Lvl5; t1ore = T1TROOPCOSTORE * t1t2Sub_Lvl5; t1gold = T1TROOPCOSTGOLD * t1t2Sub_Lvl5; t1food = T1TROOPCOSTFOOD * t1t2Sub_Lvl5;
                t1infwood = Globals.t1inf * t1wood;
                t1inffood = Globals.t1inf * t1food;
                t1infore = Globals.t1inf * t1ore;
                t1rangewood = Globals.t1range * t1wood;
                t1rangefood = Globals.t1range * t1food;
                t1rangestone = Globals.t1range * t1stone;
                t1cavfood = Globals.t1cav * t1food;
                t1cavstone = Globals.t1cav * t1stone;
                t1cavore = Globals.t1cav * t1ore;
                t1cavgold = t1gold;
                t1cavwood = 0;
                t1rangeore = 0;
                t1infstone = 0;
                t1infgold = t1gold;
                t1rangegold = t1gold;
                t1siegefood = t1food * Globals.t1siege;
                t1siegestone = t1stone * Globals.t1siege;
                t1siegewood = t1wood * Globals.t1siege;
                t1siegeore = t1ore * Globals.t1siege;
                t1siegegold = 0;
                totalwoodt1 = t1infwood + t1cavwood + t1rangewood + t1siegewood;
                totalstonet1 = t1infstone + t1cavstone + t1rangestone + t1siegestone;
                totaloret1 = t1infore + t1cavore + t1rangeore + t1siegeore;
                totalfoodt1 = t1inffood + t1rangefood + t1cavfood + t1siegefood;
                totalgoldt1 = t1cavgold + t1infgold + t1rangegold + t1siegegold;

            }
            else if (t1sub == 6)
            {
                t1wood = T1TROOPCOSTWOOD * t1t2Sub_Lvl6; t1stone = T1TROOPCOSTSTONE * t1t2Sub_Lvl6; t1ore = T1TROOPCOSTORE * t1t2Sub_Lvl6; t1gold = T1TROOPCOSTGOLD * t1t2Sub_Lvl6; t1food = T1TROOPCOSTFOOD * t1t2Sub_Lvl6;
                t1infwood = Globals.t1inf * t1wood;
                t1inffood = Globals.t1inf * t1food;
                t1infore = Globals.t1inf * t1ore;
                t1rangewood = Globals.t1range * t1wood;
                t1rangefood = Globals.t1range * t1food;
                t1rangestone = Globals.t1range * t1stone;
                t1cavfood = Globals.t1cav * t1food;
                t1cavstone = Globals.t1cav * t1stone;
                t1cavore = Globals.t1cav * t1ore;
                t1cavgold = t1gold;
                t1cavwood = 0;
                t1rangeore = 0;
                t1infstone = 0;
                t1infgold = t1gold;
                t1rangegold = t1gold;
                t1siegefood = t1food * Globals.t1siege;
                t1siegestone = t1stone * Globals.t1siege;
                t1siegewood = t1wood * Globals.t1siege;
                t1siegeore = t1ore * Globals.t1siege;
                t1siegegold = 0;
                totalwoodt1 = t1infwood + t1cavwood + t1rangewood + t1siegewood;
                totalstonet1 = t1infstone + t1cavstone + t1rangestone + t1siegestone;
                totaloret1 = t1infore + t1cavore + t1rangeore + t1siegeore;
                totalfoodt1 = t1inffood + t1rangefood + t1cavfood + t1siegefood;
                totalgoldt1 = t1cavgold + t1infgold + t1rangegold + t1siegegold;


            }
            else if (t1sub == 7)
            {
                t1wood = T1TROOPCOSTWOOD * t1t2Sub_Lvl7; t1stone = T1TROOPCOSTSTONE * t1t2Sub_Lvl7; t1ore = T1TROOPCOSTORE * t1t2Sub_Lvl7; t1gold = T1TROOPCOSTGOLD * t1t2Sub_Lvl7; t1food = T1TROOPCOSTFOOD * t1t2Sub_Lvl7;
                t1infwood = Globals.t1inf * t1wood;
                t1inffood = Globals.t1inf * t1food;
                t1infore = Globals.t1inf * t1ore;
                t1rangewood = Globals.t1range * t1wood;
                t1rangefood = Globals.t1range * t1food;
                t1rangestone = Globals.t1range * t1stone;
                t1cavfood = Globals.t1cav * t1food;
                t1cavstone = Globals.t1cav * t1stone;
                t1cavore = Globals.t1cav * t1ore;
                t1cavgold = t1gold;
                t1cavwood = 0;
                t1rangeore = 0;
                t1infstone = 0;
                t1infgold = t1gold;
                t1rangegold = t1gold;
                t1siegefood = t1food * Globals.t1siege;
                t1siegestone = t1stone * Globals.t1siege;
                t1siegewood = t1wood * Globals.t1siege;
                t1siegeore = t1ore * Globals.t1siege;
                t1siegegold = 0;
                totalwoodt1 = t1infwood + t1cavwood + t1rangewood + t1siegewood;
                totalstonet1 = t1infstone + t1cavstone + t1rangestone + t1siegestone;
                totaloret1 = t1infore + t1cavore + t1rangeore + t1siegeore;
                totalfoodt1 = t1inffood + t1rangefood + t1cavfood + t1siegefood;
                totalgoldt1 = t1cavgold + t1infgold + t1rangegold + t1siegegold;


            }
            else if (t1sub == 8)
            {
                t1wood = T1TROOPCOSTWOOD * t1t2Sub_Lvl8; t1stone = T1TROOPCOSTSTONE * t1t2Sub_Lvl8; t1ore = T1TROOPCOSTORE * t1t2Sub_Lvl8; t1gold = T1TROOPCOSTGOLD * t1t2Sub_Lvl8; t1food = T1TROOPCOSTFOOD * t1t2Sub_Lvl8;
                t1infwood = Globals.t1inf * t1wood;
                t1inffood = Globals.t1inf * t1food;
                t1infore = Globals.t1inf * t1ore;
                t1rangewood = Globals.t1range * t1wood;
                t1rangefood = Globals.t1range * t1food;
                t1rangestone = Globals.t1range * t1stone;
                t1cavfood = Globals.t1cav * t1food;
                t1cavstone = Globals.t1cav * t1stone;
                t1cavore = Globals.t1cav * t1ore;
                t1cavgold = t1gold;
                t1cavwood = 0;
                t1rangeore = 0;
                t1infstone = 0;
                t1infgold = t1gold;
                t1rangegold = t1gold;
                t1siegefood = t1food * Globals.t1siege;
                t1siegestone = t1stone * Globals.t1siege;
                t1siegewood = t1wood * Globals.t1siege;
                t1siegeore = t1ore * Globals.t1siege;
                t1siegegold = 0;
                totalwoodt1 = t1infwood + t1cavwood + t1rangewood + t1siegewood;
                totalstonet1 = t1infstone + t1cavstone + t1rangestone + t1siegestone;
                totaloret1 = t1infore + t1cavore + t1rangeore + t1siegeore;
                totalfoodt1 = t1inffood + t1rangefood + t1cavfood + t1siegefood;
                totalgoldt1 = t1cavgold + t1infgold + t1rangegold + t1siegegold;


            }
            else if (t1sub == 9)
            {
                t1wood = T1TROOPCOSTWOOD * t1t2Sub_Lvl9; t1stone = T1TROOPCOSTSTONE * t1t2Sub_Lvl9; t1ore = T1TROOPCOSTORE * t1t2Sub_Lvl9; t1gold = T1TROOPCOSTGOLD * t1t2Sub_Lvl9; t1food = T1TROOPCOSTFOOD * t1t2Sub_Lvl9;
                t1infwood = Globals.t1inf * t1wood;
                t1inffood = Globals.t1inf * t1food;
                t1infore = Globals.t1inf * t1ore;
                t1rangewood = Globals.t1range * t1wood;
                t1rangefood = Globals.t1range * t1food;
                t1rangestone = Globals.t1range * t1stone;
                t1cavfood = Globals.t1cav * t1food;
                t1cavstone = Globals.t1cav * t1stone;
                t1cavore = Globals.t1cav * t1ore;
                t1cavgold = t1gold;
                t1cavwood = 0;
                t1rangeore = 0;
                t1infstone = 0;
                t1infgold = t1gold;
                t1rangegold = t1gold;
                t1siegefood = t1food * Globals.t1siege;
                t1siegestone = t1stone * Globals.t1siege;
                t1siegewood = t1wood * Globals.t1siege;
                t1siegeore = t1ore * Globals.t1siege;
                t1siegegold = 0;
                totalwoodt1 = t1infwood + t1cavwood + t1rangewood + t1siegewood;
                totalstonet1 = t1infstone + t1cavstone + t1rangestone + t1siegestone;
                totaloret1 = t1infore + t1cavore + t1rangeore + t1siegeore;
                totalfoodt1 = t1inffood + t1rangefood + t1cavfood + t1siegefood;
                totalgoldt1 = t1cavgold + t1infgold + t1rangegold + t1siegegold;


            }
            else if (t1sub == 10)
            {
                t1wood = T1TROOPCOSTWOOD * t1t2Sub_Lvl10; t1stone = T1TROOPCOSTSTONE * t1t2Sub_Lvl10; t1ore = T1TROOPCOSTORE * t1t2Sub_Lvl10; t1gold = T1TROOPCOSTGOLD * t1t2Sub_Lvl10; t1food = T1TROOPCOSTFOOD * t1t2Sub_Lvl10;
                t1infwood = Globals.t1inf * t1wood;
                t1inffood = Globals.t1inf * t1food;
                t1infore = Globals.t1inf * t1ore;
                t1rangewood = Globals.t1range * t1wood;
                t1rangefood = Globals.t1range * t1food;
                t1rangestone = Globals.t1range * t1stone;
                t1cavfood = Globals.t1cav * t1food;
                t1cavstone = Globals.t1cav * t1stone;
                t1cavore = Globals.t1cav * t1ore;
                t1cavgold = t1gold;
                t1cavwood = 0;
                t1rangeore = 0;
                t1infstone = 0;
                t1infgold = t1gold;
                t1rangegold = t1gold;
                t1siegefood = t1food * Globals.t1siege;
                t1siegestone = t1stone * Globals.t1siege;
                t1siegewood = t1wood * Globals.t1siege;
                t1siegeore = t1ore * Globals.t1siege;
                t1siegegold = 0;
                totalwoodt1 = t1infwood + t1cavwood + t1rangewood + t1siegewood;
                totalstonet1 = t1infstone + t1cavstone + t1rangestone + t1siegestone;
                totaloret1 = t1infore + t1cavore + t1rangeore + t1siegeore;
                totalfoodt1 = t1inffood + t1rangefood + t1cavfood + t1siegefood;
                totalgoldt1 = t1cavgold + t1infgold + t1rangegold + t1siegegold;


            }
            else
            {
                t1wood = T1TROOPCOSTWOOD; t1stone = T1TROOPCOSTSTONE; t1ore = T1TROOPCOSTORE; t1food = T1TROOPCOSTFOOD; t1gold = T1TROOPCOSTGOLD;
                t1infwood = Globals.t1inf * t1wood;
                t1inffood = Globals.t1inf * t1food;
                t1infore = Globals.t1inf * t1ore;
                t1rangewood = Globals.t1range * t1wood;
                t1rangefood = Globals.t1range * t1food;
                t1rangestone = Globals.t1range * t1stone;
                t1cavfood = Globals.t1cav * t1food;
                t1cavstone = Globals.t1cav * t1stone;
                t1cavore = Globals.t1cav * t1ore;
                t1cavgold = t1gold;
                t1cavwood = 0;
                t1rangeore = 0;
                t1infstone = 0;
                t1infgold = t1gold;
                t1rangegold = t1gold;
                t1siegefood = t1food * Globals.t1siege;
                t1siegestone = t1stone * Globals.t1siege;
                t1siegewood = t1wood * Globals.t1siege;
                t1siegeore = t1ore * Globals.t1siege;
                t1siegegold = 0;
                totalwoodt1 = t1infwood + t1cavwood + t1rangewood + t1siegewood;
                totalstonet1 = t1infstone + t1cavstone + t1rangestone + t1siegestone;
                totaloret1 = t1infore + t1cavore + t1rangeore + t1siegeore;
                totalfoodt1 = t1inffood + t1rangefood + t1cavfood + t1siegefood;
                totalgoldt1 = t1cavgold + t1infgold + t1rangegold + t1siegegold;


            }
            try
            {
                t2sub = double.Parse(T2SubsidyTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number 0-10", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            if (t2sub == 1)
            {
                t2wood = T2TROOPCOSTWOOD * t1t2Sub_Lvl1; t2stone = T2TROOPCOSTSTONE * t1t2Sub_Lvl1; t2gold = T2TROOPCOSTGOLD * t1t2Sub_Lvl1; t2food = T2TROOPCOSTFOOD * t1t2Sub_Lvl1; t2ore = T2TROOPCOSTORE * t1t2Sub_Lvl1;
                t2infwood = Globals.t2inf * t2wood;
                t2inffood = Globals.t2inf * t2food;
                t2infore = Globals.t2inf * t2ore;
                t2rangewood = Globals.t2range * t2wood;
                t2rangefood = Globals.t2range * t2food;
                t2rangestone = Globals.t2range * t2stone;
                t2cavfood = Globals.t2cav * t2food;
                t2cavstone = Globals.t2cav * t2stone;
                t2cavore = Globals.t2cav * t2ore;
                t2cavgold = Globals.t2cav * t2gold;
                t2siegefood = Globals.t2siege * t2food;
                t2siegewood = Globals.t2siege * t2wood;
                t2siegestone = Globals.t2siege * t2stone;
                t2siegeore = Globals.t2siege * t2ore;
                t2siegegold = Globals.t2siege * t2gold;
                t2cavwood = 0;
                t2rangeore = 0;
                t2infstone = 0;
                t2infgold = Globals.t2inf * t2gold;
                t2rangegold = Globals.t2range * t2gold;
                totalwoodt2 = t2infwood + t2cavwood + t2rangewood+t2siegewood;
                totalstonet2 = t2infstone + t2cavstone + t2rangestone+t2siegestone;
                totaloret2 = t2infore + t2cavore + t2rangeore+t2siegeore;
                totalfoodt2 = t2inffood + t2rangefood + t2cavfood+t2siegefood;
                totalgoldt2 = t2cavgold + t2infgold + t2rangegold+t2siegegold;

                
            }
            else if (t2sub == 2)
            {
                t2wood = T2TROOPCOSTWOOD * t1t2Sub_Lvl2; t2stone = T2TROOPCOSTSTONE * t1t2Sub_Lvl2; t2gold = T2TROOPCOSTGOLD * t1t2Sub_Lvl2; t2food = T2TROOPCOSTFOOD * t1t2Sub_Lvl2; t2ore = T2TROOPCOSTORE * t1t2Sub_Lvl2;
                t2infwood = Globals.t2inf * t2wood;
                t2inffood = Globals.t2inf * t2food;
                t2infore = Globals.t2inf * t2ore;
                t2rangewood = Globals.t2range * t2wood;
                t2rangefood = Globals.t2range * t2food;
                t2rangestone = Globals.t2range * t2stone;
                t2cavfood = Globals.t2cav * t2food;
                t2cavstone = Globals.t2cav * t2stone;
                t2cavore = Globals.t2cav * t2ore;
                t2cavgold = Globals.t2cav * t2gold;
                t2siegefood = Globals.t2siege * t2food;
                t2siegewood = Globals.t2siege * t2wood;
                t2siegestone = Globals.t2siege * t2stone;
                t2siegeore = Globals.t2siege * t2ore;
                t2siegegold = Globals.t2siege * t2gold;
                t2cavwood = 0;
                t2rangeore = 0;
                t2infstone = 0;
                t2infgold = Globals.t2inf * t2gold;
                t2rangegold = Globals.t2range * t2gold;
                totalwoodt2 = t2infwood + t2cavwood + t2rangewood + t2siegewood;
                totalstonet2 = t2infstone + t2cavstone + t2rangestone + t2siegestone;
                totaloret2 = t2infore + t2cavore + t2rangeore + t2siegeore;
                totalfoodt2 = t2inffood + t2rangefood + t2cavfood + t2siegefood;
                totalgoldt2 = t2cavgold + t2infgold + t2rangegold + t2siegegold;


            }
            else if (t2sub == 3)
            {
                t2wood = T2TROOPCOSTWOOD * t1t2Sub_Lvl3; t2stone = T2TROOPCOSTSTONE * t1t2Sub_Lvl3; t2gold = T2TROOPCOSTGOLD * t1t2Sub_Lvl3; t2food = T2TROOPCOSTFOOD * t1t2Sub_Lvl3; t2ore = T2TROOPCOSTORE * t1t2Sub_Lvl3;
                t2infwood = Globals.t2inf * t2wood;
                t2inffood = Globals.t2inf * t2food;
                t2infore = Globals.t2inf * t2ore;
                t2rangewood = Globals.t2range * t2wood;
                t2rangefood = Globals.t2range * t2food;
                t2rangestone = Globals.t2range * t2stone;
                t2cavfood = Globals.t2cav * t2food;
                t2cavstone = Globals.t2cav * t2stone;
                t2cavore = Globals.t2cav * t2ore;
                t2cavgold = Globals.t2cav * t2gold;
                t2siegefood = Globals.t2siege * t2food;
                t2siegewood = Globals.t2siege * t2wood;
                t2siegestone = Globals.t2siege * t2stone;
                t2siegeore = Globals.t2siege * t2ore;
                t2siegegold = Globals.t2siege * t2gold;
                t2cavwood = 0;
                t2rangeore = 0;
                t2infstone = 0;
                t2infgold = Globals.t2inf * t2gold;
                t2rangegold = Globals.t2range * t2gold;
                totalwoodt2 = t2infwood + t2cavwood + t2rangewood + t2siegewood;
                totalstonet2 = t2infstone + t2cavstone + t2rangestone + t2siegestone;
                totaloret2 = t2infore + t2cavore + t2rangeore + t2siegeore;
                totalfoodt2 = t2inffood + t2rangefood + t2cavfood + t2siegefood;
                totalgoldt2 = t2cavgold + t2infgold + t2rangegold + t2siegegold;


            }
            else if (t2sub == 4)
            {
                t2wood = T2TROOPCOSTWOOD * t1t2Sub_Lvl4; t2stone = T2TROOPCOSTSTONE * t1t2Sub_Lvl4; t2gold = T2TROOPCOSTGOLD * t1t2Sub_Lvl4; t2food = T2TROOPCOSTFOOD * t1t2Sub_Lvl4; t2ore = T2TROOPCOSTORE * t1t2Sub_Lvl4;
                t2infwood = Globals.t2inf * t2wood;
                t2inffood = Globals.t2inf * t2food;
                t2infore = Globals.t2inf * t2ore;
                t2rangewood = Globals.t2range * t2wood;
                t2rangefood = Globals.t2range * t2food;
                t2rangestone = Globals.t2range * t2stone;
                t2cavfood = Globals.t2cav * t2food;
                t2cavstone = Globals.t2cav * t2stone;
                t2cavore = Globals.t2cav * t2ore;
                t2cavgold = Globals.t2cav * t2gold;
                t2siegefood = Globals.t2siege * t2food;
                t2siegewood = Globals.t2siege * t2wood;
                t2siegestone = Globals.t2siege * t2stone;
                t2siegeore = Globals.t2siege * t2ore;
                t2siegegold = Globals.t2siege * t2gold;
                t2cavwood = 0;
                t2rangeore = 0;
                t2infstone = 0;
                t2infgold = Globals.t2inf * t2gold;
                t2rangegold = Globals.t2range * t2gold;
                totalwoodt2 = t2infwood + t2cavwood + t2rangewood + t2siegewood;
                totalstonet2 = t2infstone + t2cavstone + t2rangestone + t2siegestone;
                totaloret2 = t2infore + t2cavore + t2rangeore + t2siegeore;
                totalfoodt2 = t2inffood + t2rangefood + t2cavfood + t2siegefood;
                totalgoldt2 = t2cavgold + t2infgold + t2rangegold + t2siegegold;


            }
            else if (t2sub == 5)
            {
                t2wood = T2TROOPCOSTWOOD * t1t2Sub_Lvl5; t2stone = T2TROOPCOSTSTONE * t1t2Sub_Lvl5; t2ore = T2TROOPCOSTORE * t1t2Sub_Lvl5; t2gold = T2TROOPCOSTGOLD * t1t2Sub_Lvl5; t2food = T2TROOPCOSTFOOD * t1t2Sub_Lvl5;
                t2infwood = Globals.t2inf * t2wood;
                t2inffood = Globals.t2inf * t2food;
                t2infore = Globals.t2inf * t2ore;
                t2rangewood = Globals.t2range * t2wood;
                t2rangefood = Globals.t2range * t2food;
                t2rangestone = Globals.t2range * t2stone;
                t2cavfood = Globals.t2cav * t2food;
                t2cavstone = Globals.t2cav * t2stone;
                t2cavore = Globals.t2cav * t2ore;
                t2cavgold = Globals.t2cav * t2gold;
                t2siegefood = Globals.t2siege * t2food;
                t2siegewood = Globals.t2siege * t2wood;
                t2siegestone = Globals.t2siege * t2stone;
                t2siegeore = Globals.t2siege * t2ore;
                t2siegegold = Globals.t2siege * t2gold;
                t2cavwood = 0;
                t2rangeore = 0;
                t2infstone = 0;
                t2infgold = Globals.t2inf * t2gold;
                t2rangegold = Globals.t2range * t2gold;
                totalwoodt2 = t2infwood + t2cavwood + t2rangewood + t2siegewood;
                totalstonet2 = t2infstone + t2cavstone + t2rangestone + t2siegestone;
                totaloret2 = t2infore + t2cavore + t2rangeore + t2siegeore;
                totalfoodt2 = t2inffood + t2rangefood + t2cavfood + t2siegefood;
                totalgoldt2 = t2cavgold + t2infgold + t2rangegold + t2siegegold;


            }
            else if (t2sub == 6)
            {
                t2wood = T2TROOPCOSTWOOD * t1t2Sub_Lvl6; t2stone = T2TROOPCOSTSTONE * t1t2Sub_Lvl6; t2ore = T2TROOPCOSTORE * t1t2Sub_Lvl6; t2gold = T2TROOPCOSTGOLD * t1t2Sub_Lvl6; t2food = T2TROOPCOSTFOOD * t1t2Sub_Lvl6;
                t2infwood = Globals.t2inf * t2wood;
                t2inffood = Globals.t2inf * t2food;
                t2infore = Globals.t2inf * t2ore;
                t2rangewood = Globals.t2range * t2wood;
                t2rangefood = Globals.t2range * t2food;
                t2rangestone = Globals.t2range * t2stone;
                t2cavfood = Globals.t2cav * t2food;
                t2cavstone = Globals.t2cav * t2stone;
                t2cavore = Globals.t2cav * t2ore;
                t2cavgold = Globals.t2cav * t2gold;
                t2siegefood = Globals.t2siege * t2food;
                t2siegewood = Globals.t2siege * t2wood;
                t2siegestone = Globals.t2siege * t2stone;
                t2siegeore = Globals.t2siege * t2ore;
                t2siegegold = Globals.t2siege * t2gold;
                t2cavwood = 0;
                t2rangeore = 0;
                t2infstone = 0;
                t2infgold = Globals.t2inf * t2gold;
                t2rangegold = Globals.t2range * t2gold;
                totalwoodt2 = t2infwood + t2cavwood + t2rangewood + t2siegewood;
                totalstonet2 = t2infstone + t2cavstone + t2rangestone + t2siegestone;
                totaloret2 = t2infore + t2cavore + t2rangeore + t2siegeore;
                totalfoodt2 = t2inffood + t2rangefood + t2cavfood + t2siegefood;
                totalgoldt2 = t2cavgold + t2infgold + t2rangegold + t2siegegold;


            }
            else if (t2sub == 7)
            {
                t2wood = T2TROOPCOSTWOOD * t1t2Sub_Lvl7; t2stone = T2TROOPCOSTSTONE * t1t2Sub_Lvl7; t2ore = T2TROOPCOSTORE * t1t2Sub_Lvl7; t2gold = T2TROOPCOSTGOLD * t1t2Sub_Lvl7; t2food = T2TROOPCOSTFOOD * t1t2Sub_Lvl7;
                t2infwood = Globals.t2inf * t2wood;
                t2inffood = Globals.t2inf * t2food;
                t2infore = Globals.t2inf * t2ore;
                t2rangewood = Globals.t2range * t2wood;
                t2rangefood = Globals.t2range * t2food;
                t2rangestone = Globals.t2range * t2stone;
                t2cavfood = Globals.t2cav * t2food;
                t2cavstone = Globals.t2cav * t2stone;
                t2cavore = Globals.t2cav * t2ore;
                t2cavgold = Globals.t2cav * t2gold;
                t2siegefood = Globals.t2siege * t2food;
                t2siegewood = Globals.t2siege * t2wood;
                t2siegestone = Globals.t2siege * t2stone;
                t2siegeore = Globals.t2siege * t2ore;
                t2siegegold = Globals.t2siege * t2gold;
                t2cavwood = 0;
                t2rangeore = 0;
                t2infstone = 0;
                t2infgold = Globals.t2inf * t2gold;
                t2rangegold = Globals.t2range * t2gold;
                totalwoodt2 = t2infwood + t2cavwood + t2rangewood + t2siegewood;
                totalstonet2 = t2infstone + t2cavstone + t2rangestone + t2siegestone;
                totaloret2 = t2infore + t2cavore + t2rangeore + t2siegeore;
                totalfoodt2 = t2inffood + t2rangefood + t2cavfood + t2siegefood;
                totalgoldt2 = t2cavgold + t2infgold + t2rangegold + t2siegegold;


            }
            else if (t2sub == 8)
            {
                t2wood = T2TROOPCOSTWOOD * t1t2Sub_Lvl8; t2stone = T2TROOPCOSTSTONE * t1t2Sub_Lvl8; t2ore = T2TROOPCOSTORE * t1t2Sub_Lvl8; t2gold = T2TROOPCOSTGOLD * t1t2Sub_Lvl8; t2food = T2TROOPCOSTFOOD * t1t2Sub_Lvl8;
                t2infwood = Globals.t2inf * t2wood;
                t2inffood = Globals.t2inf * t2food;
                t2infore = Globals.t2inf * t2ore;
                t2rangewood = Globals.t2range * t2wood;
                t2rangefood = Globals.t2range * t2food;
                t2rangestone = Globals.t2range * t2stone;
                t2cavfood = Globals.t2cav * t2food;
                t2cavstone = Globals.t2cav * t2stone;
                t2cavore = Globals.t2cav * t2ore;
                t2cavgold = Globals.t2cav * t2gold;
                t2siegefood = Globals.t2siege * t2food;
                t2siegewood = Globals.t2siege * t2wood;
                t2siegestone = Globals.t2siege * t2stone;
                t2siegeore = Globals.t2siege * t2ore;
                t2siegegold = Globals.t2siege * t2gold;
                t2cavwood = 0;
                t2rangeore = 0;
                t2infstone = 0;
                t2infgold = Globals.t2inf * t2gold;
                t2rangegold = Globals.t2range * t2gold;
                totalwoodt2 = t2infwood + t2cavwood + t2rangewood + t2siegewood;
                totalstonet2 = t2infstone + t2cavstone + t2rangestone + t2siegestone;
                totaloret2 = t2infore + t2cavore + t2rangeore + t2siegeore;
                totalfoodt2 = t2inffood + t2rangefood + t2cavfood + t2siegefood;
                totalgoldt2 = t2cavgold + t2infgold + t2rangegold + t2siegegold;


            }
            else if (t2sub == 9)
            {
                t2wood = T2TROOPCOSTWOOD * t1t2Sub_Lvl9; t2stone = T2TROOPCOSTSTONE * t1t2Sub_Lvl9; t2ore = T2TROOPCOSTORE * t1t2Sub_Lvl9; t2gold = T2TROOPCOSTGOLD * t1t2Sub_Lvl9; t2food = T2TROOPCOSTFOOD * t1t2Sub_Lvl9;
                t2infwood = Globals.t2inf * t2wood;
                t2inffood = Globals.t2inf * t2food;
                t2infore = Globals.t2inf * t2ore;
                t2rangewood = Globals.t2range * t2wood;
                t2rangefood = Globals.t2range * t2food;
                t2rangestone = Globals.t2range * t2stone;
                t2cavfood = Globals.t2cav * t2food;
                t2cavstone = Globals.t2cav * t2stone;
                t2cavore = Globals.t2cav * t2ore;
                t2cavgold = Globals.t2cav * t2gold;
                t2siegefood = Globals.t2siege * t2food;
                t2siegewood = Globals.t2siege * t2wood;
                t2siegestone = Globals.t2siege * t2stone;
                t2siegeore = Globals.t2siege * t2ore;
                t2siegegold = Globals.t2siege * t2gold;
                t2cavwood = 0;
                t2rangeore = 0;
                t2infstone = 0;
                t2infgold = Globals.t2inf * t2gold;
                t2rangegold = Globals.t2range * t2gold;
                totalwoodt2 = t2infwood + t2cavwood + t2rangewood + t2siegewood;
                totalstonet2 = t2infstone + t2cavstone + t2rangestone + t2siegestone;
                totaloret2 = t2infore + t2cavore + t2rangeore + t2siegeore;
                totalfoodt2 = t2inffood + t2rangefood + t2cavfood + t2siegefood;
                totalgoldt2 = t2cavgold + t2infgold + t2rangegold + t2siegegold;


            }
            else if (t2sub == 10)
            {
                t2wood = T2TROOPCOSTWOOD * t1t2Sub_Lvl10; t2stone = T2TROOPCOSTSTONE * t1t2Sub_Lvl10; t2ore = T2TROOPCOSTORE * t1t2Sub_Lvl10; t2gold = T2TROOPCOSTGOLD * t1t2Sub_Lvl10; t2food = T2TROOPCOSTFOOD * t1t2Sub_Lvl10;
                t2infwood = Globals.t2inf * t2wood;
                t2inffood = Globals.t2inf * t2food;
                t2infore = Globals.t2inf * t2ore;
                t2rangewood = Globals.t2range * t2wood;
                t2rangefood = Globals.t2range * t2food;
                t2rangestone = Globals.t2range * t2stone;
                t2cavfood = Globals.t2cav * t2food;
                t2cavstone = Globals.t2cav * t2stone;
                t2cavore = Globals.t2cav * t2ore;
                t2cavgold = Globals.t2cav * t2gold;
                t2siegefood = Globals.t2siege * t2food;
                t2siegewood = Globals.t2siege * t2wood;
                t2siegestone = Globals.t2siege * t2stone;
                t2siegeore = Globals.t2siege * t2ore;
                t2siegegold = Globals.t2siege * t2gold;
                t2cavwood = 0;
                t2rangeore = 0;
                t2infstone = 0;
                t2infgold = Globals.t2inf * t2gold;
                t2rangegold = Globals.t2range * t2gold;
                totalwoodt2 = t2infwood + t2cavwood + t2rangewood + t2siegewood;
                totalstonet2 = t2infstone + t2cavstone + t2rangestone + t2siegestone;
                totaloret2 = t2infore + t2cavore + t2rangeore + t2siegeore;
                totalfoodt2 = t2inffood + t2rangefood + t2cavfood + t2siegefood;
                totalgoldt2 = t2cavgold + t2infgold + t2rangegold + t2siegegold;

            }
            else
            {
                t2wood = T2TROOPCOSTWOOD; t2stone = T2TROOPCOSTSTONE; t2gold = T2TROOPCOSTGOLD; t2food = T2TROOPCOSTFOOD; t2ore = T2TROOPCOSTORE;
                t2infwood = Globals.t2inf * t2wood;
                t2inffood = Globals.t2inf * t2food;
                t2infore = Globals.t2inf * t2ore;
                t2rangewood = Globals.t2range * t2wood;
                t2rangefood = Globals.t2range * t2food;
                t2rangestone = Globals.t2range * t2stone;
                t2cavfood = Globals.t2cav * t2food;
                t2cavstone = Globals.t2cav * t2stone;
                t2cavore = Globals.t2cav * t2ore;
                t2cavgold = Globals.t2cav * t2gold;
                t2siegefood = Globals.t2siege * t2food;
                t2siegewood = Globals.t2siege * t2wood;
                t2siegestone = Globals.t2siege * t2stone;
                t2siegeore = Globals.t2siege * t2ore;
                t2siegegold = Globals.t2siege * t2gold;
                t2cavwood = 0;
                t2rangeore = 0;
                t2infstone = 0;
                t2infgold = Globals.t2inf * t2gold;
                t2rangegold = Globals.t2range * t2gold;
                totalwoodt2 = t2infwood + t2cavwood + t2rangewood + t2siegewood;
                totalstonet2 = t2infstone + t2cavstone + t2rangestone + t2siegestone;
                totaloret2 = t2infore + t2cavore + t2rangeore + t2siegeore;
                totalfoodt2 = t2inffood + t2rangefood + t2cavfood + t2siegefood;
                totalgoldt2 = t2cavgold + t2infgold + t2rangegold + t2siegegold;


            }
            try
            {
                t3sub = double.Parse(T3SubsidyTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number 0-10", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (t3sub == 1)
            {
                t3wood = T3TROOPCOSTWOOD * t3t4SUB_Lvl1; t3stone = T3TROOPCOSTSTONE * t3t4SUB_Lvl1; t3gold = T3TROOPCOSTGOLD * t3t4SUB_Lvl1; t3food = T3TROOPCOSTFOOD * t3t4SUB_Lvl1; t3ore = T3TROOPCOSTORE * t3t4SUB_Lvl1;
                t3infwood = Globals.t3inf * t3wood;
                t3inffood = Globals.t3inf * t3food;
                t3infore = Globals.t3inf * t3ore;
                t3rangewood = Globals.t3range * t3wood;
                t3rangefood = Globals.t3range * t3food;
                t3rangestone = Globals.t3range * t3stone;
                t3cavfood = Globals.t3cav * t3food;
                t3cavstone = Globals.t3cav * t3stone;
                t3cavore = Globals.t3cav * t3ore;
                t3cavgold = Globals.t3cav * t3gold;
                t3cavwood = 0;
                t3rangeore = 0;
                t3infstone = 0;
                t3infgold = Globals.t3inf * t3gold;
                t3rangegold = Globals.t3range * t3gold;
                t3siegefood = Globals.t3siege * t3food;
                t3siegestone = Globals.t3siege * t3stone;
                t3siegeore = Globals.t3siege * t3ore;
                t3siegewood = Globals.t3siege * t3wood;
                t3siegegold = Globals.t3siege * t3gold;
                totalwoodt3 = t3infwood + t3cavwood + t3rangewood+t3siegewood;
                totalstonet3 = t3infstone + t3cavstone + t3rangestone+t3siegestone;
                totaloret3 = t3infore + t3cavore + t3rangeore+t3siegeore;
                totalfoodt3 = t3inffood + t3rangefood + t3cavfood+t3siegefood;
                totalgoldt3 = t3cavgold + t3infgold + t3rangegold+t3siegegold;

                
            }
            else if (t3sub == 2)
            {
                t3wood = T3TROOPCOSTWOOD * t3t4SUB_Lvl2; t3stone = T3TROOPCOSTSTONE * t3t4SUB_Lvl2; t3gold = T3TROOPCOSTGOLD * t3t4SUB_Lvl2; t3food = T3TROOPCOSTFOOD * t3t4SUB_Lvl2; t3ore = T3TROOPCOSTORE * t3t4SUB_Lvl2;
                t3infwood = Globals.t3inf * t3wood;
                t3inffood = Globals.t3inf * t3food;
                t3infore = Globals.t3inf * t3ore;
                t3rangewood = Globals.t3range * t3wood;
                t3rangefood = Globals.t3range * t3food;
                t3rangestone = Globals.t3range * t3stone;
                t3cavfood = Globals.t3cav * t3food;
                t3cavstone = Globals.t3cav * t3stone;
                t3cavore = Globals.t3cav * t3ore;
                t3cavgold = Globals.t3cav * t3gold;
                t3cavwood = 0;
                t3rangeore = 0;
                t3infstone = 0;
                t3infgold = Globals.t3inf * t3gold;
                t3rangegold = Globals.t3range * t3gold;
                t3siegefood = Globals.t3siege * t3food;
                t3siegestone = Globals.t3siege * t3stone;
                t3siegeore = Globals.t3siege * t3ore;
                t3siegewood = Globals.t3siege * t3wood;
                t3siegegold = Globals.t3siege * t3gold;
                totalwoodt3 = t3infwood + t3cavwood + t3rangewood + t3siegewood;
                totalstonet3 = t3infstone + t3cavstone + t3rangestone + t3siegestone;
                totaloret3 = t3infore + t3cavore + t3rangeore + t3siegeore;
                totalfoodt3 = t3inffood + t3rangefood + t3cavfood + t3siegefood;
                totalgoldt3 = t3cavgold + t3infgold + t3rangegold + t3siegegold;


            }
            else if (t3sub == 3)
            {
                t3wood = T3TROOPCOSTWOOD * t3t4SUB_Lvl3; t3stone = T3TROOPCOSTSTONE * t3t4SUB_Lvl3; t3gold = T3TROOPCOSTGOLD * t3t4SUB_Lvl3; t3food = T3TROOPCOSTFOOD * t3t4SUB_Lvl3; t3ore = T3TROOPCOSTORE * t3t4SUB_Lvl3;
                t3infwood = Globals.t3inf * t3wood;
                t3inffood = Globals.t3inf * t3food;
                t3infore = Globals.t3inf * t3ore;
                t3rangewood = Globals.t3range * t3wood;
                t3rangefood = Globals.t3range * t3food;
                t3rangestone = Globals.t3range * t3stone;
                t3cavfood = Globals.t3cav * t3food;
                t3cavstone = Globals.t3cav * t3stone;
                t3cavore = Globals.t3cav * t3ore;
                t3cavgold = Globals.t3cav * t3gold;
                t3cavwood = 0;
                t3rangeore = 0;
                t3infstone = 0;
                t3infgold = Globals.t3inf * t3gold;
                t3rangegold = Globals.t3range * t3gold;
                t3siegefood = Globals.t3siege * t3food;
                t3siegestone = Globals.t3siege * t3stone;
                t3siegeore = Globals.t3siege * t3ore;
                t3siegewood = Globals.t3siege * t3wood;
                t3siegegold = Globals.t3siege * t3gold;
                totalwoodt3 = t3infwood + t3cavwood + t3rangewood + t3siegewood;
                totalstonet3 = t3infstone + t3cavstone + t3rangestone + t3siegestone;
                totaloret3 = t3infore + t3cavore + t3rangeore + t3siegeore;
                totalfoodt3 = t3inffood + t3rangefood + t3cavfood + t3siegefood;
                totalgoldt3 = t3cavgold + t3infgold + t3rangegold + t3siegegold;


            }
            else if (t3sub == 4)
            {
                t3wood = T3TROOPCOSTWOOD * t3t4SUB_Lvl4; t3stone = T3TROOPCOSTSTONE * t3t4SUB_Lvl4; t3gold = T3TROOPCOSTGOLD * t3t4SUB_Lvl4; t3food = T3TROOPCOSTFOOD * t3t4SUB_Lvl4; t3ore = T3TROOPCOSTORE * t3t4SUB_Lvl4;
                t3infwood = Globals.t3inf * t3wood;
                t3inffood = Globals.t3inf * t3food;
                t3infore = Globals.t3inf * t3ore;
                t3rangewood = Globals.t3range * t3wood;
                t3rangefood = Globals.t3range * t3food;
                t3rangestone = Globals.t3range * t3stone;
                t3cavfood = Globals.t3cav * t3food;
                t3cavstone = Globals.t3cav * t3stone;
                t3cavore = Globals.t3cav * t3ore;
                t3cavgold = Globals.t3cav * t3gold;
                t3cavwood = 0;
                t3rangeore = 0;
                t3infstone = 0;
                t3infgold = Globals.t3inf * t3gold;
                t3rangegold = Globals.t3range * t3gold;
                t3siegefood = Globals.t3siege * t3food;
                t3siegestone = Globals.t3siege * t3stone;
                t3siegeore = Globals.t3siege * t3ore;
                t3siegewood = Globals.t3siege * t3wood;
                t3siegegold = Globals.t3siege * t3gold;
                totalwoodt3 = t3infwood + t3cavwood + t3rangewood + t3siegewood;
                totalstonet3 = t3infstone + t3cavstone + t3rangestone + t3siegestone;
                totaloret3 = t3infore + t3cavore + t3rangeore + t3siegeore;
                totalfoodt3 = t3inffood + t3rangefood + t3cavfood + t3siegefood;
                totalgoldt3 = t3cavgold + t3infgold + t3rangegold + t3siegegold;


            }
            else if (t3sub == 5)
            {
                t3wood = T3TROOPCOSTWOOD * t3t4SUB_Lvl5; t3stone = T3TROOPCOSTSTONE * t3t4SUB_Lvl5; t3gold = T3TROOPCOSTGOLD * t3t4SUB_Lvl5; t3food = T3TROOPCOSTFOOD * t3t4SUB_Lvl5; t3ore = T3TROOPCOSTORE * t3t4SUB_Lvl5;
                t3infwood = Globals.t3inf * t3wood;
                t3inffood = Globals.t3inf * t3food;
                t3infore = Globals.t3inf * t3ore;
                t3rangewood = Globals.t3range * t3wood;
                t3rangefood = Globals.t3range * t3food;
                t3rangestone = Globals.t3range * t3stone;
                t3cavfood = Globals.t3cav * t3food;
                t3cavstone = Globals.t3cav * t3stone;
                t3cavore = Globals.t3cav * t3ore;
                t3cavgold = Globals.t3cav * t3gold;
                t3cavwood = 0;
                t3rangeore = 0;
                t3infstone = 0;
                t3infgold = Globals.t3inf * t3gold;
                t3rangegold = Globals.t3range * t3gold;
                t3siegefood = Globals.t3siege * t3food;
                t3siegestone = Globals.t3siege * t3stone;
                t3siegeore = Globals.t3siege * t3ore;
                t3siegewood = Globals.t3siege * t3wood;
                t3siegegold = Globals.t3siege * t3gold;
                totalwoodt3 = t3infwood + t3cavwood + t3rangewood + t3siegewood;
                totalstonet3 = t3infstone + t3cavstone + t3rangestone + t3siegestone;
                totaloret3 = t3infore + t3cavore + t3rangeore + t3siegeore;
                totalfoodt3 = t3inffood + t3rangefood + t3cavfood + t3siegefood;
                totalgoldt3 = t3cavgold + t3infgold + t3rangegold + t3siegegold;


            }
            else if (t3sub == 6)
            {
                t3wood = T3TROOPCOSTWOOD * t3t4SUB_Lvl6; t3stone = T3TROOPCOSTSTONE * t3t4SUB_Lvl6; t3gold = T3TROOPCOSTGOLD * t3t4SUB_Lvl6; t3food = T3TROOPCOSTFOOD * t3t4SUB_Lvl6; t3ore = T3TROOPCOSTORE * t3t4SUB_Lvl6;
                t3infwood = Globals.t3inf * t3wood;
                t3inffood = Globals.t3inf * t3food;
                t3infore = Globals.t3inf * t3ore;
                t3rangewood = Globals.t3range * t3wood;
                t3rangefood = Globals.t3range * t3food;
                t3rangestone = Globals.t3range * t3stone;
                t3cavfood = Globals.t3cav * t3food;
                t3cavstone = Globals.t3cav * t3stone;
                t3cavore = Globals.t3cav * t3ore;
                t3cavgold = Globals.t3cav * t3gold;
                t3cavwood = 0;
                t3rangeore = 0;
                t3infstone = 0;
                t3infgold = Globals.t3inf * t3gold;
                t3rangegold = Globals.t3range * t3gold;
                t3siegefood = Globals.t3siege * t3food;
                t3siegestone = Globals.t3siege * t3stone;
                t3siegeore = Globals.t3siege * t3ore;
                t3siegewood = Globals.t3siege * t3wood;
                t3siegegold = Globals.t3siege * t3gold;
                totalwoodt3 = t3infwood + t3cavwood + t3rangewood + t3siegewood;
                totalstonet3 = t3infstone + t3cavstone + t3rangestone + t3siegestone;
                totaloret3 = t3infore + t3cavore + t3rangeore + t3siegeore;
                totalfoodt3 = t3inffood + t3rangefood + t3cavfood + t3siegefood;
                totalgoldt3 = t3cavgold + t3infgold + t3rangegold + t3siegegold;

            }
            else if (t3sub == 7)
            {
                t3wood = T3TROOPCOSTWOOD * t3t4SUB_Lvl7; t3stone = T3TROOPCOSTSTONE * t3t4SUB_Lvl7; t3gold = T3TROOPCOSTGOLD * t3t4SUB_Lvl7; t3food = T3TROOPCOSTFOOD * t3t4SUB_Lvl7; t3ore = T3TROOPCOSTORE * t3t4SUB_Lvl7;
                t3infwood = Globals.t3inf * t3wood;
                t3inffood = Globals.t3inf * t3food;
                t3infore = Globals.t3inf * t3ore;
                t3rangewood = Globals.t3range * t3wood;
                t3rangefood = Globals.t3range * t3food;
                t3rangestone = Globals.t3range * t3stone;
                t3cavfood = Globals.t3cav * t3food;
                t3cavstone = Globals.t3cav * t3stone;
                t3cavore = Globals.t3cav * t3ore;
                t3cavgold = Globals.t3cav * t3gold;
                t3cavwood = 0;
                t3rangeore = 0;
                t3infstone = 0;
                t3infgold = Globals.t3inf * t3gold;
                t3rangegold = Globals.t3range * t3gold;
                t3siegefood = Globals.t3siege * t3food;
                t3siegestone = Globals.t3siege * t3stone;
                t3siegeore = Globals.t3siege * t3ore;
                t3siegewood = Globals.t3siege * t3wood;
                t3siegegold = Globals.t3siege * t3gold;
                totalwoodt3 = t3infwood + t3cavwood + t3rangewood + t3siegewood;
                totalstonet3 = t3infstone + t3cavstone + t3rangestone + t3siegestone;
                totaloret3 = t3infore + t3cavore + t3rangeore + t3siegeore;
                totalfoodt3 = t3inffood + t3rangefood + t3cavfood + t3siegefood;
                totalgoldt3 = t3cavgold + t3infgold + t3rangegold + t3siegegold;


            }
            else if (t3sub == 8)
            {
                t3wood = T3TROOPCOSTWOOD * t3t4SUB_Lvl8; t3stone = T3TROOPCOSTSTONE * t3t4SUB_Lvl8; t3gold = T3TROOPCOSTGOLD * t3t4SUB_Lvl8; t3food = T3TROOPCOSTFOOD * t3t4SUB_Lvl8; t3ore = T3TROOPCOSTORE * t3t4SUB_Lvl8;
                t3infwood = Globals.t3inf * t3wood;
                t3inffood = Globals.t3inf * t3food;
                t3infore = Globals.t3inf * t3ore;
                t3rangewood = Globals.t3range * t3wood;
                t3rangefood = Globals.t3range * t3food;
                t3rangestone = Globals.t3range * t3stone;
                t3cavfood = Globals.t3cav * t3food;
                t3cavstone = Globals.t3cav * t3stone;
                t3cavore = Globals.t3cav * t3ore;
                t3cavgold = Globals.t3cav * t3gold;
                t3cavwood = 0;
                t3rangeore = 0;
                t3infstone = 0;
                t3infgold = Globals.t3inf * t3gold;
                t3rangegold = Globals.t3range * t3gold;
                t3siegefood = Globals.t3siege * t3food;
                t3siegestone = Globals.t3siege * t3stone;
                t3siegeore = Globals.t3siege * t3ore;
                t3siegewood = Globals.t3siege * t3wood;
                t3siegegold = Globals.t3siege * t3gold;
                totalwoodt3 = t3infwood + t3cavwood + t3rangewood + t3siegewood;
                totalstonet3 = t3infstone + t3cavstone + t3rangestone + t3siegestone;
                totaloret3 = t3infore + t3cavore + t3rangeore + t3siegeore;
                totalfoodt3 = t3inffood + t3rangefood + t3cavfood + t3siegefood;
                totalgoldt3 = t3cavgold + t3infgold + t3rangegold + t3siegegold;


            }
            else if (t3sub == 9)
            {
                t3wood = T3TROOPCOSTWOOD * t3t4SUB_Lvl9; t3stone = T3TROOPCOSTSTONE * t3t4SUB_Lvl9; t3gold = T3TROOPCOSTGOLD * t3t4SUB_Lvl9; t3food = T3TROOPCOSTFOOD * t3t4SUB_Lvl9; t3ore = T3TROOPCOSTORE * t3t4SUB_Lvl9;
                t3infwood = Globals.t3inf * t3wood;
                t3inffood = Globals.t3inf * t3food;
                t3infore = Globals.t3inf * t3ore;
                t3rangewood = Globals.t3range * t3wood;
                t3rangefood = Globals.t3range * t3food;
                t3rangestone = Globals.t3range * t3stone;
                t3cavfood = Globals.t3cav * t3food;
                t3cavstone = Globals.t3cav * t3stone;
                t3cavore = Globals.t3cav * t3ore;
                t3cavgold = Globals.t3cav * t3gold;
                t3cavwood = 0;
                t3rangeore = 0;
                t3infstone = 0;
                t3infgold = Globals.t3inf * t3gold;
                t3rangegold = Globals.t3range * t3gold;
                t3siegefood = Globals.t3siege * t3food;
                t3siegestone = Globals.t3siege * t3stone;
                t3siegeore = Globals.t3siege * t3ore;
                t3siegewood = Globals.t3siege * t3wood;
                t3siegegold = Globals.t3siege * t3gold;
                totalwoodt3 = t3infwood + t3cavwood + t3rangewood + t3siegewood;
                totalstonet3 = t3infstone + t3cavstone + t3rangestone + t3siegestone;
                totaloret3 = t3infore + t3cavore + t3rangeore + t3siegeore;
                totalfoodt3 = t3inffood + t3rangefood + t3cavfood + t3siegefood;
                totalgoldt3 = t3cavgold + t3infgold + t3rangegold + t3siegegold;


            }
            else if (t3sub == 10)
            {
                t3wood = T3TROOPCOSTWOOD * t3t4SUB_Lvl10; t3stone = T3TROOPCOSTSTONE * t3t4SUB_Lvl10; t3gold = T3TROOPCOSTGOLD * t3t4SUB_Lvl10; t3food = T3TROOPCOSTFOOD * t3t4SUB_Lvl10; t3ore = T3TROOPCOSTORE * t3t4SUB_Lvl10;
                t3infwood = Globals.t3inf * t3wood;
                t3inffood = Globals.t3inf * t3food;
                t3infore = Globals.t3inf * t3ore;
                t3rangewood = Globals.t3range * t3wood;
                t3rangefood = Globals.t3range * t3food;
                t3rangestone = Globals.t3range * t3stone;
                t3cavfood = Globals.t3cav * t3food;
                t3cavstone = Globals.t3cav * t3stone;
                t3cavore = Globals.t3cav * t3ore;
                t3cavgold = Globals.t3cav * t3gold;
                t3cavwood = 0;
                t3rangeore = 0;
                t3infstone = 0;
                t3infgold = Globals.t3inf * t3gold;
                t3rangegold = Globals.t3range * t3gold;
                t3siegefood = Globals.t3siege * t3food;
                t3siegestone = Globals.t3siege * t3stone;
                t3siegeore = Globals.t3siege * t3ore;
                t3siegewood = Globals.t3siege * t3wood;
                t3siegegold = Globals.t3siege * t3gold;
                totalwoodt3 = t3infwood + t3cavwood + t3rangewood + t3siegewood;
                totalstonet3 = t3infstone + t3cavstone + t3rangestone + t3siegestone;
                totaloret3 = t3infore + t3cavore + t3rangeore + t3siegeore;
                totalfoodt3 = t3inffood + t3rangefood + t3cavfood + t3siegefood;
                totalgoldt3 = t3cavgold + t3infgold + t3rangegold + t3siegegold;


            }
            else
            {
                t3wood = T3TROOPCOSTWOOD; t3stone = T3TROOPCOSTSTONE; t3gold = T3TROOPCOSTGOLD; t3food = T3TROOPCOSTFOOD; t3ore = T3TROOPCOSTORE;
                t3infwood = Globals.t3inf * t3wood;
                t3inffood = Globals.t3inf * t3food;
                t3infore = Globals.t3inf * t3ore;
                t3rangewood = Globals.t3range * t3wood;
                t3rangefood = Globals.t3range * t3food;
                t3rangestone = Globals.t3range * t3stone;
                t3cavfood = Globals.t3cav * t3food;
                t3cavstone = Globals.t3cav * t3stone;
                t3cavore = Globals.t3cav * t3ore;
                t3cavgold = Globals.t3cav * t3gold;
                t3cavwood = 0;
                t3rangeore = 0;
                t3infstone = 0;
                t3infgold = Globals.t3inf * t3gold;
                t3rangegold = Globals.t3range * t3gold;
                t3siegefood = Globals.t3siege * t3food;
                t3siegestone = Globals.t3siege * t3stone;
                t3siegeore = Globals.t3siege * t3ore;
                t3siegewood = Globals.t3siege * t3wood;
                t3siegegold = Globals.t3siege * t3gold;
                totalwoodt3 = t3infwood + t3cavwood + t3rangewood + t3siegewood;
                totalstonet3 = t3infstone + t3cavstone + t3rangestone + t3siegestone;
                totaloret3 = t3infore + t3cavore + t3rangeore + t3siegeore;
                totalfoodt3 = t3inffood + t3rangefood + t3cavfood + t3siegefood;
                totalgoldt3 = t3cavgold + t3infgold + t3rangegold + t3siegegold;


            }
            try
            {
                t4sub = double.Parse(T4SubsidyTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number 0-10", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (t4sub == 1)
            {
                t4wood = T4TROOPCOSTWOOD * t3t4SUB_Lvl1; t4stone = T4TROOPCOSTSTONE * t3t4SUB_Lvl1; t4gold = T4TROOPCOSTGOLD * t3t4SUB_Lvl1; t4food = T4TROOPCOSTFOOD * t3t4SUB_Lvl1; t4ore = T4TROOPCOSTORE * t3t4SUB_Lvl1;
                t4infwood = Globals.t4inf * t4wood;
                t4inffood = Globals.t4inf * t4food;
                t4infore = Globals.t4inf * t4ore;
                t4rangewood = Globals.t4range * t4wood;
                t4rangefood = Globals.t4range * t4food;
                t4rangestone = Globals.t4range * t4stone;
                t4cavfood = Globals.t4cav * t4food;
                t4cavstone = Globals.t4cav * t4stone;
                t4cavore = Globals.t4cav * t4ore;
                t4cavgold = Globals.t4cav * t4gold;
                t4cavwood = 0;
                t4rangeore = 0;
                t4infstone = 0;
                t4infgold = Globals.t4inf * t4gold;
                t4rangegold = Globals.t4range * t4gold;
                t4siegefood = Globals.t4siege * t4food;
                t4siegewood = Globals.t4siege * t4wood;
                t4siegestone = Globals.t4siege * t4stone;
                t4siegeore = Globals.t4siege * t4ore;
                t4siegegold = Globals.t4siege * t4gold;
                totalwoodt4 = t4infwood + t4cavwood + t4rangewood+t4siegewood;
                totalstonet4 = t4infstone + t4cavstone + t4rangestone+t4siegestone;
                totaloret4 = t4infore + t4cavore + t4rangeore+t4siegeore;
                totalfoodt4 = t4inffood + t4rangefood + t4cavfood+t4siegefood;
                totalgoldt4 = t4cavgold + t4infgold + t4rangegold+t4siegegold;

                
            }
            else if (t4sub == 2)
            {
                t4wood = T4TROOPCOSTWOOD * t3t4SUB_Lvl2; t4stone = T4TROOPCOSTSTONE * t3t4SUB_Lvl2; t4gold = T4TROOPCOSTGOLD * t3t4SUB_Lvl2; t4food = T4TROOPCOSTFOOD * t3t4SUB_Lvl2; t4ore = T4TROOPCOSTORE * t3t4SUB_Lvl2;
                t4infwood = Globals.t4inf * t4wood;
                t4inffood = Globals.t4inf * t4food;
                t4infore = Globals.t4inf * t4ore;
                t4rangewood = Globals.t4range * t4wood;
                t4rangefood = Globals.t4range * t4food;
                t4rangestone = Globals.t4range * t4stone;
                t4cavfood = Globals.t4cav * t4food;
                t4cavstone = Globals.t4cav * t4stone;
                t4cavore = Globals.t4cav * t4ore;
                t4cavgold = Globals.t4cav * t4gold;
                t4cavwood = 0;
                t4rangeore = 0;
                t4infstone = 0;
                t4infgold = Globals.t4inf * t4gold;
                t4rangegold = Globals.t4range * t4gold;
                t4siegefood = Globals.t4siege * t4food;
                t4siegewood = Globals.t4siege * t4wood;
                t4siegestone = Globals.t4siege * t4stone;
                t4siegeore = Globals.t4siege * t4ore;
                t4siegegold = Globals.t4siege * t4gold;
                totalwoodt4 = t4infwood + t4cavwood + t4rangewood + t4siegewood;
                totalstonet4 = t4infstone + t4cavstone + t4rangestone + t4siegestone;
                totaloret4 = t4infore + t4cavore + t4rangeore + t4siegeore;
                totalfoodt4 = t4inffood + t4rangefood + t4cavfood + t4siegefood;
                totalgoldt4 = t4cavgold + t4infgold + t4rangegold + t4siegegold;


            }
            else if (t4sub == 3)
            {
                t4wood = T4TROOPCOSTWOOD * t3t4SUB_Lvl3; t4stone = T4TROOPCOSTSTONE * t3t4SUB_Lvl3; t4gold = T4TROOPCOSTGOLD * t3t4SUB_Lvl3; t4food = T4TROOPCOSTFOOD * t3t4SUB_Lvl3; t4ore = T4TROOPCOSTORE * t3t4SUB_Lvl3;
                t4infwood = Globals.t4inf * t4wood;
                t4inffood = Globals.t4inf * t4food;
                t4infore = Globals.t4inf * t4ore;
                t4rangewood = Globals.t4range * t4wood;
                t4rangefood = Globals.t4range * t4food;
                t4rangestone = Globals.t4range * t4stone;
                t4cavfood = Globals.t4cav * t4food;
                t4cavstone = Globals.t4cav * t4stone;
                t4cavore = Globals.t4cav * t4ore;
                t4cavgold = Globals.t4cav * t4gold;
                t4cavwood = 0;
                t4rangeore = 0;
                t4infstone = 0;
                t4infgold = Globals.t4inf * t4gold;
                t4rangegold = Globals.t4range * t4gold;
                t4siegefood = Globals.t4siege * t4food;
                t4siegewood = Globals.t4siege * t4wood;
                t4siegestone = Globals.t4siege * t4stone;
                t4siegeore = Globals.t4siege * t4ore;
                t4siegegold = Globals.t4siege * t4gold;
                totalwoodt4 = t4infwood + t4cavwood + t4rangewood + t4siegewood;
                totalstonet4 = t4infstone + t4cavstone + t4rangestone + t4siegestone;
                totaloret4 = t4infore + t4cavore + t4rangeore + t4siegeore;
                totalfoodt4 = t4inffood + t4rangefood + t4cavfood + t4siegefood;
                totalgoldt4 = t4cavgold + t4infgold + t4rangegold + t4siegegold;


            }
            else if (t4sub == 4)
            {
                t4wood = T4TROOPCOSTWOOD * t3t4SUB_Lvl4; t4stone = T4TROOPCOSTSTONE * t3t4SUB_Lvl4; t4gold = T4TROOPCOSTGOLD * t3t4SUB_Lvl4; t4food = T4TROOPCOSTFOOD * t3t4SUB_Lvl4; t4ore = T4TROOPCOSTORE * t3t4SUB_Lvl4;
                t4infwood = Globals.t4inf * t4wood;
                t4inffood = Globals.t4inf * t4food;
                t4infore = Globals.t4inf * t4ore;
                t4rangewood = Globals.t4range * t4wood;
                t4rangefood = Globals.t4range * t4food;
                t4rangestone = Globals.t4range * t4stone;
                t4cavfood = Globals.t4cav * t4food;
                t4cavstone = Globals.t4cav * t4stone;
                t4cavore = Globals.t4cav * t4ore;
                t4cavgold = Globals.t4cav * t4gold;
                t4cavwood = 0;
                t4rangeore = 0;
                t4infstone = 0;
                t4infgold = Globals.t4inf * t4gold;
                t4rangegold = Globals.t4range * t4gold;
                t4siegefood = Globals.t4siege * t4food;
                t4siegewood = Globals.t4siege * t4wood;
                t4siegestone = Globals.t4siege * t4stone;
                t4siegeore = Globals.t4siege * t4ore;
                t4siegegold = Globals.t4siege * t4gold;
                totalwoodt4 = t4infwood + t4cavwood + t4rangewood + t4siegewood;
                totalstonet4 = t4infstone + t4cavstone + t4rangestone + t4siegestone;
                totaloret4 = t4infore + t4cavore + t4rangeore + t4siegeore;
                totalfoodt4 = t4inffood + t4rangefood + t4cavfood + t4siegefood;
                totalgoldt4 = t4cavgold + t4infgold + t4rangegold + t4siegegold;

            }
            else if (t4sub == 5)
            {
                t4wood = T4TROOPCOSTWOOD * t3t4SUB_Lvl5; t4stone = T4TROOPCOSTSTONE * t3t4SUB_Lvl5; t4gold = T4TROOPCOSTGOLD * t3t4SUB_Lvl5; t4food = T4TROOPCOSTFOOD * t3t4SUB_Lvl5; t4ore = T4TROOPCOSTORE * t3t4SUB_Lvl5;
                t4infwood = Globals.t4inf * t4wood;
                t4inffood = Globals.t4inf * t4food;
                t4infore = Globals.t4inf * t4ore;
                t4rangewood = Globals.t4range * t4wood;
                t4rangefood = Globals.t4range * t4food;
                t4rangestone = Globals.t4range * t4stone;
                t4cavfood = Globals.t4cav * t4food;
                t4cavstone = Globals.t4cav * t4stone;
                t4cavore = Globals.t4cav * t4ore;
                t4cavgold = Globals.t4cav * t4gold;
                t4cavwood = 0;
                t4rangeore = 0;
                t4infstone = 0;
                t4infgold = Globals.t4inf * t4gold;
                t4rangegold = Globals.t4range * t4gold;
                t4siegefood = Globals.t4siege * t4food;
                t4siegewood = Globals.t4siege * t4wood;
                t4siegestone = Globals.t4siege * t4stone;
                t4siegeore = Globals.t4siege * t4ore;
                t4siegegold = Globals.t4siege * t4gold;
                totalwoodt4 = t4infwood + t4cavwood + t4rangewood + t4siegewood;
                totalstonet4 = t4infstone + t4cavstone + t4rangestone + t4siegestone;
                totaloret4 = t4infore + t4cavore + t4rangeore + t4siegeore;
                totalfoodt4 = t4inffood + t4rangefood + t4cavfood + t4siegefood;
                totalgoldt4 = t4cavgold + t4infgold + t4rangegold + t4siegegold;

            }
            else if (t4sub == 6)
            {
                t4wood = T4TROOPCOSTWOOD * t3t4SUB_Lvl6; t4stone = T4TROOPCOSTSTONE * t3t4SUB_Lvl6; t4gold = T4TROOPCOSTGOLD * t3t4SUB_Lvl6; t4food = T4TROOPCOSTFOOD * t3t4SUB_Lvl6; t4ore = T4TROOPCOSTORE * t3t4SUB_Lvl6;
                t4infwood = Globals.t4inf * t4wood;
                t4inffood = Globals.t4inf * t4food;
                t4infore = Globals.t4inf * t4ore;
                t4rangewood = Globals.t4range * t4wood;
                t4rangefood = Globals.t4range * t4food;
                t4rangestone = Globals.t4range * t4stone;
                t4cavfood = Globals.t4cav * t4food;
                t4cavstone = Globals.t4cav * t4stone;
                t4cavore = Globals.t4cav * t4ore;
                t4cavgold = Globals.t4cav * t4gold;
                t4cavwood = 0;
                t4rangeore = 0;
                t4infstone = 0;
                t4infgold = Globals.t4inf * t4gold;
                t4rangegold = Globals.t4range * t4gold;
                t4siegefood = Globals.t4siege * t4food;
                t4siegewood = Globals.t4siege * t4wood;
                t4siegestone = Globals.t4siege * t4stone;
                t4siegeore = Globals.t4siege * t4ore;
                t4siegegold = Globals.t4siege * t4gold;
                totalwoodt4 = t4infwood + t4cavwood + t4rangewood + t4siegewood;
                totalstonet4 = t4infstone + t4cavstone + t4rangestone + t4siegestone;
                totaloret4 = t4infore + t4cavore + t4rangeore + t4siegeore;
                totalfoodt4 = t4inffood + t4rangefood + t4cavfood + t4siegefood;
                totalgoldt4 = t4cavgold + t4infgold + t4rangegold + t4siegegold;


            }
            else if (t4sub == 7)
            {
                t4wood = T4TROOPCOSTWOOD * t3t4SUB_Lvl7; t4stone = T4TROOPCOSTSTONE * t3t4SUB_Lvl7; t4gold = T4TROOPCOSTGOLD * t3t4SUB_Lvl7; t4food = T4TROOPCOSTFOOD * t3t4SUB_Lvl7; t4ore = T4TROOPCOSTORE * t3t4SUB_Lvl7;
                t4infwood = Globals.t4inf * t4wood;
                t4inffood = Globals.t4inf * t4food;
                t4infore = Globals.t4inf * t4ore;
                t4rangewood = Globals.t4range * t4wood;
                t4rangefood = Globals.t4range * t4food;
                t4rangestone = Globals.t4range * t4stone;
                t4cavfood = Globals.t4cav * t4food;
                t4cavstone = Globals.t4cav * t4stone;
                t4cavore = Globals.t4cav * t4ore;
                t4cavgold = Globals.t4cav * t4gold;
                t4cavwood = 0;
                t4rangeore = 0;
                t4infstone = 0;
                t4infgold = Globals.t4inf * t4gold;
                t4rangegold = Globals.t4range * t4gold;
                t4siegefood = Globals.t4siege * t4food;
                t4siegewood = Globals.t4siege * t4wood;
                t4siegestone = Globals.t4siege * t4stone;
                t4siegeore = Globals.t4siege * t4ore;
                t4siegegold = Globals.t4siege * t4gold;
                totalwoodt4 = t4infwood + t4cavwood + t4rangewood + t4siegewood;
                totalstonet4 = t4infstone + t4cavstone + t4rangestone + t4siegestone;
                totaloret4 = t4infore + t4cavore + t4rangeore + t4siegeore;
                totalfoodt4 = t4inffood + t4rangefood + t4cavfood + t4siegefood;
                totalgoldt4 = t4cavgold + t4infgold + t4rangegold + t4siegegold;


            }
            else if (t4sub == 8)
            {
                t4wood = T4TROOPCOSTWOOD * t3t4SUB_Lvl8; t4stone = T4TROOPCOSTSTONE * t3t4SUB_Lvl8; t4gold = T4TROOPCOSTGOLD * t3t4SUB_Lvl8; t4food = T4TROOPCOSTFOOD * t3t4SUB_Lvl8; t4ore = T4TROOPCOSTORE * t3t4SUB_Lvl8;
                t4infwood = Globals.t4inf * t4wood;
                t4inffood = Globals.t4inf * t4food;
                t4infore = Globals.t4inf * t4ore;
                t4rangewood = Globals.t4range * t4wood;
                t4rangefood = Globals.t4range * t4food;
                t4rangestone = Globals.t4range * t4stone;
                t4cavfood = Globals.t4cav * t4food;
                t4cavstone = Globals.t4cav * t4stone;
                t4cavore = Globals.t4cav * t4ore;
                t4cavgold = Globals.t4cav * t4gold;
                t4cavwood = 0;
                t4rangeore = 0;
                t4infstone = 0;
                t4infgold = Globals.t4inf * t4gold;
                t4rangegold = Globals.t4range * t4gold;
                t4siegefood = Globals.t4siege * t4food;
                t4siegewood = Globals.t4siege * t4wood;
                t4siegestone = Globals.t4siege * t4stone;
                t4siegeore = Globals.t4siege * t4ore;
                t4siegegold = Globals.t4siege * t4gold;
                totalwoodt4 = t4infwood + t4cavwood + t4rangewood + t4siegewood;
                totalstonet4 = t4infstone + t4cavstone + t4rangestone + t4siegestone;
                totaloret4 = t4infore + t4cavore + t4rangeore + t4siegeore;
                totalfoodt4 = t4inffood + t4rangefood + t4cavfood + t4siegefood;
                totalgoldt4 = t4cavgold + t4infgold + t4rangegold + t4siegegold;


            }
            else if (t4sub == 9)
            {
                t4wood = T4TROOPCOSTWOOD * t3t4SUB_Lvl9; t4stone = T4TROOPCOSTSTONE * t3t4SUB_Lvl9; t4gold = T4TROOPCOSTGOLD * t3t4SUB_Lvl9; t4food = T4TROOPCOSTFOOD * t3t4SUB_Lvl9; t4ore = T4TROOPCOSTORE * t3t4SUB_Lvl9;
                t4infwood = Globals.t4inf * t4wood;
                t4inffood = Globals.t4inf * t4food;
                t4infore = Globals.t4inf * t4ore;
                t4rangewood = Globals.t4range * t4wood;
                t4rangefood = Globals.t4range * t4food;
                t4rangestone = Globals.t4range * t4stone;
                t4cavfood = Globals.t4cav * t4food;
                t4cavstone = Globals.t4cav * t4stone;
                t4cavore = Globals.t4cav * t4ore;
                t4cavgold = Globals.t4cav * t4gold;
                t4cavwood = 0;
                t4rangeore = 0;
                t4infstone = 0;
                t4infgold = Globals.t4inf * t4gold;
                t4rangegold = Globals.t4range * t4gold;
                t4siegefood = Globals.t4siege * t4food;
                t4siegewood = Globals.t4siege * t4wood;
                t4siegestone = Globals.t4siege * t4stone;
                t4siegeore = Globals.t4siege * t4ore;
                t4siegegold = Globals.t4siege * t4gold;
                totalwoodt4 = t4infwood + t4cavwood + t4rangewood + t4siegewood;
                totalstonet4 = t4infstone + t4cavstone + t4rangestone + t4siegestone;
                totaloret4 = t4infore + t4cavore + t4rangeore + t4siegeore;
                totalfoodt4 = t4inffood + t4rangefood + t4cavfood + t4siegefood;
                totalgoldt4 = t4cavgold + t4infgold + t4rangegold + t4siegegold;


            }
            else if (t4sub == 10)
            {
                t4wood = T4TROOPCOSTWOOD * t3t4SUB_Lvl10; t4stone = T4TROOPCOSTSTONE * t3t4SUB_Lvl10; t4gold = T4TROOPCOSTGOLD * t3t4SUB_Lvl10; t4food = T4TROOPCOSTFOOD * t3t4SUB_Lvl10; t4ore = T4TROOPCOSTORE * t3t4SUB_Lvl10;
                t4infwood = Globals.t4inf * t4wood;
                t4inffood = Globals.t4inf * t4food;
                t4infore = Globals.t4inf * t4ore;
                t4rangewood = Globals.t4range * t4wood;
                t4rangefood = Globals.t4range * t4food;
                t4rangestone = Globals.t4range * t4stone;
                t4cavfood = Globals.t4cav * t4food;
                t4cavstone = Globals.t4cav * t4stone;
                t4cavore = Globals.t4cav * t4ore;
                t4cavgold = Globals.t4cav * t4gold;
                t4cavwood = 0;
                t4rangeore = 0;
                t4infstone = 0;
                t4infgold = Globals.t4inf * t4gold;
                t4rangegold = Globals.t4range * t4gold;
                t4siegefood = Globals.t4siege * t4food;
                t4siegewood = Globals.t4siege * t4wood;
                t4siegestone = Globals.t4siege * t4stone;
                t4siegeore = Globals.t4siege * t4ore;
                t4siegegold = Globals.t4siege * t4gold;
                totalwoodt4 = t4infwood + t4cavwood + t4rangewood + t4siegewood;
                totalstonet4 = t4infstone + t4cavstone + t4rangestone + t4siegestone;
                totaloret4 = t4infore + t4cavore + t4rangeore + t4siegeore;
                totalfoodt4 = t4inffood + t4rangefood + t4cavfood + t4siegefood;
                totalgoldt4 = t4cavgold + t4infgold + t4rangegold + t4siegegold;


            }
            else
            {
                t4wood = T4TROOPCOSTWOOD; t4ore = T4TROOPCOSTORE; t4food = T4TROOPCOSTFOOD; t4stone = T4TROOPCOSTSTONE; t4gold = T4TROOPCOSTGOLD;
                t4infwood = Globals.t4inf * t4wood;
                t4inffood = Globals.t4inf * t4food;
                t4infore = Globals.t4inf * t4ore;
                t4rangewood = Globals.t4range * t4wood;
                t4rangefood = Globals.t4range * t4food;
                t4rangestone = Globals.t4range * t4stone;
                t4cavfood = Globals.t4cav * t4food;
                t4cavstone = Globals.t4cav * t4stone;
                t4cavore = Globals.t4cav * t4ore;
                t4cavgold = Globals.t4cav * t4gold;
                t4cavwood = 0;
                t4rangeore = 0;
                t4infstone = 0;
                t4infgold = Globals.t4inf * t4gold;
                t4rangegold = Globals.t4range * t4gold;
                t4siegefood = Globals.t4siege * t4food;
                t4siegewood = Globals.t4siege * t4wood;
                t4siegestone = Globals.t4siege * t4stone;
                t4siegeore = Globals.t4siege * t4ore;
                t4siegegold = Globals.t4siege * t4gold;
                totalwoodt4 = t4infwood + t4cavwood + t4rangewood + t4siegewood;
                totalstonet4 = t4infstone + t4cavstone + t4rangestone + t4siegestone;
                totaloret4 = t4infore + t4cavore + t4rangeore + t4siegeore;
                totalfoodt4 = t4inffood + t4rangefood + t4cavfood + t4siegefood;
                totalgoldt4 = t4cavgold + t4infgold + t4rangegold + t4siegegold;


            }
            double totalFood;
            double totalStone;
            double totalWood;
            double totalOre;
            double totalGold;
            totalFood = totalfoodt1 + totalfoodt2 + totalfoodt3 + totalfoodt4;
            totalStone = totalstonet1 + totalstonet2 + totalstonet3 + totalstonet4;
            totalWood = totalwoodt1 + totalwoodt2 + totalwoodt3 + totalwoodt4;
            totalOre = totaloret1 + totaloret2 + totaloret3 + totaloret4;
            totalGold = totalgoldt1 + totalgoldt2 + totalgoldt3 + totalgoldt4;
            TotalWoodLable.Text = totalWood.ToString("F0");
            FoodLabel.Text = totalFood.ToString("F0");
            StoneLabel.Text = totalStone.ToString("F0");
            OreLabel.Text = totalOre.ToString("F0");
            TotalGoldLbl.Text = totalGold.ToString("F0");
            
        }

      
    }
}
