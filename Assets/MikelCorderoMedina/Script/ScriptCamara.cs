using UnityEngine;

public class ScriptCamara : MonoBehaviour
{
    private Transform cameraTransform;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    private void Update()
    {
        transform.position = cameraTransform.position;
    }
}
