using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playvideos : MonoBehaviour {

    public GameObject video1;
	public GameObject video2;
	public GameObject video3;
	public static int numeroVideo;
    public static bool videoPlay;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (numeroVideo == 1)
		{
			video1.SetActive(true);
			video2.SetActive(false);
			video3.SetActive(false);
			videoPlay = false;

			MediaPlayerCtrl.timeBand = false;
			//video1.SetActive(false);
		}

		if (numeroVideo == 2)
		{
			video1.SetActive(false);
			video2.SetActive(true);
			video3.SetActive(false);
			videoPlay = false;

			MediaPlayerCtrl.timeBand = false;
			//video1.SetActive(false);
		}
		if (numeroVideo == 3)
		{
			video1.SetActive(false);
			video2.SetActive(false);
			video3.SetActive(true);
			videoPlay = false;

			MediaPlayerCtrl.timeBand = false;
			//video1.SetActive(false);
		}
        if (numeroVideo == 0)
        {
			videoPlay = false;

			MediaPlayerCtrl.timeBand = true;

        } 
        

	}
}
