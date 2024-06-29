using NamesSplit.Management.Test;

namespace NamesSplit.Management.Test
{
    public class NamesSplitManagementTest
    {
        public static IEnumerable<object[]> GetSplitNameData()
        {
            yield return new object[] { "Juan Fernando P�rez del Corral", new string[] { "juan", "fernando", "p�rez del corral" } };
            yield return new object[] { "Ana Mar�a L�pez", new string[] { "ana", "mar�a", "l�pez" } };
            yield return new object[] { "Carlos Alberto", new string[] { "carlos", "alberto" } };
            yield return new object[] { "Mentor Eduardo Gonz�lez Mart�nez del R�o", new string[] { "mentor", "eduardo", "gonz�lez", "mart�nez del r�o" } };
        }

        [Theory]
        [MemberData(nameof(GetSplitNameData))]
        public void ShouldGetNames(string fullname, string[] expected)
        {
            // arrange
            NamesSplitManagement management = new();
            // act
            string[] names = management.GetNames(fullname);
            // assert
            Assert.Equal(expected, names);
        }
    }
}