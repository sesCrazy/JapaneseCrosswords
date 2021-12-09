using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootLib
{
    public class Class1
    {
        public static void Shoot(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            if (pressedButton.Text == "" && pressedButton.BackColor == Color.White)
            {
                pressedButton.Text = "";
                pressedButton.BackColor = Color.Black;
            }
            else if (pressedButton.BackColor == Color.Black)
            {
                pressedButton.Text = "X";
                pressedButton.BackColor = Color.White;
            }
            else if (pressedButton.Text == "X")
            {
                pressedButton.Text = "";
                pressedButton.BackColor = Color.White;
            }

            if (pressedButton.BackColor == Color.LightGray)
            {
                pressedButton.BackColor = Color.DimGray;
            }
            else if (pressedButton.BackColor == Color.DimGray)
            {
                pressedButton.BackColor = Color.LightGray;
            }
        }
    }
}
