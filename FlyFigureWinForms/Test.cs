using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyFigureWinForms
{
    public class Test
    {
        private Form form;
        private PictureBox pictureBox;
        private Timer timer;
        private TreeView treeView;
        private List<Figure> listFigure;
        private Button triangleButton;
        private Button rectangleButton;
        private Button circleButton;

        public Test(Form form, PictureBox pictureBox, Timer timer, TreeView treeView)
        {
            this.form = form;
            this.pictureBox = pictureBox;
            this.timer = timer;
            this.treeView = treeView;
        }

        public Form Form
        {
            get
            {
                return form;
            }
        }

        public PictureBox PictureBox
        {
            get
            {
                return pictureBox;
            }
        }

        public Timer Timer
        {
            get
            {
                return timer;
            }
        }

        public TreeView TreeView
        {
            get
            {
                return treeView;
            }
        }

    }
}
