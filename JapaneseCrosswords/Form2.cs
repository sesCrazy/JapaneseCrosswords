using ShootLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseCrosswords
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CreateMaps();
            this.Text = "Кролик";
        }

        public const int sizeWidth = 6;
        public const int sizeHeight = 7;
        public int cellSize = 30;

        public int[,] myMap = new int[sizeHeight, sizeWidth];

        public void CreateMaps()
        {
            for (int i = 0; i < sizeHeight; i++)
            {
                for (int j = 0; j < sizeWidth; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(j * cellSize, i * cellSize);
                    button.Size = new Size(cellSize, cellSize);
                    button.BackColor = Color.White;
                    if (i < 2 || j < 1)
                    {
                        button.BackColor = Color.LightGray;
                    }

                    button.Click += new EventHandler(Class1.Shoot);
                    
                    this.Controls.Add(button);

                    if ((i, j) == (0, 2) || (i, j) == (0, 3) || (i, j) == (1, 1) || (i, j) == (1, 5))
                    {
                        button.Text = "1";
                    }
                    if ((i, j) == (0, 5) || (i, j) == (2, 0) || (i, j) == (3, 0))
                    {
                        button.Text = "2";
                    }
                    if ((i, j) == (1, 2) || (i, j) == (1, 3))
                    {
                        button.Text = "3";
                    }
                    if ((i, j) == (1, 4) || (i, j) == (4, 0) || (i, j) == (5, 0) || (i, j) == (6, 0))
                    {
                        button.Text = "4";
                    }
                }
            }
        }
    }
}
