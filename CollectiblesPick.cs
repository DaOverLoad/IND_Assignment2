using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiblesPick : MonoBehaviour {

    private AudioSource source;
	[SerializeField] private AudioClip collectSound;

	void OnTriggerEnter (Collider col) {
		Debug.Log ("You've collected: " + gameObject.name);
		source = col.GetComponent<AudioSource> ();
		source.PlayOneShot (collectSound, 1f);
		Destroy (gameObject);
	}
}
