using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class Testscript3 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject Dimension;
    public GameObject VB3;

    // use this for initialization
    void Start()
    {
        Dimension = GameObject.Find("Dimension");
        VB3.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Dimension.SetActive(false);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Dimension.SetActive(true);
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Dimension.SetActive(false);
    }
    // Update is called once per frame
    void Update() { }
};
