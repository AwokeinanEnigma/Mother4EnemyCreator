using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using fNbt;
using Spriteman.Exceptions;
using Spriteman.Properties;

namespace Spriteman
{
	// Token: 0x02000008 RID: 8
	public partial class MainForm : Form
	{
		// Token: 0x06000024 RID: 36 RVA: 0x0000371B File Offset: 0x0000191B
		public MainForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000372C File Offset: 0x0000192C
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

		// Token: 0x06000026 RID: 38 RVA: 0x0000375F File Offset: 0x0000195F
		private void spriteList_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				MessageBox.Show("delete");
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003778 File Offset: 0x00001978
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

		// Token: 0x06000028 RID: 40 RVA: 0x000037D7 File Offset: 0x000019D7
		private void openButton_Click(object sender, EventArgs e)
		{
			if (this.openImageDialog.ShowDialog(this) == DialogResult.OK)
			{
				this.LoadFile(this.openImageDialog.FileName);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000037F9 File Offset: 0x000019F9
		private void saveButton_Click(object sender, EventArgs e)
		{
			if (this.workingFileName != null)
			{
				this.SaveSpriteSheet(this.workingFileName);
				return;
			}
			this.saveAsButton_Click(sender, e);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003818 File Offset: 0x00001A18
		private void saveAsButton_Click(object sender, EventArgs e)
		{
			if (this.saveImageDialog.ShowDialog(this) == DialogResult.OK)
			{
				this.SaveSpriteSheet(this.saveImageDialog.FileName);
				this.workingFileName = this.saveImageDialog.FileName;
			}
		}


		// Token: 0x06000035 RID: 53 RVA: 0x00003EAC File Offset: 0x000020AC
		private void LoadSpriteSheet(string filename)
		{
			if (Path.GetExtension(filename) == ".dat")
			{
				try
				{
					this.LoadSpriteSheetFromDat(filename);
					//this.sheetBox.Size = this.image.Size;
					this.workingFileName = filename;
					this.isLoaded = true;
					//his.image.Save(filename + ".png");
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Format("{0}\n{1}", ex.Message, ex.StackTrace), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
			}
		}



		// Token: 0x06000037 RID: 55 RVA: 0x00003F78 File Offset: 0x00002178

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
        public void TransferStr(NbtString fo, RichTextBox nud)
        {
            nud.Text = fo.Value;
		}
		public void TransferI(NbtInt fo, NumericUpDown nud)
        {
            nud.Value = (decimal)fo.Value;
        }

		// Token: 0x06000038 RID: 56 RVA: 0x0000408C File Offset: 0x0000228C
		private void LoadSpriteSheetFromDat(string filename)
		{
            NbtCompound rootTag = new NbtFile(filename).RootTag;

			//Transfer(new NbtFloat("elec", (float)numericUpDown1.Value));

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
			TransferStr(str.Get<NbtString>("article"), richTextBox10);
			TransferStr(str.Get<NbtString>("defeat"), richTextBox8);
            TransferStr(str.Get<NbtString>("encounter"), richTextBox9);
			TransferStr(str.Get<NbtString>("name"), richTextBox7);
			TransferStr(str.Get<NbtString>("possessive"), richTextBox6);
			TransferStr(str.Get<NbtString>("subjective"), richTextBox11);
			TransferStr(str.Get<NbtString>("telepathy"), richTextBox12);
			TransferStr(str.Get<NbtString>("thoughts"), richTextBox13);

            TransferStr(rootTag.Get<NbtString>("ainame"), richTextBox3);
            TransferStr(rootTag.Get<NbtString>("bbg"), richTextBox2);
            TransferI(rootTag.Get<NbtInt>("exp"), numericUpDown17);
            TransferStr(rootTag.Get<NbtString>("bgm"), richTextBox4);
		}


		// Token: 0x0600003A RID: 58 RVA: 0x00004550 File Offset: 0x00002750
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

		// Token: 0x0600003B RID: 59 RVA: 0x0000462C File Offset: 0x0000282C
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

			rootTag.Add(mods);
			rootTag.Add(stats);
			rootTag.Add(str);

			rootTag.Add(new NbtString("ainame", richTextBox3.Text));
			rootTag.Add(new NbtString("bbg", richTextBox2.Text));
			rootTag.Add(new NbtInt("exp", (int)numericUpDown17.Value));
			rootTag.Add(new NbtString("bgm", richTextBox4.Text));
			rootTag.Add(new NbtString("spr", richTextBox5.Text));

			nbtFile.SaveToFile(filename, NbtCompression.GZip);
		}



		// Token: 0x0600003D RID: 61 RVA: 0x000049E8 File Offset: 0x00002BE8
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

		// Token: 0x0400001A RID: 26
		private bool isLoaded;

		// Token: 0x0400001B RID: 27
		private string workingFileName;

		// Token: 0x0400001C RID: 28
		private Bitmap image;

		// Token: 0x0400001D RID: 29
		private List<List<Color>> palettes;

		// Token: 0x0400001E RID: 30
		private int activePalette;

		// Token: 0x0400001F RID: 31
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
	}
}
