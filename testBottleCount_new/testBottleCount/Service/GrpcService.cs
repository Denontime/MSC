
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BottlePickModuleForWindows.Service
{
    public class GrpcService
    {

        private static ImageGreeter.ImageGreeterClient client;

        static GrpcService() {
            GrpcService.InitalGrpcChannel();
        }
        public static void InitalGrpcChannel() {
            try
            {
                //Channel channel = new Channel(settings.moduleModel.GrpcServerIP+":"+settings.moduleModel.GrpcServerPort, ChannelCredentials.Insecure);
                Channel channel = new Channel("10.0.50.31" + ":" + "5000", ChannelCredentials.Insecure);
                client = new ImageGreeter.ImageGreeterClient(channel);
            }
            catch (Exception)
            {
                throw;
            }
        }

        async public static Task<ObjDectionResult> InferenceObjectDetection(string imageData, string imageName)
        {
            try
            {
                //RequstImage request = new RequstImage() { Image = imageData, ImageName = imageName };
                //ObjDectionResult predictResponse;
                //predictResponse = await Task.Run(() => client.DetectImage(request));
                //return predictResponse;
                return null;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        
    }
}
