using Microsoft.AspNetCore.Mvc;
using PhanTichCamXucVanBan.Models;
using PhanTichCamXucVanBan.Services;
using PhanTichCamXucVanBan.ViewModels;
using System;

namespace PhanTichCamXucVanBan.Controllers
{
    public class CamXucController : Controller
    {
        private readonly IReviewService _reviewService;

        public CamXucController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PredictSentiment(CamXucVM vm)
        {
            var sampleData = new MLModel.ModelInput()
            {
                Col0 = vm.KhongGian ?? string.Empty,
                Col1 = vm.ThaiDo ?? string.Empty,
                Col2 = vm.ThucAn ?? string.Empty
            };

            // Load model and predict output
            var result = MLModel.Predict(sampleData);

            // Tính xác suất
            var positiveProbability = result.Score[0] * 100; // Kết quả xác suất của Hài lòng
            var negativeProbability = result.Score[1] * 100; //Kết quẳ xác suất của Không hfai lòng

            string ketQua;
            //if (positiveProbability > 80)
            //{
            //    ketQua = "Rất hài lòng";
            //}
            if (positiveProbability > negativeProbability)
            {
                ketQua = "Rất hài lòng";
            }
            else
            {
                ketQua = "Thất vọng";
            }

            _reviewService.AddReview(vm, ketQua == "Hài lòng" || ketQua == "Rất hài lòng");

            ViewBag.KetQua = ketQua;

            return View("Index");
        }

    }
}
