using Final.Models;

namespace Final.Repository
{
    public class TemplatesRepository : ITemplatesRepository
    {
        Context context;
        public TemplatesRepository(Context context)
        {
            this.context = context;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CvTemplate> GetAll()
        {
            throw new NotImplementedException();
        }

        public CvTemplate GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(CvTemplate Temp)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, CvTemplate Temp)
        {
            throw new NotImplementedException();
        }
    }
}
