namespace PsAnotherNUnit
{
    public class AirlineMembershipNumberValidator
    {
        public bool ValidityOf(string membershipNumber)
        {
            var isIncorrectLength = membershipNumber;

            if (isIncorrectLenth)
            {
                return false;
            }

            if (StartsWithALetterFollowedBy7Numbers(membershipNumber))
            {
                return true;
            }

            return false;
        }
    }
}
