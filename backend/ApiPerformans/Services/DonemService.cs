using ApiPerformans.Models.ApiModels;
using ApiPerformans.Models.DataModels;
using ApiPerformans.Models.ViewModels;
using ApiPerformans.Repositories;
using AutoMapper;
using EntityLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiPerformans.Services
{
    public class DonemService : IDonemService
    {
        private readonly OraContext _context;
        private readonly IMapper _mapper;

        public DonemService(OraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ResponseDataModel> GetDonemler()
        {
            ResponseDataModel response = new();
            try
            {
                List<DonemDataModel> donemler = new();
                var data = await _context.PerfDonem.ToListAsync();
                if (data.Count == 0)
                {
                    response.IsSuccess = false;
                    response.Message = "No data found";
                    response.StatusCode = 404;
                    response.Data = null;
                    return response;
                }
                donemler = _mapper.Map<List<DonemDataModel>>(data);
                response.IsSuccess = true;
                response.Message = "Data found";
                response.StatusCode = 200;
                response.Data = donemler;
                return response;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                response.StatusCode = 500;
                response.Data = null;
                Console.WriteLine(ex.Message);
                return response;
            }
        }

        public async Task<ResponseDataModel> GetDonem(int yil)
        {
            ResponseDataModel response = new();
            if (yil == 0 || yil == null)
            {
                response.IsSuccess = false;
                response.Message = "Year cannot be null";
                response.StatusCode = 400;
                response.Data = null;
                return response;
            }
            try
            {
                List<DonemDataModel> donem = new();
                var data = await _context.PerfDonem.Where(x => x.Yil == yil).ToListAsync();
                if (data.Count == 0)
                {
                    response.IsSuccess = false;
                    response.Message = "No data found";
                    response.StatusCode = 404;
                    response.Data = null;
                    return response;
                }
                donem = _mapper.Map<List<DonemDataModel>>(data);
                response.IsSuccess = true;
                response.Message = "Data found";
                response.StatusCode = 200;
                response.Data = donem;
                return response;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                response.StatusCode = 500;
                response.Data = null;
                Console.WriteLine(ex.Message);
                return response;
            }
        }

        public async Task<ResponseModel> AddDonem(DonemViewModel donem)
        {
            ResponseModel response = new();
            if (donem == null)
            {
                response.IsSuccess = false;
                response.Message = "Data cannot be null";
                response.StatusCode = 400;
                return response;
            }
            try
            {
                var maxid = DBProcess.MaxIdBul("PERF_DONEM");
                if (maxid == 0)
                {
                    response.IsSuccess = false;
                    response.Message = "Max id not found";
                    response.StatusCode = 404;
                    return response;
                }
                string[] values = new[] { maxid.ToString(), donem.Yil.ToString(), "1", "sysdate", "1" };
                var sonuc = DBProcess.Insert("PERF_DONEM", new[] { "ID", "YIL", "DONEM", "TARIH", "DURUM" }, values);
                if (!sonuc)
                {
                    response.IsSuccess = false;
                    response.Message = "Data not added";
                    response.StatusCode = 404;
                    return response;
                }
                response.IsSuccess = true;
                response.Message = "Data added";
                response.StatusCode = 200;
                return response;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                response.StatusCode = 500;
                Console.WriteLine(ex.Message);
                return response;
            }
        }

        public async Task<ResponseModel> UpdateDonem(int yil, DonemViewModel donem)
        {
            ResponseModel response = new();
            if (donem == null)
            {
                response.IsSuccess = false;
                response.Message = "Data cannot be null";
                response.StatusCode = 400;
                return response;
            }
            try
            {
                var data = await _context.PerfDonem.Where(x => x.Yil == donem.Yil).FirstOrDefaultAsync();
                if (data == null)
                {
                    response.IsSuccess = false;
                    response.Message = "Data not found";
                    response.StatusCode = 404;
                    return response;
                }
                data.Yil = donem.Yil;
                data.Donem = donem.Donem;
                data.Tarih = donem.Tarih;
                data.Durum = donem.Durum;
                _context.PerfDonem.Update(data);
                await _context.SaveChangesAsync();
                response.IsSuccess = true;
                response.Message = "Data updated";
                response.StatusCode = 200;
                return response;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                response.StatusCode = 500;
                Console.WriteLine(ex.Message);
                return response;
            }
        }

        public async Task<ResponseModel> DeleteDonem(int yil)
        {
            ResponseModel response = new();

            if (yil == 0 || yil == null)
            {
                response.IsSuccess = false;
                response.Message = "Year cannot be null";
                response.StatusCode = 400;
                return response;
            }
            try
            {
                var data = await _context.PerfDonem.Where(x => x.Yil == yil).FirstOrDefaultAsync();
                if (data == null)
                {
                    response.IsSuccess = false;
                    response.Message = "Data not found";
                    response.StatusCode = 404;
                    return response;
                }

                _context.PerfDonem.Remove(data);
                await _context.SaveChangesAsync();
                response.IsSuccess = true;
                response.Message = "Data deleted";
                response.StatusCode = 200;
                return response;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
                response.StatusCode = 500;
                Console.WriteLine(ex.Message);
                return response;
            }
        }

        public async Task<bool> ExistsDonem(int yil)
        {
            var data = await _context.PerfDonem.Where(x => x.Yil == yil).AnyAsync();
            return data;
        }
    }
}