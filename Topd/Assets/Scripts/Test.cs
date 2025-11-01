using UnityEngine;

public class Test : MonoBehaviour
{
    public NPC_Talk npc_Talk;
    void Start()
    {
        DialogueSystem.Instance.TypeText(npc_Talk);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            DialogueSystem.Instance.TypeText(npc_Talk);
        }
    }
}
