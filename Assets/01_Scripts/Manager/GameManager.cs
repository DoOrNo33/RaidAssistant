using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private TierCountEventHandler tierCountEventHandler;
    private ArmourCountEventHandler armourCountEventHandler;

    public TierCountEventHandler TierCountEventHandler
    {
        get
        {
            return tierCountEventHandler;
        }
    }

    public ArmourCountEventHandler ArmourCountEventHandler
    {
        get
        {
            return armourCountEventHandler;
        }
    }

    protected override void Awake()
    {
        base.Awake();
        tierCountEventHandler = new TierCountEventHandler();
        armourCountEventHandler = new ArmourCountEventHandler();
    }
}
