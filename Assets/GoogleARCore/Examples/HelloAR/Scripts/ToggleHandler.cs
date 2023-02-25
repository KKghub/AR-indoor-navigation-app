using GoogleARCore.Examples.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleHandler : MonoBehaviour
{
    bool showPlanes;
    bool showButtons;
    bool showFlag = true;
    public int counter = 0;

    public void OnToggle(bool flag)
    {
        counter++;
        if (counter % 2 == 1)
        {
            flag = false;
        } else
        {
            flag = true;
        }
        showFlag = !showFlag;
        OnTogglePlanes(flag);
        OnToggleButtons(flag);
    }
    public void OnTogglePlanes(bool flag)
    {
        showPlanes = flag;
        foreach (GameObject plane in GameObject.FindGameObjectsWithTag("plane"))
        {
            Renderer r = plane.GetComponent<Renderer>();
            DetectedPlaneVisualizer t = plane.GetComponent<DetectedPlaneVisualizer>();
            r.enabled = flag;
            t.enabled = flag;
        }
    }

    public void OnToggleButtons(bool flag)
    {
        showButtons = flag;
        foreach (GameObject button in GameObject.FindGameObjectsWithTag("hideableButton"))
        {
            Button btn = button.GetComponent<Button>();
            btn.interactable = flag;
            // btn.image.color = new Color(255f, 0f, 0f, .5f);
            btn.gameObject.SetActive(flag);
            button.SetActive(flag);
        }
    }
}
