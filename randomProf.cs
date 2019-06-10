using UnityEngine;
using System.Collections;

public class randomProf : MonoBehaviour {
	public int rand = 0;
	// Use this for initialization
	void Rand () {
		rand = Random.Range (0, 3);
	}
	
	// Update is called once per frame
	void Start () {
		Rand ();
	}
	void Update(){
		if (GameObject.FindGameObjectWithTag ("Voenn")) {

			rand = Random.Range(1,3);

				}
		if (GameObject.FindGameObjectWithTag ("Medik")) {
			
			rand = Random.Range(0,3);
			
		}
		if (GameObject.FindGameObjectWithTag ("Meh")) {
			
			rand = Random.Range(0,2);
			
		}

	}
}
