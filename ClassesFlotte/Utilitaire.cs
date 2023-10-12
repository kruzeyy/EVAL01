﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFlotte
{
    public class Utilitaire : Vehicule
    {
        private int ptac;   // poids total autorisé en charge en kg
        private int pav;    // poids à vide en kg
        private int volume; // volume en m3

        /// <summary>
        /// Constructeur de la classe Utilitaire
        /// </summary>
        public Utilitaire(string marque, string modele, int carburant, int ptac, int pav, int volume)
        : base(marque, modele, carburant)
        {
            this.ptac = ptac;
            this.pav = pav;
            this.volume = volume;
        }



        /// <summary>
        /// Retourne un booléen indiquant si le vehicule utilitaire est à entretenir ou non
        /// un véhicule utilitaire doit être révisé tous les ans
        /// </summary>
        /// <returns>true si un entretien est à prévoir ou false dans le cas contraire</returns>
        public override bool PrevoirEntretien()
        {
            bool prevoirEnt = false;
            DateTime dateDernEnt = base.GetDernierEntretien().GetDateEntretien();
            DateTime dateActuelle = DateTime.Now;
            TimeSpan diffDates = dateActuelle.Subtract(dateDernEnt);
            if (diffDates.Days >= 360)
                prevoirEnt = true;
            return prevoirEnt;
        }

        /// <summary>
        /// Retourne la charge utile de l'utilitaire 
        /// (différence entre poids total en charge et poids à vide)
        /// </summary>
        /// <returns>charge utile en kg</returns>
        public int ChargeUtile()
        {
            return ptac - pav;
        }



    }
}
