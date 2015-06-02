using CurveLock.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sodium;

namespace Tests
{
  /// <summary>
  ///This is a test class for KeyGenerationTest and is intended
  ///to contain all KeyGenerationTest Unit Tests
  ///</summary>
  [TestClass]
  public class KeyGenerationTest
  {
    /// <summary>
    ///A test for EncodePublicKey
    ///</summary>
    [TestMethod]
    public void EncodePublicKeyTest()
    {
      var publicKey = Sodium.Utilities.HexToBinary("34f066fa6957e569848e7d6d1faaa129fe43e7bb6b4047e1db34d4e09a9f4e51");
      const string EXPECTED = "Lqm2Foa9keELvGf8cYHJB3CRzEgPLuxJnBdtbZRbhuGmx3dhQB";

      var actual = KeyGeneration.EncodePublicKey(publicKey);

      Assert.AreEqual(EXPECTED, actual);
    }

    /// <summary>
    ///A test for ScryptGenerateKey
    ///</summary>
    [TestMethod]
    public void ScryptGenerateKeyTest()
    {
      const string EMAIL = "bob@example.com";
      const string PASSWORD = "bobIsGreat&1337!&sTuFf";
      var expected = new KeyPair(
        Sodium.Utilities.HexToBinary("65e520f7a800865b78551c7287b9f335d0c275c0bf7dddba3be1472f3a5b3954"),
        Sodium.Utilities.HexToBinary("d538276d5c58526d53111f78db799ad0acc2bc3010251acb3c12c719b2a2a19a"));

      var actual = KeyGeneration.ScryptGenerateKey(EMAIL, PASSWORD);
      CollectionAssert.AreEqual(expected.PrivateKey, actual.PrivateKey);
    }
  }
}