using UnityEngine;

namespace Player {
	public class Player : MonoBehaviour, IDamageable, IDieable
	{
		private PlayerParameters _playerParameters;
		void Start ()
		{
			_playerParameters = new PlayerParameters();
		}

		void Update ()
		{
			if (_playerParameters.Hp < 0)
			{
				Die ();
			}
		}

		public void ApplyDamage (Damage damage)
		{
			_playerParameters.Hp -= damage.Value;
		}
		public void Die ()
		{
			_playerParameters.Hp = _playerParameters.MaxHp;
			// transform.position =
		}
	}
}
