
// This file has been generated by the GUI designer. Do not modify.
namespace Moscrif.IDE.Controls.Wizard
{
	public partial class PublishDialogWizzard
	{
		private global::Gtk.Notebook notebook1;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Label label1;
		private global::Gtk.VBox vbox3;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.NodeView nvOutput;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.Button btnCancel;
		private global::Gtk.Button btnResetMatrix;
		private global::Gtk.Button btnNext;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Moscrif.IDE.Controls.Wizard.PublishDialogWizzard
			this.Name = "Moscrif.IDE.Controls.Wizard.PublishDialogWizzard";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child Moscrif.IDE.Controls.Wizard.PublishDialogWizzard.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			this.notebook1.BorderWidth = ((uint)(10));
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.notebook1.Add (this.vbox2);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("page1");
			this.notebook1.SetTabLabel (this.vbox2, this.label1);
			this.label1.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.nvOutput = new global::Gtk.NodeView ();
			this.nvOutput.CanFocus = true;
			this.nvOutput.Name = "nvOutput";
			this.GtkScrolledWindow.Add (this.nvOutput);
			this.vbox3.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow]));
			w4.Position = 0;
			this.notebook1.Add (this.vbox3);
			global::Gtk.Notebook.NotebookChild w5 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox3]));
			w5.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("page2");
			this.notebook1.SetTabLabel (this.vbox3, this.label2);
			this.label2.ShowAll ();
			// Notebook tab
			global::Gtk.Label w6 = new global::Gtk.Label ();
			w6.Visible = true;
			this.notebook1.Add (w6);
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("page3");
			this.notebook1.SetTabLabel (w6, this.label3);
			this.label3.ShowAll ();
			w1.Add (this.notebook1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(w1 [this.notebook1]));
			w7.Position = 0;
			// Internal child Moscrif.IDE.Controls.Wizard.PublishDialogWizzard.ActionArea
			global::Gtk.HButtonBox w8 = this.ActionArea;
			w8.Name = "dialog1_ActionArea";
			w8.Spacing = 10;
			w8.BorderWidth = ((uint)(10));
			w8.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.btnCancel = new global::Gtk.Button ();
			this.btnCancel.CanDefault = true;
			this.btnCancel.CanFocus = true;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.UseUnderline = true;
			this.btnCancel.Label = global::Mono.Unix.Catalog.GetString ("_Cancel");
			w8.Add (this.btnCancel);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w8 [this.btnCancel]));
			w9.Expand = false;
			w9.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.btnResetMatrix = new global::Gtk.Button ();
			this.btnResetMatrix.CanFocus = true;
			this.btnResetMatrix.Name = "btnResetMatrix";
			this.btnResetMatrix.UseUnderline = true;
			this.btnResetMatrix.Label = global::Mono.Unix.Catalog.GetString ("_Reset Matrix");
			w8.Add (this.btnResetMatrix);
			global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w8 [this.btnResetMatrix]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.btnNext = new global::Gtk.Button ();
			this.btnNext.CanFocus = true;
			this.btnNext.Name = "btnNext";
			this.btnNext.UseUnderline = true;
			this.btnNext.Label = global::Mono.Unix.Catalog.GetString ("_Next");
			w8.Add (this.btnNext);
			global::Gtk.ButtonBox.ButtonBoxChild w11 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w8 [this.btnNext]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 738;
			this.DefaultHeight = 482;
			this.Show ();
			this.btnCancel.Clicked += new global::System.EventHandler (this.OnBtnCancelClicked);
			this.btnResetMatrix.Clicked += new global::System.EventHandler (this.OnBtnResetMatrixClicked);
			this.btnNext.Clicked += new global::System.EventHandler (this.OnBtnNextClicked);
		}
	}
}
