// DeclarationViewWindow.cs
//
// Author:
//   Mike Krüger <mkrueger@novell.com>
//
// Copyright (c) 2009 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using Gtk;
//using MonoDevelop.Components;
using System.Collections.Generic;
//using MonoDevelop.Core;
using Moscrif.IDE.Components;

namespace Moscrif.IDE.Completion
{
	internal class DeclarationViewWindow : TooltipWindow
	{
		static char[] newline = {'\n'};
		
		List<string> overloads = new List<string> ();
		int current_overload;
		
		public int CurrentOverload {
			get {
				return this.current_overload; 
			}
			set {
				this.current_overload = value;
				ShowOverload ();
			}
		}
		
		FixedWidthWrapLabel headlabel, bodylabel;
		Label helplabel;
		Arrow left, right;
		VBox helpbox;
		
		public string DescriptionMarkup {
			get {
			 	if (string.IsNullOrEmpty (bodylabel.Text))
					return headlabel.Text;
				return headlabel.Text + "\n" + bodylabel.Text;
			}
			set {
				if (string.IsNullOrEmpty (value)) {
					headlabel.Markup = bodylabel.Markup = "";
					headlabel.Visible = bodylabel.Visible = false;
					return;
				}
				string[] parts = value.Split (newline, 2);
				headlabel.Markup = "<b>" + parts[0].Trim () + "</b>";
				bodylabel.Markup = parts.Length == 2 && !string.IsNullOrEmpty (parts[1].Trim ())? "<span size=\"smaller\">" + parts[1].Trim () + "</span>" : "";
				headlabel.Visible = !string.IsNullOrEmpty (parts[0].Trim ());
				bodylabel.Visible = parts.Length == 2 ;
			}
		}

		public bool Multiple{
			get {
				return left.Visible;
			}
			set {
				left.Visible = right.Visible = helpbox.Visible = value;
				
				//this could go somewhere better, as long as it's after realization
				headlabel.Visible = !string.IsNullOrEmpty (headlabel.Text);
				bodylabel.Visible = !string.IsNullOrEmpty (bodylabel.Text);
			}
		}

		public void AddOverload (string desc)
		{
			overloads.Add (desc);
			if (overloads.Count == 2)
				Multiple = overloads.Count > 1;
			ShowOverload ();
		}

		void ShowOverload ()
		{
			if (current_overload >= 0 && current_overload < overloads.Count) {
				DescriptionMarkup = overloads[current_overload];
				helplabel.Markup = string.Format ("<small>" + "{0} of {1} overloads" + "</small>", current_overload + 1, overloads.Count);
			}
		}

		public void OverloadLeft ()
		{
			if (current_overload == 0) {
				if (overloads.Count > 0)
					current_overload = overloads.Count - 1;
			} else {
				current_overload--;
			}
			ShowOverload ();
		}

		public void OverloadRight ()
		{
			if (current_overload == overloads.Count - 1) {
				current_overload = 0;
			} else {
				if (overloads.Count > 0)
					current_overload++;
			}
			ShowOverload ();
		}

		public void Clear ()
		{
			overloads.Clear ();
			Multiple = false;
			DescriptionMarkup = String.Empty;
			current_overload = 0;
		}
		
		public void SetFixedWidth (int w)
		{
			if (w != -1) {
				w -= SizeRequest ().Width - headlabel.SizeRequest ().Width;
				headlabel.MaxWidth = w > 0 ? w : 1;
			} else {
				headlabel.MaxWidth = -1;
			}
			bodylabel.MaxWidth = headlabel.RealWidth > 350 ? headlabel.RealWidth : 350;
			QueueResize ();
		}

		public DeclarationViewWindow () : base ()
		{
			this.AllowShrink = false;
			this.AllowGrow = false;
			
			EnableTransparencyControl = true;
			
			headlabel = new FixedWidthWrapLabel ();
			headlabel.Indent = -20;
			headlabel.Wrap = Pango.WrapMode.WordChar;
			headlabel.BreakOnCamelCasing = true;
			headlabel.BreakOnPunctuation = true;
			
			bodylabel = new FixedWidthWrapLabel ();
			bodylabel.Wrap = Pango.WrapMode.WordChar;
			bodylabel.BreakOnCamelCasing = true;
			bodylabel.BreakOnPunctuation = true;
			
			VBox vb = new VBox (false, 0);
			vb.PackStart (headlabel, true, true, 0);
			vb.PackStart (bodylabel, true, true, 3);

			left = new Arrow (ArrowType.Left, ShadowType.None);
			right = new Arrow (ArrowType.Right, ShadowType.None);

			HBox hb = new HBox (false, 0);
			hb.Spacing = 4;
			hb.PackStart (left, false, true, 0);
			hb.PackStart (vb, true, true, 0);
			hb.PackStart (right, false, true, 0);

			helplabel = new Label (string.Empty);
			helplabel.Xalign = 1;
			
			helpbox = new VBox (false, 0);
			helpbox.PackStart (new HSeparator (), false, true, 0);
			helpbox.PackStart (helplabel, false, true, 0);
			helpbox.BorderWidth = 2;
			
			VBox vb2 = new VBox (false, 0);
			vb2.Spacing = 4;
			vb2.PackStart (hb, true, true, 0);
			vb2.PackStart (helpbox, false, true, 0);
			
			this.Add (vb2);
			
			ShowAll ();
		}
	}
}
