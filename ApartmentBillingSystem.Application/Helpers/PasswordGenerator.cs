namespace ApartmentBillingSystem.Application.Helpers
{
    public static class PasswordGenerator
    {
        public static string GenerateRandomPassword(int length = 8)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            var res = new char[length];
            var rnd = new Random();
            for (int i = 0; i < length; i++)
                res[i] = valid[rnd.Next(valid.Length)];
            return new string(res);
        }
    }
}
