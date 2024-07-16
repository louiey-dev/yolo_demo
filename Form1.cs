


using YoloDotNet.Enums;
using YoloDotNet.Models;

namespace Yolo_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYoloInit_Click(object sender, EventArgs e)
        {
            String imgPath = ShowFileOpenDialog(FILE_FILTER_IMAGE);
            ModelVersion mVer;
            ModelType mType;

            if (imgPath == "")
            {
                LOG("Please select image file\n");
                return;
            }

            if(RBGet(rbYoloVersionV8))
            {
                mVer = ModelVersion.V8;
            }
            else
            {
                mVer= ModelVersion.V10;
            }

            if(RBGet(rbYoloModelClassification))
            {
                mType = ModelType.Classification;
            }
            else if(RBGet(rbYoloModelObjectDetection))
            {
                mType = ModelType.ObjectDetection;
            }
            else if (RBGet(rbYoloModelObbDetection))
            {
                mType = ModelType.ObbDetection;
            }
            else if (RBGet(rbYoloModelSegmentation))
            {
                mType = ModelType.Segmentation;
            }
            else if (RBGet(rbYoloModelPoseEstimation))
            {
                mType = ModelType.PoseEstimation;
            }
            else
            {
                ERR($"Wrong model type selection\n");
                return;
            }


            if (imgPath != null)
            {
                YoloOpen(imgPath, mVer, mType);
            }
            else
            {
                ERR("Image file open error\n");
            }
        }

        private void rbYoloVersionV10_CheckedChanged(object sender, EventArgs e)
        {
            if (RBGet(rbYoloVersionV10) == true)
            {
                RBSet(rbYoloModelObjectDetection, true);

                RBControl(rbYoloModelClassification, false);
                RBControl(rbYoloModelObbDetection, false);
                RBControl(rbYoloModelSegmentation, false);
                RBControl(rbYoloModelPoseEstimation, false);
            }
        }

        private void rbYoloVersionV8_CheckedChanged(object sender, EventArgs e)
        {
            if (RBGet(rbYoloVersionV8) == true)
            {
                RBControl(rbYoloModelObjectDetection, true);
                RBControl(rbYoloModelClassification, true);
                RBControl(rbYoloModelObbDetection, true);
                RBControl(rbYoloModelSegmentation, true);
                RBControl(rbYoloModelPoseEstimation, true);
            }
        }
    }
}
