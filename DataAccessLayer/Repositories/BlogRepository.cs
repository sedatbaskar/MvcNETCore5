﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
  //public  class BlogRepository : IBlogDal
  //  {
  //      public void AddBlog(Blog blog)
  //      {
  //          using var c = new Context();
  //          c.Add(blog);
  //      }

  //      public void Delete(Blog t)
  //      {
  //          throw new NotImplementedException();
  //      }

  //      public void DeleteBlog(Blog blog)
  //      {
  //          using var c = new Context();
  //          c.Remove(blog);
  //          c.SaveChanges();
  //      }

  //      public Blog GetById(int id)
  //      {
  //          using var c = new Context();
  //          return c.Blogs.Find(id);
  //      }

  //      public Blog GetByID(int id)
  //      {
  //          throw new NotImplementedException();
  //      }

  //      public List<Blog> GetListAll()
  //      {
  //          throw new NotImplementedException();
  //      }

  //      public List<Blog> GetListAll(Expression<Func<Blog, bool>> filter)
  //      {
  //          throw new NotImplementedException();
  //      }

  //      public List<Blog> GetListWithCategory()
  //      {
  //          throw new NotImplementedException();
  //      }

  //      public List<Blog> GetListWithCategoryByWriter(int id)
  //      {
  //          throw new NotImplementedException();
  //      }

  //      public void Insert(Blog t)
  //      {
  //          throw new NotImplementedException();
  //      }

  //      public List<Blog> ListAllBlog()
  //      {
  //          using var c = new Context();
  //          return c.Blogs.ToList();
  //      }

  //      public void Update(Blog t)
  //      {
  //          throw new NotImplementedException();
  //      }

  //      public void UpdateBlog(Blog blog)
  //      {
  //          using var c = new Context();
  //          c.Update(blog);
  //          c.SaveChanges();
  //      }
  //  }
}
