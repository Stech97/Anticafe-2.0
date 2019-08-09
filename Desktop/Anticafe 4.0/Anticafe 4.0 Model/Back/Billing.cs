namespace Anticafe_4._0_Model
{
    class Billing
    {
        public static void SetSum(int indexGuest)
        {
            int sum = 0;

            Administrator.ListGuest[indexGuest].Sum = sum; 
        } 
    }
}
