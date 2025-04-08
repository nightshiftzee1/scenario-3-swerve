using UnityEngine;

public class PlatformScroller : MonoBehaviour
{

    [SerializeField] private string[] Tags;
    public float scrollSpeed = 1;

    void Update()
    {
        scrollSpeed = scrollSpeed + Time.deltaTime ;
        // Move the platform upwards over time
        transform.position += Vector3.up * scrollSpeed * Time.deltaTime;
	}
}
//change under 50 when goes over 50 
//if scrollspeed < 50 scrollSpeed == 50 