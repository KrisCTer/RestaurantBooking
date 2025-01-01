using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBooking.Widget
{
    public partial class RestaurentsControl : UserControl
    {
        public RestaurentsControl()
        {
            InitializeComponent();
        }
        private void RoundCornersForControl(Control control)
        {
            GraphicsPath path = new GraphicsPath();

            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius - 1, control.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius - 1, radius, radius, 90, 90);

            path.CloseFigure();

            control.Region = new Region(path);
        }
        private void RestaurentsControl_Load(object sender, EventArgs e)
        {
            RoundCornersForControl(this);
        }
    }
}
