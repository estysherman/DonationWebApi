using DonationApi.Models;

namespace DonationApi.Repositories
{
    public class TrumaRepository : ITrumaRepository
    {
        public static List<Truma> TrumotList = new List<Truma>() { };
        //{
        //    new Truma()
        //    {
        //        Id = 1, ShemYeshutMedinitZara = "ישות 1", SugYeshutMedinitZara = 1, 
        //        Yeud="יעוד 1", Schum= 1000, SugMatbea = 1, ShaarHamara = 4, Tnaim="תנאי 1"
        //    },
        //    new Truma()
        //    {
        //        Id = 2, ShemYeshutMedinitZara = "ישות 2", SugYeshutMedinitZara = 2,
        //        Yeud="יעוד 2", Schum= 2000, SugMatbea = 2, ShaarHamara = 2, Tnaim="תנאי 2"
        //    },
        //    new Truma()
        //    {
        //        Id = 3, ShemYeshutMedinitZara = "ישות 3", SugYeshutMedinitZara = 3,
        //        Yeud="יעוד 3", Schum= 3000, SugMatbea = 1, ShaarHamara = 4, Tnaim="תנאי 3"
        //    }
        //};


        public List<Truma> GetTrumot()
        {
            return TrumotList;
        }

        public Truma InsertTruma(Truma truma)
        {
            truma.Id = TrumotList.Count() + 1;
            TrumotList.Add(truma);

            //check scuhm and send email 

            return TrumotList.ElementAt(truma.Id - 1);
        }

        public Truma UpdateTruma(Truma truma)
        {
            var trumaToUpdate = TrumotList.FirstOrDefault(x => x.Id == truma.Id);

            if (trumaToUpdate != null)
            {
                trumaToUpdate.Id = truma.Id;
                trumaToUpdate.ShemYeshutMedinitZara = truma.ShemYeshutMedinitZara;
                trumaToUpdate.Schum = truma.Schum;
                trumaToUpdate.SugYeshutMedinitZara = truma.SugYeshutMedinitZara;
                trumaToUpdate.Yeud = truma.Yeud;
                trumaToUpdate.Tnaim = truma.Tnaim;
                trumaToUpdate.SugMatbea = truma.SugMatbea;
                trumaToUpdate.ShaarHamara = truma.ShaarHamara;

                //check scuhm and send email                
            }

            return trumaToUpdate;
        }
    }
}
