using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ListViewEmbeddedControls
{
	// Token: 0x02000002 RID: 2
	public class ListViewEx : ListView
	{
		// Token: 0x06000001 RID: 1
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wPar, IntPtr lPar);

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		protected int[] GetColumnOrder()
		{
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(int)) * base.Columns.Count);
			if (ListViewEx.SendMessage(base.Handle, 4155, new IntPtr(base.Columns.Count), intPtr).ToInt32() == 0)
			{
				Marshal.FreeHGlobal(intPtr);
				return null;
			}
			int[] array = new int[base.Columns.Count];
			Marshal.Copy(intPtr, array, 0, base.Columns.Count);
			Marshal.FreeHGlobal(intPtr);
			return array;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020DC File Offset: 0x000002DC
		protected Rectangle GetSubItemBounds(ListViewItem Item, int SubItem)
		{
			Rectangle empty = Rectangle.Empty;
			if (Item == null)
			{
				throw new ArgumentNullException("Item");
			}
			int[] columnOrder = this.GetColumnOrder();
			if (columnOrder == null)
			{
				return empty;
			}
			if (SubItem >= columnOrder.Length)
			{
				throw new IndexOutOfRangeException("SubItem " + SubItem.ToString() + " out of range");
			}
			Rectangle bounds = Item.GetBounds(ItemBoundsPortion.Entire);
			int num = bounds.Left;
			int i;
			for (i = 0; i < columnOrder.Length; i++)
			{
				ColumnHeader columnHeader = base.Columns[columnOrder[i]];
				if (columnHeader.Index == SubItem)
				{
					break;
				}
				num += columnHeader.Width;
			}
			empty = new Rectangle(num, bounds.Top, base.Columns[columnOrder[i]].Width, bounds.Height);
			return empty;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000219D File Offset: 0x0000039D
		public void AddEmbeddedControl(Control c, int col, int row)
		{
			this.AddEmbeddedControl(c, col, row, DockStyle.Fill);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021AC File Offset: 0x000003AC
		public void AddEmbeddedControl(Control c, int col, int row, DockStyle dock)
		{
			if (c == null)
			{
				throw new ArgumentNullException();
			}
			if (col >= base.Columns.Count || row >= base.Items.Count)
			{
				throw new ArgumentOutOfRangeException();
			}
			ListViewEx.EmbeddedControl embeddedControl;
			embeddedControl.Control = c;
			embeddedControl.Column = col;
			embeddedControl.Row = row;
			embeddedControl.Dock = dock;
			embeddedControl.Item = base.Items[row];
			this._embeddedControls.Add(embeddedControl);
			c.Click += this._embeddedControl_Click;
			base.Controls.Add(c);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002248 File Offset: 0x00000448
		public void RemoveEmbeddedControl(Control c)
		{
			if (c == null)
			{
				throw new ArgumentNullException();
			}
			for (int i = 0; i < this._embeddedControls.Count; i++)
			{
				if (((ListViewEx.EmbeddedControl)this._embeddedControls[i]).Control == c)
				{
					c.Click -= this._embeddedControl_Click;
					base.Controls.Remove(c);
					this._embeddedControls.RemoveAt(i);
					return;
				}
			}
			throw new Exception("Control not found!");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022C4 File Offset: 0x000004C4
		public Control GetEmbeddedControl(int col, int row)
		{
			foreach (object obj in this._embeddedControls)
			{
				ListViewEx.EmbeddedControl embeddedControl = (ListViewEx.EmbeddedControl)obj;
				if (embeddedControl.Row == row && embeddedControl.Column == col)
				{
					return embeddedControl.Control;
				}
			}
			return null;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002334 File Offset: 0x00000534
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000233C File Offset: 0x0000053C
		[DefaultValue(View.LargeIcon)]
		public new View View
		{
			get
			{
				return base.View;
			}
			set
			{
				foreach (object obj in this._embeddedControls)
				{
					((ListViewEx.EmbeddedControl)obj).Control.Visible = (value == View.Details);
				}
				base.View = value;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000023A4 File Offset: 0x000005A4
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 15 && this.View == View.Details)
			{
				foreach (object obj in this._embeddedControls)
				{
					ListViewEx.EmbeddedControl embeddedControl = (ListViewEx.EmbeddedControl)obj;
					Rectangle subItemBounds = this.GetSubItemBounds(embeddedControl.Item, embeddedControl.Column);
					if (base.HeaderStyle != ColumnHeaderStyle.None && subItemBounds.Top < this.Font.Height)
					{
						embeddedControl.Control.Visible = false;
					}
					else
					{
						embeddedControl.Control.Visible = true;
						switch (embeddedControl.Dock)
						{
						case DockStyle.None:
							subItemBounds.Size = embeddedControl.Control.Size;
							break;
						case DockStyle.Top:
							subItemBounds.Height = embeddedControl.Control.Height;
							break;
						case DockStyle.Bottom:
							subItemBounds.Offset(0, subItemBounds.Height - embeddedControl.Control.Height);
							subItemBounds.Height = embeddedControl.Control.Height;
							break;
						case DockStyle.Left:
							subItemBounds.Width = embeddedControl.Control.Width;
							break;
						case DockStyle.Right:
							subItemBounds.Offset(subItemBounds.Width - embeddedControl.Control.Width, 0);
							subItemBounds.Width = embeddedControl.Control.Width;
							break;
						}
						embeddedControl.Control.Bounds = subItemBounds;
					}
				}
			}
			base.WndProc(ref m);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002544 File Offset: 0x00000744
		private void _embeddedControl_Click(object sender, EventArgs e)
		{
			foreach (object obj in this._embeddedControls)
			{
				ListViewEx.EmbeddedControl embeddedControl = (ListViewEx.EmbeddedControl)obj;
				if (embeddedControl.Control == (Control)sender)
				{
					base.SelectedItems.Clear();
					embeddedControl.Item.Selected = true;
				}
			}
		}

		// Token: 0x04000001 RID: 1
		private const int LVM_FIRST = 4096;

		// Token: 0x04000002 RID: 2
		private const int LVM_GETCOLUMNORDERARRAY = 4155;

		// Token: 0x04000003 RID: 3
		private const int WM_PAINT = 15;

		// Token: 0x04000004 RID: 4
		private ArrayList _embeddedControls = new ArrayList();

		// Token: 0x02000010 RID: 16
		private struct EmbeddedControl
		{
			// Token: 0x04000085 RID: 133
			public Control Control;

			// Token: 0x04000086 RID: 134
			public int Column;

			// Token: 0x04000087 RID: 135
			public int Row;

			// Token: 0x04000088 RID: 136
			public DockStyle Dock;

			// Token: 0x04000089 RID: 137
			public ListViewItem Item;
		}
	}
}
