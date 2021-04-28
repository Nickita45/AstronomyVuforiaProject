using UnityEngine;

/// <summary>
/// Spin the object at a specified speed
/// </summary>
public class SpinFree : MonoBehaviour
{
    [Tooltip("Spin: Yes or No")]
    public bool spin;
    [Tooltip("Spin the parent object instead of the object this script is attached to")]
    public bool spinParent;
    public float speed = 10f;
    public bool circleRun;
    public bool backRun;
    public float angle = 0f;
    public float radius = 0.5f;

    [HideInInspector]
    public bool clockwise = true;
    [HideInInspector]
    public float direction = 1f;
    [HideInInspector]
    public float directionChangeSpeed = 2f;
    public bool isForward = false;

    public bool isMoon = false;
    // Update is called once per frame
    void Update()
    {
        Vector3 vector3;
        if(isForward)
            vector3 = Vector3.forward;
        else
            vector3 = Vector3.up;
        if (direction < 1f)
        {
            direction += Time.deltaTime / (directionChangeSpeed / 2);
        }

        if (spin)
        {
            if (clockwise)
            {
                if (spinParent)
                    transform.parent.transform.Rotate(vector3, (speed * direction) * Time.deltaTime);
                else
                    transform.Rotate(vector3, (speed * direction) * Time.deltaTime);
            }
            else
            {
                if (spinParent)
                    transform.parent.transform.Rotate(-vector3, (speed * direction) * Time.deltaTime);
                else
                    transform.Rotate(-vector3, (speed * direction) * Time.deltaTime);
            }
        }

        if (circleRun)
        {
            if (backRun)
            {
                angle -= Time.deltaTime;
            }
            else
            {
                angle += Time.deltaTime;
            }


            var x = Mathf.Cos(angle * speed) * radius;
            var z = Mathf.Sin(angle * speed) * radius;
            if(!isMoon)
            transform.localPosition = new Vector3(x, 0, z);
            else
            transform.localPosition = new Vector3(x, z, 0);
           // transform.rotation = Quaternion.identity;

        }
    }
}