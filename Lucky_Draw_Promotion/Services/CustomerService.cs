using Lucky_Draw_Promotion.DTO;

namespace Lucky_Draw_Promotion.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly DataContext _context;
        public CustomerService(DataContext context)
        {
            _context = context;
        }

        public async Task<int> CreateNewCustomer(CreateCustomerDTO request)
        {
            try
            {
                Customer customer = new Customer();
                if(request.Block == null)
                {
                    customer.Block = request.Block;
                }
                else
                {
                    customer.Block = false;
                }
                customer.Fullname = request.CustomerName;
                customer.PhoneNumber = request.PhoneNumber;
                customer.DateOfBirth = request.DateOfBirth;
                customer.Location = request.Location;
                customer.PositionId = request.PositionId;
                customer.TOBId = request.TypeOfBusinessId;
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                return customer.CustomerId;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public async Task<int> EditCustomerInfo(int customerId, EditCustomerDTO request)
        {
            Customer? customer = await _context.Customers.FindAsync(customerId);
            if(customer == null)
            {
                return 0;
            }
            if (request.Fullname != null)
                customer.Fullname = request.Fullname;
            if (request.PhoneNumber != null)
                customer.PhoneNumber = request.PhoneNumber;
            if (request.DateOfBirth != null)
                customer.DateOfBirth = request.DateOfBirth;
            if (request.Location != null)
                customer.Location = request.Location;
            if (request.TOBId != null)
                customer.TOBId = request.TOBId;
            if (request.PositionId != null)
                customer.PositionId = request.PositionId;
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
            return customer.CustomerId;

        }

        public async Task<List<Customer>> GetAllCustomer()
        {
            var customer = await _context.Customers.ToListAsync();
            return customer;
        }

        public async Task<CustomerViewDTO> GetCustomerById(int customerId)
        {
            var customer = await _context.Customers.FindAsync(customerId);
            if( customer == null)
            {
                CustomerViewDTO customerViewDTO = new CustomerViewDTO();
                return customerViewDTO;
            }
            CustomerViewDTO customerViewDTO1 = new CustomerViewDTO();
            customerViewDTO1.Id = customer.CustomerId;
            customerViewDTO1.Name = customer.Fullname;
            customerViewDTO1.PhoneNumber = customer.PhoneNumber;
            customerViewDTO1.DateOfBirth = String.Format("{0:MM/dd/yyyy}", customer.DateOfBirth);
            var tobCustomer = await _context.TypeOfBusinesses.FindAsync(customer.TOBId);
            customerViewDTO1.TypeOfBusiness = tobCustomer.TOBName;
            customerViewDTO1.Location = customer.Location;
            customerViewDTO1.Block = customer.Block;
            return customerViewDTO1;
        }

        public async Task<int> IsBlockCustomer(int customerId)
        {
            Customer? customer = await _context.Customers.FindAsync(customerId);
            if (customer == null)
            {
                return 0;
            }

            if(customer.Block == false)
            {
                customer.Block = true;
            }
            else
            {
                customer.Block = false;
            }
            
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
            return customer.CustomerId;
        }

        

        public Task<List<Customer>> SearchCustomerByName(string customerName)
        {
            var customers = _context.Customers.Where(x => x.Fullname.ToLower().Contains(customerName.ToLower().Trim())).ToList();
            return Task.FromResult(customers);
        }
    }
    public interface ICustomerService
    {
        Task<CustomerViewDTO> GetCustomerById(int customerId);
        Task<List<Customer>> GetAllCustomer();
        Task<List<Customer>> SearchCustomerByName(string customerName);
        Task<int> CreateNewCustomer(CreateCustomerDTO customer);
        Task<int> IsBlockCustomer(int customerId);
        Task<int> EditCustomerInfo(int customerId, EditCustomerDTO request);
        
    }
}
