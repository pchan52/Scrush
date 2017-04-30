using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lighting : MonoBehaviour {

	public bool lighting;
	private Light[] lights;
	private ReflectionProbe[] probes;
	private Transform[] childObj;
	private Renderer[] rend;

	void Awake() {
		lights = this.GetComponentsInChildren<Light> ();
		probes = this.GetComponentsInChildren<ReflectionProbe> ();
		rend = this.GetComponentsInChildren<Renderer> ();
	}

	// Use this for initialization
	void Start () {
		lighting = false;
	}

	// Update is called once per frame
	void Update () {
		if (lighting == true) {
			foreach (Light l in lights) {
				l.enabled = true;
			}
			foreach (ReflectionProbe r in probes) {
				r.intensity = 1;
			}
			foreach (Renderer r in rend) {
				foreach (Material m in r.materials) {
					if (m.name == "Bulb (Instance)") {
						m.globalIlluminationFlags = UnityEngine.MaterialGlobalIlluminationFlags.RealtimeEmissive;
						m.SetColor("_EmissionColor", UnityEngine.Color.white);
					}
				}
			}
		} else {
			foreach (Light l in lights) {
				l.enabled = false;
			}
			foreach (ReflectionProbe r in probes) {
				r.intensity = 0;
			}
			foreach (Renderer r in rend) {
				foreach (Material m in r.materials) {
					if (m.name == "Bulb (Instance)") {
						m.globalIlluminationFlags = UnityEngine.MaterialGlobalIlluminationFlags.None;
						m.SetColor("_EmissionColor", UnityEngine.Color.black);
					}
				}
			}
		}
	}

}
