using System;
using Gtk;
using Gdk;


namespace Moscrif.IDE.Components
{
	public delegate void TabsReorderedHandler (Widget widget, int oldPlacement, int newPlacement);

	public class DragNotebook  : Notebook
    	{
		public DragNotebook () {
			ButtonPressEvent += new ButtonPressEventHandler (OnButtonPress);
			ButtonReleaseEvent += new ButtonReleaseEventHandler (OnButtonRelease);
			ChangeCurrentPage += new ChangeCurrentPageHandler(OnPageChanged);

			AddEvents ((Int32) (EventMask.AllEventsMask));
		}
		
		Cursor fleurCursor = new Cursor (CursorType.Fleur);

		public event TabsReorderedHandler TabsReordered;

		bool DragInProgress;

		public int FindTabAtPosition (double cursorX, double cursorY) {

			int    dragNotebookXRoot;
			int    dragNotebookYRoot;
			Widget page              = GetNthPage (0);
			int    pageNumber        = 0;
			Widget tab;
			int    tabMaxX;
			int    tabMaxY;
			int    tabMinX;
			int    tabMinY;

			ParentWindow.GetOrigin (out dragNotebookXRoot, out dragNotebookYRoot);

			while (page != null) {

				if ((tab = GetTabLabel (page)) == null)
					return -1;

				tabMinX = dragNotebookXRoot + tab.Allocation.X;
				tabMaxX = tabMinX + tab.Allocation.Width;

				tabMinY = dragNotebookYRoot + tab.Allocation.Y;
				tabMaxY = tabMinY + tab.Allocation.Height;

				if ((tabMinX <= cursorX) && (cursorX <= tabMaxX) &&
					(tabMinY <= cursorY) && (cursorY <= tabMaxY))
					return pageNumber;

				page = GetNthPage (++pageNumber);
			}

			return -1;
		}

		void MoveTab (int destinationPage)
		{
			if (destinationPage >= 0 && destinationPage != CurrentPage) {
				int oldPage = CurrentPage;
				ReorderChild (CurrentPageWidget, destinationPage);

				if (TabsReordered != null)
					TabsReordered (CurrentPageWidget, oldPage, destinationPage);
			}
		}

		[GLib.ConnectBefore]
		void OnButtonPress (object obj, ButtonPressEventArgs args) {

			if (DragInProgress)
				return;

			if (args.Event.Button == 1 && args.Event.Type == EventType.ButtonPress && FindTabAtPosition (args.Event.XRoot, args.Event.YRoot) >= 0)
				MotionNotifyEvent += new MotionNotifyEventHandler (OnMotionNotify);
		}
		
		public void LeaveDragMode (uint time)
		{
			if (DragInProgress) {
				Pointer.Ungrab (time);
				Grab.Remove (this);
			}
			MotionNotifyEvent -= new MotionNotifyEventHandler (OnMotionNotify);
			DragInProgress = false;
		}
		
		[GLib.ConnectBefore]
		void OnButtonRelease (object obj, ButtonReleaseEventArgs args) {
			LeaveDragMode (args.Event.Time);
		}

		[GLib.ConnectBefore]
		void OnMotionNotify (object obj, MotionNotifyEventArgs args) {

			if (!DragInProgress) {
				DragInProgress = true;
				Grab.Add (this);

				if (!Pointer.IsGrabbed)
					Pointer.Grab (ParentWindow, false, EventMask.Button1MotionMask | EventMask.ButtonReleaseMask, null, fleurCursor, args.Event.Time);	
			}

			MoveTab (FindTabAtPosition (args.Event.XRoot, args.Event.YRoot));
		}


		//[GLib.ConnectBefore()] //ConnectBefore]
		void OnPageChanged(object o, ChangeCurrentPageArgs args) {
		}

	/*	protected override void  OnChangeCurrentPage(int offset){
			Console.WriteLine(1);
			base.OnChangeCurrentPage(offset);

		}*/

		protected override void OnDestroyed ()
		{
			if (fleurCursor != null) {
				fleurCursor.Dispose ();
				fleurCursor = null;
			}
			base.OnDestroyed ();
		}
	}
}

