﻿using System;
using System.Diagnostics;

namespace Utilities
{
	public class StopwatchWrapper
	{
		public double total_time;
		public double calls;
		private Stopwatch sw;

		public StopwatchWrapper()
		{
			sw = new Stopwatch();
		}

		void reset()
		{
			total_time = 0;
			calls = 0;
			sw.Reset();
		}

		void start()
		{
			sw.Start();
			calls++;
		}

		void stop()
		{
			sw.Stop();
			total_time += (double)sw.Elapsed.TotalMilliseconds;
			sw.Reset();
		}

		double latency()
		{
			return total_time;
		}

		double avg_latency()
		{
			return (total_time / calls);
		}
	}
}
