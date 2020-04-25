using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour
{
    public Transform p1Transform;
    public Transform p2Transform;

    public Transform cube;
    Vector3 point1;
    Vector3 point2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        point1 = p1Transform.position;
        point2 = p2Transform.position;

        Debug.DrawLine(Vector3.zero, point1, Color.red);
        Debug.DrawLine(Vector3.zero, point2, Color.green);

        float x = point1.y * point2.z - point1.z * point2.y;
        float y = point1.z * point2.x - point1.x * point2.z;
        float z = point1.x * point2.y - point1.y * point2.x;
        Vector3 cross = new Vector3(x, y, z);

        cube.Rotate(cross, 10);

        //Vector3 cross = Vector3.Cross(point1,point2); Bu işlem ile direkt hazır bir metod ile cross işlemi yapılabilir.
        Debug.DrawLine(Vector3.zero, cross, Color.yellow);

        //cx = aybz − azby
        //cy = azbx − axbz
        //cz = axby − aybx

        //NewMethod();
    }

    private void NewMethod()
    {
        //float magnitute = Mathf.Sqrt(Mathf.Pow(point1.x, 2) + Mathf.Pow(point1.y, 2));

        //Vector3 unitPoint1 = point1 / point1.magnitude;
        ////point1.normalized = point1 / point1.magnitude;


        //Debug.Log(unitPoint1);
        ////Debug.Log(point1.magnitude); //hazır fonksiyon aynı hesaplamayı yapar.


        float dotProduct = Vector3.Dot(point1, point2);
        //Debug.Log(dotProduct);

        //a.b = |a|.|b|.cos(theta)
        //cos(theta)=a.b / (|a||b|)
        //theta = acos(a.b/ (|a||b|))
        float thetaRadian = Mathf.Acos(dotProduct / (point1.magnitude * point2.magnitude));
        float theta = thetaRadian * Mathf.Rad2Deg;
        Debug.Log(theta);


        Debug.DrawLine(Vector3.zero, point1, Color.red);
        Debug.DrawLine(Vector3.zero, point2, Color.blue);
        //Debug.DrawLine(Vector3.zero, point1+point2, Color.magenta);
        //Debug.DrawLine(Vector3.zero, point1-point2, Color.black);


        // Debug.DrawLine(Vector3.zero, unitPoint1, Color.green); //Debug.Log(point1.normalized);
    }
}
