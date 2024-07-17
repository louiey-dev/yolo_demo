# Yolo Demo

## Test tool for Yolo v8/10
### Yolo C# refered https://github.com/NickSwardh/YoloDotNet

## Feature
- Video inference added
    - Added video feature but there happenning error while find outpur dir
    - Not yet solved
    - Fixed issue. Console.xxx API causes problems. Guess this is winform and console API looks causes issue.
    - Yolo read video file and removes audio data and converts video to png and looks sum all of png???


## TODO
- Cam streaming


### Development tool
- Visual Studio 2022
- C#
- Winform
- Package
    - YoloDotNet (2.0)
    - OpenCVSharp4 (4.10.0.20240616)
    - Microsoft.ML.OnnxRuntime (1.18.1)
    - SixLabors.ImageShart (3.1.4)

![Yolo Demo](./yolo_demo.png)
