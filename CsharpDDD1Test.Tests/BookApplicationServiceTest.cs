using System;
using System.Collections.Generic;
using CsharpDDD1.ApplicationService.Services;
using CsharpDDD1.Domain.Entities;
using CsharpDDD1.Domain.Exceptions;
using CsharpDDD1.Domain.Helpers;
using CsharpDDD1.Domain.Repositories;
using CsharpDDD1.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CsharpDDD1Test.Tests
{
    [TestClass]
    public class BookApplicationServiceTest
    {
        [TestMethod]
        public void BookApplicationService_データ取得シナリオ()
        {
            var bookRepositoryMock = new Mock<IBookRepository>();

            var dummyBooks = new List<BookEntity>()
            {
                new BookEntity("00001","書籍A","2019/06/14 13:00".ToDate()),
                new BookEntity("00002","書籍B", "2019/06/13".ToDate())
            };

            bookRepositoryMock.Setup(x => x.GetData()).Returns(dummyBooks);

            var bookService = new BookApplicationService(bookRepositoryMock.Object);

            var bookList = bookService.GetData();

            bookList.Count.Is(2);
            bookList[0].Name.Is("書籍A");
            bookList[0].PurchasedDate.DisplayValue.Is("2019年06月14日");
            bookList[1].Name.Is("書籍B");
            bookList[1].PurchasedDate.DisplayValue.Is("2019年06月13日");

        }

        [TestMethod]
        public void BookApplicationService_データ登録シナリオ()
        {

            var viewModelMock = new Mock<BookSaveViewModel>() { CallBase = true }; //CallBase trueの設定を忘れずにする
            viewModelMock.Setup(x => x.GetDatetime()).Returns("2019/01/01".ToDate()); //現在時刻を取得する処理をSetup内で上書きし固定値を設定する
            var viewModel = viewModelMock.Object;
            viewModel.BookName = "書籍A";
            

            var bookRepositoryMock = new Mock<IBookRepository>();
            bookRepositoryMock.Setup(x => x.SaveData(It.IsAny<BookEntity>()))
                .Callback<BookEntity>(saveValue =>
                {
                    saveValue.Name.Is("書籍A");
                    saveValue.PurchasedDate.Is("2019/01/01".ToDate());
                });

            var bookService = new BookApplicationService(bookRepositoryMock.Object);
            bookService.SaveData(viewModel.BookName, viewModel.PurchasedDate);

            bookRepositoryMock.VerifyAll(); //テスト未通過があればNGとなる
        }

        [TestMethod]
        public void BookApplicationService_データ登録シナリオ_エラーチェック()
        {
            var viewModelMock = new Mock<BookSaveViewModel>() { CallBase = true };
            viewModelMock.Setup(x => x.GetDatetime()).Returns("2019/01/01".ToDate());
            var viewModel = viewModelMock.Object;
            viewModel.BookName = "";

            var bookRepositoryMock = new Mock<IBookRepository>();
            var bookService = new BookApplicationService(bookRepositoryMock.Object);

            var ex = AssertEx.Throws<MessageException>(() => bookService.SaveData(viewModel.BookName, viewModel.PurchasedDate));
            ex.Message.Is("書籍名が空欄です。");

        }
    }
}
