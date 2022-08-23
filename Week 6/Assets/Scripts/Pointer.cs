using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public Transform Aim;
    public Camera PlayerCamera;
    public Transform Body;

    float _yEuler;

    // Update is called once per frame
    void LateUpdate()
    {
        
        Ray ray = PlayerCamera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction *50f, Color.yellow);
        Plane plane = new Plane(-Vector3.forward, Vector3.zero);
        float distance;
        plane.Raycast(ray, out distance);
        Vector3 point = ray.GetPoint(distance);
        Aim.position = point;


        Vector3 toAim = Aim.position - transform.position;
        transform.rotation = Quaternion.LookRotation(toAim);

        if (toAim.x < 0)
        {
            _yEuler = Mathf.Lerp(_yEuler, 45f, Time.deltaTime * 8f);
        }
        else
        {
            _yEuler = Mathf.Lerp(_yEuler, -45f, Time.deltaTime * 8f);
        }
        Body.localEulerAngles = new Vector3(0, _yEuler, 0);


        //Body.transform.rotation = Quaternion.LookRotation(Vector3.Lerp(new Vector3(-Aim.position.x / 2, 0f, 0f), new Vector3(-transform.position.x / 2, 0f, 0f), 0.2f));
        //Body.transform.rotation = Quaternion.Lerp(Body.rotation, Aim.rotation, 0.5f);

        //Vector3.Lerp(ColliderTransform.localScale, new Vector3(1f, 0.5f, 1f), Time.deltaTime * 15f);
    }
}
