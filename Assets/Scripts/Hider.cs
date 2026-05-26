using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Hider : MonoBehaviour
{

    public Vector3 hidePosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
public void hide()
    {
        transform.position = hidePosition;
    }
}
