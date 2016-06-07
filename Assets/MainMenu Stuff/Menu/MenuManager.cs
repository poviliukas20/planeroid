using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour{

	public Texture active;
	public Texture inActive;

	public void SetGazedAt(bool gazedAt) {
		//what.gameObject.GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
		GetComponent<Renderer> ().material.mainTexture = gazedAt ? active : inActive;
	}

	void LateUpdate() {
		GvrViewer.Instance.UpdateState();
		if (GvrViewer.Instance.BackButtonPressed) {
			Application.Quit();
		}
	}

}
