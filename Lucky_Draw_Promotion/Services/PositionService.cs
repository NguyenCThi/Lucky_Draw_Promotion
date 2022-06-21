using Lucky_Draw_Promotion.DTO;

namespace Lucky_Draw_Promotion.Services
{
    public class PositionService : IPositionService
    {
        private readonly DataContext _dataContext; 
        public PositionService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<int> CreateNewPosition(CreateNewPositionDTO request)
        {
            try
            {
                Position? position = new Position();
                position.PositionName = request.PositionName;
                _dataContext.Positions.Add(position);
                await _dataContext.SaveChangesAsync();
                return position.PositionId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }

        public async Task<int> DeletePosition(int positionId)
        {
            var position = await _dataContext.Positions.FindAsync(positionId);
            if(position == null)
            {
                return 0;
            }
            _dataContext.Positions.Remove(position);
            await _dataContext.SaveChangesAsync();
            return 1;
        }

        public async Task<int> EditPosition(int positionId, string positionName)
        {
            Position? position = await _dataContext.Positions.FindAsync(positionId);
            if (position == null)
            {
                return 0;
            }
            if(positionName != null)
                position.PositionName = positionName;
            _dataContext.Positions.Update(position);
            await _dataContext.SaveChangesAsync();
            return position.PositionId;
        }

        public async Task<List<Position>> GetAllPositionAsync()
        {
            var positions = await _dataContext.Positions.ToListAsync();
            return positions; 
        }

        public async Task<Position> GetPositionById(int positionId)
        {
            var position = await _dataContext.Positions.FindAsync(positionId);
            return position;
        }
    }
    public interface IPositionService
    {
        Task<List<Position>> GetAllPositionAsync();
        Task<Position> GetPositionById(int positionId);
        Task<int> CreateNewPosition(CreateNewPositionDTO request);
        Task<int> EditPosition(int positionId, string positionName);
        Task<int> DeletePosition (int positionId); 
    }
}
