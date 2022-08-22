﻿using System.Reflection;
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

        #region ConstructurTest

        [TestCase(
            TestName = "Constructor test."),
            Ignore("Can't get the same time by calling DateTime.Now() twice.")]
        public void TestConstructor()
        {
            Assert.That(_note.Title , Is.EqualTo("Без названия"));
            Assert.That(_note.Category , Is.EqualTo(NoteCategory.Work));
            var expectedTime = DateTime.Now;
            Assert.That(_note.CreationTime, Is.EqualTo(expectedTime));
            Assert.That(_note.LastModifyTime, Is.EqualTo(expectedTime));
            Assert.That(_note.NoteText , Is.EqualTo(""));
        }

        #endregion

        #region CloneTest

        [TestCase(
            TestName = "Test of method Clone()."),
            Ignore("Can't get the same time by calling DateTime.Now() twice.")]
        public void TestClone()
        {
            var note = (Note)_note.Clone();
            Assert.That(note, Is.Not.Null);
            Assert.That(note.Category, Is.EqualTo(_note.Category));
            Assert.That(note.CreationTime, Is.EqualTo(_note.CreationTime));
            Assert.That(note.LastModifyTime, Is.EqualTo(_note.LastModifyTime));
            Assert.That(note.NoteText, Is.EqualTo(_note.NoteText));
            Assert.That(note.Title, Is.EqualTo(_note.Title));
        }

        #endregion
    }
}