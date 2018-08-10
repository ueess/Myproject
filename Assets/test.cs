﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class test : MonoBehaviour


{


    public Slider loadingSlider;

    public Text loadingText;

    private float loadingSpeed = 1;

    private float targetValue;

    private AsyncOperation operation;

  void Start()
    {

        loadingSlider.value = 0.0f;

        if (SceneManager.GetActiveScene().name == "002")
        {

            StartCoroutine(AsyncLoading());
        }

    }



    private IEnumerator AsyncLoading()
    {
        operation = SceneManager.LoadSceneAsync(Globe.nextSceneName);

        operation.allowSceneActivation = false;

        yield return operation;
    }
  void Update()
    {
        targetValue = operation.progress;
        if (operation.progress >= 0.9f)
        {
            //operation.progress的值最大为0.9
            targetValue = 1.0f;
        }
        if (targetValue != loadingSlider.value)
        {
           //插值运算
            loadingSlider.value = Mathf.Lerp(loadingSlider.value, targetValue, Time.deltaTime*loadingSpeed);
            if (Mathf.Abs(loadingSlider.value - targetValue) < 0.01f)
            {
               loadingSlider.value = targetValue;
            }
            loadingText.text = ((int) (loadingSlider.value*100)).ToString() + "%";
            if ((int) (loadingSlider.value*100) == 100)
            {
                //允许异步加载完毕后自动切换场景
                operation.allowSceneActivation = true;
            }
        }
    }
}





