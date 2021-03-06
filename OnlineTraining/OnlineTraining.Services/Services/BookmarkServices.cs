﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OnlineTraining.Entities.Entities;
using OnlineTraining.Repositories.Interfaces;
using OnlineTraining.Services.Interfaces;

namespace OnlineTraining.Services.Services
{
    public class BookmarkServices: IBookmarkServices
    {

        private readonly IBookmarkRepository _bookmarkRepository;

        public BookmarkServices(IBookmarkRepository bookmarkRepository)
        {
            _bookmarkRepository = bookmarkRepository;
        }
        public async Task<List<Bookmark>> GetBookMarkByUserId(string userId)
        {
            return await _bookmarkRepository.GetBookMarkByUserId(userId);
        }

        public async Task<bool> BookmarkCourse(string courseId, string userId)
        {
            return await _bookmarkRepository.BookmarkCourse(courseId, userId);
        }

        public async Task<bool> UnBookmarkCourse(string courseId, string userId)
        {
            return await _bookmarkRepository.UnBookmarkCourse(courseId, userId);
        }

        public async Task<List<Course>> GetCourseBookMarkByUserId(string userId)
        {
            return await _bookmarkRepository.GetCourseBookMarkByUserId(userId);
        }
    }
}
