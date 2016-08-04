using Xamarin.UITest;

namespace Automated{
	
	abstract public class BaseScreen{
		private static IApp app;

		public static IApp App{
			set {
				app = value;
			}

			get {
				return app;
			}
		}

		protected BaseScreen(){
			System.Threading.Thread.Sleep(1500);
		}

		public void Repl(){
			app.Repl();
		}

		protected void TapElementById(string id){
			app.Tap(e => e.Id(id));
		}

		protected void TapElementById(string id, string text){
			app.Tap(e => e.Id(id).Text(text));
		}

		protected void TypeText(string input){
			app.EnterText(input);
		}

		protected void FillInputById(string id, string input){
			this.TapElementById(id);
			this.TypeText(input);
			app.DismissKeyboard();
		}
	}
}