using UnityEngine;

public class Player : MonoBehaviour
{
    // 움직이는 속도를 정의
    public float moveSpeed = 5.0f;
    void Start()
    {
        
    }

    void FixedUpdate()      // 덜덜 거리는 걸 없앤다
    {
        //// 지정한 Axis를 통해 키의 방향을 판단하고 속도와 프레임 판정을 곱해 이동량을 정한다.
        //float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //// 이동량 만큼 실제로 이동을 해주는 함수
        //transform.Translate(distanceX, 0, 0);
        moveControl();
    }

    void moveControl()      // 함수로 만들어서 호출
    {
        // 지정한 Axis를 통해 키의 방향을 판단하고 속도와 프레임 판정을 곱해 이동량을 정한다.
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        // 이동량 만큼 실제로 이동을 해주는 함수
        transform.Translate(distanceX, 0, 0);
    }
}
