using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdventureGame
{
    public partial class CharacterCreation : Form
    {
        int str;
        int dex;
        int wis;
        int intel;
        int cha;

        public CharacterCreation()
        {
            InitializeComponent();
        }

        private void CharacterCreation_Load(object sender, EventArgs e)
        {
            lblStrengthScore.Text = "";
            lblDexterityScore.Text = "";
            lblWisdomScore.Text = "";
            lblIntelligenceScore.Text = "";
            lblCharmScore.Text = "";

            pict


        }

        private void cbCharacterImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCharacterImage.Text == "Archer")
                pbCharacterImage.Image = Properties.Resources.Archer;
            else if (cbCharacterImage.Text == "Dino Wizard")
                pbCharacterImage.Image = Properties.Resources.DinoMan;
            else if (cbCharacterImage.Text == "Fighter")
                pbCharacterImage.Image = Properties.Resources.Fighter;
            else if (cbCharacterImage.Text == "Frog Fighter")
                pbCharacterImage.Image = Properties.Resources.FrogFighter;
            else if (cbCharacterImage.Text == "Rogue")
                pbCharacterImage.Image = Properties.Resources.Rogue;
            else if (cbCharacterImage.Text == "Tinker")
                pbCharacterImage.Image = Properties.Resources.Tinkerer;
            else if (cbCharacterImage.Text == "Wizard")
                pbCharacterImage.Image = Properties.Resources.Wizard;

            pbCharacterImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void cbStrength_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbStrength.Text == "<Reset>")
            {

            }
        }

        private void cbDexterity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbWisdom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbIntelligence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCharm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            cbStrength.Items.Clear();
            cbDexterity.Items.Clear();
            cbWisdom.Items.Clear();
            cbIntelligence.Items.Clear();
            cbCharm.Items.Clear();

            if(str != 1 && )
        }
    }
}
