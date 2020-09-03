using System;
using UnitTesting;
using Xunit;

namespace LibraryTests
{
    public class UnitTest1
    {
        [Fact]
        public void Library_Tests()
        {
            Library<string> library = new Library<string>();

            Assert.Empty(library);
        }

        [Fact]
        public void Can_add_to_library()
        {
            Library<string> library2 = new Library<string>();


            library2.Add("Hi");
            library2.Add("how");
            library2.Add("are");
            library2.Add("you");

            Assert.Equal(new[] { "Hi", "how", "are", "you"}, library2);
        }

        [Fact]
        public void Library_can_remove()
        {
            // Arange
            Library<string> removeLibrary = new Library<string>();
            removeLibrary.Add("book");
            removeLibrary.Add("GoT");
            // Act
            bool result = removeLibrary.RemoveBook(0);
            // Assert
            Assert.True(result);
            Assert.Equal(new[] { "GoT" }, removeLibrary);
        }
    }
}
