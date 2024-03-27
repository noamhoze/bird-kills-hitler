using UnityEngine;
using UnityEngine.Playables;
 
public class PlayTimelineOnCollision : MonoBehaviour
{
    public PlayableDirector timeline;
 
    // Use this for initialization
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }
 
     void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            timeline.Play();
        }
    }
 
    // void OnTriggerExit(Collider c)
    // {
    //     if (c.gameObject.tag == "Player")
    //     {
    //         timeline.Stop();
    //     }
    // }
 

}