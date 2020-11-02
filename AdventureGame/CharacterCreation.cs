using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        string name;
        string picture;

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
                str = 0;
                Reset();
                cbStrength.Text = "Strength";
                lblStrengthScore.Text = "";
            }
            else
            {
                str = Convert.ToInt32(cbStrength.Text);
                lblStrengthScore.Text = cbStrength.Text;
                cbStrength.Items.Clear();
                cbStrength.Items.Add("<Reset>");
                cbDexterity.Items.Remove(cbStrength.Text);
                cbWisdom.Items.Remove(cbStrength.Text);
                cbIntelligence.Items.Remove(cbStrength.Text);
                cbCharm.Items.Remove(cbStrength.Text);
            }

        }

        private void cbDexterity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDexterity.Text == "<Reset>")
            {
                dex = 0;
                Reset();
                cbDexterity.Text = "Dexterity";
                lblDexterityScore.Text = "";
            }
            else
            {
                dex = Convert.ToInt32(cbDexterity.Text);
                lblDexterityScore.Text = cbDexterity.Text;
                cbStrength.Items.Remove(cbDexterity.Text);
                cbDexterity.Items.Clear();
                cbDexterity.Items.Add("<Reset>");
                cbWisdom.Items.Remove(cbDexterity.Text);
                cbIntelligence.Items.Remove(cbDexterity.Text);
                cbCharm.Items.Remove(cbDexterity.Text);
            }
        }

        private void cbWisdom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWisdom.Text == "<Reset>")
            {
                wis = 0;
                Reset();
                cbWisdom.Text = "Wisdom";
                lblWisdomScore.Text = "";
            }
            else
            {
                wis = Convert.ToInt32(cbWisdom.Text);
                lblWisdomScore.Text = cbWisdom.Text;
                cbStrength.Items.Remove(cbWisdom.Text);
                cbDexterity.Items.Remove(cbWisdom.Text);
                cbWisdom.Items.Clear();
                cbWisdom.Items.Add("<Reset>");
                cbIntelligence.Items.Remove(cbWisdom.Text);
                cbCharm.Items.Remove(cbWisdom.Text);
            }
        }

        private void cbIntelligence_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIntelligence.Text == "<Reset>")
            {
                intel = 0;
                Reset();
                cbIntelligence.Text = "Intelligence";
                lblIntelligenceScore.Text = "";
            }
            else
            {
                intel = Convert.ToInt32(cbIntelligence.Text);
                lblIntelligenceScore.Text = cbIntelligence.Text;
                cbStrength.Items.Remove(cbIntelligence.Text);
                cbDexterity.Items.Remove(cbIntelligence.Text);
                cbWisdom.Items.Remove(cbIntelligence.Text);
                cbIntelligence.Items.Clear();
                cbIntelligence.Items.Add("<Reset>");
                cbCharm.Items.Remove(cbIntelligence.Text);
            }
        }

        private void cbCharm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCharm.Text == "<Reset>")
            {
                cha = 0;
                Reset();
                cbCharm.Text = "Charm";
                lblCharmScore.Text = "";
            }
            else
            {
                cha = Convert.ToInt32(cbCharm.Text);
                lblCharmScore.Text = cbCharm.Text;
                cbStrength.Items.Remove(cbCharm.Text);
                cbDexterity.Items.Remove(cbCharm.Text);
                cbWisdom.Items.Remove(cbCharm.Text);
                cbIntelligence.Items.Remove(cbCharm.Text);
                cbCharm.Items.Clear();
                cbCharm.Items.Add("<Reset>");
            }
        }

        private void Reset()
        {
            cbStrength.Items.Clear();
            cbDexterity.Items.Clear();
            cbWisdom.Items.Clear();
            cbIntelligence.Items.Clear();
            cbCharm.Items.Clear();

            if(str != 1 && dex != 1 && wis != 1 && intel != 1 && cha != 1)
            {
                if (str == 0)
                    cbStrength.Items.Add("1");
                if (dex == 0)
                    cbDexterity.Items.Add("1");
                if (wis == 0)
                    cbWisdom.Items.Add("1");
                if (intel == 0)
                    cbIntelligence.Items.Add("1");
                if (cha == 0)
                    cbCharm.Items.Add("1");
            }
            if (str != 2 && dex != 2 && wis != 2 && intel != 2 && cha != 2)
            {
                if (str == 0)
                    cbStrength.Items.Add("2");
                if (dex == 0)
                    cbDexterity.Items.Add("2");
                if (wis == 0)
                    cbWisdom.Items.Add("2");
                if (intel == 0)
                    cbIntelligence.Items.Add("2");
                if (cha == 0)
                    cbCharm.Items.Add("2");
            }
            if (str != 3 && dex != 3 && wis != 3 && intel != 3 && cha != 3)
            {
                if (str == 0)
                    cbStrength.Items.Add("3");
                if (dex == 0)
                    cbDexterity.Items.Add("3");
                if (wis == 0)
                    cbWisdom.Items.Add("3");
                if (intel == 0)
                    cbIntelligence.Items.Add("3");
                if (cha == 0)
                    cbCharm.Items.Add("3");
            }
            if (str != 4 && dex != 4 && wis != 4 && intel != 4 && cha != 4)
            {
                if(str == 0)
                    cbStrength.Items.Add("4");
                if(dex == 0)
                    cbDexterity.Items.Add("4");
                if(wis == 0)
                    cbWisdom.Items.Add("4");
                if(intel == 0)
                    cbIntelligence.Items.Add("4");
                if(cha == 0)
                    cbCharm.Items.Add("4");
            }
            if (str != 5 && dex != 5 && wis != 5 && intel != 5 && cha != 5)
            {
                if (str == 0)
                    cbStrength.Items.Add("5");
                if (dex == 0)
                    cbDexterity.Items.Add("5");
                if (wis == 0)
                    cbWisdom.Items.Add("5");
                if (intel == 0)
                    cbIntelligence.Items.Add("5");
                if (cha == 0)
                    cbCharm.Items.Add("5");
            }

            cbStrength.Items.Add("<Reset>");
            cbDexterity.Items.Add("<Reset>");
            cbWisdom.Items.Add("<Reset>");
            cbIntelligence.Items.Add("<Reset>");
            cbCharm.Items.Add("<Reset>");

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(str != 0 && dex != 0 && wis != 0 && intel != 0 && cha != 0)
            {

            }
        }
    }
}
