using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace MemoryGame
{
	public partial class MainForm : Form
	{
	
		#region Promenljive globalne
		//Promenljive
		private Timer timer;
		private TimeSpan stoperica;
		bool poljeGenerisano = false;
		bool startGame = false;
		List<PictureBox> provera;
		int brojParova;
		private bool jelJeDozvoljenClick = true;
		private int skor = 100;
		
		//Logika
		List<PictureBox> boxesList;
		List<Image> imageList;
		#endregion
		public MainForm()
		{
			InitializeComponent();

			#region Inicijalziacija
			//Clock
			timer = new Timer();
			timer.Interval = 1000; 
			timer.Tick += Timer_Tick;
			stoperica = new TimeSpan(0, 0, 0);
			this.Load += new System.EventHandler(this.MainForm_Load);
			
			
			brojParova = 0;
			boxesList = new List<PictureBox>();
			imageList = new List<Image>();
			provera = new List<PictureBox>();
			Resource1.prazno.Tag = "prazno";
			labelaSkor.Text = skor.ToString();
			#endregion

		}
	private void MainForm_Load(object sender, EventArgs e) {
			//Setovanje panela za grid pictureBoxova
			panel1.Location = new Point(
			this.ClientSize.Width / 2 - panel1.Size.Width / 2,
			this.ClientSize.Height / 2 - panel1.Size.Height / 2);
			panel1.Anchor = AnchorStyles.None;
			panel1.Dock = DockStyle.Fill;


			panel2.Show();


			//Loadovanje slika
			LoadImages2(imageList);
		}

		//Generate field
		private void GeneratePictureBoxes(int m, int n)
		{
			panel1.Controls.Clear(); // Clear existing PictureBoxes

			int panelWidth = panel1.ClientSize.Width;
			int panelHeight = panel1.ClientSize.Height;

			// Calculate the size of each PictureBox
			int size = Math.Min(panelWidth / n, panelHeight / m);

			// Calculate the total size of the PictureBox grid
			int totalWidth = size * n;
			int totalHeight = size * m;

			// Calculate offsets to center the PictureBox grid within the panel
			int offsetX = (panelWidth - totalWidth) / 2;
			int offsetY = (panelHeight - totalHeight) / 2;

			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
				{
					PictureBox pictureBox = new PictureBox
					{
						Width = size,
						Height = size,
						BorderStyle = BorderStyle.FixedSingle,
						Location = new Point(offsetX + j * size, offsetY + i * size),
						BackColor = Color.LightGray,
						Image = Resource1.zatvoreno,
						BackgroundImageLayout = ImageLayout.Zoom,
						SizeMode = PictureBoxSizeMode.Zoom,
					};
					panel1.Controls.Add(pictureBox);
					boxesList.Add(pictureBox);
				}
			}


			//Adding event on evry picture box
			for ( int i = 0; i < boxesList.Count; i++)
				boxesList[i].Click += Box_Click;
				

		}

		private async void Otvori(PictureBox pb) {
			int indeks = boxesList.IndexOf(pb);
			boxesList[indeks].Image = pb.BackgroundImage;

			jelJeDozvoljenClick = false;
			await Task.Delay(650);
			jelJeDozvoljenClick = true;
			boxesList[indeks].Visible = false;
		}

		//Provera za dve slike dal su iste
		public bool AreImagesSame(Bitmap img1, Bitmap img2)
		{
			if (img1 == null || img2 == null)
				return false;

			if (img1.Width != img2.Width || img1.Height != img2.Height)
				return false;

			for (int y = 0; y < img1.Height; y++)
			{
				for (int x = 0; x < img1.Width; x++)
				{
					if (img1.GetPixel(x, y) != img2.GetPixel(x, y))
						return false;
				}
			}

			return true;
		}
		private void gameEnd() {
			timer.Stop();
			stoperica = new TimeSpan();
			skor = 100;
			MessageBox.Show("Kraj igre reseno za : " + labelaVreme.Text + ", Vas skor je: " + labelaSkor.Text);
		}

		private void Box_Click(object sender, EventArgs e)
		{
			if (!jelJeDozvoljenClick)
				return;
			if (startGame)
			{
				PictureBox pictureBox = (PictureBox)sender;
				int indeks = boxesList.IndexOf(pictureBox);
				//Otvori ga
				boxesList[indeks].Image = pictureBox.BackgroundImage;

				if (provera.Count != 2)
					provera.Add(boxesList[indeks]);

				if (AreImagesSame((Bitmap)boxesList[indeks].Image, Resource1.prazno) && provera.Count == 1)
				{
					skor += 50;
					Otvori(boxesList[indeks]);
					provera.Clear();
				}
				else
				{
					if (provera.Count == 2)
					{
						IzvrsiProveru(provera);
						provera.Clear();
						if (brojParova == 1)
							gameEnd();
					}
				}
			}
			labelaSkor.Text = skor.ToString();
			
		}
		private async void IzvrsiProveru(List<PictureBox> provera)
		{
			
			if (provera[0].Image == provera[1].Image && provera[0] != provera[1])
			{
				int prvi = boxesList.IndexOf(provera[0]);
				int drugi = boxesList.IndexOf(provera[1]);

				jelJeDozvoljenClick = false;
				await Task.Delay(700);
				jelJeDozvoljenClick = true;

				boxesList[prvi].Visible = false;
				boxesList[drugi].Visible = false;
				brojParova--;
				skor += 100;
			}
			else {
				int prvi = boxesList.IndexOf(provera[0]);
				int drugi = boxesList.IndexOf(provera[1]);
				if (!(skor == 0))
					skor -= 50;
				jelJeDozvoljenClick = false;
				await Task.Delay(700);
				jelJeDozvoljenClick = true;
				boxesList[prvi].Image = Resource1.zatvoreno;
				boxesList[drugi].Image = Resource1.zatvoreno;
				
			}
		}

		

		#region Loadovanje slika u listu
		private void LoadImages1(List<Image> imageList) {
			imageList.Add(Resource1.narandza);
			imageList.Add(Resource1.kapa);
			imageList.Add(Resource1.pica);
			imageList.Add(Resource1.kacket);
			imageList.Add(Resource1.solja);
			imageList.Add(Resource1.apple);
			imageList.Add(Resource1.burger);
			imageList.Add(Resource1.bombona);
			imageList.Add(Resource1.hotdog);
			imageList.Add(Resource1.naocare);
			imageList.Add(Resource1.kokice);
			imageList.Add(Resource1.meda);
			imageList.Add(Resource1.kruska);
			imageList.Add(Resource1.sladoled);
			imageList.Add(Resource1.prsten);
		}
		private void LoadImages2(List<Image> imageList)
		{

			List<String> tags = new List<String>
			{
				"pcela", "leptir", "puz", "bubamara", "cizme", "drvo", "grana", "kamen",
				"kofica", "sunce", "list", "pecurka", "ptica", "semenke", "zir"
			};

			Resource2.prazno.Tag = "prazno";
			Resource2.zatvoreno.Tag = "zatvoreno";
			imageList.Add(Resource2.pcela);
			imageList.Add(Resource2.leptir);
			imageList.Add(Resource2.puz);
			imageList.Add(Resource2.bubamara);
			imageList.Add(Resource2.cizme);
			imageList.Add(Resource2.drvo);
			imageList.Add(Resource2.grana);
			imageList.Add(Resource2.kamen);
			imageList.Add(Resource2.kofica);
			imageList.Add(Resource2.sunce);
			imageList.Add(Resource2.list);
			imageList.Add(Resource2.pecurka);
			imageList.Add(Resource2.ptica);
			imageList.Add(Resource2.semenke);
			imageList.Add(Resource2.zir);

			for (int i = 0; i < tags.Count; i++)
				imageList[i].Tag = tags[i];
		}
		#endregion

		//Dodavanje slika u boxove
		private void AddImagesToBoxes()
		{
			int brojBoxova = Int32.Parse((nudKolone.Value * nudRedovi.Value).ToString());
			brojParova = (10 * (brojBoxova / 10)) / 2;
			int brojPraznih = (Int32.Parse((nudKolone.Value * nudRedovi.Value).ToString()) % 10);

			List<int> indexesOfBoxes = new List<int>();
			List<int> indexesOfPrazni = new List<int>();
			for (int i = 0; i < brojBoxova; i++)
				indexesOfBoxes.Add(i);

			Mesanje(indexesOfBoxes);

			for (int i = 0; i < brojPraznih; i++)
			{
				indexesOfPrazni.Add(indexesOfBoxes[i]);
				indexesOfBoxes.RemoveAt(i);
				boxesList[indexesOfPrazni[i]].BackgroundImage = Resource1.prazno;
				
			}

			for (int i = 0; i < indexesOfBoxes.Count - 1; i += 2) {
				//Dodavanje slika u boxove
				boxesList[indexesOfBoxes[i]].BackgroundImage = imageList[i  % 15];
				boxesList[indexesOfBoxes[i]].BackgroundImage.Tag = imageList[i % 15].Tag;
				boxesList[indexesOfBoxes[i + 1]].BackgroundImage = imageList[i % 15];
				boxesList[indexesOfBoxes[i + 1]].BackgroundImage.Tag = imageList[i % 15].Tag;
			}
		}

		//Mesanje liste sa indeksima slika
		static void Mesanje<T>(List<T> list)
		{
			Random rng = new Random();
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}


		//Timer svaki tick prikaz za labelu
		private void Timer_Tick(object sender, EventArgs e)
		{
			stoperica = stoperica.Add(TimeSpan.FromSeconds(1));
			labelaVreme.Text = stoperica.ToString(@"hh\:mm\:ss");
		}

		//Skrivanje panela i meni, Generisanje novog polja na dugme itd.
		#region Klikovi 
		private void btnGenerisiPolje_Click(object sender, EventArgs e)
		{
			if (poljeGenerisano) { 
				boxesList.Clear();
			}

			int red = Int32.Parse(nudRedovi.Value.ToString());
			int kolona = Int32.Parse(nudKolone.Value.ToString());

			GeneratePictureBoxes(red, kolona);
			poljeGenerisano = true;
			AddImagesToBoxes();
		}
		private void openMeniToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panel2.Show();
		}

		private void btnClosePanel_Click(object sender, EventArgs e)
		{
			panel2.Hide();
		}

		private void btnStartGame_Click(object sender, EventArgs e)
		{
			if (poljeGenerisano)
			{
				//Clock start
				timer.Start();
				panel2.Hide();
				startGame = true;
				jelJeDozvoljenClick = true;
				skor = 100;
			}

			//igra.Logika();

		}

		private void button1_Click(object sender, EventArgs e)
		{

			timer.Stop();
			stoperica = new TimeSpan();
			jelJeDozvoljenClick = false;
			for (int i = 0; i < boxesList.Count; i++) {
				boxesList[i].Image = boxesList[i].BackgroundImage;
			}
		}
		private void odustaniToolStripMenuItem_Click(object sender, EventArgs e)
		{
			button1_Click(sender, e);
		}
		#endregion


		//Pokusaj saveovanja ali ne radi daje gresku
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				using (SaveFileDialog saveFileDialog = new SaveFileDialog())
				{
					saveFileDialog.Filter = "XML files (*.xml)|*.xml";
					saveFileDialog.Title = "Save your game";
					saveFileDialog.FileName = "myGame.xml";

					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						Info inf = new Info
						{
							Kolone = (int)this.nudKolone.Value,
							Redovi = (int)this.nudRedovi.Value,
							StartGame = this.startGame,
							BrojParova = this.brojParova,
							JelJeDozvoljenClick = this.jelJeDozvoljenClick,
							MyTimeSpan = this.stoperica,
							PoljeGenerisano = this.poljeGenerisano,
							BoxImageTags = new List<string>(),
							BoxMatchedStates = new List<bool>()
						};

						// Store the index of the images and whether each box is matched
						foreach (var pictureBox in boxesList)
						{
							if (pictureBox.BackgroundImage != null && pictureBox.BackgroundImage.Tag != null)
								inf.BoxImageTags.Add(pictureBox.BackgroundImage.Tag.ToString());

							inf.BoxMatchedStates.Add(pictureBox.Visible == false); // Store match status
						}

						SaveXML.SavedData(inf, saveFileDialog.FileName);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving the game:\n" + ex.Message);
			}
		}

		private void ResetGameState()
		{
			// Clear any previous game data
			boxesList.Clear();
			imageList.Clear();
			// Reset UI components, e.g. hide all picture boxes or reset their states
			foreach (var pictureBox in boxesList)
			{
				pictureBox.Visible = true;
				pictureBox.BackgroundImage = null;
			}
			// Add any other necessary resets, like time or score
			labelaSkor.Text = "0";
		}

		private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				ResetGameState();

				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "XML Files (*.xml)|*.xml";
				openFileDialog.Title = "Choose saved game (XML file)";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					// Load data from selected file
					Info inf = SaveXML.LoadedData(openFileDialog.FileName);

					// Restore game settings
					this.nudRedovi.Value = inf.Redovi;
					this.nudKolone.Value = inf.Kolone;
					this.startGame = inf.StartGame;
					this.brojParova = inf.BrojParova;
					this.jelJeDozvoljenClick = inf.JelJeDozvoljenClick;
					this.stoperica = inf.MyTimeSpan;
					this.poljeGenerisano = inf.PoljeGenerisano;

					// Update timer label
					labelaVreme.Text = stoperica.ToString(@"hh\:mm\:ss");

					// Load images into imageList (if needed)
					imageList.Clear();
					LoadImages2(imageList);

					// Recreate the field if needed
					if (poljeGenerisano)
					{
						GeneratePictureBoxes((int)nudRedovi.Value, (int)nudKolone.Value);
					}

					// Restore images and matched state
					for (int i = 0; i < boxesList.Count; i++)
					{
						string tag = inf.BoxImageTags[i];
						bool isMatched = inf.BoxMatchedStates[i];

						Image matchedImage = imageList.FirstOrDefault(img => img.Tag != null && img.Tag.ToString() == tag);
						boxesList[i].BackgroundImage = matchedImage;
						boxesList[i].Visible = !isMatched;
					}

					btnStartGame_Click(null, null);

					MessageBox.Show("Game has been loaded!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error game loading: " + ex.Message);
			}
		}


	}
}
