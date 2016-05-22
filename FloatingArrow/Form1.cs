using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloatingArrow
{
    public partial class Form1 : Form
    {
        enum Direction
        {
            up = 0,
            right,
            down,
            left
        }

        private Direction m_direction;
        private Point mouse_offset;

        private Rectangle m_rectClose;
        private Rectangle m_rectRotateC;
        private Rectangle m_rectRotateCC;

        public Form1()
        {
            InitializeComponent();

            // These buttons were used to figure out the their positions in each direction. 
            // We disable them after we got that info.
            buttonClose.Enabled = false;
            buttonClose.Visible = false;
            buttonRotateC.Enabled = false;
            buttonRotateC.Visible = false;
            buttonRotateCC.Enabled = false;
            buttonRotateCC.Visible = false;

            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("FloatingArrow.Images.arrow_up.ico");
            Icon icon = new Icon(myStream);
            this.Icon = icon;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle rect_click = new Rectangle(e.X, e.Y, 1, 1);

            if (m_rectClose.IntersectsWith(rect_click))
            {
                this.Close();
            }
            else if (m_rectRotateC.IntersectsWith(rect_click))
            {
                RotateC();
            }
            else if (m_rectRotateCC.IntersectsWith(rect_click))
            {
                RotateCC();
            }
            else
            {
                mouse_offset = new Point(-e.X, -e.Y);

                // Bug fix: If rotate while part of the form is outside of the screen, 
                // the part of the form outside will not load the background image 
                // correctly, and will have a background of grey.
                //
                // This fix is to reload the background the next time mouse down happens.
                // This is not an ideal solution as the grey rectangle can still be seen 
                // while the arrow is being dragged inside of the screen.
                //
                // I guess the correct solution is to draw the background in code, overriding 
                // the Invalidate()/OnPaint() function.

                //LoadBackgroundImage();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
                //this.Text = this.Left + ", " + this.Top;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_direction = Direction.up;
            LoadBackgroundImage();
            RelocateButtons();
        }

        private void LoadBackgroundImage()
        {
            string imageName = "";
            if (Direction.up == m_direction)
            {
                imageName = "FloatingArrow.Images.arrow_up.png";
            }
            if (Direction.right == m_direction)
            {
                imageName = "FloatingArrow.Images.arrow_right.png";
            }
            if (Direction.down == m_direction)
            {
                imageName = "FloatingArrow.Images.arrow_down.png";
            }
            if (Direction.left == m_direction)
            {
                imageName = "FloatingArrow.Images.arrow_left.png";
            }
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream(imageName);
            Bitmap image = new Bitmap(myStream);
            this.BackgroundImage = image;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRotateC_Click(object sender, EventArgs e)
        {
            RotateC();
        }

        private void RotateC()
        {
            m_direction = m_direction + 1;
            if ((int)m_direction > 3)
                m_direction = Direction.up;
            LoadBackgroundImage();
            RelocateButtons();
        }

        private void RotateCC()
        {
            m_direction = m_direction - 1;
            if (m_direction < 0)
                m_direction = Direction.left;
            LoadBackgroundImage();
            RelocateButtons();
        }

        private void buttonRotateCC_Click(object sender, EventArgs e)
        {
            RotateCC();
        }

        private void RelocateButtons()
        {
            if (Direction.up == m_direction)
            {
                m_rectClose = new Rectangle(115, 210, 70, 46);
                m_rectRotateC = new Rectangle(150, 150, 35, 60);
                m_rectRotateCC = new Rectangle(115, 150, 35, 60);

                buttonClose.Width = 70;
                buttonClose.Height = 46;
                buttonClose.Left = 115;
                buttonClose.Top = 210;

                buttonRotateC.Width = 35;
                buttonRotateC.Height = 60;
                buttonRotateC.Left = 150;
                buttonRotateC.Top = 150;

                buttonRotateCC.Width = 35;
                buttonRotateCC.Height = 60;
                buttonRotateCC.Left = 115;
                buttonRotateCC.Top = 150;
            }
            if (Direction.right == m_direction)
            {
                m_rectClose = new Rectangle(44, 115, 46, 70);
                m_rectRotateC = new Rectangle(90, 150, 60, 35);
                m_rectRotateCC = new Rectangle(90, 115, 60, 35);

                buttonClose.Width = 46;
                buttonClose.Height = 70;
                buttonClose.Left = 44;
                buttonClose.Top = 115;

                buttonRotateC.Width = 60;
                buttonRotateC.Height = 35;
                buttonRotateC.Left = 90;
                buttonRotateC.Top = 150;

                buttonRotateCC.Width = 60;
                buttonRotateCC.Height = 35;
                buttonRotateCC.Left = 90;
                buttonRotateCC.Top = 115;
            }
            if (Direction.down == m_direction)
            {
                m_rectClose = new Rectangle(115, 44, 70, 46);
                m_rectRotateCC = new Rectangle(150, 90, 35, 60);
                m_rectRotateC = new Rectangle(115, 90, 35, 60);

                buttonClose.Width = 70;
                buttonClose.Height = 46;
                buttonClose.Left = 115;
                buttonClose.Top = 44;

                buttonRotateCC.Width = 35;
                buttonRotateCC.Height = 60;
                buttonRotateCC.Left = 150;
                buttonRotateCC.Top = 90;

                buttonRotateC.Width = 35;
                buttonRotateC.Height = 60;
                buttonRotateC.Left = 115;
                buttonRotateC.Top = 90;
            }
            if (Direction.left == m_direction)
            {
                m_rectClose = new Rectangle(210, 115, 46, 70);
                m_rectRotateCC = new Rectangle(150, 150, 60, 35);
                m_rectRotateC = new Rectangle(150, 115, 60, 35);

                buttonClose.Width = 46;
                buttonClose.Height = 70;
                buttonClose.Left = 210;
                buttonClose.Top = 115;

                buttonRotateCC.Width = 60;
                buttonRotateCC.Height = 35;
                buttonRotateCC.Left = 150;
                buttonRotateCC.Top = 150;

                buttonRotateC.Width = 60;
                buttonRotateC.Height = 35;
                buttonRotateC.Left = 150;
                buttonRotateC.Top = 115;
            }
        }
    }
}
