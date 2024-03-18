using PhanTichCamXucVanBan.Data;
using PhanTichCamXucVanBan.Models;
using PhanTichCamXucVanBan.ViewModels;

namespace PhanTichCamXucVanBan.Services
{
    public class ReviewService : IReviewService
    {
        private readonly ApplicationDbContext _dbContext;

        public ReviewService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddReview(CamXucVM vm, bool haiLong)
        {
            var camxuc = new CamXuc
            {
                KhongGian = vm.KhongGian,
                ThaiDo = vm.ThaiDo,
                ThucAn = vm.ThucAn,
                HaiLong = haiLong
            };
            _dbContext.camXucs.Add(camxuc);
            _dbContext.SaveChanges();
        }
    }
}
