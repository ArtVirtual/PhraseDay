using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	public float delaytimer = 5;

	IEnumerator Start(){
		yield return new WaitForSeconds (delaytimer);

		Application.LoadLevel (1);
		}

	/*/ Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/
}
