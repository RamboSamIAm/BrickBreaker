using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBrick : MonoBehaviour
{
    [SerializeField, Range(1, 20)] protected int hitsToBreak;
    protected int curHitsToBreak = 0;

    private void Awake()
    {
        curHitsToBreak = hitsToBreak;
    }
    public void Break(int aDamage)
    {
        curHitsToBreak -= aDamage;

        BreakBrick();
    }

    protected void BreakBrick()
    {
        if (curHitsToBreak < 0)
        {
            FindObjectOfType<RoundMannager>().RemoveBrick(this);
            Destroy(gameObject);
        }
    }
}
