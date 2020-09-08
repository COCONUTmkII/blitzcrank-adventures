using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform player = null;
    Vector3 temp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        temp = new Vector3(player.transform.position.x, player.transform.position.y + 3.0f, player.transform.position.z - 8.0f);
        transform.position = Vector3.Lerp(transform.position, temp, Time.deltaTime * 6);
       // transform.forward += player.transform.forward;
    }
}
