﻿using System;
using AnhShop.Data.Infrastructure;
using AnhShop.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnhShop.Model.Models;
using System.Linq;

namespace AnhShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;
        [TestInitialize] 
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory); 
        }
        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            //var list = objRepository.GetAll().ToList();
            //Assert.AreEqual(2, list.Count);
        }
        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test cate";
            category.Alias = "Test";
            category.Status = true;

            var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}