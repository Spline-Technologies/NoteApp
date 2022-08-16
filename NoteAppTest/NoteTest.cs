using System.Reflection;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;

namespace NoteAppTest
{
    [TestFixture]
    public class NoteTest
    {
        private Note note;
        #region TitleTest

        
        [Test(Description = "Positive test for title getter.")]
        public void TestTitleGet_CorrectValue()
        {
            note = new Note();
            var expected = "TestTitle";
            note.Title = expected;
            var actual = note.Title;
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase("StringLengthIsOverThanFiftySymbolsStringLengthIsOve",
            "Title more over than 50 symbols.",
            TestName = "Negative test on set string with 51 length to title.")]
        public void TestTitleGet_ArgumentException(
            string wrongTitle, string message )
        {
            var note = new Note();
            Assert.Throws<ArgumentException>
                (() => { note.Title = wrongTitle; }, message);
        }
        
        [TestCase("", "Title was not empty.",
            TestName = "Negative test on set empty string to title.")]
        [TestCase(null, "Title was not null.",
            TestName = "Negative test on set null to title.")]
        public void TestTitleGet_ArgumentNullException(
            string wrongTitle, string message)
        {
            var note = new Note();
            Assert.Throws<ArgumentNullException>(
                () => { note.Title = wrongTitle; }, message);
        }
        
        #endregion

    }
}
