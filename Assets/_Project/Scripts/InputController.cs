using UnityEngine;

namespace DragonspiritGames.EchoesOfFire
{
    public abstract class InputController : ScriptableObject
    {
        public abstract float RetrieveMoveInput(GameObject gameObject);
        public abstract bool RetrieveJumpInput(GameObject gameObject);
        public abstract bool RetrieveFireInput(GameObject gameObject);
    }
}
