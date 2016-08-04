using NUnit.Framework;
using Automated.Assertions;
using Screens;

namespace NUnit.Tests{

	[TestFixture]
	public class LoginTest{
		private readonly NewScreen _landing = new NewScreen();
		private readonly MenuScreen _menu = new MenuScreen();

		[TestFixtureSetUp]
		public void BeforeEach(){
			_landing.TapButtonOk();
		}

		[Test]
		public void NormalLogin(){
			_menu.TapHomeButton();

			Asserts.HasThisText ("No Tasks");

		}
	}
}