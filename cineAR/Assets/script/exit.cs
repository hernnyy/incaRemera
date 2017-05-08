using UnityEngine;
using System.Collections;

public class exit : MonoBehaviour {

	public GameObject element;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void BackAplication()
	{			
		element.SetActive (false);
	}

	public void CloseAplication()
	{			
		Application.Quit();

	}
}
