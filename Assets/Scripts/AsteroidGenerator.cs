using UnityEngine;
using System.Collections;

public class AsteroidGenerator : MonoBehaviour {

	public float nextActionTime;
	public float period;
	public float timer;
	public GameObject[] asteroids;
	// Use this for initialization
	void Start () {	
		nextActionTime = Random.Range(1f, 1.5f);

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer += Time.deltaTime;
		if (timer >= nextActionTime ) {
			//timer = Random.Range(10f, 20f);
			//nextActionTime += period;

			//Debug.Log (asteroids.Length);	
			int next = Random.Range (0, asteroids.Length);
			Instantiate (asteroids[next], new Vector3 (
				transform.position.x,
				transform.position.y+Random.Range(-5f,5f),
				transform.position.z+Random.Range(-5f,5f)), transform.rotation);
			timer = 0f;
			nextActionTime = Random.Range(0.5f, 1.5f);

		}
	}
}
