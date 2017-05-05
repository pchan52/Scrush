using UnityEngine;

namespace Player {
	public class Player : MonoBehaviour, IDamageable, IDieable
	{
		private PlayerParameters _playerParameters;
		void Start ()
		{
			_playerParameters = new PlayerParameters();
		}

		public void ApplyDamage (Damage damage)
		{
			_playerParameters.Hp -= damage.Value;
		}
		public void Die ()
		{

		}
	}
}
