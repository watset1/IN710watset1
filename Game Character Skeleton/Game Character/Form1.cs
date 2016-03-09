using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public partial class Form1 : Form
    {
        CharacterManager characterManager;

        public Form1()
        {
            InitializeComponent();
            characterManager = new CharacterManager();
            characterManager.DummyDataFill(listBox1);
            DisplayCharacters();
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            
            String name = txtName.Text;
            RefreshErrorMessages();
            if (txtName.Text != "")
            {
                
                if (rdKing.Checked == true)
                    characterManager.AddCharacter(new King(listBox1, name));
                else if (rdQueen.Checked == true)
                    characterManager.AddCharacter(new Queen(listBox1, name));
                else if (rdKnight.Checked == true)
                    characterManager.AddCharacter(new Knight(listBox1, name));
                else if (rdTroll.Checked == true)
                    characterManager.AddCharacter(new Troll(listBox1, name));
                else
                    lblNewCharError.Text = "No character type has been selected";              
            }
            else 
            {
                lblNewCharError.Text = "Please enter a name in the name field";
            }
            RefreshDisplay();
        }

        public void DisplayCharacters()
        {
            checkedListBox1.DisplayMember = "Name";
            checkedListBox2.DisplayMember = "Name";

            foreach (Character character in characterManager.CharacterList)
            {
                checkedListBox1.Items.Add(character);
                checkedListBox2.Items.Add(character);
            } 
        }

        public void RefreshErrorMessages()
        {
            lblBattleError.Text = "";
            lblWeaponError.Text = "";
            lblNewCharError.Text = "";
        }

        public void RefreshDisplay()
        {
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            DisplayCharacters();
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            List<Character> checkedCharacters = new List<Character>();

            RefreshErrorMessages();
            foreach (Character character in checkedListBox1.CheckedItems)
            {
                checkedCharacters.Add(character);
            }
            if (checkedCharacters.Count == 2)
            {
                listBox1.Items.Clear();
                characterManager.DisplayBattleMessages(checkedCharacters);
            }
            else
            {
                lblBattleError.Text = "Please select exactly 2 combatants";
            }
        }

        private void btnChangeWeapon_Click(object sender, EventArgs e)
        {
            List<Character> checkedCharacters = new List<Character>();

            RefreshErrorMessages();
            foreach (Character character in checkedListBox2.CheckedItems)
            {
                checkedCharacters.Add(character);               
            }
            if (checkedCharacters.Count != 0)
            {
                if (rdSword.Checked == true)
                    characterManager.ChangeWeapon(new Sword(), checkedCharacters);
                else if (rdBow.Checked == true)
                    characterManager.ChangeWeapon(new Bow(), checkedCharacters);
                else if (rdKnife.Checked == true)
                    characterManager.ChangeWeapon(new Knife(), checkedCharacters);
                else if (rdClub.Checked == true)
                    characterManager.ChangeWeapon(new Club(), checkedCharacters);
                else
                    lblWeaponError.Text = "Please choose a weapon";
            }
            else
            {
                lblWeaponError.Text = "Please pick characters to edit";
            }
        }
    }
}
