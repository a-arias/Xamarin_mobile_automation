namespace Screens {
	public class NewScreen : Automated.BaseScreen {
		public DashboardScreen TapButtonOk(){
			base.TapElementById("buttonDefaultPositive");
			return new DashboardScreen();
		}
	}
}

