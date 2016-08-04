using NUnit.Framework;
using Xamarin.UITest;
using Automated;

namespace NUnit.Tests{

	[SetUpFixture]
	public class TestSetup{

		[SetUp]
		public void SetUp(){
			string device = "Android";
			//			string device = "iOS";

			if (device == "iOS"){
				BaseScreen.App = ConfigureApp
					.iOS
					.AppBundle("iOSAppRoute")
					.DeviceIdentifier("DeviceId")
					.StartApp();
			}
			else if (device == "Android"){
				BaseScreen.App = ConfigureApp
					.Android
					.ApkFile("/Users/aarias/Desktop/task-todo.apk")
					.DeviceSerial("192.168.58.101:5555")
					.StartApp();
			}
		}
	}
}
