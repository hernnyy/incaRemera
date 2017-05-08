using UnityEngine;
using System.Collections;
using Vuforia;
public class accesoOmega : MonoBehaviour, IVirtualButtonEventHandler {

	public string teststring;
	// Use this for initialization
//	void Start () {
//
		
//
//	}
	
	// Update is called once per frame
	void Update () {
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < vbs.Length; ++i) {
			
			vbs[i].RegisterEventHandler(this);
		}
	}
	IEnumerator Start()
	{
		string url = "http://ikaroira.com/ws/ws-user.php/getFanPage";
		WWW www = new WWW(url);
		yield return www;
		teststring = www.text;
	}
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		
		// si se presiona el boton virtual quebrada


		if (vb.VirtualButtonName == "VirtualOmega") {
			
//			Application.OpenURL("https://www.facebook.com/events/558981187604216/");
			Application.OpenURL(teststring);

		}
		
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) { 
	}
}
