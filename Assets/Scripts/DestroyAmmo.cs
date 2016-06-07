using UnityEngine;
using System.Collections;

public class DestroyAmmo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerExit(Collider coll){
		if (coll.gameObject.tag == "MapEnd") {
			Destroy (this.gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
