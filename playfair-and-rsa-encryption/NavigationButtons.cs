using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playfair_and_rsa_encryption
{
    public class NavigationButtons
    {
        List<Button> buttons;
        Color defaultBackColor;
        Color selectedBackColor;
        Color defaultTextColor;
        Color selectedTextColor;

        public NavigationButtons
            (List<Button> buttons, Color defaultBackColor, Color selectedBackColor, Color defaultTextColor, Color selectedTextColor)
        {
            this.buttons = buttons;
            this.defaultBackColor = defaultBackColor;
            this.selectedBackColor = selectedBackColor;
            this.defaultTextColor = defaultTextColor;
            this.selectedTextColor = selectedTextColor;
            SetDefaultColorButtons();
        }

        private void SetDefaultColorButtons()
        {
            foreach (var button in buttons)
            {
                button.BackColor = defaultBackColor;
                button.ForeColor = defaultTextColor;
            }
        }

        public void Highlight(Button selectedButton)
        {
            foreach (var button in buttons)
            {
                if (button == selectedButton)
                {
                    button.BackColor = selectedBackColor;
                    button.ForeColor = selectedTextColor;
                }
                else
                {
                    button.BackColor = defaultBackColor;
                    button.ForeColor = defaultTextColor;
                }
            }
        }
    }
}
