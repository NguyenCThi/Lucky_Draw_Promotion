namespace Lucky_Draw_Promotion.Services
{
    public class TypeOfBusinessService : ITypeOfBusinessService
    {
        private readonly DataContext _dataContext;
        public TypeOfBusinessService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<int> CreateNewTOB(string tobName)
        {
            try
            {
                TypeOfBusiness? tob = new TypeOfBusiness();
                tob.TOBName = tobName;
                _dataContext.TypeOfBusinesses.Add(tob);
                await _dataContext.SaveChangesAsync();
                return tob.TOBId;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }  
        }

        public async Task<int> DeleteTOB(int id)
        {
            TypeOfBusiness? tob = await _dataContext.TypeOfBusinesses.FindAsync(id);
            if(tob == null)
            {
                return 0;
            }
            _dataContext.TypeOfBusinesses.Remove(tob);
            await _dataContext.SaveChangesAsync();
            return 1;
        }

        public async Task<int> EditTOB(int id, string tobName)
        {
            TypeOfBusiness? tob = await _dataContext.TypeOfBusinesses.FindAsync(id);
            if(tob == null)
            {
                return 0;
            }
            if (tobName != null)
                tob.TOBName = tobName;
            _dataContext.TypeOfBusinesses.Update(tob);
            await _dataContext.SaveChangesAsync();
            return tob.TOBId;
        }

        public async Task<List<TypeOfBusiness>> GetTypeOfBusinessAll()
        {
            var tobs = await _dataContext.TypeOfBusinesses.ToListAsync();
            return tobs;
        }

        public async Task<TypeOfBusiness> GetTypeOfBusinessById(int id)
        {
            var business = await _dataContext.TypeOfBusinesses.FindAsync(id);
            return business;
        }
    }
    public interface ITypeOfBusinessService
    {
        Task<List<TypeOfBusiness>> GetTypeOfBusinessAll();
        Task<TypeOfBusiness> GetTypeOfBusinessById(int id);
        Task<int> CreateNewTOB(string tobName);
        Task<int> EditTOB(int id, string tobName);
        Task<int> DeleteTOB(int id);
    }
}
