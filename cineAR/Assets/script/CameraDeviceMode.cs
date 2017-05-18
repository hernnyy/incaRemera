using System.Collections;
using System;
using Vuforia;
using UnityEngine;

public class CameraDeviceMode : MonoBehaviour 
{
	private bool mVuforiaStarted = false;

	// Use this for initialization
	void Start ()
	{
        VuforiaARController vuforia = VuforiaARController.Instance;
        vuforia.RegisterVuforiaStartedCallback(OnVuforiaStarted);
	}

	private void OnVuforiaStarted()
	{
		Debug.Log(" OnVuforiaStarted ");
		mVuforiaStarted = true;
		SetAutofocus();
	}

	void OnApplicationPause(bool pause)
	{
		if (!pause)
		{
			// App resumed
			Debug.Log("App resumed");
			if (mVuforiaStarted)
			{
				// App resumed, and Vuforia already started previously
				SetAutofocus();
			}
		}
	}

	private void SetAutofocus()
	{
//		CameraDevice.Instance.SetFocusMode( 
//			CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
		bool focusModeSet = CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
//
		if (!focusModeSet) {
			Debug.Log ("Failed to set focus mode FOCUS_MODE_CONTINUOUSAUTO (unsupported mode).");
			bool triggerModeSet = CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);
			if (!triggerModeSet) {
				Debug.Log ("Failed to set focus mode FOCUS_MODE_TRIGGERAUTO (unsupported mode).");
			}
		}
	}
}