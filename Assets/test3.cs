using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test3 : MonoBehaviour {
    public Text t;
    float time = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time=Time.time;
        t.text = time.ToString();
	}
}
