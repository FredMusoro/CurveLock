using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Sodium;
using StreamCryptor;
using StreamCryptor.Model;

namespace CurveLock.Core
{
  public static class MessageCrypto
  {
    private const int ID_VERSION = 0x0A;

    public static byte[] EncryptMessage(byte[] message, string toId)
    {
      //generate an ephemeral key to encrypt this with
      var key = PublicKeyBox.GenerateKeyPair();

      //decode the recip ID
      var recip = Base58Check.Base58CheckEncoding.Decode(toId);

      //Check to make sure that the ID version is supported
      if (recip[0] != ID_VERSION)
      {
        throw new CryptographicException("Invalid ID Format.");
      }

      var nonce = SodiumCore.GetRandomBytes(24);
      var encrypted = PublicKeyBox.Create(message, nonce, key.PrivateKey, ArrayHelpers.SubArray(recip, 1));
      var recipVerifier = GenericHash.Hash(ArrayHelpers.ConcatArrays(nonce, key.PublicKey), null, 16);
      var version = new byte[] {0x00};

      var final = ArrayHelpers.ConcatArrays(version, nonce, key.PublicKey, recipVerifier, encrypted);

      return final;
    }

    public static byte[] DecryptMessage(byte[] message, KeyPair key)
    {
      const int VERSION_LENGTH = 1;
      const int NONCE_LENGTH = 24;
      const int SENDER_KEY_LENGTH = 32;
      const int RECIP_VERIFIER_LENGTH = 16;

      var version = ArrayHelpers.SubArray(message, 0, VERSION_LENGTH)[0];
      byte[] ret;

      switch (version)
      {
        case 0x00:
          var nonce = ArrayHelpers.SubArray(message, 1, NONCE_LENGTH);
          var senderKey = ArrayHelpers.SubArray(message, 25, SENDER_KEY_LENGTH);
          var verifier = ArrayHelpers.SubArray(message, 57, RECIP_VERIFIER_LENGTH);
          var encrypted = ArrayHelpers.SubArray(message, 73);

          //check the verifier, to make sure that the message is for this KeyPair before going on
          var recipVarifier = GenericHash.Hash(ArrayHelpers.ConcatArrays(nonce, key.PublicKey), null, 16);
          if (Utilities.ByteArrayCompare(verifier, recipVarifier))
          {
            throw new CryptographicException("Invalid verifier; message not encrypted for this key.");
          }

          var decrypted = PublicKeyBox.Open(encrypted, nonce, key.PrivateKey, senderKey);
          ret = decrypted;

          break;
        default:
          //TODO: Unsupported version
          throw new NotImplementedException();
      }

      return ret;
    }

    public static async Task EncryptFile(string path, string toId, IProgress<StreamCryptorTaskAsyncProgress> prg)
    {
      //generate an ephemeral key to encrypt this with
      var key = PublicKeyBox.GenerateKeyPair();

      //decode the recip ID
      var recip = Base58Check.Base58CheckEncoding.Decode(toId);

      //Check to make sure that the ID version is supported
      if (recip[0] != ID_VERSION)
      {
        throw new CryptographicException("Invalid ID Format.");
      }

      await Cryptor.EncryptFileWithStreamAsync(key, ArrayHelpers.SubArray(recip, 1), path, 
        fileExtension: ".CurveLock", encryptionProgress: prg);
    }

    public static async Task DecryptFile(string file, KeyPair key, IProgress<StreamCryptorTaskAsyncProgress> prg)
    {
      var path = Path.GetDirectoryName(file);
      await Cryptor.DecryptFileWithStreamAsync(key, file, path, prg);
    }
  }
}
