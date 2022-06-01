using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HelixClient
{
    public partial class Form1 : Form
    {

        Memory.Mem memory = new Memory.Mem();

        public Form1()
        {
            InitializeComponent();

            
        }

        private void airjump_CheckedChanged(object sender, EventArgs e)
        {
            while (airjump.Checked);
                    {
                        memory.OpenProcess(Process.GetProcessesByName("Minecraft.Windows").FirstOrDefault().Id);
                        memory.WriteMemory("Minecraft.Windows.exe + 0549E7E8,8,18,b8,1D8", "4", "16777473");
                    }
        }
    }
}
