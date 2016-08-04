using System;
using System.IO;
using System.Linq;
using System.Configuration;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;

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
					.DeviceSerial("emulator-5554")
					.StartApp();
			}
		}
	}
}
