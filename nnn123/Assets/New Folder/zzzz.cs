using UnityEngine;

public class zzzz : MonoBehaviour
{

    [SerializeField]
    private GameObject capsule;   // ���n��
    [SerializeField]
    private SphereCollider sphere1;   // ���
    [SerializeField]
    private Camera cam;   //�۾�
    [SerializeField]
    private GameObject cube1;  //����� 
    [SerializeField]
    private Rigidbody rig;
    
    

    void Start()
    {

        

        print("��v�����`��" + Camera.main.depth);
        print("�y��b�|" + sphere1.radius);

        cam.backgroundColor = Random.ColorHSV(0f,1f,1f,1f,0.5f,1f);

    }


    void Update()
    {
        capsule.transform.localScale= new Vector3(3, 2, 1);

        cube1.transform.RotateAround(sphere1.transform.position, Vector3.up, 20 * Time.deltaTime);

        rig.AddForce(0,30,0);

    }
}
