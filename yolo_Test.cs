
using System;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using SkiaSharp;
using YoloDotNet.Enums;
using YoloDotNet.Models;
using YoloDotNet;
using YoloDotNet.Extensions;
using SkiaSharp;
using OpenCvSharp;

namespace Yolo_Demo
{
    public partial class Form1 : Form
    {
        const String FILE_FILTER_IMAGE = "그림 파일 (*.jpg, *.gif, *.bmp, *.png, *.svd, *.webp) | *.jpg; *.gif; *.bmp; *.png; *.svd; *.webp; | 모든 파일 (*.*) | *.*";
        
        public void YoloOpen(String imgPath, ModelVersion modelVer, ModelType mediaType)
        {
            try
            {
                //String imgPath = ShowFileOpenDialog(FILE_FILTER_IMAGE);
                String model = "";

                // Initialize the YOLO model
                if (modelVer == ModelVersion.V8)
                {
                    switch(mediaType)
                    {
                        case ModelType.Classification:  
                            model = @"..\..\..\assets\Models\yolov8s-cls.onnx";
                            break;


                        case ModelType.ObjectDetection:
                            model = @"..\..\..\assets\Models\yolov8s.onnx";
                            break;

                        case ModelType.ObbDetection:
                            model = @"..\..\..\assets\Models\yolov8s-obb.onnx";
                            break;

                        case ModelType.Segmentation:
                            model = @"..\..\..\assets\Models\yolov8s-seg.onnx";
                            break;

                        case ModelType.PoseEstimation:
                            model = @"..\..\..\assets\Models\yolov8s-pose.onnx";
                            break;

                        default:
                            ERR($"Gave wrong media type...{mediaType}");
                            return;
                    }
                }
                else if(modelVer == ModelVersion.V10)
                {
                    model = @"..\..\..\assets\Models\yolov8s.onnx";
                }
                LOG($"Model onnx => {modelVer}, {model}, {mediaType}");

                // Instantiate a new Yolo object
                using var yolo = new Yolo(new YoloOptions
                {
                    //OnnxModel = @"..\..\..\assets\Models\yolov8s.onnx",      // Your Yolov8 or Yolov10 model in onnx format
                    OnnxModel = model,      // Your Yolov8 or Yolov10 model in onnx format
                    ModelType = mediaType,  // Model type
                    Cuda = false,                           // Use CPU or CUDA for GPU accelerated inference. Default = true
                    //GpuId = 0,                               // Select Gpu by id. Default = 0
                    PrimeGpu = false,                       // Pre-allocate GPU before first. Default = false
                });


                // Load image
                using var image = SKImage.FromEncodedData(imgPath);

                String saveImg = Path.GetDirectoryName(imgPath);
                String fileName = Path.GetFileName(imgPath);
                fileName = "converted_" + fileName;
                saveImg = Path.Combine(saveImg, fileName);

                SKImage resultImage = SKImage.Create(new SKImageInfo());

                // Run inference and get the results
                switch (mediaType)
                {
                    case ModelType.Classification:
                        resultImage = image.Draw(yolo.RunClassification(image, 1));
                        resultImage.Save(saveImg, SKEncodedImageFormat.Jpeg, 80);
                        break;


                    case ModelType.ObjectDetection:
                        resultImage = image.Draw(yolo.RunObjectDetection(image, confidence: 0.25, iou: 0.7));
                        resultImage.Save(saveImg, SKEncodedImageFormat.Jpeg, 80);
                        break;

                    case ModelType.ObbDetection:
                        resultImage = image.Draw(yolo.RunObbDetection(image));
                        resultImage.Save(saveImg, SKEncodedImageFormat.Jpeg, 80);
                        break;

                    case ModelType.Segmentation:
                        resultImage = image.Draw(yolo.RunSegmentation(image));
                        resultImage.Save(saveImg, SKEncodedImageFormat.Jpeg, 80);
                        break;

                    case ModelType.PoseEstimation:
                        resultImage = image.Draw(yolo.RunPoseEstimation(image), CustomKeyPointColorMap.KeyPointOptions);
                        resultImage.Save(saveImg, SKEncodedImageFormat.Jpeg, 80);
                        break;

                    default:
                        ERR($"Gave wrong media type...{mediaType}");
                        return;
                }

                pbSrc.Image = Bitmap.FromFile(imgPath);
                pbDst.Image = Bitmap.FromFile(saveImg);

                var src = new Mat(imgPath, ImreadModes.Unchanged);
                var dst = new Mat(saveImg, ImreadModes.Unchanged);
                Cv2.ImShow("Source image", src);
                Cv2.ImShow("Converted image", dst);
                Cv2.WaitKey(0);
                Cv2.DestroyAllWindows();
            }
            catch (Exception ex)
            {
                ERR(ex.ToString());
            }
        }

        public String ShowFileOpenDialog(String fileFilter)
        {
            try
            {
                //파일오픈창 생성 및 설정
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "이미지 열기";
                ofd.FileName = "image";
                ofd.Filter = fileFilter;
                ofd.InitialDirectory = Application.StartupPath; // 현재 실행파일 경로를 사용하도록 설정


                //파일 오픈창 로드
                DialogResult dr = ofd.ShowDialog();

                //OK버튼 클릭시
                if (dr == DialogResult.OK)
                {
                    //File명과 확장자를 가지고 온다.
                    String fileName = ofd.SafeFileName;
                    //File경로와 File명을 모두 가지고 온다.
                    String fileFullName = ofd.FileName;
                    //File경로만 가지고 온다.
                    String filePath = fileFullName.Replace(fileName, "");

                    //File경로 + 파일명 리턴
                    return fileFullName;
                }
                //취소버튼 클릭시 또는 ESC키로 파일창을 종료 했을경우
                else if (dr == DialogResult.Cancel)
                {
                    return "";
                }

                return "";
            }
            catch (Exception e)
            {
                ERR(e.ToString());
                return "";
            }
        }
    }
}