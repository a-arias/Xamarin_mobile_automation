namespace Screens{
	public class TaskScreen : Automated.BaseScreen{
		public TaskScreen FillTaskToDo(string task = "wash dishes"){
			base.FillInputById("task", task);

			return this;
		}

		public TaskScreen FillNotes(string notes = "You really need to do this"){
			base.FillInputById("notes", notes);

			return this;
		}

		public DashboardScreen TapCancelButton(){
			base.TapElementById("menu_cancel");
			return new DashboardScreen();
		}

		public DashboardScreen TapAcceptButton(){
			base.TapElementById("menu_accept");
			return new DashboardScreen();
		}

		public TaskScreen TapBellButton(){
			base.TapElementById("fab");
			return this;
		}

		public TaskScreen TapReminderButton(){
			base.TapElementById("reminder");
			return this;
		}
	}
}

