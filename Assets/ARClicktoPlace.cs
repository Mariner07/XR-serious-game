using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARClicktoPlace : MonoBehaviour
{
    public GameObject Model;
    public GameObject objectToPlace;
    public GameObject placementIndicator;
    private ARSessionOrigin arOrigin;
    private ARRaycastManager arRaycast;
    private Pose placementPose;
    private bool placementPoseIsValid = false;
    private bool onetime = true;
    public Camera ARCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (onetime)
        {
            UpdatePlacementPose();
            UpdatePlacementIndicator();

            if(placementPoseIsValid && Input.touchCount> 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                PlaceObject();
            }

        }
    }

    private void UpdatePlacementIndicator()
    {
        if (onetime)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        }
        else
        {
            placementIndicator.SetActive(false);
        }
    }

    private void PlaceObject()
    {
        if (onetime == true)
        {
            GameObject obj = Instantiate(objectToPlace, placementPose.position, placementPose.rotation);
            Model.transform.localPosition = obj.transform.localPosition;
            Model.transform.localRotation = obj.transform.localRotation;
            onetime = false;
            placementIndicator.SetActive(false);
            GetComponent<ARClicktoPlace>().enabled = false;
        }
    }

    private void UpdatePlacementPose()
    {
        var screenCenter = ARCam.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();

        _ = arRaycast.Raycast(screenCenter, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
        placementPoseIsValid = hits.Count > 0;
        if (placementPoseIsValid)
        {
            placementPose =hits[0].pose;

            var cameraForward = Camera.main.transform.forward;
            var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;
            placementPose.rotation = Quaternion.LookRotation(cameraBearing);
        }

    }
}
