using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tdd.Bibliotheque;

namespace RechercheVilleTest
{

    [TestFixture]
    public class RechercheVilleTest
    {
        private RechercheVille _rechercheville;
        //public void SetUp()
        //{
        //    _rechercheville = new RechercheVille();
        //}
        [Test]
        [TestCase("Paris")]
        [TestCase("Budapest")]
        [TestCase("Rotterdam")]
        [TestCase("Valence")]
        [TestCase("Vancouver")]
        [TestCase("Amsterdam")]
        [TestCase("Vienne")]
        [TestCase("Sydney")]
        [TestCase("New York")]
        [TestCase("Londres")]
        [TestCase("Bangkok")]
        [TestCase("Hong Kong")]
        [TestCase("Dubaï")]
        [TestCase("Rome")]
        [TestCase("Istanbul")]
        public void RechercheVilleTest_2_char(string mot)
        {
            RechercheVille rechercheVille = new RechercheVille(mot);
        }
        [Test]
        [TestCase("Paris")]
        [TestCase("Budapest")]
        [TestCase("Rotterdam")]
        [TestCase("Valence")]
        [TestCase("Vancouver")]
        [TestCase("Amsterdam")]
        [TestCase("Vienne")]
        [TestCase("Sydney")]
        [TestCase("New York")]
        [TestCase("Londres")]
        [TestCase("Bangkok")]
        [TestCase("Hong Kong")]
        [TestCase("Dubaï")]
        [TestCase("Rome")]
        [TestCase("Istanbul")]
        //Si le texte de recherche est égal ou supérieur à 2 caractères, il doit renvoyer tous les noms de ville commençant par le texte de recherche exact.
        public void RechercheVilleTest_2_ou_plusieurs_char(string mot)
        {
            // Arrange
            RechercheVille rechercheVille = new RechercheVille(mot);

            // Act & Assert
            rechercheVille.Rechercher("A");
            throw new DirectoryNotFoundException();

        }
    }
}

   

