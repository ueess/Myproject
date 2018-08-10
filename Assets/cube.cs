using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {
    float time;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
     

        if (time>2)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.transform.Rotate(new Vector3(0, 10f, 1));

        }

        if (time>5)
        {
            time = 0;
        }
       
    }
}
