using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playvideos : MonoBehaviour {

    public GameObject video1;
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
            videoPlay = false;

            MediaPlayerCtrl.timeBand = true;
            //video1.SetActive(false);
        }

        if (numeroVideo == 0)
        {
            video1.SetActive(true);
            videoPlay = false;

            MediaPlayerCtrl.timeBand = false;

           
        } 
        

	}
}
