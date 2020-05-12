using System.Collections.Generic;
using UnityEngine;
using BepuUnity.Shared.Abstraction;

namespace BepuUnity.Bodies
{
	public class BepuRigidBody : MonoBehaviour, IBepuRigidBody
	{
		public List<IBepuConstraint> Constraints => throw new System.NotImplementedException();
	}
}