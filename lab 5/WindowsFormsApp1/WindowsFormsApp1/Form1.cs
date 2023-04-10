using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameProcessBuilder builder = new GameProcessBuilder();
            GameProcessDirector director = new GameProcessDirector(builder);

            // Construct game process with different configurations
            director.Construct("Alice", 1, true);
            IGameProcessPrototype gameProcess1 = builder.GetGameProcessPrototype().Clone();
            gameProcess1.Display();

            director.Construct("Bob", 2, false);
            IGameProcessPrototype gameProcess2 = builder.GetGameProcessPrototype().Clone();
            gameProcess2.Display();

            director.Construct("Charlie", 3, true);
            IGameProcessPrototype gameProcess3 = builder.GetGameProcessPrototype().Clone();
            gameProcess3.Display();
        }
    }
}
