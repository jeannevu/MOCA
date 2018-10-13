using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.Extras
{
    [RequireComponent(typeof(SteamVR_TrackedObject))]
    public class DrawLineManager : MonoBehaviour
    {
        public SteamVR_Action_Boolean spawn;

        SteamVR_Behaviour_Pose trackedObj;

        // Update is called once per frame
        void Update()
        {
            
            // if trigger is pressed down
            if (spawn.GetStateDown(trackedObj.inputSource))
            {
                Debug.Log("GOT HERE");
            }
        }
    }
}


