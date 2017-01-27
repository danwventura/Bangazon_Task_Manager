﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BangazonAPI.Providers.Models;

namespace BangazonAPI.DAL
{
    public class ChoreRepository
    {
        public ChoreManagerContext Context { get; set; }
        public ChoreRepository(ChoreManagerContext _context)
        {
            Context = _context;
        }
        public ChoreRepository() {
            Context = new ChoreManagerContext();
        }

        public void AddNewTask(Chore chore)
        {
            Context.Chores.Add(chore);
            Context.SaveChanges();
        }

        public List<Chore> GetAllChores()
        {
            return Context.Chores.ToList();
        }

        public void DeleteTask(int choreId)
        {
            Chore found_chore = Context.Chores.FirstOrDefault(c => c.ChoreID == choreId);
            Context.Chores.Remove(found_chore);
            Context.SaveChanges();
        }
    }
}