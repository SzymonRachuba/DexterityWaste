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
     * Klasa odpadów
     */
    class Trash
    {
        /**Pozycja x*/
        public int x;
        /**Pozycja y*/
        public int y;
        /**Obrazek*/
        public PictureBox image;
        /**Zmienna stanu złowienia*/
        public bool hooked;
        /**Zmienna wykorzystywana do sprawdzenia czy odpad został wyłowiony*/
        public bool done;
        /**Ścieżka do obrazka*/
        public string src;
        /**Rodzaj odpadu*/
        public int id;
        /**Prędkość poruszania się odpadu*/
        public static int speed=3;
        /**Obiekt głównej aplikacji*/
        private Gameplay main;

        /**
         * Konstruktor klasy. Przypisuje wartości poszczególnym parametrom, oraz inicjalizuje odpad
         */
        public Trash(Gameplay main, string img, int id, int x, int y)
        {
            this.main = main;
            this.x = x;
            this.y = y;
            this.id = id;

            src = img;
            Image tmp = Image.FromFile(img);

            image = new PictureBox();
            image.Image = tmp;
            image.BackgroundImageLayout = ImageLayout.Zoom;
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.Size = new Size(130, 100);
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
         * Funkcja rysująca odpad
         */
        private void paint(object sender, PaintEventArgs e)
        {
            if (image.Visible) e.Graphics.DrawImage(image.Image, image.Left, image.Top, image.Width, image.Height);
        }

        /**
         * Funkcja ruszająca odpadem
         */
        public void move()
        {
            if (!hooked)
            {
                x -= speed;
                if (x <= -image.Size.Width-180) x = main.Width + 10; // przesuniecie obiektu na koniec "tasmy"
            }
            else
            {
                y = main.player.line.y + 30;
            }

            if (y == main.player.line.ay + 30) done = true;


            image.Location = new Point(x, y);
            main.Invalidate();
        }

        /** Funkcja sprawdzająca czy odpad koliduje z hakiem.
         * Zwraca false jeżeli nie ma kolizji. W przeciwnym wypadku zwraca True*/
        public bool checkCollision(FishingLine hook)
        {
            if (!hook.hook)
            {
                if (image.Bounds.IntersectsWith(hook.image.Bounds))
                {
                    if (image.Top + 30 <= hook.image.Bottom &&
                        image.Right - 30 >= hook.image.Left &&
                        image.Left + 30 <= hook.image.Right)
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
