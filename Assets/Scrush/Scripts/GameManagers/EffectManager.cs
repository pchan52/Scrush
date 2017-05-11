using UnityEngine;
using UniRx;
using System;
using System.Collections;
using Players;

public class EffectManager : MonoBehaviour {
    [SerializeField] GameObject DamagedEffect;
    [SerializeField] GameObject DeadEffect;

    public static EffectManager instance;

    void Start ()
    {
        // シングルトン化
        if (instance == null)
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        Dead(new Player());
    }

    // playerがダメージをくらった時のエフェクト
    public void Damaged (Player player)
    {
        DamagedEffect.SetActive(true);
        Observable.Timer (TimeSpan.FromSeconds(0.5f)).Subscribe (_ => {
            DamagedEffect.SetActive(false);
        });
    }

    // playerが死んだ時のエフェクト
    public void Dead (Player player)
    {
        DeadEffect.SetActive(true);
        Observable.Timer (TimeSpan.FromSeconds(1f)).Subscribe (_ => {
            DeadEffect.SetActive(false);
        });
    }
}
