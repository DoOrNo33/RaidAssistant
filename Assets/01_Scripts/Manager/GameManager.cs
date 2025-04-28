using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private TierCountEventHandler tierCountEventHandler;
    private ArmourCountEventHandler armourCountEventHandler;
    private SaveSlotNumberEventHandler saveSlotNumberEventHandler;

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

    public SaveSlotNumberEventHandler SaveSlotNumberEventHandler
    {
        get
        {
            return saveSlotNumberEventHandler;
        }
    }

    protected override void Awake()
    {
        base.Awake();

        // 이미 초기화된 경우 기존 인스턴스를 정리
        tierCountEventHandler?.Cleanup();
        armourCountEventHandler?.Cleanup();
        saveSlotNumberEventHandler?.Cleanup();

        // 새로운 인스턴스 생성
        tierCountEventHandler = new TierCountEventHandler();
        armourCountEventHandler = new ArmourCountEventHandler();
        saveSlotNumberEventHandler = new SaveSlotNumberEventHandler();
    }


}
