using UnityEngine;

public class zzzz : MonoBehaviour
{

    [SerializeField]
    private GameObject capsule;   // 膠囊體
    [SerializeField]
    private SphereCollider sphere1;   // 圓形
    [SerializeField]
    private Camera cam;   //相機
    [SerializeField]
    private GameObject cube1;  //正方形 
    [SerializeField]
    private Rigidbody rig;
    
    

    void Start()
    {

        

        print("攝影機的深度" + Camera.main.depth);
        print("球體半徑" + sphere1.radius);

        cam.backgroundColor = Random.ColorHSV(0f,1f,1f,1f,0.5f,1f);

    }


    void Update()
    {
        capsule.transform.localScale= new Vector3(3, 2, 1);

        cube1.transform.RotateAround(sphere1.transform.position, Vector3.up, 20 * Time.deltaTime);

        rig.AddForce(0,30,0);

    }
}
