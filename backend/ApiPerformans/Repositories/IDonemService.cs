using ApiPerformans.Models.ApiModels;
using ApiPerformans.Models.DataModels;
using ApiPerformans.Models.ViewModels;

namespace ApiPerformans.Repositories
{
    public interface IDonemService
    {
        Task<ResponseDataModel> GetDonemler();

        Task<ResponseDataModel> GetDonem(int yil);

        Task<ResponseModel> AddDonem(DonemViewModel donem);

        Task<ResponseModel> UpdateDonem(int yil, DonemViewModel donem);

        Task<ResponseModel> DeleteDonem(int yil);

        public Task<bool> ExistsDonem(int yil);
    }
}