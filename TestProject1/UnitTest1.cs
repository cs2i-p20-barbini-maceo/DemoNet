using demoNet;

namespace TestProject1

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p = new Personne("Barbini", "Macéo");
            Assert.AreEqual("Barbini", p.Nom);
            Assert.AreEqual("Macéo", p.Prenom);


        }
    }
}
