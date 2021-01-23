using System;
using System.Drawing;
using System.Windows.Forms;

namespace Angrand.UserControls.ColorCardCollection
{
    public partial class ColorCardCollection : UserControl
    {
        public Color CardColor { get; set; }

        public ColorCardCollection()
        {
            InitializeComponent();
        }

        public event Action<Color> ColorHandler;

        private void button_color_Click(object sender, EventArgs e)
        {
            ColorHandler?.Invoke(this.CardColor = ((Button) sender).BackColor);
        }
    }
}