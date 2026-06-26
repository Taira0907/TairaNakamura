using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    [SerializeField] private float speed = 3f;  // 移動スピード
    [SerializeField] private float distance = 5f; // 往復する全体の距離

    private Vector3 startPosition;

    void Start()
    {
        // ゲーム開始時の初期位置を記憶
        startPosition = transform.position;
    }

    void Update()
    {
      float pingPong = Mathf.PingPong(Time.time * speed, distance);
    float offset = pingPong - (distance / 2f);

    // 以下の行で「startPosition.x + offset」となっているか確認してください
    transform.position = new Vector3(startPosition.x + offset, startPosition.y, startPosition.z);
    }
}