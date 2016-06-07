using UnityEngine;
using System.Collections;

public class AsteroidVelocity : MonoBehaviour {

	Rigidbody body;
	public int side;
	public GameObject[] particle;
	public AudioClip[] impact;
	public GameObject player;
	AudioSource audio;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		audio = player.GetComponent<AudioSource> ();
		audio.enabled = true;
		body = GetComponent<Rigidbody> ();
		body.velocity = new Vector3 (-10*side, 0, 0);
	}

	void OnTriggerExit(Collider coll){
		if (coll.gameObject.tag == "MapEnd") {
			Destroy (this.gameObject);
		}
		
	}

	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag == "Planet") {
			Instantiate (particle[Random.Range(0,particle.Length)], transform.position, transform.rotation);
			player.gameObject.SendMessage ("AddScore");
			audio.PlayOneShot (impact[Random.Range(0,impact.Length)]);
			Destroy (coll.gameObject);
			Destroy (this.gameObject);
		}
		if (coll.gameObject.tag == "Asteroid") {
			Instantiate (particle[Random.Range(0,particle.Length)], transform.position, transform.rotation);
			audio.PlayOneShot (impact[Random.Range(0,impact.Length)]);
			Destroy (coll.gameObject);
			Destroy (this.gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
