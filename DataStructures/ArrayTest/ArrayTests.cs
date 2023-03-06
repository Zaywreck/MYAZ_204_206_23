namespace ArrayTest
{
    public class ArrayTests
    {
        [Fact]
        public void Array_Count_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add("Mert");
            array.Add("Sena");

            // Act
            int count = array.Count;

            //
            Assert.Equal(2, count);
        }
        [Fact]
        public void Array_Add_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add("Mert");
            array.Add("Sena");
            array.Add("Sena Nur");
            array.Add("Sena Gülle");
            array.Add("Mert Gülle");

            // Act
            int count = array.Count;

            //
            Assert.Equal(5, count);
            Assert.Equal(8, array.Capacity);

        }
    }
}