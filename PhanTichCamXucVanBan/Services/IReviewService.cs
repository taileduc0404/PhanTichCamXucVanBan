using PhanTichCamXucVanBan.Models;
using PhanTichCamXucVanBan.ViewModels;

namespace PhanTichCamXucVanBan.Services
{
    public interface IReviewService
    {
        void AddReview(CamXucVM camxuc, bool haiLong);
        //void AddReview(CamXuc camxuc, bool isRatHaiLong, bool isKhaHaiLong, bool isHaiLong, bool isRatKhongHaiLong, bool isKhongHaiLong, bool isThatVong);;

    }
}
