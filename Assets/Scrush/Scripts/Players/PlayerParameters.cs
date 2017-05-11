namespace Players
{
	public enum PlayerStatus
    {
		Hero,
		Villain
    }
	public class PlayerParameters {
		private float _hp;
		private int _specialAttackItemNum;
		public float Hp { get; set; }
		public int SpecialAttackItemNum { get; set; }

		public PlayerParameters (float maxHp)
		{
			_hp = maxHp;
			_specialAttackItemNum = 0;
		}
	}
}
