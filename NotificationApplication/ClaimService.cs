namespace NotificationApplication
{
    public class ClaimService
    {
        public void RegisterClaim(RegisterClaimDTO claim)
        {
            RegisterClaim registerClaim = new RegisterClaim(claim);
            registerClaim.Run();
        }
    }
}