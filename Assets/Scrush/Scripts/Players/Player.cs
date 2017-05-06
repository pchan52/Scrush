using UnityEngine;
using GameManagers;
using Damages;

namespace Players {
	public class Player : MonoBehaviour, IDamageApplicable, IDieable
	{
		[SerializeField] private float _maxHp;
		private PlayerStatus _playerStatus;
		private PlayerParameters _playerParameters;

		public PlayerStatus PlayerStatus
		{
			get { return _playerStatus; }
		}

		void Start ()
		{
			_playerParameters = new PlayerParameters(_maxHp);
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
			EffectManager.instance.Dead(this);
			_playerParameters.Hp = _maxHp;
			PlayerSpawner.instance.Respawn(gameObject);
		}
	}
}
