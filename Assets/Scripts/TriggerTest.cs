using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class TriggerTest : MonoBehaviour {

	public GameObject[] go;
	public float timer;
	public int sec;
	public GameObject restart;
	public Text secTxt;
	public Text secTxt2;
	public int score;

	// Use this for initialization
	void Start () {
		timer = 1;
	}

	// Update is called once per frame
	void Update () {

		if (timer <= 0) {
			sec--;
			timer = 1;
		} else {
			timer -= Time.deltaTime;
		}

		if (sec <= 0) {
			secTxt.text = "Score: " + score; 
			secTxt2.text = "Score: " + score; 
			Time.timeScale = 0f;
			restart.SetActive (true);
		} else {
			secTxt.text = "Time left: " + sec; 
			secTxt2.text = "Time left: " + sec; 
		}

		if (GvrViewer.Instance.Triggered) { 
			if (sec > 0) {
				//Debug.Log("Tap detected");
				GameObject ins = Instantiate (go [Random.Range (0, go.Length)]) as GameObject;
				ins.transform.position = transform.position + Camera.main.transform.forward * 2;
				Rigidbody rb = ins.GetComponent<Rigidbody> ();
				rb.velocity = Camera.main.transform.forward * 40;
			}
		}
	}

	public void AddScore(){
		score++;
	}

	public void Restart(){
		Time.timeScale = 1f;
		restart.SetActive (false);
		sec = 60;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);

		Social.ReportScore(score, "CgkI3a_KxL8PEAIQBg", (bool success) => {
			// handle success or failure
		});

	}
}
