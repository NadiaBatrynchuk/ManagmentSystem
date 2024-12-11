using DAL.Repositories.Impl;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly ManagementSystemContext _db;

        private UserRepository _userRepository;
        private RoleRepository _roleRepository;
        private TaskRepository _taskRepository;
        private TaskPriorityRepository _taskPriorityRepository;
        private TaskCategoryRepository _taskCategoryRepository;
        private UserTaskRepository _userTaskRepository;

        public EFUnitOfWork(DbContextOptions<ManagementSystemContext> options)
        {
            _db = new ManagementSystemContext(options);
        }

        public IUserRepository Users
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_db);
                return _userRepository;
            }
        }

        public IRoleRepository Roles
        {
            get
            {
                if (_roleRepository == null)
                    _roleRepository = new RoleRepository(_db);
                return _roleRepository;
            }
        }

        public ITaskRepository Tasks
        {
            get
            {
                if (_taskRepository == null)
                    _taskRepository = new TaskRepository(_db);
                return _taskRepository;
            }
        }

        public ITaskPriorityRepository TaskPriorities
        {
            get
            {
                if (_taskPriorityRepository == null)
                    _taskPriorityRepository = new TaskPriorityRepository(_db);
                return _taskPriorityRepository;
            }
        }

        public ITaskCategoryRepository TaskCategories
        {
            get
            {
                if (_taskCategoryRepository == null)
                    _taskCategoryRepository = new TaskCategoryRepository(_db);
                return _taskCategoryRepository;
            }
        }

        public IUserTaskRepository UserTasks
        {
            get
            {
                if (_userTaskRepository == null)
                    _userTaskRepository = new UserTaskRepository(_db);
                return _userTaskRepository;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
