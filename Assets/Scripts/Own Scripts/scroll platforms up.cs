using UnityEngine;

public class PlatformScroller : MonoBehaviour
{
    // Adjustable scrolling speed
    public float scrollSpeed = 2f;

    void Update()
    {
        // Move the platform upwards over time
        transform.position += Vector3.up * scrollSpeed * Time.deltaTime;
	}
}