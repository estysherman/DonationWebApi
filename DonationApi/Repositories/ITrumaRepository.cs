using DonationApi.Models;

namespace DonationApi.Repositories
{
    public interface ITrumaRepository
    {
        public List<Truma> GetTrumot();
        public Truma UpdateTruma(Truma truma);
        public Truma InsertTruma(Truma truma);
    }
}
