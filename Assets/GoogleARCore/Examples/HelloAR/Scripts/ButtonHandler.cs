using UnityEngine;
using GoogleARCore.Examples.HelloAR;

public class ButtonHandler : MonoBehaviour
{
    GameObject controllerGO;
    HelloARController scriptMyHelloAR;
    GameObject sphereGO;
    GameObject arrowGO;
    GameObject wrongWayGO;
    GameObject thisWay1;
    GameObject thisWay2;
    GameObject destinationGO;
    public void ChangeObjectTypeToDestination()
    {
        controllerGO = GameObject.Find("HelloARController");
        scriptMyHelloAR = controllerGO.GetComponent<HelloARController>();
        destinationGO = GameObject.Find("destination");
        scriptMyHelloAR.GameObjectHorizontalPlanePrefab = destinationGO;
        scriptMyHelloAR.GameObjectPointPrefab = destinationGO;
    }
    public void ChangeObjectTypeToWrongWay()
    {
        controllerGO = GameObject.Find("HelloARController");
        scriptMyHelloAR = controllerGO.GetComponent<HelloARController>();
        wrongWayGO = GameObject.Find("wrong_way");
        scriptMyHelloAR.GameObjectHorizontalPlanePrefab = wrongWayGO;
        scriptMyHelloAR.GameObjectPointPrefab = wrongWayGO;
    }
    public void ChangeObjectTypeToThisWay1()
    {
        controllerGO = GameObject.Find("HelloARController");
        scriptMyHelloAR = controllerGO.GetComponent<HelloARController>();
        thisWay1 = GameObject.Find("this_way_1");
        scriptMyHelloAR.GameObjectHorizontalPlanePrefab = thisWay1;
        scriptMyHelloAR.GameObjectPointPrefab = thisWay1;
    }
    public void ChangeObjectTypeToThisWay2()
    {
        controllerGO = GameObject.Find("HelloARController");
        scriptMyHelloAR = controllerGO.GetComponent<HelloARController>();
        thisWay2 = GameObject.Find("this_way_2");
        scriptMyHelloAR.GameObjectHorizontalPlanePrefab = thisWay2;
        scriptMyHelloAR.GameObjectPointPrefab = thisWay2;
    }
    public void ChangeObjectTypeToSphere()
    {
        controllerGO = GameObject.Find("HelloARController");
        scriptMyHelloAR = controllerGO.GetComponent<HelloARController>();
        sphereGO = GameObject.Find("sphere");
        scriptMyHelloAR.GameObjectHorizontalPlanePrefab = sphereGO;
        scriptMyHelloAR.GameObjectPointPrefab = sphereGO;
    }
    public void ChangeObjectTypeToArrow()
    {
        controllerGO = GameObject.Find("HelloARController");
        scriptMyHelloAR = controllerGO.GetComponent<HelloARController>();
        arrowGO = GameObject.Find("arrow");
        scriptMyHelloAR.GameObjectHorizontalPlanePrefab = arrowGO;
        scriptMyHelloAR.GameObjectPointPrefab = arrowGO;
    }
}
