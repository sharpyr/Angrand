using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Angrand.PalettApp
{
    public partial class WinFormAngrand : Form
    {
        public WinFormAngrand()
        {
            InitializeComponent();
            this._colorCardCollection.OnClicked += OnColorCardCollectionClick;
            this._colorSpacePanel.OnIndexChanged += OnColorSpacePanelIndexedChanged;
        }

        public void OnColorSpacePanelIndexedChanged(Color color, (bool, bool) enabled)
        {
            var (rgbEnabled, hslEnabled) = enabled;
            this.labelColorControlPanel.Text = color.Rgb().ToString();
            this.labelAux.Text = $@"rgb ({rgbEnabled}) hsl ({hslEnabled})";
        }

        public void OnColorCardCollectionClick(Color color)
        {
            this._colorSpacePanel.Rgb = color;
            this.labelColorCardCollection.Text = color.Rgb().ToString();
        }


        private void WinFormAngrand_Load(object sender, EventArgs e)
        {
        }

        private void _colorCardCollection_Load(object sender, EventArgs e)
        {

        }
    }
}