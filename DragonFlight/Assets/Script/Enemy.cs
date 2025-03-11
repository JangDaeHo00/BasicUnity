using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 움직일 속도를 지정해준다.
    public float moveSpeed = 1.3f;
    public int scoreValue = 10;
    void Start()
    {
        if (gameObject.CompareTag("NormalEnemy1")) scoreValue = 20;
        else if (gameObject.CompareTag("NormalEnemy2")) scoreValue = 50;
        else if (gameObject.CompareTag("Boss")) scoreValue = 100;
    }

    void Update()
    {
        // 움직일 거리를 계산해준다.
        float distanceY = moveSpeed * Time.deltaTime;
        // 움직임을 반영한다.
        transform.Translate(0, -distanceY, 0);
    }

    // 화면 밖으로 나가 카메라에서 보이지 않으면 호출된다.
    private void OnBecameInvisible()
    {
        Destroy(gameObject);    // 객체를 삭제한다.
    }

    private void OnDestroy()
    {
        GameManager.instance.AddScore(scoreValue);
    }
}
