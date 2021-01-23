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
                Debug.Print(
                    $"set rgb {value} (hsl: {(value.GetHue(), value.GetSaturation() * 100, value.GetBrightness() * 100)})");
                this.comboBoxR.SelectedIndex = value.R;
                this.comboBoxG.SelectedIndex = value.G;
                this.comboBoxB.SelectedIndex = value.B;
                if (this.HslCollectionEnabled)
                {
                    this.Hsl = (value.GetHue(), value.GetSaturation() * 100, value.GetBrightness() * 100);
                }

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
                if (this.RgbCollectionEnabled)
                {
                    var (r, g, b) = value.HslToRgb();
                    this.Rgb = Color.FromArgb(r, g, b);
                }

                OnIndexChanged?.Invoke(this.Rgb, (this.RgbCollectionEnabled, this.HslCollectionEnabled));
                this.HslCollectionEnabled = true;
            }
        }

        public event Action<Color, (bool, bool)> OnIndexChanged;

        public bool RgbCollectionEnabled = true;
        public bool HslCollectionEnabled = true;

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
            this.RgbCollectionEnabled = false;
            var color = this.Rgb;
            this.Hsl = (color.GetHue(), color.GetSaturation() * 100, color.GetBrightness() * 100);
            this.RgbCollectionEnabled = true;
            OnIndexChanged?.Invoke(this.Rgb, (this.RgbCollectionEnabled, this.HslCollectionEnabled));
        }

        private void HslSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.HslCollectionEnabled) return;
            this.HslCollectionEnabled = false;
            var (r, g, b) = this.Hsl.HslToRgb();
            this.Rgb = Color.FromArgb(r, g, b);
            this.HslCollectionEnabled = true;
            OnIndexChanged?.Invoke(this.Rgb, (this.RgbCollectionEnabled, this.HslCollectionEnabled));
        }
    }
}