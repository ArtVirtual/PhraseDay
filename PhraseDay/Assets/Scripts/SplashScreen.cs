using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	public float delaytimer = 4;
	IEnumerator Start(){

		yield return new WaitForSeconds (delaytimer);
		Application.LoadLevel (1);

		}
}
