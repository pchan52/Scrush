using UnityEngine;

namespace GameManagers{
	public class PlayerSpawner : MonoBehaviour {
		[SerializeField] private float minX;
		[SerializeField] private float maxX;
		[SerializeField] private float minY;
		[SerializeField] private float maxY;
		public static PlayerSpawner instance;

		void Start ()
		{
			if (instance == null)
			{
				instance = this;
			}
			DontDestroyOnLoad(this.gameObject);
		}

		// playerをrespawnさせる
		public void Respawn (GameObject player)
		{
			// player.transform.position = anywhere;
		}

		// respawnするランダムな場所を決める
		private void SetRandomPosition ()
		{

		}
	}
}
