using NUnit.Framework;

namespace Automated.Assertions{
	public static class Asserts{
		
		public static void HasThisText(string text){
			Assert.IsNotNull(BaseScreen.App.WaitForElement(e => e.Marked(text), "TEST FAILED! Could not find text: " + text));
		}
	}
}

