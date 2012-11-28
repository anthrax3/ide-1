
// This file has been generated by the GUI designer. Do not modify.
namespace Moscrif.IDE.Option
{
	public partial class DevicesOptionsWidget
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView tvFiles;
		private global::Gtk.VButtonBox vbuttonbox1;
		private global::Gtk.Button btnAdd;
		private global::Gtk.Button btnRemove;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment;
		private global::Gtk.Table table1;
		private global::Gtk.ComboBox cbResolution;
		private global::Gtk.Label label1;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.SpinButton sbHeight;
		private global::Gtk.SpinButton sbWidth;
		private global::Gtk.Label GtkLabel3;
		private global::Gtk.Table table3;
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment1;
		private global::Gtk.Table table2;
		private global::Gtk.Entry entAuthor;
		private global::Gtk.Entry entTitle;
		private global::Gtk.Entry entUrl;
		private global::Gtk.Label label4;
		private global::Gtk.Label label5;
		private global::Gtk.Label label6;
		private global::Gtk.Label GtkLabel4;
		private global::Gtk.Frame frame3;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.CheckButton chbTablet;
		private global::Gtk.Label GtkLabel5;
		private global::Gtk.HButtonBox hbuttonbox2;
		private global::Gtk.Button button1268;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Moscrif.IDE.Option.DevicesOptionsWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Moscrif.IDE.Option.DevicesOptionsWidget";
			// Container child Moscrif.IDE.Option.DevicesOptionsWidget.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.tvFiles = new global::Gtk.TreeView ();
			this.tvFiles.CanFocus = true;
			this.tvFiles.Name = "tvFiles";
			this.GtkScrolledWindow.Add (this.tvFiles);
			this.hbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.GtkScrolledWindow]));
			w2.Position = 0;
			w2.Padding = ((uint)(5));
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbuttonbox1 = new global::Gtk.VButtonBox ();
			this.vbuttonbox1.Name = "vbuttonbox1";
			this.vbuttonbox1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
			// Container child vbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.btnAdd = new global::Gtk.Button ();
			this.btnAdd.CanFocus = true;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.UseUnderline = true;
			this.btnAdd.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.vbuttonbox1.Add (this.btnAdd);
			global::Gtk.ButtonBox.ButtonBoxChild w3 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox1 [this.btnAdd]));
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.btnRemove = new global::Gtk.Button ();
			this.btnRemove.CanFocus = true;
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.UseUnderline = true;
			this.btnRemove.Label = global::Mono.Unix.Catalog.GetString ("Remove");
			this.vbuttonbox1.Add (this.btnRemove);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox1 [this.btnRemove]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.hbox1.Add (this.vbuttonbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbuttonbox1]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			w5.Padding = ((uint)(5));
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w6.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.BorderWidth = ((uint)(1));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.cbResolution = global::Gtk.ComboBox.NewText ();
			this.cbResolution.Name = "cbResolution";
			this.table1.Add (this.cbResolution);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.cbResolution]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Width :");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Height :");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Resolution :");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.sbHeight = new global::Gtk.SpinButton (0D, 2000D, 50D);
			this.sbHeight.WidthRequest = 110;
			this.sbHeight.Sensitive = false;
			this.sbHeight.CanFocus = true;
			this.sbHeight.Name = "sbHeight";
			this.sbHeight.Adjustment.PageIncrement = 100D;
			this.sbHeight.ClimbRate = 1D;
			this.sbHeight.Numeric = true;
			this.table1.Add (this.sbHeight);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.sbHeight]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.sbWidth = new global::Gtk.SpinButton (0D, 2000D, 50D);
			this.sbWidth.WidthRequest = 110;
			this.sbWidth.Sensitive = false;
			this.sbWidth.CanFocus = true;
			this.sbWidth.Name = "sbWidth";
			this.sbWidth.Adjustment.PageIncrement = 100D;
			this.sbWidth.ClimbRate = 1D;
			this.sbWidth.Numeric = true;
			this.table1.Add (this.sbWidth);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.sbWidth]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment.Add (this.table1);
			this.frame1.Add (this.GtkAlignment);
			this.GtkLabel3 = new global::Gtk.Label ();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Display</b>");
			this.GtkLabel3.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel3;
			this.vbox2.Add (this.frame1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frame1]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			w15.Padding = ((uint)(5));
			// Container child vbox2.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(3)), ((uint)(1)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.BorderWidth = ((uint)(1));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.table2 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.entAuthor = new global::Gtk.Entry ();
			this.entAuthor.CanFocus = true;
			this.entAuthor.Name = "entAuthor";
			this.entAuthor.IsEditable = true;
			this.entAuthor.InvisibleChar = '●';
			this.table2.Add (this.entAuthor);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2 [this.entAuthor]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entTitle = new global::Gtk.Entry ();
			this.entTitle.CanFocus = true;
			this.entTitle.Name = "entTitle";
			this.entTitle.IsEditable = true;
			this.entTitle.InvisibleChar = '●';
			this.table2.Add (this.entTitle);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2 [this.entTitle]));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entUrl = new global::Gtk.Entry ();
			this.entUrl.CanFocus = true;
			this.entUrl.Name = "entUrl";
			this.entUrl.IsEditable = true;
			this.entUrl.InvisibleChar = '●';
			this.table2.Add (this.entUrl);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2 [this.entUrl]));
			w18.TopAttach = ((uint)(2));
			w18.BottomAttach = ((uint)(3));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Title :");
			this.table2.Add (this.label4);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table2 [this.label4]));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Author :");
			this.table2.Add (this.label5);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table2 [this.label5]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("URL :");
			this.table2.Add (this.label6);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2 [this.label6]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment1.Add (this.table2);
			this.frame2.Add (this.GtkAlignment1);
			this.GtkLabel4 = new global::Gtk.Label ();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Info</b>");
			this.GtkLabel4.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel4;
			this.table3.Add (this.frame2);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table3 [this.frame2]));
			w24.TopAttach = ((uint)(1));
			w24.BottomAttach = ((uint)(2));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.frame3 = new global::Gtk.Frame ();
			this.frame3.Name = "frame3";
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.chbTablet = new global::Gtk.CheckButton ();
			this.chbTablet.CanFocus = true;
			this.chbTablet.Name = "chbTablet";
			this.chbTablet.Label = global::Mono.Unix.Catalog.GetString ("Tablet");
			this.chbTablet.DrawIndicator = true;
			this.chbTablet.UseUnderline = true;
			this.GtkAlignment2.Add (this.chbTablet);
			this.frame3.Add (this.GtkAlignment2);
			this.GtkLabel5 = new global::Gtk.Label ();
			this.GtkLabel5.Name = "GtkLabel5";
			this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Device</b>");
			this.GtkLabel5.UseMarkup = true;
			this.frame3.LabelWidget = this.GtkLabel5;
			this.table3.Add (this.frame3);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table3 [this.frame3]));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.hbuttonbox2 = new global::Gtk.HButtonBox ();
			this.hbuttonbox2.Name = "hbuttonbox2";
			this.hbuttonbox2.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.button1268 = new global::Gtk.Button ();
			this.button1268.CanFocus = true;
			this.button1268.Name = "button1268";
			this.button1268.UseUnderline = true;
			this.button1268.Label = global::Mono.Unix.Catalog.GetString ("Save");
			this.hbuttonbox2.Add (this.button1268);
			global::Gtk.ButtonBox.ButtonBoxChild w28 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.button1268]));
			w28.Expand = false;
			w28.Fill = false;
			this.table3.Add (this.hbuttonbox2);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table3 [this.hbuttonbox2]));
			w29.TopAttach = ((uint)(2));
			w29.BottomAttach = ((uint)(3));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add (this.table3);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.table3]));
			w30.Position = 2;
			w30.Expand = false;
			w30.Fill = false;
			w30.Padding = ((uint)(5));
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.btnAdd.Clicked += new global::System.EventHandler (this.OnBtnAddClicked);
			this.btnRemove.Clicked += new global::System.EventHandler (this.OnBtnRemoveClicked);
			this.cbResolution.Changed += new global::System.EventHandler (this.OnCbResolutionChanged);
			this.button1268.Clicked += new global::System.EventHandler (this.OnBtnSaveClicked);
			this.chbTablet.Toggled += new global::System.EventHandler (this.OnChbTabletToggled);
			this.entUrl.Changed += new global::System.EventHandler (this.OnEntUrlChanged);
			this.entTitle.Changed += new global::System.EventHandler (this.OnEntTitleChanged);
			this.entAuthor.Changed += new global::System.EventHandler (this.OnEntAuthorChanged);
		}
	}
}
