namespace Players
{
	public enum PlayerStatus
    {
		Hero,
		Villain
    }
	public class PlayerParameters {
		private float _hp;
		public float Hp { get; set; }

		public PlayerParameters (float maxHp)
		{
			_hp = maxHp;
		}

	}
}
