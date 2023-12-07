using playfair_and_rsa_encryption.UserControls;

namespace playfair_and_rsa_encryption
{
    public partial class Form1 : Form
    {

        private NavigationControl navigationControl;
        private NavigationButtons navigationButtons;

        // Khởi tạo màu của các nút navigation
        Color btnDefaultColor = Color.FromArgb(0, 48, 73);
        Color btnSelectedColor = Color.FromKnownColor(KnownColor.Control);

        // Khởi tạo màu của các label của nút navigation
        Color txtDefaultColor = Color.White;
        Color txtSelectedColor = Color.FromArgb(0, 48, 73);

        public Form1()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new UserControlPlayfair(), new UserControlRsa() };

            navigationControl = new NavigationControl(userControls, panelBody);
            navigationControl.Display(0);
        }

        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { btnPlayfair, btnRsa };

            // Tạo đối tượng cho Navigation button
            navigationButtons = new NavigationButtons
                (buttons, btnDefaultColor, btnSelectedColor, txtDefaultColor, txtSelectedColor);

            // Đặt màu cho nút mặc định
            navigationButtons.Highlight(btnPlayfair);
        }

        private void btnPlayfair_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(btnPlayfair);
        }

        private void btnRsa_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(btnRsa);
        }
    }
}
