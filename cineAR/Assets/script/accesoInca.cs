using UnityEngine;
using System.Collections;
using Vuforia;
public class accesoInca : MonoBehaviour, IVirtualButtonEventHandler {

	private string urlToOpen;
	public string urlServer;
	public string methodServer;
	public string paramServer;
	public string urlNoServer;

	IEnumerator Start()
	{
		string url = urlServer+"/"+methodServer+"/"+paramServer;
		WWW www = new WWW(url);
		yield return www;
		SiteCustom myObject = JsonUtility.FromJson<SiteCustom>(www.text);
		urlToOpen = myObject.url_custom;
	}

	// Update is called once per frame
	void Update () {
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < vbs.Length; ++i) {
			
			vbs[i].RegisterEventHandler(this);
		}
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {


			Application.OpenURL(urlToOpen);

		
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) { 
	}

	public class SiteCustom
	{
		public bool status;
		public int code;
		public string url_custom;
		public string message;
	}
}
