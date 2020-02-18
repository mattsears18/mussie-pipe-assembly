using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class Testscript2 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject Colors;
    public GameObject VB2;

    // use this for initialization
    void Start()
    {
        Colors = GameObject.Find("Colors");
        VB2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Colors.SetActive(false);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Colors.SetActive(true);
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Colors.SetActive(false);
    }
    // Update is called once per frame
    void Update() { }
};