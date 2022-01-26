namespace ZavrsniRad.RezervacijeTermina.Data.Services
{
	public interface IEncryptionService
	{
		public string EncryptAndUrlEncode(string input);

		public string UrlDecodeAndDecrypt(string input);

		public string Encrypt(string input);

		public string Decrypt(string input);
	}
}