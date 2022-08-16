using System.Reflection;
using System.Runtime.InteropServices;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;
using Assert = NUnit.Framework.Assert;

namespace NoteAppTest
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;

        [SetUp]
        public void InitNote()
        {
            _note = new Note();
        }

        #region TitleTest

        
        [Test(
            Description = "Positive test for title getter.")]
        public void TestTitleGet_CorrectValue()
        {
            var expected = "TestTitle";
            _note.Title = expected;
            var actual = _note.Title;
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(
            "StringLengthIsOverThanFiftySymbolsStringLengthIsOve",
            "Title more over than 50 symbols.",
            TestName = "Negative test on set string with 51 length to title.")]
        public void TestTitleGet_ArgumentException(
            string wrongTitle, string message )
        {
            Assert.Throws<ArgumentException>
                (() => { _note.Title = wrongTitle; }, message);
        }
        
        [TestCase(
            "", "Title was not empty.",
            TestName = "Negative test on set empty string to title.")]
        [TestCase(
            null, 
            "Title was not null.",
            TestName = "Negative test on set null to title.")]
        public void TestTitleGet_ArgumentNullException(
            string wrongTitle, string message)
        {
            Assert.Throws<ArgumentNullException>(
                () => { _note.Title = wrongTitle; }, message);
        }
        
        #endregion
        
        #region CategoryTest

        [TestCase(
            TestName = "Positive test on setter for category.")]
        public void TestCategoryGet_CorrectValue()
        {
            var expected = NoteCategory.Documents;
            _note.Category = NoteCategory.Documents;
            Assert.That(expected, Is.EqualTo(_note.Category));
        }

        #endregion

        #region CreationTimeTest

        [TestCase(
            TestName = "Positive test for getter of creation time."),
            Ignore("Can't get the same time by calling DateTime.Now() twice.")]
        public void TestCreationTime_CorrectValue()
        {
            var expected = DateTime.Now;
            Assert.That(expected, Is.EqualTo(_note.CreationTime));
        }

        #endregion

        #region LastModifyTimeTest

        [TestCase(
            TestName = "Positive test on getter of last modify time."),
            Ignore("Can't get the same time by calling DateTime.Now() twice.")]
        public void TestLastModufyTime_CorrectValue()
        {
            var expected = DateTime.Now;
            Assert.That(expected, Is.EqualTo(_note.LastModifyTime));
        }

        #endregion

        #region NoteTextTest

        [TestCase(
            "Expected note text",
            TestName = "Positive test on getter of NoteText.")]
        public void TestNoteTextGet_CorrectValue(string expected)
        {
            _note.NoteText = expected;
            Assert.That(expected, Is.EqualTo(_note.NoteText));
        }

        [TestCase(
            null,
            TestName = "Negative test for setter of note text.")]
        public void TestNoteTextSet_ArgumentNullException(string expected)
        {
            Assert.Throws<ArgumentNullException>(
                () => _note.NoteText = expected);
        }

        #endregion
    }
}
