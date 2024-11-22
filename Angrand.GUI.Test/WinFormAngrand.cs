using System;
using System.Drawing;
using System.Windows.Forms;

namespace Angrand.PalettApp
{
    public partial class WinFormAngrand : Form
    {
        public WinFormAngrand()
        {
            InitializeComponent();
            Console.WriteLine(@"----------------------------");
        }

        private void WinFormAngrand_Load(object sender, EventArgs e)
        {
            // splitPreset.Count = 20;
            // splitPreset.Munse
            splitPreset.OnDoneClicked += OnDoneClicked;
            splitPreset.Preset = (Color.Coral, Color.Goldenrod);
            splitPreset.OnLeftColorChanged += OnLeftUpdated;
            splitPreset.OnRightColorChanged += OnRightUpdated;
        }

        private void presetPalettControl_Load(object sender, EventArgs e)
        {
            // presetPalettControl.OnDoneClicked += this.Close;
            // presetPalettControl.Preset = (Color.FromArgb(0, 204, 204), Color.FromArgb(153, 153, 255));
        }

        private void OnLeftUpdated(Color color)
        {
            Console.WriteLine($@"Left Color: {color}");
        }
        private void OnRightUpdated(Color color)
        {
            Console.WriteLine($@"Right Color: {color}");
        }

        private void OnDoneClicked(object sender, EventArgs e)
        {
            Close();
        }
    }
}