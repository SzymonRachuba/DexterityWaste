/**Autor: Paweł Perkowski*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.IO;
namespace DexterityWaste
{
    public partial class Gameplay : Form
    {
        /**Szerokośc aplikacji*/
        private int sizeX;
        /**Wysokość aplikacji*/
        private int sizeY;
        /**Tablica przechowująca obiekty ryb*/
        private Fish[] fish;
        /**Tablica przechowująca obiekty odpadów danego typu*/
        private Trash[,] trash;
        /**Tablica przechowująca obiekty widocznych odpadów*/
        private Trash[] availableTrash;
        /**Obiekt przechowującay informacje numeryczne o wynikach gry*/
        private GameScore gScore;
        /**Obiekt gracza*/
        public Student player;
        /**Zmienna stanu gry*/
        private bool gameOver = false;
        /**Zmienna stanu muzyki*/
        private bool ismusic = true;
        /**Tablica przechowująca obiekty gwiazdek*/
        private PictureBox[] stars;
        /**Zmienna pauzy rozgrywki*/
        private bool stop = true;
        /**Zmienna stanu ryby policjanta*/
        private bool police = false;
        /**Zmienna przechowująca rodzaj złowionego odpadu*/
        private int curId;
        /**Zmienna przechowująca indeks złowionego odpadu*/
        private int curInd;
        /**Odtwarzacz muzyki*/
        private SoundPlayer music;
        /**Zegar*/
        private System.Timers.Timer t;

        /**
         * Konstruktor inicjalizującay aplikację, oraz tworzący obiekty potrzebnych
         * elementów.
         */
        public Gameplay()
        {
            InitializeComponent();

            music = new SoundPlayer("../../Resources/dzwiek.wav");
            music.PlayLooping();

            sizeX = this.Width;
            sizeY = this.Height;
            player = new Student(this, "../../Resources/rybak.png", sizeX / 6, sizeY / 10);

            gScore = new GameScore();
            stars = new PictureBox[3];

            //GWIAZDKI
            Image tmp = Image.FromFile("../../Resources/gwiazda.png");
            for (int i = 0; i < 3; i++)
            {
                stars[i] = new PictureBox();
                stars[i].Image = tmp;
                stars[i].BackgroundImageLayout = ImageLayout.Zoom;
                stars[i].SizeMode = PictureBoxSizeMode.Zoom;
                stars[i].BackColor = Color.Transparent;
                stars[i].Size = new Size(50, 50);
                stars[i].Location = new Point(30 + i * stars[i].Size.Width, 30);
                stars[i].Visible = false;

                Controls.Add(stars[i]);
            }

            //RYBY
            fish = new Fish[5];
            for (int i = 0; i < 5; i++)
            {
                fish[i] = new Fish(this, ("../../Resources/ryba" + (i + 1).ToString() + ".png"), sizeX / 2, sizeY / 4 * 3);
                if (i % 2 != 0) fish[i].speed *= 3 / 2;
            }

            //SMIECI
            trash = new Trash[5, 2];
            //metal
            for (int i = 0; i < 2; i++)
            {
                trash[0, i] = new Trash(this, ("../../Resources/metal" + (i + 1).ToString() + ".png"), 0, 0, 0);
                //trash[0, i].image.Visible = true;
            }
            //organiczne
            for (int i = 0; i < 2; i++)
            {
                trash[1, i] = new Trash(this, ("../../Resources/organiczne" + (i + 1).ToString() + ".png"), 1, 0, 0);
                //trash[1, i].image.Visible = true;
            }
            //papier
            for (int i = 0; i < 2; i++)
            {
                trash[2, i] = new Trash(this, ("../../Resources/papier" + (i + 1).ToString() + ".png"), 2, 0, 0);
                // trash[2, i].image.Visible = true;
            }
            //plastik
            for (int i = 0; i < 2; i++)
            {
                trash[3, i] = new Trash(this, ("../../Resources/plastik" + (i + 1).ToString() + ".png"), 3, 0, 0);
                //trash[3, i].image.Visible = true;
            }
            //szkło
            for (int i = 0; i < 2; i++)
            {
                trash[4, i] = new Trash(this, ("../../Resources/szklo" + (i + 1).ToString() + ".png"), 4, 0, 0);
                //trash[4, i].image.Visible = true;
            }


            availableTrash = new Trash[7];
            for (int i = 0; i < 7; i++)
            {
                Trash tmp2 = trash[randomInt(0, 5), randomInt(0, 2)];
                availableTrash[i] = new Trash(this, tmp2.src, tmp2.id, i * 260, sizeY - 180);
            }
            lvlTime.Text = gScore.time.ToString();

            t = new System.Timers.Timer();
            t.Interval = 1000;//1s

            t.Elapsed += OnTimeEvent;
            Application.Idle += game;
        }

        /**
         * Funkcja wywołująca się z krokiem zegara.
         * Aktualizuje wartość czas
         */
        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                gScore.time--;

                if (gScore.time < 0)
                {
                    gScore.time = 0;
                    gameOver = true;
                }

                if (gameOver) t.Stop();
                counter.Text = "CZAS: " + gScore.time.ToString();
            }));
        }

        /**
         * Funkcja wywołująca się przy wciśnięciu odpowiedniego klawisza.
         * Wywołuje ruch wędki.
         */
        private void input(object sender, KeyEventArgs e)
        {
            if (!stop)
            {
                if (e.KeyCode == Keys.Space) player.line.moving = true;
            }
        }

        /**
         * Funkcja wywołująca się przy wciśnięciu przycisku start
         */
        private void startBtn_Click(object sender, EventArgs e)
        {
            t.Start();
            for (int i = 0; i < 5; i++)
            {
                fish[i].image.Visible = true;
                fish[i].image.Location = new Point(randomInt(fish[i].image.Size.Width, sizeX - fish[i].image.Size.Width), fish[i].y - i * fish[i].image.Size.Height - 25 * i);
            }
            for (int i = 0; i < 6; i++)
            {
                availableTrash[i].image.Visible = true;
            }

            fish[4].image.Visible = false;
            startBtn.Visible = false;
            settingsBtn.Visible = false;
            exitBtn.Location = new Point(sizeX - exitBtn.Size.Width - 30, sizeY - exitBtn.Size.Height - 30);

            stop = false;
            gameOver = false;
            counter.Visible = true;
            score.Visible = true;
            player.image.Focus();
        }

        /**
         * Funkcja wstrzymująca aplikację na określony czas
         */
        private void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        /**
         * Funkcja losująca wartość całkowitą mieszczącą się w danym przedziale
         */
        private int randomInt(int min, int max)
        {
            Random rnd = new Random();
            wait(15);
            int x = rnd.Next(min, max);

            return x;
        }

        /**
         * Funkcja wywołująca się przy wciśnięciu przycisku ustawień
         */
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            startBtn.Visible = false;
            exitBtn.Visible = false;
            settingsBtn.Visible = false;

            musicBtn.Visible = true;
            levelTBtn.Visible = true;
            backBtn.Visible = true;
        }

        /**
         * Funkcja wywołująca się przy wciśnięciu przycisku wyjścia
         */
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /**
         * Funkcja wywołująca się przy wciśnięciu przycisku muzyki
         */
        private void musicBtn_Click(object sender, EventArgs e)
        {
            if (ismusic)
            {
                music.Stop();
                ismusic = false;
            }
            else
            {
                music.PlayLooping();
                ismusic = true;
            }
        }

        /**
         * Funkcja wywołująca się przy wciśnięciu przycisku ustawiania
         * czasu rozgrywki
         */
        private void levelTBtn_Click(object sender, EventArgs e)
        {
            levelTBtn.Visible = false;
            lvlTime.Visible = true;
            lvlTime.Focus();
        }

        /**
         * Funkcja wywołująca się przy wciśnięciu przycisku powrotu
         */
        private void backBtn_Click(object sender, EventArgs e)
        {
            startBtn.Visible = true;
            exitBtn.Visible = true;
            settingsBtn.Visible = true;

            musicBtn.Visible = false;
            levelTBtn.Visible = false;
            backBtn.Visible = false;
            lvlTime.Visible = false;
        }

        /**
         * Funkcja używana przy wyborze kontenerów.
         * Wywołuje się przy wyborze kontenera na odpady metalowe.
         */
        private void metalBtn_Click(object sender, EventArgs e)
        {

            addTrash(0);
        }
        
        /**
         * Funkcja używana przy wyborze kontenerów.
         * Wywołuje się przy wyborze kontenera na odpady organiczne.
         */
        private void organicBtn_Click(object sender, EventArgs e)
        {
            addTrash(1);
        }
        
        /**
         * Funkcja używana przy wyborze kontenerów.
         * Wywołuje się przy wyborze kontenera na odpady papierowe.
         */
        private void paperBtn_Click(object sender, EventArgs e)
        {
            addTrash(2);
        }
        
        /**
         * Funkcja używana przy wyborze kontenerów.
         * Wywołuje się przy wyborze kontenera na odpady plastikowe.
         */
        private void plasticBtn_Click(object sender, EventArgs e)
        {
            addTrash(3);
        }
        
        /**
         * Funkcja używana przy wyborze kontenerów.
         * Wywołuje się przy wyborze kontenera na odpady szklane.
         */
        private void glassBtn_Click(object sender, EventArgs e)
        {
            addTrash(4);
        }

        /**
         * Funkcja wywołująca się przy zmianie wartości czasu rozgrywki.
         */
        private void lvlTime_TextChanged(object sender, EventArgs e)
        {
            if (lvlTime.Text != "") gScore.time = int.Parse(lvlTime.Text);

            counter.Text = "CZAS: " + lvlTime.Text;
        }

        /**Element potrzebny do pętli rozgrywki*/
        #region POTRZEBNE DO GAMELOOPA
        [StructLayout(LayoutKind.Sequential)]
        public struct NativeMessage
        {
            public IntPtr Handle;
            public uint Message;
            public IntPtr WParameter;
            public IntPtr LParameter;
            public uint Time;
            public Point Location;
        }
        /**Element potrzebny do pętli rozgrywki*/
        [DllImport("user32.dll")]
        public static extern int PeekMessage(out NativeMessage message, IntPtr window, uint filterMin, uint filterMax, uint remove);
        /**Element potrzebny do pętli rozgrywki*/
        bool IsApplicationIdle()
        {
            NativeMessage result;
            return PeekMessage(out result, IntPtr.Zero, (uint)0, (uint)0, (uint)0) == 0;
        }
        #endregion

        /**
         * Funkcja wywołująca się przy wyborze kontenerów.
         * Jeżeli wyłowiony odpad jest tego samego rodzaju co wybrany kontener
         * naliczane są punkty. W przeciwnym wypadku zmniejszana jest ilość
         * błędów jakie gracz może wykonać.
         */
        private void addTrash(int id)
        {
            metalBtn.Enabled = false;
            organicBtn.Enabled = false;
            paperBtn.Enabled = false;
            plasticBtn.Enabled = false;
            glassBtn.Enabled = false;
            availableTrash[curInd].hooked = false;

            if (curId == id)
            {
                gScore.trashCollected[curId]++;
                gScore.score++;
                score.Text = "ZEBRANE ODPADY: " + gScore.score.ToString();
                gScore.level++;
                int rindex = randomInt(0,4);
                fish[rindex].speed += 1;
            }
            else
            {
                gScore.hp--;

                alert.Visible = true;
                alert.Text = "BŁĘDNY WYBÓR!";
                for (int i = 0; i < 200; i++)
                {
                    alert.BackColor = Color.FromArgb(55 / 200 + i, alert.BackColor.R, alert.BackColor.G, alert.BackColor.B);
                    alert.BringToFront();
                    wait(1);
                }
                alert.Visible = false;
                alert.Text = "NIE ŁÓW RYB!";
            }

            metalBin.Visible = false;
            metalBtn.Visible = false;

            organicBin.Visible = false;
            organicBtn.Visible = false;

            paperBin.Visible = false;
            paperBtn.Visible = false;

            plasticBin.Visible = false;
            plasticBtn.Visible = false;

            glassBin.Visible = false;
            glassBtn.Visible = false;

            var tmp = trash[randomInt(0, 5), randomInt(0, 2)];
            availableTrash[curInd].done = false;
            availableTrash[curInd].image.Visible = false;
            availableTrash[curInd] = new Trash(this, tmp.src, tmp.id, player.line.x - 135, sizeY - 180);
            availableTrash[curInd].image.Visible = true;
            availableTrash[curInd].hooked = false;

            metalBtn.Enabled = true;
            organicBtn.Enabled = true;
            paperBtn.Enabled = true;
            plasticBtn.Enabled = true;
            glassBtn.Enabled = true;

            player.line.hook = false;
            stop = false;
            t.Start();
            player.image.Focus();
        }

        /**
         * Funkcja zapisująca wynik gracza w pliku tekstowym
         */
        private void saveScore()
        {
            StreamWriter sw = new StreamWriter("scores.txt");
            sw.Write(gScore.score);
            sw.Close();
        }

        /**
         * Funkcja odpowiedzialna za pętlę gry i wyświetlanie ekranu końcowego.
         */
        private void game(object sender, EventArgs e)
        {
            if (!stop)
            {
                if (gScore.hp <= 0) gameOver = true;
                if (gameOver)
                {
                    stop = true;
                    saveScore();
                    for (int i = 0; i < Controls.Count; i++)
                    {
                        if (Controls[i] != exitBtn &&
                            Controls[i] != alert &&
                            Controls[i] != metal &&
                            Controls[i] != plastic &&
                            Controls[i] != paper &&
                            Controls[i] != organic &&
                            Controls[i] != glass &&
                            Controls[i] != stars[0] &&
                            Controls[i] != stars[1] &&
                            Controls[i] != stars[2]) Controls.Remove(Controls[i]);
                    }
                    for (int i = 0; i < fish.Count(); i++)
                    {
                        fish[i].image.Visible = false;
                    }
                    for (int i = 0; i < availableTrash.Count(); i++)
                    {
                        availableTrash[i].image.Visible = false;
                    }
                    player.image.Visible = false;
                    player.line.image.Visible = false;
                    this.Invalidate();

                    score.Location = new Point(score.Location.X, 200);

                    metal.Text = "METAL: " + gScore.trashCollected[0].ToString();
                    organic.Text = "ORGANIC: " + gScore.trashCollected[1].ToString();
                    paper.Text = "PAPER: " + gScore.trashCollected[2].ToString();
                    plastic.Text = "PLASTIC: " + gScore.trashCollected[3].ToString();
                    glass.Text = "GLASS: " + gScore.trashCollected[4].ToString();

                    metal.Visible = true;
                    organic.Visible = true;
                    paper.Visible = true;
                    plastic.Visible = true;
                    glass.Visible = true;

                    alert.Visible = true;
                    alert.Text = "KONIEC GRY";
                    for (int i = 0; i < 200; i++)
                    {
                        alert.BackColor = Color.FromArgb(55 / 200 + i, alert.BackColor.R, alert.BackColor.G, alert.BackColor.B);
                        alert.BringToFront();
                        wait(1);
                    }
                }

                //GAMELOOP
                while (IsApplicationIdle() && !gameOver)
                {

                    //ruch linki
                    if (player.line.moving) player.line.move();

                    //ruch smieci
                    for (int i = 0; i < 7; i++)
                    {
                        availableTrash[i].move();
                        if (availableTrash[i].checkCollision(player.line))
                        {
                            availableTrash[i].hooked = true;
                            curId = availableTrash[i].id;
                            curInd = i;
                        }
                    }

                    //ruszanie ryb
                    for (int i = 0; i < 4; i++)
                    {
                        fish[i].move();
                        if (fish[i].checkCollision(player.line))
                        {
                            stop = true;
                            police = true;
                        }
                    }


                    if (gScore.stars <= 0) gScore.stars = 0;
                    if (gScore.stars >= 3)
                    {
                        gScore.stars = 3;
                        gameOver = true;
                    }
                }
                //zlowienie opdadu
                if (availableTrash[curInd].done)
                {
                    stop = true;
                    t.Stop();
                    availableTrash[curInd].image.Location = new Point(availableTrash[curInd].x, sizeY / 2);

                    metalBin.Visible = true;
                    metalBtn.Visible = true;

                    organicBin.Visible = true;
                    organicBtn.Visible = true;

                    paperBin.Visible = true;
                    paperBtn.Visible = true;

                    plasticBin.Visible = true;
                    plasticBtn.Visible = true;

                    glassBin.Visible = true;
                    glassBtn.Visible = true;
                }

                //Animacja ryby policjanta i wyswietlenie komunikatu
                if (police)
                {
                    t.Stop();
                    fish[4].image.Location = new Point(sizeX - fish[4].image.Size.Width - 1, fish[4].y + fish[4].image.Size.Height);
                    fish[4].x = fish[4].image.Location.X;
                    fish[4].image.Visible = true;
                    fish[4].speed /= 2;

                    for (int i = 0; i < 40; i++)
                    {
                        fish[4].move();
                        wait(10);
                    }

                    alert.Visible = true;

                    for (int i = 0; i < 200; i++)
                    {
                        alert.BackColor = Color.FromArgb(55 / 200 + i, alert.BackColor.R, alert.BackColor.G, alert.BackColor.B);
                        alert.BringToFront();
                        wait(1);
                    }

                    fish[4].right = true;

                    Image tmp = fish[4].image.Image;
                    tmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    fish[4].image.Image = tmp;
                    for (int i = 0; i < 40; i++)
                    {
                        fish[4].move();
                        wait(10);
                    }
                    alert.Visible = false;
                    fish[4].image.Visible = false;
                    fish[4].speed *= 2;
                    gScore.stars += 1;
                    stop = false;
                    police = false;
                    t.Start();
                    for (int i = 0; i < gScore.stars; i++)
                    {
                        if (!stars[i].Visible) stars[i].Visible = true;
                    }

                }
            }
        }
    }
}
