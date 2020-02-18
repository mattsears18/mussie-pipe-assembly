using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class Testscript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject HelloWorld;
    public GameObject VB;

    // use this for initialization
    void Start()
    {
        HelloWorld = GameObject.Find("HelloWorld");
        VB.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        HelloWorld.SetActive(false);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        HelloWorld.SetActive(true);
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        HelloWorld.SetActive(false);
    }
    // Update is called once per frame
    void Update() { }
};