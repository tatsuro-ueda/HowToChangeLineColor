using UnityEngine;

public class DrawDynamicLine : MonoBehaviour {

    public GameObject fromObject = null;
    public GameObject toObject = null;
    public GameObject lineRendererContainer = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        LineRenderer lineOld = lineRendererContainer.GetComponent<LineRenderer>();
        DestroyImmediate(lineOld);

        LineRenderer lineNew = lineRendererContainer.AddComponent<LineRenderer>();

        lineNew.startColor = Color.blue;
        lineNew.endColor = Color.red;
        //第一引数には始点、第二引数には終点の色を渡します。

        lineNew.startWidth = 0.1f;
        lineNew.endWidth = 0.1f;

        lineNew.SetPosition(0, fromObject.transform.position + new Vector3(0, -0.1f, 0));
        lineNew.SetPosition(1, toObject.transform.position);
        //line.SetPosition関数の第一引数は配列の要素数(配列は0スタートです！,第二引数は座標です)

    }
}
