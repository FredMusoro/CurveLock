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
        Sodium.Utilities.HexToBinary("db5d2066285100fb2dc96a6af544cb1ec611c2fa178d5434382163a427572a7d"),
        Sodium.Utilities.HexToBinary("7c18a20b3fc73f110fd91d35771294c61994187d805ee2eb6dd2071ae09b4db9"));

      var actual = KeyGeneration.ScryptGenerateKey(EMAIL, PASSWORD);
      CollectionAssert.AreEqual(expected.PrivateKey, actual.PrivateKey);
    }
  }
}