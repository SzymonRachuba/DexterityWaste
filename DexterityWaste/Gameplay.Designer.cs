
namespace DexterityWaste
{
    partial class Gameplay
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.startBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.musicBtn = new System.Windows.Forms.Button();
            this.levelTBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.alert = new System.Windows.Forms.Label();
            this.metalBin = new System.Windows.Forms.PictureBox();
            this.organicBin = new System.Windows.Forms.PictureBox();
            this.paperBin = new System.Windows.Forms.PictureBox();
            this.plasticBin = new System.Windows.Forms.PictureBox();
            this.glassBin = new System.Windows.Forms.PictureBox();
            this.metalBtn = new System.Windows.Forms.Button();
            this.organicBtn = new System.Windows.Forms.Button();
            this.paperBtn = new System.Windows.Forms.Button();
            this.plasticBtn = new System.Windows.Forms.Button();
            this.glassBtn = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.Label();
            this.lvlTime = new System.Windows.Forms.TextBox();
            this.score = new System.Windows.Forms.Label();
            this.metal = new System.Windows.Forms.Label();
            this.organic = new System.Windows.Forms.Label();
            this.paper = new System.Windows.Forms.Label();
            this.plastic = new System.Windows.Forms.Label();
            this.glass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metalBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organicBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plasticBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassBin)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Gold;
            this.startBtn.CausesValidation = false;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startBtn.FlatAppearance.BorderSize = 4;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startBtn.Location = new System.Drawing.Point(800, 500);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(200, 50);
            this.startBtn.TabIndex = 0;
            this.startBtn.TabStop = false;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.Gold;
            this.settingsBtn.CausesValidation = false;
            this.settingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.settingsBtn.FlatAppearance.BorderSize = 4;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsBtn.Location = new System.Drawing.Point(800, 571);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(200, 50);
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.TabStop = false;
            this.settingsBtn.Text = "SETTINGS";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Gold;
            this.exitBtn.CausesValidation = false;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitBtn.FlatAppearance.BorderSize = 4;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitBtn.Location = new System.Drawing.Point(800, 646);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(200, 50);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.TabStop = false;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // musicBtn
            // 
            this.musicBtn.BackColor = System.Drawing.Color.Gold;
            this.musicBtn.CausesValidation = false;
            this.musicBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.musicBtn.FlatAppearance.BorderSize = 4;
            this.musicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.musicBtn.Location = new System.Drawing.Point(800, 500);
            this.musicBtn.Name = "musicBtn";
            this.musicBtn.Size = new System.Drawing.Size(250, 50);
            this.musicBtn.TabIndex = 3;
            this.musicBtn.TabStop = false;
            this.musicBtn.Text = "MUSIC ON/OFF";
            this.musicBtn.UseVisualStyleBackColor = false;
            this.musicBtn.Visible = false;
            this.musicBtn.Click += new System.EventHandler(this.musicBtn_Click);
            // 
            // levelTBtn
            // 
            this.levelTBtn.BackColor = System.Drawing.Color.Gold;
            this.levelTBtn.CausesValidation = false;
            this.levelTBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.levelTBtn.FlatAppearance.BorderSize = 4;
            this.levelTBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelTBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.levelTBtn.Location = new System.Drawing.Point(800, 571);
            this.levelTBtn.Name = "levelTBtn";
            this.levelTBtn.Size = new System.Drawing.Size(250, 50);
            this.levelTBtn.TabIndex = 4;
            this.levelTBtn.TabStop = false;
            this.levelTBtn.Text = "LEVEL TIME";
            this.levelTBtn.UseVisualStyleBackColor = false;
            this.levelTBtn.Visible = false;
            this.levelTBtn.Click += new System.EventHandler(this.levelTBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Gold;
            this.backBtn.CausesValidation = false;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backBtn.FlatAppearance.BorderSize = 4;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backBtn.Location = new System.Drawing.Point(800, 646);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(250, 50);
            this.backBtn.TabIndex = 5;
            this.backBtn.TabStop = false;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Visible = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // alert
            // 
            this.alert.BackColor = System.Drawing.Color.Crimson;
            this.alert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alert.Cursor = System.Windows.Forms.Cursors.Default;
            this.alert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alert.ForeColor = System.Drawing.Color.White;
            this.alert.Location = new System.Drawing.Point(513, 500);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(250, 125);
            this.alert.TabIndex = 6;
            this.alert.Text = "NIE ŁÓW RYB!";
            this.alert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alert.Visible = false;
            // 
            // metalBin
            // 
            this.metalBin.BackColor = System.Drawing.Color.Transparent;
            this.metalBin.BackgroundImage = global::DexterityWaste.Properties.Resources.metal3;
            this.metalBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metalBin.Location = new System.Drawing.Point(60, 100);
            this.metalBin.Name = "metalBin";
            this.metalBin.Size = new System.Drawing.Size(200, 300);
            this.metalBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.metalBin.TabIndex = 7;
            this.metalBin.TabStop = false;
            this.metalBin.Visible = false;
            // 
            // organicBin
            // 
            this.organicBin.BackColor = System.Drawing.Color.Transparent;
            this.organicBin.BackgroundImage = global::DexterityWaste.Properties.Resources.organiczne3;
            this.organicBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.organicBin.Location = new System.Drawing.Point(300, 100);
            this.organicBin.Name = "organicBin";
            this.organicBin.Size = new System.Drawing.Size(200, 300);
            this.organicBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.organicBin.TabIndex = 8;
            this.organicBin.TabStop = false;
            this.organicBin.Visible = false;
            // 
            // paperBin
            // 
            this.paperBin.BackColor = System.Drawing.Color.Transparent;
            this.paperBin.BackgroundImage = global::DexterityWaste.Properties.Resources.papier3;
            this.paperBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paperBin.Location = new System.Drawing.Point(540, 100);
            this.paperBin.Name = "paperBin";
            this.paperBin.Size = new System.Drawing.Size(200, 300);
            this.paperBin.TabIndex = 9;
            this.paperBin.TabStop = false;
            this.paperBin.Visible = false;
            // 
            // plasticBin
            // 
            this.plasticBin.BackColor = System.Drawing.Color.Transparent;
            this.plasticBin.BackgroundImage = global::DexterityWaste.Properties.Resources.plastik3;
            this.plasticBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plasticBin.Location = new System.Drawing.Point(780, 100);
            this.plasticBin.Name = "plasticBin";
            this.plasticBin.Size = new System.Drawing.Size(200, 300);
            this.plasticBin.TabIndex = 10;
            this.plasticBin.TabStop = false;
            this.plasticBin.Visible = false;
            // 
            // glassBin
            // 
            this.glassBin.BackColor = System.Drawing.Color.Transparent;
            this.glassBin.BackgroundImage = global::DexterityWaste.Properties.Resources.szklo3;
            this.glassBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.glassBin.Location = new System.Drawing.Point(1020, 100);
            this.glassBin.Name = "glassBin";
            this.glassBin.Size = new System.Drawing.Size(200, 300);
            this.glassBin.TabIndex = 11;
            this.glassBin.TabStop = false;
            this.glassBin.Visible = false;
            // 
            // metalBtn
            // 
            this.metalBtn.BackColor = System.Drawing.Color.Gold;
            this.metalBtn.CausesValidation = false;
            this.metalBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.metalBtn.FlatAppearance.BorderSize = 4;
            this.metalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.metalBtn.Location = new System.Drawing.Point(60, 430);
            this.metalBtn.Name = "metalBtn";
            this.metalBtn.Size = new System.Drawing.Size(200, 50);
            this.metalBtn.TabIndex = 12;
            this.metalBtn.TabStop = false;
            this.metalBtn.Text = "METAL";
            this.metalBtn.UseVisualStyleBackColor = false;
            this.metalBtn.Visible = false;
            this.metalBtn.Click += new System.EventHandler(this.metalBtn_Click);
            // 
            // organicBtn
            // 
            this.organicBtn.BackColor = System.Drawing.Color.DimGray;
            this.organicBtn.CausesValidation = false;
            this.organicBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.organicBtn.FlatAppearance.BorderSize = 4;
            this.organicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.organicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.organicBtn.Location = new System.Drawing.Point(300, 430);
            this.organicBtn.Name = "organicBtn";
            this.organicBtn.Size = new System.Drawing.Size(200, 50);
            this.organicBtn.TabIndex = 13;
            this.organicBtn.TabStop = false;
            this.organicBtn.Text = "ORGANIC";
            this.organicBtn.UseVisualStyleBackColor = false;
            this.organicBtn.Visible = false;
            this.organicBtn.Click += new System.EventHandler(this.organicBtn_Click);
            // 
            // paperBtn
            // 
            this.paperBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.paperBtn.CausesValidation = false;
            this.paperBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.paperBtn.FlatAppearance.BorderSize = 4;
            this.paperBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paperBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.paperBtn.Location = new System.Drawing.Point(540, 430);
            this.paperBtn.Name = "paperBtn";
            this.paperBtn.Size = new System.Drawing.Size(200, 50);
            this.paperBtn.TabIndex = 14;
            this.paperBtn.TabStop = false;
            this.paperBtn.Text = "PAPER";
            this.paperBtn.UseVisualStyleBackColor = false;
            this.paperBtn.Visible = false;
            this.paperBtn.Click += new System.EventHandler(this.paperBtn_Click);
            // 
            // plasticBtn
            // 
            this.plasticBtn.BackColor = System.Drawing.Color.Orange;
            this.plasticBtn.CausesValidation = false;
            this.plasticBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.plasticBtn.FlatAppearance.BorderSize = 4;
            this.plasticBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plasticBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plasticBtn.Location = new System.Drawing.Point(780, 430);
            this.plasticBtn.Name = "plasticBtn";
            this.plasticBtn.Size = new System.Drawing.Size(200, 50);
            this.plasticBtn.TabIndex = 15;
            this.plasticBtn.TabStop = false;
            this.plasticBtn.Text = "PLASTIC";
            this.plasticBtn.UseVisualStyleBackColor = false;
            this.plasticBtn.Visible = false;
            this.plasticBtn.Click += new System.EventHandler(this.plasticBtn_Click);
            // 
            // glassBtn
            // 
            this.glassBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.glassBtn.CausesValidation = false;
            this.glassBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.glassBtn.FlatAppearance.BorderSize = 4;
            this.glassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.glassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.glassBtn.Location = new System.Drawing.Point(1020, 430);
            this.glassBtn.Name = "glassBtn";
            this.glassBtn.Size = new System.Drawing.Size(200, 50);
            this.glassBtn.TabIndex = 16;
            this.glassBtn.TabStop = false;
            this.glassBtn.Text = "GLASS";
            this.glassBtn.UseVisualStyleBackColor = false;
            this.glassBtn.Visible = false;
            this.glassBtn.Click += new System.EventHandler(this.glassBtn_Click);
            // 
            // counter
            // 
            this.counter.BackColor = System.Drawing.Color.Transparent;
            this.counter.Cursor = System.Windows.Forms.Cursors.Default;
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.counter.ForeColor = System.Drawing.Color.Black;
            this.counter.Location = new System.Drawing.Point(1015, 2);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(250, 80);
            this.counter.TabIndex = 17;
            this.counter.Text = "CZAS: 90";
            this.counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.counter.Visible = false;
            // 
            // lvlTime
            // 
            this.lvlTime.BackColor = System.Drawing.Color.Gold;
            this.lvlTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lvlTime.Location = new System.Drawing.Point(800, 578);
            this.lvlTime.MaxLength = 3;
            this.lvlTime.Name = "lvlTime";
            this.lvlTime.Size = new System.Drawing.Size(250, 35);
            this.lvlTime.TabIndex = 18;
            this.lvlTime.TabStop = false;
            this.lvlTime.Text = "90";
            this.lvlTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvlTime.Visible = false;
            this.lvlTime.TextChanged += new System.EventHandler(this.lvlTime_TextChanged);
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Cursor = System.Windows.Forms.Cursors.Default;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.ForeColor = System.Drawing.Color.Black;
            this.score.Location = new System.Drawing.Point(450, 15);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(373, 80);
            this.score.TabIndex = 19;
            this.score.Text = "ZEBRANE ODPADY: 0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.score.Visible = false;
            // 
            // metal
            // 
            this.metal.BackColor = System.Drawing.Color.Gold;
            this.metal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metal.Cursor = System.Windows.Forms.Cursors.Default;
            this.metal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.metal.ForeColor = System.Drawing.Color.Black;
            this.metal.Location = new System.Drawing.Point(60, 320);
            this.metal.Name = "metal";
            this.metal.Size = new System.Drawing.Size(200, 80);
            this.metal.TabIndex = 20;
            this.metal.Text = "METAL: 0";
            this.metal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metal.Visible = false;
            // 
            // organic
            // 
            this.organic.BackColor = System.Drawing.Color.DimGray;
            this.organic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.organic.Cursor = System.Windows.Forms.Cursors.Default;
            this.organic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.organic.ForeColor = System.Drawing.Color.Black;
            this.organic.Location = new System.Drawing.Point(300, 320);
            this.organic.Name = "organic";
            this.organic.Size = new System.Drawing.Size(200, 80);
            this.organic.TabIndex = 21;
            this.organic.Text = "ORGANIC: 0";
            this.organic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.organic.Visible = false;
            // 
            // paper
            // 
            this.paper.BackColor = System.Drawing.Color.DodgerBlue;
            this.paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paper.Cursor = System.Windows.Forms.Cursors.Default;
            this.paper.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.paper.ForeColor = System.Drawing.Color.Black;
            this.paper.Location = new System.Drawing.Point(540, 320);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(200, 80);
            this.paper.TabIndex = 22;
            this.paper.Text = "PAPER: 0";
            this.paper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paper.Visible = false;
            // 
            // plastic
            // 
            this.plastic.BackColor = System.Drawing.Color.Orange;
            this.plastic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plastic.Cursor = System.Windows.Forms.Cursors.Default;
            this.plastic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plastic.ForeColor = System.Drawing.Color.Black;
            this.plastic.Location = new System.Drawing.Point(780, 320);
            this.plastic.Name = "plastic";
            this.plastic.Size = new System.Drawing.Size(200, 80);
            this.plastic.TabIndex = 23;
            this.plastic.Text = "PLASTIC: 0";
            this.plastic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plastic.Visible = false;
            // 
            // glass
            // 
            this.glass.BackColor = System.Drawing.Color.LimeGreen;
            this.glass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.glass.Cursor = System.Windows.Forms.Cursors.Default;
            this.glass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.glass.ForeColor = System.Drawing.Color.Black;
            this.glass.Location = new System.Drawing.Point(1020, 320);
            this.glass.Name = "glass";
            this.glass.Size = new System.Drawing.Size(200, 80);
            this.glass.TabIndex = 24;
            this.glass.Text = "GLASS: 0";
            this.glass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.glass.Visible = false;
            // 
            // Gameplay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::DexterityWaste.Properties.Resources.tlo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.ControlBox = false;
            this.Controls.Add(this.glass);
            this.Controls.Add(this.plastic);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.organic);
            this.Controls.Add(this.metal);
            this.Controls.Add(this.score);
            this.Controls.Add(this.lvlTime);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.glassBtn);
            this.Controls.Add(this.plasticBtn);
            this.Controls.Add(this.paperBtn);
            this.Controls.Add(this.organicBtn);
            this.Controls.Add(this.metalBtn);
            this.Controls.Add(this.glassBin);
            this.Controls.Add(this.plasticBin);
            this.Controls.Add(this.paperBin);
            this.Controls.Add(this.organicBin);
            this.Controls.Add(this.metalBin);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.levelTBtn);
            this.Controls.Add(this.musicBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.startBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gameplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DexterityWaste";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input);
            ((System.ComponentModel.ISupportInitialize)(this.metalBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organicBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plasticBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassBin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button musicBtn;
        private System.Windows.Forms.Button levelTBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label alert;
        private System.Windows.Forms.PictureBox metalBin;
        private System.Windows.Forms.PictureBox organicBin;
        private System.Windows.Forms.PictureBox paperBin;
        private System.Windows.Forms.PictureBox plasticBin;
        private System.Windows.Forms.PictureBox glassBin;
        private System.Windows.Forms.Button metalBtn;
        private System.Windows.Forms.Button organicBtn;
        private System.Windows.Forms.Button paperBtn;
        private System.Windows.Forms.Button plasticBtn;
        private System.Windows.Forms.Button glassBtn;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.TextBox lvlTime;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label metal;
        private System.Windows.Forms.Label organic;
        private System.Windows.Forms.Label paper;
        private System.Windows.Forms.Label plastic;
        private System.Windows.Forms.Label glass;
    }
}

