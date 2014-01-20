using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace EAL.Graphics
{
    public class Graphics
    {

        public enum colours
        {
            black,
            white,
            red,
            blue,
            green

        };

        public enum borderStyles
        {
            Normal,
            Borderless
        };
        Form f = new Form();
        System.Drawing.Graphics g;
        string Title = "";
        public Graphics()
        {

        }

        /// <summary>
        /// Set window parameters
        /// </summary>
        /// <param name="width">Width of the Window</param>
        /// <param name="height">Height of the Window</param>
        /// <param name="title">Title of the Window</param>
        public void createWindow(int width, int height, string title, borderStyles borderStyle = borderStyles.Normal, bool fullscreen = false)
        {
            FormBorderStyle b = FormBorderStyle.FixedSingle;

            switch(borderStyle){
                case borderStyles.Normal:
                    b = FormBorderStyle.FixedSingle;
                    break;
                case borderStyles.Borderless:
                    b = FormBorderStyle.None;
                    break;
                default:
                    break;

            }
            f.ShowIcon = false;
            f.MinimizeBox = false;
            f.MaximizeBox = false;
            f.ControlBox = false;
            f.UseWaitCursor = false;
            f.Cursor = Cursors.Arrow;
            if (fullscreen)
            {
                f.TopMost = true;
                f.FormBorderStyle = FormBorderStyle.None;
                f.WindowState = FormWindowState.Maximized;
            }
            else
            {
                f.Width = width;
                f.Height = height;
                f.FormBorderStyle = b;
            }
            f.Text = title;
            

            g = f.CreateGraphics();

            // Set console crap up and all that jazz...
            Console.Title = title + " - CONSOLE";
                       

        }

        public int getWidth()
        {
            Console.WriteLine(f.Width);
            return f.Width;
        }

        public int getHeight()
        {
            Console.WriteLine(f.Height);
            return f.Height;
        }
        /// <summary>
        /// Draws a line to the graphics window
        /// </summary>
        /// <param name="startX">The starting coordinate of X</param>
        /// <param name="startY">The starting coordinate of Y</param>
        /// <param name="endX">The end coordinate of X</param>
        /// <param name="endY">The end coordinate of Y</param>
        /// <param name="color">The colour of the line</param>
        public void draw(int startX, int startY, int endX, int endY, colours color)
        {
            System.Drawing.Point p1 = new System.Drawing.Point();
            p1.X = startX;
            p1.Y = startY;
            System.Drawing.Point p2 = new System.Drawing.Point();
            p2.X = endX;
            p2.Y = endY;

            System.Drawing.Pen p = System.Drawing.Pens.Black;
            switch(color){

                case(colours.red):
                    p = System.Drawing.Pens.Red;
                    break;
                case(colours.blue):
                    p = System.Drawing.Pens.Blue;
                    break;
                case(colours.green):
                    p = System.Drawing.Pens.Green;
                    break;
                case(colours.white):
                    p = System.Drawing.Pens.White;
                    break;
                default:
                    p = System.Drawing.Pens.Black;
                    break;
            }
           
            g.DrawLine(p, p1, p2);
        }
        public void setBackgroundColour(colours colour)
        {
            System.Drawing.Color c = System.Drawing.Color.White;
            switch(colour){
                case colours.red:
                    c = System.Drawing.Color.Red;
                    break;
                case colours.blue:
                    c = System.Drawing.Color.Blue;
                    break;
                case colours.green:
                    c = System.Drawing.Color.Green;
                    break;
                default:
                    Console.WriteLine("[EAL] Invalid Colour: " + colour);
                    break;
            }
            f.Hide();
            f.BackColor = c;
            f.Show();
        }
        /// <summary>
        /// Show the window
        /// </summary>
        public void showWindow()
        {
            f.Show();
            f.Cursor = Cursors.Arrow;
        }
        /// <summary>
        /// Hide the window
        /// </summary>
        public void hideWindow()
        {
            f.Hide();
        }
    }
}
