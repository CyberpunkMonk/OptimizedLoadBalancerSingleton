using System;
using System.Collections.Generic;

namespace OptimizedLoadBalancer {
	/// <summary>
	/// Application entry point
	/// </summary>
	class MainApp {
		/// <summary>
		/// Defines the entry point of the application.
		/// </summary>
		static void Main() {
			LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
			LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
			LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
			LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

			//Confirm these are the same instance
			if (b1 == b2 && b2 == b3 && b3 == b4) {
				Console.WriteLine("Same Instance\n");
			}

			//Next, load balance 15 requests for a server.
			LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
			for (int i = 0; i < 15; i++) {
				string serverName = balancer.NextServer.Name;
				Console.WriteLine("Dispatch request to: " + serverName);
			}
			//wait for user
			Console.ReadKey();
		}
	}
}
