namespace Questions.Helpers.Strings
{
    public static class StringHelper
    {
		public static string RandomString(int length)
		{
			var alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

			if (length > alphabet.Length) throw new ArgumentException("Length exceeds string seed");

			return new string(alphabet
							  .OrderBy(o => Guid.NewGuid())
							  .Take(length)
							  .ToArray());
		}
	}
}
