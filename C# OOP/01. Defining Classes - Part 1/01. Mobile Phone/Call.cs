﻿using System;

public class Call
{
	public Call(DateTime time, string number, int duration, decimal pricePerMinute)
	{
		Time = time;
		Number = number;
		Duration = duration;
		Cost = (duration / 60 + 1) * pricePerMinute;
	}

	public DateTime Time { get; set; }
	public string Number { get; set; }
	public int Duration { get; set; }
	public decimal Cost { get; set; }

	public override string ToString()
	{
		return string.Format("Time: {0} Number: {1} Duration: {2}s Cost: {3:F2} BGN", Time, Number, Duration, Cost);
	}
}