using UnityEngine;

public class MoveWithGravity : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce = 5.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // Space 키를 누르면 점프 
        // GetKey : 키를 누르고 있는 동안 계속 감지
        // GetKeyDown : 키를 처음 눌렀을 때 한 번 감지
        // GetKeyUp : 키를 뗄 때 한 번 감지
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Rigidbody : 물리효과를 추가해 중력을 적용한다.
            // AddForce : 점프를 위해 오브젝트에 힘을 준다.
            // ForceMode.Impulse : 순간적으로 힘을 가하는 옵션
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
