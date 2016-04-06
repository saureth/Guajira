using UnityEngine;
using System.Collections;

public class CreateAvatar : MonoBehaviour {

	public bool randomAvatar;
	public GameObject[] head;
	public GameObject[] body;
	public GameObject[] legs;
	public int headNumber;
	public int bodyNumber;
	public int legsNumber;

	private GameObject headChosen;
	private GameObject bodyChosen;
	private GameObject legsChosen;
	private int randomIterator;

	void Start () {
		if (randomAvatar) {
			GenerateRandomAvatar();
		} 
		else {
			headChosen = head [headNumber];
			bodyChosen = body [bodyNumber];
			legsChosen = legs [legsNumber];
		}
	}

	void GenerateRandomAvatar(){
		randomIterator = Random.Range (0, head.Length);
		headChosen = head [randomIterator];
		randomIterator = Random.Range (0, body.Length);
		bodyChosen = body [randomIterator];
		randomIterator = Random.Range (0, legs.Length);
		legsChosen = legs [randomIterator];
	}

	void Update () {
	
	}
}
