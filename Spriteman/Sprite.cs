using System;
using System.Drawing;

namespace M4EC
{
	public class Sprite
	{
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00006704 File Offset: 0x00004904
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000670C File Offset: 0x0000490C
		public string Name { get; set; }
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00006715 File Offset: 0x00004915
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000671D File Offset: 0x0000491D
		public Point Coords { get; set; }
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00006726 File Offset: 0x00004926
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0000672E File Offset: 0x0000492E
		public Size Bounds { get; set; }
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00006737 File Offset: 0x00004937
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0000673F File Offset: 0x0000493F
		public Point Origin { get; set; }
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00006748 File Offset: 0x00004948
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00006750 File Offset: 0x00004950
		public int Frames { get; set; }
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00006759 File Offset: 0x00004959
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00006761 File Offset: 0x00004961
		public float[] SpeedSet { get; set; }
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000676A File Offset: 0x0000496A
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00006772 File Offset: 0x00004972
		public bool FlipX { get; set; }
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000677B File Offset: 0x0000497B
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00006783 File Offset: 0x00004983
		public bool FlipY { get; set; }
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000678C File Offset: 0x0000498C
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00006794 File Offset: 0x00004994
		public int Mode { get; set; }
		public Sprite(string name, Point coords, Size bounds, Point origin, int frames, float[] speeds, bool flipX, bool flipY, int mode)
		{
			this.Name = name;
			this.Coords = coords;
			this.Bounds = bounds;
			this.Origin = origin;
			this.Frames = frames;
			this.SpeedSet = speeds;
			this.FlipX = flipX;
			this.FlipY = flipY;
			this.Mode = mode;
		}
	}
}
