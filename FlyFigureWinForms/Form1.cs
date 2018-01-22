//-----------------------------------------------------------------------
//
// <copyright file="Form1.cs" company="DCT">
//
//     Company copyright tag.
//
// </copyright>
//
//-----------------------------------------------------------------------
namespace FlyFigureWinForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Media;
    using System.Resources;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Documentation for the second part of Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// asdfl dlsv
        /// </summary>
        private const string Triangle = "triangle";

        /// <summary>
        /// af sdf
        /// </summary>
        private const string Circle = "circle";

        /// <summary>
        /// sef' sregw
        /// </summary>
        private const string Rectangle = "rectangle";

        /// <summary>
        /// asefca dvcd
        /// </summary>
        private ResourceManager resource;

        /// <summary>
        /// blah blah blah
        /// </summary>
        private Point pointMax;

        /// <summary>
        /// blah blah blah
        /// </summary>
        private List<Figure> listFigures = new List<Figure>();

        /// <summary>
        /// asdfa aef 
        /// </summary>
        private ToolStripMenuItem menuItem;

        /// <summary>
        /// aef ef qw
        /// </summary>
        private ToolStripMenuItem englishMenu;

        /// <summary>
        /// asef ded qwe
        /// </summary>
        private ToolStripMenuItem russianMenu;

        public delegate void CrossingFigureState(object sender, CrossingFigureEventArgs e);
        public event CrossingFigureState CrossingFigure;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.resource = new ResourceManager("FlyFigureWinForms.Form1", typeof(Form1).Assembly);

            this.InitializeComponent();

            this.pointMax.X = this.pictureBox1.Width;
            this.pointMax.Y = this.pictureBox1.Height;

            this.menuItem = new ToolStripMenuItem() { Text = this.resource.GetString("menuItem.Text") };

            this.englishMenu = new ToolStripMenuItem() { Text = "English" };

            this.englishMenu.Click += this.EnglishMenu_Click;
            this.menuItem.DropDownItems.Add(this.englishMenu);

            this.russianMenu = new ToolStripMenuItem() { Text = "Russian" };

            this.russianMenu.Click += this.RussianMenu_Click;
            this.menuItem.DropDownItems.Add(this.russianMenu);

            this.menuStrip1.Items.Add(this.menuItem);

            this.CrossingFigure += SoundBeep;
        }

        private void SoundBeep(object sender, CrossingFigureEventArgs e)
        {
            Console.Beep();
        }

        //private void SoundBeep()
        //{
        //    //SystemSounds.Asterisk.Play();
        //    Console.Beep();
        //}

        /// <summary>
        /// Change language Form on Russian
        /// </summary>
        /// <param name="sender">Object type sender parameter</param>
        /// <param name="e">EventArgs type e parameter</param>
        private void RussianMenu_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            this.SetValueProperty();
        }

        /// <summary>
        /// This Method assigns value properties.
        /// </summary>
        private void SetValueProperty()
        {
            this.button1.Text = this.resource.GetString("button1.Text");
            this.button2.Text = this.resource.GetString("button2.Text");
            this.button3.Text = this.resource.GetString("button3.Text");
            this.englishMenu.Text = this.resource.GetString("englishMenu.Text");
            this.menuItem.Text = this.resource.GetString("menuItem.Text");
            this.moveButton.Text = this.resource.GetString("moveButton.Text");
            this.russianMenu.Text = this.resource.GetString("russianMenu.Text");
            this.stopButton.Text = this.resource.GetString("stopButton.Text");
        }

        /// <summary>
        /// Change language From on English
        /// </summary>
        /// <param name="sender">Object type sender parameter</param>
        /// <param name="e">EventArgs type e parameter</param>
        private void EnglishMenu_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            this.SetValueProperty();
        }

        /// <summary>
        /// Event on click triangle button.
        /// </summary>
        /// <param name="sender">Object type sender parameter</param>
        /// <param name="e">EventArgs type e parameter</param>
        private void TriangleButton_Click(object sender, EventArgs e)
        {
            Figure f = new Triangle(this.pointMax);
            this.listFigures.Add(f);
            TreeNode node = new TreeNode(f.Name);
            this.treeView1.Nodes.Add(node);
            this.treeView1.Refresh();
        }

        /// <summary>
        /// Event on click circle button.
        /// </summary>
        /// <param name="sender">Object type sender parameter</param>
        /// <param name="e">EventArgs type e parameter</param>
        private void CircleButton_Click(object sender, EventArgs e)
        {
            Figure f = new Circle(this.pointMax);
            this.listFigures.Add(f);
            TreeNode node = new TreeNode(f.Name);
            this.treeView1.Nodes.Add(node);
            this.treeView1.Refresh();
        }

        /// <summary>
        /// Event on click rectangle button.
        /// </summary>
        /// <param name="sender">Object type sender parameter</param>
        /// <param name="e">EventArgs type e parametr</param>
        private void RectangleButton_Click(object sender, EventArgs e)
        {
            Figure f = new Rectangle(this.pointMax);
            this.listFigures.Add(f);
            TreeNode node = new TreeNode(f.Name);
            this.treeView1.Nodes.Add(node);
            this.treeView1.Refresh();
        }

        /// <summary>
        /// Call methods Draw and Move for each figure in ListFigure.
        /// </summary>
        /// <param name="sender">Object type sender parameter</param>
        /// <param name="e">PaintEventArgs type e parametr</param>
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var f in this.listFigures)
            {
                f.Move(this.pointMax);
                f.Draw(e.Graphics);
            }

            if (CrossingFigure != null)
            {
                foreach (var f in listFigures)
                {
                    foreach (var fig in listFigures)
                    {
                        if (!f.Equals(fig))
                        {
                            for (int j = fig.CoordX; j < fig.CoordX + fig.SizeX; j++)
                            {
                                if (j > f.CoordX && j < f.CoordX + f.SizeX)
                                {
                                    for (int i = fig.CoordY; i < fig.CoordY + fig.SizeY; i++)
                                    {
                                        if (i > f.CoordY && i < f.CoordY + f.SizeY)
                                        {
                                            CrossingFigure(this, new CrossingFigureEventArgs(f, fig));
                                            break;
                                        }
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Refresh picture box= <see cref="pictureBox1"/>
        /// </summary>
        /// <param name="sender">Object type sender parameter</param>
        /// <param name="e">EventArgs type e parameter</param>
        private void TimerMain_Tick(object sender, EventArgs e)
        {
            this.pictureBox1.Refresh();

        }

        /// <summary>
        /// When size Form1 changed , change coordinates right down angle point.
        /// </summary>
        /// <param name="sender">Object type sender parameter</param>
        /// <param name="e">EventArgs type e parameter</param>
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.pointMax = new Point() { X = this.pictureBox1.Width, Y = this.pictureBox1.Height };
        }

        /// <summary>
        /// When click StopButton selected figure stop.
        /// </summary>
        /// <param name="sender">Object type sender parameter</param>
        /// <param name="e">EventArgs type e parameter</param>
        private void StopButton_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode != null)
            {
                this.listFigures[this.treeView1.SelectedNode.Index].CanMove = false;
            }
        }

        /// <summary>
        /// When click MoveButton selected figure move again.
        /// </summary>
        /// <param name="sender">Object type sender parameter</param>
        /// <param name="e">EventArgs type e parameter</param>
        private void MoveButton_Click(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode != null)
            {
                if (this.listFigures[this.treeView1.SelectedNode.Index].CanMove == false)
                {
                    this.listFigures[this.treeView1.SelectedNode.Index].CanMove = true;
                }
            }
        }
    }
}
