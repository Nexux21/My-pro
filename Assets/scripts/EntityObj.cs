using Unity.VisualScripting;
using UnityEngine;

public class EntityObj : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public float distance;

    public float radius;

    void Start()
    {

    }

    void Update()
    {

        distance = Vector3.Distance(target.transform.position,transform.position);
        if (distance < radius)
        {


            Vector3 dir = (target.transform.position - transform.position).normalized;

            transform.position += dir * speed * speed * Time.deltaTime;
        }
    }

} 