using UnityEngine;


public class NormalEnemy : MonoBehaviour
{
    public GameObject normalEnemy;
    public EnemyData enemy = new(1, 0.03f);


    //GameManager�� �̵��� �ڵ�
    void Start()
    {
        //Application.targetFrameRate = 60;
        //InvokeRepeating("MakeEnemy", 0f, 3f);
        MakeEnemy();
    }

    void Update()
    {
        MoveEnemy(enemy);
    }

    private void MakeEnemy()
    {
        // �Ϲ� Ÿ�� enemy�� ȭ�� ��ܿ� ���� ����(��ġ)
        //Instantiate(normalEnemy);

        Debug.Log("ȭ�� ��ܿ� �� ���� ����");

        float x = Random.Range(-3.0f, 3.0f);
        float y = 5.0f;
        transform.position = new Vector3(x, y);
    }

    private void MoveEnemy(EnemyData enemy)
    {
        // ����ִ� �� �⺻ �̵�(�ϰ�)

        if (enemy.Hp > 0)
        {
            transform.position += Vector3.down * enemy.Speed;
            if (transform.position.y < -4.0f)
            {
                Debug.Log("ȭ�� ���ϴܿ� ������ �� ������Ʈ�� �ı��մϴ�.");
                Destroy(normalEnemy, 3.0f);
            }
        }
    }

    private void Attack()
    {
        // �Ѿ� ���� �Լ� ȣ���ϱ�
    }

    //�浹 ����

    private void DestoryEnemy() { }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // ��� ���� �� player�� bullet�� ������
            // Hp�� �ٰ� player�� bullet�� �ı��Ѵ�

            if (enemy.Hp > 0)
            {
                enemy.Hp -= 1;
                Destroy(collision.gameObject);
            }
            else if (enemy.Hp == 0)
            {
                Destroy(normalEnemy, 3.0f);
                //GameManager.Instance.AddScore();
            }

            //�÷��̾�� �浹 �ÿ��� ���� ��
        }
    }
}