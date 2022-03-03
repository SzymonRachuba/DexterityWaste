using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DexterityWaste
{
    /**
     * Klasa wędki
     */
    public class FishingLine
    {
        /**Obiekt głównej aplikacji*/
        private Gameplay main;
        /**Pozycja x haczyka*/
        public int x;
        /**Pozycja y haczyka*/
        public int y;
        /**Pozycja x wędki*/
        public int ax;
        /**Pozycja x wędki*/
        public int ay;
        /**Obrazek haczyka*/
        public PictureBox image;
        /**Zmienna stanu złowienia*/
        public bool hook = false;
        /**Zmienna stanu ruchu ryby*/
        public bool moving = false;
        /**Maksymalna długość linki*/
        private int len = 700;
        /**Prędkość haczyka*/
        public int speed = 30;

        /**
         * Konstruktor klasy. Przypisuje wartości odpowiednim zmiennym, oraz
         * inicjalizuje wędkę.
         */
        public FishingLine(Gameplay main, string img, int ax, int ay)
        {
            this.main = main;

            Image tmp = Image.FromFile(img);
            tmp.RotateFlip(RotateFlipType.RotateNoneFlipX);

            this.ax = ax;
            this.ay = ay;

            image = new PictureBox();
            image.Image = tmp;
            image.BackgroundImageLayout = ImageLayout.Zoom;
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.Size = new Size(50, 100);
            image.BackColor = Color.FromArgb(0, Color.White);
            image.Visible = true;


            x = ax - image.Size.Width+10;
            y = ay + 10;
            image.Location = new Point(x, y);

            main.Paint += new System.Windows.Forms.PaintEventHandler(paint);
        }

        /**
         * Funkcja rysująca linkę wraz z haczykiem
         */
        private void paint(object sender, PaintEventArgs e)
        {
            if (image.Visible)
            {
                Pen pen = new Pen(Color.White, 2);
                Point p1 = new Point(ax, ay);
                Point p2 = new Point(x + image.Size.Width - 10, y + 10);

                e.Graphics.DrawLine(pen, p1, p2);

                e.Graphics.DrawImage(image.Image, x, y, image.Width, image.Height);
            }
        }

        /**
         * Funkcja ruszająca haczykiem
         */
        public void move()
        {
            if (!hook) y += speed;
            else y -= speed;

            if (y >= len + ay)
            {
                y = ay + len;
                hook = true;
            }
            if (y <= ay)
            {
                y = ay;
                hook = false;
                moving = false;
            }
            image.Location = new Point(x, y);
            main.Invalidate();
        }
    }
}
