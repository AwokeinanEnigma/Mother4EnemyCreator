using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ListViewEmbeddedControls
{
	public class ListViewEx : ListView
	{
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wPar, IntPtr lPar);
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
		public void AddEmbeddedControl(Control c, int col, int row)
		{
			this.AddEmbeddedControl(c, col, row, DockStyle.Fill);
		}
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
		private const int LVM_FIRST = 4096;
		private const int LVM_GETCOLUMNORDERARRAY = 4155;
		private const int WM_PAINT = 15;
		private ArrayList _embeddedControls = new ArrayList();
		private struct EmbeddedControl
		{
			public Control Control;
			public int Column;
			public int Row;
			public DockStyle Dock;
			public ListViewItem Item;
		}
	}
}
