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
     * Klasa obiektu gracza
     */
    public class Student
    {
        /**Obiekt głównej aplikacji*/
        private Gameplay main;
        /**Pozycja x*/
        public int x;
        /**Pozycja y*/
        public int y;
        /**Obrazek*/
        public PictureBox image;
        /**Wędka*/
        public FishingLine line;

        /**
         * Konstruktor klasy. Przypisuje wartości odpowiednim zmiennym, oraz
         * inicjalizuje obiekt gracza i wędki.
         */
        public Student(Gameplay main, string img, int x, int y)
        {
            this.main = main;
            this.x = x;
            this.y = y;

            Image tmp = Image.FromFile(img);
            image = new PictureBox();
            image.Image = tmp;
            image.BackgroundImageLayout = ImageLayout.Zoom;
            image.Size = new Size(400,300);
            image.Location = new Point(x,y);
            image.BackColor = Color.Transparent;

            line = new FishingLine(main, "../../Resources/hak.png", x+image.Size.Width,y+image.Size.Height/6-10);
            main.Controls.Add(image);
            main.Paint += new System.Windows.Forms.PaintEventHandler(paint);
        }

        /**
         * Funkcja rysująca gracza
         */
        private void paint(object sender, PaintEventArgs e)
        {
            if (image.Visible) e.Graphics.DrawImage(image.Image, image.Left, image.Top, image.Width, image.Height);
        }
    }
}
