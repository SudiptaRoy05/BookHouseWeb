﻿using BookHouse.DataAccess.Repository.IRepository;
using BookHouse.Models;
using BookHouseWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHouse.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDBContext _db;
        public CoverTypeRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
        public void Update(CoverType obj)
        {
            _db.CoverTypes.Update(obj);
        }

    }
}
