using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public string panoramaID;
	public float yawDegree;
	
	public void SetDegree(float degree)
	{
		yawDegree = degree;
		
		transform.Rotate(Vector3.right, 90.0f); // 세워진 화살표를 눕히고
		transform.Rotate(Vector3.forward, degree - 90.0f); // 화살표의 전방방향으로 Yaw만큼 회전한 후 90도의 오차만큼 회전한다.
		transform.Translate(0, 6, 3, Space.Self);
	}
	
	public void SetPanoramaID(string id)
	{
		panoramaID = id;
	}
}