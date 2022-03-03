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
     * Klasa ryby
     */
    public class Fish
    {
        /**Pozycja x*/
        public int x;
        /**Pozycja y*/
        public int y;
        /**Obrazek*/
        public PictureBox image;
        /**Zmienna stanu kolizji*/
        public bool collision;
        /**Zmienna przechowująca informację kierunku ryby*/
        public bool right;
        /**Prędkość ryby*/
        public int speed = 2;
        /**Obiekt głównej aplikacji*/
        private Gameplay main;

        /**
         * Konstruktor klasy. Przypisuje wartości odpowiednim zmiennym, oraz inicjalizuje rybę.
         */
        public Fish(Gameplay main, string img, int x, int y)
        {
            this.main = main;
            this.x = x;
            this.y = y;

            Image tmp = Image.FromFile(img);

            image = new PictureBox();
            image.Image = tmp;
            image.BackgroundImageLayout = ImageLayout.Zoom;
            image.Size = new Size(130, 100);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.BackColor = Color.Transparent;
            image.Location = new Point(x, y);
            image.Visible = false;

            main.Paint += new System.Windows.Forms.PaintEventHandler(paint);
            image.LocationChanged += new System.EventHandler(updateXY);
        }

        /**
         * Funkcja wykonująca się wraz ze zmianem położenia ryby.
         * Aktualizuje wartości x i y
         */
        private void updateXY(object sender, EventArgs e)
        {
            x = image.Location.X;
            y = image.Location.Y;
        }

        /**
         * Funkcja rysująca rybę
         */
        private void paint(object sender, PaintEventArgs e)
        {
            if (image.Visible) e.Graphics.DrawImage(image.Image, image.Left, image.Top, image.Width, image.Height);
        }

        /**
         * Funkcja ruszająca rybą
         */
        public void move()
        {
            if (right) x += speed;
            else x -= speed;

            if (x >= main.Width - image.Size.Width)
            {
                x = main.Width - image.Size.Width;
                Image tmp = image.Image;
                tmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                image.Image = tmp;
                right = false;
            }
            if (x <= 0)
            {
                x = 0;
                Image tmp = image.Image;
                tmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                image.Image = tmp;
                right = true;
            }

            image.Location = new Point(x, y);
            main.Invalidate();
        }

        /**
         * Funkcja sprawdzająca czy ryba koliduje z hakiem.
         * Zwraca false jeżeli nie ma kolizji. W przeciwnym wypadku zwraca true;
         */
        public bool checkCollision(FishingLine hook)
        {
            if (!hook.hook)
            {
                if (image.Bounds.IntersectsWith(hook.image.Bounds))
                {
                    if (image.Top + 30 <= hook.image.Bottom &&
                        image.Right - 40 >= hook.image.Left &&
                        image.Left + 40 <= hook.image.Right)
                    {
                        hook.hook = true;
                        return true;
                    }

                }
            }

            return false;
        }

    }
}
