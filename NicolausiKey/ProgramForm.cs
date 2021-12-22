using System;
using System.Reflection;
using System.Windows.Forms;

namespace NicolausiKey
{
    public partial class ProgramForm : Form
    {
        public ProgramForm()
        {
            InitializeComponent();

            // Set game select data source.
            ComboBoxGameSelect.DataSource = new[] {
                new { Name = "Nicolausi", Value = 1 },
                new { Name = "PC-Bakterien", Value = 2 }
            };
            ComboBoxGameSelect.DisplayMember = "Name";
            ComboBoxGameSelect.ValueMember = "Value";
        }

        private void ButtonGenerateKey_Click(object sender, EventArgs e)
        {
            // Ensure that the input has at least 2 separated words.
            if (TextBoxNameInput.Text.Length > 0 && TextBoxNameInput.Text.Split().Length > 1)
            {
                // Get game select data source value.
                PropertyInfo gameValue = ComboBoxGameSelect.SelectedItem.GetType().GetProperty("Value");
                string gameIndex = gameValue.GetValue(ComboBoxGameSelect.SelectedItem, null).ToString();

                // Set keygen results on text box.
                TextBoxKey.Text = Keygen.KeyGenerate(TextBoxNameInput.Text, UInt32.Parse(gameIndex)).ToString();

                MessageBox.Show("Merry Christmas!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("The name must contain at least two words.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuItemGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Hipnosis183/NicolausiKey");
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Key Generator for Nicolausi and PC-Bakterien\nby Hipnosis/Renzo Pigliacampo, 2021", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
