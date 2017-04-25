using UnityEngine;
using System.Collections;

public class SysClock : MonoBehaviour {
    public float step;
    public float scale;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        step = Time.deltaTime * scale;   
	}
}
