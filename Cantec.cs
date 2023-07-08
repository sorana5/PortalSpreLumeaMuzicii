﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalSpreLumeaMuzicii
{
    public class Cantec
    {
        public bool _cantat;
        public int _nrPortative;
        public List<List<int>> _note = new List<List<int>>();
        public string _titlu;

        public bool Cantat
        { get { return _cantat; } set { _cantat = value; } }

        public List < List <int>> Note
        { get { return _note; } set { _note = value; } }

        public string Titlu
        { get { return _titlu; } set { _titlu = value; } }

        public int NrPortative
        { get { return _nrPortative; } set { _nrPortative = value; } }

        public Cantec(string titlu, int nrPortative, List<List<int>> note)
        {
            Titlu = titlu;
            NrPortative = nrPortative;
            Note = note;
        }
    }
}