﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Click);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Click()
    {
        GameObject.Find("Main Camera").GetComponent<CameraEffect>().enabled = false;
        transform.parent.gameObject.SetActive(false);
        transform.parent.parent.Find("Status").gameObject.SetActive(true);// 显示状态UI
        // TODO: Start game
    }
}
