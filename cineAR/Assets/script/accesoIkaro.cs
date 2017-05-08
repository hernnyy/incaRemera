using UnityEngine;
using System.Collections;
using Vuforia;

public class accesoIkaro : MonoBehaviour , IVirtualButtonEventHandler{

	// Use this for initialization
	void Start () {
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < vbs.Length; ++i) {
			
			vbs[i].RegisterEventHandler(this);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
		

			Application.OpenURL("https://www.facebook.com/ikaroIRA/?fref=ts");

	}
			
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) { 
	}
}
