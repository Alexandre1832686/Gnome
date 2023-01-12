using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
        public Transform Target;
        public float Speed= 1f;
        private Coroutine LookCorutine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void  StartRotating()
    {
        if(LookCorutine!=null){
            StopCoroutine(LookCorutine);
        } 
        LookCorutine=StartCorutine(lookAt());
    }
    private IEnumerator lookAt()
    {
        Quaternion lookRotation= Quaternion.lookRotation(target.position-transform. position);

        float time=0;
        while(time<1)
        {
            transform.rotation=Quaternion.Slerp(transform.rotation, lookRotation,time);
        }
        time +=Time.fixedDeltaTime* Speed;

        yield return null;
    }

}
