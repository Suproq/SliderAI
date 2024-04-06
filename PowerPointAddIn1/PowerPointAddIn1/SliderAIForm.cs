using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerPointAddIn1
{
    public partial class SliderAIForm : Form
    {
        public SliderAIForm()
        {
            InitializeComponent();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            panel1.Location = new Point((ClientSize.Width - panel1.Width) / 2, (ClientSize.Height - panel1.Height) / 2);
        }

        private void SliderAIForm_Load(object sender, EventArgs e)
        {
            base.OnSizeChanged(e);
            panel1.Location = new Point((ClientSize.Width - panel1.Width) / 2, (ClientSize.Height - panel1.Height) / 2);
        }
    }
}
