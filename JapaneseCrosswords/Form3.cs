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
    public partial class Form3 : Form
    {
        public const int sizeWidth = 13;
        public const int sizeHeight = 14;
        public int cellSize = 30;

        public int[,] myMap = new int[sizeHeight, sizeWidth];

        public Form3()
        {
            InitializeComponent();
            CreateMaps();
            this.Text = "Фотоаппарат";
        }

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
                    if (i < 4 || j < 3)
                    {
                        button.BackColor = Color.LightGray;
                    }

                    button.Click += new EventHandler(Class1.Shoot);

                    this.Controls.Add(button);

                    if ((i, j) == (0, 7) || (i, j) == (1, 7) || (i, j) == (1, 8) || (i, j) == (1, 9)
                        || (i, j) == (2, 5) || (i, j) == (2, 10) || (i, j) == (3, 7) || (i, j) == (3, 8)
                        || (i, j) == (5, 1) || (i, j) == (5, 2) || (i, j) == (6, 0) || (i, j) == (6, 2)
                        || (i, j) == (8, 0) || (i, j) == (8, 2))
                    {
                        button.Text = "1";
                    }
                    if ((i, j) == (13, 2))
                    {
                        button.Text = "10";
                    }
                    if ((i, j) == (2, 4) || (i, j) == (2, 7) || (i, j) == (2, 8) || (i, j) == (3, 6) || (i, j) == (3, 9)
                        || (i, j) == (10, 1) || (i, j) == (11, 1))
                    {
                        button.Text = "2";
                    }
                    if ((i, j) == (0, 8) || (i, j) == (10, 0) || (i, j) == (10, 2) || (i, j) == (11, 0) || (i, j) == (11, 2))
                    {
                        button.Text = "3";
                    }
                    if ((i, j) == (2, 6) || (i, j) == (2, 9) || (i, j) == (2, 11) || (i, j) == (4, 2) || (i, j) == (6, 1)
                        || (i, j) == (7, 1) || (i, j) == (7, 2) || (i, j) == (9, 1) || (i, j) == (9, 2) || (i, j) == (12, 1) || (i, j) == (12, 2))
                    {
                        button.Text = "4";
                    }
                    if ((i, j) == (3, 4) || (i, j) == (3, 5) || (i, j) == (3, 11) || (i, j) == (8, 1))
                    {
                        button.Text = "5";
                    }
                    if ((i, j) == (3, 3) || (i, j) == (3, 10) || (i, j) == (3, 12))
                    {
                        button.Text = "7";
                    }
                }
            }
        }
    }
}
