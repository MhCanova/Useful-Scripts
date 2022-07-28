using UnityEngine;

public class JugadorBehaviour : MonoBehaviour
{
    [SerializeField] float playerSpeed = 6f;
    [SerializeField] float rotateSpeed = 150f;
    
    void Update()
    {
       MoverRotarPlayer();
    }

    void MoverRotarPlayer()
    {
        float ver = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0,0,ver) * playerSpeed * Time.deltaTime);

        float hor = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0,hor,0) * rotateSpeed * Time.deltaTime);
    }

}
