namespace BuberDinner.Domain.Dinner.Enums;

public enum ReservationStatus
{
    PendingGuestApproval = 0, // En attente de la confirmation de l'invité
    Reserved = 1,             // Confirmée et réservée
    Cancelled = 2,            // Annulée (par l'invité ou l'hôte)
    Used = 3                  // L'invité s'est bien présenté au dîner
}