using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;
    [SerializeField, Range(0f,10f)]private float helpCameraFollowFaster = 3;
    

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // void LateUpdate()
    // {
    //     transform.position = player.transform.position + offset;
    // }

    void FixedUpdate () {
        this.transform.position = new Vector3 (Mathf.Lerp(this.transform.position.x, player.transform.position.x + offset.x, Time.deltaTime*helpCameraFollowFaster),
                                               Mathf.Lerp(this.transform.position.y, player.transform.position.y + offset.y, Time.deltaTime*helpCameraFollowFaster),
                                               Mathf.Lerp(this.transform.position.z, player.transform.position.z + offset.z, Time.deltaTime*helpCameraFollowFaster)
                                               );
    }
}
