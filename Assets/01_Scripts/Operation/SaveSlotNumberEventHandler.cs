using UnityEngine;

public class SaveSlotNumberEventHandler
{
    [SerializeField] private int saveSlotNumber = 0;

    public delegate void UpdateSaveSlotNumber(int value);

    private event UpdateSaveSlotNumber updateSaveSlotNumber;

    public int SaveSlotNumber
    {
        get
        {
            return saveSlotNumber;
        }
        set
        {
            saveSlotNumber = value;
            updateSaveSlotNumber?.Invoke(SaveSlotNumber);
        }
    }

    public void AddUpdateSaveSlotNumberListener(UpdateSaveSlotNumber listener)
    {
        updateSaveSlotNumber += listener;
    }

    public void RemoveUpdateSaveSlotNumberListener(UpdateSaveSlotNumber listener)
    {
        updateSaveSlotNumber -= listener;
    }

    private void OnDestroy()
    {
        Cleanup();
    }

    public void Cleanup()
    {
        updateSaveSlotNumber = null;
    }
}
