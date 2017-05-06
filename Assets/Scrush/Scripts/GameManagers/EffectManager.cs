using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Players;

public class EffectManager : MonoBehaviour {
    [SerializeField] Canvas DamagedEffect;
    public static EffectManager instance;

    void Start ()
    {
        if (instance == null)
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void Damaged (Player player)
    {
        Canvas effect = Instantiate(DamagedEffect);
        Invoke("Destroy()", 3.5f);
    }
}
