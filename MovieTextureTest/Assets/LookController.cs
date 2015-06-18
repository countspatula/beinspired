using UnityEngine;
using System.Collections;

public class LookController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("play");
        col.gameObject.GetComponent<MediaPlayerCtrl>().Play();
    }
    void OnTriggerExit(Collider col)
    {

        Debug.Log("pause");
        col.gameObject.GetComponent<MediaPlayerCtrl>().Pause();
    }
}
