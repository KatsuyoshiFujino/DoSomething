using UnityEngine;
using System.Collections;

public class StageController : MonoBehaviour {

	public GameObject prevStage;
	public GameObject Stage;
	public GameObject nextStage;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void MoveToNextStage(){
		Destroy(Stage);
		Instantiate(nextStage);
	}

}
