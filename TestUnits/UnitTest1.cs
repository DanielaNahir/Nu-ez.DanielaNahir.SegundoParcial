using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnits
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void AgregarMascotaVeterinaria()
        {
            Veterinaria vete = new Veterinaria();
            Gato gato = new Gato();
            Perro perro = new Perro();
            Exotico exotico = new Exotico();

            vete += gato;
            vete += perro;
            vete += exotico;

            Assert.AreEqual(vete.ListaMascotas.Count(), 3);
        }

        [TestMethod]
        public void VerificarIgualdadGatos()
        {
            Gato gato1 = new Gato("lolo", 4, "jj", "kk", ERazaGato.Persa, true);
            Gato gato2 = new Gato("lolo", 4, "jj", "kk", ERazaGato.Persa, true);


            Assert.IsTrue(gato1 == gato2);
        }

        [TestMethod]
        [ExpectedException(typeof(EspacioInternacionException))]
        public void AgregarInternacionExeption()
        {
            Veterinaria v = new Veterinaria();
            v.CapacidadInternaciones = 1;

            Exotico ex = new Exotico("juan", 5, "ll", "pp", EExotico.Cobayo, EAlimento.Especial);
            Gato gato = new Gato("lolo", 4, "jj", "kk", ERazaGato.Persa, true);

            v.AgregarMascotaInternacion(ex);
            v.AgregarMascotaInternacion(gato);
            
        }

        [TestMethod]
        public void VerificarDiferenciaMascotas()
        {
            Veterinaria v = new Veterinaria();
            v.CapacidadInternaciones = 1;

            Exotico ex = new Exotico("lolo", 4, "jj", "kk", EExotico.Cobayo, EAlimento.Especial);
            Gato gato = new Gato("lolo", 4, "jj", "kk", ERazaGato.Persa, true);

            Assert.IsFalse(ex == gato);
        }
    }
}