using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Palett.Convert;

namespace Angrand.UserControls.ColorControlPanel
{
    public partial class ColorSpacePanel : UserControl
    {
        public Color Rgb
        {
            get => Color.FromArgb(comboBoxR.SelectedIndex, comboBoxG.SelectedIndex, comboBoxB.SelectedIndex);
            set
            {
                this.RgbCollectionEnabled = false;
                Debug.Print($"set rgb {value} (hsl: {value.ColorToHsl()})");
                this.comboBoxR.SelectedIndex = value.R;
                this.comboBoxG.SelectedIndex = value.G;
                this.comboBoxB.SelectedIndex = value.B;
                if (this.HslCollectionEnabled) this.Hsl = value.ColorToHsl();
                OnIndexChanged?.Invoke(this.Rgb, (this.RgbCollectionEnabled, this.HslCollectionEnabled));
                this.RgbCollectionEnabled = true;
            }
        }

        public (float, float, float) Hsl
        {
            get => (comboBoxH.SelectedIndex, comboBoxS.SelectedIndex, comboBoxL.SelectedIndex);
            set
            {
                this.HslCollectionEnabled = false;
                Debug.Print($"set hsl {value} (rgb {value.HslToRgb()})");
                var (h, s, l) = value;
                this.comboBoxH.SelectedIndex = (int) h;
                this.comboBoxS.SelectedIndex = (int) s;
                this.comboBoxL.SelectedIndex = (int) l;
                if (this.RgbCollectionEnabled) this.Rgb = value.HslToColor();
                OnIndexChanged?.Invoke(this.Rgb, (this.RgbCollectionEnabled, this.HslCollectionEnabled));
                this.HslCollectionEnabled = true;
            }
        }

        public event Action<Color, (bool, bool)> OnIndexChanged;

        public bool RgbCollectionEnabled = true;
        public bool HslCollectionEnabled = true;

        public void UpdateHslCollection((float, float, float) hsl)
        {
            this.RgbCollectionEnabled = false;
            this.Hsl = hsl;
            this.RgbCollectionEnabled = true;
        }

        public void UpdateRgbCollection(Color color)
        {
            this.HslCollectionEnabled = false;
            this.Rgb = color;
            this.HslCollectionEnabled = true;
        }

        public ColorSpacePanel()
        {
            InitializeComponent();
            var rgbIndexes = Enumerable.Range(0, 256).Select(x => (object) x).ToArray();
            this.comboBoxR.Items.AddRange(rgbIndexes);
            this.comboBoxG.Items.AddRange(rgbIndexes);
            this.comboBoxB.Items.AddRange(rgbIndexes);
            this.comboBoxH.Items.AddRange(Enumerable.Range(0, 361).Select(x => (object) x).ToArray());
            this.comboBoxS.Items.AddRange(Enumerable.Range(0, 101).Select(x => (object) x).ToArray());
            this.comboBoxL.Items.AddRange(Enumerable.Range(0, 101).Select(x => (object) x).ToArray());
            this.Rgb = Color.CornflowerBlue;
        }

        private void RgbSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.RgbCollectionEnabled) return;
            this.UpdateHslCollection(this.Rgb.ColorToHsl());
            OnIndexChanged?.Invoke(this.Rgb, (this.RgbCollectionEnabled, this.HslCollectionEnabled));
        }

        private void HslSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.HslCollectionEnabled) return;
            this.UpdateRgbCollection(this.Hsl.HslToColor());
            OnIndexChanged?.Invoke(this.Rgb, (this.RgbCollectionEnabled, this.HslCollectionEnabled));
        }
    }
}