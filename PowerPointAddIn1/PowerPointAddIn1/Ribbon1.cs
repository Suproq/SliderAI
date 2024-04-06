using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Windows.Forms;

namespace PowerPointAddIn1
{
    public partial class Ribbon1
    {
        int i = 0;
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void checkBtn_Click(object sender, RibbonControlEventArgs e)
        {
            SliderAIForm f1 = new SliderAIForm();
            f1.Show();

        }
    }
}
