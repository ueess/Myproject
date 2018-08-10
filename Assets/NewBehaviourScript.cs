using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Globe
{
    public static string nextSceneName;
}
public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //异步加载新场景
    public void LoadNewScene()
    {
        //保存需要加载的目标场景
        Globe.nextSceneName = "003";
        SceneManager.LoadScene("002");
    }
}
