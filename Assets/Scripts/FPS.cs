using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    public int targetfps = 60;
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetfps;
    }
}
