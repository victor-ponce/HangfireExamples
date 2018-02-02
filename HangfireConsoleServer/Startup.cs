﻿using Hangfire;
using Owin;

namespace HangfireConsoleServer
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			// Map Dashboard to the `http://<your-app>/hangfire` URL.
			app.UseHangfireDashboard();
		}
	}
}
