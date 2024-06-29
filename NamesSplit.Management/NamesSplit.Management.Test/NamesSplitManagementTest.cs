using NamesSplit.Management.Test;

namespace NamesSplit.Management.Test
{
    public class NamesSplitManagementTest
    {
        public static IEnumerable<object[]> GetSplitNameData()
        {
            yield return new object[] { "Juan Fernando Pérez del Corral", new string[] { "juan", "fernando", "pérez del corral" } };
            yield return new object[] { "Ana María López", new string[] { "ana", "maría", "lópez" } };
            yield return new object[] { "Carlos Alberto", new string[] { "carlos", "alberto" } };
            yield return new object[] { "Mentor Eduardo González Martínez del Río", new string[] { "mentor", "eduardo", "gonzález", "martínez del río" } };
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