using UnityEngine;
using System.ComponentModel;
using BepuUnity.Shared.Abstraction;

namespace BepuUnity.Constraints.Configuration
{
	public class SpringSettings : ISpringSettings
	{
		public float Frequency { get; }
		public float DampingRation { get; }

		public SpringSettings(
			[System.ComponentModel.DataAnnotations.Range(1.0f, 99.0f)] int frequency,
			[System.ComponentModel.DataAnnotations.Range(0.0f, 1.0f)] float dampingRation)
		{
			Frequency = frequency;
			DampingRation = dampingRation;
		}

	}
}
