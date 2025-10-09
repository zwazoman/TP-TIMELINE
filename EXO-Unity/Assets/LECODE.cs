using UnityEngine;

public class LECODE : MonoBehaviour
{
    void Update()
    {
        if (Vector3.Angle(Camera.main.transform.forward, GameObject.Find("Sphere").transform.position - Camera.main.transform.position) > 90) print("C'est LOIN");

    }
}
