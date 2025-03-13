using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float scrollSpeed = 0.01f;
    Material myMatrial;
    void Start()
    {
        myMatrial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        float newOffsetY = myMatrial.mainTextureOffset.y + scrollSpeed * Time.deltaTime;

        Vector2 newOffset = new Vector2(0, newOffsetY);

        myMatrial.mainTextureOffset = newOffset;
    }
}
