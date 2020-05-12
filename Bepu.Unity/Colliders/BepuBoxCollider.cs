using BepuUnity.Shared.Abstraction;
using UnityEngine;

namespace Bepu.Unity.Colliders
{
	public class BepuBoxCollider : MonoBehaviour, IBepuCollider
	{
		public Vector3 size;
		public Vector3 center;
	}
}
