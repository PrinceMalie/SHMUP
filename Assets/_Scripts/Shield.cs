using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [Header("Shield Rotation")]
    public float rotationPerSecond = 0.1f;

    [Header("Sheild Level")]
    public int levelShown = 0;

    Material mat; 
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        int currLevel = Mathf.FloorToInt(HeroScript.S.shieldLevel);
        if (currLevel != levelShown)
        {
            levelShown = currLevel;
            mat.mainTextureOffset = new Vector2(0.2f * levelShown, 0);
        }

        float rZ = -(rotationPerSecond * Time.time * 360) % 360f; 
        transform.rotation = Quaternion.Euler(0, 0, rZ);

    }
}
