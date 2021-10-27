using Unity.FPS.Game;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class InteractionObjectPickup : Pickup
    {
        protected override void OnPicked(PlayerCharacterController player)
        {
            PlayerWeaponsManager playerWM = player.GetComponent<PlayerWeaponsManager>();
            if (playerWM && !playerWM.overheatOff)
            {
                playerWM.overheatOff = true;
                PlayPickupFeedback();
                Destroy(gameObject);
            }
        }
    }
}