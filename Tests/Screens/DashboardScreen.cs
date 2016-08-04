namespace Screens{
	public class DashboardScreen : Automated.BaseScreen{
		public TaskScreen TapNewTaskButton(){
			base.TapElementById("fa");
			return new TaskScreen();
		}
	}
}

