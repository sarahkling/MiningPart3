using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject cubePrefab;

	float createBronzeTime = 3f;
	float timeToAct = 0f;
	float spawnSilverTime = 12.0f;


	// Use this for initialization
	void Start () {
		timeToAct += createBronzeTime;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > timeToAct) {
			//Whatever the Instantiate method creates, store it in a new variable called myCube, which is a GameObject.
			GameObject myCube = (GameObject) Instantiate(cubePrefab,
			            new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0),
			            Quaternion.identity);
			if (Time.time >= spawnSilverTime) {
				myCube.GetComponent<Renderer>().material.color = Color.white;
			}
			else {
				myCube.GetComponent<Renderer>().material.color = Color.red;
			}
			timeToAct += createBronzeTime;
		}
	
	}
}
