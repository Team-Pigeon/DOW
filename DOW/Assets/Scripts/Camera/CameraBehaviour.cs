using System;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {
    public Camera camera_main_player1;
    public Camera camera_place_0;
    public Camera camera_place_1 { get; set; }
    public Camera camera_place_2;
    public Camera camera_place_3;
    public Camera camera_place_4;
    public Camera camera_place_5;
    public Camera camera_place_6;

    // Use this for initialization
    void Start () {
        Debug.Log("start");
        camera_main_player1 = Camera.main;
        Debug.Log(camera_main_player1);
        Debug.Log(Camera.allCamerasCount);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
