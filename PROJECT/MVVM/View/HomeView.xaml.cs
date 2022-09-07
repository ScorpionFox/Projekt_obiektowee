﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PROJECT.Entities;
using System.Diagnostics;

namespace PROJECT.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            Komunikat.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new MyDbContext())
                {
                    Klienci Klient = new Klienci();
                    // int last = db.Klienci.Count
                    Klient.Id = db.Klienci.Max() + 1;
                    Klient.Imie = ImieK.Text;
                    Klient.Nazwisko = NazwiskoK.Text;
                    Klient.IdTrener = int.Parse(IdTrener.Text);
                    Klient.IdRabat = int.Parse(IdRabat.Text);
                    Klient.IdKarnet = int.Parse(IdKarnet.Text);

                    db.Klienci.Add(Klient);
                    db.SaveChanges();
                    Komunikat.Text = "Dodano Pomyślnie";
                }
            }
            catch
            {
                Komunikat.Text = "Wystąpił błąd";
            }
        }
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        //    try
        //    {
        //        using (var db = new MyDbContext())
        //        {
        //            Klienci Klient = new Klienci();
        //            // int last = db.Klienci.Count
        //            Klient.Id = db.Klienci.Count() + 1;
        //            Klient.Imie = ImieK.Text;
        //            Klient.Nazwisko = NazwiskoK.Text;
        //            Klient.IdTrener = int.Parse(IdTrener.Text);
        //            Klient.IdRabat = int.Parse(IdRabat.Text);
        //            Klient.IdKarnet = int.Parse(IdKarnet.Text);

        //            db.Klienci.Add(Klient);
        //            db.SaveChanges();
        //            Komunikat.Text = "Dodano Pomyślnie";
        //        }
        //    }
        //    catch
        //    {
        //        Komunikat.Text = "Wystąpił błąd";
        //    }
        //}
    }
    }
}
