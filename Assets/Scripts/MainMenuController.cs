﻿using UnityEngine;

public class MainMenuController : MonoBehaviour
{

    private GameObject credits, menu, controls;
    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
        CameraControl.StartStop(true);
        menu = GameObject.Find("CanvasMenu");
        credits = GameObject.Find("CanvasCredits");
        controls = GameObject.Find("CanvasControls");
        DisableCanvas();
    }

    void DisableCanvas()
    {
        controls.SetActive(false);
        credits.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (credits.activeSelf)
            {
                credits.SetActive(false);
                menu.SetActive(true);
            }
            else if (controls.activeSelf)
            {
                controls.SetActive(false);
                menu.SetActive(true);
            }
            else if (!menu.activeSelf)
            {
                menu.SetActive(true);
                CameraControl.StartStop(true);
            }
            else if (menu.activeSelf)
            {
                menu.SetActive(false);
                CameraControl.StartStop(false);
            }
        }
    }

    public void StartGame()
    {
        menu.SetActive(false);
        CameraControl.StartStop(false);
    }

    public void ShowCredits()
    {
        menu.SetActive(false);
        credits.SetActive(true);
    }

    public void CloseCredits()
    {
        credits.SetActive(false);
        menu.SetActive(true);
    }

    public void ShowControls()
    {
        menu.SetActive(false);
        controls.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
