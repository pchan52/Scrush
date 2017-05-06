using UnityEngine;

namespace Attacks {
	public abstract class BaseBullet : MonoBehaviour
	{
		public PlayerAttacker Attacker { get; set; }
        protected float DamagePoint { get; set; }
	}
}
