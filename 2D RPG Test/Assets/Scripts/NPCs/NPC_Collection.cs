using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Collection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<NPC> npcs = new List<NPC>();

        npcs.Add(new NPC("Dorian", 17));

    }


}
