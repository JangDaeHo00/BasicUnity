using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5.0f;  // 이동 속도
      
        void Update()
    {
        //Vector3 a = Vector3.right;  // x(1, 0, 0)
        //Vector3 a = Vector3.left;   // y(0, 1, 0)
        //Vector3 a = Vector3.forward // z(0, 0, 1)

        // 키 입력에 따라 이동
        //float move = Input.GetAxis("Horizontal");   // Horizontal : 키보드 좌우 (x축)
        // 방향 * 스피드 * 타임델타타임(없으면 훅훅 지나감, 부드럽게 움직일 수 O)
        //transform.Translate(Vector3.right * move * speed * Time.deltaTime);

        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);    // Vertical : 상하 (y축)
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));      // z축으로 앞뒤
        
        //transform.position += move * speed * Time.deltaTime;
        transform.Translate(move * speed * Time.deltaTime);     // 두 개 다 가능

        // positoin는 좌표이고 translate는 좌표 이동같은 개념인 느낌
        // 포지션의 상위개념이 Transform인데
        // 그걸 움직이는걸 Translate라고 함
    }
}
