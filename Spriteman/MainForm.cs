using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using fNbt;
using M4EC.Exceptions;
using M4EC.Properties;

namespace M4EC
{
	public partial class MainForm : Form
	{
        public static readonly string RESOURCES = "Data" + Path.DirectorySeparatorChar;
        public static readonly string GRAPHICS = Path.Combine(RESOURCES, "Graphics", "") + Path.DirectorySeparatorChar;
		public static readonly string GRAPHICSENEMIES = GRAPHICS + "Enemies" + Path.DirectorySeparatorChar;

		public MainForm()
		{
			this.InitializeComponent();
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			this.activePalette = 0;
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			if (commandLineArgs.Length > 1)
			{
				string text = commandLineArgs[1];
				if (File.Exists(text))
				{
					this.LoadFile(text);
				}
			}
		}
		private void spriteList_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				MessageBox.Show("delete");
			}
		}
		private void LoadFile(string filename)
		{
			this.isLoaded = false;
			this.LoadSpriteSheet(filename);
			if (this.isLoaded)
			{
				this.saveButton.Enabled = true;
				this.saveAsButton.Enabled = true;
			}
		}
		private void openButton_Click(object sender, EventArgs e)
		{
			if (this.openImageDialog.ShowDialog(this) == DialogResult.OK)
			{
				this.LoadFile(this.openImageDialog.FileName);
			}
		}
		private void saveButton_Click(object sender, EventArgs e)
		{
			if (this.workingFileName != null)
			{
				this.SaveSpriteSheet(this.workingFileName);
				return;
			}
			this.saveAsButton_Click(sender, e);
		}
		private void saveAsButton_Click(object sender, EventArgs e)
		{
			if (this.saveImageDialog.ShowDialog(this) == DialogResult.OK)
			{
				this.SaveSpriteSheet(this.saveImageDialog.FileName);
				this.workingFileName = this.saveImageDialog.FileName;
			}
		}
		private void LoadSpriteSheet(string filename)
		{
			if (Path.GetExtension(filename) == ".edat")
			{
				try
				{
					this.LoadEnemyDataFromEDat(filename);
					//this.sheetBox.Size = this.image.Size;
					this.workingFileName = filename;
					this.isLoaded = true;
					//his.image.Save(filename + ".png");
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Format("{0}\n{1}", ex.Message, ex.StackTrace), "Error loading EDat file. You'll have to recover manually.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
			}
		}

        public void Transfer(NbtFloat fo, NumericUpDown nud)
        {
            nud.Value = (decimal)fo.Value;
        }
        public void TransferB(NbtByte fo, NumericUpDown nud)
        {
            nud.Value = (decimal)fo.Value;
		}
        public void TransferS(NbtShort fo, NumericUpDown nud)
        {
            nud.Value = (decimal)fo.Value;
        }

        public void TransferStr(NbtString fo, RichTextBox nud, string nameOFFIELD)
        {
            if (fo != null)
            {
                nud.Text = fo.Value;
            }
            else
            {
                MessageBox.Show($"Error loading field data from nbt string {nameOFFIELD}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TransferI(NbtInt fo, NumericUpDown nud)
        {
            nud.Value = (decimal)fo.Value;
        }
		private void LoadEnemyDataFromEDat(string filename)
		{
            NbtCompound rootTag = new NbtFile(filename).RootTag;

			//Transfer(new NbtFloat("elec", (float)numericUpDown1.Value));

            Trace.WriteLine("asfsaf sprite");

			NbtCompound mods = rootTag.Get<NbtCompound>("modifiers");
			Transfer(mods.Get<NbtFloat>("elec"), numericUpDown1);
			Transfer(mods.Get<NbtFloat>("expl"), numericUpDown2);
            Transfer(mods.Get<NbtFloat>("fire"), numericUpDown8);
			Transfer(mods.Get<NbtFloat>("ice"), numericUpDown3);
			Transfer(mods.Get<NbtFloat>("naus"), numericUpDown4);
			Transfer(mods.Get<NbtFloat>("phys"), numericUpDown9);
			Transfer(mods.Get<NbtFloat>("pois"), numericUpDown5);
			Transfer(mods.Get<NbtFloat>("wet"), numericUpDown8);

            NbtCompound stats = rootTag.Get<NbtCompound>("stats");
			TransferB(stats.Get<NbtByte>("def"), numericUpDown18);
            TransferB(stats.Get<NbtByte>("gut"), numericUpDown19);
			TransferS(stats.Get<NbtShort>("hp"), numericUpDown12);
            TransferB(stats.Get<NbtByte>("iq"), numericUpDown11);
            TransferB(stats.Get<NbtByte>("lck"), numericUpDown16);
            TransferB(stats.Get<NbtByte>("lvl"), numericUpDown20);
            TransferB(stats.Get<NbtByte>("off"), numericUpDown15);
			TransferS(stats.Get<NbtShort>("pp"), numericUpDown14);
            TransferB(stats.Get<NbtByte>("spd"), numericUpDown13);

            NbtCompound str = rootTag.Get<NbtCompound>("str");
			TransferStr(str.Get<NbtString>("article"), richTextBox10, "article");
			TransferStr(str.Get<NbtString>("defeat"), richTextBox8, "defeat");
            TransferStr(str.Get<NbtString>("encounter"), richTextBox9, "encounter");
			TransferStr(str.Get<NbtString>("name"), richTextBox7, "name");
			TransferStr(str.Get<NbtString>("possessive"), richTextBox6, "possessive");
			TransferStr(str.Get<NbtString>("subjective"), richTextBox11, "subjective");
			TransferStr(str.Get<NbtString>("telepathy"), richTextBox12, "telepathy");
            TransferStr(str.Get<NbtString>("thoughts"), richTextBox13, "thoughts");
            TransferStr(str.Get<NbtString>("wasteaction"), richTextBox15, "wasteaction");

			TransferStr(rootTag.Get<NbtString>("ainame"), richTextBox3, "ainame");
            TransferStr(rootTag.Get<NbtString>("bbg"), richTextBox2, "bbg");
            TransferI(rootTag.Get<NbtInt>("exp"), numericUpDown17);
            TransferStr(rootTag.Get<NbtString>("bgm"), richTextBox4, "bgm");
            TransferStr(rootTag.Get<NbtString>("spr"), richTextBox5, "spr");

            TransferI(rootTag.Get<NbtInt>("imm"), numericUpDown10);
            TransferI(rootTag.Get<NbtInt>("opt"), numericUpDown21);
            Console.WriteLine("loading sprite");
            TransferStr(rootTag.Get<NbtString>("overworldspr"), richTextBox14, "overworldspr");

            LoadDat();
        }
		private void InitializePalette()
		{
			List<Color> list = new List<Color>();
			this.indices = new byte[this.image.Width * this.image.Height];
			for (int i = 0; i < this.image.Width; i++)
			{
				for (int j = 0; j < this.image.Height; j++)
				{
					Color pixel = this.image.GetPixel(i, j);
					byte b;
					if (!list.Contains(pixel))
					{
						b = (byte)list.Count;
						list.Add(pixel);
					}
					else
					{
						b = (byte)list.IndexOf(pixel);
					}
					this.indices[j * this.image.Width + i] = b;
					if (list.Count > 256)
					{
						throw new IndexOutOfRangeException("The number of colors in the palette has exceeded 256.");
					}
				}
			}
			this.palettes.Add(list);
			this.activePalette = 0;
		}
		private void SaveSpriteSheet(string filename)
		{
			NbtFile nbtFile = new NbtFile();
			NbtCompound rootTag = nbtFile.RootTag;

			NbtCompound mods = new NbtCompound("modifiers");
			mods.Add(new NbtFloat("elec", (float)numericUpDown1.Value));
			mods.Add(new NbtFloat("expl", (float)numericUpDown2.Value));
			mods.Add(new NbtFloat("fire", (float)numericUpDown8.Value));
            mods.Add(new NbtFloat("ice", (float)numericUpDown3.Value));
			mods.Add(new NbtFloat("naus", (float)numericUpDown4.Value));
			mods.Add(new NbtFloat("phys", (float)numericUpDown9.Value));
			mods.Add(new NbtFloat("pois", (float)numericUpDown5.Value));
			mods.Add(new NbtFloat("wet", (float)numericUpDown8.Value));

			NbtCompound stats = new NbtCompound("stats");
            stats.Add(new NbtByte("def", (byte)numericUpDown18.Value));
            stats.Add(new NbtByte("gut", (byte)numericUpDown19.Value));
            stats.Add(new NbtShort("hp", (short)numericUpDown12.Value));
            stats.Add(new NbtByte("iq", (byte)numericUpDown11.Value));
            stats.Add(new NbtByte("lck", (byte)numericUpDown16.Value));
            stats.Add(new NbtByte("lvl", (byte)numericUpDown20.Value));
            stats.Add(new NbtByte("off", (byte)numericUpDown15.Value));
            stats.Add(new NbtShort("pp", (short)numericUpDown14.Value));
            stats.Add(new NbtByte("spd", (byte)numericUpDown13.Value));

			NbtCompound str = new NbtCompound("str");
			str.Add(new NbtString("article", richTextBox10.Text));
			str.Add(new NbtString("defeat", richTextBox8.Text));
			str.Add(new NbtString("encounter", richTextBox9.Text));
			str.Add(new NbtString("name", richTextBox7.Text));
			str.Add(new NbtString("possessive", richTextBox6.Text));
			str.Add(new NbtString("subjective", richTextBox11.Text));
			str.Add(new NbtString("telepathy", richTextBox12.Text));
			str.Add(new NbtString("thoughts", richTextBox13.Text));
			str.Add(new NbtString("wasteaction", richTextBox15.Text));

			rootTag.Add(mods);
			rootTag.Add(stats);
			rootTag.Add(str);

			rootTag.Add(new NbtString("ainame", richTextBox3.Text));
			rootTag.Add(new NbtString("bbg", richTextBox2.Text));
            rootTag.Add(new NbtInt("exp", (int)numericUpDown17.Value));
			rootTag.Add(new NbtString("bgm", richTextBox4.Text));
            rootTag.Add(new NbtString("spr", richTextBox5.Text));
            rootTag.Add(new NbtString("overworldspr", richTextBox14.Text));

			rootTag.Add(new NbtInt("imm", (int)numericUpDown10.Value));
            rootTag.Add(new NbtInt("opt", (int)numericUpDown21.Value));

			nbtFile.SaveToFile(filename, NbtCompression.GZip);
		}
		private void RemapColors(List<Tuple<int, int>> remap)
		{
			for (int i = 0; i < remap.Count; i++)
			{
				Tuple<int, int> tuple = remap[i];
				for (int j = 0; j < this.indices.Length; j++)
				{
					if ((int)this.indices[j] == tuple.Item1)
					{
						this.indices[j] = (byte)tuple.Item2;
					}
					else if ((int)this.indices[j] == tuple.Item2)
					{
						this.indices[j] = (byte)tuple.Item1;
					}
				}
			}
		}
		private bool isLoaded;
		private string workingFileName;
		private Bitmap image;
		private List<List<Color>> palettes;
		private int activePalette;
		private byte[] indices;

		private void numericUpDown8_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label13_Click(object sender, EventArgs e)
		{

		}

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void numericUpDown9_ValueChanged(object sender, EventArgs e)
		{

		}

				private void LoadSpriteSheetFromDat(string filename)
		{
			NbtCompound rootTag = new NbtFile(filename).RootTag;
			NbtByteArray nbtByteArray = rootTag.Get<NbtByteArray>("img");
			this.indices = nbtByteArray.ByteArrayValue;
			NbtCompound nbtCompound = null;
			bool useList = false;
			NbtList nebtList = null;
			try
			{
				nbtCompound = rootTag.Get<NbtCompound>("pal");
			}
			catch
			{
				useList = true;
				nebtList = rootTag.Get<NbtList>("pal");
			}
			this.palettes = new List<List<Color>>();
			if (!useList)
			{
				using (IEnumerator<NbtTag> enumerator = nbtCompound.Tags.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						NbtTag nbtTag4 = enumerator.Current;
						int[] intArrayValue = ((NbtIntArray)nbtTag4).IntArrayValue;
						List<Color> list = new List<Color>();
						for (int i = 0; i < intArrayValue.Length; i++)
						{
							Color item = Color.FromArgb(intArrayValue[i]);
							list.Add(item);
						}
						this.palettes.Add(list);
					}
					goto IL_13F;
				}
			}
			foreach (NbtTag nbtTag5 in nebtList)
			{
				int[] intArrayValue2 = ((NbtIntArray)nbtTag5).IntArrayValue;
				List<Color> list2 = new List<Color>();
				for (int j = 0; j < intArrayValue2.Length; j++)
				{
					Color item2 = Color.FromArgb(intArrayValue2[j]);
					list2.Add(item2);
				}
				this.palettes.Add(list2);
			}
			IL_13F:
			NbtCompound nbtCompound2 = rootTag.Get<NbtCompound>("spr");
			if (nbtCompound2 != null)
			{
				foreach (NbtTag nbtTag6 in nbtCompound2.Tags)
				{
					NbtCompound nbtCompound3 = (NbtCompound)nbtTag6;
					string name = nbtCompound3.Name;
					int[] intArrayValue3 = nbtCompound3.Get<NbtIntArray>("crd").IntArrayValue;
					int[] intArrayValue4 = nbtCompound3.Get<NbtIntArray>("bnd").IntArrayValue;
					int[] intArrayValue5 = nbtCompound3.Get<NbtIntArray>("org").IntArrayValue;
					byte[] byteArrayValue = nbtCompound3.Get<NbtByteArray>("opt").ByteArrayValue;
					int intValue = nbtCompound3.Get<NbtInt>("frm").IntValue;
					NbtTag nbtTag3 = nbtCompound3.Get("spd");
					float[] array;
					if (nbtTag3.TagType == NbtTagType.Float)
					{
						array = new float[]
						{
							nbtTag3.FloatValue
						};
					}
					else
					{
						NbtTag[] array2 = nbtCompound3.Get<NbtList>("spd").ToArray();
						array = new float[array2.Length];
						for (int k = 0; k < array2.Length; k++)
						{
							array[k] = array2[k].FloatValue;
						}
					}
					Point coords = new Point(intArrayValue3[0], intArrayValue3[1]);
					Size bounds = new Size(intArrayValue4[0], intArrayValue4[1]);
					Point origin = new Point(intArrayValue5[0], intArrayValue5[1]);
					bool flipX = byteArrayValue[0] == 1;
					bool flipY = byteArrayValue[1] == 1;
					int mode = (int)byteArrayValue[2];
					Sprite sprite = new Sprite(name, coords, bounds, origin, intValue, array, flipX, flipY, mode);
					//this.AddSpriteRow(sprite);
				}
			}
			int intValue2 = rootTag.Get<NbtInt>("w").IntValue;
			int num = this.indices.Length / intValue2;
			this.image = new Bitmap(intValue2, num);
			using (Graphics.FromImage(this.image))
			{
				for (int l = 0; l < num; l++)
				{
					for (int m = 0; m < intValue2; m++)
					{
						List<Color> list3 = this.palettes[0];
						int index = (int)this.indices[l * intValue2 + m];
						this.image.SetPixel(m, l, list3[index]);
					}
				}
			}
            image = new Bitmap(image, new Size(image.Width * 2, image.Height * 2));
			// InterpolationMode.NearestNeighbor;
		}

                private void picBox_Paint_1(object sender, PaintEventArgs e)
                {
                    e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                    if (image != null)
                    {
                    }


                }

                public void LoadDat()
		{           //hhhhhhm

            //corresponds to Resources/Graphics/Enemies/(richTextBox5.text).dat
            //requires the exe to be in the same folder as the 

            string text = GRAPHICSENEMIES + richTextBox5.Text + ".dat";


            try
            {
                this.LoadSpriteSheetFromDat(text);
                this.pictureBox1.Image = this.image;
                //useThisForDaImage.Image.Height *= 3;
                this.pictureBox1.Dock = DockStyle.None;
                //Graphics.
                //this.pictureBox1.Size = this.image.Size;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}\n{1}", ex.Message, ex.StackTrace), "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
		}

                private void button1_Click(object sender, EventArgs e)
                {
                    LoadDat();

                }
	}
}
