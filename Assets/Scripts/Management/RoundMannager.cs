using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundMannager : MonoBehaviour
{
    // [SerializeField] protected BreakableBrick[] bricks;
    [SerializeField] protected GameObject cavasScene;

    private void Awake()
    {
        GameObject[] gOs = GameObject.FindObjectsOfType<GameObject>();

        if (gOs.Length > 1)
        {
            Destroy(gameObject);
        }
    }

    public void RemoveBrick(BreakableBrick bb)
    {
        EndRound();
    }

    protected void EndRound()
    {
        if (FindObjectsOfType<BreakableBrick>().Length <= 0)
        {
            cavasScene.SetActive(true);
        }
    }
}
