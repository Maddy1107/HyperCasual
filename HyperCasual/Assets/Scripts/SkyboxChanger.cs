using System.Collections.Generic;
using UnityEngine;

public class SkyboxChanger : MonoBehaviour
{
    public List<Material> skyboxes = new List<Material>();

    private void Start()
    {
        RenderSettings.skybox = skyboxes[Random.Range(0, skyboxes.Count)];
    }
}
