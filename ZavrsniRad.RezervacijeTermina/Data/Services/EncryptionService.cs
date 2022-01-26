using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Web;
using ZavrsniRad.RezervacijeTermina.Data.Infrastructure;

namespace ZavrsniRad.RezervacijeTermina.Data.Services
{
	public class EncryptionService : IEncryptionService
	{
		#region Fields

		private readonly EncryptionSettings _encryptionSettings;

		#endregion

		#region Constructors

		public EncryptionService(IConfiguration configuration)
		{
			_encryptionSettings = configuration.GetSection(nameof(EncryptionSettings)).Get<EncryptionSettings>();
		}

		#endregion

		#region Public Methods

		public string UrlDecodeAndDecrypt(string input)
		{
			var urlDecodedinput = HttpUtility.UrlDecode(input);

			return Decrypt(urlDecodedinput);
		}

		public string EncryptAndUrlEncode(string input)
		{
			var encryptedInput = Encrypt(input);

			return HttpUtility.UrlEncode(encryptedInput);
		}

		public string Decrypt(string secret)
		{
			var aes = Aes.Create();
			aes.Key = Convert.FromBase64String(_encryptionSettings.SecretKey);

			using (var memoryStream = new MemoryStream(Convert.FromBase64String(secret)))
			{
				using (var cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(Convert.FromBase64String(_encryptionSettings.SecretKey), Convert.FromBase64String(_encryptionSettings.InitializationVector)), CryptoStreamMode.Read))
				{
					using (var streamReader = new StreamReader(cryptoStream))
					{
						return streamReader.ReadToEnd();
					}
				}
			}
		}

		public string Encrypt(string data)
		{
			var aes = Aes.Create();
			aes.Key = Convert.FromBase64String(_encryptionSettings.SecretKey);
			aes.IV = Convert.FromBase64String(_encryptionSettings.InitializationVector);

			using (var msEncrypt = new MemoryStream())
			{
				using (var csEncrypt = new CryptoStream(msEncrypt, aes.CreateEncryptor(aes.Key, aes.IV), CryptoStreamMode.Write))
				{
					using (var swEncrypt = new StreamWriter(csEncrypt))
					{
						swEncrypt.Write(data);
					}

					return Convert.ToBase64String(msEncrypt.ToArray());
				}
			}
		}

		#endregion
	}
}