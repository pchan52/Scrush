using UnityEngine;
using Damages;
using Players;

namespace Attacks.Bullets {
	public class NormalBullet : BaseBullet
	{
		[SerializeField] float _damagePoint;

		Damage GiveDamage ()
		{
			return new Damage()
			{
				Attacker = this.Attacker,
				Value = _damagePoint
			};
		}

		// 引数playerStatusを渡すと味方だとtrue、敵だとfalseを返す
		private bool IsFriend(PlayerStatus playerStatus)
		{
			return this.Attacker.PlayerStatus == playerStatus;
		}


		private void OnTriggerEnter(Collider other)
		{
			// もし当たった先がDamageApplicableのInterfaceを継承していれば
			var damageApplicable = other.gameObject.GetComponent<IDamageApplicable>();
            if (damageApplicable != null)
			{
				// もしそれがPlayerなら
				var player = other.gameObject.GetComponent<Player>();
				if (player != null)
				{
					// もしそれが敵なら
					if (IsFriend(player.PlayerStatus) == false)
					{
						// Damageを与える
						damageApplicable.ApplyDamage(GiveDamage());
						EffectManager.instance.Damaged(player);
					}
				}
				Object.Destroy(gameObject);
			}
		}
	}
}
