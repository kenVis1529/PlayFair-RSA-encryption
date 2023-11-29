using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playfair_and_rsa_encryption
{
    internal class NavigationControl
    {
        List<UserControl> userControls = new List<UserControl>();
        Panel panel = new Panel();

        public NavigationControl(List<UserControl> userControls, Panel panel)
        {
            this.userControls = userControls;
            this.panel = panel;
            AddUserControl();
        }

        private void AddUserControl()
        {
            for (int i = 0; i < userControls.Count; i++)
            {
                // Làm cho User Control lắp đầy hết Control cha của nó
                userControls[i].Dock = DockStyle.Fill;

                // Thêm tất cả User Control vào Panel - Một nhóm Control
                panel.Controls.Add(userControls[i]);
            }
        }


        public void Display(int index)
        {
            if (index < userControls.Count) {
                userControls[index].BringToFront(); // Hiện ra User Control được chọn
            }
        }
    }
}
