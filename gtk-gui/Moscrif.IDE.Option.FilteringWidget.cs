
// This file has been generated by the GUI designer. Do not modify.
namespace Moscrif.IDE.Option
{
	public partial class FilteringWidget
	{
		private global::Gtk.Table table2;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView tvMask;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TreeView tvFilter;
		private global::Gtk.Label label3;
		private global::Gtk.Label label4;
		private global::Gtk.VButtonBox vbuttonbox2;
		private global::Gtk.Button btnAddMask;
		private global::Gtk.Button btnDeleteMask;
		private global::Gtk.Button btnEditMask;
		private global::Gtk.VButtonBox vbuttonbox3;
		private global::Gtk.Button btnAddFilter;
		private global::Gtk.Button btnDeleteFilter;
		private global::Gtk.Button btnEditFilter;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Moscrif.IDE.Option.FilteringWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Moscrif.IDE.Option.FilteringWidget";
			// Container child Moscrif.IDE.Option.FilteringWidget.Gtk.Container+ContainerChild
			this.table2 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.tvMask = new global::Gtk.TreeView ();
			this.tvMask.CanFocus = true;
			this.tvMask.Name = "tvMask";
			this.GtkScrolledWindow.Add (this.tvMask);
			this.table2.Add (this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2 [this.GtkScrolledWindow]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YPadding = ((uint)(5));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.tvFilter = new global::Gtk.TreeView ();
			this.tvFilter.CanFocus = true;
			this.tvFilter.Name = "tvFilter";
			this.GtkScrolledWindow1.Add (this.tvFilter);
			this.table2.Add (this.GtkScrolledWindow1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.GtkScrolledWindow1]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YPadding = ((uint)(5));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Mask");
			this.table2.Add (this.label3);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2 [this.label3]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.XPadding = ((uint)(5));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Filter");
			this.table2.Add (this.label4);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2 [this.label4]));
			w6.XPadding = ((uint)(5));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.vbuttonbox2 = new global::Gtk.VButtonBox ();
			this.vbuttonbox2.Name = "vbuttonbox2";
			this.vbuttonbox2.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
			// Container child vbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.btnAddMask = new global::Gtk.Button ();
			this.btnAddMask.CanFocus = true;
			this.btnAddMask.Name = "btnAddMask";
			this.btnAddMask.UseUnderline = true;
			this.btnAddMask.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.vbuttonbox2.Add (this.btnAddMask);
			global::Gtk.ButtonBox.ButtonBoxChild w7 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox2 [this.btnAddMask]));
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.btnDeleteMask = new global::Gtk.Button ();
			this.btnDeleteMask.CanFocus = true;
			this.btnDeleteMask.Name = "btnDeleteMask";
			this.btnDeleteMask.UseUnderline = true;
			this.btnDeleteMask.Label = global::Mono.Unix.Catalog.GetString ("Delete");
			this.vbuttonbox2.Add (this.btnDeleteMask);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox2 [this.btnDeleteMask]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.btnEditMask = new global::Gtk.Button ();
			this.btnEditMask.CanFocus = true;
			this.btnEditMask.Name = "btnEditMask";
			this.btnEditMask.UseUnderline = true;
			this.btnEditMask.Label = global::Mono.Unix.Catalog.GetString ("Edit");
			this.vbuttonbox2.Add (this.btnEditMask);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox2 [this.btnEditMask]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			this.table2.Add (this.vbuttonbox2);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table2 [this.vbuttonbox2]));
			w10.TopAttach = ((uint)(2));
			w10.BottomAttach = ((uint)(3));
			w10.LeftAttach = ((uint)(2));
			w10.RightAttach = ((uint)(3));
			w10.XPadding = ((uint)(5));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.vbuttonbox3 = new global::Gtk.VButtonBox ();
			this.vbuttonbox3.Name = "vbuttonbox3";
			this.vbuttonbox3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
			// Container child vbuttonbox3.Gtk.ButtonBox+ButtonBoxChild
			this.btnAddFilter = new global::Gtk.Button ();
			this.btnAddFilter.CanFocus = true;
			this.btnAddFilter.Name = "btnAddFilter";
			this.btnAddFilter.UseUnderline = true;
			this.btnAddFilter.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.vbuttonbox3.Add (this.btnAddFilter);
			global::Gtk.ButtonBox.ButtonBoxChild w11 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox3 [this.btnAddFilter]));
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbuttonbox3.Gtk.ButtonBox+ButtonBoxChild
			this.btnDeleteFilter = new global::Gtk.Button ();
			this.btnDeleteFilter.CanFocus = true;
			this.btnDeleteFilter.Name = "btnDeleteFilter";
			this.btnDeleteFilter.UseUnderline = true;
			this.btnDeleteFilter.Label = global::Mono.Unix.Catalog.GetString ("Delete");
			this.vbuttonbox3.Add (this.btnDeleteFilter);
			global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox3 [this.btnDeleteFilter]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbuttonbox3.Gtk.ButtonBox+ButtonBoxChild
			this.btnEditFilter = new global::Gtk.Button ();
			this.btnEditFilter.CanFocus = true;
			this.btnEditFilter.Name = "btnEditFilter";
			this.btnEditFilter.UseUnderline = true;
			this.btnEditFilter.Label = global::Mono.Unix.Catalog.GetString ("Edit");
			this.vbuttonbox3.Add (this.btnEditFilter);
			global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox3 [this.btnEditFilter]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			this.table2.Add (this.vbuttonbox3);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table2 [this.vbuttonbox3]));
			w14.LeftAttach = ((uint)(2));
			w14.RightAttach = ((uint)(3));
			w14.YPadding = ((uint)(5));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.btnAddFilter.Clicked += new global::System.EventHandler (this.OnBtnAddFilterClicked);
			this.btnDeleteFilter.Clicked += new global::System.EventHandler (this.OnBtnDeleteFilterClicked);
			this.btnEditFilter.Clicked += new global::System.EventHandler (this.OnBtnEditFilterClicked);
			this.btnAddMask.Clicked += new global::System.EventHandler (this.OnBtnAddMaskClicked);
			this.btnDeleteMask.Clicked += new global::System.EventHandler (this.OnBtnDeleteMaskClicked);
			this.btnEditMask.Clicked += new global::System.EventHandler (this.OnBtnEditMaskClicked);
		}
	}
}
