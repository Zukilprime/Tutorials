using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            cbAbility.SelectedIndex = 0;
            cbProf.SelectedIndex = 0;
            cbBoost.SelectedIndex = 0;
            cbDiff.SelectedIndex = 0;
            cbChal.SelectedIndex = 0;
            cbSetB.SelectedIndex = 0;

            Random rnd = new Random();
            string[] boostDice = { "Blank", "Blank", "Success", "Success and Advantage", "Double Advantage", "Advantage" };
            string[] abilityDice = { "Blank", "Success", "Success", "Double Success", "Advantage", "Advantage", "Success and Advantage", "Double Advantage" };
            string[] proficiencyDice = {"Blank","Success","Success","Double Success","Double Success","Advantage","Success and Advantage",
                                  "Success and Advantage","Success and Advantage","Double Advantage","Double Advantage","Triumph" };
            string[] setbackDice = { "Blank", "Blank", "Failure", "Failure", "Threat", "Threat" };
            string[] difficultyDice = { "Blank", "Failure", "Double Failure", "Threat", "Threat", "Threat", "Double Threat", "Failure and Threat" };
            string[] challengeDice = {"Blank","Failure","Failure","Double Failure","Double Failure","Threat","Threat","Failure and Threat",
                                  "Failure and Threat","Double Threat","Double Threat","Despair" };

            int boostIndex = rnd.Next(boostDice.Length);
            int abilityIndex = rnd.Next(abilityDice.Length);
            int proficiencyIndex = rnd.Next(proficiencyDice.Length);
            int setBackIndex = rnd.Next(setbackDice.Length);
            int difficultyIndex = rnd.Next(setbackDice.Length);
            int challengeIndex = rnd.Next(setbackDice.Length);

            //RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            //var byteArray = new byte[4];
            //provider.GetBytes(byteArray);
            //var randomInteger = BitConverter.ToUInt32(byteArray, 0);

            txtResult.Clear();
            txtResult.Text += ("Roll Results: "+"\r\n");
            txtResult.Text += ("Boost dice:         " + boostDice[boostIndex]+"\r\n");
            txtResult.Text += ("Ability dice:       " + abilityDice[abilityIndex] + "\r\n");
            txtResult.Text += ("Proficiency dice:   " + proficiencyDice[proficiencyIndex] + "\r\n");
            txtResult.Text += ("Set Back dice:      " + setbackDice[setBackIndex] + "\r\n");
            txtResult.Text += ("Difficulty dice:    " + difficultyDice[difficultyIndex] + "\r\n");
            txtResult.Text += ("Challenge dice:     " + challengeDice[challengeIndex] + "\r\n");




        }

        





        //private void cbAbility_SelectedIndexChanged(object sender, EventArgs e)
        //{
            
        //}

        //private void cbProf_SelectedIndexChanged(object sender, EventArgs e)
        //{
            
        //}

        //private void cbBoost_SelectedIndexChanged(object sender, EventArgs e)
        //{
            
        //}

        //private void cbDiff_SelectedIndexChanged(object sender, EventArgs e)
        //{
            
        //}

        //private void cbChal_SelectedIndexChanged(object sender, EventArgs e)
        //{
            
        //}

        //private void cbSetB_SelectedIndexChanged(object sender, EventArgs e)
        //{
            
        //}

        //private void btnAbilityPlusOne_Click(object sender, EventArgs e)
        //{
        //    Random rnd = new Random();

        //    string[] abilityDice = { "Blank", "Success", "Success", "Double Success", "Advantage", "Advantage", "Success and Advantage", "Double Advantage" };
        //    int abilityIndex = rnd.Next(abilityDice.Length);
            




        //    txtResult.Text += ("Ability dice:       " + abilityDice[abilityIndex] + "\r\n");
        //}

        //private void btnProfPlusOne_Click(object sender, EventArgs e)
        //{
        //    txtResult.Text += ("Proficiency dice:   " + proficiencyDice[proficiencyIndex] + "\r\n");
        //}

        //private void btnBoostPlusOne_Click(object sender, EventArgs e)
        //{
        //    txtResult.Text += ("Boost dice:         " + boostDice[boostIndex] + "\r\n");
        //}

        //private void btnDiffPlusOne_Click(object sender, EventArgs e)
        //{
        //    txtResult.Text += ("Difficulty dice:    " + difficultyDice[difficultyIndex] + "\r\n");
        //}

        //private void btnChalPlusOne_Click(object sender, EventArgs e)
        //{
        //    txtResult.Text += ("Challenge dice:     " + challengeDice[challengeIndex] + "\r\n");
        //}

        //private void btnSetBackPlusOne_Click(object sender, EventArgs e)
        //{
        //    txtResult.Text += ("Set Back dice:      " + setbackDice[setBackIndex] + "\r\n");
        //}
    }
}
