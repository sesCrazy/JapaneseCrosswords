using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShootLib;

namespace JapaneseCrosswords
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            CreateMaps();
            this.Text = "Яблоко";
        }
        public const int size = 17;
        public int cellSize = 30;

        public int[,] myMap = new int[size, size];

        public void CreateMaps()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(j * cellSize, i * cellSize);
                    button.Size = new Size(cellSize, cellSize);
                    button.BackColor = Color.White;
                    if (i < 2 || j < 2)
                    {
                        button.BackColor = Color.LightGray;
                    }

                    button.Click += new EventHandler(Class1.Shoot);

                    this.Controls.Add(button);

                    if ((i, j) == (0, 5) || (i, j) == (9, 1) || (i, j) == (10, 1))
                    {
                        button.Text = "1";
                    }
                    if ((i, j) == (0, 6) || (i, j) == (0, 8) || (i, j) == (0, 12) || (i, j) == (0, 14) || (i, j) == (0, 15)
                        || (i, j) == (2, 1) || (i, j) == (5, 1) || (i, j) == (8, 1) || (i, j) == (11, 1))
                    {
                        button.Text = "2";
                    }
                    if ((i, j) == (0, 7) || (i, j) == (0, 11) || (i, j) == (0, 13) || (i, j) == (2, 0) || (i, j) == (3, 0) || (i, j) == (3, 1))
                    {
                        button.Text = "3";
                    }
                    if ((i, j) == (1, 14) || (i, j) == (1, 15) || (i, j) == (16, 0) || (i, j) == (16, 1))
                    {
                        button.Text = "4";
                    }
                    if ((i, j) == (4, 1))
                    {
                        button.Text = "5";
                    }
                    if ((i, j) == (1, 2) || (i, j) == (1, 13) || (i, j) == (1, 16))
                    {
                        button.Text = "6";
                    }
                    if ((i, j) == (1, 3))
                    {
                        button.Text = "8";
                    }
                    if ((i, j) == (1, 4))
                    {
                        button.Text = "10";
                    }
                    if ((i, j) == (1, 5) || (i, j) == (1, 6) || (i, j) == (1, 7) || (i, j) == (1, 8) || (i, j) == (1, 11) || (i, j) == (1, 12)
                        || (i, j) == (6, 1) || (i, j) == (9, 0) || (i, j) == (10, 0) || (i, j) == (15, 1))
                    {
                        button.Text = "11";
                    }
                    if ((i, j) == (1, 9) || (i, j) == (8, 0) || (i, j) == (11, 0))
                    {
                        button.Text = "12";
                    }
                    if ((i, j) == (7, 1) || (i, j) == (14, 1))
                    {
                        button.Text = "13";
                    }
                    if ((i, j) == (1, 10))
                    {
                        button.Text = "14";
                    }
                    if ((i, j) == (12, 1) || (i, j) == (13, 1))
                    {
                        button.Text = "15";
                    }
                }
            }
        }
    }
}
