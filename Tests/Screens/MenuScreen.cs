namespace Screens{
	public class MenuScreen : Automated.BaseScreen{
		public DashboardScreen TapHomeButton(){
			base.TapElementById("listName","Home");
			return new DashboardScreen();
		}
	}
}

