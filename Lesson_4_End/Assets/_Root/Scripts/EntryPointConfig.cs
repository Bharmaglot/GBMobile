using Profile;
using UnityEngine;

internal interface IEntryPoint
{
    float SpeedCar { get; }
    GameState InitialState { get; }

}


[CreateAssetMenu(fileName = nameof(EntryPointConfig), menuName = "Configs/" + nameof(EntryPointConfig))]
internal class EntryPointConfig : ScriptableObject, IEntryPoint

{
    [field: SerializeField] public float SpeedCar { get; private set; }
    [field: SerializeField] public GameState InitialState { get; private set; } 
}
