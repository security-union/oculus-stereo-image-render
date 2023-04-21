using UnityEngine;
using UnityEngine.XR;

public class RenderToTexture : MonoBehaviour
{
    public Texture2D leftEyeTexture;
    public Texture2D rightEyeTexture;

    void Start()
    {
        var leftEye = GameObject.Find("LeftEyeAnchor");
        var rightEye = GameObject.Find("RightEyeAnchor");

        var leftCamera = leftEye.GetComponent<Renderer>();
        var rightCamera = rightEye.GetComponent<Renderer>();

        leftCamera.material.mainTexture = leftEyeTexture;
        rightCamera.material.mainTexture = rightEyeTexture;
    }
}

