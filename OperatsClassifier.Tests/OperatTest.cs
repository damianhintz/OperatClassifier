using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperatsClassifier.Domain;
using Shouldly;

namespace OperatsClassifier.Tests
{
    [TestClass]
    public class OperatTest
    {
        [TestMethod]
        public void TestOperatPathShouldNullOrEmpty()
        {
            var operat = new Operat();
            operat.Path.ShouldBeNullOrEmpty();
            //var loader = new OperatLoader(operat);
            //operat.Status.ShouldBe(Loading)
            //loader.ImportFromPath(path: "path"); -> import files, create json file
            //operat.Status.ShouldBe(Open)
            //loader.SyncWithPath() -> added, deleted/renamed files
            //operat.Status.ShouldBe(Syncing)
            //operat.Path.ShouldExist
            //opeat.Path.ShouldHaveReadWriteRights
            //operat.Path.SholdyBe("path");
            //operat.Files.ShouldBe(10)
            //operat.Types.ShouldBe(unknown);
            //var operatRenamer = new OperatRenamer(operat);
            //operat.Status.ShouldBe(Locked)
            //renamer.RenameFiles().ShouldBe(10);
            //operat.LockForRename() -> create lock file
            //operat.UnlockForRename() -> delete lock file
            //operat.Status.ShoulBe(Closed)
        }

        [TestMethod]
        public void TestOperatStateShouldBeUnkown()
        {
            var operat = new Operat();
            operat.State.ShouldBe(OperatState.Unknown);
        }

        [TestMethod]
        public void TestOperatFilesShouldBeEmpty()
        {
            var operat = new Operat();
            operat.State.ShouldBe(OperatState.Unknown);
        }
    }
}
