namespace Player
{
	public class PlayerParameters {
		private float _hp;
		private float _maxHp = 100f;

		public float Hp { get; set; }
		public float MaxHp { get; }

		public PlayerParameters ()
		{
			_hp = _maxHp;
		}

	}
}
