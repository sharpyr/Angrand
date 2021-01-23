using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angrand.UserControls.PalettControl
{
    public static class PalettControlExt
    {
        public static void StillAction(this Control control, Action action)
        {
            if (!control.Enabled) return;
            control.Enabled = false;
            action();
            control.Enabled = true;
        }

        public static (float, float, float) UpdateLightness(this (float, float, float) hsl, float newLight)
        {
            var (h, s, _) = hsl;
            return (h, s, newLight);
        }
    }
}