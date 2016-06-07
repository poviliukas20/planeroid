using UnityEngine;
using System.Collections;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayGamesPlatform.Activate ();
		Social.localUser.Authenticate ((bool success) => {

		});
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Play(string scene){
		SceneManager.LoadScene(scene);
	}

	public void Fight(){

	}

	public void Quit(){
		Application.Quit();
	}

	public void LogIn(){
		Social.localUser.Authenticate ((bool success) => {

		});
	}

	public void Achievements(){
		Social.ShowAchievementsUI ();
	}

	public void Leaderboards(){
		PlayGamesPlatform.Instance.ShowLeaderboardUI ("CgkI3a_KxL8PEAIQBg");
	}
}
